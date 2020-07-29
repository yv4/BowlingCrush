using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : SpawnItemBehaviour
{
    #region 成员变量


    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
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

    public override void Collider(Transform collider = null)
    {
        base.Collider();

        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HitByObstacle);
    }

    #endregion

    #region 委托方法

    #endregion
}
