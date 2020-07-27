using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//委托原型
public delegate void OnActionHandler<T>(T parameter=default(T));

public abstract class AbstractEventObserver<T>
{

    //委托字典(在此查找注册了的监听)
    private Dictionary<ObserverEventContent, List<OnActionHandler<T>>> dic = new Dictionary<ObserverEventContent, List<OnActionHandler<T>>>();

    /// <summary>
    /// 注册监听
    /// </summary>
    public void AddEventListener(ObserverEventContent eventContent, OnActionHandler<T> handler)
    {
        //判断字典中是否已经包含协议类型
        if (dic.ContainsKey(eventContent))
        {
            //如果包含则在相关协议委托集合里添加新委托
            dic[eventContent].Add(handler);
        }
        else
        {
            //如果不存在 则new一个协议委托集合
            List<OnActionHandler<T>> listHandler = new List<OnActionHandler<T>>();

            //在委托集合中添加新委托
            listHandler.Add(handler);

            //将委托集合放入字典
            dic.Add(eventContent, listHandler);
        }
    }

    /// <summary>
    /// 移除监听
    /// </summary>
    public void RemoveEventListener(ObserverEventContent eventContent, OnActionHandler<T> handler)
    {
       
        //判断是否包含协议
        if (dic.ContainsKey(eventContent))
        {
            //如果包含取出协议集合并移除协议委托
            List<OnActionHandler<T>> listHandler = dic[eventContent];
            listHandler.Remove(handler);
            if (listHandler.Count == 0)
            {
                dic.Remove(eventContent);
            }
        }
    }

    public void RemoveAllEventListener()
    {
        foreach (ObserverEventContent key in dic.Keys)
        {
            List<OnActionHandler<T>> listHandler = dic[key];
            listHandler.Clear();
        }
        dic.Clear();
    }

    /// <summary>
    /// 派发协议
    /// </summary>
    public void Dispatch(ObserverEventContent eventContent,T parameter)
    {

        //判断字典中是否已存在协议集合
        if (dic.ContainsKey(eventContent))
        {
            //取出协议集合
            List<OnActionHandler<T>> listHandler = dic[eventContent];
            if (listHandler != null && listHandler.Count > 0)
            {
                //对委托集合进行循环并以此调用
                for (int i = 0; i < listHandler.Count; i++)
                {
                    if (listHandler[i] != null)
                    {
                        listHandler[i](parameter);
                    }
                }
            }
        }
    }
}
