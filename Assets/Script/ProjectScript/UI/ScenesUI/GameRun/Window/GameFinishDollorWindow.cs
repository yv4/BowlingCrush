using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFinishDollorWindow : GameFinishWindow
{
    #region 成员变量

    private int m_SuccessVal;
    private GameObject m_LoseObj;
    private GameObject m_WinObj;

    #region 文本相关

    private Text m_DollorValText;

    #endregion

    #region 按钮相关

    private Button m_ReplayBut;
    

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        this.WindowName = GameTags.UIFinishDollorWindow;
        this.m_DollorValText = BaseOption.FindChild<Text>(this.gameObject, "DollorVal_Text");
        this.m_ReplayBut = BaseOption.FindChild<Button>(this.gameObject, "Replay_But");
        this.m_LoseObj = BaseOption.FindChild(this.gameObject, "LoseObj");
        this.m_WinObj = BaseOption.FindChild(this.gameObject, "WinImg");

        BaseOption.AddButClickMethod(m_ReplayBut, ReplayButClickMethod);
    }

    protected override void OnInit()
    {
        base.OnInit();
    }

    private void Update()
    {
    }

    protected override void DestroySelf()
    {
    }

    private void OnEnable()
    {
        
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 设置奖励金币
    /// </summary>
    /// <param name="coin"></param>
    public void SetBounceCoinAndDollar(int coin,string dollarVal)
    {
        m_CoinValText.text = coin.ToString() + "/" + m_SuccessVal;
        m_DollorValText.text = dollarVal;
    }

    /// <summary>
    /// 设置过关值
    /// </summary>
    public void SetMaxSuccessVal(int successVal)
    {
        string[] valStrs = BaseOption.SpliteStr('/', m_CoinValText.text);
        int val = int.Parse(valStrs[0]);
        m_SuccessVal = successVal;
        m_CoinValText.text = val.ToString() + "/" + m_SuccessVal;
 

        if (val >= m_SuccessVal)
        {
            BaseOption.ShowCardDialog();
            this.m_LoseObj.SetActive(false);
            this.m_WinObj.SetActive(true);
            this.m_ReplayBut.gameObject.SetActive(false);
            this.m_NoThanksBut.gameObject.SetActive(false);
            this.m_DoneBut.gameObject.SetActive(true);
            LocalDataMgr.Instance.EnterDollorLevel = false;
        }
        else
        {
            this.m_LoseObj.SetActive(true);
            this.m_WinObj.SetActive(false);
            this.m_ReplayBut.gameObject.SetActive(true);
            Timer.Register(1f, () => {
                this.m_NoThanksBut.gameObject.SetActive(true);
            });
           
            this.m_DoneBut.gameObject.SetActive(false);
            LocalDataMgr.Instance.EnterDollorLevel = true;
        }
    }

   
    #endregion

    #region 委托方法

    public override void DoneClickMethod()
    {
        int coin = 0;

        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        Dictionary<string, string> recordDic = new Dictionary<string, string>();
        recordDic.Add("Mission", userData.CurrentMission.ToString());
        BaseOption.SetRecord(GameTags.SpecialGameReviveRecord, recordDic);

        string coinText = m_CoinValText.text;
        string[] coins = BaseOption.SpliteStr('/', coinText);
        coin = int.Parse(coins[0]);
        coin = 0;
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameSuccess, coin);
    }

    protected override void NoThanksClickMethod()
    {

        int coin = 0;
        string coinText = m_CoinValText.text;
        string[] coins = BaseOption.SpliteStr('/', coinText);
        coin = int.Parse(coins[0]);
        coin = 0;
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameSuccess, coin);
    }

    private void ReplayButClickMethod()
    {
        BaseOption.ShowAdvertiseBounce((bool show) => {
            if (show)
            {
                EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, GameTags.UIFinishDollorWindow);
                EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.RePlayGame);
            }
        });
    }


    #endregion
}
