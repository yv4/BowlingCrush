using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using UnityEditor.Android;

public class SolveMuteDexErrorBuildProcessor : IPostGenerateGradleAndroidProject
{
    public int callbackOrder
    {
        // 同种插件的优先级
        get { return 999; }
    }
    public void OnPostGenerateGradleAndroidProject(string path)
    {

        Debug.Log("Bulid path : " + path);
#if UNITY_2020_1_OR_NEWER
        int d = path.LastIndexOf('\\')-1;
        string output = path.Substring(0, path.Length - d);
        Debug.Log(output);
        string grade = $"{output}\\launcher\\build.gradle";
#else
        string grade = $"{path}\\build.gradle";
#endif
        Debug.Log(grade);
        if (File.Exists(grade))
        {
            string txt = File.ReadAllText(grade);
            Debug.Log(txt);
            int idx = txt.IndexOf("defaultConfig {");
            Debug.Log(idx);
            txt = txt.Insert(idx + 15, "\nmultiDexEnabled true");
            Debug.Log(txt);
            File.Delete(grade);
            File.WriteAllText(grade, txt);
            Debug.Log("Add Line 'multiDexEnabled true' success");
        }

    }
}