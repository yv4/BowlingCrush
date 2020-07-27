using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MiniGameSDK
{
    public interface IAPI { }
    public interface IAdAPI: IAPI
    {
        bool isReady();
        void Show();
    }
    public interface IRewardAdAPI: IAdAPI
    {
        bool isNotUseAd { get; set; }
        Action<bool> onClose { set; }
        void AutoShow(Action<bool> onclose);
    }
   
}

