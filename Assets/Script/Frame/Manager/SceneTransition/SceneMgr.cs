using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr  {



    #region 加载场景UI

    /// <summary>
    /// 加载场景UI
    /// </summary>
    /// <returns></returns>
    public static AsyncOperation LoadScene(SceneType type, LoadSceneMode mode)
    {
        AsyncOperation asyncOperation;

        switch (type)
        {
            case SceneType.GameInit:
                {
                    asyncOperation= SceneManager.LoadSceneAsync(SceneType.GameInit.ToString(), mode);
                }
                break;
            case SceneType.GameStart:
                {
                    asyncOperation= SceneManager.LoadSceneAsync(SceneType.GameStart.ToString(), mode);
                }
                break;
            case SceneType.GameLoading:
                {
                    asyncOperation = SceneManager.LoadSceneAsync(SceneType.GameLoading.ToString(), mode);
                }
                break;
            case SceneType.GameRun:
                {
                    asyncOperation = SceneManager.LoadSceneAsync(SceneType.GameRun.ToString(), mode);
                }
                break;
            case SceneType.Shop:
                {
                    asyncOperation = SceneManager.LoadSceneAsync(SceneType.Shop.ToString(), mode);
                }
                break;
            case SceneType.Category:
                {
                    asyncOperation = SceneManager.LoadSceneAsync(SceneType.Category.ToString(), mode);
                }
                break;
            case SceneType.Manual:
                {
                    asyncOperation = SceneManager.LoadSceneAsync(SceneType.Manual.ToString(), mode);
                }
                break;
            case SceneType.NewRun:
                {
                    asyncOperation = SceneManager.LoadSceneAsync(SceneType.NewRun.ToString(), mode);
                }
                break;

            default:
                 asyncOperation=null;
                break;

        }

        return asyncOperation;
    }


    #endregion
}
