using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using LitJson;
using System.Text;

public class LocalDataMgr : Singleton<LocalDataMgr>
{

    #region Model成员

    private ShopItemModel m_ShopItemModel;
    private MissionModel m_MissionModel;
    private DollorMissionModel m_DollorMissionModel;
    private SpawnConfigModel m_SpawnConfigModel;
    private BounceCoinConfigModel m_BouncCoinConfigModel;

    #endregion

    private int m_RandomMeshIndex = -1;
    public float LevelDollorEnterPercent = 28;
    public bool EnterDollorLevel = false;
    private float m_levelRunSpeed = 400;
    public int EasyCount = 1;
    public int NormalCount = 2;
    public int HardCount = 3;
    public int EnvEffectIndex = -1;
    public float LevelRunSpeed { get => m_levelRunSpeed; set => m_levelRunSpeed = value; }

    public LocalDataMgr()
    {
        #region 初始化成员

        m_ShopItemModel = new ShopItemModel();
        m_MissionModel = new MissionModel();
        m_DollorMissionModel = new DollorMissionModel();
        m_SpawnConfigModel = new SpawnConfigModel();
        m_BouncCoinConfigModel = new BounceCoinConfigModel();

        #endregion
    }

    #region 成员方法

    /// <summary>
    /// 获取当前球瓶皮肤
    /// </summary>
    /// <returns></returns>
    public string GetCurrentMesh()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();

        MissionEntity mission = m_MissionModel.Get(user.CurrentMission);

