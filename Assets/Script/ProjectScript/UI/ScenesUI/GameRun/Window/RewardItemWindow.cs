using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;

public class RewardItemWindow : UIOpenWindowsBase
{

    #region 成员变量

    #region 文本相关

    private Text m_RewardText;

    #endregion

    #region 图片相关

    private Image m_ItemImg;
    private Image m_ItemEffectImg;
    private Sprite m_GoldSprite;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();

        this.WindowName = GameTags.UIRewardItemWindow;

        #region 获取成员引用

        #region 文本相关

        m_RewardText = BaseOption.FindChild<Text>(this.gameObject, "Reward_Text");

        #endregion

        #region 图片相关

        m_ItemImg = BaseOption.FindChild<Image>(this.gameObject, "Item_Img");
        m_ItemEffectImg = BaseOption.FindChild<Image>(this.gameObject, "ItemEffect_Img");
        m_GoldSprite = ResourcesMgr.Instance.LoadSprite(GameTags.UICoinSprite);

        #endregion

        #endregion

        #region 添加成员委托方法监听

        #endregion

    }

    protected override void OnInit()
    {
    }

    private void OnEnable()
    {
        Timer.Register(1.5f, () => { this.CloseButClick(); });
        m_ItemImg.GetComponent<RectTransform>().sizeDelta = new Vector2(242, 255);
    }

    private void Update()
    {
    }

    protected override void DestroySelf()
    {
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 改变奖励图片
    /// </summary>
    /// <param name="sprite"></param>
    public void ChangeAvatarSprite(Sprite sprite)
    {
        m_ItemImg.sprite = sprite;
        m_ItemImg.GetComponent<RectTransform>().sizeDelta = new Vector2(133, 178);
    }

    /// <summary>
    /// 显示回报信息
    /// </summary>
    /// <param name="info"></param>
    public void ShowRewardInfo(string info)
    {
        if (info.Contains("Gold"))
        {
            m_ItemImg.sprite = m_GoldSprite;
        }

        m_RewardText.text = info;
        m_ItemEffectImg.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        m_ItemEffectImg.transform.DOScale(0.8f, 1).SetLoops(-1, LoopType.Yoyo);
    }

    /// <summary>
    /// 设置回报图片
    /// </summary>
    public void SetRewardAvatar(int ballId)
    {
        ShopItemEntity data = LocalDataMgr.Instance.GetShipItemWithId(ballId);
        string path = GameTags.BallMesh + data.MeshName;
        Sprite ballSprite = ResourcesMgr.Instance.LoadSprite(path);
        m_ItemImg.sprite = ballSprite;
    }

    #endregion

    #region 委托方法


    #endregion

}