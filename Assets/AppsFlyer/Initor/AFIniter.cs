using AppsFlyerSDK;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK
{
    public class AFIniter : MonoBehaviour,ISDKInitor
    {
        public string key = "xZFBAQhQSvHdzbGeMgzozU";
        public bool debug;

        public string paramName => "Appsflyer Dev key";
#if UNITY_IOS
    public string appid = "1495039197";
#endif
        // Start is called before the first frame update
        void Awake()
        {
            /* Mandatory - set your AppsFlyer’s Developer key. */
            //AppsFlyer.setAppsFlyerKey(key);

            /* For detailed logging */
            AppsFlyer.setIsDebug(debug);
#if UNITY_IOS
            AppsFlyer.initSDK(key, appid);
#elif UNITY_ANDROID
            /* Mandatory - set your Android package name */
            //AppsFlyer.setCollectIMEI(true);
            //AppsFlyer.setCollectAndroidID(true);

            //AppsFlyer.setAppID("com.cutit.fruitmaster.ninja");
            /* For getting the conversion data in Android, you need to add the "AppsFlyerTrackerCallbacks" listener.*/
            AppsFlyer.initSDK(key,null);
           
#endif
            AppsFlyer.startSDK();
            StartCoroutine(Wait());
            //if(debug)
            //StartCoroutine(Test());
            //AppsFlyer.trackRichEvent()
        }
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(2);
            //AppsFlyer.trackRichEvent("day_test_test_test", null);
            TJ();
        }
        IEnumerator Test()
        {
            for (int i = 0; i < 50; i++)
            {
                yield return new WaitForSeconds(1);
                AppsFlyer.sendEvent($"Test_{i}", new Dictionary<string, string>());
            }
        }
        private void TJ()
        {
            int x = PlayerPrefs.GetInt($"{Application.identifier}_day", -1);
            if (x == -1)
            {
                x = DateTime.Now.DayOfYear;
                PlayerPrefs.SetInt($"{Application.identifier}_day", x);
            }
            int diff = DateTime.Now.DayOfYear - x;
            //Debug.Log(diff);
            switch (diff)
            {
                case 1:
                case 2:
                case 6:
                    string key = $"{Application.identifier}_day_{diff + 1}";
                    if (!PlayerPrefs.HasKey(key))
                    {
                        AppsFlyer.sendEvent(key, new Dictionary<string, string>());
                        PlayerPrefs.SetInt(key, 0);
                        //Debug.Log(key);
                    }
                    break;
            }
        }

        public void SetParam(params string[] param)
        {
            key = param[0];
#if UNITY_IOS
            appid = param[1];
#endif
        }
    }
}

