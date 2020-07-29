using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacleBehaviour : SpawnItemBehaviour
{
    #region 成员变量

    public float PlayerDistance = 25;
    private ObstaclRotateAction m_RotateAction;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        m_RotateAction = this.GetComponent<ObstaclRotateAction>();

    }


    protected override void DestroySelf()
    {

    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        CheckPlayerDistance();
    }

    #endregion

    #region 成员方法

    public override void MoveCtrl(bool enable)
    {
        base.MoveCtrl(enable);
        m_RotateAction.MoveCtrl(enable);
    }

    public override void Collider(Transform collider = null)
    {
        base.Collider();
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HitByObstacle);
    }

    /// <summary>
    /// 检测玩家距离
    /// </summary>
    public void CheckPlayerDistance()
    {
        float distance = this.transform.position.z;
        if (distance < PlayerDistance)
        {
            m_RotateAction.MoveEnable = true;
        }
    }


    #endregion

    #region 委托方法

    #endregion
}
