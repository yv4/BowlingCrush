using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueWindow : UIOpenWindowsBase
{

    #region 成员变量

    #region 按钮相关

    private Button m_DoneBut;
    private Button m_SkipBut;

    #endregion

    #region 文本相关

    private Text m_LevelValText;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        this.WindowName = GameTags.UIContinueWindow;

        #region 获取成员引用

        #region 按钮相关

        m_DoneBut =BaseOption.FindChild<Button>(this.gameObject,"Done_But");
        m_SkipBut=BaseOption.FindChild<Button>(this.gameObject,"Skip_But");

        #endregion

        #region 文本相关

        m_LevelValText=BaseOption.FindChild<Text>(this.gameObject,"LevelVal_Text");

        #endregion

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        BaseOption.AddButClickMethod(m_DoneBut,DoneClickMethod);
        BaseOption.AddButClickMethod(m_SkipBut,SkipClickMethod);

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

    private void DoneClickMethod()
    {

        this.CloseButClick();

    }

    private void SkipClickMethod()
    {
        BaseOption.ShowAdvertiseBounce((bool show) => {
            EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.SkipMission);
            CloseButClick();
        });

    }

   #endregion

    #endregion

}