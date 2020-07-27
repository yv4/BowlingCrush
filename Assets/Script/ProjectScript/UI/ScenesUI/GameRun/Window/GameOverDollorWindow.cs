using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDollorWindow : GameOverWindow
{
    #region 成员变量

    private GameObject m_DollorObj;
    private int m_SuccessMax;

    #region 按钮相关


    #endregion

    #region 文本相关

    private Text m_DollorValText;

    #endregion

    #endregion

    #region 生命周期
    
    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        this.WindowName = GameTags.UIOverDollorWindow;

        m_DollorObj = BaseOption.FindChild(this.gameObject, "DollorObj");
        m_DollorValText = BaseOption.FindChild<Text>(this.gameObject, "DollorVal_Text");
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

    #endregion

    #region 成员方法

    /// <summary>
    /// 设置奖励金币
    /// </summary>
    /// <param name="coin"></param>
    public void SetBounceCoinAndDollar(int coin,string dollarValStr)
    {
        m_CoinValText.text = coin.ToString() + "/" + m_SuccessMax.ToString();

        m_DollorValText.text = dollarValStr;
    }

    /// <summary>
    /// 设置过关最大值
    /// </summary>
    public void SetMaxSuccessVal(int successVal)
    {
        m_SuccessMax = successVal;
        m_CoinValText.text = m_CoinValText.text + "/" + m_SuccessMax.ToString();
    }

    protected override void ExceedTime()
    {

        TanksClickMethod();
    }

    #endregion

    #region 委托方法

    protected override void DoneClickMethod()
    {
        base.DoneClickMethod();
    }

    protected override void ContinueClickMethod()
    {
        BaseOption.ShowAdvertiseBounce((bool show) => {

            if (show)
            {
                UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
                Dictionary<string, string> recordDic = new Dictionary<string, string>();
                recordDic.Add("Mission", userData.CurrentMission.ToString());
                BaseOption.SetRecord(GameTags.SpecialGameReviveRecord, recordDic);

                EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.RePlayGame);
                EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, GameTags.UIOverDollorWindow);
            }

        });
     
    }

    #endregion
}
