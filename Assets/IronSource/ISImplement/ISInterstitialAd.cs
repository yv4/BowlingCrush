using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
enum InterstitialRes
{
    Rewarded, Closed
}
namespace MiniGameSDK
{
    [AdAPIAutoLoad(typeof(ISInitor))]
    class ISInterstitialAd : MonoBehaviour, IInterstitialAdAPI
    {
        //public Action onNormalClosed = null;
        //public Action<InterstitialRes> onClosed = null;
        //public Action onShow = null;

        public Action<bool> onClose { get; set ; }

        public bool isReady()
        {
            return IronSource.Agent.isInterstitialReady();
        }
        public void Show()
        {
            _show();
        }
        private void _show()
        {
            Debug.Log($"isInterstitialReady::{IronSource.Agent.isInterstitialReady()}");
            if (IronSource.Agent.isInterstitialReady())
                IronSource.Agent.showInterstitial();
            else
            {
                IronSource.Agent.loadInterstitial();
                StartCoroutine(ShowAd());
            }
            //onShow?.Invoke();
        }
        IEnumerator ShowAd()
        {
            int i = 0;
            while (!IronSource.Agent.isInterstitialReady())
            {
                yield return new WaitForEndOfFrame();
                i++;
                if (i >= 300)
                    yield break;
            }
            IronSource.Agent.showInterstitial();
        }
        void Awake()
        {
            IronSourceEvents.onInterstitialAdReadyEvent += InterstitialAdReadyEvent;
            IronSourceEvents.onInterstitialAdLoadFailedEvent += InterstitialAdLoadFailedEvent;
            IronSourceEvents.onInterstitialAdShowSucceededEvent += InterstitialAdShowSucceededEvent;
            IronSourceEvents.onInterstitialAdShowFailedEvent += InterstitialAdShowFailedEvent;
            IronSourceEvents.onInterstitialAdClickedEvent += InterstitialAdClickedEvent;
            IronSourceEvents.onInterstitialAdOpenedEvent += InterstitialAdOpenedEvent;
            IronSourceEvents.onInterstitialAdClosedEvent += InterstitialAdClosedEvent;
            IronSourceEvents.onInterstitialAdRewardedEvent += InterstitialAdRewardedEvent;
        }
        private void Start()
        {
            StartCoroutine(wait());
        }
        IEnumerator wait()
        {
            yield return new WaitForSeconds(1);
            IronSource.Agent.loadInterstitial();
        }
        void InterstitialAdReadyEvent()
        {
            //value.isShowed = false;
            //IronSource.Agent.showInterstitial();
            Debug.Log("unity-script: I got InterstitialAdReadyEvent");
        }

        void InterstitialAdLoadFailedEvent(IronSourceError error)
        {
            Debug.Log("unity-script: I got InterstitialAdLoadFailedEvent, code: " + error.getCode() + ", description : " + error.getDescription());
        }

        void InterstitialAdShowSucceededEvent()
        {
            Debug.Log("unity-script: I got InterstitialAdShowSucceededEvent");
        }

        void InterstitialAdShowFailedEvent(IronSourceError error)
        {
            Debug.Log("unity-script: I got InterstitialAdShowFailedEvent, code :  " + error.getCode() + ", description : " + error.getDescription());
        }

        void InterstitialAdClickedEvent()
        {
            AppsFlyerSDK.AppsFlyer.sendEvent("InterstitialAdClickedEvent", null);
            Debug.Log("unity-script: I got InterstitialAdClickedEvent");
        }

        void InterstitialAdOpenedEvent()
        {
            Debug.Log("unity-script: I got InterstitialAdOpenedEvent");
        }

        void InterstitialAdClosedEvent()
        {
            onClose?.Invoke(false);
            //onNormalClosed?.Invoke();
            //onClosed?.Invoke(InterstitialRes.Closed);
            IronSource.Agent.loadInterstitial();
            Debug.Log("unity-script: I got InterstitialAdClosedEvent");
        }

        void InterstitialAdRewardedEvent()
        {
            onClose?.Invoke(true);
            //onClosed?.Invoke(InterstitialRes.Rewarded);
            Debug.Log("unity-script: I got InterstitialAdRewardedEvent");
        }
    }
}
