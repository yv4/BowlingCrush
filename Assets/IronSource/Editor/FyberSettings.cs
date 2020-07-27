#if UNITY_IPHONE 
using UnityEngine;
using UnityEditor;
using UnityEditor.iOS.Xcode;
using System.IO;

namespace IronSource.Editor
{
	// Fyber is an empty adapter.
	// These files should be added manually:

	// iOS:
		// IASDKCore.framework 
		// IASDKMRAID.framework
		// IASDKResources.bundle
		// IASDKVideo.framework

	// Android: 
		// ia-mraid-kit-release-7.1.3.aar
		// ia-sdk-core-release-7.1.3.aar
		// ia-video-kit-release-7.1.3.aar


	public class FyberSettings : IAdapterSettings
	{
		public void updateProject (BuildTarget buildTarget, string projectPath)
		{
			Debug.Log ("IronSource - Update project for Fyber");

			PBXProject project = new PBXProject ();
			project.ReadFromString (File.ReadAllText (projectPath));

			string targetId = project.TargetGuidByName (PBXProject.GetUnityTargetName ());

			project.AddFrameworkToProject (targetId, "SystemConfiguration.framework", false);
			project.AddFrameworkToProject (targetId, "CoreGraphics.framework", false);
			project.AddFrameworkToProject (targetId, "EventKit.framework", false);
			project.AddFrameworkToProject (targetId, "EventKitUI.framework", false);
			project.AddFrameworkToProject (targetId, "MediaPlayer.framework", false);
			project.AddFrameworkToProject (targetId, "MessageUI.framework", false);
			project.AddFrameworkToProject (targetId, "CoreTelephony.framework", false);
			project.AddFrameworkToProject (targetId, "StoreKit.framework", false);
			project.AddFrameworkToProject (targetId, "AdSupport.framework", false);
			project.AddFrameworkToProject (targetId, "AVFoundation.framework", false);
			project.AddFrameworkToProject (targetId, "CoreMedia.framework", false);
			project.AddFrameworkToProject (targetId, "WebKit.framework", false);
			project.AddFrameworkToProject (targetId, "UIKit.framework", false);
			project.AddFrameworkToProject (targetId, "Foundation.framework", false);

            project.AddFileToBuild (targetId, project.AddFile ("usr/lib/libxml2.2.tbd", "Frameworks/libxml2.2.tbd", PBXSourceTree.Sdk));
			File.WriteAllText (projectPath, project.WriteToString ());
		}

		public void updateProjectPlist (BuildTarget buildTarget, string plistPath)
		{
			Debug.Log ("IronSource - Update plist for Fyber");
		}
	}
}
#endif
