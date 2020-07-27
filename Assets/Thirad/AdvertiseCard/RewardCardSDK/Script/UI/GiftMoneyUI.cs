using System.Collections;
using System.Collections.Generic;
using MobiiGame.Sdk.Base;
using MobiiGame.Sdk.Event;
using UnityEngine;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Gift
{
    public class GiftMoneyUI : MonoBehaviour
    {
        public static GiftMoneyUI instance;

        public GameObject moneyObj;
        public Text txtMoney;
        public Button BtnMoney, btnWarning;

        private bool isShowMoney;

        void Awake()
        {
            if (DataManager.InitComplete)
            {
                return;
            }
            instance = this;

            Singleton<MUIEventManager>.Instance.AddUIEventListener(enMUIEventID.Reward_Status_Change, ShowMoney);

            if (BtnMoney != null)
            {
                //BtnMoney.onClick.RemoveAllListeners();
                BtnMoney.onClick.AddListener(() =>
                {
                    GiftCardDialog.ShowCardDetailDialog();
                });
            }

            gameObject.SetActive(false);
        }

        void Start()
        {
            if (DataManager.InitComplete)
            {
                return;
            }
            if (DataManager.ShowWarningUI)
            {
                Timer.Schedule(this, 0.5f, () => { GiftCardDialog.ShowCardDetailDialog(); });
                
            }
        }

        private void OnDestroy()
        {
            Singleton<MUIEventManager>.Instance.RemoveUIEventListener(enMUIEventID.Reward_Status_Change, ShowMoney);
        }

        private void OnEnable()
        {
            UpdateStatus();
        }

        void UpdateStatus()
        {
            if (DataManager.ShowWarningUI)
            {
                moneyObj.SetActive(false);

                btnWarning.gameObject.SetActive(true);

                btnWarning.onClick.RemoveAllListeners();
                btnWarning.onClick.AddListener(() =>
                {
                    GiftCardDialog.ShowCardDetailDialog();
                });                
            }
            else
            {
                if (btnWarning!=null)
                {
                    btnWarning.gameObject.SetActive(false);
                    moneyObj.SetActive(true);

                    UpdateCoin();
                }
                
            }
        }

        private void ShowMoney(MUIEvent hUIEvent)
        {
            //LogSdk.Log("GiftMoneyUI >> ShowMoney >> " + isShowMoney);

            UpdateCoin();

            if (hUIEvent.m_eventID == enMUIEventID.Reward_Status_Change)
            {                
                isShowMoney = hUIEvent.m_eventParams.bool_param1;
                gameObject.SetActive(isShowMoney);
            }

            // 
            UpdateStatus();
        }

        public static string FormatMoney(float value)
        {
            return string.Format("{0:N2}", value);
        }

        // Update is called once per frame
        public void UpdateCoin()
        {
            if (DataManager.GoldCoin > 10000)
            {
                DataManager.GoldCoin = 10000;
            }

            if (txtMoney != null)
            {
                txtMoney.text = "$" + RewardGiftSDK.FormatMoney(DataManager.GoldCoin);
            }

            //LogSdk.Log("GiftMoneyUI >> UpdateCoin >> coin=" + ConvertDollar(DataManager.GoldCoin));
        }
        public void ShowMoneyUI(bool show = true)
        {
            if (show)
            {
                transform.localScale = Vector3.one;
            }
            else
            {
                transform.localScale = Vector3.zero;
            }
        }

        public void DragMoneyUI(bool drag = true)
        {
            var dragui = transform.GetOrAddComponent<DragUI>();
            dragui.enabled = drag;
        }
    }
}