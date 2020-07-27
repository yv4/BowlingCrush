using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclDownAction : RoleMoveAction
{
    #region 成员变量

    public float DownTime = 3;
    public bool MoveEnable = false;
    private GameObject m_MeshObj;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        m_MeshObj = BaseOption.FindChild(this.gameObject, "Mesh");

    }

    protected override void OnInit()
    {
        DownMove();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();

        //if (MoveEnable)
        //{
        //    DownMove();

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
    /// 旋转移动
    /// </summary>
    private void DownMove()
    {
        this.transform.position = new Vector3(this.transform.position.x, 0.5f, this.transform.position.z);
        this.transform.DOBlendableRotateBy(new Vector3(0, 0, -180), DownTime, RotateMode.WorldAxisAdd).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
      
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
