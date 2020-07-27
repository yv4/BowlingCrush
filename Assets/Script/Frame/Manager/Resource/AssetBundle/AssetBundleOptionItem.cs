using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public enum OptionType
{
    AssetBundleLoad,
    AssetBundleFileLoad
}

public class AssetBundleOptionItem:MonoBehaviour  {

    
    #region 成员

    private Action<AssetBundle> m_HandleDelegate;
    private Action<Object> m_HandleObjDelegate;
    private AssetBundle m_AssetBundle;
    private Object m_AssetFile;

    private AssetBundle m_LoadAssetOfAssetBundle;
    private OptionType m_OptionType;

    #endregion

    #region 生命周期


    #endregion

    #region 成员方法

    /// <summary>
    /// 初始化AssetBundle
    /// </summary>
    /// <param name="handleDelegate"></param>
    public void AssetBundleOptionItemInit(string filePath, Action<AssetBundle> handleDelegate = null)
    {
        m_OptionType = OptionType.AssetBundleLoad;
        m_HandleDelegate = handleDelegate;
        StartCoroutine(RunAssetHandleMethod(filePath));
    }

    /// <summary>
    /// 初始化Object
    /// </summary>
    public void ObjOptionItemInit(string filePath,AssetBundle assetBundle, Action<Object> handleDelegate = null)
    {
        m_OptionType = OptionType.AssetBundleFileLoad;
        m_HandleObjDelegate = handleDelegate;
        m_LoadAssetOfAssetBundle = assetBundle;
        StartCoroutine(RunObjHandleMethod(filePath));

    }

    private IEnumerator RunAssetHandleMethod(string filePath)
    {
        AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(filePath);
        yield return request;
        AssetBundle ab=request.assetBundle;
        m_AssetBundle = ab;
        AssetBundleMgr.Instance.Enqueue(this);
    }

    private IEnumerator RunObjHandleMethod(string filePath)
    {
        if (m_LoadAssetOfAssetBundle!=null)
        {
            AssetBundleRequest request = m_LoadAssetOfAssetBundle.LoadAssetAsync(filePath);
            yield return request;
            m_AssetFile = request.asset;
            AssetBundleMgr.Instance.Enqueue(this);

        }

    }

    public void CompleteHandle()
    {
        if (m_OptionType==OptionType.AssetBundleLoad)
        {
            m_HandleDelegate(m_AssetBundle);
        }
        else
        {
            m_HandleObjDelegate(m_AssetFile);
        }
    }

    #endregion
}
