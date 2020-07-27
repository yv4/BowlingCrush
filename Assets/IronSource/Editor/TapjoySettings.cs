#if UNITY_IPHONE 
using UnityEngine;
using UnityEditor;
using UnityEditor.iOS.Xcode;
using System.IO;

namespace IronSource.Editor
{
	public class TapjoySettings : IAdapterSettings
	{
		public void updateProject (BuildTarget buildTarget, string projectPath)
		{
			Debug.Log ("IronSource - Update project for Tapjoy");

			PBXProject project = new PBXProject ();
			project.ReadFromString (File.ReadAllText (projectPath));

			string targetId = project.TargetGuidByName (PBXProject.GetUnityTargetName ());

			// Required System Frameworks
			project.AddFrameworkToProject (targetId, "CoreData.framework", false);
			project.AddFrameworkToProject (targetId, "CoreMotion.framework", false);
			project.AddFrameworkToProject (targetId, "MapKit.framework", false);
			project.AddFrameworkToProject (targetId, "MediaPlayer.framework", false);
			project.AddFrameworkToProject (targetId, "MessageUI.framework", false); //Not required for SDK 11.9 and higher
			project.AddFrameworkToProject (targetId, "UIKit.framework", false);

			project.AddFileToBuild (targetId, project.AddFile ("usr/lib/libsqlite3.0.tbd", "Frameworks/libsqlite3.0.tbd", PBXSourceTree.Sdk));
			project.AddFileToBuild (targetId, project.AddFile ("usr/lib/libxml2.tbd", "Frameworks/libxml2.tbd", PBXSourceTree.Sdk));
			project.AddFileToBuild (targetId, project.AddFile ("usr/lib/libz.tbd", "Frameworks/libz.tbd", PBXSourceTree.Sdk));
			project.AddFileToBuild (targetId, project.AddFile ("usr/lib/libc++.tbd", "Frameworks/libc++.tbd", PBXSourceTree.Sdk));

			// Optional Frameworks
			project.AddFrameworkToProject (targetId, "PassKit.framework", true);
			project.AddFrameworkToProject (targetId, "Social.framework", true);
		
			File.WriteAllText (projectPath, project.WriteToString ());
		}

		public void updateProjectPlist (BuildTarget buildTarget, string plistPath)
		{
			Debug.Log ("IronSource - Update plist for Tapjoy");
		}
	}
}
#endif