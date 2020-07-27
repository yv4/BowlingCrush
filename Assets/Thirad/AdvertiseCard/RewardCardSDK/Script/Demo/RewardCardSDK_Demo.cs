#region HeadComments
/* ========================================================================
* Copyright (C) 2019 维恩
*
* 作    者：孟凡勇
* 时    间：2019-
* 功    能：
* 
* =========================================================================
*/
#endregion
using MobiiGame.Sdk.Base;
using MobiiGame.Sdk.Gift;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardCardSDK_Demo : MonoBehaviour
{
    private void Awake()
    {
        //设置log显示inputfield，便于调试
        LogSdk.logIf = this.transform.Find("Txt_Log").GetComponent<InputField>();
        this.transform.Find("Btn_cleraLog").GetComponent<Button>().onClick.AddListener(()=> { LogSdk.logIf.text = ""; });

        //初始化FB
        if (!Facebook.Unity.FB.IsInitialized)
        {
            Facebook.Unity.FB.Init();
        }
        else
        {
            Facebook.Unity.FB.ActivateApp();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //是否显示log（正式包！一定要写false！或者不要调用！）
        RewardGiftSDK.ShowLog(true);

        //初始化激励卡sdk，初始化成功后的回调，用户唯一标识，包名
        RewardGiftSDK.Init(RefreshViceModelMoney);

        //绑定FB登录接口（需要自己接入FB SDK：https://developers.facebook.com/docs/unity/）
        RewardGiftSDK.FBLoginBindAction(()=> {
            //这里要写FB登录接口，激励sdk所有需要FB登录的地方都会调用此action

            //FB登陆成功后的回调里面要调用FB登录成功的方法，并传入fb的userid（FBSDK登陆成功后会返回userid），这里是demo，没有接入fb，所以绑定成点击后即可登录，固定了userid
            //RewardGiftSDK.FBLoginSuccess("181589816595269");

            //下面是接入FB SDK后的Demo写法
            var perms = new List<string>() { "public_profile", "email" };
            Facebook.Unity.FB.LogInWithReadPermissions(perms, (result) =>
            {
                if (Facebook.Unity.FB.IsLoggedIn)
                {
                    //得到atoken
                    var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
                    LogSdk.Log("FB登录成功：" + aToken.UserId);
                    //传入fb userid
                    RewardGiftSDK.FBLoginSuccess(aToken.UserId);
                }
                else
                {
                    LogSdk.Log("User cancelled login");
                }
            });
        });

        //是否显示小金币UI（不调用此方法默认为显示）
        RewardGiftSDK.ShowMoneyUI(true);

        //小金币UI是否允许拖动（不调用此方法默认为允许拖动）
        RewardGiftSDK.DragMoneyUI(true);

        //在触发点调用GiftCardDialog.ShowCardDialog(),这里把点击按钮当作触发点
        this.transform.Find("Btn_ShowRewardCard").GetComponent <Button>().onClick.AddListener(() => {
            //显示激励卡，如果参数为null则只是关闭界面无任何操作，默认参数为null
            GiftCardDialog.ShowCardDialog();

            //国内不会自动追加金币，需要在广告播放完毕后自己调用追加金币，写法如下
            //GiftCardDialog.ShowCardDialog(() =>
            //{
            //    //这里写调用激励广告的接口
            //    LogSdk.Log("显示广告");
            //    //在激励广告激励完成的事件里调用这句话即可增加本次钱，返回的为此次增加的钱（单位：分）
            //    int coin = RewardGiftSDK.GetReward();
            //    //分转换元
            //    float yuan = RewardGiftSDK.ConvertDollar(coin);
            //    LogSdk.Log(yuan + "元已存入您的账户中");
            //});
        });

        //广告打点
        this.transform.Find("Btn_insertAd").GetComponent<Button>().onClick.AddListener(() =>
        {
            //请在插屏视频调用成功的回调函数里写,这里把点击按钮当作插屏视频成功回调，正常接入时请！不要！这样写！！！
            int i_ad_count = RewardGiftSDK.RecordInterstitialAdShowSuccessTimes();
            LogSdk.Log("插屏视频展示次数：" + i_ad_count);
        });
        this.transform.Find("Btn_rewardAd").GetComponent<Button>().onClick.AddListener(() =>
        {
            //请在激励视频调用成功的回调函数里写,这里把点击按钮当作激励视频成功回调，正常接入时请！不要！这样写！！！
            int r_ad_count = RewardGiftSDK.RecordRewardAdSuccessTimes();
            LogSdk.Log("激励视频展示次数：" + r_ad_count);
        });

        //副模块
        this.transform.Find("Btn_model1").GetComponent<Button>().onClick.AddListener(()=> {
            //参数1：点击按钮后的操作
            //参数2：模块id（1~4）
            GiftCardDialog.ShowCardDialog(null, 1);

            //测试，刷新按钮上显示的奖励数
            RefreshViceModelMoney();
        });
        this.transform.Find("Btn_model2").GetComponent<Button>().onClick.AddListener(() =>
        {
            //参数1：点击按钮后的操作
            //参数2：模块id（1~4）
            GiftCardDialog.ShowCardDialog(null, 2);

            //测试，刷新按钮上显示的奖励数
            RefreshViceModelMoney();
        });
        this.transform.Find("Btn_model3").GetComponent<Button>().onClick.AddListener(() =>
        {
            //参数1：点击按钮后的操作
            //参数2：模块id（1~4）
            GiftCardDialog.ShowCardDialog(null, 3);

            //测试，刷新按钮上显示的奖励数
            RefreshViceModelMoney();
        });
        this.transform.Find("Btn_model4").GetComponent<Button>().onClick.AddListener(() =>
        {
            //参数1：点击按钮后的操作
            //参数2：模块id（1~4）
            GiftCardDialog.ShowCardDialog(null,4);

            //测试，刷新按钮上显示的奖励数
            RefreshViceModelMoney();
        });

        //根据副模块ID获取副模块的所有激励值列表
        var rewardValueList = RewardGiftSDK.GetViceModelRewardValueList(1);
        //根据副模块ID获取副模块的所有概率列表
        var probabilityList = RewardGiftSDK.GetViceModelProbabilityList(1);

        //版本号
        this.transform.Find("Txt_RewardVersion").GetComponent<Text>().text = "Reward SDK Version：" + RewardGiftSDK.rewardVersion;
    }

    //刷新副模块的金币，显示在按钮上
    private void RefreshViceModelMoney()
    {
        //RewardGiftSDK.GetViceModelRewardValue(模块id);//获得副模块本次可增加的奖励数
        //RewardGiftSDK.GeetViceModelProbability(模块id);//获得副模块本次的概率值
        //如：
        this.transform.Find("Btn_model1").Find("Value").GetComponent<Text>().text = RewardGiftSDK.CheckExist(1)?
            "+" + RewardGiftSDK.FormatMoney(RewardGiftSDK.GetViceModelRewardValue(1)) + "(" + RewardGiftSDK.GetViceModelProbability(1).ToString() + "%)"
            :
            "数据不存在"
            ;
        this.transform.Find("Btn_model2").Find("Value").GetComponent<Text>().text = RewardGiftSDK.CheckExist(2) ? "+" +
            RewardGiftSDK.FormatMoney(RewardGiftSDK.GetViceModelRewardValue(2)) + "(" + RewardGiftSDK.GetViceModelProbability(2).ToString() + "%)"
            :
            "数据不存在"
            ;
        this.transform.Find("Btn_model3").Find("Value").GetComponent<Text>().text = RewardGiftSDK.CheckExist(3) ? "+" +
            RewardGiftSDK.FormatMoney(RewardGiftSDK.GetViceModelRewardValue(3)) + "(" + RewardGiftSDK.GetViceModelProbability(3).ToString() + "%)"
            :
            "数据不存在"
            ;
        this.transform.Find("Btn_model4").Find("Value").GetComponent<Text>().text = RewardGiftSDK.CheckExist(4) ? "+" +
            RewardGiftSDK.FormatMoney(RewardGiftSDK.GetViceModelRewardValue(4)) + "(" + RewardGiftSDK.GetViceModelProbability(4).ToString() + "%)"
            :
            "数据不存在"
            ;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
