using MobiiGame.Sdk.Gift;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameRunMgr : AbstractMgrBase
{

    #region 成员变量

    #region 控制器

    private UIGameRunCtrl m_UIGameRunCtrl;
    private GameRunEnvCtrl m_EnvCtrl;
    private PlayerCtrl m_PlayerCtrl;

    #endregion

    private bool m_GameIsFinish;
    private float m_DollarLevelBounce;//美元关奖励
    private int m_CurrentDollarMax = 0;
    private float m_BounceCardProbility = 0;
    private bool m_GetRewardBall;//获取推送奖励球
    private int m_CurrentBounceVal = 0;
    private bool m_IsEnterDollerLevel = false;
    private LevelType m_CurrentLevelType;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        SceneDontDesObjCheck.Instance.EnableDontSaveObj(true);

        #region 获取成员变量

        GameObject ctrls = GameObject.Find(GameTags.GameRunCtrls);
        m_UIGameRunCtrl = BaseOption.FindChild<UIGameRunCtrl>(ctrls, "UICtrl");
        m_EnvCtrl = BaseOption.FindChild<GameRunEnvCtrl>(ctrls, "EnvCtrl");
        m_PlayerCtrl = BaseOption.FindChild<PlayerCtrl>(ctrls, "PlayerCtrl");

        #endregion

        #region 注册事件

        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameRunTimeStop, GameRunTimeStop);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ResetChunk, ResetChunkMethod);
        EventObserverMgr<float>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.PlayerDrag, PlayerDragMethod);
        EventObserverMgr<float>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CountingTime, CountingTimeMethod);
        EventObserverMgr<bool>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameFinish, GameFinishMethod);
        EventObserverMgr<string>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, OpenWindowMethod);
        EventObserverMgr<string>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, CloseWindowMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameSuccess, GameSuccessMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HitByObstacle, HitByObstacleMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OverGetAdBounce, OverGetAdBounceMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameFail, GameFailMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GetBounce, GetBounceMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ColliderBottle, ColliderBottleMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.DollorEnter, DollorEnterMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.PostReward, PostRewardMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.RePlayGame, RePlayGameMethod);
        EventObserverMgr<float>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.AdvertiseCardDollar, AdvertiseCardDollarMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ContinueMove, ContinueMoveMethod);

        #endregion
    }

    protected override void OnInit()
    {
        CheckEnterLevel();
        CheckNormalMissionCardProbility();
        GameObject meshObj = LocalDataMgr.Instance.InitPlayer();
        m_PlayerCtrl.SetMesh(meshObj);
        GameObject tailObj = GetPlayerTail();
        m_PlayerCtrl.SetTail(tailObj);
        m_PlayerCtrl.GameMaxTime = m_EnvCtrl.MaxLevelLength;
        m_PlayerCtrl.ToCountTime();

        if (!m_IsEnterDollerLevel)
        {
            LocalDataMgr.Instance.GetCurrentLevelSpeed();
            UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
            m_UIGameRunCtrl.SetCurrentLevel(user.CurrentMission);
            UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
            Dictionary<string, string> recordDic = new Dictionary<string, string>();
            recordDic.Add("Mission", userData.CurrentMission.ToString());
            BaseOption.SetRecord(GameTags.GameStartRecord, recordDic);
        }
        else
        {
            m_UIGameRunCtrl.SetCurrentLevel(-1);

            float dollar = RewardGiftSDK.ConvertDollar(DataManager.GoldCoin);
            m_DollarLevelBounce = dollar;
            UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
            Dictionary<string, string> recordDic = new Dictionary<string, string>();
            recordDic.Add("Mission", userData.CurrentMission.ToString());
            BaseOption.SetRecord(GameTags.SpecialGameStartRecord, recordDic);
        }

        UserPeresistData.Instance.HandleTask(TaskType.PlayGameCount);
        AudioBackgroundMgr.Instance.Play(GameTags.BackgroundAudio);
        Timer.Register(0.5f, () => { Resources.UnloadUnusedAssets(); GC.Collect(); });
        SceneMgrMaster.Instance.CloseLoader();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        #region 测试代码

        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    PlayerPrefs.SetInt(GameTags.PopWindowCount, 0);
        //}

        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    GiftCardDialog.ShowCardDialog();
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardWindow);
        //}

        #endregion

    }

    protected override void DestroySelf()
    {
        #region 注销事件

        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameRunTimeStop, GameRunTimeStop);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ResetChunk, ResetChunkMethod);
        EventObserverMgr<float>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.PlayerDrag, PlayerDragMethod);
        EventObserverMgr<float>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CountingTime, CountingTimeMethod);
        EventObserverMgr<bool>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameFinish, GameFinishMethod);
        EventObserverMgr<string>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, OpenWindowMethod);
        EventObserverMgr<string>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, CloseWindowMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameSuccess, GameSuccessMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HitByObstacle, HitByObstacleMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OverGetAdBounce, OverGetAdBounceMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameFail, GameFailMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GetBounce, GetBounceMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ColliderBottle, ColliderBottleMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.DollorEnter, DollorEnterMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.PostReward, PostRewardMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.RePlayGame, RePlayGameMethod);
        EventObserverMgr<float>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.AdvertiseCardDollar, AdvertiseCardDollarMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ContinueMove, ContinueMoveMethod);

        #endregion
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 检测普通关激励卡概率
    /// </summary>
    private void CheckNormalMissionCardProbility()
    {
        int mission = UserPeresistData.Instance.GetUserResource().CurrentMission;
        if (mission < 3)
        {
            m_BounceCardProbility = 1;
        }
        else if (mission>=6&&mission<=0)
        {
            m_BounceCardProbility = 0.3f;
        }
        else if (mission > 11)
        {
            m_BounceCardProbility = 0.2f;
        }
        else
        {
            switch (mission)
            {
                case 3:
                    m_BounceCardProbility = 0.8f;
                    break;
                case 4:
                    m_BounceCardProbility = 0.7f;
                    break;
                case 5:
                    m_BounceCardProbility = 0.6f;
                    break;
                default:
                    break;
            }
        }


    }

    /// <summary>
    /// 设置玩家拖尾
    /// </summary>
    private GameObject GetPlayerTail()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        ShopItemEntity shopItemData = LocalDataMgr.Instance.GetShipItemWithId(user.CurrentBall);
        string meshPath = GameTags.TailMesh;
        StringBuilder sb = new StringBuilder(meshPath);
        sb.Append(shopItemData.MeshName);
        GameObject tailObj = ResourcesMgr.Instance.Load(sb.ToString(), true, true);
        return tailObj;
    }

    /// <summary>
    /// 检查进入的关卡
    /// </summary>
    private void CheckEnterLevel()
    {
        m_IsEnterDollerLevel = LocalDataMgr.Instance.EnterDollorLevel;
        if (m_IsEnterDollerLevel)
        {
            SpawnDollors();
            //SpawnRandomBottles(true);
            m_CurrentLevelType = LevelType.DollorLevel;
            m_UIGameRunCtrl.WillEnterDollorLevelIcon();
        }
        else
        {
            SpawnRandomBottles(false);
            m_CurrentLevelType = LevelType.NormalLevel;
        }
    }

    /// <summary>
    /// 生成随机球瓶
    /// </summary>
    private void SpawnRandomBottles(bool isDollar)
    {
        List<List<string[]>> allBottleDatas = new List<List<string[]>>();

        string easyPath = GameTags.EasyDataPath;
        string normalPath = GameTags.NormalDataPath;
        string hardPath = GameTags.HardDataPath;

        StringBuilder easySb = new StringBuilder(easyPath);
        StringBuilder normalSb = new StringBuilder(normalPath);
        StringBuilder hardSb = new StringBuilder(hardPath);

        string levelConfig = LocalDataMgr.Instance.GetLevelConfig();
        if (levelConfig == null)
        {

            return;
        }
        string[] levels = BaseOption.SpliteStr(',', levelConfig);
        int failCount = PlayerPrefs.GetInt(GameTags.SameLevelFailCount);
        int easyCount = int.Parse(levels[0]);
        int normalCount = int.Parse(levels[1]);
        int hardCount = int.Parse(levels[2]);

        #region 测试代码

        //easyCount = 3;
        //normalCount = 3;
        //hardCount = 3;

        #endregion

        AdjustLevelDifficult(ref failCount, ref easyCount, ref hardCount);

        #region 测试代码

        //easySb.Append("easy");
        //easySb.Append((1).ToString());
        //TextAsset easyTextAssets = Resources.Load<TextAsset>(easySb.ToString());
        //List<string[]> easyBottleDatas = LitJson.JsonMapper.ToObject<List<string[]>>(easyTextAssets.ToString());
        //allBottleDatas.Add(easyBottleDatas);

        //easyTextAssets = Resources.Load<TextAsset>(easySb.ToString());
        //easyBottleDatas = LitJson.JsonMapper.ToObject<List<string[]>>(easyTextAssets.ToString());
        //allBottleDatas.Add(easyBottleDatas);

        //normalSb.Append("normal");
        //normalSb.Append((1).ToString());
        //TextAsset normalTextAssets = Resources.Load<TextAsset>(normalSb.ToString());
        //List<string[]> normalBottleDatas = LitJson.JsonMapper.ToObject<List<string[]>>(normalTextAssets.ToString());
        //allBottleDatas.Add(normalBottleDatas);

        #endregion

        #region 正式代码

        for (int i = 0; i < easyCount; i++)
        {
            int randomVal = Random.Range(0, GameTags.EasyMaxCount);
            if (i > 0)
            {
                int splitIndex = easySb.ToString().LastIndexOf('/');
                int removeCount = easySb.ToString().Length - (splitIndex + 1);
                easySb.Remove((splitIndex + 1), removeCount);
            }
            easySb.Append("easy");
            easySb.Append((randomVal + 1).ToString());

            try
            {
                TextAsset easyTextAssets = Resources.Load<TextAsset>(easySb.ToString());
                List<string[]> easyBottleDatas = LitJson.JsonMapper.ToObject<List<string[]>>(easyTextAssets.ToString());
                easyBottleDatas = easyBottleDatas.OrderBy(p =>
                float.Parse(p[2])
                ).ToList();
                allBottleDatas.Add(easyBottleDatas);
            }
            catch (Exception ex)
            {
                Debug.Log("随机值Easy:" + randomVal);
                Debug.Log("索引值:" + i + randomVal + 1);
                Debug.Log(easySb.ToString());
            }

        }

        for (int j = 0; j < normalCount; j++)
        {
            int randomVal = Random.Range(0, GameTags.NormalMaxCount);
            if (j > 0)
            {
                int splitIndex = normalSb.ToString().LastIndexOf('/');
                int removeCount = normalSb.ToString().Length - (splitIndex + 1);
                normalSb.Remove((splitIndex + 1), removeCount);
            }
            normalSb.Append("normal");
            normalSb.Append((j + randomVal + 1).ToString());

            try
            {
                TextAsset normalTextAssets = Resources.Load<TextAsset>(normalSb.ToString());
                List<string[]> normalBottleDatas = LitJson.JsonMapper.ToObject<List<string[]>>(normalTextAssets.ToString());
                normalBottleDatas = normalBottleDatas.OrderBy(p =>
                 float.Parse(p[2])
                ).ToList();
                allBottleDatas.Add(normalBottleDatas);
            }
            catch (Exception ex)
            {
                Debug.Log("随机值Normal:" + randomVal);
                Debug.Log("索引值:" + j + randomVal + 1);
                Debug.Log(easySb.ToString());
            }


        }

        for (int z = 0; z < hardCount; z++)
        {
            int randomVal = Random.Range(0, GameTags.HardMaxCount);
            if (z > 0)
            {
                int splitIndex = hardSb.ToString().LastIndexOf('/');
                int removeCount = hardSb.ToString().Length - (splitIndex + 1);
                hardSb.Remove((splitIndex + 1), removeCount);
            }
            hardSb.Append("hard");
            hardSb.Append((z + randomVal + 1).ToString());

            try
            {
                TextAsset hardTextAssets = Resources.Load<TextAsset>(hardSb.ToString());
                List<string[]> hardBottleDatas = LitJson.JsonMapper.ToObject<List<string[]>>(hardTextAssets.ToString());
                hardBottleDatas = hardBottleDatas.OrderBy(p =>
                float.Parse(p[2])
                ).ToList();
                allBottleDatas.Add(hardBottleDatas);
            }
            catch (Exception ex)
            {
                Debug.Log("随机值Hard:" + randomVal);
                Debug.Log("索引值:" + z + randomVal + 1);
                Debug.Log(easySb.ToString());
            }

        }

        #endregion


        m_EnvCtrl.SpawnRandomItem(allBottleDatas, isDollar);
    }

    ///// <summary>
    ///// 生成美元
    ///// </summary>
    private void SpawnDollors()
    {
        StringBuilder sb = new StringBuilder(GameTags.DollorJsonData);
        sb.Append("dollar");
        DollorMissionEntity data = LocalDataMgr.Instance.GetRandomDollorMission();
        m_CurrentDollarMax = data.SuccessCount;
        sb.Append((data.Id)).ToString();
        string filePath = sb.ToString();
        TextAsset textAssets = Resources.Load<TextAsset>(filePath);
        List<string[]> bottleDatas = LitJson.JsonMapper.ToObject<List<string[]>>(textAssets.ToString());
        bottleDatas = bottleDatas.OrderBy(p =>
              float.Parse(p[2])
              ).ToList();

        m_EnvCtrl.SpwanDollar(bottleDatas);
    }

    /// <summary>
    /// 调整关卡难度
    /// </summary>
    private void AdjustLevelDifficult(ref int easyCount, ref int normalCount, ref int hardCount)
    {
        int failCount = PlayerPrefs.GetInt(GameTags.SameLevelFailCount);
        switch (failCount)
        {
            case 1:
                {
                    normalCount += 1;
                    hardCount -= 1;
                }
                break;
            case 2:
                {
                    easyCount += 1;
                    normalCount -= 1;

                }
                break;
            case 3:
                {
                    normalCount += 1;
                    hardCount -= 1;
                }
                break;
            case 4:
                {
                    easyCount += 1;
                    normalCount -= 1;
                }
                break;
            case 5:
                {
                    normalCount += 1;
                    hardCount -= 1;
                }
                break;
            case 6:
                {
                    easyCount += 1;
                    normalCount -= 1;
                }
                break;

            default:
                break;
        }
    }


    /// <summary>
    /// 通过得分计算金币
    /// </summary>
    private int CalCoinWithBounce(bool win, int bounce)
    {
        int multiply = 1;
        if (win)
        {
            if (bounce >= 0 && bounce <= 200)
            {
                multiply = CheckMulti(50, 30, 19, 1);
            }
            else if (bounce >= 201 && bounce <= 300)
            {
                multiply = CheckMulti(65, 34, 0.9f, 0.1f);
            }
            else if (bounce >= 201)
            {
                multiply = CheckMulti(75, 24.5f, 0.45f, 0.05f);
            }

        }
        else
        {
            if (bounce >= 0 && bounce <= 150)
            {
                multiply = CheckMulti(15, 55, 25, 5);
            }
            else if (bounce >= 151 && bounce <= 250)
            {
                multiply = CheckMulti(29, 55, 15, 1);
            }
            else if (bounce >= 251)
            {
                multiply = CheckMulti(65, 34, 0.9f, 0.1f);
            }
        }

        return bounce * multiply;
    }

    /// <summary>
    /// 检测倍率
    /// </summary>
    private int CheckMulti(float twoPercent, float fourPercent, float sixPercent, float eightPercent)
    {
        int multiple = 1;
        float percentVal = UnityEngine.Random.Range(0, 100f);

        if (percentVal < twoPercent)
        {
            multiple = 2;
            return multiple;
        }

        if (percentVal < fourPercent)
        {
            multiple = 4;
            return multiple;
        }

        if (percentVal < sixPercent)
        {
            multiple = 6;
            return multiple;
        }

        if (percentVal < eightPercent)
        {
            multiple = 8;
            return multiple;
        }

        return multiple;
    }

    /// <summary>
    /// 检测是否弹出广告奖励界面
    /// </summary>
    private void CheckPopWindow()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        if (user.RewardBallIndex>=3)
        {
            return;
        }

        #region 测试代码

        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardWindow);

        #endregion

        #region 正式代码

        //if (user.CurrentMission >= 3)
        //{
        //    int count = PlayerPrefs.GetInt(GameTags.PopWindowCount);
        //    if (count < 2)
        //    {
        //        float randomVal = UnityEngine.Random.Range(0, 100f);

        //        if (randomVal <= 20)
        //        {
        //            BaseOption.SetRecord(GameTags.ExtraOpenRecord);
        //            count = 0;
        //            PlayerPrefs.SetInt(GameTags.PopWindowCount, count);
        //            EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardWindow);
        //        }
        //        else
        //        {
        //            count += 1;
        //            PlayerPrefs.SetInt(GameTags.PopWindowCount, count);
        //        }
        //    }
        //    else
        //    {
        //        BaseOption.SetRecord(GameTags.ExtraOpenRecord);
        //        count = 0;
        //        PlayerPrefs.SetInt(GameTags.PopWindowCount, count);
        //        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardWindow);
        //    }
        //}

        #endregion

    }

    #endregion

    #region 委托方法

    #region 窗口

    /// <summary>
    /// 打开UIWindow
    /// </summary>
    private void OpenWindowMethod(string parameter)
    {
        string tag = parameter;

        GameObject windowObj = m_UIGameRunCtrl.OpenUIWindow(GameTags.GameRunCanvas, tag, true);

        if (tag.Equals(GameTags.UICompleteWindow) || (tag.Equals(GameTags.UIFinishDollorWindow)))
        {
            //int coinCount = this.CalCoinWithBounce(true, m_CurrentBounceVal);
            int coinCount = m_CurrentBounceVal;
            GameFinishWindow windowScrip = windowObj.GetComponent<GameFinishWindow>();
            if (tag.Equals(GameTags.UICompleteWindow))
            {
                windowScrip.SetBounceCoin(coinCount);
            }

            if (tag.Equals(GameTags.UIFinishDollorWindow))
            {

                GameFinishDollorWindow dollorWindowScrip = (GameFinishDollorWindow)windowScrip;

                int rewardValue = RewardGiftSDK.Ins.GetMainRewardValue();
                string dollarValeStr = RewardGiftSDK.FormatMoney(rewardValue);

                dollorWindowScrip.SetBounceCoinAndDollar(coinCount, dollarValeStr);
                dollorWindowScrip.SetMaxSuccessVal(m_CurrentDollarMax);

            }
        }
        else if (tag.Equals(GameTags.UIOverWindow) || tag.Equals(GameTags.UIOverDollorWindow))
        {
            //int coinCount = this.CalCoinWithBounce(false, m_CurrentBounceVal);
            int coinCount = m_CurrentBounceVal;
            GameOverWindow windowScrip = windowObj.GetComponent<GameOverWindow>();

            if (tag.Equals(GameTags.UIOverDollorWindow))
            {
                DollorMissionEntity data = LocalDataMgr.Instance.GetRandomDollorMission();
                GameOverDollorWindow dollorWindowScrip = (GameOverDollorWindow)windowScrip;
                dollorWindowScrip.SetMaxSuccessVal(data.SuccessCount);

                int rewardValue = RewardGiftSDK.Ins.GetMainRewardValue();
                string dollarValeStr = RewardGiftSDK.FormatMoney(rewardValue);
                dollorWindowScrip.SetBounceCoinAndDollar(coinCount, dollarValeStr);
            }
            else if (tag.Equals(GameTags.UIOverWindow))
            {

                windowScrip.SetBounceCoin(coinCount);

            }
        }
        else if (tag.Equals(GameTags.UIRewardWindow))
        {
            UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
            int rewardBallIndex = user.RewardBallIndex;
            RewardWindow windowScrip = windowObj.GetComponent<RewardWindow>();
            if (rewardBallIndex >= 1)
            {
                windowScrip.ChangeUI(true);
            }
            else
            {
                windowScrip.ChangeUI(false);
            }
        }
        else if(tag.Equals(GameTags.UIRewardItemWindow))
        {
            if (m_GetRewardBall)
            {
                m_GetRewardBall = false;
                UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
                int rewardBallIndex = user.RewardBallIndex + 24;        
                ShopItemEntity shopItem = LocalDataMgr.Instance.GetShipItemWithId(rewardBallIndex);
                string ballSprite = GameTags.ShopItemSpritePath + shopItem.ShowSprite;
                Sprite shopSprite = ResourcesMgr.Instance.Load<Sprite>(ballSprite, true, true);
                RewardItemWindow windowScrip = windowObj.GetComponent<RewardItemWindow>();
                windowScrip.ChangeAvatarSprite(shopSprite);
               
            }
        }

    }

    /// <summary>
    /// 关闭UIWindow
    /// </summary>
    private void CloseWindowMethod(string parameter)
    {
        string tag = parameter;
        m_UIGameRunCtrl.OpenUIWindow(GameTags.GameRunCanvas, tag, false);
    }


    #endregion

    #region 碰撞

    /// <summary>
    /// 碰到瓶子
    /// </summary>
    /// <param name="parameter"></param>
    private void ColliderBottleMethod(int parameter)
    {
        m_PlayerCtrl.PlayCollider();
        m_CurrentBounceVal += parameter;
        m_UIGameRunCtrl.GetBounce(m_CurrentBounceVal);
        UserPeresistData.Instance.HandleTask(TaskType.ColliderBotton,parameter);
    }

    /// <summary>
    /// 碰到美金
    /// </summary>
    /// <param name="parameter"></param>
    private void GetBounceMethod(int parameter)
    {
        m_CurrentBounceVal += parameter;
        m_UIGameRunCtrl.GetBounce(m_CurrentBounceVal);

    }

    /// <summary>
    /// 被障碍物碰撞
    /// </summary>
    /// <param name="parameter"></param>
    private void HitByObstacleMethod(int parameter)
    {
        if (!m_PlayerCtrl.CheckInvicible())
        {
            m_PlayerCtrl.ToDie();
            m_EnvCtrl.MoveCtrl(false);

            int failCount = PlayerPrefs.GetInt(GameTags.SameLevelFailCount);
            failCount++;
            PlayerPrefs.SetInt(GameTags.SameLevelFailCount, failCount);

            Timer.Register(1f, () =>
            {
                if (m_IsEnterDollerLevel)
                {
                    UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
                    Dictionary<string, string> recordDic = new Dictionary<string, string>();
                    recordDic.Add("Mission", userData.CurrentMission.ToString());
                    BaseOption.SetRecord(GameTags.SpecialGameFailRecord, recordDic);

                    EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIOverDollorWindow);
                }
                else
                {
                    UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
                    Dictionary<string, string> recordDic = new Dictionary<string, string>();
                    recordDic.Add("Mission", userData.CurrentMission.ToString());
                    BaseOption.SetRecord(GameTags.GameFailRecord, recordDic);

                    EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIOverWindow);
                    m_UIGameRunCtrl.SetOverWindowType(LevelType.NormalLevel);
                }
            });
        }
    }

    #endregion

    #region 游戏状态

    /// <summary>
    /// 激励卡控制方法
    /// </summary>
    private void RefreshViceModelMoney()
    {

    }

    /// <summary>
    /// 复活后再移动
    /// </summary>
    /// <param name="parameter"></param>
    private void ContinueMoveMethod(int parameter)
    {
        m_UIGameRunCtrl.ShowContinueSlider(false);
        m_PlayerCtrl.MoveCtrl(true);
        m_EnvCtrl.MoveCtrl(true);
        m_PlayerCtrl.Revive(GameTags.ReviveInvicibleTime);
    }

    /// <summary>
    /// 激励卡现金奖励
    /// </summary>
    /// <param name="parameter"></param>
    private void AdvertiseCardDollarMethod(float parameter)
    {
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();

        int rewardValue = RewardGiftSDK.Ins.GetMainRewardValue();
        string dollarValeStr = RewardGiftSDK.FormatMoney(rewardValue);
        float addVal = float.Parse(dollarValeStr);
        float dollarVal = float.Parse(RewardGiftSDK.FormatMoney(DataManager.GoldCoin));
        float newVal = addVal + dollarVal;
        userData.DollorCount = newVal;

        UserPeresistData.Instance.SaveToJson();

    }


    /// <summary>
    /// 重新开始游戏
    /// </summary>
    /// <param name="parameter"></param>
    private void RePlayGameMethod(int parameter)
    {
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        BaseOption.SetRecord(GameTags.SpecialGameReplayRecord);
        m_IsEnterDollerLevel = true;
        m_CurrentBounceVal = 0;
        m_UIGameRunCtrl.GetBounce(m_CurrentBounceVal);
        m_EnvCtrl.ReplayGame();
        m_PlayerCtrl.MoveCtrl(true);
        m_PlayerCtrl.Revive(1);
        m_PlayerCtrl.ResetTime();
       
    }

    /// <summary>
    /// 推送奖励获取
    /// </summary>
    /// <param name="parameter"></param>
    private void PostRewardMethod(int parameter)
    {
        #region 测试代码

        //LocalDataMgr.Instance.GetRandomBallMesh();

        #endregion

        #region 正式代码

        int count = PlayerPrefs.GetInt(GameTags.PostReward);
        count++;

        int coinCount = 0;
        PlayerPrefs.SetInt(GameTags.PostReward, count);
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();

        string rewardStr = "";
        int ballMeshId = -1;
        switch (count)
        {
            case 1:
                {
                    
                    coinCount = 588;
                    rewardStr = "+588";
                    EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardItemWindow);

                }
                break;
            case 5:
                {
                    rewardStr = "+1288";
                    coinCount = 1288;
                    EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardItemWindow);
                }
                break;
            case 8:
                {
                    rewardStr = "Ball";
                    ballMeshId = LocalDataMgr.Instance.GetRewardBallMesh();
                    m_GetRewardBall = true;
                    if (ballMeshId != -1)
                    {

                        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardItemWindow);
                    }
                    else
                    {
                        GetRandomVal(out rewardStr, out coinCount);
                    }

                }
                break;
            case 10:
                {
                    count = 0;
                    PlayerPrefs.SetInt(GameTags.PostReward, 0);
                    rewardStr = "Ball";
                    m_GetRewardBall = true;
                    ballMeshId = LocalDataMgr.Instance.GetRewardBallMesh();
                    if (ballMeshId != -1)
                    {
                        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardItemWindow);
                    }
                    else
                    {
                        GetRandomVal(out rewardStr, out coinCount);
                    }
                }

                break;
            default:
                {
                    GetRandomVal(out rewardStr, out coinCount);

                }
                break;
        }
        userData.CoinCount += coinCount;
        m_UIGameRunCtrl.ShowRewardItemInfo(rewardStr);

        #endregion

    }

    /// <summary>
    /// 随机金币奖励
    /// </summary>
    private void GetRandomVal(out string rewardStr, out int coinCount)
    {
        rewardStr = "";
        coinCount = 0;
        float randomVal = UnityEngine.Random.Range(0, 100);
        if (randomVal < 52.5f)
        {
            CheckAwardPercent(randomVal, out coinCount,out rewardStr);
        }
        else if (randomVal > 52.5f)
        {
            randomVal -= 52.5f;
            CheckAwardPercent(randomVal, out coinCount,out rewardStr);
        }

        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIRewardItemWindow);
    }

    /// <summary>
    /// 检测奖励概率
    /// </summary>
    /// <param name="randomeVal"></param>
    /// <param name="coin"></param>
    private void CheckAwardPercent(float randomVal, out int coinCount, out string coinStr)
    {
        coinCount = 0;
        coinStr = "";
        if (randomVal < 0.5)
        {
            coinCount = 1588;
            coinStr = "+1588";
        }
        else if (randomVal < 2)
        {
            coinCount = 1088;
            coinStr = "+1588";
        }
        else if (randomVal < 5)
        {
            coinCount = 888;
            coinStr = "+888";
        }
        else if (randomVal < 10)
        {
            coinCount = 588;
            coinStr = "+588";
        }
        else if (randomVal < 30)
        {
            coinCount = 388;
            coinStr = "+388";

        }
        else
        {
            coinCount = 288;
            coinStr = "+288";
        }
    }

    /// <summary>
    /// 确定是否弹出激励卡
    /// </summary>
    private bool CheckShowCard(int probility,int max)
    {
        if (probility>= max)
        {
            return true;
        }

        System.Random rand = new System.Random();
        int percent = rand.Next(0, max);
        if (percent <= probility)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// 进入美元关
    /// </summary>
    /// <param name="parameter"></param>
    private void DollorEnterMethod(int parameter)
    {
        m_IsEnterDollerLevel = true;
        m_UIGameRunCtrl.WillEnterDollorLevelIcon();
        LocalDataMgr.Instance.EnterDollorLevel = m_IsEnterDollerLevel;
        m_IsEnterDollerLevel = false;
    }


    /// <summary>
    /// 游戏运行时间停止
    /// </summary>
    /// <param name="parameter"></param>
    private void GameRunTimeStop(int parameter)
    {

        m_GameIsFinish = true;
        m_PlayerCtrl.StopCountTime();
        m_EnvCtrl.MoveCtrl(false);
        EventObserverMgr<bool>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameFinish, true);

    }

    /// <summary>
    /// 游戏结算
    /// </summary>
    /// <param name="parameter"></param>
    private void GameFinishMethod(bool parameter)
    {
        m_PlayerCtrl.SetInvicible(true);
        AudioEffectMgr.Instance.Play(GameTags.GameSuccessAudio, Vector3.zero);
        if (m_IsEnterDollerLevel && m_CurrentLevelType == LevelType.DollorLevel)
        {
            //m_IsEnterDollerLevel = false;
            PlayerPrefs.SetInt(GameTags.SameLevelFailCount, 0);
            if (parameter)
            {
                EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIFinishDollorWindow);
            }
            else
            {
                EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, GameTags.UIFinishDollorWindow);
            }
            BaseOption.ShowCardDialog();
            UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
            Dictionary<string, string> recordDic = new Dictionary<string, string>();
            recordDic.Add("Mission", userData.CurrentMission.ToString());
            BaseOption.SetRecord(GameTags.SpecialGameSuccessRecord, recordDic);

        }
        else
        {
            if (parameter)
            {
                PlayerPrefs.SetInt(GameTags.SameLevelFailCount, 0);
                EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UICompleteWindow);
            }
            else
            {
                EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, GameTags.UICompleteWindow);
            }

            int showCardProbility = (int)(m_BounceCardProbility * 10);
            if(CheckShowCard(showCardProbility,10))
            {
                BaseOption.ShowCardDialog();
            }

            UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
            Dictionary<string, string> recordDic = new Dictionary<string, string>();
            recordDic.Add("Mission", userData.CurrentMission.ToString());
            BaseOption.SetRecord(GameTags.GameSuccessRecord, recordDic);
        }

        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        this.CheckPopWindow();
    }

    /// <summary>
    /// 游戏成功过关
    /// </summary>
    /// <param name="parameter"></param>
    private void GameSuccessMethod(int parameter)
    {
      
       
        int coin = parameter;
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        user.CoinCount += coin;
        if (!m_IsEnterDollerLevel)
        {
            user.CurrentMission += 1;
        }
        UserPeresistData.Instance.SaveToJson();
        PlayerPrefs.SetInt(GameTags.SameLevelFailCount, 0);
        EventObserverMgr<SceneType>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterNewScene, SceneType.GameStart);

        if ((TaskType)user.TaskType != TaskType.GetCoinCount)
        {
            UserPeresistData.Instance.HandleTask(TaskType.CompleteMissionCount);
        }
        else
        {
            UserPeresistData.Instance.HandleCoinTask(coin);
        }

        if (m_IsEnterDollerLevel)
        {
            m_IsEnterDollerLevel = false;
            LocalDataMgr.Instance.EnterDollorLevel = m_IsEnterDollerLevel;
        }

    }

    /// <summary>
    /// 游戏结束点击广告获取奖励
    /// </summary>
    /// <param name="parameter"></param>
    private void OverGetAdBounceMethod(int parameter)
    {
        int coin = parameter;
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        user.CoinCount += coin;
        UserPeresistData.Instance.SaveToJson();

        m_PlayerCtrl.HalfRevive();
        m_EnvCtrl.DisableObstacle(m_PlayerCtrl.GetPlayerPos());
        m_UIGameRunCtrl.ShowContinueSlider(true);
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        Dictionary<string, string> recordDic = new Dictionary<string, string>();
        recordDic.Add("Mission", userData.CurrentMission.ToString());
        BaseOption.SetRecord(GameTags.GameReviveRecord, recordDic);

        if (m_IsEnterDollerLevel)
        {
            EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, GameTags.UIOverDollorWindow);
        }
        else
        {
            EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, GameTags.UIOverWindow);
        }



    }

    /// <summary>
    /// 游戏失败结算
    /// </summary>
    /// <param name="parameter"></param>
    private void GameFailMethod(int parameter)
    {
        if (m_IsEnterDollerLevel)
        {
            m_IsEnterDollerLevel = false;
            LocalDataMgr.Instance.EnterDollorLevel = m_IsEnterDollerLevel;
        }

        int coinCount = parameter;
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        user.CoinCount += coinCount;
        if (((TaskType)user.TaskType)==TaskType.GetCoinCount)
        {
            UserPeresistData.Instance.HandleCoinTask(coinCount);
        }
       

        UserPeresistData.Instance.SaveToJson();
        EventObserverMgr<SceneType>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterNewScene, SceneType.GameStart);
    }

    #endregion

    #region 其他

    /// <summary>
    /// 计时方法
    /// </summary>
    /// <param name="parameter"></param>
    private void CountingTimeMethod(float parameter)
    {
        float runTime = parameter;
        float runVal = runTime / m_PlayerCtrl.GameMaxTime;
        m_UIGameRunCtrl.ToCountRunTime(runVal);
    }

    /// <summary>
    /// 重设路块位置
    /// </summary>
    /// <param name="parameter"></param>
    private void ResetChunkMethod(int parameter)
    {
        m_EnvCtrl.ResetChunk(parameter);
    }

    /// <summary>
    /// 拖动玩家位置
    /// </summary>
    /// <param name="parameter"></param>
    private void PlayerDragMethod(float parameter)
    {
        m_PlayerCtrl.PlayerDrag(parameter);
    }

    #endregion

    #endregion

}