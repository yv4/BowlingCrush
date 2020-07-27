using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILoadingCtrl : AbstractCtrlBase
{
    #region 成员

    private float m_LoadingTimer;
    public bool NoLoad;

    private Text m_LoadingText;

    private bool m_StartLoading;

    private GameObject m_loadingParent;

    private Slider m_ProgressSlider;

    private Image m_LoadingBg;

    #endregion

    #region 生命周期

    protected override void OnAwake()
    {
        base.OnAwake();
        m_LoadingBg = BaseOption.FindChild<Image>(BaseOption.GetCanvas(GameTags.GameLoadingCanvas), "Loader");


    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        if (m_StartLoading)
        {
            if (!NoLoad)
            {
                m_LoadingTimer++;
            }
            else
            {
                m_LoadingTimer=100;
              
            }

            m_ProgressSlider.value = m_LoadingTimer * 0.01f;
            m_LoadingText.text = m_LoadingTimer.ToString();
        }

        if (m_LoadingTimer==100&&m_StartLoading)
        {
            m_ProgressSlider.value = 1;
            m_StartLoading = false;
            EventObserverMgr<SceneType>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameLoadingSuccessOptionEvent, SceneMgrMaster.Instance.NextScene);
        }
       
    }

    protected override void OnBeforeDestroy()
    {
        base.OnBeforeDestroy();
    }

    #endregion

    #region 初始化与销毁

    protected override void DestroySelf()
    {
        this.m_LoadingText = null;
        this.m_loadingParent = null;
    }

    protected override void GetMemberReference()
    {
        GameObject canvas = BaseOption.GetCanvas("LoadingCanvas"); 
        this.m_loadingParent= BaseOption.FindChild(canvas, "Loader");
        this.m_LoadingText = BaseOption.FindChild<Text>(canvas, "TimeText");
        this.m_ProgressSlider = BaseOption.FindChild<Slider>(canvas, "Slider");
    }

    protected override void OnInit()
    {
    
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 设置背景色透明
    /// </summary>
    public void SetBgClear()
    {
        m_LoadingBg.color = Color.clear;
        
    }

    public void StartLoading()
    {
        GameObject canvas = BaseOption.GetCanvas("LoadingCanvas");
        canvas.SetActive(true);
        this.m_loadingParent.SetActive(true);
        this.m_StartLoading = true;
        ResetLoading();
    }

    public void StopLoading()
    {
        
        ResetLoading();
    }

    public void ResetLoading()
    {
        this.m_LoadingTimer = 0;
        this.m_LoadingText.text = "";
    }
    #endregion
}
