using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractRoleAction : MonoBehaviour {


    private void Awake()
    {
        OnAwake();
        GetMemberReference();
    }

    // Use this for initialization
    void Start()
    {
        OnStart();
    }

    // Update is called once per frame
    void Update()
    {

        OnUpdate();
    }

    private void FixedUpdate()
    {
        OnFixedUpdate();
    }

    private void OnDestroy()
    {
        OnBeforeDestroy();
    }

    #region 虚方法

    protected virtual void OnAwake() { }
    protected virtual void OnStart() { OnInit(); }
    protected virtual void OnUpdate() { }
    protected virtual void OnFixedUpdate() { }
    protected virtual void OnBeforeDestroy() { DestroySelf(); }

    #endregion

    #region 抽象方法

    protected abstract void GetMemberReference();
    protected abstract void OnInit();
    protected abstract void DestroySelf();

    #endregion
}
