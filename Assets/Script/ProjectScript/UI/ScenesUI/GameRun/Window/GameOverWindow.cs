using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;

public class GameOverWindow : UIOpenWindowsBase
{

    #region 成员变量

    public float WaitTime = 5;
    private Text m_MultiText;
    private Text m_MultiValText;
    private Text m_ContinueMultiText;
    private Text m_ContinueMultiValText;

    private int m_BounceVal = 0;
    private float m_BounceDollar = 0;

    #region 按钮相关

    private GameObject m_TimeCountObj;
    private GameObject m_LoseObj;
    private GameObject m_CoinObj;

    private Button m_DoneBut;
    private Button m_TanksBut;
    private Button m_ContinueBut;
    protected Button m_FailTanksBut;

    #endregion

    #region 文本相关

    private Text m_TimeCountText;
    protected Text m_CoinValText;

    #endregion

    private Image m_CoinImg;
    private Sprite m_CoinSprite;
    private Sprite m_DollorSprite;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        this.WindowName = GameTags.UIOverWindow;

        #region 获取成员引用

        m_TimeCountObj = BaseOption.FindChild(this.gameObject, "TimeCount");
        m_LoseObj = BaseOption.FindChild(this.gameObject, "LoseObj");
        m_CoinObj = BaseOption.FindChild(this.gameObject, "CoinObj");

        #region 按钮相关

        m_DoneBut = BaseOption.FindChild<Button>(this.gameObject, "Done_But");
        m_TanksBut = BaseOption.FindChild<Button>(this.gameObject, "Tanks_But");
        m_ContinueBut = BaseOption.FindChild<Button>(this.gameObject, "Continue_But");
        m_FailTanksBut = BaseOption.FindChild<Button>(this.gameObject, "FailTanks_But");

        #endregion

        #region 文本相关

        m_TimeCountText = BaseOption.FindChild<Text>(this.gameObject, "TimeCount_Text");
        m_CoinValText = BaseOption.FindChild<Text>(this.gameObject, "CoinVal_Text");
        m_MultiText = BaseOption.FindChild<Text>(this.gameObject, "BounceMulti");
        m_MultiValText = BaseOption.FindChild<Text>(this.gameObject, "BounceMultiVal");
        m_ContinueMultiText = BaseOption.FindChild<Text>(this.gameObject, "CointinueBounceMulti");
        m_ContinueMultiValText = BaseOption.FindChild<Text>(this.gameObject, "CointinueBounceMultiVal");

        #endregion

        m_CoinImg = BaseOption.FindChild<Image>(this.gameObject, "CoinImg");
        m_CoinSprite = ResourcesMgr.Instance.LoadSprite(GameTags.UICoinSprite, true);
        m_DollorSprite = ResourcesMgr.Instance.LoadSprite(GameTags.UIDollorSprite, true);

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        BaseOption.AddButClickMethod(m_DoneBut, DoneClickMethod);
        BaseOption.AddButClickMethod(m_TanksBut, TanksClickMethod);
        BaseOption.AddButClickMethod(m_ContinueBut, ContinueClickMethod);
        BaseOption.AddButClickMethod(m_FailTanksBut, FailTanksClickMethod);

        #endregion

