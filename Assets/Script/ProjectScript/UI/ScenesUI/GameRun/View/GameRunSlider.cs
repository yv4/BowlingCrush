using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRunSlider : UIBase
{

    #region 成员变量

    #region 按钮相关


    #endregion

    #region 文本相关

    private Text m_HaveRunText;
    private Text m_MaxRunText;

    #endregion

    #region 滑动相关

    private Slider m_TimeSlider;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {

        #region 获取成员引用

        #region 按钮相关


        #endregion


        m_HaveRunText = BaseOption.FindChild<Text>(this.gameObject, "HaveRun_Text");
        m_MaxRunText = BaseOption.FindChild<Text>(this.gameObject, "MaxRun_Text");
        m_TimeSlider = BaseOption.FindChild<Slider>(this.gameObject, "Time_Slider");


        #endregion

        #region 添加成员委托方法监听


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

    public void SetCurrentLevel(int level)
    {
        if (level > 0)
        {
            m_HaveRunText.text = level.ToString();
            m_MaxRunText.text = (level + 1).ToString();
        }
        else
        {
            m_HaveRunText.text = "∞";
            m_MaxRunText.text = "∞";
        }

    }

    public void ToCountSlideVal(float val)
    {
        m_TimeSlider.value = val;
    }

    #endregion

    #region 委托方法

    #region 按钮相关

   #endregion

    #endregion

}