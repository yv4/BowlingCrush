using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButs : UIBase
{

    #region 成员变量

    #region 按钮相关

    private Button m_GetRewardsBut;
    private Button m_ShopBut;
    private Button m_SkipBut;

    #endregion

    #region 文本相关


    #endregion

    #region 图片相关

    private Image m_Dollar;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {

        #region 获取成员引用

        #region 按钮相关

        m_GetRewardsBut = BaseOption.FindChild<Button>(this.gameObject, "GetRewards_But");
        m_ShopBut = BaseOption.FindChild<Button>(this.gameObject, "Shop_But");
        m_SkipBut = BaseOption.FindChild<Button>(this.gameObject, "Skip_But");

        #endregion

        #region 文本相关


        #endregion

        #region 图片相关

        m_Dollar = BaseOption.FindChild<Image>(this.gameObject, "DollorImg");

        #endregion

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        BaseOption.AddButClickMethod(m_GetRewardsBut, GetRewardsClickMethod);
        BaseOption.AddButClickMethod(m_ShopBut, ShopClickMethod);
        BaseOption.AddButClickMethod(m_SkipBut, SkipClickMethod);

        #endregion

        #endregion

    }

    protected override void OnInit()
    {
        m_SkipBut.gameObject.SetActive(false);
    }

    private void Update()
    {
        #region 测试代码

        //m_GetRewardsBut.enabled = true;

        #endregion
    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    public void SetButsEnable(bool enable)
    {
        m_GetRewardsBut.enabled = enable;
    }

    /// <summary>
    /// 展示跳过按钮
    /// </summary>
    /// <param name="enable"></param>
    public void ShowSkipButEnable(bool enable)
    {
        m_SkipBut.gameObject.SetActive(enable);
    }

    /// <summary>
    /// 美金扩张动画
    /// </summary>
    public void ShowDollarAnim(bool enable)
    {
        if (enable)
        {
            m_Dollar.transform.DOKill();
            m_Dollar.transform.DOScale(1.3f, 1f).SetLoops(-1, LoopType.Yoyo);
        }
        else
        {
            m_Dollar.transform.DOKill();
        }
    }

    #endregion

    #region 委托方法

    #region 按钮相关

    /// <summary>
    /// 得到回报按钮点击
    /// </summary>
    private void GetRewardsClickMethod()
    {

        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HandleTaskFinish);

    }

    private void ShopClickMethod()
    {

        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIShopWindow);

    }

    private void SkipClickMethod()
    {
        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.OpenWindowUI, GameTags.UIContinueWindow);
    }


    #endregion

    #endregion

}