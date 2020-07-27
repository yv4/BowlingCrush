using UnityEngine;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MobiiGame.Sdk.Gift
{
    [Serializable]
    public class PostData
    {
        public int money;//总金额
        public int reward_count;//激励总展示次数
        public int interstitial_count;//总插屏次数
        public int video_count;//总视频广告次数
        public int ad_count;//总广告次数
        public int duration;//游戏总时长
        public int day_count;//游戏总天数（领取激励卡的天数，禁用激励卡的话不计算天数）
        //public Dictionary<string,DailyData> days;
        public DailyData day;

        public static string ToJson(PostData data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }

    [Serializable]
    public class RetPostData
    {
        public long code;
        public string invite;
        public DateTime Date;
    }

    [Serializable]
    public class DrawPostData
    {
        public string email;
        public string pay_account;

        public static string ToJson(DrawPostData data)
        {
            return JsonUtility.ToJson(data);
        }
    }

    [Serializable]
    public class DailyData
    {
        public long client_response_duration;//当日请求服务器响应时间总时长
        public int client_request_times;//当日请求服务器次数
        public int money;//当日累计金额
        public int reward_count;//当日累计激励卡展示次数
        public int interstitial_count;//当日插屏广告观看成功次数
        public int video_count;//当日激励广告观看成功次数
        public int ad_count;//当日广告次数
        public int duration = 0;//当日累计游戏时间
    }
}