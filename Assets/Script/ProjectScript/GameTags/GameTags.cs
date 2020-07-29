using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//C:\Users\24237\AppData\LocalLow\limoyu\深空旅行者

public static class GameTags
{

    #region 画布相关

    public const string GameInitCanvas = "GameInitCanvas";
    public const string GameLoadingCanvas = "LoadingCanvas";
    public const string GameStartCanvas = "GameStartCanvas";
    public const string GameStartBgCanvas = "GameStartBgCanvas";
    public const string GameRunCanvas = "GameRunCanvas";
    public const string ScaleContent = "ScaleContent";//扩展缩小内容页

    #endregion

    #region UI预制体

    public const string MessageWindow = "Base/MessagePanel";//消息窗口

    #region GameStart场景相关

    public const string AudioEnableSprite = "GameStart/UI/Sprites/Voice-on";
    public const string AudioUnEnableSprite = "GameStart/UI/Sprites/Voice-off";
    public const string ShakeEnableSprite = "GameStart/UI/Sprites/ShockOpenIcon";
    public const string ShakeUnEnableSprite = "GameStart/UI/Sprites/ShockCloseIcon";
    public const string ShopItemUnSelectSprite = "GameStart/UI/Sprites/ShopItemUnSel";
    public const string ShopItemSelectSprite = "GameStart/UI/Sprites/ShopItemSel";
    public const string ShopItemSpritePath = "GameStart/UI/Sprites/";
    public const string UISignWindow = "GameStart/UI/Windows/UISignWindow";//签到窗口
    public const string UITaskWindow = "GameStart/UI/Windows/UITaskWindow";//任务窗口
    public const string UISettingWindow = "GameStart/UI/Windows/UISettingWindow";//设置窗口
    public const string UIRewardWindow = "GameStart/UI/Windows/RewardWindow";//奖励窗口
    public const string ShopItem = "GameStart/UI/Item/ShopItem";//商城Item
    public const string FinishStar = "GameStart/UI/Sprites/FinishStar";//完成星星
    public const string UnFinishStar = "GameStart/UI/Sprites/UnFinishStar";//未完成星星

    #endregion

    #region GameRun场景相关

    public const string UICompleteWindow = "GameRun/UI/Windows/GameFinishWindow";//完成过关窗口
    public const string UIOverWindow = "GameRun/UI/Windows/GameOverWindow";//关卡结束窗口
    public const string UIOverDollorWindow = "GameRun/UI/Windows/GameOverDollorWindow";//美元关卡结束窗口
    public const string UIFinishDollorWindow = "GameRun/UI/Windows/GameFinishDollorWindow";//完成美元关卡窗口
    public const string UIPropBounceWindow = "GameRun/UI/Windows/UIPropBounceWindow";//奖励箱弹出
    public const string UIShopWindow = "GameStart/UI/Windows/ShopWindow";//商城窗口
    public const string UITipWindow = "GameStart/UI/Windows/TipWindow";//提示窗口
    public const string UIContinueWindow = "GameRun/UI/Windows/ContinueWindow";//完成过关窗口
    public const string UICongraWindow = "GameStart/UI/Windows/CongraWindow";//祝贺窗口
    public const string UICoinSprite = "GameRun/UI/Sprites/CoinSprite";//金币精灵
    public const string UIDollorSprite = "GameRun/UI/Sprites/DollorSprite";//美元精灵
    public const string UIRewardItemWindow = "GameRun/UI/Windows/RewardItemWindow";//推送奖励物窗口

    #endregion

    #endregion

    #region 控制器父类

    public const string GameStartCtrls = "GameStartCtrls";//游戏开始场景父控制器
    public const string GameRunCtrls = "GameRunCtrls";//游戏运行场景父控制器
    public const string GameGarageCtrls = "GameGarageCtrls";//游戏车库场景父控制器、
    public const string GameShopCtrls = "GameShopCtrls";//游戏商城控制器
    public const string GameManualCtrls = "GameManualCtrls";//游戏图鉴控制器
    public const string GameStartCameraCtrl = "CameraCtrl";//游戏开始摄像机控制类

    #endregion

    #region 模型预制体

    #region 保龄球皮肤

    public const string BallMesh = "Common/Mesh/";//保龄球皮肤路径
    public const string TailMesh = "Common/Tail/";//拖尾路径
    public const string BottleMesh = "GameRun/Model/Bottles/BottlesMesh/";//保龄球瓶皮肤路径

    #endregion

    #region 道路生成物

    public const string BottleObj = "GameRun/Model/Bottles/Bottle";//球瓶
    public const string FourBottleObj = "GameRun/Model/Bottles/FourBottle";//四连球瓶
    public const string TenBottleObj = "GameRun/Model/Bottles/TenBottle";//十连球瓶
    public const string RoadChunks = "GameRun/Model/Road/Chunk";//路块
    public const string StaticObstacleObj = "GameRun/Model/Obstacle/StaticObstacle";//静态障碍
    public const string MoveObstacleObj = "GameRun/Model/Obstacle/MoveObstacle";//动态障碍
    public const string RotateObstacleObj = "GameRun/Model/Obstacle/RotateObstacle";//旋转障碍
    public const string BounceDollorObj = "GameRun/Model/BounceItem/Dollor";//美元
    public const string FourBounceDollorObj = "GameRun/Model/BounceItem/FourDollar";//四美元
    public const string TenBounceDollorObj = "GameRun/Model/BounceItem/TenDollar";//十美元
    public const string BounceDonzenDollorObj = "GameRun/Model/BounceItem/DonzenDollor";//一打美元
    public const string BounceDollorEnter = "GameRun/Model/BounceItem/DollorEnter";//美元关卡入口
    public const string DownObstacleChunkObj = "GameRun/Model/Obstacle/DownObstacleChunk";//下落障碍
    public const string EndChunkObj = "GameRun/Model/Obstacle/End";//终点
    public const string DollarEffectObj = "GameRun/Effect/DollarBlast";//美元效果

