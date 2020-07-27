using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkBehaviour : AbstractRoleBehaviour
{
    #region 成员变量

    private ChunkMoveAction m_ChunkMoveAction;
    private Vector3 m_InitPos;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        m_ChunkMoveAction = this.GetComponent<ChunkMoveAction>();
    }

    protected override void OnInit()
    {

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

    /// <summary>
    /// 记录起始位置
    /// </summary>
    /// <param name="pos"></param>
    public void SetInitPos(Vector3 pos)
    {
        m_InitPos = pos;
    }

    /// <summary>
    /// 回复起始位置
    /// </summary>
    public void ResetInitPos()
    {
        this.gameObject.transform.localPosition = m_InitPos;
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 移动控制
    /// </summary>
    /// <param name="enable"></param>
    public void MoveCtrl(bool enable)
    {
        m_ChunkMoveAction.MoveCtrl(enable);
    }

    /// <summary>
    /// 设置路块索引
    /// </summary>
    /// <param name="index"></param>
    public void SetChunkIndex(int index)
    {
        m_ChunkMoveAction.Index = index;
    }

    /// <summary>
    /// 重设路块位置
    /// </summary>
    public void ResetChunkPos(float pos)
    {
        this.transform.localPosition = new Vector3(0, 0, pos);
    }

    /// <summary>
    /// 获取路块消失距离
    /// </summary>
    /// <returns></returns>
    public float GetChunkDisappearLength()
    {
        return m_ChunkMoveAction.Border;
    }

    #endregion

    #region 委托方法


    #endregion
}
