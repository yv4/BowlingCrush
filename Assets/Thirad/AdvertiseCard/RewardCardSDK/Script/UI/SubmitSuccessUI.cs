using System;
using UnityEngine;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Gift
{
    public class SubmitSuccessUI : MonoBehaviour
    {
        public static SubmitSuccessUI instance;

        public Text txtEmail;

        public Button btnSubmit, BtnBack;

        void Awake()
        {
            instance = this;
        }

        public void Show(Action CloseCallback)
        {
            txtEmail.text = "If you meet any problems, feel free to contact us via: " + RewardGiftSDK.Ins.GetServiceEmail();

            btnSubmit.onClick.RemoveAllListeners();
            btnSubmit.onClick.AddListener(() => { CloseCallback?.Invoke(); });

            // 调用关闭view回调方法
            BtnBack.onClick.RemoveAllListeners();
            BtnBack.onClick.AddListener(() => { CloseCallback?.Invoke(); });
        }
    }
}