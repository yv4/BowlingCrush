using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleMoveAction : RoleMoveAction
{
    #region 成员变量

    public bool MoveEnable = true;
    private float m_MoveSpeed;
    private float m_SingleFrameTimer = 0.01f;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

      
    }

    protected override void OnInit()
    {
        m_MoveSpeed = LocalDataMgr.Instance.LevelRunSpeed;
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        //if (MoveEnable)
        //{
        //    BottleMove();
        //}
    }

    private void FixedUpdate()
    {

    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 球瓶移动
    /// </summary>
    private void BottleMove()
    {
        transform.Translate(-1 * transform.forward * m_MoveSpeed * m_SingleFrameTimer);
    }

    /// <summary>
    /// 移动控制
    /// </summary>
    /// <param name="enable"></param>
    public void MoveCtrl(bool enable)
    {
        MoveEnable = enable;
    }

    #endregion

    #region 委托方法

    #endregion
}
