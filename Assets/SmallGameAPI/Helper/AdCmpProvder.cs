using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK
{
    public class AdCmpProvder : MonoBehaviour
    {
        private void Awake()
        {
            APIProvider.Provide(GetComponent<IRewardAdAPI>());
            APIProvider.Provide(GetComponent<IInterstitialAdAPI>());
        }
    }
}

