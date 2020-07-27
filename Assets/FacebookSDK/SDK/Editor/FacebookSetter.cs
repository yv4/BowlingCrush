using Facebook.Unity.Editor;
using Facebook.Unity.Settings;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK
{
    public class FacebookSetter : IBuildValueSetter
    {
        public void SetData(Dictionary<string, string> data)
        {
            FacebookSettings.AppIds[0] = data["Facebook AppID"];
            ManifestMod.GenerateManifest();
            EditorSaveHelper.SaveAssets(FacebookSettings.Instance);
        }
    }
}
