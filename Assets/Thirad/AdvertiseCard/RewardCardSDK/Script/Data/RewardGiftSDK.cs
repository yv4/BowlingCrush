using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using Newtonsoft.Json;
using System;
using System.IO;
using MobiiGame.Sdk.Event;
using MobiiGame.Sdk.Base;
using MobiiGame.Common;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Storage;
using System.Linq;
using System.Runtime.InteropServices;

namespace MobiiGame.Sdk.Gift
{
    // 激励卡片sdk封装
    public enum Country
    {
        China,
        Foreign,
    }

    public class RewardGiftSDK : MonoBehaviour
    {
        private static RewardGiftSDK ins;
        public static RewardGiftSDK Ins
        {
            get
            {
                if (ins==null)
                {
                    Debug.Log("请在窗景中创建“激励卡”（在Hierarchy窗口的空白处点击鼠标右键 -> Create Reward），详情请查看接入文档！");
                }
                return ins;
            }
            set => ins = value;
        }

        [SerializeField]
        public Country country = Country.Foreign;//sdk版本

        public const string rewardVersion = "7.1";//sdk版本号

        private const bool OpenEncrypt = true;//是否打开数据加密模式
        private const bool OpenLocalRewardData = false;//是否打开激励数据本地缓存的功能

        private const bool CheckTimeStamp = false;//是否打开时间戳判断（防止用户修改时间）
        private const bool DebugForceNoNatural = false;//是否强制非自然量（用于测试）
        private const string DebugAndroidId = "test-device-id-11";//编辑器状态下测试的androidid

        [SerializeField]
        private const string ROOT_URL = null;//"http://10.10.1.11:9988";//本地测试，线上要置为null
        private const string ROOT_URL_CN = "https://reward.love6522.com";//国内
        private const string ROOT_URL_FO = "https://reward.bfesx.xyz";//国外
        private const string GET_REWARD_DATA_API = "/v2/config";   // 获取配置参数
        private const string POST_API = "/v2/user";      // 同步本地数据接口
        private const string DRAW_API = "/v2/cash";   // 提现接口
        private const string GET_SERVER_DATETIME_API = "/time";//获取服务器时间
        private const string GET_RANKINGLIST_DATA_API = "/v2/winning";//得到排行榜数据

        public static string GetServerDateTimeUrl
        {
            get
            {
                string res = null;
                if (!string.IsNullOrEmpty(ROOT_URL))
                {
                    res = ROOT_URL + GET_SERVER_DATETIME_API;
                }
                else
                {
                    switch (Ins.country)
                    {
                        case Country.China:
                            res = ROOT_URL_CN + GET_SERVER_DATETIME_API;
                            break;
                        case Country.Foreign:
                            res = ROOT_URL_FO + GET_SERVER_DATETIME_API;
                            break;
                    }
                }
                return res;
            }
        }

        public static string GetRankingListDataUrl
        {
            get
            {
                string res = null;
                if (!string.IsNullOrEmpty(ROOT_URL))
                {
                    res = ROOT_URL + GET_RANKINGLIST_DATA_API;
                }
                else
                {
                    switch (Ins.country)
                    {
                        case Country.China:
                            res = ROOT_URL_CN + GET_RANKINGLIST_DATA_API;
                            break;
                        case Country.Foreign:
                            res = ROOT_URL_FO + GET_RANKINGLIST_DATA_API;
                            break;
                    }
                }
                return res;
            }
        }

        public static string GetRewardDataUrl
        {
            get
            {
                string res = null;
                if (!string.IsNullOrEmpty(ROOT_URL))
                {
                    res = ROOT_URL + GET_REWARD_DATA_API;
                }
                else
                {
                    switch (Ins.country)
                    {
                        case Country.China:
                            res = ROOT_URL_CN + GET_REWARD_DATA_API;
                            break;
                        case Country.Foreign:
                            res = ROOT_URL_FO + GET_REWARD_DATA_API;
                            break;
                    }
                }
                return res;
            }
        }
        public static string PostUrl
        {
            get
            {
                string res = null;
                if (!string.IsNullOrEmpty(ROOT_URL))
                {
                    res = ROOT_URL + POST_API;
                }
                else
                {
                    switch (Ins.country)
                    {
                        case Country.China:
                            res = ROOT_URL_CN + POST_API;
                            break;
                        case Country.Foreign:
                            res = ROOT_URL_FO + POST_API;
                            break;
                    }
                }
                return res;
            }
        }public static string DrawUrl
        {
            get
            {
                string res = null;
                if (!string.IsNullOrEmpty(ROOT_URL))
                {
                    res = ROOT_URL + DRAW_API;
                }
                else
                {
                    switch (Ins.country)
                    {
                        case Country.China:
                            res = ROOT_URL_CN + DRAW_API;
                            break;
                        case Country.Foreign:
                            res = ROOT_URL_FO + DRAW_API;
                            break;
                    }
                }
                return res;
            }
        }

        //[SerializeField]
        //private ObscuredString androidPackageName;

        //[SerializeField]
        //private ObscuredString iosPackageName;

        //[SerializeField]
        private ObscuredString ReleaseKey = "1ba0f34b4c235b88ffba57fff59b3242";

        //[SerializeField]
        //private ObscuredString FbGPCheckIPUrl = "https://api.c31.xyz/validation";    // 检测是否为google 和 facebook 的ip //V6版本集成在服务器判断了

        private ObscuredString PackageName;

#if UNITY_IOS || UNITY_IPHONE
        [DllImport("__Internal")]
        private static extern string GetIphoneADID();
#endif

        private static readonly long Jan1st1970Ms = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc).Ticks;

        public static long CurrentTimeMillis
        {
            //服務器時間暫時定死了是東八區，所以在這裡強制轉換
            get { return (System.DateTime.UtcNow.Ticks - Jan1st1970Ms) / 10000; }
        }

        public static long CurrentTimeSeconds
        {
            //服務器時間暫時定死了是東八區，所以在這裡強制轉換
            get { return (System.DateTime.UtcNow.Ticks - Jan1st1970Ms) / 10000 / 1000; }
        }

        // 返回码为200，则表示成功
        private const int CODE_SUCCESS = 200;   // 返回码为200，则表示成功
        private const int CODE_BLOCK = 401;     // 401, 被block，不显示激励卡
        private const int CODE_WARNING = 403;   // 403, 弹警告

