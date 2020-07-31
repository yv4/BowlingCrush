using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoadingMgr : AbstractMgrBase
{

    #region 成员

    private UILoadingCtrl m_LoadingCtrl;
    private AsyncOperation m_Async;

    #endregion

    #region 生命周期

    protected override void OnAwake()
    {
        base.OnAwake();
    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
    }

    protected override void OnBeforeDestroy()
    {
        base.OnBeforeDestroy();
    }

    #endregion

    #region 初始化与销毁

    protected override void DestroySelf()
    {
        m_LoadingCtrl = null;

        #region 删除事件

        EventObserverMgr<SceneType>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameLoadingSuccessOptionEvent, GameLoadingSuccessMethod);

        #endregion
    }

    protected override void GetMemberReference()
    {
        SceneMgrMaster.Instance.LoadingScene = this;
        GameObject ctrls = GameObject.Find("LoadingCtrls");
        m_LoadingCtrl = BaseOption.FindChild<UILoadingCtrl>(ctrls, "UIGameLoadingCtrl");

        #region 注册事件

        EventObserverMgr<SceneType>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameLoadingSuccessOptionEvent, GameLoadingSuccessMethod);

        #endregion
    }


    protected override void OnInit()
    {

    }

    #endregion

    #region 成员方法

    public void OpenLoading()
    {
        m_LoadingCtrl.ResetLoading();
        m_LoadingCtrl.StartLoading();

        m_Async = SceneMgr.LoadScene(SceneMgrMaster.Instance.NextScene, LoadSceneMode.Additive);
        m_Async.allowSceneActivation = false;
    }

    public void SetProgressComplete()
    {
        m_LoadingCtrl.SetCompleteLoad();
    }

    #endregion

    #region 委托方法

    private void GameLoadingSuccessMethod(SceneType parameter)
    {
        m_Async.allowSceneActivation = true;

        
    }


    #endregion
}
