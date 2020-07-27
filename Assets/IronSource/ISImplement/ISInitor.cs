using UnityEngine;
using System.Collections;
namespace MiniGameSDK
{
    public class ISInitor : MonoBehaviour,ISDKInitor
    {
        //public string uniqueUserId = "demoUserUnity";
        public string appKey = "a9eb3e4d";
        public bool debug;

        public string paramName => "Ironsource key";

        // Use this for initialization
        void Start()
        {
            Debug.Log("unity-script: ISInitor Start called");
            //Dynamic config example
            IronSourceConfig.Instance.setClientSideCallbacks(true);
            if (debug)
            {
                IronSource.Agent.validateIntegration();
                IronSource.Agent.setAdaptersDebug(true);
            }

            // SDK init
            Debug.Log("unity-script: IronSource.Agent.init");
            IronSource.Agent.init(appKey);
        }

        void OnApplicationPause(bool isPaused)
        {
            Debug.Log("unity-script: OnApplicationPause = " + isPaused);
            IronSource.Agent.onApplicationPause(isPaused);
        }

        public void SetParam(params string[] param)
        {
            appKey = param[0];
        }
    }
}