        if (mission != null)
        {
            if (!mission.MeshName.Equals("1"))
            {
                return mission.MeshName;
            }
            return "";
        }
        else
        {
            return "";
        }
    }


    /// <summary>
    /// 获取随机皮肤
    /// </summary>
    /// <returns></returns>
    public string GetRandomMesh()
    {
        List<MissionEntity> missions = m_MissionModel.GetList();
        if (m_RandomMeshIndex == -1)
        {
            int index = Random.Range(0, missions.Count);
            m_RandomMeshIndex = index;
            return missions[index].MeshName;
        }
        else
        {
            return missions[m_RandomMeshIndex].MeshName;

        }
    }


    /// <summary>
    /// 获取关卡配置
    /// </summary>
    /// <returns></returns>
    public string GetLevelConfig()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        int mission = user.CurrentMission;

        List<SpawnConfigEntity> spawnConfigs = m_SpawnConfigModel.GetList();
        SpawnConfigEntity config = spawnConfigs.Find(p =>
       {
           string border = p.Border;
           string[] borderStrs = BaseOption.SpliteStr('-', p.Border);
           int upBorderVal = int.Parse(borderStrs[0]);
           int downBorderVal = int.Parse(borderStrs[1]);
           if (mission >= upBorderVal && mission <= downBorderVal)
           {
               return true;
           }
           return false;
       });

        StringBuilder sb = new StringBuilder();
        if (config != null)
        {
            sb.Append(config.EasyCount.ToString());
            sb.Append(",");
            sb.Append(config.NormalCount.ToString());
            sb.Append(",");
            sb.Append(config.HardCount.ToString());
        }


        return sb.ToString();

    }



    /// <summary>
    /// 获取任务回报皮肤
    /// </summary>
    /// <returns></returns>
    public int GetRewardBallMesh()
    {
        int retVal = 0;
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        user.RewardBallIndex += 1;
        if (user.RewardBallIndex>3)
        {
            return -1;
        }
        
        List<ShopItemEntity> shopItems = m_ShopItemModel.GetList();
        List<ShopItemEntity> rewardItems = shopItems.Where(p => p.BuyCoin < 0).ToList();
        ShopItemEntity shopItem = rewardItems[user.RewardBallIndex];
        if (shopItem != null)
        {
            UserPeresistData.Instance.AddBall(shopItem.Id);
            return retVal = shopItem.Id; ;
        }
        else
        {
            retVal = -1;
            return retVal;
        }

    }

    /// <summary>
    /// 重置随机索引
    /// </summary>
    public void ResetRandomIndex()
    {
        m_RandomMeshIndex = -1;
    }

    /// <summary>
    /// 获取商品列表
    /// </summary>
    /// <returns></returns>
    public List<ShopItemEntity> GetShopItemList()
    {
        return m_ShopItemModel.GetList();

    }

    /// <summary>
    /// 通过Id获取商品项
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ShopItemEntity GetShipItemWithId(int id)
    {
        return m_ShopItemModel.Get(id);
    }

    /// <summary>
    /// 根据数据初始化玩家
    /// </summary>
    public GameObject InitPlayer()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        int currentBallId = user.CurrentBall;

        Dictionary<string, string> para = new Dictionary<string, string>();
        para.Add("Mesh", currentBallId.ToString());
        BaseOption.SetRecord(GameTags.UseBallRecord, para);

        ShopItemEntity shopItemData = LocalDataMgr.Instance.GetShipItemWithId(currentBallId);
        string meshPath = GameTags.BallMesh;
        StringBuilder sb = new StringBuilder(meshPath);
        sb.Append(shopItemData.MeshName);
        GameObject meshObj = ResourcesMgr.Instance.Load(sb.ToString(), true, true);
        return meshObj;
    }


    /// <summary>
    /// 获取所有已购买物品
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public List<ShopItemEntity> GetAllHaveBuyItems()
    {
        List<ShopItemEntity> allItem = m_ShopItemModel.GetList();
        string haveBuyIds = UserPeresistData.Instance.GetUserResource().BallIds;
        string[] haveBuyIdVal = BaseOption.SpliteStr(',', haveBuyIds);
        List<ShopItemEntity> haveBuyItems = new List<ShopItemEntity>();
        foreach (string idStr in haveBuyIdVal)
        {
            int idVal = int.Parse(idStr);
            ShopItemEntity buyItem = allItem.Find(s => { return s.Id == idVal; });
            haveBuyItems.Add(buyItem);
        }


        return haveBuyItems;
    }

    /// <summary>
    /// 获取随机美元关
    /// </summary>
    public DollorMissionEntity GetRandomDollorMission()
    {
        List<DollorMissionEntity> missions = m_DollorMissionModel.GetList();
        int randomIndex = Random.Range(0, missions.Count);
        return missions[randomIndex];
    }

    /// <summary>
    /// 获取随机皮肤
    /// </summary>
    public void GetRandomBallMesh()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        string[] ballIds = BaseOption.SpliteStr(',', user.BallIds);
        List<int> ballIdList = new List<int>();
        foreach (string ballId in ballIds)
        {
            ballIdList.Add(int.Parse(ballId));
        }

    }

    /// <summary>
    /// 获取当前关卡速度
    /// </summary>
    public void GetCurrentLevelSpeed()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        int mission = user.CurrentMission;
        MissionEntity missionData = m_MissionModel.Get(mission);
        if (missionData != null)
        {
            this.LevelRunSpeed = missionData.Speed;
            //this.LevelRunSpeed = 400f;
        }
        else
        {
            this.LevelRunSpeed = 500f;
        }

    }

    public BounceCoinConfigEntity GetBounceCoinPercent(bool win, int coin)
    {
        List<BounceCoinConfigEntity> bounceList = null;
        if (win)
        {
            bounceList = m_BouncCoinConfigModel.GetList().Where(p => p.WinFail == 1).ToList();
        }
        else
        {
            bounceList = m_BouncCoinConfigModel.GetList().Where(p => p.WinFail == 0).ToList();
        }

        BounceCoinConfigEntity bounceData = bounceList.Find(p =>
        {
            string border = p.Border;
            string[] borderStrs = BaseOption.SpliteStr('-', p.Border);
            if (borderStrs.Length>1)
            {
                int upBorderVal = int.Parse(borderStrs[0]);
                int downBorderVal = int.Parse(borderStrs[1]);
                if (coin >= upBorderVal && coin <= downBorderVal)
                {
                    return true;
                }
            }
            else
            {
                int upBorderVal = int.Parse(borderStrs[0]);
                if (coin >= upBorderVal)
                {
                    return true;
                }
            }
        
            return false;
        });

        return bounceData;
    }

    #endregion

}

