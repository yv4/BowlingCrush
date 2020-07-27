using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CodeStage.AntiCheat.ObscuredTypes;
using MobiiGame.Sdk.Base;
using UnityEngine;

namespace MobiiGame.Sdk.Gift
{
    [System.Serializable]
    public class ViceModel
    {
        public string name;
        public int type_id;
        public Dictionary<string, int> dollar;   //激励配置
        public Dictionary<string, int> probability; //概率配置
        public bool limit_cap;

        // 按元获取现金，保留2位小数点
        public ObscuredInt GetRewardValue()
        {
            if (dollar == null)
                return 0;

            //得到当前模块的钱的领取次数
            int showTimes = DataManager.GetViceModelRewardTimesOfTotal(type_id);

            // 判断总的展示次数是否超过了奖励的最大值
            if (showTimes >= dollar.Count)
            {
                return dollar[dollar.Keys.Last<string>()];
            }
            //得到下一次要领取的钱是多少并返回
            return dollar[(showTimes + 1).ToString()];
        }

        /// <summary>
        /// 得到概率
        /// </summary>
        /// <returns></returns>
        public ObscuredInt GetProbability()
        {
            LogSdk.Log("读取副模块概率");
            ObscuredInt res = probability.Values.ToArray()[0];
            return res;
        }
    }

    [System.Serializable]
    public class GiftCard
    {
        public int code;        //200显示 401隐藏
        public string email;//客服邮箱
        public Dictionary<string, int> dollar;   //激励配置
        public Dictionary<string, int> limit;     //次数限制配置,某一天的限制次数，用户来一天+1
        public Dictionary<string, int> probability; //概率配置
        public Dictionary<string, ViceModel> vice_model; //副模块配置表

        //获取配置
        public ObscuredInt GetLimit()
        {
            ObscuredInt limit = GetLimit(DataManager.LimitIndex);
            if (limit == -1)
            {
                DataManager.LimitIndex++;
                limit = GetLimit(DataManager.LimitIndex);
            }

            LogSdk.Log("第" + DataManager.UserActiveDays + "天活跃，限制次数:" + DataManager.ShowTimesOfDay + "/" + limit);

            return limit;
        }

        private ObscuredInt GetLimit(int index)
        {

            string key = limit.Keys.ToArray()[index];
            string[] limits = key.Split(',');
            if (DataManager.UserActiveDays >= int.Parse(limits[0])
                && DataManager.UserActiveDays <= int.Parse(limits[1]))
            {
                return limit.Values.ToArray()[index];
            }
            // 如果下一个下标超过了限制次数数组的下标，则用最后的那个限制次数值
            if ((index + 1) >= limit.Keys.Count)
            {
                return limit.Values.ToArray()[index];
            }

            return -1;
        }

        /// <summary>
        /// 得到主模块概率
        /// </summary>
        /// <returns></returns>
        public ObscuredInt GetMainProbability()
        {
            ObscuredInt probability = GetProbability(DataManager.MainProbabilityIndex);
            if (probability == -1)
            {
                DataManager.MainProbabilityIndex++;
                probability = GetProbability(DataManager.MainProbabilityIndex);
            }

            return probability;
        }

        private ObscuredInt GetProbability(int index)
        {
            LogSdk.Log("读取第[" + index + "]个概率");
            string key = probability.Keys.ToArray()[index];
            string[] limits = key.Split(',');

            //判断是否在这个概率区间
            if (DataManager.CardProbabilityTimesOfTotal >= int.Parse(limits[0]) && DataManager.CardProbabilityTimesOfTotal <= int.Parse(limits[1]))
            {
                return probability.Values.ToArray()[index];
            }
            // 如果下一个下标超过了概率数组的下标，则用最后的那个概率值
            if ((index + 1) >= probability.Keys.Count)
            {
                return probability.Values.ToArray()[index];
            }
            return -1;
        }
        // 按元获取现金，保留2位小数点
        public ObscuredInt GetRewardValue()
        {
            if (dollar == null)
                return 0;
            int showTimes = DataManager.GetMainRewardTimesOfTotal;
            LogSdk.Log("读取第[" + showTimes + "]个奖励");
            // 判断总的展示次数是否超过了奖励的最大值
            if (showTimes >= dollar.Count)
            {
                return dollar[dollar.Keys.Last<string>()];
            }
            return dollar[(showTimes + 1).ToString()];
        }

        // 获取最大激励展示次数
        public int GetMaxRewardShowTimes()
        {
            return dollar.Count;
        }

        // 按分获取现金数
        public int GetRewardValueInt()
        {
            return (int)GetRewardValue();
        }

        public static GiftCard CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<GiftCard>(jsonString);
        }
    }
}