using System;
using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;

public class GameFinishWindow : UIOpenWindowsBase
{

    #region 成员变量

    #region 按钮相关

    protected Button m_DoneBut;
    protected Button m_NoThanksBut;

    #endregion

    #region 文本相关

    protected Text m_CoinValText;
    private Text m_BounceMultiVal;
    private Text m_MultiText;

    #endregion

    #region 滑动相关


    #endregion

    private int m_BounceVal = 0;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        this.WindowName = GameTags.UICompleteWindow;

        #region 获取成员引用

        #region 按钮相关

        m_DoneBut = BaseOption.FindChild<Button>(this.gameObject, "Done_But");
        m_NoThanksBut = BaseOption.FindChild<Button>(this.gameObject, "FailTanks_But");

        #endregion

        #region 文本相关

        m_CoinValText = BaseOption.FindChild<Text>(this.gameObject, "CoinVal_Text");
        m_BounceMultiVal = BaseOption.FindChild<Text>(this.gameObject, "BounceMultiVal");
        m_MultiText = BaseOption.FindChild<Text>(this.gameObject, "BounceMulti");

        #endregion

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        BaseOption.AddButClickMethod(m_DoneBut, DoneClickMethod);
        BaseOption.AddButClickMethod(m_NoThanksBut, NoThanksClickMethod);

        #endregion

        #endregion

    }


    protected override void OnInit()
    {

    }

    private void Update()
    {
    }

    protected override void DestroySelf()
    {
    }

    private void OnEnable()
    {
        m_NoThanksBut.gameObject.SetActive(false);
        Timer.Register(1f, () => { m_NoThanksBut.gameObject.SetActive(true); });
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 设置奖励金币
    /// </summary>
    /// <param name="coin"></param>
    public virtual void SetBounceCoin(int coin)
    {
        m_CoinValText.text = coin.ToString();
        coin = CheckPercent(coin);
        m_BounceVal = coin;

    }

    /// <summary>
    /// 检测概率
    /// </summary>
    private int CheckPercent(int coin)
    {
        BounceCoinConfigEntity bounceData = LocalDataMgr.Instance.GetBounceCoinPercent(true, coin);
        float two = bounceData.TwoPercent;
        float four = bounceData.FourPercent;
        float six = bounceData.SixPercent;
        float eight = bounceData.EightPercent;
        int adjustVal = 100;
        int bounceMulti = 1;
        int twoAdjutVal = (int)(two * adjustVal);
        int fourAdjustVal = (int)(four * adjustVal);
        int sixAdjustVal = (int)(six * adjustVal);
        int eightAdjustVal = (int)(eight * adjustVal);

        float max = (two + four + six + eight) * adjustVal;

        System.Random rand = new System.Random();
        int percent = rand.Next(0, (int)max);
        if (percent <= eightAdjustVal)
        {
            bounceMulti = 8;
            m_BounceMultiVal.color = Color.red;
            m_MultiText.color = Color.red;
        }
        else if (percent <= (eightAdjustVal + sixAdjustVal))
        {
            bounceMulti = 6;
            m_BounceMultiVal.color = Color.yellow;
            m_MultiText.color = Color.yellow;
        }
        else if (percent <= (eightAdjustVal + sixAdjustVal + fourAdjustVal))
        {
            bounceMulti = 4;
            m_BounceMultiVal.color = Color.blue;
            m_MultiText.color = Color.blue;
        }
        else if (percent <= (twoAdjutVal + fourAdjustVal + sixAdjustVal + eightAdjustVal))
        {
            bounceMulti = 2;
            m_BounceMultiVal.color = Color.red;
            m_MultiText.color = Color.red;
        }

        m_BounceMultiVal.text = bounceMulti.ToString();
        coin *= bounceMulti;
        return coin;
    }

    #endregion

    #region 委托方法

    #region 按钮相关

    public virtual void DoneClickMethod()
    {
        int coin = 0;

        BaseOption.ShowAdvertiseBounce((bool show) =>
        {
            UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
            Dictionary<string, string> recordDic = new Dictionary<string, string>();
            recordDic.Add("Mission", userData.CurrentMission.ToString());
            BaseOption.SetRecord(GameTags.GameFinishAdRecord, recordDic);

            coin = m_BounceVal;
            EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameSuccess, coin);
        });

    }

    protected virtual void NoThanksClickMethod()
    {
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        Dictionary<string, string> recordDic = new Dictionary<string, string>();
        recordDic.Add("Mission", userData.CurrentMission.ToString());
        BaseOption.SetRecord(GameTags.GameFinishNoThanksRecord, recordDic);
        int coin = 0;
        coin = int.Parse(m_CoinValText.text);
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameSuccess, coin);

        if (userData.CurrentMission>=5)
        {
            int insertADCount = PlayerPrefs.GetInt(GameTags.DailyInsertAdsCount);
            if (insertADCount>=GameTags.InsertAdsMaxCount)
            {
                BaseOption.ShowInsertAdvertise();
            }
            else
            {
                insertADCount++;
                if (insertADCount > GameTags.InsertAdsMaxCount)
                {
                    insertADCount = GameTags.InsertAdsMaxCount;
                }
                PlayerPrefs.SetInt(GameTags.DailyInsertAdsCount,insertADCount);
            }
          
        }

    }

    #endregion

    #endregion

}