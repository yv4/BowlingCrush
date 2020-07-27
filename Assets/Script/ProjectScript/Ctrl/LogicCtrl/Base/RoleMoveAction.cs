using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleMoveAction : AbstractRoleAction {

    #region 成员

    /// 人物控制器
    /// </summary>
    protected CharacterController m_CharaCtrl;

    /// <summary>
    /// 人物刚体
    /// </summary>
    protected Rigidbody2D m_Rigibody;

    /// <summary>
    /// 移动控制方式
    /// </summary>
    public MoveControlEnum MoveCtrlType;

    #endregion

    #region 生命周期

    protected override void OnUpdate()
    {
        base.OnUpdate();

       
     
    }

    protected override void OnInit()
    {
        
    }

    protected override void DestroySelf()
    {
        m_CharaCtrl = null;
    }

    protected override void GetMemberReference()
    {
        if (MoveCtrlType == MoveControlEnum.CharacterController)
        {
            m_CharaCtrl = this.GetComponentInChildren<CharacterController>();
        }
        else
        {
            m_Rigibody = this.GetComponent<Rigidbody2D>();
        }
       
    }

    #endregion

}