        //激励数据
        private GiftCard rewardData;

        //排行榜数据
        private RankingListData rankingListData;

        //服务器时间
        private string serverDateTime;

        // 获取数据错误码
        private ObscuredLong GetDataErrorCode = -2;

        // 密钥，提前生成好
        private ObscuredString CommonKey;

        // 用户进来的秒数
        private ObscuredLong StartPlaySeconds;

        // 统计完分钟后，剩余的秒数
        private ObscuredInt RemainSeconds;

        [Serializable]
        class ServerDateTime
        {
            public int time;
        }

        void Awake()
        {
            if (DataManager.InitComplete)
            {
                Destroy(this.gameObject);
                return;
            }
            StartPlaySeconds = CurrentTimeSeconds;
            Ins = this;
            rankingListData = null;

            DontDestroyOnLoad(this.gameObject);
        }

        private void Start()
        {
            if (DataManager.InitComplete)
            {
                Destroy(this.gameObject);
                return;
            }
            DontDestroyOnLoad(gameObject);
            //保存sdk版本号
            DataManager.RCSdkVersion = rewardVersion;
            //迁移之前版本的数据
            TransferOldData();
        }

        /// <summary>
        /// 记录激励广告激励完成次数
        /// </summary>
        /// <returns>当天总次数</returns>
        public static int RecordRewardAdSuccessTimes()
        {
            if (string.IsNullOrEmpty(DataManager.TimeNow))
            {
                LogSdk.Log("服务器时间还未返回，不记录，防止数据出错");
                return 0;
            }
            //收集当日数据
            var timeNow = DataManager.TimeNow;
            var dd = DataManager.GetDailyDataByDateNow();
            dd.video_count++;
            dd.ad_count++; 
            //储存当日数据
            DataManager.SaveDailyDataByDateTime(timeNow, dd);
            return dd.video_count;
        }

        /// <summary>
        /// 记录插屏广告显示成功次数
        /// </summary>
        /// <returns>当天总次数</returns>
        public static int RecordInterstitialAdShowSuccessTimes()
        {
            if (string.IsNullOrEmpty(DataManager.TimeNow))
            {
                LogSdk.Log("服务器时间还未返回，不记录，防止数据出错");
                return 0;
            }
            //收集当日数据
            var timeNow = DataManager.TimeNow;
            var dd = DataManager.GetDailyDataByDateNow();
            dd.interstitial_count++;
            dd.ad_count++;
            //储存当日数据
            DataManager.SaveDailyDataByDateTime(timeNow, dd);
            return dd.interstitial_count;
        }

        /// <summary>
        /// 迁移之前版本的数据
        /// </summary>
        void TransferOldData()
        {
            //v5升级v6
            //钱，之前的key是"mei_mfy_qian"，现在换成了乱码，所以新版本是没有"mei_mfy_qian"的，如果检测存在"mei_mfy_qian"，则表示是v5升级v6的用户，
            Debug.Log("----判断是否迁移V5数据----");
            if (ObscuredPrefs.HasKey("mei_mfy_qian"))
            {
                Debug.Log("----迁移V5数据----");
                //判断之前的钱和现在的钱哪个钱高，就用哪个，由于现在用的是美分，则*100
                Debug.Log("之前用户钱为（元）："+ ObscuredPrefs.GetFloat("mei_mfy_qian"));
                Debug.Log("当前钱为（分）："+ DataManager.GoldCoin);
                var oldCoin = Mathf.Max(ObscuredPrefs.GetFloat("mei_mfy_qian"), (DataManager.GoldCoin/100f));
                Debug.Log("取最大值（元）：" + oldCoin);
                DataManager.GoldCoin = (int)(oldCoin * 100f);
                Debug.Log("之前的领取次数：" + DataManager.CardShowTimesOfTotal);
                //金币领取次数之前用的是展示次数，现在用的真实领取次数
                DataManager.GetMainRewardTimesOfTotal += DataManager.CardShowTimesOfTotal;
                LogSdk.Log("迁移后的领取次数：" + DataManager.GetMainRewardTimesOfTotal);

                //由于用户每日数据的格式有所修改，所以清空之前的所有每日数据
                DataManager.AllDailyData = null;
                //删除老钱key
                ObscuredPrefs.DeleteKey("mei_mfy_qian");
            }
            else
            {
                Debug.Log("----不需要迁移V5数据----");
            }
        }

        long InitStartTime;//记录初始化的开始时间，

        public static void ShowLog(bool IsShowLog = false)
        {
            LogSdk.IsLogOn = IsShowLog;
        }

        private Action InitSuccessCallBack;
        /// <summary>
        /// 初始化激励卡sdk
        /// </summary>
        /// <param name="InitSuccessCallBack">init成功后的回调函数</param>
        /// <param name="UID">用户唯一标识（IMEI/MAC等）,传入null（默认为null）的话会自动获取（Android）ANDROID_ID、（IOS）IDFA</param>
        /// <param name="PackageName">项目包名,传入null（默认为null）的话会自动获取，Application.identifier</param>
        public static void Init(Action InitSuccessCallBack = null,string UID = null,string PackageName = null)
        {
            if (DataManager.InitComplete)
            {
                LogSdk.Log("sdk已经初始化过，不要重复初始化！");
                return;
            }
            DataManager.InitComplete = false;
            Ins.InitSuccessCallBack = InitSuccessCallBack;
            Ins.InitStartTime = CurrentTimeMillis;//记录请求时间，用于计算请求响应时间
            if (String.IsNullOrEmpty(UID))
            {
                if (String.IsNullOrEmpty(DataManager.UID))
                {
                    LogSdk.Log("开始获取设备id");
#if UNITY_EDITOR
                    DataManager.UID = DebugAndroidId;
#elif UNITY_ANDROID
                    var _ajc = new AndroidJavaObject("com.reward.card.sdk.unityrewardlibrary.AndroidIdClient");
                    string success = _ajc.Call<string>("getDeviceId");
                    if (String.IsNullOrEmpty(success))
                    {
                        LogSdk.Log("获取设备id失败！");
                    }
                    else
                    {
                        LogSdk.Log("获取设备id："+ success);
                        DataManager.UID = success;
                    }
#elif UNITY_IOS || UNITY_IPHONE
                    DataManager.UID = GetIphoneADID();
#endif
                    Ins.HandleGoogleAdId(DataManager.UID);
                }
                else
                {
                    LogSdk.Log("已有设备id：" + DataManager.UID);
                    Ins.HandleGoogleAdId(DataManager.UID);
                }
            }
            else
            {
                Ins.HandleGoogleAdId(UID);
            }
            if (String.IsNullOrEmpty(PackageName))
            {
                PackageName = Application.identifier;
            }
            Ins.PackageName = PackageName;

            LogSdk.Log("包名：" + PackageName);

            //获取服务器时间
            Ins.StartCoroutine(Ins.GetServerDateTime(verify =>
            {
                // 若返回正常，则继续请求激励数据
                if (verify)
                {
                    Ins.SyncLocalData();
                }
            }));
        }

