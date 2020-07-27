using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Object = UnityEngine.Object;


public class AssetBundleMgr : SingletonMono<AssetBundleMgr> {

    #region 成员

    #region 处理队列

    private Queue<AssetBundleOptionItem> m_HandleRoutineQueue = new Queue<AssetBundleOptionItem>();

    #endregion

    #endregion

    #region 生命周期

    #region 初始化与销毁

    protected override void OnAwake()
    {
        base.OnAwake();
       
    
    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnBeforeDestroy()
    {
        base.OnBeforeDestroy();
    }

    private void Update()
    {
        if (m_HandleRoutineQueue!=null&&m_HandleRoutineQueue.Count>0)
        {
            AssetBundleOptionItem item = m_HandleRoutineQueue.Dequeue();
            item.CompleteHandle();
        }
    }

    #endregion

    #endregion

    #region 成员方法

    /// <summary>
    /// 插入LoadFile项
    /// </summary>
    /// <param name="item"></param>
    public void InsertLoadFileItem(string filePath,AssetBundle bundle, Action<Object> handleMethod = null)
    {
        AssetBundleOptionItem optionItem = gameObject.AddComponent<AssetBundleOptionItem>();
        optionItem.ObjOptionItemInit(filePath,bundle,handleMethod);
    }

    public void InsertLoadAssetItem(string filePath, Action<AssetBundle> handleMethod = null)
    {
        AssetBundleOptionItem optionItem = gameObject.AddComponent<AssetBundleOptionItem>();
        optionItem.AssetBundleOptionItemInit(filePath, handleMethod);
    }


    /// <summary>
    /// 入队
    /// </summary>
    /// <param name="item"></param>
    public void Enqueue(AssetBundleOptionItem item)
    {
        m_HandleRoutineQueue.Enqueue(item);
    }
  
    #endregion
}
