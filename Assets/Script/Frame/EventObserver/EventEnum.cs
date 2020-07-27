using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObserverEventContent
{

    #region 场景交互事件

    OpenWindowUI,
    CloseWindowUI,
    EnterNewScene,
    EnterGameRun,

    #endregion

    #region 游戏进程事件

    #region 游戏加载读取事件

    GameLoadingSuccessOptionEvent,

    #endregion

    RePlayGame,//重新开始游戏
    GameRunTimeStop,//游戏一关运行时间结束
    ResetChunk,//设置路块位置
    PlayerDrag,//玩家屏幕拖拽
    CountingTime,//游戏时间计算
    GameFinish,//游戏结算
    GameSuccess,//游戏成功过关
    GameFail,//游戏失败
    HitByObstacle,//障碍物碰撞
    GetBounce,//获取奖励物
    DollorEnter,//进入美元关
    OverGetAdBounce,//结束点击广告获取奖励
    BuyItem,//购买物品
    FinishTask,//完成任务
    RefreshShopList,//刷新商品列表
    ColliderBottle,//碰撞瓶子
    SkipMission,//跳过关卡
    PostReward,//推送奖励
    HandleTaskFinish,//处理任务完成
    TaskBounceCoin,//任务奖励金币
    AdvertiseCardDollar,//激励卡现金奖励
    ContinueMove,//复活后再移动

    #endregion

    #region 网络相关事件

    ExceedNetTime, //网络连接等待超时

    #endregion

    #region 数据相关事件

    CloseAudio,//关闭声音
    CloseShock,//关闭震动

    #endregion

}

public enum ObserverEventType
{
    SceneActEvent,//场景交互事件
    PlayerCtrlEvent//玩家控制事件
}