    #endregion

    #endregion

    #region 父物体相关

    #region GameStart场景相关

    public const string GameStartEnv = "GameStartEnv";//环境物体父物体
    public const string GameStartCameraParent = "GameStartCameraCtrl";//摄像机父物体
   
    #endregion

    #region GameRun场景相关

    public const string GameRunEnv = "GameRunEnv";//环境物体父物体
    public const string GameRunCameraParent = "GameRunCameraParent";//摄像机父物体

    #endregion

    #endregion

    #region 特效相关

    #region GameStart场景相关

    #endregion

    #region GameRun场景相关

    public const string HitEffect = "GameRun/Effect/HitEffect";//撞击特效
    public const string BombEffect = "GameRun/Effect/BombExplore";//爆炸特效
    public const string BounceEffect = "GameRun/Effect/BounceBox";//奖励盒
    
    #endregion

    #endregion

    #region 各种Tag值

    public const string GameRunEnvTag = "GameRunEnv";//游戏运行环境Tag
    public const string BottlesTag = "Bottles";//球瓶父物体Tag
    public const string PlayerTag = "Player";//玩家Tag
    public const string TailParentTag = "Tail";//尾部Tag

    #endregion

    #region 友盟打点记录

    public const string GameStartRecord = "game_start";//进入关卡记录
    public const string GameFailRecord = "game_faild";//关卡失败记录
    public const string GameSuccessRecord = "game_finish";//关卡胜利记录
    public const string GameReviveRecord = "game_relife_ad";//关卡复活记录
    public const string GameFinishNoThanksRecord = "game_finish_normal";//关卡过关NoThanks
    public const string GameFinishAdRecord = "game_finish_ad";//关卡过关多倍领取

    public const string SpecialGameStartRecord = "specalgame_start";//进入美元关卡记录
    public const string SpecialGameFailRecord = "specalgame_faild";//美元关卡失败记录
    public const string SpecialGameDeadRecord = "specalgame_dead";//美元关卡死亡记录
    public const string SpecialGameSuccessRecord = "specalgame_finish";//美元关卡胜利记录
    public const string SpecialGameReviveRecord = "specalgame_relife_ad";//美元关卡复活记录
    public const string SpecialGameReplayRecord = "specalgame_replay_ad";//美元关卡重来记录

    public const string MissionRewardRecord = "mission_complete";//领取奖励记录
    public const string ExtraOpenRecord = "extra_open";//推送界面记录
    public const string ExtraAdRecord = "extra_ad";//推送广告点击记录
    public const string ShopBallRecord = "shop_ball";//商城球购买记录
    public const string UseBallRecord = "game_useball";//球使用记录

    #endregion

    #region 音效相关

    public const string BackgroundAudio = "Audio/GameBackground";
    public const string GameStartAudio = "Audio/GameStart";
    public const string BuyShopSuccessAudio = "Audio/BuySuccess";
    public const string BuyShopFailAudio = "Audio/BuyFail";
    public const string GameSuccessAudio = "Audio/GameSuccess";
    public const string SoundEanble = "SoundEnable";
    public const string ShockEnable = "ShockEnable";

    #endregion

    #region 数据相关

    public const float DisableRadius = 30;//隐藏半径
    public const string SameLevelFailCount = "SameLevelFailCount";//单关失败次数
    public const string PopWindowCount = "PopWindowCount";//弹出广告窗口次数
    public const string DailyInsertAdsCount = "DailyInsertAdsCount";//每日插屏广告
    public const int InsertAdsMaxCount = 3;//插屏广告最大容忍次数
    public const float SingleFrame = 0.01f;
    public const float ReviveInvicibleTime = 3;//复活无敌时间
    public const string BottleChunck = "BottleChunk";
    public const string DollorChunk = "DollorChunk";
    public const string FourDollarChunk = "FourDollarChunk";
    public const string TenDollarChunk = "TenDollarChunk";
    public const string FourBottleChunk = "FourChunk";
    public const string TenBottleChunk = "TenChunk";
    public const string DozenChunk = "DozenChunk";
    public const string DownObstacleChunk = "DownObstacleChunk";
    public const string StaticObstacleChunk = "StaticObstacleChunk";
    public const string MoveObstacleChunk = "MoveObstacleChunk";
    public const string RotateObstacleChunk = "RotateObstacleChunk";
    public const int ColliderBottonCount = 500;
    public const int PlayGameCount = 5;
    public const int GetCoinCount = 800;
    public const int CompleteMissionCount = 3;
    public const string PostReward = "PostReward";
    public const string BottleJsonData = "GameRun/JsonData/Level/";
    public const string DollorJsonData = "GameRun/JsonData/Dollor/";
    public const string EasyDataPath = "GameRun/JsonData/Easy/";//简单关卡数据路径
    public const string NormalDataPath = "GameRun/JsonData/Normal/";//普通关卡数据路径
    public const string HardDataPath = "GameRun/JsonData/Hard/";//困难关卡数据路径
    public const int EasyMaxCount = 30;
    public const int NormalMaxCount = 20;
    public const int HardMaxCount = 20;
    public const int BounceMaxCount = 10;
    public const float RoadLeftMax = -1;
    public const float RoadRightMax = 1;
    public const float ZOffset = 0;
    public const float TriggerChangeRoadDistance = 55;

    #endregion

}