        //获取服务器时间
        IEnumerator GetServerDateTime(Action<bool> callback = null)
        {
            //生成秘钥、判断是否删除log日志功能
            InitNative();
            LogSdk.Log("获取服务器时间："+ GetServerDateTimeUrl);
            UnityWebRequest webRequest = UnityWebRequest.Get(GetServerDateTimeUrl);
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError || webRequest.isHttpError)
            {
                LogSdk.Log(webRequest.error);
                callback?.Invoke(false);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<ServerDateTime>(webRequest.downloadHandler.text);
                serverDateTime =  ConvertStringToDateTime(result.time).ToString("yyyy-MM-dd");
                LogSdk.Log("服务器时间：" + result.time.ToString() + "(" + serverDateTime + ")");
                callback?.Invoke(true);
            }
        }

        // 判断激励卡片是否关闭
        public bool IsRewardClosed()
        {
            if (rewardData == null || rewardData.code != CODE_SUCCESS)
            {
                return true;
            }

            return false;
        }

        public static bool CheckRewardDataSuccess()
        {
            if (Ins==null)
            {
                LogSdk.Log("sdk还未初始化");
                return false;
            }
            if (Ins.rewardData == null || Ins.rewardData.code != CODE_SUCCESS)
            {
                LogSdk.Log("激励数据未准备完毕或返回码【" + Ins.rewardData?.code + "】");
                return false;
            }
            return true;
        }


        // 判断是否显示激励卡片
        private int missTimes = 0;//激励卡没有随机到的次数
        private int missProbability = 0;//记录没有随机到的概率
        public bool IsShowRewardCard(int viceModelId = 0)
        {
            LogSdk.Log("判断是否可以显示激励卡");

            // 判断获取数据是否成功
            if (!CheckRewardDataSuccess())
            {
                // 请求数据失败，才继续请求
                if (GetDataErrorCode == -1)
                {
                    LogSdk.Log("请求数据失败，继续向服务器请求数据");
                    GetRewardData();
                }
                return false;
            }

            //下次要增加的金额，根据参数来确定是主模块还是副模块，当id小于等于0时，表示当前是判断主模块
            float nextRewardValue = viceModelId > 0 ? GetViceModelRewardValue(viceModelId) : GetMainRewardValue();

            //客户端新增规则——如果是中国，并当前金额+下次获取金额≥100，则不调用激励事件。
            if (country == Country.China)
            {
                if (DataManager.GoldCoin + nextRewardValue >= 3000f || nextRewardValue <= 0f)
                {
                    LogSdk.Log("国内sdk，当前金额+下次获取金额≥30，或者下次要增加的金额≤0，不显示激励卡");
                    return false;
                }
            }

            // 1)当已经获得钱大于100美元（10000美分） 则不展示激励卡片 2)本次获得的钱==0，则不再展示激励卡片
            //if (DataManager.GoldCoin + GetRewardValue() > 99.99f || GetRewardValue() <= 0f)
            if (DataManager.GoldCoin >= 10000 || nextRewardValue <= 0f)
            {
                LogSdk.Log("国外sdk，当前金币≥100了，或者本次应该获得的钱≤0，不显示激励卡");
                return false;
            }

            // 激励卡片用户从第一次开始到现在总的展示次数
            //只有主模块做判断
            if (viceModelId <= 0)
            {
                if (DataManager.CardShowTimesOfTotal >= rewardData.GetMaxRewardShowTimes())
                {
                    LogSdk.Log("总展示次数超过最大次数");
                    return false;
                }

                if (rewardData.probability == null || rewardData.probability.Count <= 0)
                {
                    LogSdk.Log("概率表为null或数据为0，不显示");
                    return false;
                }
            }
            else
            {
                if (rewardData.probability == null || rewardData.probability.Count <= 0|| rewardData.vice_model==null)
                {
                    LogSdk.Log("主/副模块概率表为null或数据为0，不显示");
                    return false;
                }
            }
            // 判断概率
            int probability = viceModelId > 0 ? GetViceModelProbability(viceModelId) : (int)rewardData.GetMainProbability();
            if (probability == 0)
            {
                LogSdk.Log("此次概率为0，则百分百不显示");
                return false;
            }

            if (probability >= 100)
            {
                missTimes = 0;
                LogSdk.Log("此次概率为100，则百分百显示");
                return true;
            }

            // 根据概率计算是否可以展示激励卡片
            ObscuredInt randomNum = UnityEngine.Random.Range(1, 100);
            if (randomNum > probability)
            {
                LogSdk.Log("概率为" + probability + "，随机到了" + randomNum + "，所以不显示");
                //如果当前概率下标大于10，则开始计算是否100%显示（如：概率为30% ，N=1/0.3=3.33,向上取整为4。则第5次必弹激励卡。）
                if (DataManager.MainProbabilityIndex >= 10)
                {
                    //判断概率是否有改变，如果有改变的话重新计数
                    if (missProbability!= probability)
                    {
                        missProbability = probability;
                        missTimes = 0;
                    }
                    //未出现次数计数
                    missTimes++;
                    //判断是否达到百分百出现的时候
                    int N = Mathf.CeilToInt(1 / (probability / 100f)) + 1;
                    if (missTimes>= N)
                    {
                        LogSdk.Log("已经"+ missTimes + "次没有显示激励卡了，强制显示激励卡");
                        missTimes = 0;
                        return true;
                    }
                }
                return false;
            }
            missTimes = 0;
            LogSdk.Log("-----可以显示激励卡");
            return true;
        }

        /// <summary>
        /// 判断是否达到了当日卡片展示次数
        /// </summary>
        /// <returns></returns>
        public bool IsReachedLimit()
        {
            //LogSdk.Log("ShowTimesOfDay=" + DataManager.ShowTimesOfDay + ",limit=" + rewardData.GetLimit());

            if (DataManager.ShowTimesOfDay >= rewardData.GetLimit())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取激励数据
        /// </summary>
        /// <param name="data">传入数据的话则直接用传入的数据，不去获取</param>
        public void GetRewardData(string data = null)
        {
            if (data!=null)
            {
                HandleRewardData(data);
                Singleton<MUIEventManager>.Instance.DispatchUIEvent(enMUIEventID.Reward_Status_Change,
                        new MUIEventParams() { bool_param1 = !IsRewardClosed() });
            }
            else
            {
                StartCoroutine(GetRewardDataFromServer(result =>
                {
                    bool isShowRewardCard;

                    if (result == 0 && !IsRewardClosed())
                    {
                        // 显示现金金额及按钮
                        isShowRewardCard = true;

                        DataManager.InitComplete = true;
                    }
                    else
                    {
                        // 隐藏现金金额及按钮
                        isShowRewardCard = false;

                        DataManager.InitComplete = false;
                    }

                    Singleton<MUIEventManager>.Instance.DispatchUIEvent(enMUIEventID.Reward_Status_Change,
                        new MUIEventParams() { bool_param1 = isShowRewardCard });

                    //如果是正确的则计数。
                    //现在时间大于记录时间
                    if (CurrentTimeMillis> InitStartTime)
                    {
                        //记录请求相应时间
                        var timeNowData = DataManager.GetDailyDataByDateNow();

                        //得到持续时间
                        var duration = CurrentTimeMillis - InitStartTime;

                        //当日响应时间追加
                        timeNowData.client_response_duration += duration;

                        //记录当日的请求次数
                        timeNowData.client_request_times++;

                        DataManager.SaveDailyDataByDateTime(DataManager.TimeNow, timeNowData);

                        LogSdk.Log("响应时间(ms)：" + duration);
                        LogSdk.Log("当日请求服务器" + timeNowData.client_request_times + "次，当日总响应时间(ms)：" + timeNowData.client_response_duration + "，当日平均响应时间(ms)：" + (timeNowData.client_response_duration / timeNowData.client_request_times));
                    }
                    else
                    {
                        LogSdk.Log("响应时间为负数，当日响应时间不进行任何记录，可能用户在请求中修改了时间（往前）：开始时间(ms)" + InitStartTime.ToString() + "服务器返回时间（当前时间）(ms)" + CurrentTimeMillis.ToString());
                    }
                    this.InitSuccessCallBack?.Invoke();
                }));
            }
        }

        /// <summary>
        /// 请求调用激励数据
        /// </summary>
        /// <param name="callback">获取数据后调用事件</param>
        /// <returns></returns>
        IEnumerator GetRewardDataFromServer(Action<long> callback = null)
        {
            string url = GetRewardDataUrl;
            //if (IsTest)
            //{
            //    url = TestGetUrl + TestPackageName;
            //}

            LogSdk.Log("获取激励卡数据配置表 url=" + url);

            using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
            {
                webRequest.SetRequestHeader("X-Requested-With", PackageName);
                webRequest.SetRequestHeader("Version", Application.version);
                if (CheckTimeStamp)
                    webRequest.SetRequestHeader("timestamp", CurrentTimeSeconds.ToString());
                yield return webRequest.SendWebRequest();

                LogSdk.Log("获取配置数据：code=" + webRequest.responseCode);

                if (webRequest.isNetworkError || webRequest.isHttpError)
                {
                    GetDataErrorCode = -1;
                    
                    callback?.Invoke(-1);
                }
                else if (webRequest.responseCode == CODE_SUCCESS)
                {

                    HandleRewardData(webRequest.downloadHandler.text);

                    //储存激励数据
                    if (OpenLocalRewardData)
                    {
                        LogSdk.Log("储存配置数据");
                        SaveLocalFile(webRequest.downloadHandler.data);
                    }

                    GetDataErrorCode = 0;
                    callback?.Invoke(0);
                }
            }
        }

        void HandleRewardData(string value)
        {
            string result = DecryptString(value);

            LogSdk.Log("配置数据=" + result);

            rewardData = JsonConvert.DeserializeObject<GiftCard>(result);

            // 如果adid 为空，则不展示
            if (DataManager.HasGoogleAdid && string.IsNullOrEmpty(DataManager.GoogleAdId))
            {                
                LogSdk.Log("HandleRewardData >>> 广告ID为空 >>>");

                rewardData.code = CODE_BLOCK;
            }
        }

        /// <summary>
        /// 储存激励数据到本地
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool SaveLocalFile(byte[] data)
        {
            string path = Application.persistentDataPath + "/logo.png";

            LogSdk.Log("path=" + path);

            if (File.Exists(path))
                File.Delete(path);

            FileStream fs = new FileStream(path, FileMode.CreateNew);

            if (fs == null)
                return false;

            fs.Write(data, 0, data.Length);
            fs.Close();

            return true;
        }

        string ReadLocalFile()
        {
            string res = null;
            string path = Application.persistentDataPath + "/logo.png";

            LogSdk.Log("path=" + path);
            if (File.Exists(path))
            {
                res = File.ReadAllText(path);
            }
            return res;
        }

        /// <summary>
        /// 得到排行榜数据
        /// </summary>
        /// <param name="callback"></param>
        public void SyncGetRankingListData(Action<long> callback = null)
        {
            StartCoroutine(SyncGetRankingListData2Server(callback));
        }

        private IEnumerator SyncGetRankingListData2Server(Action<long> callback = null)
        {
            if (rankingListData == null)
            {
                string url = GetRankingListDataUrl;
                using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
                {
                    webRequest.SetRequestHeader("X-Requested-With", PackageName);
                    webRequest.SetRequestHeader("Version", Application.version);
                    if (CheckTimeStamp)
                        webRequest.SetRequestHeader("timestamp", CurrentTimeSeconds.ToString());
                    yield return webRequest.SendWebRequest();

                    LogSdk.Log("获取排行榜数据：code=" + webRequest.responseCode);

                    if (webRequest.isNetworkError || webRequest.isHttpError)
                    {
                        callback?.Invoke(-1);
                    }
                    else if (webRequest.responseCode == CODE_SUCCESS)
                    {
                        string result = DecryptString(webRequest.downloadHandler.text);
                        LogSdk.Log(result);
                        rankingListData = JsonConvert.DeserializeObject<RankingListData>(result);

                        //储存激励数据
                        //if (OpenLocalRewardData)
                        //{
                        //    LogSdk.Log("储存配置数据");
                        //    SaveLocalFile(webRequest.downloadHandler.data);
                        //}
                        callback?.Invoke(0);
                    }
                }
            }
            else
            {
                callback?.Invoke(0);
            }
        }


        /// <summary>
        /// 同步本地数据到服务器
        /// </summary>
        /// <param name="callback"></param>
        public void SyncLocalData(Action<long> callback = null)
        {
            StartCoroutine(SyncData2Server(callback));
        }

        /// <summary>
        /// 同步本地数据到服务器
        /// </summary>
        private IEnumerator SyncData2Server(Action<long> callback = null)
        {
            string url = PostUrl;

            //把每日的视频观看次数加起来等于总的视频次数
            var allDailyData = DataManager.AllDailyData;
            int interstitialCount = 0;
            int videoCount = 0;
            int adCount = 0;
            //int Duration = 0;
            foreach (var item in allDailyData)
            {
                interstitialCount += item.Value.interstitial_count;
                videoCount += item.Value.video_count;
                adCount += item.Value.ad_count;
                //Duration += item.Value.duration;
            }

            PostData data = new PostData
            {
                money = DataManager.GoldCoin,//用户累计金额
                reward_count = DataManager.CardShowTimesOfTotal,//总激励次数
                interstitial_count = interstitialCount,//总插屏次数
                video_count = videoCount,//总视频广告次数
                ad_count = adCount,//总广告次数
                duration = DataManager.PlayTimes,//总游戏时长
                day_count = DataManager.AllDailyData.Count,//激励卡领取总天数
                //days = DataManager.Day7DailyData//每日数据（防止数据过度，只取最近7天）
                day = DataManager.GetDailyDataByDateNow()//获取当日数据
            };
            LogSdk.Log("用户数据同步到服务器：url=" + url + "，" + CurrentTimeSeconds);

            string postData = PostData.ToJson(data);
            LogSdk.Log(postData);

            postData = EncryptPackage(postData);

            using (UnityWebRequest www = new UnityWebRequest(url, "POST"))
            {
                www.SetRequestHeader("X-Requested-With", PackageName);//包名
                www.SetRequestHeader("Content-Type", "application/json");
                www.SetRequestHeader("DeviceId", DataManager.GoogleAdId);//用户id
                www.SetRequestHeader("Version", Application.version);//激励版本

                //判断是否为自然用户
                //目前仅支持安卓（GooglePlay）
                ReferrerReceiver.getInstallReferrer(s =>
                {
                    //如果返回的是空，则表示不是推广进来的，为自然用户，反之
                    DataManager.Natural = string.IsNullOrEmpty(s);
                }, false);
                //是否强制非自然量(用于测试)
                if (DebugForceNoNatural)
                {
                    DataManager.Natural = false;
                }
                LogSdk.Log("渠道跟踪（自然用户：" + DataManager.Natural.ToString() + "）");
                www.SetRequestHeader("IsNatural", DataManager.Natural.ToString());
                if (CheckTimeStamp)
                    www.SetRequestHeader("timestamp", CurrentTimeSeconds.ToString());

                byte[] postBytes = Encoding.UTF8.GetBytes(postData);
                www.uploadHandler = (UploadHandler)new UploadHandlerRaw(postBytes);
                www.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();

                yield return www.SendWebRequest();
                long retCode = www.responseCode;
                var retPostDataStr = www.downloadHandler.text;
                retPostDataStr = DecryptString(retPostDataStr);
                var retPostData = JsonConvert.DeserializeObject<RetPostData>(retPostDataStr);
                string invite = retPostData == null ? "" : retPostData.invite;//邀请码后期备用
                LogSdk.Log("用户数据同步：返回码=" + retCode + "，邀请码=" + invite);

                // 同步成功
                if (retCode == CODE_SUCCESS)
                {
                    LogSdk.Log("用户数据同步成功");

                    CheckUserActiveDays();

                    GetRewardData();
                }
                // 用户被block，则弹出警告
                else if (retCode == CODE_WARNING)
                {
                    LogSdk.Log("用户被block，显示警告");
                    DataManager.ShowWarningUI = true;

                    Singleton<MUIEventManager>.Instance.DispatchUIEvent(enMUIEventID.Reward_Status_Change,
                        new MUIEventParams() { bool_param1 = true });
                }
                // 直接不显示激励卡, 不请求任何数据
                else if (retCode == CODE_BLOCK)
                {
                    LogSdk.Log("该用户被屏蔽了");
                }
                else
                {
                    LogSdk.Log("服务器没有正常返回数据，使用本地数据功能【" + OpenLocalRewardData.ToString() + "】");
                    if (OpenLocalRewardData)
                    {
                        LogSdk.Log("服务器没有正常返回，默认使用本地数据");
                        string rewarddata = ReadLocalFile();
                        if (string.IsNullOrEmpty(rewarddata))
                        {
                            LogSdk.Log("本地数据为空！");
                        }
                        else
                        {
                            CheckUserActiveDays();

                            GetRewardData(rewarddata);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 判断用户活跃天数，主要用于计算用户当日的limit
        /// </summary>
        private static void CheckUserActiveDays()
        {
            // 使用服务器时间判断用户是否为同一天，不同日期，活跃天数+1
            if (!DataManager.UserPlayDate.Equals(DataManager.TimeNow))
            {
                DataManager.UserPlayDate = DataManager.TimeNow;

                DataManager.UserActiveDays++;

                // 如果为不同的天，则将每天的展示次数置0
                DataManager.ShowTimesOfDay = 0;
            }
        }

        public void SetPublicRequestHeader()
        {

        }

        // 提交提现申请
        bool isWithDrawing = false;//记录是否正在提交提现
        public void SendWithDrawRequest(Action callback)
        {
            if (!isWithDrawing)
            {
                isWithDrawing = true;
                StartCoroutine(WithDrawToServer(callback));
            }
        }

        private IEnumerator WithDrawToServer(Action callback)
        {
            string packagename = PackageName;
            string url = DrawUrl;
            //if (IsTest)
            //{
            //    packagename = TestPackageName;
            //    url = TestDrawUrl;
            //}

            DrawPostData data = new DrawPostData
            {
                email = DataManager.Email,
                pay_account = DataManager.Paypal,
            };

            string drawdata = DrawPostData.ToJson(data);
            string postData = EncryptPackage(drawdata);

            LogSdk.Log("提现数据：WithDrawToServer >>> url=" + url);

            using (UnityWebRequest www = new UnityWebRequest(url, "POST"))
            {
                www.SetRequestHeader("X-Requested-With", PackageName);//包名
                www.SetRequestHeader("Content-Type", "application/json");
                www.SetRequestHeader("DeviceId", DataManager.GoogleAdId);//用户id
                if (CheckTimeStamp)
                    www.SetRequestHeader("timestamp", CurrentTimeSeconds.ToString());

                byte[] postBytes = Encoding.UTF8.GetBytes(postData);
                www.uploadHandler = (UploadHandler)new UploadHandlerRaw(postBytes);
                www.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();

                yield return www.SendWebRequest();
                
                LogSdk.Log("提现申请：code=" + www.responseCode);
                if (www.responseCode==CODE_SUCCESS)
                {
                    LogSdk.Log("提现成功");
                    callback?.Invoke();
                }
                else
                {
                    LogSdk.Log("提现失败");
                    GiftCardDialog.ShowTips("Please try again.");
                    isWithDrawing = false;
                }
            }
        }

        // 加密数据包
        private string EncryptPackage(string data)
        {
            //暂时不加密
            if (!OpenEncrypt)
            {
                return data;
            }
            if (string.IsNullOrEmpty(data))
            {
                LogSdk.Log("要加密的字符串为空");
                return "";
            }
            try
            {
                byte[] bytes = CommonUtil.AESEncrypt(data, CommonKey);

                return Convert.ToBase64String(bytes);
            }
            catch(Exception e)
            {
                LogSdk.Log(e.Message);
            }
            return string.Empty;
        }

        // 解密字符串
        string DecryptString(string value)
        {
            if (!OpenEncrypt)
            {
                return value;//暂时不加密
            }
            if (string.IsNullOrEmpty(value))
            {
                LogSdk.Log("要解密的字符串为空");
                return "";
            }
            byte[] bytes = Convert.FromBase64String(value);

            byte[] result = CommonUtil.AESDecrypt(bytes, CommonKey);

            return CommonUtil.Byte2String(result).Trim();
        }

        // 缓存一下本次可以获取到的金币
        private ObscuredInt rewardCoin;

        /// <summary>
        /// 获取主模块激励值(本次可以获得的奖励数)
        /// </summary>
        /// <returns></returns>
        public int GetMainRewardValue()
        {
            if (rewardData==null)
            {
                return 0;
            }
            if (rewardCoin <= 0)
            {
                rewardCoin = rewardData.GetRewardValue();
            }
            return rewardCoin;
        }

        /// <summary>
        /// 获取副模块激励值(本次可以获得的奖励数)
        /// </summary>
        /// <param name="viceModeId">副模块id(1~4)</param>
        /// <returns></returns>
        public static int GetViceModelRewardValue(int viceModeId)
        {
            if (Ins.rewardData == null|| Ins.rewardData.vice_model == null)
            {
                LogSdk.Log("当前总数据为空，或副模块数据为空");
                return 0;
            }
            if (!Ins.rewardData.vice_model.ContainsKey(viceModeId.ToString()))
            {
                LogSdk.Log("当前副模块" + viceModeId + "不存在，请检查后台配置");
                return 0;
            }
            var viceModelData = Ins.rewardData.vice_model[viceModeId.ToString()];

            int viceModelrewardCoin = viceModelData.GetRewardValue();
            return viceModelrewardCoin;
        }

        /// <summary>
        /// 根据副模块ID获取副模块的所有激励值
        /// </summary>
        /// <param name="viceModeId">副模块id(1~4)</param>
        /// <returns></returns>
        public static int[] GetViceModelRewardValueList(int viceModeId)
        {
            if (Ins.rewardData == null || Ins.rewardData.vice_model == null)
            {
                LogSdk.Log("当前总数据为空，或副模块数据为空");
                return null;
            }
            if (!Ins.rewardData.vice_model.ContainsKey(viceModeId.ToString()))
            {
                LogSdk.Log("当前副模块" + viceModeId + "不存在，请检查后台配置");
                return null;
            }
            var viceModelData = Ins.rewardData.vice_model[viceModeId.ToString()];

            return viceModelData.dollar.Values.ToArray();
        }

        /// <summary>
        /// 获取副模块的概率
        /// </summary>
        /// <param name="viceModeId">副模块id(1~4)</param>
        /// <returns></returns>
        public static int GetViceModelProbability(int viceModeId)
        {
            if (Ins.rewardData == null || Ins.rewardData.vice_model == null)
            {
                LogSdk.Log("当前总数据为空，或副模块数据为空");
                return 0;
            }
            if (!Ins.rewardData.vice_model.ContainsKey(viceModeId.ToString()))
            {
                LogSdk.Log("当前副模块" + viceModeId + "不存在，请检查后台配置");
                return 0;
            }
            var viceModelData = Ins.rewardData.vice_model[viceModeId.ToString()];

            int res = viceModelData.GetProbability();
            return res;
        }

        /// <summary>
        /// 检查副模块数据是否存在
        /// </summary>
        /// <param name="viceModeId">副模块id</param>
        /// <returns>是否存在</returns>
        public static bool CheckExist(int viceModeId)
        {
            if (Ins.rewardData == null || Ins.rewardData.vice_model == null)
            {
                LogSdk.Log("当前总数据为空，或副模块数据为空");
                return false;
            }
            if (!Ins.rewardData.vice_model.ContainsKey(viceModeId.ToString()))
            {
                LogSdk.Log("当前副模块" + viceModeId + "不存在，请检查后台配置");
                return false;
            }
            if (Ins.rewardData.vice_model[viceModeId.ToString()].dollar.Count <= 0|| Ins.rewardData.vice_model[viceModeId.ToString()].probability.Count <= 0)
            {
                LogSdk.Log("当前副模块" + viceModeId + "数据条数为0，请检查后台配置");
                return false;
            }
            return true;
        }


        /// <summary>
        /// 根据副模块ID获取副模块的所有概率
        /// </summary>
        /// <param name="viceModeId">副模块id(1~4)</param>
        /// <returns></returns>
        public static int[] GetViceModelProbabilityList(int viceModeId)
        {
            if (Ins.rewardData == null || Ins.rewardData.vice_model == null)
            {
                LogSdk.Log("当前总数据为空，或副模块数据为空");
                return null;
            }
            if (!Ins.rewardData.vice_model.ContainsKey(viceModeId.ToString()))
            {
                LogSdk.Log("当前副模块" + viceModeId + "不存在，请检查后台配置");
                return null;
            }
            var viceModelData = Ins.rewardData.vice_model[viceModeId.ToString()];

            return viceModelData.probability.Values.ToArray();
        }

        /// <summary>
        /// 调用副模块次数是否会影响主模块
        /// </summary>
        /// <param name="viceModeId">副模块id(1~4)</param>
        /// <returns></returns>
        public bool GetViceModelIsLimitCap(int viceModeId)
        {
            if (rewardData == null || rewardData.vice_model == null)
            {
                LogSdk.Log("当前总数据为空，或副模块数据为空");
                return false;
            }
            if (!rewardData.vice_model.ContainsKey(viceModeId.ToString()))
            {
                LogSdk.Log("当前副模块" + viceModeId + "不存在，请检查后台配置");
                return false;
            }
            var viceModelData = rewardData.vice_model[viceModeId.ToString()];
            return viceModelData.limit_cap;
        }

        public RankingListData GetRankingListData()
        {
            return rankingListData;
        }

        /// <summary>
        /// 分转元
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float ConvertDollar(int value)
        {
            return value / 100f;
        }

        /// <summary>
        /// 得到奖励
        /// </summary>
        /// <returns>本次增加的金币数量</returns>
        public static int GetReward()
        {
            var coin = Ins.GetMainRewardValue();
            DataManager.GoldCoin += coin;
            //限制金额，国内2999，国外10000
            switch (Ins.country)
            {
                case Country.China:
                    if (DataManager.GoldCoin > 2999)
                        DataManager.GoldCoin = 2999;
                    break;
                case Country.Foreign:
                    if (DataManager.GoldCoin > 10000)
                        DataManager.GoldCoin = 10000;
                    break;
            }

            LogSdk.Log("主模块增加金币:" + coin);

            //收集当日数据
            var timeNow = DataManager.TimeNow;
            var dd = DataManager.GetDailyDataByDateNow();
            //当日领取金额
            dd.money += (int)coin;
            //储存当日数据
            DataManager.SaveDailyDataByDateTime(timeNow, dd);

            //金币领取次数+1
            DataManager.GetMainRewardTimesOfTotal++;

            Ins.rewardCoin = 0;
            return coin;
        }

        /// <summary>
        /// 分转元
        /// </summary>
        /// <returns></returns>
        public static string FormatMoney(int coin)
        {
            return GiftMoneyUI.FormatMoney(RewardGiftSDK.ConvertDollar(coin));
        }

        /// <summary>
        /// 得到副模块奖励
        /// </summary>
        /// <param name="viceModelId">副模块id（1~4）</param>
        /// <returns>小于等于0表示没有增加金币</returns>
        public static int GetViceModelReward(int viceModelId)
        {
            LogSdk.Log("-----------------");
            LogSdk.Log("开始副模块【" + viceModelId + "】增加金币流程");
            //判断数据是否加载完成、概率、超额等
            //if (!ins.IsShowRewardCard(viceModelId))
            //{
            //    LogSdk.Log("无法获取副模块奖励");
            //    LogSdk.Log("-----------------");
            //    return 0;
            //}
            //如果需要跟着主模块的limit，则判断limit
            //if (ins.GetViceModelIsLimitCap(viceModelId))
            //{
            //    if (ins.IsReachedLimit())
            //    {
            //        LogSdk.Log("副模块跟着主模块limit，已经到达limit限制，所以不能增加奖励");
            //        LogSdk.Log("-----------------");
            //        return 0;
            //    }
            //}
            var coin = GetViceModelRewardValue(viceModelId);
            DataManager.GoldCoin += coin;
            //限制金额，国内2999，国外10000
            switch (Ins.country)
            {
                case Country.China:
                    if (DataManager.GoldCoin > 2999)
                        DataManager.GoldCoin = 2999;
                    break;
                case Country.Foreign:
                    if (DataManager.GoldCoin > 10000)
                        DataManager.GoldCoin = 10000;
                    break;
            }

            LogSdk.Log("副模块【" + viceModelId + "】增加金币:" + coin);

            //收集当日数据
            var timeNow = DataManager.TimeNow;
            var dd = DataManager.GetDailyDataByDateNow();
            //当日领取金额
            dd.money += (int)coin;
            //储存当日数据
            DataManager.SaveDailyDataByDateTime(timeNow, dd);

            //金币领取次数+1
            DataManager.SetViceModelRewardTimesOfTotal(viceModelId,DataManager.GetViceModelRewardTimesOfTotal(viceModelId) + 1);

            // 用户总的展示次数+1
            //DataManager.CardShowTimesOfTotal++;
            //刷新小图标金币数
            Singleton<MUIEventManager>.Instance.DispatchUIEvent(enMUIEventID.Reward_Status_Change,
                    new MUIEventParams() { bool_param1 = !Ins.IsRewardClosed() });
            LogSdk.Log("-----------------");
            return coin;
        }

        void InitNative()
        {
#if UNITY_EDITOR
            //DataManager.IsDebugMode = false;
            ////LogSdk.IsLogOn = true;
            //LogSdk.Log("LogSdk.IsLogOn=" + LogSdk.IsLogOn);
#elif UNITY_ANDROID
            //try
            //{
            //    // 第一次需要调用
            //    if (!DataManager.HasGoogleAdid)
            //    {
            //        AndroidJavaClass jc = new AndroidJavaClass(PackageName + ".UnityActivity");
            //        if (jc != null)
            //        {
            //            //LogSdk.IsLogOn = jc.CallStatic<bool>("IsLogOn");

            //            DataManager.IsDebugMode = jc.CallStatic<bool>("IsDebugMode");      
                    
            //            string adId = jc.CallStatic<string>("GetGoogleAdverstingId");
            //            LogSdk.Log("InitNativeMethod >>> GetGoogleAdverstingId=" + adId);

            //            HandleGoogleAdId(adId);

            //            // 上报模拟器
            //            bool isSimulator = jc.CallStatic<bool>("IsDeviceSiMulator");
            //            if (isSimulator)
            //            {
            //                //DataReport.Track("模拟器", adId);
            //                //M_SDK.ins.EventLog(EVENTLOG.RewardCard, "simulator", adId);
            //            } else
            //            {
            //                //DataReport.Track("手机用户", adId);
            //                //M_SDK.ins.EventLog(EVENTLOG.RewardCard, "phone", adId);
            //            }
            //        }
            //    }
            //}
            //catch(Exception e)
            //{
            //    LogSdk.Log("error:" + e.Message);
            //}
#elif UNITY_IOS || UNITY_IPHONE
            ////LogSdk.IsLogOn = false;
            //DataManager.IsDebugMode = false;
            //LogSdk.Log("ios >>> LogSdk.IsLogOn=" + LogSdk.IsLogOn);
            //if (!DataManager.HasGoogleAdid)
            //{
            //    HandleGoogleAdId(System.Guid.NewGuid().ToString());
            //}
#endif
            // 如果日志关闭，则销毁对象
            //if (!LogSdk.IsLogOn)
            //{
            //    LogSdk.Log(">>>> Destroy(GameObject.Find(Reporter))");
            //    Destroy(GameObject.Find("Reporter"));
            //}

            //生成秘钥
            string md5key = PackageName + ReleaseKey;
            CommonKey = CommonUtil.Md5Sum(md5key);
        }

        void HandleGoogleAdId(string adId)
        {            
            DataManager.GoogleAdId = adId;

            //DataReport.Track("GoogleAdid", adId);
            //M_SDK.ins.EventLog(EVENTLOG.RewardCard, "GoogleAdid", adId);

            if (string.IsNullOrEmpty(adId) && rewardData != null)
            {
                LogSdk.Log("HandleGoogleAdId >>> reward:" + rewardData);

                rewardData.code = CODE_BLOCK;

                Singleton<MUIEventManager>.Instance.DispatchUIEvent(enMUIEventID.Reward_Status_Change,
                    new MUIEventParams() { bool_param1 = false });
            }
        }

        // test
        public void SetOpen(bool isOpen)
        {
            rewardData.code = isOpen ? CODE_SUCCESS : CODE_BLOCK;
        }

        private void OnApplicationPause(bool pause)
        {
            if (pause)
            {
                int minutes = (int)((CurrentTimeSeconds - StartPlaySeconds) / 60);
                int seconds = (int)((CurrentTimeSeconds - StartPlaySeconds) % 60);
                if (minutes<0|| seconds<0)
                {
                    LogSdk.Log("游戏时间出现异常，小于0！CurrentTimeSeconds："+ CurrentTimeSeconds+ "，StartPlaySeconds"+ StartPlaySeconds);
                }

                RemainSeconds += seconds < 0 ? 0 : seconds;
                minutes += (int)RemainSeconds / 60;
                minutes = minutes < 0 ? 0 : minutes;
                RemainSeconds %= 60;

                DataManager.PlayTimes += minutes;

                //收集当日数据
                var timeNow = DataManager.TimeNow;
                var dd = DataManager.GetDailyDataByDateNow();
                //当日游戏时间
                dd.duration += minutes;
                //储存当日数据
                DataManager.SaveDailyDataByDateTime(timeNow, dd);
            }
            else
            {
                StartPlaySeconds = CurrentTimeSeconds;
            }
        }

        /// <summary>
        /// 显示小金币UI
        /// </summary>
        /// <param name="show">是否显示</param>
        public static void ShowMoneyUI(bool show = true)
        {
            GiftMoneyUI.instance?.ShowMoneyUI(show);
        }

        /// <summary>
        /// 是否允许拖动
        /// </summary>
        /// <param name="drag">是否允许拖动</param>
        public static void DragMoneyUI(bool drag = true)
        {
            GiftMoneyUI.instance?.DragMoneyUI(drag);
        }

        public Action FBLoginEvent = null;
        /// <summary>
        /// 绑定fb登录事件，sdk所有需要fb登录的地方都会调用传入的action
        /// </summary>
        /// <param name="action">fb登录接口</param>
        public static void FBLoginBindAction(Action action)
        {
            Ins.FBLoginEvent = action;
        }

        /// <summary>
        /// FB登录成功后调用次参数，将记录FB登录状态
        /// </summary>
        /// <param name="fb_userId">fb用户的userid</param>
        public static void FBLoginSuccess(string fb_userId)
        {
            DataManager.FBUserId = fb_userId;
            GiftCardDialog.ShowTips("FaceBook Login Success");
            //刷新排行榜界面的fb头像、金币等
            GiftCardDialog.ins.rankingListUI.RefreshFBLoginState();
            GiftCardUI.instance.RefreshFBLoginState();
        }

        /// <summary>
        /// 获取服务器配置的客服邮箱
        /// </summary>
        /// <returns>客服邮箱</returns>
        public string GetServiceEmail()
        {
            return rewardData.email;
        }

        public string GetServerDateTime()
        {
            return serverDateTime;
        }

        /// <summary>
        /// 时间戳Timestamp转换成日期
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        private DateTime ConvertStringToDateTime(int timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = ((long)timeStamp * 10000000);
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime targetDt = dtStart.Add(toNow);
            return targetDt;
        }
    }
}
