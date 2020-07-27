using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : AbstractRoleBehaviour
{

    #region 成员变量

    #region Action相关

    private PlayerMoveAction m_PlayMoveAction;//人物移动Action

    #endregion

    private GameObject m_Mesh;
    private GameObject m_Tail;
    private GameObject m_Invicible;
    public GameObject TestTail;
    private ParticleSystem [] m_ColliderParticle;//撞击特效
    private ParticleSystem m_DeadParticle;//死亡特效
    private bool m_IsInvisible;

    public bool IsInvisible { get => m_IsInvisible; set => m_IsInvisible = value; }

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        #region 获取成员变量引用

        #region Action相关

        m_PlayMoveAction = this.GetComponent<PlayerMoveAction>();
        Transform colliderTrans = BaseOption.FindChild(this.gameObject, "ColliderEffect").transform;
        m_ColliderParticle = colliderTrans.GetComponentsInChildren<ParticleSystem>();

        #endregion


        Transform deadTrans = BaseOption.FindChild(this.gameObject, "DeadEffect").transform;
        m_DeadParticle = deadTrans.GetComponent<ParticleSystem>();
        m_Tail = GameObject.FindWithTag(GameTags.TailParentTag);
        m_Invicible = BaseOption.FindChild(this.gameObject,"InvincibleEffect");
        m_Invicible.gameObject.SetActive(false);

        #endregion
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
    /// 展示Mesh
    /// </summary>
    /// <param name="enable"></param>
    public void ShowMesh(bool enable)
    {
        m_Mesh.gameObject.SetActive(enable);
    }

    /// <summary>
    /// 设置死亡效果颜色
    /// </summary>
    private void SetDeadEffectColor()
    {
        if (m_Mesh!=null)
        {
            Renderer render = m_Mesh.GetComponentInChildren<Renderer>();
            Texture2D tex = render.material.mainTexture as Texture2D;
            //从纹理中获取像素颜色
            if(tex!=null)
            {
                Color[] m_textureColorsStart = tex.GetPixels();
                //设置渐变色
                ParticleSystem.MainModule mm = m_DeadParticle.main;
                mm.startColor = m_textureColorsStart[m_textureColorsStart.Length / 2];
                m_DeadParticle.GetComponent<Renderer>().material.SetColor("_TintColor", m_textureColorsStart[m_textureColorsStart.Length / 2]);
            }

        }
       
    }

    /// <summary>
    /// 设置Mesh
    /// </summary>
    /// <param name="obj"></param>
    public void SetMesh(GameObject obj)
    {
        m_Mesh = obj;
        //m_Collider = obj.GetComponent<Collider>();
        Transform mesh = BaseOption.FindChild(this.gameObject, "Mesh").transform;
        for (int i = 0; i < mesh.transform.childCount; i++)
        {
            Transform childTran = mesh.transform.GetChild(i);
            Destroy(childTran.gameObject);
        }

        obj.transform.SetParent(mesh);
        obj.transform.localPosition = Vector3.zero;

        SetDeadEffectColor();
    }

    /// <summary>
    /// 设置拖尾特效
    /// </summary>
    public void SetTail(GameObject obj)
    {
        obj.transform.SetParent(m_Tail.transform);
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localEulerAngles = new Vector3(0, 180, 0);
    }

    /// <summary>
    /// 停止移动
    /// </summary>
    public void MoveCtrl(bool enable)
    {
        m_PlayMoveAction.MoveCtrl(enable);
        if (!enable)
        {
            //m_Collider.enabled = false;
            IsInvisible = true;
            m_Tail.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// 半复活
    /// </summary>
    public void HalfRevive()
    {
        m_Mesh.gameObject.SetActive(true);
        m_Invicible.gameObject.SetActive(true);
    }

    /// <summary>
    /// 复活
    /// </summary>
    public void Revive()
    {
        m_Mesh.gameObject.SetActive(true);
        m_Invicible.gameObject.SetActive(true);
        Timer.Register(GameTags.ReviveInvicibleTime, () => {
            //if (m_Collider)
            //{
            //    m_Collider.enabled = true;
            //}
            IsInvisible = false;
            m_Invicible.gameObject.SetActive(false);
        });

        m_Tail.gameObject.SetActive(true);
        //Vector3 tailPos = m_Tail.transform.position;
        //m_Tail.transform.position = new Vector3(m_Mesh.transform.position.x, tailPos.y, tailPos.z);
       
    }

    /// <summary>
    /// 玩家拖动
    /// </summary>
    /// <param name="pos"></param>
    public void PlayerDrag(float pos)
    {
        m_PlayMoveAction.PlayerDrag(pos);
        Vector3 tailpos = m_Tail.transform.position;
        Vector3 target = new Vector3(this.transform.position.x, tailpos.y, tailpos.z);

        //m_Tail.transform.position=target;
        //m_Tail.transform.DOMove(target, 0.1f);
    }

    /// <summary>
    /// 播放撞击特效
    /// </summary>
    public void PlayColEffect()
    {
        foreach (var item in m_ColliderParticle)
        {
            item.Play();
        }
    }

    /// <summary>
    /// 播放死亡特效
    /// </summary>
    public void PlayDeadEffect()
    {
        m_DeadParticle.Play();
    }

    #endregion

    #region 委托方法

    #endregion

}