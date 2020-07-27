using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkMoveAction : RoleMoveAction
{
    #region 成员变量

    public bool MoveEnable = true;
    public int Index;
    private bool m_StartPlay;
    private float m_MoveSpeed;
    public float Border = -84;
    private float m_SingleFrameTimer = GameTags.SingleFrame;

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

        if (MoveEnable)
        {
            ChunkMove();
            CheckBorder();
        }
        
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
    /// 控制移动
    /// </summary>
    /// <param name="enable"></param>
    public void MoveCtrl(bool enable)
    {
        MoveEnable = enable;
    }

    /// <summary>
    /// 路块移动
    /// </summary>
    private void ChunkMove()
    {
      
        transform.Translate(-1*transform.forward * m_MoveSpeed * m_SingleFrameTimer);
    }

    /// <summary>
    /// 检查是否到达边界
    /// </summary>
    private void CheckBorder()
    {
        if (transform.localPosition.z<Border)
        {
            EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ResetChunk, Index);
        }
    }
  
    #endregion

    #region 委托方法

    #endregion
}
