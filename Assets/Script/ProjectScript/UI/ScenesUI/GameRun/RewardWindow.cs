using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;

public class RewardWindow : UIOpenWindowsBase
{

    #region 成员变量

    #region 按钮相关

    private Button m_Coin1STBut;
    private Button m_Coin5THBut;
    private Button m_CoolSkinBut;
    private Button m_SpecialTailBut;
    private Button m_GetCoinBut;
    private Button m_DoneBut;
    private GameObject m_SpecialBallA;
    private GameObject m_SpecialBallB;
    private GameObject m_SpecialBallC;
    private GameObject m_SpecialBallD;
    private Image m_BallIcon;
    private Text m_BallAText;
    private Text m_BallBText;
    private Text m_BallAGetText;
    private Text m_BallBGetText;

    #endregion

    private Text m_ADSValText;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        this.WindowName = GameTags.UIRewardWindow;

        #region 获取成员引用

        m_ADSValText = BaseOption.FindChild<Text>(this.gameObject, "ADSVal_Text");
        m_BallAText = BaseOption.FindChild<Text>(this.gameObject, "BallA_Text");
        m_BallBText = BaseOption.FindChild<Text>(this.gameObject, "BallB_Text");
        m_BallAGetText = BaseOption.FindChild<Text>(this.gameObject, "BallAGet_Text");
        m_BallBGetText = BaseOption.FindChild<Text>(this.gameObject, "BallBGet_Text");

        #region 按钮相关

        //m_Coin1STBut = BaseOption.FindChild<Button>(this.gameObject, "Coin1ST_But");
        //m_Coin5THBut = BaseOption.FindChild<Button>(this.gameObject, "Coin5TH_But");
        //m_CoolSkinBut = BaseOption.FindChild<Button>(this.gameObject, "CoolSkin_But");
        //m_SpecialTailBut = BaseOption.FindChild<Button>(this.gameObject, "SpecialTail_But");
        m_GetCoinBut = BaseOption.FindChild<Button>(this.gameObject, "GetCoin_But");
        m_DoneBut = BaseOption.FindChild<Button>(this.gameObject, "Done_But");

        #endregion

        m_SpecialBallA = BaseOption.FindChild(this.gameObject, "SpecialBallA");
        m_SpecialBallB = BaseOption.FindChild(this.gameObject, "SpecialBallB");
        m_SpecialBallC = BaseOption.FindChild(this.gameObject, "SpecialBallC");
        m_SpecialBallD = BaseOption.FindChild(this.gameObject, "SpecialBallD");

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        //BaseOption.AddButClickMethod(m_Coin1STBut, Coin1STClickMethod);
        //BaseOption.AddButClickMethod(m_Coin5THBut, Coin5THClickMethod);
        //BaseOption.AddButClickMethod(m_CoolSkinBut, CoolSkinClickMethod);
        //BaseOption.AddButClickMethod(m_SpecialTailBut, SpecialTailClickMethod);
        BaseOption.AddButClickMethod(m_GetCoinBut, GetCoinClickMethod);
        BaseOption.AddButClickMethod(m_DoneBut, DoneClickMethod);

        #endregion

        #endregion

    }

    protected override void OnInit()
    {
        int count = PlayerPrefs.GetInt(GameTags.PostReward);
        m_ADSValText.text = count.ToString();
      
    }

    private void Update()
    {

    }

    private void OnEnable()
    {
        m_DoneBut.gameObject.SetActive(false);
        Timer.Register(1f, () =>
        {
            m_DoneBut.gameObject.SetActive(true);
        });
    }

    protected override void DestroySelf()
    {
    }

    #endregion

    #region 成员方法

    public void ChangeUI(bool enable)
    {
        if (enable)
        {
            this.m_SpecialBallB.gameObject.SetActive(false);
            this.m_SpecialBallD.gameObject.SetActive(false);
            this.m_SpecialBallA.gameObject.SetActive(true);
            this.m_SpecialBallC.gameObject.SetActive(true);
            m_BallAText.text = "Star Ball";
            m_BallBText.text = "Ocean Ball";
            m_BallBGetText.text = "GET STAR BALL FOR 10TH WATCH.";
            m_BallAGetText.text = "GET OCEAN BALL FOR 8TH WATCH.";

        }
        else
        {
            this.m_SpecialBallB.gameObject.SetActive(true);
            this.m_SpecialBallD.gameObject.SetActive(true);
            this.m_SpecialBallA.gameObject.SetActive(false);
            this.m_SpecialBallC.gameObject.SetActive(false);
            m_BallAText.text = "Fire Ball";
            m_BallBText.text = "Thunder Ball";
            m_BallBGetText.text = "GET FIRE BALL FOR 10TH WATCH.";
            m_BallAGetText.text = "GET THUNDER BALL FOR 8TH WATCH.";
        }
    }

    #endregion

    #region 委托方法

    #region 按钮相关

    private void Coin1STClickMethod()
    {

        Debug.Log("m_Coin1STBut");

    }

    private void Coin5THClickMethod()
    {

        Debug.Log("m_Coin5THBut");

    }

    private void CoolSkinClickMethod()
    {

        Debug.Log("m_CoolSkinBut");

    }

    private void SpecialTailClickMethod()
    {

        Debug.Log("m_SpecialTailBut");

    }

    private void GetCoinClickMethod()
    {
        BaseOption.ShowAdvertiseBounce((bool show) =>
        {
            if(show)
            {
                int insertADCount = PlayerPrefs.GetInt(GameTags.DailyInsertAdsCount);
                if (insertADCount <= 0)
                {
                    insertADCount = 0;
                }
                else
                {
                    insertADCount--;
                 
                }
                PlayerPrefs.SetInt(GameTags.DailyInsertAdsCount, insertADCount);

                BaseOption.SetRecord(GameTags.ExtraAdRecord);
                EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.PostReward);
                this.CloseButClick();
            }

        });

    }

    private void DoneClickMethod()
    {

        this.CloseButClick();

    }

    #endregion

    #endregion

}