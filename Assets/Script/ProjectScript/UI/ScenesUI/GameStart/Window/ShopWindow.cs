using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopWindow : UIOpenWindowsBase
{

    #region 成员变量

    #region 按钮相关

    private Button m_DoneBut;
    private Transform m_ScrollContent;
    private List<ShopBottleItem> m_ShopItems = new List<ShopBottleItem>();
    private RectTransform m_ScrollContentRect;

    #endregion

    #region 文本相关


    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        this.WindowName = GameTags.UIShopWindow;
        m_ScrollContent = BaseOption.FindChild(this.gameObject, "ScrollContent").transform;
        m_ScrollContentRect = m_ScrollContent.GetComponent<RectTransform>();

        #region 获取成员引用

        #region 按钮相关

        m_DoneBut = BaseOption.FindChild<Button>(this.gameObject, "Done_But");

        #endregion

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        BaseOption.AddButClickMethod(m_DoneBut, DoneClickMethod);

        #endregion

        #endregion

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

    /// <summary>
    /// 刷新商品列表
    /// </summary>
    public void RefreshShopList()
    {
        #region 设置已经购买的状态

        List<ShopItemEntity> haveBuyItems = LocalDataMgr.Instance.GetAllHaveBuyItems();
        foreach (ShopItemEntity item in haveBuyItems)
        {
            if (m_ShopItems != null && m_ShopItems.Count > 0)
            {
                ShopBottleItem shopItemScr = m_ShopItems.Find(s => { return s.ItemID == item.Id; });
                shopItemScr.SetHaveBuy();
                shopItemScr.HaveBuy = true;
            }
        }

        #endregion

        #region 设置选中状态

        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        int ballId = user.CurrentBall;
        ShopBottleItem selectedItemScr = m_ShopItems.Find(s => { return s.ItemID == ballId; });
        selectedItemScr.SetSelectedState();
        selectedItemScr.HaveBuy = true;

        #endregion
    }

    /// <summary>
    /// 设置列表数据
    /// </summary>
    public void SetDatas(List<ShopItemEntity> datas)
    {
        Vector3 curPos = m_ScrollContentRect.localPosition;
        m_ScrollContent.localPosition = new Vector3(curPos.x, 0, curPos.z);
        for (int i = 0; i < datas.Count; i++)
        {
            ShopItemEntity shopItem = datas[i];
            if (m_ShopItems.Count < datas.Count)
            {
                GameObject shopItemObj = ResourcesMgr.Instance.Load(GameTags.ShopItem, true, true);
                shopItemObj.transform.SetParent(m_ScrollContent);
                shopItemObj.transform.localScale = Vector3.one;
                ShopBottleItem shopItemScri = shopItemObj.GetComponent<ShopBottleItem>();
                shopItemScri.ItemID = shopItem.Id;
                shopItemScri.SetData(shopItem);
                shopItemScri.HaveBuy = false;
                m_ShopItems.Add(shopItemScri);
            }
            else
            {
                ShopBottleItem shopItemScri = m_ShopItems[i];
                shopItemScri.SetData(shopItem);
                shopItemScri.HaveBuy = false;
            }
        }

        RefreshShopList();

    }

    /// <summary>
    /// 购买物品
    /// </summary>
    public void BuyItem(int index)
    {

      

        foreach (ShopBottleItem item in m_ShopItems)
        {
            item.Selected(false);
        }

        ShopBottleItem shopItem = m_ShopItems.Find(s => { return s.ItemID == index; });

        Dictionary<string, string> para = new Dictionary<string, string>();
        para.Add("Mesh", shopItem.ItemID.ToString());
        BaseOption.SetRecord(GameTags.ShopBallRecord,para);

        shopItem.BuyItem();
    }

    #endregion

    #region 委托方法

    #region 按钮相关

    private void DoneClickMethod()
    {

        CloseButClick();
    }

    #endregion

    #endregion

}