using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractRoleBehaviour : MonoBehaviour {

    #region 成员

    /// <summary>
    /// 动画
    /// </summary>
    protected Animator m_Animator;

    #region 属性

    //玩家动画信息
    public AnimatorStateInfo GetAnimInof { get { return m_Animator.GetCurrentAnimatorStateInfo(0); } }

    //玩家动画片段信息
    public AnimatorClipInfo[] GetAnimClipInof { get { return m_Animator.GetCurrentAnimatorClipInfo(0); } }

    #endregion

    #endregion

    private void Awake()
    {
        OnAwake();
        GetMemberReference();
    }

    // Use this for initialization
    void Start () {

        OnStart();
	}
	
	// Update is called once per frame
	void Update () {

        OnUpdate();
	}

    private void FixedUpdate()
    {
        OnFixedUpdate();
    }

    private void OnDestroy()
    { 
        OnBeforeDestroy();
    }

    #region 虚方法

    protected virtual void OnAwake()
    {
        m_Animator = this.GetComponentInChildren<Animator>();
    }

    protected virtual void OnStart() { OnInit(); }
    protected virtual void OnUpdate(){}
    protected virtual void OnFixedUpdate() { }
    protected virtual void OnBeforeDestroy()
    {
        DestroySelf();
        this.m_Animator = null;
    }

    public virtual void Collider() { }

    #endregion

    #region 抽象方法

    protected abstract void GetMemberReference();
    protected abstract void OnInit();
    protected abstract void DestroySelf();

    #endregion

    #region 成员方法

    #region 控制动画相关方法

    public void SetAnimator(Animator anim)
    {

        m_Animator = anim;
    }

    //设置动画Bool参数
    public void SetAnimBool(string animName, bool value)
    {
        if (m_Animator!=null)
        {
            m_Animator.SetBool(animName, value);
        }
       
    }

    public void SetAnimTrigger(string animName)
    {
        if (m_Animator != null)
        {
            m_Animator.SetTrigger(animName);
        }
       
    }

    public float GetAnimFloat(string paraName)
    {
        if (m_Animator != null)
        {
            return m_Animator.GetFloat(paraName);
        }

        return -1;
       
    }

    public void SetAnimFloat(string paraName,float value)
    {
        if (m_Animator!=null)
        {
            m_Animator.SetFloat(paraName, value);
        }
       
    }

    #endregion



    #endregion
}
