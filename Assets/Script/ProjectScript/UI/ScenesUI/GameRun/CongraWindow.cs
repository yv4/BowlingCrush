using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CongraWindow : UIOpenWindowsBase
{

    #region 成员变量

    #region 按钮相关

    private Button m_GetCoinBut;
    private Button m_DoneBut;

    #endregion

    #region 文本相关

    private Text m_DollerValText;

    #endregion

    #region 图片相关

    private Image m_AdvIconImg;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        this.WindowName = GameTags.UICongraWindow;

        #region 获取成员引用

        #region 按钮相关

        m_GetCoinBut=BaseOption.FindChild<Button>(this.gameObject,"GetCoin_But");
        m_DoneBut=BaseOption.FindChild<Button>(this.gameObject,"Done_But");

        #endregion

        #region 文本相关

        m_DollerValText=BaseOption.FindChild<Text>(this.gameObject,"DollerVal_Text");

        #endregion

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        BaseOption.AddButClickMethod(m_GetCoinBut,GetCoinClickMethod);
        BaseOption.AddButClickMethod(m_DoneBut,DoneClickMethod);

        #endregion

        #endregion

    }

    protected override void OnInit()
{
}

    private void Update()
{
}

    protected override void DestroySelf()
{
}

    #endregion

    #region 成员方法

    #endregion

    #region 委托方法

    #region 按钮相关

    private void GetCoinClickMethod()
    {

        Debug.Log("m_GetCoinBut");

    }

    private void DoneClickMethod()
    {

        Debug.Log("m_DoneBut");

    }

   #endregion

    #endregion

}