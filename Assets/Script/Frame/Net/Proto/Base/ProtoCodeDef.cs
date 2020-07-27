
/// <summary>
/// 协议编号定义
/// </summary>
public class ProtoCodeDef
{

    /// <summary>
    /// 客户端发送心跳包
    /// </summary>
    public const ushort SystemOperation_Heat = 1004;

    /// <summary>
    /// 检测项目版本更新
    /// </summary>
    public const ushort SystemOperation_ChekVersion = 1005;

    /// <summary>
    /// 检测项目版本更新回调
    /// </summary>
    public const ushort SystemOperation_CheckVersionRet = 1006;

    /// <summary>
    /// 获取玩家排名
    /// </summary>
    public const ushort GetPlayerRank = 1007;

    /// <summary>
    /// 获取玩家排名回调
    /// </summary>
    public const ushort GetPlayerRankRet = 1008;

}
