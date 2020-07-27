using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownObstacleBehaviour : SpawnItemBehaviour
{
    #region 成员变量

    public float PlayerDistance = 25;
    private ObstaclDownAction m_DownAction;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        m_DownAction = this.GetComponent<ObstaclDownAction>();
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
        float distance = this.transform.position.z;
        if (distance < PlayerDistance)
        {
            m_DownAction.MoveEnable = true;
        }
    }


    #endregion

    #region 委托方法

    #endregion
}
