using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 所有UI的基类
/// </summary>
public abstract class UIBase : MonoBehaviour
{

    /// <summary>
    /// 打开或关闭动画效果持续时间
    /// </summary>
    public float Duration = 0.2f;

    /// <summary>
    /// 是否已经设置过打开效果
    /// </summary>
    public bool EffectHaveSet;

    private void Awake()
    {
        OnAwake();
        GetMemberReference();
    }

    void Start()
    {
        OnStart();
        OnInit();
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }

    private void OnDestroy()
    {
        BeforeOnDestroy();
        DestroySelf();
    }



    #region 虚拟方法

    protected virtual void OnAwake() { }
    protected virtual void OnStart() { }
    protected virtual void OnUpdate() { }
    protected virtual void BeforeOnDestroy() { }
    public virtual void InActive() { }

    protected abstract void OnInit();
    protected abstract void GetMemberReference();
    protected abstract void DestroySelf();

    #endregion

}