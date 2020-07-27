using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollorBehaviour : SpawnItemBehaviour
{
    #region 成员变量

    public int BounceVal = 10;
    private Transform m_Mesh;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        m_Mesh = BaseOption.FindChild(this.gameObject, "Mesh").transform;
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

    public override void Collider()
    {
        base.Collider();

        if (BounceVal>1)
        {

            AudioEffectMgr.Instance.PlayShock();
        }

        this.m_Mesh.gameObject.SetActive(false);
        EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GetBounce, BounceVal);
        GameObject dollarEffectObj = ResourcesMgr.Instance.Load(GameTags.DollarEffectObj, true, true);
        dollarEffectObj.transform.position = this.transform.position;
    }


    #endregion

    #region 委托方法

    #endregion
}
