using UnityEngine;
using System.Collections;

/// <summary>
/// 场景UI的基类
/// </summary>
public abstract class UISceneBase : UIBase
{
    /// <summary>
    /// 容器_居中
    /// </summary>
    [SerializeField]
    public Transform Container_Center;

    protected override void DestroySelf()
    {
        
    }

    protected override void GetMemberReference()
    {
       
    }

    protected override void OnInit()
    {
        
    }
}
