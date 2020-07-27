using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOpenWindowsBase : UIWindowBase {

    #region 成员

    public bool ShowBg = true;
    public string WindowName;//浮动窗体名称
    public Image BackgroundImg;//透明背景图
    public GameObject ScaleContent;//缩放内容
    private Button m_CloseBut;//关闭按钮


    #endregion

    #region 实现虚方法

    #region 初始化与销毁

    protected override void OnInit()
    {
     
    }

    protected override void GetMemberReference()
    {
        BackgroundImg = BaseOption.FindChild<Image>(this.gameObject, "Background");
        ScaleContent = BaseOption.FindChild(this.gameObject, GameTags.ScaleContent);
        m_CloseBut = BaseOption.FindChild<Button>(this.gameObject, "CloseBut");
        if (m_CloseBut!=null)
        {
            m_CloseBut.onClick.AddListener(delegate { CloseButClick(); });
        }
       
    }

    protected override void DestroySelf()
    {

    }


    #endregion

    #region 委托方法

    /// <summary>
    /// 关闭按钮点击
    /// </summary>
    protected virtual void CloseButClick()
    {
        EventObserverMgr<string>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseWindowUI, WindowName);
    }

    #endregion

    #endregion
}
