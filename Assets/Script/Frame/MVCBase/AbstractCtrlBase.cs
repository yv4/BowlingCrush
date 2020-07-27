using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCtrlBase : MonoBehaviour {

    #region 生命周期

    protected void Awake()
    {
        OnAwake();
        GetMemberReference();
    }


    // Use this for initialization
    protected void Start()
    {
        OnStart();
     
        OnInit();
    }

    // Update is called once per frame
    protected void Update()
    {
        OnUpdate();
    }

    protected void OnDestroy()
    {
        OnBeforeDestroy();
        DestroySelf();
    }

    #endregion
   
    #region 虚方法

    protected abstract void OnInit();
    protected abstract void DestroySelf();
    protected abstract void GetMemberReference();
    protected virtual void OnAwake() { }
    protected virtual void OnUpdate() { }
    protected virtual void OnStart() { }
    protected virtual void OnBeforeDestroy() { }

    public virtual GameObject OpenUIWindow(string canvas,string type, bool open)
    {
        if (open)
        {
           return  UIViewMgr.Instance.OpenWindow(type, BaseOption.GetCanvas(canvas).transform, true);
        }
        else
        {
            UIViewMgr.Instance.CloseWindow(type);
            
        }

        return null;
    }
    #endregion
}
