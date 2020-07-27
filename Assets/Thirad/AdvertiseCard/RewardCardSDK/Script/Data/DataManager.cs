using MobiiGame.Sdk.Base;
using UnityEngine;
using CodeStage.AntiCheat.Storage;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using CodeStage.AntiCheat.ObscuredTypes;
using System.Linq;

namespace MobiiGame.Sdk.Gift
{
    /// <summary>
    /// 本地数据管理类 
    /// </summary>
    public static class DataManager
    {
        static ObscuredString rsdk_uid = "U_m_I_f_D_y";
        static ObscuredString[] rsdk_gold_coin = new ObscuredString[] { "&& EAX %", "&EAX%EDX A" };
        static ObscuredString rsdk_google_adid = "gg_mfy_adid";
        static ObscuredString rsdk_debug_mode = "ceshi_mfy_moshi";
        static ObscuredString rsdk_email = "you_mfy_x";
        static ObscuredString rsdk_paypal = "ti_mfy_xianpp";
        static ObscuredString rsdk_submit = "ti_mfy_jiao";
        static ObscuredString rsdk_submit_config = "tij_mfy_pz";
        static ObscuredString rsdk_show_warning = "xian_mfy_shijg";
        static ObscuredString rsdk_play_time = "shi_mfy_jian";
        static ObscuredString rsdk_CardProbabilityTimesOfTotal = "c_mfy_tt";
        static ObscuredString rsdk_ShowTimesOfDay = "st_mfy_of";
        static ObscuredString rsdk_CardTotalShowTimes = "cs_mfy_t";
        static ObscuredString rsdk_LimitIndex = "xz_mfy_xb";
        static ObscuredString rsdk_ProbabilityIndex = "p_mfy_i";
        static ObscuredString rsdk_UserActiveDays = "ua_mfy_d";
        static ObscuredString rsdk_UserPlayDate = "upd_mfy_upd";
        static ObscuredString rsdk_app_version = "v_mfy_v";
        static ObscuredString rsdk_allDailyData = "dad";
        static ObscuredString rsdk_getCardReward_count = "gCR_c";
        static ObscuredString rsdk_ziran = "ziranll";
        static ObscuredString rsdk_rc_version = "rc_mfy_v";

        static ObscuredString rsdk_fb_user_id = "uifbd";

        static ObscuredString rsdk_vice_model_data = "vimodta";

        static ObscuredString rsdk_vice_model_probability = "vimodtaproindex";

        public static bool InitComplete = false;//记录sdk是否初始化成功

