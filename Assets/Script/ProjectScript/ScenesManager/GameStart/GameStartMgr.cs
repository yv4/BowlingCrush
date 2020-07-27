using MobiiGame.Sdk.Gift;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameStartMgr : AbstractMgrBase
{

    #region 成员变量

    #region 控制器相关

    private UIGameStartCtrl m_UICtrl;
    private PlayerCtrl m_PlayerCtrl;
    private TaskCtrl m_TaskCtrl;
    private GameStartEnvCtrl m_EnvCtrl;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        #region 注册事件

        #region 场景交互事件

        EventObserverMgr<string>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, OpenWindowMethod);
        EventObserverMgr<string>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, CloseWindowMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterGameRun, EnterGameRunMethod);

        #endregion

        #region 互动事件

        EventObserverMgr<bool>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseAudio, CloseAudioMethod);
        EventObserverMgr<bool>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseShock, CloseShockMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.BuyItem, BuyItemMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.RefreshShopList, RefreshShopListMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.SkipMission, SkipMissionMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.FinishTask, FinishTaskMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HandleTaskFinish, HandleTaskFinishMethod);
        EventObserverMgr<int>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.TaskBounceCoin, TaskBounceCoinMethod);
        EventObserverMgr<float>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.AdvertiseCardDollar, AdvertiseCardDollarMethod);

        #endregion

        #endregion

        #region 获取控制器

        GameObject ctrls = GameObject.Find(GameTags.GameStartCtrls);
        m_UICtrl = BaseOption.FindChild<UIGameStartCtrl>(ctrls, "UICtrl");
        m_PlayerCtrl = BaseOption.FindChild<PlayerCtrl>(ctrls, "PlayerCtrl");
        m_TaskCtrl = BaseOption.FindChild<TaskCtrl>(ctrls, "TaskCtrl");
        m_EnvCtrl = BaseOption.FindChild<GameStartEnvCtrl>(ctrls, "EnvCtrl");

        #endregion
    }


    protected override void OnInit()
    {
        Debug.Log("UM Start");
        Timer.Register(1, () =>
        {
            SceneMgrMaster.Instance.CloseLoader();
        });

        SetPlayerMesh();
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        if (userData.TaskType<=-1)
        {
            UserPeresistData.Instance.GetRandomTask();
        }

        m_UICtrl.SetHeaderData(userData);
        CheckSameLevelFailCount();
        m_TaskCtrl.CheckFinishMission();
        m_EnvCtrl.PlayRandomEffect();
        m_UICtrl.SetTaskInfo((TaskType)userData.TaskType);
        m_UICtrl.SetFinishStar(userData.FinishStarCount);
  
        RewardGiftSDK.Init(RefreshViceModelMoney);

        #region 测试代码

        //m_UICtrl.SetRewardButEnable(true);

        #endregion
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        //this.CheckClickStart();

        if (Input.GetKeyDown(KeyCode.A))
        {
       
            PlayerPrefs.SetInt(GameTags.PostReward, 0);
        }

    }

    protected override void DestroySelf()
    {
        #region 注销事件

        #region 场景交互事件

        EventObserverMgr<string>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, OpenWindowMethod);
        EventObserverMgr<string>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, CloseWindowMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterGameRun, EnterGameRunMethod);

        #endregion

        #region 互动事件

        EventObserverMgr<bool>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseAudio, CloseAudioMethod);
        EventObserverMgr<bool>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseShock, CloseShockMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.BuyItem, BuyItemMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.RefreshShopList, RefreshShopListMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.SkipMission, SkipMissionMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.FinishTask, FinishTaskMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HandleTaskFinish, HandleTaskFinishMethod);
        EventObserverMgr<int>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.TaskBounceCoin, TaskBounceCoinMethod);
        EventObserverMgr<float>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.AdvertiseCardDollar, AdvertiseCardDollarMethod);

        #endregion

        #endregion
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 点击任意位置开始游戏
    /// </summary>
    private void CheckClickStart()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag != "ClickButUI")
                {
                    StartPlayer();
                }
            }
        }
    }

    /// <summary>
    /// 开始游戏
    /// </summary>
    private void StartPlayer()
    {
        AudioEffectMgr.Instance.Play(GameTags.BackgroundAudio, Vector3.zero);
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterGameRun);
    }

    #region 设置PlayerPref相关

    /// <summary>
    /// 设置声音数据保存
    /// </summary>
    /// <param name="enable"></param>
    private void SetSoundSetting(bool enable)
    {
        if (enable)
        {
            PlayerPrefs.SetInt(GameTags.SoundEanble, 1);
        }
        else
        {
            PlayerPrefs.SetInt(GameTags.SoundEanble, 0);
        }
    }

    /// <summary>
    /// 设置震动数据保存
    /// </summary>
    /// <param name="enable"></param>
    private void SetShockSetting(bool enable)
    {
        if (enable)
        {
            PlayerPrefs.SetInt(GameTags.ShockEnable, 1);
        }
        else
        {
            PlayerPrefs.SetInt(GameTags.ShockEnable, 0);
        }
    }

    #endregion

    /// <summary>
    /// 设置任务
    /// </summary>
    private void SetPlayerTask(UserResourceEntity userData)
    {
        BaseOption.SetRecord(GameTags.MissionRewardRecord);
        m_TaskCtrl.RefreshRandomMission();
        m_UICtrl.SetFinishStar(userData.FinishStarCount);
        m_UICtrl.SetTaskInfo((TaskType)userData.TaskType);
    }

    /// <summary>
    /// 设置玩家皮肤
    /// </summary>
    private void SetPlayerMesh()
    {
        GameObject meshObj = LocalDataMgr.Instance.InitPlayer();
        m_PlayerCtrl.SetMesh(meshObj);
    }

    /// <summary>
    /// 检测同个关卡失败次数
    /// </summary>
    private void CheckSameLevelFailCount()
    {
        int failCount = PlayerPrefs.GetInt(GameTags.SameLevelFailCount);
        if (failCount >= 3)
        {
            m_UICtrl.SetSkipButShow(true);
        }
        else
        {
            m_UICtrl.SetSkipButShow(false);
        }
    }

    #endregion

    #region 委托方法

    /// <summary>
    /// 激励卡控制方法
    /// </summary>
    private void RefreshViceModelMoney()
    {

    }

    /// <summary>
    /// 激励卡现金奖励
    /// </summary>
    /// <param name="parameter"></param>
    private void AdvertiseCardDollarMethod(float parameter)
    {
        int rewardValue = RewardGiftSDK.GetViceModelRewardValue(1);
        string str = RewardGiftSDK.FormatMoney(rewardValue);
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        userData.DollorCount = parameter+float.Parse(str);
        UserPeresistData.Instance.SaveToJson();

        m_UICtrl.SetHeaderData(userData);
    }

    /// <summary>
    /// 任务完成奖励金币委托
    /// </summary>
    /// <param name="parameter"></param>
    private void TaskBounceCoinMethod(int parameter)
    {
     
        UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
        userData.HaveTask = -1;
        userData.FinishStarCount = 0;
        userData.TaskCompleteCount = 0;

        int rewardCoin = Random.Range(500, 800);
        userData.CoinCount += rewardCoin;
    }


    /// <summary>
    /// 处理任务完成
    /// </summary>
    /// <param name="parameter"></param>
    private void HandleTaskFinishMethod(int parameter)
    {
        GiftCardDialog.ShowCardDialog(()=> {

            UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
            this.SetPlayerTask(user);
            m_UICtrl.SetFinishStar(user.FinishStarCount);

        },1);
    }

    /// <summary>
    /// 完成任务方法
    /// </summary>
    /// <param name="parameter"></param>
    private void FinishTaskMethod(int parameter)
    {
        m_UICtrl.SetFinishStar(4);
        m_UICtrl.SetDollarAnim(true);
    }


    /// <summary>
    /// 关闭声音
    /// </summary>
    /// <param name="parameter"></param>
    private void CloseAudioMethod(bool parameter)
    {
        bool enable = parameter;

        if (enable)
        {
            AudioBackgroundMgr.Instance.ResumePlayAudio();

        }
        else
        {
            AudioBackgroundMgr.Instance.StopPlayAudio();
        }

        AudioEffectMgr.Instance.SetPlayAudio(enable);
        SetSoundSetting(enable);
    }

    /// <summary>
    /// 关闭震动
    /// </summary>
    /// <param name="parameter"></param>
    private void CloseShockMethod(bool parameter)
    {
        bool enable = parameter;
        AudioEffectMgr.Instance.ShockEnable = enable;
        SetShockSetting(enable);
    }


    /// <summary>
    /// 进入GameRun场景
    /// </summary>
    /// <param name="parameter"></param>

    private void EnterGameRunMethod(int parameter)
    {
        GameObjPool.Instance.ClearPool();
        UserPeresistData.Instance.SaveToJson();
        EventObserverMgr<SceneType>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterNewScene, SceneType.GameRun);
    }

    /// <summary>
    /// 打开UIWindow
    /// </summary>
    private void OpenWindowMethod(string parameter)
    {
        string tag = parameter;

        m_UICtrl.OpenUIWindow(GameTags.GameStartCanvas, tag, true);

        if (tag.Equals(GameTags.UIShopWindow))
        {
            List<ShopItemEntity> shopItems = LocalDataMgr.Instance.GetShopItemList();

            m_UICtrl.SetShopListData(shopItems);
        }
    }

    /// <summary>
    /// 关闭UIWindow
    /// </summary>
    private void CloseWindowMethod(string parameter)
    {
        string tag = parameter;
        m_UICtrl.OpenUIWindow(GameTags.GameStartCanvas, tag, false);
    }

    /// <summary>
    /// 购买物品
    /// </summary>
    /// <param name="parameter"></param>
    private void BuyItemMethod(int parameter)
    {
        Debug.Log("index:" + parameter);
        ShopItemEntity shopItem = LocalDataMgr.Instance.GetShipItemWithId(parameter);
        bool buy = UserPeresistData.Instance.CostCoin(shopItem.BuyCoin);
        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UITipWindow);
        if (buy)
        {
            AudioEffectMgr.Instance.Play(GameTags.BuyShopSuccessAudio,Vector3.zero);
            UserPeresistData.Instance.AddBall(shopItem.Id);
            UserResourceEntity userData = UserPeresistData.Instance.GetUserResource();
            userData.CurrentBall = parameter;

            m_UICtrl.BuyItem(parameter);
            m_UICtrl.RefreshShopList();
            m_UICtrl.SetHeaderData(userData);
            this.SetPlayerMesh();
            m_UICtrl.ShowTipWindow("Have Buy");
        }
        else
        {
            AudioEffectMgr.Instance.Play(GameTags.BuyShopFailAudio,Vector3.zero);
            m_UICtrl.ShowTipWindow("No Buy");
        }
    }

    /// <summary>
    /// 刷新商品列表
    /// </summary>
    /// <param name="parameter"></param>
    private void RefreshShopListMethod(int parameter)
    {
        m_UICtrl.RefreshShopList();
        SetPlayerMesh();
    }

    /// <summary>
    /// 跳过关卡
    /// </summary>
    /// <param name="parameter"></param>
    private void SkipMissionMethod(int parameter)
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        user.CurrentMission++;
        m_UICtrl.SetSkipButShow(false);
        PlayerPrefs.SetInt(GameTags.SameLevelFailCount,0);
    }

    #endregion

}