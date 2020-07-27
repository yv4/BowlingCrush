using System.Collections.Generic;
using UnityEditor;
namespace MiniGameSDK
{
    public class EditorSettingSettor : IBuildValueSetter
    {
        public void SetData(Dictionary<string, string> data)
        {
            PlayerSettings.productName = data["游戏名称"];
            BuildTargetGroup targetGroup = BuildTargetGroup.Unknown;
#if UNITY_ANDROID
            targetGroup = BuildTargetGroup.Android;
#elif UNITY_IOS
            targetGroup = BuildTargetGroup.iOS;
#endif
            PlayerSettings.SetApplicationIdentifier(targetGroup, data["包名"]);
        }
    }
}

