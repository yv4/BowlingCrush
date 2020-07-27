using System;
using UnityEngine;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Gift
{
    public class WarningUI : MonoBehaviour
    {
        public static WarningUI instance;

        public Button btnSubmit, BtnBack;

        void Awake()
        {
            instance = this;
        }

        public void Show(Action CloseCallback)
        {
            btnSubmit.onClick.RemoveAllListeners();
            btnSubmit.onClick.AddListener(() => { CloseCallback?.Invoke(); });

            // 调用关闭view回调方法
            BtnBack.onClick.RemoveAllListeners();
            BtnBack.onClick.AddListener(() => { CloseCallback?.Invoke(); });
        }
    }
}