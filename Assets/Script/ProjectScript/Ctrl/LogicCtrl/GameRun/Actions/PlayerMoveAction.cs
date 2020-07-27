using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveAction : RoleMoveAction
{

    #region 成员变量
    public bool MoveEnable = true;
    public float MoveSpeed = 3;
    public float RotateSpeed = 5;
    public float SingleFrameTimer = 0.01f;
    public float LeftBorder = -15;
    public float RightBorder = 15;
    public bool NoLeftMove;
    public bool NoRightMove;
    private float m_DragX;
    private Transform m_Mesh;
    private float m_MaxRightX = 21;
    private float m_MaxLeftX = -21;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        m_Mesh = BaseOption.FindChild(this.gameObject, "Mesh").transform;
    }

    protected override void OnInit()
    {

    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        if (MoveEnable)
        {
            HandleMove();
            HandleRotate();
        }
        
    }

    private void FixedUpdate()
    {
        if (MoveEnable)
        {
            CheckBorder();
        }
    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 停止移动
    /// </summary>
    public void MoveCtrl(bool enable)
    {
        MoveEnable = enable;
    }

    /// <summary>
    /// 玩家拖动
    /// </summary>
    /// <param name="pos"></param>
    public void PlayerDrag(float pos)
    {
        float editX = pos * Time.deltaTime * MoveSpeed;
        m_DragX = editX;
    }

    /// <summary>
    /// 检查边界
    /// </summary>
    private void CheckBorder()
    {
        if (transform.position.x > RightBorder)
        {
            NoRightMove = true;
            NoLeftMove = false;
        }
        else if (transform.position.x < LeftBorder)
        {
            NoLeftMove = true;
            NoRightMove = false;
        }

    }

    /// <summary>
    /// 处理移动
    /// </summary>
    private void HandleMove()
    {
        if (m_DragX!=0)
        {

            if (m_DragX<0&&NoLeftMove)
            {
      
                m_DragX = 0;
                Vector3 currentPos = this.transform.position;
                this.transform.position = new Vector3(m_MaxLeftX, currentPos.y, currentPos.z);
                return;
            }

            if (m_DragX>0&&NoRightMove)
            {
     
                m_DragX = 0;
                Vector3 currentPos = this.transform.position;
                this.transform.position = new Vector3(m_MaxRightX, currentPos.y, currentPos.z);
                return;
            }
       
            this.transform.Translate(this.transform.right * m_DragX, Space.World);
            m_DragX = 0;
            NoLeftMove = false;
            NoRightMove = false;

            //CtrlPos.Translate(CtrlPos.right * m_DragX, Space.World);
            //m_DragX = 0;
            //NoLeftMove = false;
            //NoRightMove = false;
            //this.transform.DOMoveX(CtrlPos.position.x, 0.2f);
        }
        
    }

    /// <summary>
    /// 处理旋转
    /// </summary>
    private void HandleRotate()
    {
        //保龄球球自转
        m_Mesh.transform.Rotate(Vector3.right, RotateSpeed * Time.deltaTime);
    }

    #endregion

    #region 委托方法

    #endregion

}