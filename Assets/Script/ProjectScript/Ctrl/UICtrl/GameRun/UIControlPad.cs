using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIControlPad : AbstractCtrlBase, IBeginDragHandler, IDragHandler, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    #region 成员变量

    private Canvas m_GameRunCanvas;
    private Vector2 m_TmpAxis;
    private bool m_IsOnTouch;
    private bool m_IsOnDrag;
    private float m_TargetX;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        GameObject gameRunCavas = BaseOption.GetCanvas(GameTags.GameRunCanvas);
        m_GameRunCanvas = gameRunCavas.GetComponent<Canvas>();
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

    #endregion

    #region 委托方法

    #region 按钮相关

    #endregion

    #endregion

    #region 接口方法

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        m_TmpAxis = new Vector2(eventData.delta.x, eventData.delta.y);
        m_IsOnTouch = true;
        m_IsOnDrag = true;
        EventObserverMgr<float>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.PlayerDrag, m_TmpAxis.x);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        m_IsOnTouch = false;
        m_IsOnTouch = false;
        m_TmpAxis = Vector2.zero;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_IsOnTouch = false;
        m_IsOnDrag = false;
        m_TmpAxis = Vector2.zero;
    }

    #endregion
}
