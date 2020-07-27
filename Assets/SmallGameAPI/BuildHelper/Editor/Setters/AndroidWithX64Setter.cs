using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace MiniGameSDK
{
#if UNITY_ANDROID
    public class AndroidWithX64Setter : IBuildValueSetter
    {
        public void SetData(Dictionary<string, string> data)
        {
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.iOS, ScriptingImplementation.IL2CPP);
            AndroidArchitecture aac = AndroidArchitecture.ARM64 | AndroidArchitecture.ARMv7;
            PlayerSettings.Android.targetArchitectures = aac;
        }
    }
#endif
}

