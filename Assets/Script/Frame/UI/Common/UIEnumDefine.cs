using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region 场景类型

/// <summary>
/// 场景类型
/// </summary>
public enum SceneType
{
    None=0,
    GameInit,
    GameLoading,
    GameRun,
    NewRun,
    GameStart,
    Category,
    Shop,
    Manual
}

#endregion

#region 窗口类型

/// <summary>
/// 窗口类型
/// </summary>
//public enum WindowUIType
//{
//    /// <summary>
//    /// 未设置
//    /// </summary>
//    None,
//    UIMineralExchange,//星币兑换UI
//    UIGemStoneExchange,//晶体兑换UI
//    UIPowerExchange,//能源兑换UI
//    UISetting,//设置UI
//    UIShipHouse,//船坞UI
//    UISign,//签到UI
//    UIGameOver,//游戏结束UI
//    UIReStart,//游戏重开UI
//    UISuccess,//过关成功UI
//    UILaunch,//游戏启动暂停界面
//    UICraftHouse//船舱UI

//}

#endregion

#region UI容器类型

public enum WindowUIContainerType
{
    /// <summary>
    /// 左上
    /// </summary>
    TopLeft,

    /// <summary>
    /// 右上
    /// </summary>
    TopRight,

    /// <summary>
    /// 左下
    /// </summary>
    BottomLeft,

    /// <summary>
    /// 右下
    /// </summary>
    BottomRight,

    /// <summary>
    /// 居中
    /// </summary>
    Center
}


#endregion

#region UI打开方式

/// <summary>
/// 视图打开方式
/// </summary>
public enum ViewShowStyle
{
    /// <summary>
    /// 正常打开
    /// </summary>
    Normal,

    /// <summary>
    /// 从中间放大
    /// </summary>
    ConterToBig,

    /// <summary>
    /// 从上往下
    /// </summary>
    FromTop,

    /// <summary>
    /// 从下往上
    /// </summary>
    FromDown,

    /// <summary>
    /// 从左向右
    /// </summary>
    FromLeft,

    /// <summary>
    /// 从右向左
    /// </summary>
    FromRight
}

/// <summary>
/// 窗口打开方式
/// </summary>
public enum WindowShowStyle
{
    /// <summary>
    /// 正常打开
    /// </summary>
    Normal,

    /// <summary>
    /// 从中间放大
    /// </summary>
    CenterToBig,

    /// <summary>
    /// 从上往下
    /// </summary>
    FromTop,

    /// <summary>
    /// 从下往上
    /// </summary>
    FromDown,

    /// <summary>
    /// 从左向右
    /// </summary>
    FromLeft,

    /// <summary>
    /// 从右向左
    /// </summary>
    FromRight
}

#endregion

#region UI事件枚举

public enum UIEvent
{
    #region SeletRole窗体点击事件

    //关闭
    SelectServerClose
   

    #endregion
}

#endregion

#region UI子视图

/// <summary>
/// 子视图类型
/// </summary>
public enum ViewUIType
{
    /// <summary>
    /// 未设置
    /// </summary>
    None,
    
    /// <summary>
    /// 游戏结束界面
    /// </summary>
    GameOverPanel


}

#endregion
