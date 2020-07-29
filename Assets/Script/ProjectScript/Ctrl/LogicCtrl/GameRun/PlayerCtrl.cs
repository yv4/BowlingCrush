
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : AbstractCtrlBase
{

    #region 成员变量

    private PlayerBehaviour m_PlayerBeha;


    #region 计时相关

    public float MoveSpeed = 10;//移动速度
    public float GameMaxTime = 0;//游戏最大时间
    public bool StartCountTime;//开始计时
    private float m_RunTime = 0;//经过的时间

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        GameObject player = GameObject.FindGameObjectWithTag(GameTags.PlayerTag);
        m_PlayerBeha = player.GetComponent<PlayerBehaviour>();

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

        //if (StartCountTime)
        //{
        //    CountRunTime();
        //}

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 设置Mesh
    /// </summary>
    /// <param name="obj"></param>
    public void SetMesh(GameObject obj)
    {
        GameObject player = GameObject.FindGameObjectWithTag(GameTags.PlayerTag);
        m_PlayerBeha = player.GetComponent<PlayerBehaviour>();
        m_PlayerBeha.SetMesh(obj);
    }

    /// <summary>
    /// 设置拖尾
    /// </summary>
    /// <param name="obj"></param>
    public void SetTail(GameObject obj)
    {
        if (m_PlayerBeha != null)
        {
            m_PlayerBeha.SetTail(obj);
        }
    }

    /// <summary>
    /// 玩家拖动
    /// </summary>
    /// <param name="pos"></param>
    public void PlayerDrag(float pos)
    {
        m_PlayerBeha.PlayerDrag(pos);
    }

    /// <summary>
    /// 计算时间
    /// </summary>
    private void CountRunTime()
    {
        float moveSpeed = LocalDataMgr.Instance.LevelRunSpeed;
        if (m_RunTime < GameMaxTime)
        {
            float addVal = GameTags.SingleFrame * (moveSpeed - 10);
            m_RunTime += addVal;
            EventObserverMgr<float>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CountingTime, m_RunTime);
        }
        else
        {
            //EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.GameRunTimeStop);
        }
    }

    /// <summary>
    /// 停止计算时间
    /// </summary>
    public void StopCountTime()
    {
        m_RunTime = 0;
        StartCountTime = false;
        m_PlayerBeha.MoveCtrl(false);
    }

    /// <summary>
    /// 开始计算时间
    /// </summary>
    public void ToCountTime()
    {
        StartCountTime = true;
    }

    /// <summary>
    /// 重置时间
    /// </summary>
    public void ResetTime()
    {
        m_RunTime = 0;
    }

    /// <summary>
    /// 玩家死亡
    /// </summary>
    public void ToDie()
    {
        PlayDead();
        StartCountTime = false;
        m_PlayerBeha.ShowMesh(false);
        m_PlayerBeha.MoveCtrl(false);

    }

    /// <summary>
    /// 玩家复活
    /// </summary>
    public void Revive(float invicibleTime)
    {
        StartCountTime = true;
        m_PlayerBeha.Revive();
    }

    /// <summary>
    /// 获取玩家位置
    /// </summary>
    /// <returns></returns>
    public Vector3 GetPlayerPos()
    {
        return m_PlayerBeha.transform.position;
    }

    /// <summary>
    /// 显示形体
    /// </summary>
    public void HalfRevive()
    {
        m_PlayerBeha.HalfRevive();

    }

    /// <summary>
    /// 移动控制
    /// </summary>
    /// <param name="move"></param>
    public void MoveCtrl(bool move)
    {
        m_PlayerBeha.MoveCtrl(move);
    }

    /// <summary>
    /// 播放碰撞特效
    /// </summary>
    public void PlayCollider()
    {
        m_PlayerBeha.PlayColEffect();

    }

    /// <summary>
    /// 检测是否无敌
    /// </summary>
    /// <returns></returns>
    public bool CheckInvicible()
    {
        return m_PlayerBeha.IsInvisible;
    }

    /// <summary>
    /// 设置无敌
    /// </summary>
    /// <param name=""></param>
    public void SetInvicible(bool enable)
    {
        m_PlayerBeha.IsInvisible = enable;
    }

    /// <summary>
    /// 播放死亡特效
    /// </summary>
    public void PlayDead()
    {
        m_PlayerBeha.PlayDeadEffect();
    }

    #endregion

    #region 委托方法

    #endregion

}