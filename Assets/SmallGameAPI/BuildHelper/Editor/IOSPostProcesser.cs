using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
using System.IO;

public class IOSPostProcesser
{
    //public static string admobId;
    [PostProcessBuild(999)]
    public static void OnPostprocessBuild(BuildTarget BuildTarget, string path)
    {
        //Debug.Log(path);
        if (BuildTarget == BuildTarget.iOS)
        {
            UnityEngine.Debug.Log("XCodePostProcess: Starting to perform post build tasks for iOS platform.");

            /*======== projPath ========*/
            string projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";

            PBXProject proj = new PBXProject();
            proj.ReadFromFile(projPath);
#if UNITY_2019_3_OR_NEWER
            string target = proj.GetUnityFrameworkTargetGuid();
#else
            string target = proj.TargetGuidByName(PBXProject.GetUnityTargetName());
#endif
            // ENABLE_BITCODE=False
            //proj.SetBuildProperty(main, "CLANG_ENABLE_MODULES", "YES");
            proj.SetBuildProperty(target, "CLANG_ENABLE_MODULES", "YES");
            //Debug.Log(proj.AddFile($"{path}/Libraries/RegisterMonoModules.h", "Libraries/RegisterMonoModules.h", PBXSourceTree.Source));
            //proj.adf(target, proj.AddFile($"{path}/Libraries/RegisterMonoModules.h", "Libraries/RegisterMonoModules.h", PBXSourceTree.Source));
            File.WriteAllText(projPath, proj.WriteToString());



            string plistPath = path + "/Info.plist";
            PlistDocument plist = new PlistDocument();
            plist.ReadFromString(File.ReadAllText(plistPath));
            string admobId = PlayerPrefs.GetString(Application.identifier + "player_admob_id", "");
            // Get root
            PlistElementDict rootDict = plist.root;
            rootDict.SetString("NSLocationWhenInUseUsageDescription", "Use Location");
            rootDict.SetString("NSCalendarsUsageDescription", "Use Calendars");
            rootDict.SetString("GADApplicationIdentifier", admobId);
            rootDict.values.Remove("UIApplicationExitsOnSuspend");
            // Write to file
            File.WriteAllText(plistPath, plist.WriteToString());
        }

    }
}
