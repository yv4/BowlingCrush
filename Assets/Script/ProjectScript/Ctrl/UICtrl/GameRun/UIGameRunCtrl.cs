using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class UIGameRunCtrl : AbstractCtrlBase
{

    #region 成员变量

    private ContinueSlider m_ContinueSlider;
    private GameRunSlider m_GameRunSlider;
    private Text m_BounceCount;
    private Image m_DollorIcon;
    private GameOverWindow m_OverWindow;
    private RewardItemWindow m_RewardItemWindow;
 
    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        GameObject gameRunCavas = BaseOption.GetCanvas(GameTags.GameRunCanvas);

        m_GameRunSlider = BaseOption.FindChild<GameRunSlider>(gameRunCavas, "GameRunSlider");
        m_ContinueSlider = BaseOption.FindChild<ContinueSlider>(gameRunCavas, "ContinueSlider");
        m_BounceCount = BaseOption.FindChild<Text>(gameRunCavas, "BounceCount");
        m_DollorIcon = BaseOption.FindChild<Image>(gameRunCavas, "DollerIcon");
        m_DollorIcon.gameObject.SetActive(false);
        m_ContinueSlider.gameObject.SetActive(false);
    }

    protected override void OnInit()
    {
       
    }

    protected override void DestroySelf()
    {

    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 控制时间滑动条
    /// </summary>
    public void ToCountRunTime(float val)
    {
        m_GameRunSlider.ToCountSlideVal(val);
    }

    /// <summary>
    /// 设置当前关卡
    /// </summary>
    public void SetCurrentLevel(int level)
    {
        m_GameRunSlider.SetCurrentLevel(level);
    }
    
    /// <summary>
    /// 获取奖励
    /// </summary>
    /// <param name="bounceVal"></param>
    public void GetBounce(int bounceVal)
    {
        m_BounceCount.text = bounceVal.ToString();
    }

    /// <summary>
    /// 将进入美元关Ionc展示
    /// </summary>
    public void WillEnterDollorLevelIcon()
    {
        Vector3 defaultPos = m_DollorIcon.transform.localPosition;
        m_DollorIcon.rectTransform.localScale = Vector3.zero;
        m_DollorIcon.gameObject.SetActive(true);

        m_DollorIcon.transform.localPosition = Vector3.zero;
        m_DollorIcon.transform.DOScale(1.2f, 1).SetEase(Ease.OutBounce).OnComplete(()=> {
            m_DollorIcon.transform.DOLocalMove(defaultPos, 1);
            m_DollorIcon.transform.DOScale(1, 1);
        });
    }

    /// <summary>
    /// 展示继续滑动
    /// </summary>
    public void ShowContinueSlider(bool enable)
    {
        m_ContinueSlider.gameObject.SetActive(enable);
    }

    #endregion

    #region 委托方法

    #region 按钮相关

    #endregion

    public override GameObject OpenUIWindow(string canvas, string type, bool open)
    {
        GameObject windowObj = base.OpenUIWindow(canvas, type, open);
        if (open)
        {
            if (type.Equals(GameTags.UIOverWindow))
            {
                m_OverWindow = windowObj.GetComponent<GameOverWindow>();
            }

            if (type.Equals(GameTags.UIRewardItemWindow))
            {
                m_RewardItemWindow = windowObj.GetComponent<RewardItemWindow>();
            }
        }

        return windowObj;
    }
    
    /// <summary>
    /// 设置结束窗口类型
    /// </summary>
    /// <param name="show"></param>
    public void SetOverWindowType(LevelType type)
    {
        m_OverWindow.SetOverWindowType(type);
    }

    /// <summary>
    /// 展示回报信息
    /// </summary>
    /// <param name="info"></param>
    public void ShowRewardItemInfo(string info)
    {
        if (m_RewardItemWindow!=null)
        {
            m_RewardItemWindow.ShowRewardInfo(info);
        }
    }
    #endregion

}