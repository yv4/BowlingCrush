using System.Collections;
using System.Collections.Generic;
using Umeng;
using UnityEngine;
namespace MiniGameSDK
{
    public class UMIniter : MonoBehaviour, IAnalyzeEvent,ISDKInitor
    {
        public string key = "";
        public bool enableLog;

        public string paramName => "Umeng App key";

        // Start is called before the first frame update
        void Awake()
        {
            Debug.Log("Error UM");
            GA.StartWithAppKeyAndChannelId(key, "umeng");
            GA.SetLogEnabled(enableLog);
            APIProvider.Provide<IAnalyzeEvent>(this);
        }
        public void SetEvent(string key)
        {
            GA.Event(key);
        }
        public void SetEvent(string key, Dictionary<string, string> value)
        {
            GA.Event(key, value);
        }

        public void SetParam(params string[] param)
        {
            key = param[0];
        }
    }
}

