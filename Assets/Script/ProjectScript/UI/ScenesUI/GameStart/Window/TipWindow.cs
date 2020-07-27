using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;

public class TipWindow : UIOpenWindowsBase
{

    #region 成员变量

    #region 文本相关

    private Text m_BuyText;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        this.WindowName = GameTags.UITipWindow;

        #region 获取成员引用

        #region 文本相关

        m_BuyText = BaseOption.FindChild<Text>(this.gameObject, "Buy_Text");

        #endregion

        #endregion

        #region 添加成员委托方法监听

        #endregion

    }

    protected override void OnInit()
    {
    }

    private void OnEnable()
    {
        Timer.Register(1.5f, () =>
        {
            CloseButClick();
        });
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
    /// 显示提示信息
    /// </summary>
    /// <param name="message"></param>
    public void ShowTipMessage(string message)
    {
        m_BuyText.text = message;
    }

    #endregion

    #region 委托方法

    #endregion

}