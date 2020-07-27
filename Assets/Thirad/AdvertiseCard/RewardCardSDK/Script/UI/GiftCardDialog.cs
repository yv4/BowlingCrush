
using MobiiGame.Sdk.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MobiiGame.Sdk.Gift
{
    public class GiftCardDialog : BaseDialog
    {
        public static GiftCardDialog ins;

        public GameObject cardUI, submitUI, configUI, successUI, warningUI;

        public TipsUI tipsUI;

        public RankingListUI rankingListUI;

        protected override void Awake()
        {
            cardUI.SetActive(false);
            submitUI.SetActive(false);
            configUI.SetActive(false);
            successUI.SetActive(false);
            warningUI.SetActive(false);
            rankingListUI.gameObject.SetActive(false);
            tipsUI.gameObject.SetActive(false);
        }

        public static void showRankingList()
        {
            ins.rankingListUI.gameObject.SetActive(true);
        }

        public static void ShowTips(string message,int hideTime =2)
        {
            ins.tipsUI.Show(message, hideTime);
        }


        /// <summary>
        /// 游戏过程中弹出的获得现金奖励的弹窗
        /// </summary>
        /// <param name="GetBonusCallback">点领取按钮时的回调函数</param>
        public static void ShowCardDialog(Action GetBonusCallback = null, int viceModelId = 0)
        {
            //服务器没有数据的情况下不继续向下执行
            if (!RewardGiftSDK.CheckRewardDataSuccess())
            {
                return;
            }
            //主模块请求展示激励卡片，这个值就+1
            if (viceModelId<=0)
            {
                DataManager.CardProbabilityTimesOfTotal++;
            }

            if (RewardGiftSDK.Ins.IsShowRewardCard(viceModelId))
            {
                // 用户总的展示次数+1
                DataManager.CardShowTimesOfTotal++;

                var timeNow = DataManager.TimeNow;
                var dd = DataManager.GetDailyDataByDateNow();
                //当日激励卡展示次数+1
                dd.reward_count++;
                //储存当日数据
                DataManager.SaveDailyDataByDateTime(timeNow, dd);

                string giftCardDialogPath = "";
                switch (RewardGiftSDK.Ins.country)
                {
                    case Country.China:
                        giftCardDialogPath = "China/GiftCardDialog";
                        break;
                    case Country.Foreign:
                        giftCardDialogPath = "Foreign/GiftCardDialog";
                        break;
                }
                GiftCardDialog obj = Resources.Load<GiftCardDialog>(giftCardDialogPath);
                ins?.Close();
                ins = Instantiate(obj);
                ins.Show();

                ins.cardUI.SetActive(true);

                enumGiftCardType cardType = enumGiftCardType.Get_Money;
                if (viceModelId>0)
                {
                    if (RewardGiftSDK.Ins.GetViceModelIsLimitCap(viceModelId))
                    {
                        if (RewardGiftSDK.Ins.IsReachedLimit())
                        {
                            cardType = enumGiftCardType.Reach_Limited;
                        }
                    }
                }
                else
                {
                    if (RewardGiftSDK.Ins.IsReachedLimit())
                    {
                        cardType = enumGiftCardType.Reach_Limited;
                    }
                }

                GiftCardUI.instance.Show(cardType,
                    ()=>
                    {
                        GetBonusCallback?.Invoke();
                    }, 
                    () =>
                    {
                        ins.Close();
                    }, viceModelId);
            }
            else
            {
                EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.TaskBounceCoin);
            }
        }

        public override void Close()
        {
            base.Close();
            ins = null;
        }

        // 用户点击现金图标，弹出现金奖励详情，用户可以去提现
        public static void ShowCardDetailDialog()
        {
            string giftCardDialogPath = "";
            switch (RewardGiftSDK.Ins.country)
            {
                case Country.China:
                    giftCardDialogPath = "China/GiftCardDialog";
                    break;
                case Country.Foreign:
                    giftCardDialogPath = "Foreign/GiftCardDialog";
                    break;
            }
            GiftCardDialog obj = Resources.Load<GiftCardDialog>(giftCardDialogPath);
            ins = Instantiate(obj);
            ins.Show();

            if (DataManager.ShowWarningUI)
            {
                ins.ShowWarningUI();
                return;
            }

            // 如果用户提交的提现申请，则显示界面
            if (DataManager.HasSubmit)
            {
                // 如果已经提交到服务器
                if (DataManager.HasSubmitConfig)
                {
                    ins.ShowSubmitSuccessUI();
                }
                else
                {
                    // 未提交到服务，中途退出提现界面
                    ins.ShowSubmitUI();
                }
            }
            else
            {
                ins.cardUI.SetActive(true);


                GiftCardUI.instance.Show(enumGiftCardType.CashOut_Money, () =>
                {
                    ins.Close();
                },() =>
                {
                    ins.Close();
                });
            }
        }

        // 显示提现提交页面
        public void ShowSubmitUI()
        {
            cardUI.SetActive(false);
            submitUI.SetActive(true);

            SubmitUI.instance.Show(ins.Close, () =>
            {
                DataManager.HasSubmit = true;

                submitUI.SetActive(false);
                configUI.SetActive(true);

                SubmitConfigUI.instance.Show(() =>
                {
                    configUI.SetActive(false);
                    submitUI.SetActive(true);
                }, () =>
                {
                    // 提交数据到服务器，展示提交成功ui
                    RewardGiftSDK.Ins.SendWithDrawRequest(()=>
                    {
                        DataManager.HasSubmitConfig = true;

                        ins.ShowSubmitSuccessUI();
                    });
                    
                    //ins.Close();
                });
            });
        }

        public void ShowSubmitSuccessUI()
        {
            cardUI.SetActive(false);
            submitUI.SetActive(false);
            configUI.SetActive(false);

            successUI.SetActive(true);

            SubmitSuccessUI.instance.Show(ins.Close);
        }

        public void ShowWarningUI()
        {
            warningUI.SetActive(true);

            WarningUI.instance.Show(ins.Close);
        }
    }
}