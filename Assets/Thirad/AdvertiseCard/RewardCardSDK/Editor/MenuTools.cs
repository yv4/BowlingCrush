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
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MobiiGame.Sdk.Gift
{
    public class MenuTools : MonoBehaviour
    {
        //[MenuItem("GameObject/CreateReward", false, 0)]
        //private static void CreateRewardChina()
        //{
        //    var obj = Resources.Load<GameObject>("China/RewardCardSDK");
        //    if (obj)
        //    {
        //        Instantiate(obj);
        //    }
        //    else
        //    {
        //        Debug.Log("创建失败，请联系技术人员");
        //    }
        //}

        [MenuItem("GameObject/Create Reward", false, 0)]
        private static void CreateRewardForeign()
        {
            var obj = Resources.Load<GameObject>("Foreign/RewardCardSDK");
            if (obj)
            {
                Instantiate(obj);
            }
            else
            {
                Debug.Log("创建失败，请联系技术人员");
            }
        }
    }
}