using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ShopBottleItem : UIBase
{

    #region 成员变量

    public bool HaveBuy;
    public int ItemID;
    private GameObject m_BuyObj;
    private GameObject m_SelObj;

    #region 文本相关

    private Text m_CoinText;
    private Text m_SelectedText;

    #endregion

    #region 图片相关

    private Image m_AvatarImg;
    private Sprite m_UnSelSprite;
    private Sprite m_HaveSelSprite;
    private Image m_StateImg;
    private Image m_CoinIcon;

    #endregion

    private Button m_SelBut;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {

        #region 获取成员引用

        m_BuyObj = BaseOption.FindChild(this.gameObject, "BuyObj");
        m_SelObj = BaseOption.FindChild(this.gameObject, "SelObj");

        #region 文本相关

        m_CoinText = BaseOption.FindChild<Text>(this.gameObject, "Coin_Text");
        m_SelectedText = BaseOption.FindChild<Text>(this.gameObject, "Selected_Text");

        #endregion

        #region 图片相关

        m_AvatarImg = BaseOption.FindChild<Image>(this.gameObject, "BottleAvatar_Img");
        m_StateImg = this.GetComponent<Image>();
        m_CoinIcon = BaseOption.FindChild<Image>(this.gameObject, "CoinIcon");

        #endregion

        m_SelBut = this.GetComponent<Button>();
        m_SelBut.onClick.AddListener(() => { SelButClick(); });

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关


        #endregion

        #endregion

        m_UnSelSprite = ResourcesMgr.Instance.LoadSprite(GameTags.ShopItemUnSelectSprite, true);
        m_HaveSelSprite = ResourcesMgr.Instance.LoadSprite(GameTags.ShopItemSelectSprite, true);
        Selected(false);
    }

    protected override void OnInit()
    {
       
    }

    private void Update()
    {
    }

    protected override void DestroySelf()
    {
    }

    #endregion

    #region 成员方法

    private void SelState(bool select)
    {
        m_BuyObj.gameObject.SetActive(!select);
        m_SelObj.gameObject.SetActive(select);
    }

    /// <summary>
    /// 选中按钮点击
    /// </summary>
    private void SelButClick()
    {
        if (!HaveBuy)
        {
            EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.BuyItem, ItemID);
        }
        else
        {

            UserPeresistData.Instance.GetUserResource().CurrentBall = this.ItemID;
            UserPeresistData.Instance.SaveToJson();
            EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.RefreshShopList, ItemID);
        }

    }

    /// <summary>
    /// 设置数据
    /// </summary>
    public void SetData(ShopItemEntity item)
    {
        if (item.BuyCoin>0)
        {
            m_CoinText.text = item.BuyCoin.ToString();
        }
        else
        {
            SetHaveReward();
            m_SelBut.enabled = false;
        }
        
        string spritePath = GameTags.ShopItemSpritePath;
        StringBuilder sb = new StringBuilder(spritePath);
        string sprite = item.ShowSprite;
        sb.Append(sprite);
        Sprite spriteObj = ResourcesMgr.Instance.LoadSprite(sb.ToString(), true);
        m_AvatarImg.sprite = spriteObj;
    }

    /// <summary>
    /// 选中逻辑
    /// </summary>
    /// <param name="selected"></param>
    public void Selected(bool selected)
    {
        m_BuyObj.gameObject.SetActive(!selected);
        m_SelObj.gameObject.SetActive(selected);
        if (selected)
        {
            m_StateImg.sprite = m_HaveSelSprite;
        }
        else
        {
            m_StateImg.sprite = m_UnSelSprite;
        }
    }

    /// <summary>
    /// 购买物品
    /// </summary>
    public void BuyItem()
    {
        m_BuyObj.gameObject.SetActive(false);
        m_SelObj.gameObject.SetActive(true);
        m_StateImg.sprite = m_HaveSelSprite;
    }

    /// <summary>
    /// 设置已经购买状态
    /// </summary>
    public void SetHaveBuy()
    {
        m_BuyObj.gameObject.SetActive(false);
        m_SelObj.gameObject.SetActive(false);
        m_StateImg.sprite = m_UnSelSprite;
        m_SelBut.enabled = true;
    }

    /// <summary>
    /// 设置已经奖励状态
    /// </summary>
    public void SetHaveReward()
    {
        m_BuyObj.gameObject.SetActive(true);
        m_CoinText.text = "TASK";
        Vector3 pos = m_CoinText.transform.localPosition;
        m_CoinText.transform.localPosition = new Vector3(40, pos.y, pos.z);
        m_CoinIcon.gameObject.SetActive(false);
        
        m_SelObj.gameObject.SetActive(false);
        m_StateImg.sprite = m_UnSelSprite;
    }


    /// <summary>
    /// 设置已选中状态
    /// </summary>
    public void SetSelectedState()
    {
        m_BuyObj.gameObject.SetActive(false);
        m_SelObj.gameObject.SetActive(true);
        m_StateImg.sprite = m_HaveSelSprite;
    }

    #endregion

    #region 委托方法


    #endregion

}