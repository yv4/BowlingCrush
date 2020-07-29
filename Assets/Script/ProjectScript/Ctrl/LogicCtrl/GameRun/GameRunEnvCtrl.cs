using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameRunEnvCtrl : AbstractCtrlBase
{
    #region 成员变量

    private Transform m_EnvParent;
    private Transform m_BottlesParent;
    public float MaxLevelLength = 0;//关卡最大长度
    private float m_AddZ = 0;
    private int m_RoadChangeIndex = 0;
    private float m_MaxZ = -1050;

    #region 路段生成相关

    private float m_ChunkZLength = 55;//单个路段长度
    private float m_InitChunkZLenth = -55;//首个路段z位置
    private float m_LastChunkZLenth = 0;//最后一个路段z位置
    private float m_ChunckDisappearLenth = 0;//路段消失距离
    public int ChunkCount = 5;//路段数
    private bool m_HaveSpawnDollorEner = false;//已经产圣美元关入口

    public List<ChunkBehaviour> RoadChunks;//道路路段
    public List<SpawnItemBehaviour> SpawnItems;//生成物

    #endregion

    #region 球瓶生成相关

    public float BottleYPos = 0f;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        m_EnvParent = GameObject.FindWithTag(GameTags.GameRunEnvTag).transform;
        m_BottlesParent = GameObject.FindWithTag(GameTags.BottlesTag).transform;
    }

    protected override void OnInit()
    {
        SpawnAllRoad();
        m_LastChunkZLenth = m_InitChunkZLenth + ChunkCount * m_ChunkZLength - Mathf.Abs(m_ChunckDisappearLenth);
        //PlayEnvEffect();
    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    #region 路段相关

    /// <summary>
    /// 移动控制
    /// </summary>
    /// <param name="enable"></param>
    public void MoveCtrl(bool enable)
    {
        foreach (ChunkBehaviour item in RoadChunks)
        {
            item.MoveCtrl(enable);
        }

        foreach (SpawnItemBehaviour item in SpawnItems)
        {
            item.MoveCtrl(enable);
        }
    }

    /// <summary>
    /// 改变路块
    /// </summary>
    public void ChangeRoad()
    {
        int maxCount = RoadChunks.Count;
        int index = m_RoadChangeIndex % maxCount;
        ChunkBehaviour chunkBeha = RoadChunks[index];
        chunkBeha.transform.localPosition = new Vector3(0, 0, m_MaxZ - GameTags.TriggerChangeRoadDistance * m_RoadChangeIndex);
        m_RoadChangeIndex++;

    }

    /// <summary>
    /// 生成所有路块
    /// </summary>
    public void SpawnAllRoad()
    {
        //for (int i = 0; i < ChunkCount; i++)
        //{
        //    GameObject chunk = ResourcesMgr.Instance.Load(GameTags.RoadChunks);
        //    ChunkBehaviour chunkBeha = chunk.GetComponent<ChunkBehaviour>();
        //    chunkBeha.SetChunkIndex(i);
        //    chunk.transform.SetParent(m_EnvParent);
        //    chunk.transform.localPosition = Vector3.zero;
        //    Vector3 newPos = Vector3.zero;
        //    newPos = new Vector3(0, 0, m_InitChunkZLenth + i * m_ChunkZLength);
        //    chunk.transform.localPosition = newPos;
        //    chunkBeha.SetInitPos(newPos);
        //    m_ChunckDisappearLenth = chunkBeha.GetChunkDisappearLength();
        //    RoadChunks.Add(chunkBeha);
        //}
    }

    public void ReplayGame()
    {
        for (int i = 0; i < RoadChunks.Count; i++)
        {
            ChunkBehaviour chunk = RoadChunks[i];
            chunk.ResetInitPos();
            chunk.gameObject.SetActive(true);
            GameObject meshObj = BaseOption.FindChild(chunk.gameObject, "Mesh");
            if (meshObj != null)
            {
                meshObj.SetActive(true);
            }
            chunk.MoveCtrl(true);

        }

        for (int i = 0; i < SpawnItems.Count; i++)
        {
            SpawnItemBehaviour item = SpawnItems[i];
            item.ResetInitPos();
            item.gameObject.SetActive(true);
            GameObject meshObj = BaseOption.FindChild(item.gameObject, "Mesh");
            if (meshObj!=null)
            {
                meshObj.SetActive(true);
            }
            item.MoveCtrl(true);
        }
    }


    /// <summary>
    /// 重设路块位置
    /// </summary>
    /// <param name="index"></param>
    public void ResetChunk(int index)
    {
        ChunkBehaviour chunkBh = RoadChunks[index];
        chunkBh.ResetChunkPos(m_LastChunkZLenth);
    }

    #endregion

    #region 球瓶相关

    /// <summary>
    /// 生成美元
    /// </summary>
    /// <param name="dollarDatas"></param>
    public void SpwanDollar(List<string[]> dollarDatas)
    {
        SpawnBottlesAndObstacle(dollarDatas, true);
    }

    /// <summary>
    /// 随机生成生成物
    /// </summary>
    public void SpawnRandomItem(List<List<string[]>> bottleDatas, bool isDollar)
    {

        float offSet = 0;
        for (int i = 0; i < bottleDatas.Count; i++)
        {
            List<string[]> itemDatas = bottleDatas[i];

            if (i > 0)
            {
                List<string[]> lastItemDatas = bottleDatas[i - 1];
                string[] posStrs = lastItemDatas[lastItemDatas.Count - 1];
                float z = float.Parse(posStrs[2]);
                offSet += z;
                if (i > 1)
                {
                    string[] firstPoszStr = lastItemDatas[0];
                    float firstZVal = float.Parse(firstPoszStr[2]);
                    offSet -= firstZVal - 100;
                }

                SpawnBottlesAndObstacleWithZOffset(itemDatas, offSet, isDollar);

                if (i == bottleDatas.Count - 1)
                {
                    GameObject end = ResourcesMgr.Instance.Load(GameTags.EndChunkObj, true, true);
                    end.transform.SetParent(m_BottlesParent);
                    List<string[]> tempPosStrs = bottleDatas[i];
                    end.transform.localPosition = new Vector3(0, 0, MaxLevelLength + 100);
                    SpawnItemBehaviour endBeha = end.GetComponent<SpawnItemBehaviour>();
                    endBeha.SetInitPos(end.transform.localPosition);
                    SpawnItems.Add(endBeha);
                }

            }
            else
            {
                SpawnBottlesAndObstacle(itemDatas, isDollar);
            }

        }

        LocalDataMgr.Instance.ResetRandomIndex();


        #region 测试优化

        //StartCoroutine(SpawnSpecial(bottleDatas, isDollar));

        #endregion

    }

    /// <summary>
    /// 销毁附近所有障碍
    /// </summary>
    /// <param name="playerPos"></param>
    public void DisableObstacle(Vector3 playerPos)
    {
        foreach (SpawnItemBehaviour item in SpawnItems)
        {
            if (item is ObstacleBehaviour ||
                item is MoveObstacleBehaviour ||
                item is DownObstacleBehaviour ||
                item is RotateObstacleBehaviour)
            {
                if (Vector3.Distance(playerPos, item.transform.position) < GameTags.DisableRadius)
                {
                    item.gameObject.SetActive(false);
                }
            }
        }


    }

    /// <summary>
    /// 生成球瓶和障碍
    /// </summary>
    public void SpawnBottlesAndObstacle(List<string[]> bottleDatas, bool isDollar)
    {
        if (CheckLevelHaveDollorEnterChance())
        {
            m_HaveSpawnDollorEner = true;
        }
        else
        {
            m_HaveSpawnDollorEner = false;
        }

        if (LocalDataMgr.Instance.EnterDollorLevel)
        {
            m_HaveSpawnDollorEner = false;
        }

        int dollorLevelEnterIndex = -1;


        for (int i = 0; i < bottleDatas.Count; i++)
        {

            if (isDollar)
            {
                if (i == bottleDatas.Count - 1)
                {
                    GameObject end = ResourcesMgr.Instance.Load(GameTags.EndChunkObj, true, true);
                    end.transform.SetParent(m_BottlesParent);
                    string[] tempPosStrs = bottleDatas[i];
                    end.transform.localPosition = new Vector3(0, 0, float.Parse(tempPosStrs[2]) + 100);
                    SpawnItemBehaviour endBeha = end.GetComponent<SpawnItemBehaviour>();
                    endBeha.SetInitPos(end.transform.localPosition);
                    SpawnItems.Add(endBeha);
                }
            }

            string[] item = bottleDatas[i];
            float x = float.Parse(item[0]);
            float y = float.Parse(item[1]);
            float z = float.Parse(item[2]);

            string chunkType = item[3].ToString();
            if (isDollar)
            {
                switch (chunkType)
                {
                    case GameTags.BottleChunck:
                        chunkType = GameTags.DollorChunk;
                        break;
                    case GameTags.FourBottleChunk:
                        chunkType = GameTags.FourDollarChunk;
                        break;
                    case GameTags.TenBottleChunk:
                        chunkType = GameTags.TenDollarChunk;
                        break;
                }

            }


            Vector3 spawnPos = new Vector3(x, 0, z);
            GameObject spawnObj = null;

            if (m_HaveSpawnDollorEner)
            {
                if (dollorLevelEnterIndex == -1)
                {
                    dollorLevelEnterIndex = Random.Range(0, bottleDatas.Count);

                    while (true)
                    {
                        string chunk = bottleDatas[dollorLevelEnterIndex][3];
                        if (chunk.Contains("Obstacle"))
                        {
                            dollorLevelEnterIndex = Random.Range(0, bottleDatas.Count);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            if (i != dollorLevelEnterIndex)
            {
                SpawnBottleWithType(chunkType, spawnObj, spawnPos);
            }
            else
            {
                spawnObj = ResourcesMgr.Instance.Load(GameTags.BounceDollorEnter, true, true);
                spawnObj.transform.SetParent(m_BottlesParent);
                spawnObj.transform.localPosition = spawnPos;
                SpawnItems.Add(spawnObj.GetComponent<SpawnItemBehaviour>());
                dollorLevelEnterIndex = -1;
                m_HaveSpawnDollorEner = false;
            }

          
        }

        if (SpawnItems.Count > 0)
        {
            Transform tran = SpawnItems[SpawnItems.Count - 1].gameObject.transform;
            MaxLevelLength = tran.position.z + GameTags.ZOffset; ;

        }

    }

    /// <summary>
    /// 优化生成
    /// </summary>
    /// <param name="bottleDatas"></param>
    /// <param name="isDollar"></param>
    /// <param name="dollorLevelEnterIndex"></param>
    /// <param name="ZOffset"></param>
    /// <returns></returns>
    private IEnumerator SpawnSpecial(List<List<string[]>> bottleDatas, bool isDollar)
    {
        float offSet = 0;
        int i = 0;
        while(i<bottleDatas.Count)
        {
            List<string[]> itemDatas = bottleDatas[i];

            if (i > 0)
            {
                List<string[]> lastItemDatas = bottleDatas[i - 1];
                string[] posStrs = lastItemDatas[lastItemDatas.Count - 1];
                float z = float.Parse(posStrs[2]);
                offSet += z;
                if (i > 1)
                {
                    string[] firstPoszStr = lastItemDatas[0];
                    float firstZVal = float.Parse(firstPoszStr[2]);
                    offSet -= firstZVal - 100;
                }

                SpawnBottlesAndObstacleWithZOffset(itemDatas, offSet, isDollar);

                if (i == bottleDatas.Count - 1)
                {
                    GameObject end = ResourcesMgr.Instance.Load(GameTags.EndChunkObj, true, true);
                    end.transform.SetParent(m_BottlesParent);
                    List<string[]> tempPosStrs = bottleDatas[i];
                    end.transform.localPosition = new Vector3(0, 0, MaxLevelLength + 100);
                    SpawnItemBehaviour endBeha = end.GetComponent<SpawnItemBehaviour>();
                    endBeha.SetInitPos(end.transform.localPosition);
                    SpawnItems.Add(endBeha);
                }

            }
            else
            {
                SpawnBottlesAndObstacle(itemDatas, isDollar);
            }
            i++;
            yield return new WaitForSeconds(1.5f);
        }


        LocalDataMgr.Instance.ResetRandomIndex();

    }

    /// <summary>
    /// 生成球瓶和障碍带Z轴偏移
    /// </summary>
    public void SpawnBottlesAndObstacleWithZOffset(List<string[]> bottleDatas, float ZOffset, bool isDollar)
    {

        float firstZpos = 0;

        for (int i = 0; i < bottleDatas.Count; i++)
        {

            string[] item = bottleDatas[i];
            float x = float.Parse(item[0]);
            float y = float.Parse(item[1]);
            float z = float.Parse(item[2]);

            if (i == 0)
            {
                firstZpos = z;
            }

            if (ZOffset > 0)
            {
                z -= firstZpos;
                z += ZOffset;
                z += 100;
 
            }

            string chunkType = item[3].ToString();
            if (isDollar)
            {
                switch (chunkType)
                {
                    case GameTags.BottleChunck:
                        chunkType = GameTags.DollorChunk;
                        break;
                    case GameTags.FourBottleChunk:
                        chunkType = GameTags.FourDollarChunk;
                        break;
                    case GameTags.TenBottleChunk:
                        chunkType = GameTags.TenDollarChunk;
                        break;
                }
               
            }

            Vector3 spawnPos = new Vector3(x, y, z);
            GameObject spawnObj = null;

            SpawnBottleWithType(chunkType, spawnObj, spawnPos);
        }

        if (SpawnItems.Count > 0)
        {
            Transform tran = SpawnItems[SpawnItems.Count - 1].gameObject.transform;
            MaxLevelLength = tran.position.z;
        }

 
    }

    /// <summary>
    /// 判断当前关卡生成美元关入口概率
    /// </summary>
    /// <returns></returns>
    private bool CheckLevelHaveDollorEnterChance()
    {
        float percent = LocalDataMgr.Instance.LevelDollorEnterPercent;

        float randomVal = Random.Range(0f, 100);

        if (randomVal <= percent)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// 根据种类生成不同生成物
    /// </summary>
    private float SpawnBottleWithType(string chunkType, GameObject spawnObj, Vector3 spawnPos)
    {
        spawnPos.z += m_AddZ;
        m_AddZ += GameTags.ZOffset;
        switch (chunkType)
        {
            case GameTags.BottleChunck:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.BottleObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.StaticObstacleChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.StaticObstacleObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.MoveObstacleChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.MoveObstacleObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.RotateObstacleChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.RotateObstacleObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.DollorChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.BounceDollorObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = new Vector3(spawnPos.x,0,spawnPos.z);
                }
                break;
            case GameTags.FourDollarChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.FourBounceDollorObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.TenDollarChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.TenBounceDollorObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.FourBottleChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.FourBottleObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.TenBottleChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.TenBottleObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;
            case GameTags.DownObstacleChunk:
                {
                    spawnObj = ResourcesMgr.Instance.Load(GameTags.DownObstacleChunkObj, true, true);
                    spawnObj.transform.SetParent(m_BottlesParent);
                    spawnObj.transform.localPosition = spawnPos;
                }
                break;

            default:
                break;
        }

        SpawnItemBehaviour beha = spawnObj.GetComponent<SpawnItemBehaviour>();
        beha.SetInitPos(spawnPos);
        if (beha is BottleBehaviour)
        {
            string mesh = LocalDataMgr.Instance.GetCurrentMesh();
            if (mesh.Equals(""))
            {
                mesh = LocalDataMgr.Instance.GetRandomMesh();
            }
            ((BottleBehaviour)beha).SetMesh(mesh);
        }

        SpawnItems.Add(beha);
        return beha.gameObject.transform.position.z;

    }

    #endregion

    /// <summary>
    /// 播放场景特效
    /// </summary>
    private void PlayEnvEffect()
    {
        int index = LocalDataMgr.Instance.EnvEffectIndex;

        GameObject effects = GameObject.FindWithTag("EnvEffect");

        if (index != -1)
        {
            effects.transform.GetChild(index).gameObject.SetActive(true);
        }

    }

    #endregion\

    #region 委托方法

    #endregion
}
