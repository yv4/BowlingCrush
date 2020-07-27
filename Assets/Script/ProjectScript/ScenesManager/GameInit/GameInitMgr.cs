using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MobiiGame.Sdk.Gift;

public class GameInitMgr : AbstractMgrBase
{

    #region 成员变量

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        object obj = LocalDataMgr.Instance;
      
    }

    protected override void OnInit()
    {
        Application.targetFrameRate = 60;
         EventObserverMgr<SceneType>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterNewScene, SceneType.GameStart);
        this.GetSystemTime();
    }

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 委托方法



    #endregion

    #region 成员方法

    /// <summary>
    /// 获取系统时间
    /// </summary>
    private void GetSystemTime()
    {
        System.DateTime now = System.DateTime.Now;
        int dayOfYear = now.DayOfYear;
        int lastDay = PlayerPrefs.GetInt("DayOfYear");
        if (lastDay<=0)
        {
            PlayerPrefs.SetInt("DayOfYear", dayOfYear);
        }
        else
        {
            int dayOffset = dayOfYear - lastDay;
            if (dayOfYear>=1)
            {
                PlayerPrefs.SetInt(GameTags.DailyInsertAdsCount, 0);
            }
        }
      
    }

    #endregion

}