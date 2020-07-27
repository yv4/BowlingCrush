using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCtrl : AbstractCtrlBase
{
    #region 成员变量


    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
       
    }

    protected override void OnInit()
    {
     
    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 刷新随机任务
    /// </summary>
    public void RefreshRandomMission()
    {
        UserPeresistData.Instance.GetRandomTask();
        UserPeresistData.Instance.SaveToJson();
    }

    /// <summary>
    /// 检测任务是否完成
    /// </summary>
    public void CheckFinishMission()
    {
        UserResourceEntity user = UserPeresistData.Instance.GetUserResource();
        TaskType taskType = (TaskType)user.TaskType;
        int finishCount = 0;
        switch (taskType)
        {
            case TaskType.ColliderBotton:
                {
                    finishCount = GameTags.ColliderBottonCount;
                }
                break;
            case TaskType.PlayGameCount:
                {
                    finishCount = GameTags.PlayGameCount;
                }
                break;
            case TaskType.GetCoinCount:
                {
                    finishCount = GameTags.GetCoinCount;
                }
                break;
            case TaskType.CompleteMissionCount:
                {
                    finishCount = GameTags.CompleteMissionCount;
                }
                break;
            default:
                break;
        }

        if (user.TaskCompleteCount>=finishCount)
        {
            user.TaskCompleteCount = 0;
            user.FinishStarCount++;
        }

        if (user.FinishStarCount>=4)
        {
            user.FinishStarCount = 4;
            EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.FinishTask);
        }
    }

    #endregion

    #region 委托方法

    #endregion
}
