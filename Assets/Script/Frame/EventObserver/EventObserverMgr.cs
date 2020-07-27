using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventObserverMgr<T> : Singleton<EventObserverMgr<T>> {

    

    private Dictionary<ObserverEventType, AbstractEventObserver<T>> m_OptionObserver;

    public EventObserverMgr()
    {
        m_OptionObserver = new Dictionary<ObserverEventType, AbstractEventObserver<T>>();
        m_OptionObserver.Add(ObserverEventType.SceneActEvent, new OptionEventObserver<T>());
        m_OptionObserver.Add(ObserverEventType.PlayerCtrlEvent, new OptionEventObserver<T>());
    }

    public void RegisterAction(ObserverEventType eventType,ObserverEventContent eventEnum, OnActionHandler<T> handler)
    {
        m_OptionObserver[eventType].AddEventListener(eventEnum, handler);
       
         
    }

    /// <summary>
    /// 移除监听
    /// </summary>
    public void RemoveEventListener(ObserverEventType eventType,ObserverEventContent eventContent, OnActionHandler<T> handler)
    {
        m_OptionObserver[eventType].RemoveEventListener(eventContent, handler);
      

    }

    public void RemoveAllEventListener(ObserverEventType eventType)
    {
        m_OptionObserver[eventType].RemoveAllEventListener();
        
    }

    /// <summary>
    /// 派发协议
    /// </summary>
    public void Dispatch(ObserverEventType eventType,ObserverEventContent eventContent,T parameter=default(T))
    {
        m_OptionObserver[eventType].Dispatch(eventContent, parameter);
    }

}
