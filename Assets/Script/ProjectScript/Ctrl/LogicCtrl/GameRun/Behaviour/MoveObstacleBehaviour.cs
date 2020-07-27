using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleBehaviour : SpawnItemBehaviour
{
    #region 成员变量

    public float PlayerDistance = 25;
    private ObstaclHorizontalAction m_HMoveAction;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        m_HMoveAction = this.GetComponent<ObstaclHorizontalAction>();

    }


    protected override void DestroySelf()
    {

    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        if (!m_HMoveAction.HMoveEnable)
        {
            CheckPlayerDistance();
        }
    }

    #endregion

    #region 成员方法

    public override void MoveCtrl(bool enable)
    {
        base.MoveCtrl(enable);

        m_HMoveAction.MoveCtrl(enable);
    }

    public override void Collider()
    {
        base.Collider();
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.HitByObstacle);
    }

    /// <summary>
    /// 检测玩家距离
    /// </summary>
    public void CheckPlayerDistance()
    {
        float distance =  this.transform.position.z;
        if (distance<PlayerDistance)
        {
            m_HMoveAction.HMoveEnable = true;
        }
    }


    #endregion

    #region 委托方法

    #endregion
}