        //fb是否已经登录
        public static ObscuredBool FBIsLogin
        {
            get
            {
                if (string.IsNullOrEmpty(FBUserId))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //fb的userid
        public static ObscuredString FBUserId
        {
            get { return ObscuredPrefs.GetString(rsdk_fb_user_id); }
            set { ObscuredPrefs.SetString(rsdk_fb_user_id, value); }
        }

        public static ObscuredString UID
        {
            get { return ObscuredPrefs.GetString(rsdk_uid); }
            set { ObscuredPrefs.SetString(rsdk_uid, value); }
        }


        //当前有多少钱，加密方式保存
        //public static float GoldCoin
        //{
        //    get { return CryptoPrefs.GetFloat("rsdk_gold_coin"); }
        //    set { CryptoPrefs.SetFloat("rsdk_gold_coin", value); }
        //}
        public static int GoldCoin
        {
            get
            {
                int[] gold_values = new int[rsdk_gold_coin.Length];
                for (int i = 0; i < gold_values.Length; i++)
                {
                    var c = GPCCryptography.Take(i);
                    string cstr = ObscuredPrefs.GetString(rsdk_gold_coin[i], c.Encode("0"));
                    string temp = c.Decode(cstr);
                    if (int.TryParse(temp, out int v))
                    {
                        gold_values[i] = v;
                    }
                    else
                    {
                        gold_values[i] = (int)(float.Parse(temp) * 100);
                    }
                }
                int gold = gold_values[0];
                if (gold_values.Length > 1)
                    gold = Mathf.Min(gold_values[0], gold_values[1]);
                return gold;
            }
            set
            {
                for (int i = 0; i < rsdk_gold_coin.Length; i++)
                {
                    ObscuredPrefs.SetString(rsdk_gold_coin[i], GPCCryptography.Take(i).Encode(value.ToString()));
                }
            }
        }

        //储存的所有每日数据
        public static Dictionary<string, DailyData> AllDailyData
        {
            get
            {
                if (!ObscuredPrefs.HasKey(rsdk_allDailyData))
                {
                    AllDailyData = new Dictionary<string, DailyData>();
                }
                return JsonConvert.DeserializeObject<Dictionary<string, DailyData>>(ObscuredPrefs.GetString(rsdk_allDailyData));
            }
            set
            {
                if (value==null)
                {
                    value = new Dictionary<string, DailyData>();
                }
                ObscuredPrefs.SetString(rsdk_allDailyData, JsonConvert.SerializeObject(value));
            }
        }

        //得到最近一周的每日数据
        public static Dictionary<string, DailyData> Day7DailyData
        {
            get
            {
                if (!ObscuredPrefs.HasKey(rsdk_allDailyData))
                {
                    AllDailyData = new Dictionary<string, DailyData>();
                }
                var allDailyData = JsonConvert.DeserializeObject<Dictionary<string, DailyData>>(ObscuredPrefs.GetString(rsdk_allDailyData));
                var res = new Dictionary<string, DailyData>();
                for (int i = allDailyData.Count, j = 0; i > 0 && j < 7; i--, j++)
                {
                    var item = allDailyData.ElementAt(i - 1);
                    res.Add(item.Key, item.Value);
                }
                return res;
            }
        }

        /// <summary>
        /// 得到当天的数据
        /// </summary>
        /// <returns></returns>
        public static DailyData GetDailyDataByDateNow()
        {
            var timeNow = TimeNow;
            return GetDailyDataByDateTime(timeNow);
        }

        /// <summary>
        /// 根据日期得到对应的当天的数据
        /// </summary>
        /// <param name="timeNow">日期（yyyy-MM-dd）</param>
        /// <returns></returns>
        public static DailyData GetDailyDataByDateTime(string timeNow)
        {
            var dd = AllDailyData;
            if (!dd.ContainsKey(timeNow))
            {
                dd.Add(timeNow, new DailyData());
                AllDailyData = dd;
            }
            var ddbdt = AllDailyData[timeNow];
            //计算平均相应时长（总相应时长/请求次数）
            //ddbdt.response_time = ddbdt.response_total_time / (ddbdt.response_times <= 0 ? 1 : ddbdt.response_times);
            return ddbdt;
        }

        /// <summary>
        /// 根据日期保存对应的当天数据
        /// </summary>
        /// <param name="timeNow">日期（yyyy-MM-dd）</param>
        /// <param name="dd">当天数据</param>
        public static void SaveDailyDataByDateTime(string timeNow, DailyData dd)
        {
            var add = AllDailyData;
            if (!add.ContainsKey(timeNow))
            {
                add.Add(timeNow, new DailyData());
            }
            add[timeNow] = dd;
            //自己=自己 走 set 保存数据
            AllDailyData = add;
        }

        public static string TimeNow
        {
            get
            {
                //优先使用服务器时间，如果服务器时间有问题，则获取本地时间
                var res = RewardGiftSDK.Ins.GetServerDateTime();
                //if (string.IsNullOrEmpty(res))
                //{
                //    res = DateTime.Now.ToString("yyyy-MM-dd");
                //}
                return res;
            }
        }

        // 保存 google adid，加密保存
        public static string GoogleAdId
        {
            get { return ObscuredPrefs.GetString(rsdk_google_adid); }
            set { ObscuredPrefs.SetString(rsdk_google_adid, value); }
        }

        // 是否为Debug模式
        public static bool IsDebugMode
        {
            get { return bool.Parse(ObscuredPrefs.GetString(rsdk_debug_mode, false.ToString())); }
            set { ObscuredPrefs.SetString(rsdk_debug_mode, value.ToString()); }
        }

        // 保存用户的email
        public static string Email
        {
            get { return ObscuredPrefs.GetString(rsdk_email); }
            set { ObscuredPrefs.SetString(rsdk_email, value); }
        }

        // 保存用户的paypal账号
        public static string Paypal
        {
            get { return ObscuredPrefs.GetString(rsdk_paypal); }
            set { ObscuredPrefs.SetString(rsdk_paypal, value); }
        }

        // 是否存在adid key
        public static bool HasGoogleAdid
        {
            get { return ObscuredPrefs.HasKey(rsdk_google_adid); }
        }

        // 用户是否提交的提现申请
        public static bool HasSubmit
        {
            get { return bool.Parse(ObscuredPrefs.GetString(rsdk_submit, false.ToString())); }

            set { ObscuredPrefs.SetString(rsdk_submit, value.ToString()); }
        }

        // 用户是否进行了提现申请的确认，即提现申请已经上传到服务器
        public static bool HasSubmitConfig
        {
            get { return bool.Parse(ObscuredPrefs.GetString(rsdk_submit_config, false.ToString())); }

            set { ObscuredPrefs.SetString(rsdk_submit_config, value.ToString()); }
        }

        // 是否显示警告界面
        public static bool ShowWarningUI
        {
            get { return bool.Parse(ObscuredPrefs.GetString(rsdk_show_warning, false.ToString())); }
            set { ObscuredPrefs.SetString(rsdk_show_warning, value.ToString()); }
        }

        // 用户玩游戏时间长，按分钟计算
        public static int PlayTimes
        {
            get { return ObscuredPrefs.GetInt(rsdk_play_time); }
            set { ObscuredPrefs.SetInt(rsdk_play_time, value); }
        }

        //主模块请求展示卡片次数（但因为有概率显示，不一定每次显示）
        public static int CardProbabilityTimesOfTotal
        {
            get { return ObscuredPrefs.GetInt(rsdk_CardProbabilityTimesOfTotal); }
            set { ObscuredPrefs.SetInt(rsdk_CardProbabilityTimesOfTotal, value); }
        }

        // 用户当天展示次数，通过该值判断是否超过当天的显示上限值(Limit)，每次启动app的时候判断是否清0
        public static int ShowTimesOfDay
        {
            get { return ObscuredPrefs.GetInt(rsdk_ShowTimesOfDay); }
            set { ObscuredPrefs.SetInt(rsdk_ShowTimesOfDay, value); }
        }
        // 卡片总的展示次数, 卡片展示出来+1
        public static int CardShowTimesOfTotal
        {
            get { return ObscuredPrefs.GetInt(rsdk_CardTotalShowTimes); }
            set { ObscuredPrefs.SetInt(rsdk_CardTotalShowTimes, value); }
        }

        //钱真正领取的次数, 通过总的领取次数获取当天的激励值
        public static int GetMainRewardTimesOfTotal
        {
            get { return ObscuredPrefs.GetInt(rsdk_getCardReward_count); }
            set { ObscuredPrefs.SetInt(rsdk_getCardReward_count, value); }
        }


        //副模块钱真正领取的次数, 通过总的领取次数获取当天的激励值
        public static int GetViceModelRewardTimesOfTotal(int viceModelId)
        {
            return ObscuredPrefs.GetInt(rsdk_vice_model_data + viceModelId.ToString());
        }

        public static void SetViceModelRewardTimesOfTotal(int viceModelId,int value)
        {
            ObscuredPrefs.SetInt(rsdk_vice_model_data + viceModelId.ToString(), value);
        }

        // 记录概率表的下标，方便快速定位概率数组
        public static int MainProbabilityIndex
        {
            get { return ObscuredPrefs.GetInt(rsdk_ProbabilityIndex); }
            set { ObscuredPrefs.SetInt(rsdk_ProbabilityIndex, value); }
        }


        // 记录副模块概率表的下标，方便快速定位概率数组
        public static int GetViceModelProbabilityIndex(int viceModelId)
        {
            return ObscuredPrefs.GetInt(rsdk_vice_model_probability + viceModelId.ToString());
        }

        public static void SetViceModelProbabilityIndex(int viceModelId, int value)
        {
            ObscuredPrefs.SetInt(rsdk_vice_model_probability + viceModelId.ToString(), value);
        }

        // 记录限制表的下标，方便快速定位限制表数组
        public static int LimitIndex
        {
            get { return ObscuredPrefs.GetInt(rsdk_LimitIndex); }
            set { ObscuredPrefs.SetInt(rsdk_LimitIndex, value); }
        }

        // 保存用户活跃天数，来一天，则 +1
        public static int UserActiveDays
        {
            get { return ObscuredPrefs.GetInt(rsdk_UserActiveDays); }
            set { ObscuredPrefs.SetInt(rsdk_UserActiveDays, value); }
        }

        // 保存用户进入游戏日期，为了判断用户的活跃天数
        public static string UserPlayDate
        {
            get { return ObscuredPrefs.GetString(rsdk_UserPlayDate); }
            set { ObscuredPrefs.SetString(rsdk_UserPlayDate, value); }
        }

        // 保存一下当前版本号
        public static string AppVersion
        {
            get { return ObscuredPrefs.GetString(rsdk_app_version); }
            set { ObscuredPrefs.SetString(rsdk_app_version, value); }
        }

        //保存激励卡版本
        public static string RCSdkVersion
        {
            get { return ObscuredPrefs.GetString(rsdk_rc_version); }
            set { ObscuredPrefs.SetString(rsdk_rc_version, value); }
        }

        /// <summary>
        /// 是否为自然流量（只有在刚开始的时候判断，后面不管）
        /// </summary>
        public static bool Natural
        {
            get { return ObscuredPrefs.GetBool(rsdk_ziran); }
            set { ObscuredPrefs.SetBool(rsdk_ziran, value); }
        }
    }
}