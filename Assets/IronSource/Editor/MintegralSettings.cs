#if UNITY_IPHONE 
using UnityEngine;
using UnityEditor;
using UnityEditor.iOS.Xcode;
using System.IO;

namespace IronSource.Editor
{
	public class MintegralSettings : IAdapterSettings
	{
		public void updateProject (BuildTarget buildTarget, string projectPath)
		{
			Debug.Log ("IronSource - Update project for Mintegral");

			PBXProject project = new PBXProject ();
			project.ReadFromString (File.ReadAllText (projectPath));

			string targetId = project.TargetGuidByName (PBXProject.GetUnityTargetName ());

			// Required System Frameworks
			project.AddFrameworkToProject (targetId, "CoreGraphics.framework", false);
			project.AddFrameworkToProject (targetId, "Foundation.framework", false);
			project.AddFrameworkToProject (targetId, "UIKit.framework", false);
			project.AddFrameworkToProject (targetId, "AdSupport.framework", false);
			project.AddFrameworkToProject (targetId, "StoreKit.framework", false);
			project.AddFrameworkToProject (targetId, "QuartzCore.framework", false);
			project.AddFrameworkToProject (targetId, "CoreTelephony.framework", false);
			project.AddFrameworkToProject (targetId, "MobileCoreServices.framework", false);
			project.AddFrameworkToProject (targetId, "Accelerate.framework", false);
			project.AddFrameworkToProject (targetId, "AVFoundation.framework", false);
			project.AddFrameworkToProject (targetId, "WebKit.framework", false);

			project.AddFileToBuild (targetId, project.AddFile ("usr/lib/libsqlite3.tbd", "Frameworks/libsqlite3.tbd", PBXSourceTree.Sdk));
			project.AddFileToBuild (targetId, project.AddFile ("usr/lib/libz.tbd", "Frameworks/libz.tbd", PBXSourceTree.Sdk));

			File.WriteAllText (projectPath, project.WriteToString ());
		}

		public void updateProjectPlist (BuildTarget buildTarget, string plistPath)
		{
			Debug.Log ("IronSource - Update plist for Mintegral");
		}
	}
}
#endif
