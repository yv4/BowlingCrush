

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 事件分发类 (观察者模式)
/// </summary>
public class EventDispatcher : Singleton<EventDispatcher>
{

    //委托原型
    public delegate void OnActionHandler(byte[] buffer);

    //委托字典(在此查找注册了的监听)
    private Dictionary<ushort, List<OnActionHandler>> dic = new Dictionary<ushort, List<OnActionHandler>>();

    /// <summary>
    /// 注册监听
    /// </summary>
    /// <param name="protoCode"></param>
    /// <param name="handler"></param>
    public void AddEventListener(ushort protoCode, OnActionHandler handler)
    {

        //判断字典中是否已经包含协议类型
        if (dic.ContainsKey(protoCode))
        {
            //如果包含则在相关协议委托集合里添加新委托
            dic[protoCode].Add(handler);
        }
        else
        {
            //如果不存在 则new一个协议委托集合
            List<OnActionHandler> listHandler = new List<OnActionHandler>();

            //在委托集合中添加新委托
            listHandler.Add(handler);

            //将委托集合放入字典
            dic.Add(protoCode, listHandler);
        }
    }

    /// <summary>
    /// 移除监听
    /// </summary>
    /// <param name="protoCode"></param>
    /// <param name="handler"></param>
    public void RemoveEventListener(ushort protoCode, OnActionHandler handler)
    {
        //判断是否包含协议
        if (dic.ContainsKey(protoCode))
        {
            //如果包含取出协议集合并移除协议委托
            List<OnActionHandler> listHandler = dic[protoCode];
            listHandler.Remove(handler);
            if (listHandler.Count == 0)
            {
                dic.Remove(protoCode);
            }
        }
    }


    /// <summary>
    /// 派发协议
    /// </summary>
    /// <param name="protoCode"></param>
    /// <param name="role"></param>
    /// <param name="buffer"></param>
    public void Dispatch(ushort protoCode, byte[] buffer)
    {

        //判断字典中是否已存在协议集合
        if (dic.ContainsKey(protoCode))
        {
            //取出协议集合
            List<OnActionHandler> listHandler = dic[protoCode];
            if (listHandler != null && listHandler.Count > 0)
            {
                //对委托集合进行循环并以此调用
                for (int i = 0; i < listHandler.Count; i++)
                {
                    if (listHandler[i] != null)
                    {
                        listHandler[i](buffer);
                    }
                }
            }
        }
    }
}

