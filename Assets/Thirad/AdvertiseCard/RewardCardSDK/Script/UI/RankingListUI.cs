using MobiiGame.Sdk.Base;
using MobiiGame.Sdk.Gift;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RankingListUI : MonoBehaviour
{
    public Button btn_close;
    public GameObject pre_item;
    public Transform pre_item_parent;
    public GameObject topThree;
    public Button btn_login;
    public Color me_login_text_color = Color.white;
    public Color me_price_text_color = Color.white;
    public Image head;
    // Start is called before the first frame update
    void Start()
    {
        btn_close.onClick.RemoveAllListeners();
        btn_close.onClick.AddListener(() => { this.gameObject.SetActive(false); });
        btn_login.onClick.RemoveAllListeners();

        btn_login.onClick.AddListener(() =>
        {
            if (DataManager.FBIsLogin)
            {
                LogSdk.Log("fb已经登录了，不再进行任何操作");
            }
            else
            {
                LogSdk.Log("login fb");
                RewardGiftSDK.Ins.FBLoginEvent?.Invoke();
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        //请求排行榜数据
        RewardGiftSDK.Ins.SyncGetRankingListData((long res)=>
        {
            if (res==0)
            {
                //初始化排行榜
                StartCoroutine(Init(RewardGiftSDK.Ins.GetRankingListData()));
            }
            else
            {
                LogSdk.Log("排行榜加载失败");
            }
        });

        //定位排行榜列表到最上面
        pre_item_parent.parent.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;

        //刷新FB状态
        RefreshFBLoginState();
    }

    #region FB_Login
    string picture = "https://graph.facebook.com/[userid]/picture?width=200&height=200";
    string localPicName = "fbhead.png";
    public void RefreshFBLoginState()
    {
        //判断当前自己是否正在显示状态，可能是其他地方登陆的，不需要刷新页面
        if (!this.gameObject.activeSelf)
        {
            return;
        }
        var text = btn_login.GetComponentInChildren<Text>();
        //判断是否有登陆过FB，如果有用户id，则表示已经登陆过
        if (DataManager.FBIsLogin)
        {
            LogSdk.Log("已经登录了fb");
            text.color = me_price_text_color;
            text.text = "$ " + RewardGiftSDK.FormatMoney(DataManager.GoldCoin);;
            FBLoginSurcces(DataManager.FBUserId);
        }
        else
        {
            LogSdk.Log("没有登录fb");
            text.color = me_login_text_color;
            text.text = "FB Login";
        }
    }
    public void FBLoginSurcces(string userid)
    {
        PlayerPrefs.SetString("fbuserid", userid);
        string url = picture.Replace("[userid]", userid);
        //下载头像
        if (!File.Exists(FullFBHeadPath))
        {
            LogSdk.Log("头像没缓存");
            //如果之前不存在缓存文件
            StartCoroutine(DownLoadImage(url, head));
        }
        else
        {
            LogSdk.Log("头像有缓存:" + FullFBHeadPath);
            StartCoroutine(LoadLocalImage(url, head));
        }
    }

    private IEnumerator DownLoadImage(string url, Image image)
    {
        LogSdk.Log("下载头像并缓存:" + url);
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        www.timeout = -1;
        yield return www.SendWebRequest();
        if (www.isNetworkError)
        {
            LogSdk.Log(www.error);
            yield break;
        }
        if (www.isDone)
        {
            Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;

            //缓存本地
            //if (!Directory.Exists(FBHeadPath))
            //{
            //    Directory.CreateDirectory(FBHeadPath);
            //}
            byte[] pngData = texture.EncodeToPNG();
            File.WriteAllBytes(FullFBHeadPath, pngData);

            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            if (sprite != null)
                image.sprite = sprite;
        }
        LogSdk.Log("下载头像完成");
    }

    IEnumerator LoadLocalImage(string url, Image image)
    {
        string filePath = "file://" + FullFBHeadPath;

        LogSdk.Log("加载头像缓存:" + filePath);
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(filePath);
        yield return www.SendWebRequest();

        Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        Sprite m_sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0));
        image.sprite = m_sprite;
        LogSdk.Log("头像缓存加载完成");
    }

    public string FullFBHeadPath
    {
        get
        {
            return Application.temporaryCachePath + "/" + localPicName;
        }
    }
    #endregion

    public IEnumerator Init(RankingListData rld)
    {
        for (int i = 0; i < pre_item_parent.childCount; i++)
        {
            Destroy(pre_item_parent.GetChild(i).gameObject);
        }
        if (rld==null|| rld.winning==null||rld.winning.Length<=0)
        {
            yield break;
        }
        //前三名单独
        for (int i = 0; i < (rld.winning.Length > 3 ? 3 : rld.winning.Length); i++)
        {
            topThree.transform.Find((i + 1).ToString()).GetComponentInChildren<Text>().text = rld.winning[i].name.Length > 8 ? rld.winning[i].name.Substring(0, 7) + "..." : rld.winning[i].name;
        }
        yield return null;
        for (int i = 3; i < rld.winning.Length; i++)
        {
            var item = Instantiate(pre_item, pre_item_parent);
            item.GetComponent<RankingListItem>().Init(rld.winning[i]);
            yield return null;
        }
    }
}
