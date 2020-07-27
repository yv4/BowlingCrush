using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclHorizontalAction : RoleMoveAction
{
    #region 成员变量

    private int m_MoveDir = 1;
    public float MoveTime = 3;
    public bool MoveEnable = false;
    public bool HMoveEnable = false;
    public bool ReachBorder = false;
    private GameObject m_MeshObj;
    private float m_SingleFrameTimer = 0.01f;
    public int DirThreshHold = -5;
    public float leftBorder = -15;
    public float rightBorder = 15;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        m_MeshObj = BaseOption.FindChild(this.gameObject, "Mesh");
      
    }

    protected override void OnInit()
    {
        CheckPos();
        HorizontalMove();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        //if (MoveEnable)
        //{
        //    HorizontalMove();
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
    /// 判断位置
    /// </summary>
    private void CheckPos()
    {
        float posx = this.transform.position.x;
        Vector3 pos = m_MeshObj.transform.localPosition;
        if (posx<0)
        {
            m_MeshObj.transform.localPosition = new Vector3(GameTags.RoadLeftMax, pos.y, pos.z);
            m_MoveDir = 13;
        }
        else if(posx>0)
        {
            m_MeshObj.transform.localPosition = new Vector3(GameTags.RoadRightMax, pos.y, pos.z);
            m_MoveDir = -13;
        }
        else
        {
            float randVal = Random.Range(0, 10);
            if (randVal<5)
            {
                m_MeshObj.transform.localPosition = new Vector3(GameTags.RoadLeftMax, pos.y, pos.z);
                m_MoveDir = 13;
            }
            else
            {
                m_MeshObj.transform.localPosition = new Vector3(GameTags.RoadRightMax, pos.y, pos.z);
                m_MoveDir = -13;
            }

        }
    }



    /// <summary>
    /// 球瓶移动
    /// </summary>
    private void HorizontalMove()
    {
        this.m_MeshObj.transform.DOMoveX(m_MoveDir, MoveTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);

    }

    /// <summary>
    /// 移动控制
    /// </summary>
    /// <param name="enable"></param>
    public void MoveCtrl(bool enable)
    {
        MoveEnable = enable;
    }

    /// <summary>
    /// 检测边界
    /// </summary>
    private void CheckBorder()
    {
        if (m_MoveDir < 0)
        {
            if (m_MeshObj.transform.position.x <= leftBorder)
            {
                ReachBorder = true;
            }
        }
        else if (m_MoveDir > 0)
        {
            if (m_MeshObj.transform.position.x >= rightBorder)
            {
                ReachBorder = true;
            }
        }
    }

    #endregion

    #region 委托方法

    #endregion
}