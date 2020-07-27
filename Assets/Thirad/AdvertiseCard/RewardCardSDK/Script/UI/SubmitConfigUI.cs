using System;
using UnityEngine;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Gift
{
    public class SubmitConfigUI : MonoBehaviour
    {
        public static SubmitConfigUI instance;

        public Text txtEmail, txtPaypal;
        public Button btnBack, btnOk;

        void Awake()
        {
            instance = this;
        }

        public void Show(Action backCallback, Action okCallback)
        {
            txtEmail.text = DataManager.Email;
            txtPaypal.text = DataManager.Paypal;

            btnOk.onClick.RemoveAllListeners();
            btnOk.onClick.AddListener(()=> { okCallback?.Invoke(); });

            // 调用关闭view回调方法
            btnBack.onClick.RemoveAllListeners();
            btnBack.onClick.AddListener(() => { backCallback?.Invoke(); });
        }
    }
}