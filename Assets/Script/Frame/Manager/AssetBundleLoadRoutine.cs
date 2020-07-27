using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class AssetBundleLoadRoutine : MonoBehaviour {

    #region 成员

    public Action HandleDelegate;
    private string m_BundleName;
    private string m_FileName;
    private string m_AssetBundleDirectorPath;
    private string m_WindownName;

    #endregion

    #region 生命周期



    #endregion

    #region 成员方法

    public void AssetBundleLoadRoutineInit(string bundleName, string fileName, string assetBundleDirectorPath, string windownName, Action handleDelegate)
    {
        m_BundleName = bundleName;
        m_FileName = fileName;
        m_WindownName = windownName;
        m_AssetBundleDirectorPath = assetBundleDirectorPath;
        HandleDelegate = handleDelegate;

    }

    private void LoadDPBundle(string[] arrDp, List<AssetBundle> arrDpBundles, string assetPath, AssetBundle mainfestBundle)
    {
        //循环加载依赖AssetBundle
        for (int i = 0; i < arrDp.Length; i++)
        {
            string strDpsPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, arrDp[i]);

            //协程加载依赖项
            StartCoroutine(AssetBundleAsync(strDpsPath, (AssetBundle dpAssetBundleFile) =>
            {
                arrDpBundles.Add(dpAssetBundleFile);

                //依赖项加载完毕
                if (arrDpBundles.Count == arrDp.Length)
                {
                    //加载文件AssetBundle包
                    StartCoroutine(AssetBundleAsync(assetPath, (AssetBundle assetBundleFile) =>
                    {
                        if (assetBundleFile != null)
                        {
                            UnityEngine.Object file = assetBundleFile.LoadAsset(m_FileName);

                            //卸载各个AB包
                            mainfestBundle.Unload(false);
                            assetBundleFile.Unload(false);

                            foreach (AssetBundle dpBundle in arrDpBundles)
                            {
                                dpBundle.Unload(false);
                            }

                            if (HandleDelegate != null)
                            {
                                HandleDelegate();
                            }
                        }

                    }));
                }
            }));
        }
    }

    public void LoadAssetBundle(Action completeDelegate)
    {

        //所依赖的资源包
        List<AssetBundle> arrDpBundles = new List<AssetBundle>();
        //Manifest文件
        AssetBundleManifest manifestFile = null;

        //Manifest AB包
        AssetBundle mainfestBundle = null;

        //拼接AssetBundle包路径
        string assetPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, m_BundleName);

        //拼接AssetBundleManiFest包路径
        //StringBuilder sb = new StringBuilder("file:///");
        StringBuilder sb = new StringBuilder("");
        sb.Append(m_AssetBundleDirectorPath);
        sb.Append(m_WindownName);
        string assetManifestPath = sb.ToString();

        StartCoroutine(AssetBundleAsync(assetManifestPath, (AssetBundle bundle) => {

            if (bundle != null)
            {
                mainfestBundle = bundle;
                manifestFile = bundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");

                //获取依赖项
                string[] arrDp = manifestFile.GetAllDependencies(m_BundleName);

                if (arrDp.Length > 0)
                {
                    LoadDPBundle(arrDp, arrDpBundles, assetPath, mainfestBundle);
                }
            }

        }));

    }

    private IEnumerator AssetBundleAsync(string path, Action<AssetBundle> completeDelegate)
    {
        UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequestAssetBundle.GetAssetBundle(path);

        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {

            // Extracts AssetBundle
            AssetBundle bundle = (www.downloadHandler as UnityEngine.Networking.DownloadHandlerAssetBundle).assetBundle;

            if (completeDelegate != null)
            {
                completeDelegate(bundle);
            }

        }
    }

    #endregion
}
