using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindowBase : UIBase {

    #region 成员
    /// <summary>
    /// 挂点类型
    /// </summary>
    [SerializeField]
    public WindowUIContainerType containerType = WindowUIContainerType.Center;

    /// <summary>
    /// 打开方式
    /// </summary>
    [SerializeField]
    public WindowShowStyle showStyle = WindowShowStyle.Normal;

    /// <summary>
    /// 当前窗口类型
    /// </summary>
    [HideInInspector]
    public string CurrentUIType;

    /// <summary>
    /// 下一个要打开的窗口
    /// </summary>
    protected string m_NextOpenWindow = "";

    #endregion

    #region 实现虚方法
    /// <summary>
    /// 销毁之前执行
    /// </summary>
    protected override void BeforeOnDestroy()
    {
        LayerUIMgr.Instance.CheckOpenWindow();
    }
    #endregion

    #region 新的虚方法

    /// <summary>
    /// 关闭窗口
    /// </summary>
    public virtual void Close()
    {
        Debug.Log("Close");
    }

    #endregion

    #region 初始化与销毁

    protected override void OnInit()
    {
        
    }

    protected override void GetMemberReference()
    {
       
    }

    protected override void DestroySelf()
    {
      
    }


    #endregion

}
