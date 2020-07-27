using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSlider : UIBase
{

    #region 成员变量

    private GameObject m_SlideHand;
    private Button m_StartBut;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {

        #region 获取成员引用

        m_SlideHand = BaseOption.FindChild(this.gameObject, "SliderHand_Img");
        m_StartBut = this.GetComponent<Button>();
        BaseOption.AddButClickMethod(m_StartBut, StartButClickMethod);

        #endregion

        

    }

    protected override void OnInit()
    {
        SlideTweeen();
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
    /// 初始滑动动画
    /// </summary>
    public void SlideTweeen()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(m_SlideHand.transform.DOLocalMove(new Vector3(409, -768.5f, 0), 1f).SetEase(Ease.Linear));
        sequence.Append(m_SlideHand.transform.DOLocalMove(new Vector3(-339, -768.5f, 0), 1.5f).SetEase(Ease.Linear));
        sequence.Append(m_SlideHand.transform.DOLocalMove(new Vector3(38.3f, -768.5f, 0), 1f).SetEase(Ease.Linear));
        sequence.SetLoops(-1,LoopType.Restart);
    }

    #endregion

    #region 委托方法

    #region 按钮相关

    /// <summary>
    /// 开始点击方法
    /// </summary>
    private void StartButClickMethod()
    {
        AudioEffectMgr.Instance.Play(GameTags.BackgroundAudio,Vector3.zero);
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterGameRun);
    }

    #endregion

    #endregion

}