using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonNet<T> :  MonoBehaviour where T:MonoBehaviour {

    #region Instance
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject(typeof(T).Name);
                DontDestroyOnLoad(obj);
                instance = obj.AddComponent<T>();
            }
            return instance;
        }
    }

    #endregion

    #region Mono
    private void Awake()
    {
        OnAwake();
    }
    void Start()
    {
        OnStart();
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }

    private void OnDestroy()
    {
        OnBeforeDestory();
    }
    #endregion

    #region 虚方法
    protected virtual void OnAwake()
    {

    }

    protected virtual void OnStart()
    {

    }

    protected virtual void OnUpdate()
    {

    }

    protected virtual void OnBeforeDestory()
    {

    }
    #endregion

}
