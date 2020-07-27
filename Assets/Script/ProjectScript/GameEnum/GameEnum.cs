using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#region 示例

public enum SquareType
{
    None,
    White,
    Black,
    Grey

}

public enum GameMode
{
    Classic,
    Arcade
}

public enum YomobMode
{
    Normal,
    Banner
}

#endregion

#region GameStart场景枚举

public enum GameLoginOptionEnum
{
    Register,
    Login
}

#endregion

#region 手势拖拽方向

public enum SwipeDirectionEnum
{
    None,
    SwipeLeft,
    SwipeRight
}

/// <summary>
/// 移动使用控制器类型枚举
/// </summary>
public enum MoveControlEnum
{
    CharacterController,
    Rigibody
}

public enum RoadTypeEnum
{ 
    LeftBorder=-2,
    LeftRoad=-1,
    MiddleRoad=0,
    RightRoad=1,
    RightBorder=2
}

#endregion

#region 生成物

/// <summary>
/// 生成物Chunk名称
/// </summary>
public enum ChunkType
{
    BottleChunk,
    StaticObstacleChunk,
    MoveObstacleChunk,
    RotateObstacleChunk,
    DollorChunk,
    FourChunk,
    TenChunk,
    DozenChunk,
    DownObstacleChunk
}

public enum BounceItemType
{
    Dollor
}

#endregion

#region 关卡类型

public enum LevelType
{
    NormalLevel,
    DollorLevel
}

#endregion

#region 任务类型

/// <summary>
/// 任务类型
/// </summary>
public enum TaskType
{
    ColliderBotton = 0,
    PlayGameCount =1,
    GetCoinCount=2,
    CompleteMissionCount=3
}

#endregion





