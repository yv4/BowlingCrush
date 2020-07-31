using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;

public class BottleBehaviour : SpawnItemBehaviour
{
    #region 成员变量

    private BottleHitAction m_BottleHitAction;
    private ChangeMeshAction m_ChangeMeshAction;
    public int Bounce = 1;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        m_BottleHitAction = this.GetComponent<BottleHitAction>();
        m_ChangeMeshAction = this.GetComponent<ChangeMeshAction>();
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

        m_BottleHitAction.StartCollider(collider);

        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ColliderBottle, Bounce);
    }

    /// <summary>
    /// 设置皮肤
    /// </summary>
    /// <param name="meshObjPath"></param>
    public void SetMesh(string meshObjPath)
    {
        if (m_ChangeMeshAction == null)
        {
            m_ChangeMeshAction = this.GetComponent<ChangeMeshAction>();
        }
        //m_ChangeMeshAction.SetMesh(meshObjPath);
        m_ChangeMeshAction = GetComponent<ChangeMeshAction>();
        m_ChangeMeshAction.SetMesh("ping_01");
        Timer.Register(1f, () => {
            m_BottleHitAction.GetObjs();
        });

    }

    #endregion

    #region 委托方法

    #endregion
}
