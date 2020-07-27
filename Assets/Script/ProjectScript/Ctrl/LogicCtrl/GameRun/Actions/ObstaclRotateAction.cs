using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclRotateAction : RoleMoveAction
{
    #region 成员变量

    public float RotateTime;
    private float m_MoveDir = 1;
    public float MoveSpeed = 3;
    public float MaxAngle = 90;
    public bool MoveEnable = false;
    public bool RMoveEnable = true;
    private float m_RotateAngle = 0;
    private GameObject m_MeshObj;
    public int DirThreshHold = -5;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        m_MeshObj = BaseOption.FindChild(this.gameObject, "Mesh");

    }

    protected override void OnInit()
    {
        CheckDir();
        RotateMove();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        //if (MoveEnable && RMoveEnable)
        //{
        //    RotateMove();

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
    /// 检测移动距离
    /// </summary>
    private void CheckDir()
    {
        if (transform.position.x < DirThreshHold)
        {
            m_MoveDir = 1;
        }
        else if (transform.position.x > DirThreshHold)
        {
            m_MoveDir = -1;
        }
    }

    /// <summary>
    /// 旋转移动
    /// </summary>
    private void RotateMove()
    {
        m_MeshObj.transform.DOBlendableRotateBy(new Vector3(0, 360, 0), RotateTime, RotateMode.WorldAxisAdd).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        RMoveEnable = false;
    }

    /// <summary>
    /// 移动控制
    /// </summary>
    /// <param name="enable"></param>
    public void MoveCtrl(bool enable)
    {
        MoveEnable = enable;
        RMoveEnable = enable;
    }

    /// <summary>
    /// 检测角度
    /// </summary>
    private void CheckAngle()
    {
        float angle = m_MeshObj.transform.eulerAngles.y;
        if (angle > 180)
        {
            angle -= 180;
            angle *= -1;
        }

        if (m_MoveDir > 0)
        {
            if (angle > MaxAngle)
            {
                RMoveEnable = false;
            }
        }

        if (m_MoveDir < 0)
        {
            if (angle > 0)
            {
                if (angle<MaxAngle)
                {
                    RMoveEnable = false;
                }
            
            }
        }

    }


    #endregion

    #region 委托方法

    #endregion
}
