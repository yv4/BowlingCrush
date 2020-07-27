using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMgrBase : MonoBehaviour {


    private float m_EnterNextLevelTimer = 0;
    private float m_EnterNextLevelThreshold = 1;
    private bool m_EnableEnterNextLevel;

    // Use this for initialization
    protected void Awake()
    {
        OnAwake();
        GetMemberReference();

        EventObserverMgr<SceneType>.Instance.RegisterAction(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterNewScene, EnterGameRunMethod);
    }

    protected  void Start () {

        OnStart();
        OnInit();
	}
	
	// Update is called once per frame
	protected  void Update () {

        OnUpdate();

        EnterNextLevel();
    }

    protected  void OnDestroy()
    {
        OnBeforeDestroy();
        DestroySelf();
        EventObserverMgr<SceneType>.Instance.RemoveEventListener(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.EnterNewScene, EnterGameRunMethod);
    }

    #region 虚方法

    protected virtual void OnAwake() { }
    protected virtual void OnUpdate() { }
    protected virtual void OnStart() { }
    protected virtual void OnBeforeDestroy() { }

    protected abstract void GetMemberReference();
    protected abstract void OnInit();
    protected abstract void DestroySelf();

    protected virtual void EnterNextLevel()
    {
        if (m_EnableEnterNextLevel)
        {
            if (m_EnterNextLevelTimer > m_EnterNextLevelThreshold)
            {
                SceneMgrMaster.Instance.CloseLoader();
                m_EnableEnterNextLevel = false;
            }
            else
            {
                m_EnterNextLevelTimer += Time.deltaTime;
            }
        }

    }

    /// <summary>
    /// 进入游戏运行场景
    /// </summary>
    private void EnterGameRunMethod(SceneType parameter)
    {
      
        SceneType scene = parameter;
        SceneMgrMaster.Instance.LoadScene(scene);
    }

    protected void SetEnterNextLevelEnable()
    {
        m_EnableEnterNextLevel = true;
    }


    #endregion
}