        #endregion

    }

    protected override void OnInit()
    {

    }

    private void Update()
    {

    }

    private void OnEnable()
    {
        InitSetMethod();
    }

    protected override void DestroySelf()
    {
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 检测概率
    /// </summary>
    private int CheckPercent(int coin)
    {
        if (m_MultiValText==null)
        {
            return coin;
        }

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
            m_MultiValText.color = Color.red;
            m_MultiText.color = Color.red;
        }
        else if (percent <= (eightAdjustVal + sixAdjustVal))
        {
            bounceMulti = 6;
            m_MultiValText.color = Color.yellow;
            m_MultiText.color = Color.yellow;
        }
        else if (percent <= (eightAdjustVal + sixAdjustVal + fourAdjustVal))
        {
            bounceMulti = 4;
            m_MultiValText.color = Color.blue;
            m_MultiText.color = Color.blue;

        }
        else if (percent <= (twoAdjutVal + fourAdjustVal + sixAdjustVal + eightAdjustVal))
        {
            bounceMulti = 2;
            m_MultiValText.color = Color.red;
            m_MultiText.color = Color.red;
        }

        //m_MultiValText.text = bounceMulti.ToString();
        m_ContinueMultiValText.text = bounceMulti.ToString();
        coin *= bounceMulti;
        return coin;
    }

    /// <summary>
    /// 初始设置
    /// </summary>
    protected virtual void InitSetMethod()
    {
        m_TimeCountText.text = WaitTime.ToString();
        ShowObjs(false);
        StartCoroutine(Wait());

        if (m_TanksBut != null)
        {
            m_TanksBut.gameObject.SetActive(false);
            Timer.Register(1f, () =>
            {
                m_TanksBut.gameObject.SetActive(true);
            });
        }

    }

    /// <summary>
    /// 展示模块
    /// </summary>
    /// <param name="enable"></param>
    private void ShowObjs(bool enable)
    {
       m_TimeCountObj.gameObject.SetActive(!enable);
        m_DoneBut.gameObject.SetActive(!enable);
        m_TanksBut.gameObject.SetActive(false);
        m_FailTanksBut.gameObject.SetActive(false);
        m_LoseObj.gameObject.SetActive(enable);
        m_ContinueBut.gameObject.SetActive(enable);
    }

    private IEnumerator Wait()
    {
        float timeCount = 5;
        while (true)
        {
            yield return new WaitForSeconds(1f);
            timeCount -= 1;
            m_TimeCountText.text = timeCount.ToString();
            if (timeCount<=0)
            {
                ExceedTime();
                break;
            }
        }
    }

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

    public void SetOverWindowType(LevelType type)
    {
        switch (type)
        {
            case LevelType.NormalLevel:
                {
                    m_CoinImg.sprite = m_CoinSprite ;
                }
                break;
            case LevelType.DollorLevel:
                {
                    m_CoinImg.sprite = m_DollorSprite;
                }
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 超时处理
    /// </summary>
    protected virtual void ExceedTime()
    {
        TanksClickMethod();
    }


    #endregion

    #region 委托方法

    #region 按钮相关

    protected virtual void DoneClickMethod()
    {
 
        BaseOption.ShowAdvertiseBounce((bool show) =>
        {
            if (show)
            {
                StopAllCoroutines();
                string coinText = m_CoinValText.text;
                string[] coins = BaseOption.SpliteStr('/', coinText);
                int coin = int.Parse(coins[0]);
                coin = 0;
                EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OverGetAdBounce, coin);

            }
        });
    }

    protected virtual void TanksClickMethod()
    {
        StopAllCoroutines();
        ShowObjs(true);
        Timer.Register(1f, () =>
        {
            if (m_FailTanksBut!=null)
            {
                m_FailTanksBut.gameObject.SetActive(true);
            }
          
        });
    }

    protected virtual void ContinueClickMethod()
    {
        string coinText = m_CoinValText.text;
        string[] coins = BaseOption.SpliteStr('/', coinText);
        int coin = int.Parse(coins[0]);
        BaseOption.ShowAdvertiseBounce((bool show) => {
            if (show)
            {
                coin *= 2;
                EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameFail, coin);
            }
        });
      

    }

    private void FailTanksClickMethod()
    {
        string coinText = m_CoinValText.text;
        string[] coins = BaseOption.SpliteStr('/', coinText);
        int coin = int.Parse(coins[0]);
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameFail, coin);

        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        if (userData.CurrentMission >= 5)
        {
            int insertADCount = PlayerPrefs.GetInt(GameTags.DailyInsertAdsCount);
            if (insertADCount >= GameTags.InsertAdsMaxCount)
            {
                BaseOption.ShowInsertAdvertise();
            }
            else
            {
                insertADCount++;
                if (insertADCount>GameTags.InsertAdsMaxCount)
                {
                    insertADCount = GameTags.InsertAdsMaxCount;
                }
                PlayerPrefs.SetInt(GameTags.DailyInsertAdsCount, insertADCount);
            }

        }
    }

   #endregion

    #endregion

}