using MobiiGame.Sdk.Gift;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameStartCtrl : AbstractCtrlBase
{

    #region 成员变量

    private HeadBar m_HeadBar;
    private OptionButs m_OptionBut;
    private StartSlider m_StartSlider;
    private Canvas m_BgCanvas;
    private Canvas m_UICanvas;
    private ShopWindow m_ShopWindow;
    private TipWindow m_TipWindow;
    private StarsView m_StarsView;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        #region 获取成员引用

        GameObject canvas = BaseOption.GetCanvas(GameTags.GameStartCanvas);
        m_UICanvas = canvas.GetComponent<Canvas>();
        //m_BgCanvas = GameObject.Find(GameTags.GameStartBgCanvas).GetComponent<Canvas>();

        m_HeadBar = BaseOption.FindChild<HeadBar>(canvas, "HeadBar");
        m_OptionBut = BaseOption.FindChild<OptionButs>(canvas, "OptionButs");
        m_StartSlider = BaseOption.FindChild<StartSlider>(canvas, "StartSlider");
        m_StarsView = BaseOption.FindChild<StarsView>(m_OptionBut.gameObject, "GetRewards_But");

        #endregion

    }

    protected override void OnInit()
    {

    }

    protected override void DestroySelf()
    {

    }

    private new void Update()
    {
        //m_StartSlider.gameObject.GetComponent<RectTransform>().SetAsLastSibling();
    }

    #endregion

    #region 成员方法

    public override GameObject OpenUIWindow(string canvas, string type, bool open)
    {
        GameObject retObj = base.OpenUIWindow(canvas, type, open);
        if (open)
        {
            if (type.Equals(GameTags.UIShopWindow))
            {
                m_ShopWindow = retObj.GetComponent<ShopWindow>();
            }

            if (type.Equals(GameTags.UITipWindow))
            {
                m_TipWindow = retObj.GetComponent<TipWindow>();
            }

        }
        return retObj;
    }

    /// <summary>
    /// 显示提示窗口
    /// </summary>
    public void ShowTipWindow(string tipMsg)
    {
        m_TipWindow.ShowTipMessage(tipMsg);
    }

    /// <summary>
    /// 设置任务完成
    /// </summary>
    public void SetFinishStar(int finishCount)
    {
        m_StarsView.SetStarsFinish(finishCount);

        if(finishCount < 4)
        {
            m_OptionBut.SetButsEnable(false);
            m_OptionBut.ShowDollarAnim(false);
        }
        else
        {
            m_OptionBut.SetButsEnable(true);
        }
    }

    /// <summary>
    /// 设置美元动画
    /// </summary>
    public void SetDollarAnim(bool enable)
    {
        m_OptionBut.ShowDollarAnim(enable);
      
    }

    /// <summary>
    /// 设置任务描述
    /// </summary>
    public void SetTaskInfo(TaskType task)
    {
        m_StarsView.SetTaskInfo(task);
    }

    /// <summary>
    /// 设置跳过按钮展示
    /// </summary>
    /// <param name="enable"></param>
    public void SetSkipButShow(bool enable)
    {
        m_OptionBut.ShowSkipButEnable(enable);
    }

    /// <summary>
    /// 设置商城数据列表
    /// </summary>
    /// <param name="datas"></param>
    public void SetShopListData(List<ShopItemEntity> datas)
    {
        m_ShopWindow.SetDatas(datas);
    }

    /// <summary>
    /// 购买物品
    /// </summary>
    /// <param name="index"></param>
    public void BuyItem(int index)
    {
        m_ShopWindow.BuyItem(index);
    }

    /// <summary>
    /// 刷新商品列表
    /// </summary>
    public void RefreshShopList()
    {
        m_ShopWindow.RefreshShopList();
    }

    /// <summary>
    /// 设置Head数据
    /// </summary>
    /// <param name="data"></param>
    public void SetHeaderData(UserResourceEntity data)
    {
        m_HeadBar.SetData(data);
    }

    /// <summary>
    /// 设置任务按钮可用
    /// </summary>
    /// <param name="enable"></param>
    public void SetRewardButEnable(bool enable)
    {
        m_OptionBut.SetButsEnable(enable);
    }

    #endregion

    #region 委托方法


    #endregion

}