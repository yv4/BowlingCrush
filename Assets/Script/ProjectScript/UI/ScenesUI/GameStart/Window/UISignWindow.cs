using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISignWindow : UIOpenWindowsBase
{

    #region 成员变量

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        this.WindowName = GameTags.UISignWindow;
    }

    protected override void OnInit()
    {

    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    #endregion

    #region 委托方法
    
    #endregion

}