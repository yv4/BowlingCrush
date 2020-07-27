using System;
using System.Collections;
using System.Text.RegularExpressions;
using MobiiGame.Sdk.Base;
using UnityEngine;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Gift
{

    /// <summary>
    /// 获取界面（正常领取、已达上限两个界面）
    /// 
    /// 获取界面中，数值表和次数上限都取自后台。（目前SDK的实现方式是每次打开游戏时都从后台拉取对应参数，且同步部分数据。）
    /// </summary>
    public class SubmitUI : MonoBehaviour
    {
        public static SubmitUI instance;

        public Text txtEmail, txtPaypal;

        public Button btnSubmit, BtnBack;

        public GameObject Tip;
        public Text Tiptext;

        void Awake()
        {
            instance = this;
        }

        public void Show(Action BackCallback, Action SubmitCallback)
        {
            Tip.SetActive(false);

            btnSubmit.onClick.RemoveAllListeners();
            btnSubmit.onClick.AddListener(()=> { OnClick_SubmitBtn(SubmitCallback); });


            // 调用关闭view回调方法
            BtnBack.onClick.RemoveAllListeners();
            BtnBack.onClick.AddListener(() => { BackCallback?.Invoke(); });
        }

        public void OnClick_SubmitBtn(Action callback)
        {
            string email = txtEmail.text.Trim();
            string paypal = txtPaypal.text.Trim();

            LogSdk.Log("email=" + email + ",paypal=" + paypal);

            //如果为空，认为验证不合格
            if (string.IsNullOrEmpty(email))
            {
                StartCoroutine(ShowTip("Please fill in the mail"));
                return;
            }

            if (!IsEmail(email))
            {
                StartCoroutine(ShowTip("Wrong email, please refill in"));
                return;
            }

            if (string.IsNullOrEmpty(paypal))
            {
                StartCoroutine(ShowTip("Please fill in the paypal account"));
                return;
            }

            DataManager.Email = email;
            DataManager.Paypal = paypal;

            callback?.Invoke();
        }

        IEnumerator ShowTip(string msg)
        {
            Tiptext.text = msg;

            Tip.gameObject.SetActive(true);

            yield return new WaitForSeconds(2);

            Tip.gameObject.SetActive(false);
        }

        public static bool IsEmail(string email)
        {
            //模式字符串
            string pattern = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";

            pattern = "([a-zA-Z0-9_\\.\\-])+\\@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9]{2,5})+";

            //Regex reg = new Regex(pattern);
            Regex.IsMatch(email, pattern);

            //验证ss
            return Regex.IsMatch(email, pattern);
        }
    }
}