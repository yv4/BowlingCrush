using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMgrMaster : SingletonMono<SceneMgrMaster>
{
    #region 成员

    private GameLoadingMgr m_LoadingScene;
    private Scene m_CurrentScene;
    private Scene m_LoadScene;
    private SceneType m_NextScene = SceneType.None;
    private bool m_NeedSwitchScene;
    private bool m_SetBgClear;

    #region 属性

    public GameLoadingMgr LoadingScene { set { m_LoadingScene = value; } }

    public SceneType NextScene { get { return m_NextScene; } }


    #endregion

    #endregion

    #region 生命周期

    protected override void OnAwake()
    {
        base.OnAwake();


    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoadMethod;
        SceneManager.sceneUnloaded += OnSceneUnLoadMethod;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoadMethod;
        SceneManager.sceneUnloaded -= OnSceneUnLoadMethod;
    }

    protected override void OnStart()
    {
        base.OnStart();

    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
        if (m_NeedSwitchScene)
        {
            if (m_LoadingScene != null)
            {
                m_NeedSwitchScene = false;
                m_LoadingScene.OpenLoading();
            }
        }
    }

    protected override void OnBeforeDestroy()
    {
        base.OnBeforeDestroy();
        m_LoadingScene = null;

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 根据枚举返回场景
    /// </summary>
    /// <param name="sceneType"></param>
    /// <returns></returns>
    public Scene GetSceneWithType(SceneType sceneType)
    {
        Scene scene = SceneManager.GetSceneByName(sceneType.ToString());
        return scene;
    }

    public void LoadScene(SceneType sceneType)
    {
        m_NeedSwitchScene = true;
        m_NextScene = sceneType;
        UIViewMgr.Instance.ClearAllDic();

        if (m_LoadingScene == null)
        {
            SceneMgr.LoadScene(SceneType.GameLoading, LoadSceneMode.Additive);
        }
        else
        {
            EnableOrDisableRootObj(m_LoadScene.GetRootGameObjects(), true);
            //m_LoadingScene.OpenLoading();
        }

    }

    public void CloseLoader()
    {
     
        if (m_LoadingScene != null && m_LoadingScene.name != null)
        {
            if (!m_SetBgClear)
            {
                GameObject[] objs = m_LoadScene.GetRootGameObjects();

                foreach (GameObject obj in objs)
                {
                    if (obj.name.Equals(GameTags.GameLoadingCanvas))
                    {
                        Image bg = BaseOption.FindChild<Image>(obj, "Loader");
                        bg.color = Color.clear;
                        GameObject logo = BaseOption.FindChild(bg.gameObject, "Logo");
                        if (logo!=null)
                        {
                            logo.SetActive(false);
                        }
                    }
                }
                m_SetBgClear = true;
            }
           

            EnableOrDisableRootObj(m_LoadScene.GetRootGameObjects(), false);
        }

        m_NextScene = SceneType.None;
    }


    void EnableOrDisableRootObj(GameObject[] objs, bool enable)
    {
        foreach (GameObject obj in objs)
        {
            obj.SetActive(enable);
        }
    }

    void DisableOldScene()
    {
        EnableOrDisableRootObj(m_CurrentScene.GetRootGameObjects(), false);
        SceneManager.UnloadSceneAsync(m_CurrentScene);
        ResourcesMgr.Instance.Dispose();
        Resources.UnloadUnusedAssets();
        GC.Collect();
    }
    #endregion

    #region 委托

    private void OnSceneUnLoadMethod(Scene arg0)
    {

    }

    private void OnSceneLoadMethod(Scene arg0, LoadSceneMode arg1)
    {
        //获取Loading场景引用
        if (m_LoadScene.name == null)
        {
            if (arg0.name.Equals(SceneType.GameLoading.ToString()))
            {
                m_LoadScene = arg0;
            }
        }

        //加载新场景时若当前场景既非null，又不是Init与Loading场景则将其卸载
        if (m_CurrentScene.name != null &&
            (!m_CurrentScene.name.Equals(SceneType.GameInit.ToString()) &&
            !m_CurrentScene.name.Equals(SceneType.GameLoading.ToString()))
            )
        {
            DisableOldScene();
        }


        this.m_CurrentScene = arg0;

        SceneManager.SetActiveScene(arg0);
    }

    #endregion

}
