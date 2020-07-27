using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MiniGameSDK
{
    [AdAPIAutoLoad(typeof(ISInitor))]
    class ISRewardAd : MonoBehaviour,IRewardAdAPI
    {
        public bool notUseAd=false;
#if UNITY_IOS
        public bool autoPauseGame = true;
#endif
        public bool isNotUseAd { get => notUseAd; set => notUseAd = value; }
        public Action onNormalClosed = null;
        Action<bool> _onClose = null;
        public Action onShow = null;
        bool isReward = true;
        float oldScale;
        public Action<bool> onClose
        {
            set => _onClose = value;
        }

        public void Show()
        {
            isReward = false;
#if UNITY_IOS
            if (autoPauseGame && isReady())
            {
                oldScale = Time.timeScale;
                Time.timeScale = 0;
            }
#endif
            onShow?.Invoke();
            if (notUseAd)
            {
                onAdClose(true);
            }
            else
            {
                IronSource.Agent.showRewardedVideo();
            }
        }
        public void AutoShow(Action<bool> onclose)
        {
            onClose = onclose;
            Show();
        }
        public bool isReady()
        {
            return notUseAd || IronSource.Agent.isRewardedVideoAvailable();
        }
        void onAdClose(bool isEnd)
        {
#if UNITY_IOS
            if (autoPauseGame)
            {
                Time.timeScale = oldScale;
            }
#endif
            _onClose?.Invoke(isEnd);
        }
        protected void Awake()
        {
            IronSourceEvents.onRewardedVideoAdOpenedEvent += RewardedVideoAdOpenedEvent;
            IronSourceEvents.onRewardedVideoAdClosedEvent += RewardedVideoAdClosedEvent;
            IronSourceEvents.onRewardedVideoAvailabilityChangedEvent += RewardedVideoAvailabilityChangedEvent;
            IronSourceEvents.onRewardedVideoAdStartedEvent += RewardedVideoAdStartedEvent;
            IronSourceEvents.onRewardedVideoAdEndedEvent += RewardedVideoAdEndedEvent;
            IronSourceEvents.onRewardedVideoAdRewardedEvent += RewardedVideoAdRewardedEvent;
            IronSourceEvents.onRewardedVideoAdShowFailedEvent += RewardedVideoAdShowFailedEvent;
            IronSourceEvents.onRewardedVideoAdClickedEvent += RewardedVideoAdClickedEvent;
        }
        void RewardedVideoAvailabilityChangedEvent(bool canShowAd)
        {
            Debug.Log("unity-script: I got RewardedVideoAvailabilityChangedEvent, value = " + canShowAd);
        }

        void RewardedVideoAdOpenedEvent()
        {
            Debug.Log("unity-script: I got RewardedVideoAdOpenedEvent");
        }

        void RewardedVideoAdRewardedEvent(IronSourcePlacement ssp)
        {
            isReward = ssp.getRewardAmount() > 0;
            //_onClose?.Invoke(ssp.getRewardAmount() > 0);
            Debug.Log("unity-script: I got RewardedVideoAdRewardedEvent, amount = " + ssp.getRewardAmount() + " name = " + ssp.getRewardName());

        }

        void RewardedVideoAdClosedEvent()
        {
            onAdClose(isReward);
            Debug.Log("unity-script: I got RewardedVideoAdClosedEvent"+" isReward "+ isReward);
        }

        void RewardedVideoAdStartedEvent()
        {
            Debug.Log("unity-script: I got RewardedVideoAdStartedEvent");
        }

        void RewardedVideoAdEndedEvent()
        {
            Debug.Log("unity-script: I got RewardedVideoAdEndedEvent");
        }

        void RewardedVideoAdShowFailedEvent(IronSourceError error)
        {
            Debug.Log("unity-script: I got RewardedVideoAdShowFailedEvent, code :  " + error.getCode() + ", description : " + error.getDescription());
        }

        void RewardedVideoAdClickedEvent(IronSourcePlacement ssp)
        {
            AppsFlyerSDK.AppsFlyer.sendEvent("RewardedVideoAdClickedEvent", null);
            Debug.Log("unity-script: I got RewardedVideoAdClickedEvent, name = " + ssp.getRewardName());
        }

    }
}
