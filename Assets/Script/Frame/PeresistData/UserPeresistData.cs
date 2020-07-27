using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class UserPeresistData : Singleton<UserPeresistData>
{

    private UserResourceEntity m_UserResource = new UserResourceEntity();
    private List<Dictionary<string, int>> m_CurUserOwnItems;

    public void InitData()
    {
        LoadUseResource();
        //InitUserData();
    }

    private void LoadUseResource()
    {
        if (!LoadFromJson())
        {
            InitUserData();
            SaveToJson();
        }
    }

    public UserResourceEntity GetUserResource()
    {
        if (m_UserResource.BallIds.Equals(""))
        {
            InitData();
        }
        return m_UserResource;
    }


    /// <summary>
    /// 消耗金币
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public bool CostCoin(int count)
    {
        bool check = false;
        if ((m_UserResource.CoinCount - count) >= 0)
        {
            m_UserResource.CoinCount -= count;
            return check = true;
        }

        if (check)
        {
            m_UserResource.CoinCount -= count;
        }

        return check;
    }

    /// <summary>
    /// 添加保龄球到已拥有
    /// </summary>
    public void AddBall(int ballId)
    {
        string idStr = m_UserResource.BallIds;
        StringBuilder sb = new StringBuilder(idStr);
        sb.Append(",");
        sb.Append(ballId);
        m_UserResource.BallIds = sb.ToString();
        UserPeresistData.Instance.SaveToJson();
    }


    #region 其他

    private void InitUserData()
    {
        m_UserResource.CoinCount = 0;
        m_UserResource.DollorCount = 0;
        //m_UserResource.BallIds = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27";
        m_UserResource.BallIds = "1";
        m_UserResource.RewardBallIndex = -1;
        m_UserResource.CurrentBall = 1;
        m_UserResource.CurrentMission = 1;
        m_UserResource.HaveTask = -1;
        m_UserResource.TaskType = -1;
        m_UserResource.TaskCompleteCount = 0;
        m_UserResource.FinishStarCount = 0;

    }

    /// <summary>
    /// 存储为Json
    /// </summary>
    public void SaveToJson()
    {

        JsonData user = new JsonData();
        user["CoinCount"] = m_UserResource.CoinCount;
        user["DollorCount"] = m_UserResource.DollorCount;
        user["BallIds"] = m_UserResource.BallIds;
        user["RewardBallIndex"] = m_UserResource.RewardBallIndex;
        user["CurrentBall"] = m_UserResource.CurrentBall;
        user["CurrentMission"] = m_UserResource.CurrentMission;
        user["HaveTask"] = m_UserResource.HaveTask;
        user["TaskType"] = m_UserResource.TaskType;
        user["TaskCompleteCount"] = m_UserResource.TaskCompleteCount;
        user["FinishStarCount"] = m_UserResource.FinishStarCount;
        BaseOption.SaveJsonTxtToLocal("PeresistData", user.ToJson());

    }

    /// <summary>
    /// 读取为Json
    /// </summary>
    public bool LoadFromJson()
    {
        string jsonTxt = BaseOption.LoadJsonTxtFromLocal("PeresistData");
        if (jsonTxt != null)
        {
            JsonData user = LitJson.JsonMapper.ToObject(jsonTxt);
            m_UserResource.CoinCount = int.Parse(user["CoinCount"].ToString());
            m_UserResource.DollorCount = float.Parse(user["DollorCount"].ToJson());
            m_UserResource.BallIds = user["BallIds"].ToString();
            m_UserResource.RewardBallIndex = int.Parse(user["RewardBallIndex"].ToString());
            m_UserResource.CurrentBall = int.Parse(user["CurrentBall"].ToString());
            m_UserResource.CurrentMission = int.Parse(user["CurrentMission"].ToString());
            m_UserResource.HaveTask = int.Parse(user["HaveTask"].ToString());
            m_UserResource.TaskCompleteCount = int.Parse(user["TaskCompleteCount"].ToString());
            m_UserResource.FinishStarCount = int.Parse(user["FinishStarCount"].ToString());
            m_UserResource.TaskType = int.Parse(user["TaskType"].ToString());
            return true;
        }

        return false;
    }

    /// <summary>
    /// 获取随机任务
    /// </summary>
    public void GetRandomTask()
    {
        if (m_UserResource != null)
        {

            m_UserResource.HaveTask = 1;
            int randVal = Random.Range(0, 4);
            m_UserResource.TaskType = randVal;
            m_UserResource.TaskCompleteCount = 0;
            m_UserResource.FinishStarCount = 0;
            m_UserResource.HaveTask = 1;

        }

    }

    /// <summary>
    /// 处理任务
    /// </summary>
    public void HandleTask(TaskType taskType,int count=0)
    {
        if (taskType == (TaskType)m_UserResource.TaskType)
        {
            if (count==0)
            {
                m_UserResource.TaskCompleteCount++;
            }
            else
            {
                m_UserResource.TaskCompleteCount += count;
            }
        }
    }

    /// <summary>
    /// 处理金币任务
    /// </summary>
    /// <param name="coin"></param>
    public void HandleCoinTask(int coin)
    {
        m_UserResource.TaskCompleteCount += coin;
    }

    #endregion

}
