using System;
using System.Collections;
using MobiiGame.Sdk.Base;
using MobiiGame.Sdk.Event;
using UnityEngine;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Gift
{
    public enum enumGiftCardType
    {
        Get_Money,      // 获取实时奖励，每一关完成后自动弹出
        CashOut_Money,  // 查看提现详情，用户主动点击money icon
        Reach_Limited,  // 激励卡片展示到达上限
    }

    /// <summary>
    /// 获取界面（正常领取、已达上限两个界面）
    /// 
    /// 获取界面中，数值表和次数上限都取自后台。（目前SDK的实现方式是每次打开游戏时都从后台拉取对应参数，且同步部分数据。）
    /// </summary>
    public class GiftCardUI : MonoBehaviour
    {
        public static GiftCardUI instance;

        public Text txtTotalMoney, txtTitle;

        public Button GetBonusBtn, BtnBack;
        public Text CongratulationText,CongratulationMoneyText, ReachLimitMoneyText, txtButton;

        public GameObject labelCashOut, Tip, Congratulation, ReachLimit, maskObj, moneyObj;
        public Text Tiptext;

        public Image imgTitle_Cash, imgTitle_Congratulations, imgTitle_Regret;
        public Sprite imgBtn_GetMoney, imgBtn_CashOut;
        public Button BtnRule;

        public Button BtnOpenRankingList;

        void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            BtnOpenRankingList.onClick.RemoveAllListeners();
            BtnOpenRankingList.onClick.AddListener(()=> {
                GiftCardDialog.ins.rankingListUI.gameObject.SetActive(true);
            });
        }

        public void RefreshFBLoginState()
        {
            if (!this.gameObject.activeSelf)
            {
                return;
            }
            //判断是否有登陆过FB，如果有用户id，则表示已经登陆过
            if (DataManager.FBIsLogin)
            {
                txtButton.text = "Cash Out";
            }
            else
            {
                txtButton.text = "FB Login";
            }
        }

        /// <summary>
        /// 当已获得金额+下次金额＞99.99，客户端不调用事件
        /// 当get bonus金额为0 ，客户端不调用事件
        /// 当在99.99时，同时也到达触发limit条件。此时按不触发事件处理，不弹出limit界面
        /// 当更改数值表后，已有用户的兼容更改数值后用户进入游戏，前端取用户已获得金额和次数。并根据新表的对应次数，继续发放对应金额。直至发生不触发事件
        /// </summary>
        public void Show(enumGiftCardType type, Action GetBonusCallback,Action CloseCallback, int viceModelId = 0)
        {
            Tip.SetActive(false);
            maskObj.SetActive(false);
            moneyObj.SetActive(true);
            BtnOpenRankingList.gameObject.SetActive(false);
            txtTitle.gameObject.SetActive(true);

            GetBonusBtn.onClick.RemoveAllListeners();
            GetBonusBtn.interactable = true;

            if (type == enumGiftCardType.Get_Money || type == enumGiftCardType.CashOut_Money)
            {
                Congratulation.SetActive(true);
                ReachLimit.SetActive(false);
            }
            else
            {
                Congratulation.SetActive(false);
                ReachLimit.SetActive(true);
            }

            // 已经获得的总奖励金额
            txtTotalMoney.text = "$ " + RewardGiftSDK.FormatMoney(DataManager.GoldCoin);

            switch (type)
            {
                case enumGiftCardType.Get_Money:

                    txtButton.text = "Collect";
                    //得到本次要增加的钱，用于显示到界面上，判断是主模块还是副模块
                    int rewardValue = viceModelId > 0 ? RewardGiftSDK.GetViceModelRewardValue(viceModelId) : RewardGiftSDK.Ins.GetMainRewardValue();
                    switch (RewardGiftSDK.Ins.country)
                    {
                        case Country.China:
                            txtTitle.text = "您获得了一个现金红包";
                            imgTitle_Cash.gameObject.SetActive(false);
                            imgTitle_Congratulations.gameObject.SetActive(true);
                            imgTitle_Regret.gameObject.SetActive(false);
                            BtnRule.gameObject.SetActive(false);
                            GetBonusBtn.image.sprite = imgBtn_GetMoney;
                            GetBonusBtn.gameObject.SetActive(true);
                            CongratulationMoneyText.text = "+ " + RewardGiftSDK.FormatMoney(rewardValue)+" 元";
                            //CongratulationMoneyText.rectTransform.DOAnchorPosY(200, 0);
                            CongratulationMoneyText.rectTransform.anchoredPosition = new Vector2(CongratulationMoneyText.rectTransform.anchoredPosition.x, 200);
                            moneyObj.SetActive(false);
                            CongratulationText.gameObject.SetActive(false);
                            break;
                        case Country.Foreign:
                            txtTitle.text = "CONGRATULATION";
                            CongratulationMoneyText.text = "+ $ " + RewardGiftSDK.FormatMoney(rewardValue);
                            labelCashOut.SetActive(false);
                            break;
                    }
                    GetBonusBtn.onClick.AddListener(() =>
                    {
                        GetBonusBtn.interactable = false;//防止用户多次点击，点击只能一次，就变成禁用
                        GetBonusCallback?.Invoke();
                        OnClick_GetBonusBtn(CloseCallback, viceModelId);
                    });

                    //副模块的领取次数需要看是否跟着主模块走
                    if (viceModelId>0)
                    {
                        //如果需要limit的话，则显示次数+1
                        if (RewardGiftSDK.Ins.GetViceModelIsLimitCap(viceModelId))
                        {
                            LogSdk.Log("副模块跟着主模块limit，展示次数+1");
                            // 用户当天的展示次数+1
                            DataManager.ShowTimesOfDay++;
                        }
                    }
                    else
                    {
                        //主模块直接++
                        // 用户当天的展示次数+1
                        DataManager.ShowTimesOfDay++;
                    }

                    break;

                case enumGiftCardType.CashOut_Money:

                    BtnOpenRankingList.gameObject.SetActive(true);

                    txtButton.text = "Cash Out";

                    switch (RewardGiftSDK.Ins.country)
                    {
                        case Country.China:
                            txtTitle.gameObject.SetActive(false);
                            txtTitle.text = "EARN CASH";
                            imgTitle_Cash.gameObject.SetActive(true);
                            imgTitle_Congratulations.gameObject.SetActive(false);
                            imgTitle_Regret.gameObject.SetActive(false);
                            BtnRule.gameObject.SetActive(true);
                            GetBonusBtn.image.sprite = imgBtn_CashOut;
                            GetBonusBtn.gameObject.SetActive(true);
                            CongratulationText.gameObject.SetActive(true);

                            GetBonusBtn.onClick.AddListener(() =>
                            {
                                //if (DataManager.GoldCoin >= 100f)
                                //{
                                //    GiftCardDialog.ins.ShowSubmitUI();
                                //}
                                //else
                                //{
                                //国内版本就不能提现，直接弹出提示
                                    StartCoroutine(ShowTip());
                                //}
                            });

                            CongratulationMoneyText.text = RewardGiftSDK.FormatMoney(DataManager.GoldCoin > 3000 ? 2999 : DataManager.GoldCoin) + " 元";
                            //CongratulationMoneyText.rectTransform.DOAnchorPosY(70.7f, 0);
                            CongratulationMoneyText.rectTransform.anchoredPosition = new Vector2(CongratulationMoneyText.rectTransform.anchoredPosition.x, 70.7f);
                            break;
                        case Country.Foreign:
                            txtTitle.text = "EARN CASH";
                            CongratulationMoneyText.text = "$ " + RewardGiftSDK.FormatMoney(DataManager.GoldCoin > 10000 ? 10000 : DataManager.GoldCoin);
                            labelCashOut.SetActive(true);

                            GetBonusBtn.onClick.AddListener(() =>
                            {
                                //当小于98提示不够100，当大于98，则按钮自动变成fb login，登陆后再点击如果还不大于等于100，继续提示不够100
                                if (DataManager.GoldCoin>=9800&& DataManager.GoldCoin<10000)
                                {
                                    //这里需要增加fb是否登录的判断，如果没有登录先登录
                                    if (!DataManager.FBIsLogin)
                                    {
                                        LogSdk.Log("login fb");
                                        RewardGiftSDK.Ins.FBLoginEvent?.Invoke();
                                    }
                                    else
                                    {
                                        StartCoroutine(ShowTip());
                                    }
                                }
                                else if (DataManager.GoldCoin >= 10000)
                                {
                                    //这里需要增加fb是否登录的判断，如果已经登录则可以提现，如果没有登录先登录
                                    if (DataManager.FBIsLogin)
                                    {
                                        GiftCardDialog.ins.ShowSubmitUI();
                                    }
                                    else
                                    {
                                        LogSdk.Log("login fb");
                                        RewardGiftSDK.Ins.FBLoginEvent?.Invoke();
                                    }
                                }
                                else
                                {
                                    StartCoroutine(ShowTip());
                                }
                            });

                            //如果可以提现了，则判断当前是否有登录fb，没有登录fb，按钮文字修改为登录fb
                            if (DataManager.GoldCoin >= 9800)
                            {
                                RefreshFBLoginState();
                            }
                            break;
                    }
                    CongratulationMoneyText.gameObject.SetActive(true);

                    moneyObj.SetActive(false);
                    maskObj.SetActive(true);

                    break;

                case enumGiftCardType.Reach_Limited:
                    switch (RewardGiftSDK.Ins.country)
                    {
                        case Country.China:
                            txtTitle.text = "您在今日已达领取上限\r\n请明日再来";
                            imgTitle_Cash.gameObject.SetActive(false);
                            imgTitle_Congratulations.gameObject.SetActive(false);
                            imgTitle_Regret.gameObject.SetActive(true);
                            BtnRule.gameObject.SetActive(false);
                            GetBonusBtn.gameObject.SetActive(false);
                            ReachLimitMoneyText.text = "距离微信提现100元仅差\r\n" + (100 - RewardGiftSDK.ConvertDollar(DataManager.GoldCoin)).ToString("F2") + "元";
                            CongratulationText.gameObject.SetActive(false);
                            moneyObj.SetActive(false);
                            break;
                        case Country.Foreign:
                            txtTitle.text = "REACHED LIMIT";
                            //GetBonusBtn.gameObject.SetActive(false);
                            break;
                    }

                    labelCashOut.SetActive(false);
                    txtButton.text = "Ok";

                    GetBonusBtn.onClick.AddListener(() =>
                    {
                        CloseCallback?.Invoke();
                        //GetBonusCallback?.Invoke();
                    });                    

                    break;
            }

            gameObject.SetActive(true);

            // 调用关闭view回调方法
            BtnBack.onClick.RemoveAllListeners();
            BtnBack.onClick.AddListener(() => { CloseCallback?.Invoke(); });
        }

        public void OnClick_GetBonusBtn(Action GetBonusCallback,int viceModelId = 0)
        {
            switch (RewardGiftSDK.Ins.country)
            {
                case Country.China:
                    GetBonusCallback?.Invoke();
                    break;
                case Country.Foreign:
                    float originCoin = RewardGiftSDK.ConvertDollar(DataManager.GoldCoin);
                    EventObserverMgr<float>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.AdvertiseCardDollar, originCoin);
                    if (viceModelId > 0)
                    {
                        RewardGiftSDK.GetViceModelReward(viceModelId);
                    }
                    else
                    {
                        RewardGiftSDK.GetReward();
                    }

                    //金币特效
                    this.GetComponent<UICurrencyCollect>().BoombToCollectCurrency(10);

                    // 现金动画(中国免动画)
                    float time = 5f;
                    float delay = 0.5f;
                    if (RewardGiftSDK.Ins.country == Country.China)
                    {
                        time = 0;
                        delay = 0;
                    }
                    StartCoroutine(DoFloatValueTween(originCoin, RewardGiftSDK.ConvertDollar(DataManager.GoldCoin), time, delay, () =>
                     {
                         Singleton<MUIEventManager>.Instance.DispatchUIEvent(enMUIEventID.Reward_Status_Change,
                             new MUIEventParams() { bool_param1 = true });

                         Timer.Schedule(this, 0.5f, () => { GetBonusCallback?.Invoke(); });
                     }));
                    break;
            }
        }

        /// <summary>
        /// 数字动画（剥离dotween插件）
        /// </summary>
        /// <param name="min">当前值</param>
        /// <param name="max">目标值</param>
        /// <param name="change_speed">变换速度</param>
        /// <param name="action">变换完成后的事件</param>
        /// <returns></returns>
        IEnumerator DoFloatValueTween(float min, float max, float change_speed,float delay,Action action)
        {
            yield return new WaitForSeconds(delay);     //每 0.1s 加一次
            float delta = (max - min) / change_speed;   //delta为一个常数，每次加的数大小

            float result = min;

            for (int i = 0; i < change_speed; i++)
            {
                result += delta;
                txtTotalMoney.text = "$ " + string.Format("{0:N2}", result);
                yield return new WaitForSeconds(0.1f);     //每 0.1s 加一次
            }
            txtTotalMoney.text = "$ " + string.Format("{0:N2}", max);
            StopCoroutine(DoFloatValueTween(max,min,change_speed, delay,action));
            action?.Invoke();
        }

        //public Tween DoFloatValueTween(float from, float to,float time)
        //{
        //    float v = from;
        //    Tween t = DOTween.To(() => v, x => v = x, to, time);
        //    t.OnUpdate(() =>
        //    {
        //        txtTotalMoney.text = "$ " + string.Format("{0:N2}", v);
        //    });
        //    return t;
        //}

        IEnumerator ShowTip()
        {
            switch (RewardGiftSDK.Ins.country)
            {
                case Country.China:
                    Tiptext.text = "余额不足，满30即可提现。";
                    break;
                case Country.Foreign:
                    Tiptext.text = "Not enough $100, Play and Earn $" + (100f - RewardGiftSDK.ConvertDollar(DataManager.GoldCoin)) + " or more";
                    break;
            }

            Tip.gameObject.SetActive(true);

            yield return new WaitForSeconds(2);

            Tip.gameObject.SetActive(false);
        }
    }
}