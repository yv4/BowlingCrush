using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI层级管理器
/// </summary>
public class LayerUIMgr : Singleton<LayerUIMgr> {

    /// <summary>
    /// UIPanel层级深度
    /// </summary>
    private int m_UIViewLayer = 50;

    /// <summary>
    /// 重置
    /// </summary>
    public void Reset()
    {
        m_UIViewLayer = 50;
    }

    /// <summary>
    /// 递减层级顺序，如果当前打开窗口为0则重置
    /// </summary>
    public void CheckOpenWindow()
    {
        m_UIViewLayer--;
        if (UIViewMgr.Instance.OpenWindowCount==0)
        {
            Reset();
        }
    }

    /// <summary>
    /// 设置层级
    /// </summary>
    /// <param name="obj"></param>
    public void SetLayer(GameObject obj)
    {
        
        m_UIViewLayer++;
        obj.transform.SetSiblingIndex(m_UIViewLayer);
        
    }
}
