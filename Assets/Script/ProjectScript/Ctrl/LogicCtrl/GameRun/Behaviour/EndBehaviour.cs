using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBehaviour : SpawnItemBehaviour
{
    #region 成员变量


    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

    }

    public override void ResetInitPos()
    {
        base.ResetInitPos();
    }

    public override void SetInitPos(Vector3 pos)
    {
        base.SetInitPos(pos);
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


    public override void MoveCtrl(bool enable)
    {
        base.MoveCtrl(enable);

 
    }

    public override void Collider()
    {
        base.Collider();

        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameRunTimeStop);
    }

    #endregion

    #region 委托方法

    #endregion
}
