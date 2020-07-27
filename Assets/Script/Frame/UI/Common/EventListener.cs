using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 事件监听类
/// </summary>
public class EventListener : UnityEngine.EventSystems.EventTrigger
{

    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate onClick;

    #region 暂时隐藏的待实现委托
    /*
    public VoidDelegate onDown;
    public VoidDelegate onEnter;
    public VoidDelegate onExit;
    public VoidDelegate onUp;
    public VoidDelegate onSelect;
    public VoidDelegate onUpdateSelect;
    */
    #endregion

    public void Clear()
    {
        onClick = null;
    }

    /// <summary>
    /// 获取游戏对象上的事件组件如没有则添加
    /// </summary>
    /// <param name="go"></param>
    /// <returns></returns>
    static public EventListener Get(GameObject go)
    {
        EventListener listener = go.GetComponent<EventListener>();
        if (listener==null)
        {
            listener = go.AddComponent<EventListener>();
        }
        return listener;
    }

    /// <summary>
    /// 点击事件的重写
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (onClick != null)
            onClick(gameObject);
    }

    #region 暂时隐藏的待实现方法
    /*
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (onDown != null) onDown(gameObject);
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (onEnter != null) onEnter(gameObject);
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (onExit != null) onExit(gameObject);
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (onUp != null) onUp(gameObject);
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (onSelect != null) onSelect(gameObject);
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (onUpdateSelect != null) onUpdateSelect(gameObject);
    }
    */
    #endregion

}
