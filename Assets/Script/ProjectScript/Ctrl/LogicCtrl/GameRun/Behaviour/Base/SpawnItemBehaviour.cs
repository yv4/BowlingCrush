using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItemBehaviour : AbstractRoleBehaviour
{
    #region 成员变量

    private BottleMoveAction m_BottleMoveAction;
    private Vector3 m_InitPos;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        m_BottleMoveAction = this.GetComponent<BottleMoveAction>();
    }

    protected override void OnInit()
    {
        //Timer.Register(1f, () => { this.gameObject.SetActive(false); });
    }

    protected override void DestroySelf()
    {

    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        if (this.transform.position.z < -180)
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
        }
    }

    #endregion

    #region 成员方法

    public virtual void MoveCtrl(bool enable)
    {
        m_BottleMoveAction.MoveCtrl(enable);
    }

    /// <summary>
    /// 回复起始位置
    /// </summary>
    public virtual void ResetInitPos()
    {
        this.gameObject.transform.localPosition = m_InitPos;
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 记录起始位置
    /// </summary>
    /// <param name="pos"></param>
    public virtual void SetInitPos(Vector3 pos)
    {
        m_InitPos = pos;
    }


    #endregion

    #region 委托方法

    #endregion
}
