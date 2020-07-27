using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartEnvCtrl : AbstractCtrlBase
{
    #region 成员变量

    public GameObject[] Effects;

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
    /// 随机播放特效
    /// </summary>
    public void PlayRandomEffect()
    {
        foreach (GameObject gameObj in Effects)
        {
            gameObj.SetActive(false);
        }

        if (Effects.Length>0)
        {
            int randomVal = Random.Range(0, Effects.Length);
            GameObject effectObj = Effects[randomVal];
            LocalDataMgr.Instance.EnvEffectIndex = randomVal;
            effectObj.SetActive(true);
        }

    }

    #endregion

    #region 委托方法

    #endregion
}
