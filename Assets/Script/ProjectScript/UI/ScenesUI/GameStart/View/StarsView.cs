using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsView : UIBase
{
    #region 成员变量

    private Image m_Star1;
    private Image m_Star2;
    private Image m_Star3;
    private Image m_Star4;

    private Sprite m_FinishStar;
    private Sprite m_UnFinishStar;
    private Text m_TaskInfo;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        #region 获取成员引用

        m_Star1 = BaseOption.FindChild<Image>(this.gameObject, "Star1");
        m_Star2 = BaseOption.FindChild<Image>(this.gameObject, "Star2");
        m_Star3 = BaseOption.FindChild<Image>(this.gameObject, "Star3");
        m_Star4 = BaseOption.FindChild<Image>(this.gameObject, "Star4");
        m_TaskInfo = BaseOption.FindChild<Text>(this.gameObject, "GetRewardsText");

        #endregion

        m_FinishStar = ResourcesMgr.Instance.LoadSprite(GameTags.FinishStar, true);
        m_UnFinishStar = ResourcesMgr.Instance.LoadSprite(GameTags.UnFinishStar, true);
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
    /// 设置任务描述
    /// </summary>
    public void SetTaskInfo(TaskType task)
    {
        switch (task)
        {
            case TaskType.ColliderBotton:
                m_TaskInfo.text = "Hit 500pins";
                break;
            case TaskType.PlayGameCount:
                m_TaskInfo.text = "play 5games";
                break;
            case TaskType.GetCoinCount:
                m_TaskInfo.text = "Get 800coins";
                break;
            case TaskType.CompleteMissionCount:
                m_TaskInfo.text = "Win 3games";
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 设置星星
    /// </summary>
    /// <param name="i"></param>
    public void SetStarsFinish(int i)
    {
        switch (i)
        {
            case 0:
                m_Star1.sprite = m_UnFinishStar;
                m_Star2.sprite = m_UnFinishStar;
                m_Star3.sprite = m_UnFinishStar;
                m_Star4.sprite = m_UnFinishStar;
                break;
            case 1:
                m_Star1.sprite = m_FinishStar;
                m_Star2.sprite = m_UnFinishStar;
                m_Star3.sprite = m_UnFinishStar;
                m_Star4.sprite = m_UnFinishStar;
                break;
            case 2:
                m_Star1.sprite = m_FinishStar;
                m_Star2.sprite = m_FinishStar;
                m_Star3.sprite = m_UnFinishStar;
                m_Star4.sprite = m_UnFinishStar;
                break;
            case 3:
                m_Star1.sprite = m_FinishStar;
                m_Star2.sprite = m_FinishStar;
                m_Star3.sprite = m_FinishStar;
                m_Star4.sprite = m_UnFinishStar;
                break;
            case 4:
                m_Star1.sprite = m_FinishStar;
                m_Star2.sprite = m_FinishStar;
                m_Star3.sprite = m_FinishStar;
                m_Star4.sprite = m_FinishStar;
                break;
            default:
                break;
        }
    }

    #endregion

    #region 委托方法


    #endregion
}
