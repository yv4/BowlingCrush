using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TimerDelay;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

/// <summary>
/// 资源管理类 加载各类预制
/// </summary>
public class ResourcesMgr : Singleton<ResourcesMgr>
{

    #region ResourceType 资源类型
    /// <summary>
    /// 资源类型
    /// </summary>
    public enum ResourceType
    {
        //场景UI
        UIScene,
        //窗口
        UIWindow,
        //角色
        Role,

        #region 角色子项

        //角色_太空垃圾
        Role_SpaceTrash,
        //角色_陨石
        Role_Meteorelite,
        //角色_静态陨石
        Role_StaticMeteorolite,
        //角色_行星
        Role_Star,
        //角色_飞船
        Role_Ship,
        //角色爆炸
        Role_Explosion,

        #endregion

        //特效
        Effect,
        //其他
        UIOther,
        //窗口子项
        UIWindowsChild,
        //滚动背景
        ScrollBG,
        //背景音乐
        AudioBackground,
        //背景音效
        AudioEffect,
        //精灵
        PlayerSprite,
        //灾难
        Disaster
    }

    #endregion

    //预制键值表
    private Hashtable m_PrefabTable;

    private AssetBundle m_SceneAssetBundle;
    private List<AssetBundle> m_SceneDPAssetbundle;
    private List<AssetBundle> m_ItemDpAssetbundle = new List<AssetBundle>();
    //private List<AssetBundle> m_ItemRefAssetbundle = new List<AssetBundle>();

    private AssetBundle m_ManifestBundle;
    private AssetBundleManifest m_ManifestFile;
    private Dictionary<string, AssetBundle> m_LoadPrefabAssetBundle = new Dictionary<string, AssetBundle>();
    private Dictionary<string, AssetBundle> m_PrefabDPBundle = new Dictionary<string, AssetBundle>();
    private string m_AssetBundleDirectorPath = Application.persistentDataPath + "/" + m_AssetBundlePrentPath + "/" + m_WindowsName + "/";
    private const string m_AssetBundlePrentPath = "AssetBundles";
    private const string m_WindowsName = "AndroidInit";
    private const string m_ManifestFileName = ".manifest";
    private const string m_SceneFileName = ".unity3d";

    public ResourcesMgr()
    {
        m_PrefabTable = new Hashtable();
    }

    #region 加载资源

    /// <summary>
    /// 加载资源
    /// </summary>
    /// <param name="type">资源类型</param>
    /// <param name="path">短路径</param>
    /// <param name="cache">是否放入缓存</param>
    /// <param name="returnClone">是否返回克隆体</param>
    /// <returns>预设克隆体</returns>
    //public T Load<T>(ResourceType type, string path, bool cache = false) where T : class
    //{
    //    //要返回的对象
    //    T obj = null;

    //    //键值表中有存储则直接返回
    //    if (m_PrefabTable.Contains(path))
    //    {
    //        obj = m_PrefabTable[path] as T;
    //    }
    //    else
    //    {
    //        #region 拼接路径字符串

    //        //要拼接的路径字符串
    //        StringBuilder sbr = new StringBuilder();
    //        switch (type)
    //        {
    //            case ResourceType.AudioBackground:
    //                sbr.Append("Audio/BackGround/");
    //                break;
    //            case ResourceType.AudioEffect:
    //                sbr.Append("Audio/AudioEffect/");
    //                break;
    //            default:
    //                break;
    //        }
    //        sbr.Append(path);

    //        #endregion

    //        //加载预制
    //        obj = Resources.Load(sbr.ToString()) as T;

    //        //如果需要缓存，则加入键值表
    //        if (cache)
    //        {
    //            m_PrefabTable.Add(path, obj);
    //        }
    //    }
    //    return obj;

    //}

    /// <summary>
    /// 从AssetBundle中加载资源
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="fileName"></param>
    /// <param name="cache"></param>
    /// <param name="returnClone"></param>
    /// <returns></returns>
    public T LoadFromAssetBundle<T>(string filePath, bool cache = false, bool returnClone = true) where T : UnityEngine.Object
    {
        int fileNameIndex = filePath.LastIndexOf('/') + 1;
        int fileNameLength = filePath.Length - fileNameIndex;
        string fileFullName = filePath.Substring(fileNameIndex, fileNameLength);
        string[] Suffixs = fileFullName.Split('.');
        string fileName = Suffixs[0];
        string bundleName = filePath;

        //要返回的对象
        T obj = null;

        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(fileName))
        {
            obj = m_PrefabTable[fileName] as T;

            if (returnClone)
            {
                T retObj = Object.Instantiate<T>(obj);

                return retObj;
            }
        }
        else
        {

            //拼接AssetBundle包路径
            string assetPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, bundleName);

            //拼接AssetBundleManiFest包路径
            //StringBuilder sb = new StringBuilder("file:///");
            StringBuilder sb = new StringBuilder("");
            sb.Append(m_AssetBundleDirectorPath);
            sb.Append(m_WindowsName);
            string assetManifestPath = sb.ToString();
            //加载AssetBundleManiFest文件
            try
            {
                //this.ClearAssetRefBundle();

                //Manifest文件
                AssetBundleManifest manifestFile = null;

                //Manifest AB包
                AssetBundle manifestBundle = null;

                if (!m_ManifestBundle)
                {
                    manifestBundle = AssetBundle.LoadFromFile(assetManifestPath);
                    m_ManifestBundle = manifestBundle;
                    manifestFile = manifestBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
                    m_ManifestFile = manifestFile;
                }

                //m_ItemRefAssetbundle.Add(manifestBundle);

                //获取依赖项
                string[] arrDp = m_ManifestFile.GetAllDependencies(bundleName);
                //this.ClearAssetDPBundle();
                //循环加载依赖AssetBundle
                for (int i = 0; i < arrDp.Length; i++)
                {
                    string strDpPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, arrDp[i]); ;
                    if (!m_PrefabDPBundle.ContainsKey(strDpPath))
                    {
                        AssetBundle dpBundle = AssetBundle.LoadFromFile(strDpPath);
                        m_PrefabDPBundle.Add(strDpPath, dpBundle);
                    }

                }

                AssetBundle prefabAssetBundle = null;

                //加载AssetBundle文件读取GameObject
                if (!m_LoadPrefabAssetBundle.ContainsKey(assetPath))
                {
                    if (m_PrefabDPBundle.ContainsKey(assetPath))
                    {
                        prefabAssetBundle = m_PrefabDPBundle[assetPath];
                        m_LoadPrefabAssetBundle.Add(assetPath, prefabAssetBundle);
                    }
                    else
                    {
                        if (File.Exists(assetPath))
                        {
                            prefabAssetBundle = AssetBundle.LoadFromFile(assetPath);
                            if (prefabAssetBundle != null)
                            {
                                m_LoadPrefabAssetBundle.Add(assetPath, prefabAssetBundle);
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }

                    }

                }
                else
                {
                    prefabAssetBundle = m_LoadPrefabAssetBundle[assetPath];
                }

                //m_ItemRefAssetbundle.Add(assetBundle);

                //if (!prefabAssetBundle)
                //{
                //卸载各个AB包
                //这里之所以要等待是因为Unity的Bug 它卸载时候线程会冲突 等待就可避免这个问题 也许有更好的办法 但我没发现
                //Timer.Register(0.1f, () =>
                //{
                //    manifestBundle.Unload(false);
                //});
                //manifestBundle.Unload(false);
                //m_ItemDpAssetbundle = arrDpBundles;
                //return null;
                //}

                T prefab = prefabAssetBundle.LoadAsset<T>(fileName);

                m_PrefabTable.Add(fileName, prefab);

                //Timer.Register(0.1f,()=>{

                //    foreach (var item in arrDpBundles)
                //    {
                //        item.Unload(false);
                //    }

                //});


                obj = prefab;
                if (!obj)
                {
                    //卸载各个AB包
                    //Timer.Register(0.1f, () =>
                    //{
                    //    manifestBundle.Unload(false);
                    //    assetBundle.Unload(false);
                    //});

                    //manifestBundle.Unload(false);
                    //assetBundle.Unload(false);
                    //m_ItemDpAssetbundle = arrDpBundles;
                    return null;
                }

                //卸载各个AB包
                //Timer.Register(0.1f, () =>
                //{
                //    manifestBundle.Unload(false);
                //    assetBundle.Unload(false);
                //});
                //manifestBundle.Unload(false);
                //assetBundle.Unload(false);

                if (returnClone)
                {
                    if (returnClone)
                    {
                        T retObj = Object.Instantiate(obj);

                        //m_ItemDpAssetbundle = arrDpBundles;
                        return retObj;
                    }
                }
                else
                {
                    //m_ItemDpAssetbundle = arrDpBundles;
                    return obj;
                }
            }
            catch (System.Exception)
            {

                return null;
            }


        }

        return obj;

    }

    /// <summary>
    /// 加载资源
    /// </summary>
    /// <param name="type">资源类型</param>
    /// <param name="path">短路径</param>
    /// <param name="cache">是否放入缓存</param>
    /// <param name="returnClone">是否返回克隆体</param>
    /// <returns>预设克隆体</returns>
    public GameObject Load(ResourceType type, string path, bool cache = false, bool returnClone = true)
    {
        //要返回的对象
        GameObject obj = null;

        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(path))
        {
            obj = m_PrefabTable[path] as GameObject;
        }
        else
        {
            #region 拼接路径字符串

            //要拼接的路径字符串
            StringBuilder sbr = new StringBuilder();
            string typeStr = type.ToString();
            string[] typeSplite = BaseOption.SpliteStr('_', typeStr);

            foreach (string str in typeSplite)
            {
                sbr.Append(str + "/");
            }

            sbr.Append(path);
            #endregion

            //加载预制
            obj = Resources.Load(sbr.ToString()) as GameObject;

            //如果需要缓存，则加入键值表
            if (cache)
            {
                m_PrefabTable.Add(path, obj);
            }
        }

        if (returnClone)
        {
            GameObject retObj = Object.Instantiate(obj);
            return retObj;
        }
        else
        {
            return obj;
        }
    }

    public GameObject Load(string path, bool cache = false, bool returnClone = true)
    {
        //要返回的对象
        GameObject obj = null;

        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(path))
        {
            obj = m_PrefabTable[path] as GameObject;
        }
        else
        {

            //加载预制
            obj = Resources.Load(path.ToString()) as GameObject;

            //如果需要缓存，则加入键值表
            if (cache)
            {
                m_PrefabTable.Add(path, obj);
            }
        }

        if (returnClone)
        {
            GameObject retObj = Object.Instantiate(obj);
            return retObj;
        }
        else
        {
            return obj;
        }
    }

    public T Load<T>(string path, bool cache = false, bool returnClone = true) where T : UnityEngine.Object
    {
        //要返回的对象
        T obj = null;

        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(path))
        {
            obj = m_PrefabTable[path] as T;
        }
        else
        {

            //加载预制
            obj = Resources.Load<T>(path.ToString());

            //如果需要缓存，则加入键值表
            if (cache)
            {
                m_PrefabTable.Add(path, obj);
            }
        }

        if (returnClone)
        {
            T retObj = Object.Instantiate(obj);
            return retObj;
        }
        else
        {
            return obj;
        }
    }

    /// <summary>
    /// 加载Sprite
    /// </summary>
    /// <param name="type">资源类型</param>
    /// <param name="path">短路径</param>
    /// <param name="cache">是否放入缓存</param>
    /// <param name="returnClone">是否返回克隆体</param>
    /// <returns>预设克隆体</returns>
    public Sprite LoadSprite(ResourceType type, string path, bool cache = false)
    {
        //要返回的对象
        Sprite obj = null;

        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(path))
        {
            obj = m_PrefabTable[path] as Sprite;
        }
        else
        {
            #region 拼接路径字符串

            //要拼接的路径字符串
            StringBuilder sbr = new StringBuilder();
            sbr.Append(type.ToString() + "/");
            sbr.Append(path);

            #endregion

            //加载预制

            obj = Resources.Load<Sprite>(sbr.ToString());

            //如果需要缓存，则加入键值表
            if (cache)
            {
                m_PrefabTable.Add(path, obj);
            }
        }

        return obj;
    }

    /// <summary>
    /// 加载Sprite
    /// </summary>
    /// <param name="type">资源类型</param>
    /// <param name="path">短路径</param>
    /// <param name="cache">是否放入缓存</param>
    /// <param name="returnClone">是否返回克隆体</param>
    /// <returns>预设克隆体</returns>
    public Sprite LoadSprite(string path, bool cache = false)
    {

        //要返回的对象
        Sprite obj = null;

        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(path))
        {
            obj = m_PrefabTable[path] as Sprite;
        }
        else
        {
          
            //加载预制
            obj = Resources.Load<Sprite>(path);

            //如果需要缓存，则加入键值表
            if (cache)
            {
                m_PrefabTable.Add(path, obj);
            }
        }

        return obj;
    }

    /// <summary>
    /// LoadFromAssetBundleAsync
    /// </summary>
    /// <param name="filePaht"></param>
    /// <param name="cache"></param>
    /// <param name="returnClone"></param>
    public GameObject LoadFromAssetBundle(string filePath, bool cache = false, bool returnClone = true, bool isScene = false)
    {
        int fileNameIndex = filePath.LastIndexOf('/') + 1;
        int fileNameLength = filePath.Length - fileNameIndex;
        string fileFullName = filePath.Substring(fileNameIndex, fileNameLength);
        string[] Suffixs = fileFullName.Split('.');
        string fileName = Suffixs[0];
        string bundleName = filePath;

        //要返回的对象
        GameObject obj = null;

        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(fileName))
        {
            obj = m_PrefabTable[fileName] as GameObject;

            if (returnClone)
            {
                GameObject retObj = Object.Instantiate(obj);

                return retObj;
            }
        }
        else
        {
            //所依赖的资源包
            //List<AssetBundle> arrDpBundles = new List<AssetBundle>();

            //加载文件AB包
            //AssetBundle assetBundle = null;

            //拼接AssetBundle包路径
            string assetPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, bundleName);

            //拼接AssetBundleManiFest包路径
            //StringBuilder sb = new StringBuilder("file:///");
            StringBuilder sb = new StringBuilder("");
            sb.Append(m_AssetBundleDirectorPath);
            sb.Append(m_WindowsName);
            string assetManifestPath = sb.ToString();
            //加载AssetBundleManiFest文件
            try
            {
                //ClearAssetRefBundle();

                if (!m_ManifestBundle)
                {
                    //Manifest AB包
                    AssetBundle manifestBundle = null;

                    //Manifest文件
                    AssetBundleManifest manifestFile = null;

                    manifestBundle = AssetBundle.LoadFromFile(assetManifestPath);
                    manifestFile = manifestBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
                    m_ManifestBundle = manifestBundle;
                    m_ManifestFile = manifestBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
                }

                //m_ItemRefAssetbundle.Add(manifestBundle);

                //获取依赖项
                string[] arrDp = m_ManifestFile.GetAllDependencies(bundleName);

                //ClearAssetDPBundle();//清除依赖包
                //循环加载依赖AssetBundle
                for (int i = 0; i < arrDp.Length; i++)
                {
                    string strDpPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, arrDp[i]); ;
                    if (!m_PrefabDPBundle.ContainsKey(strDpPath))
                    {
                        AssetBundle dpBundle = AssetBundle.LoadFromFile(strDpPath);
                        m_PrefabDPBundle.Add(strDpPath, dpBundle);
                    }
                }

                AssetBundle prefabAssetBundle = null;

                //加载AssetBundle文件读取GameObject
                if (!m_LoadPrefabAssetBundle.ContainsKey(assetPath))
                {
                    prefabAssetBundle = AssetBundle.LoadFromFile(assetPath);
                    m_LoadPrefabAssetBundle.Add(assetPath, prefabAssetBundle);
                }
                else
                {
                    prefabAssetBundle = m_LoadPrefabAssetBundle[assetPath];
                }

                if (isScene)
                {
                    return null;
                }

                //加载AssetBundle文件读取GameObject

                // assetBundle = AssetBundle.


                //if (!assetBundle)
                //{
                //卸载各个AB包
                //这里之所以要等待是因为Unity的Bug 它卸载时候线程会冲突 等待就可避免这个问题 也许有更好的办法 但我没发现
                //Timer.Register(0.1f, () =>
                //{
                //    manifestBundle.Unload(false);

                //});

                //manifestBundle.Unload(false);
                //m_ItemDpAssetbundle = arrDpBundles;
                //return null;
                //}

                //m_ItemRefAssetbundle.Add(assetBundle);
                Object prefab = prefabAssetBundle.LoadAsset(fileName);

                m_PrefabTable.Add(fileName, prefab);

                //Timer.Register(0.1f, () => {

                //    foreach (var item in arrDpBundles)
                //    {

                //        item.Unload(false);
                //    }

                //});

                obj = prefab as GameObject;
                //if (!obj)
                //{
                //manifestBundle.Unload(false);
                //assetBundle.Unload(false);
                //m_ItemDpAssetbundle = arrDpBundles;
                // return null;
                // }

                //Debug.Log(manifestBundle.name + "ManifestBundle is will Unload");
                //manifestBundle.Unload(false);

                //Debug.Log(assetBundle.name + " is will Unload");
                //assetBundle.Unload(false);

                if (returnClone)
                {
                    GameObject retObj = Object.Instantiate(obj);

                    //m_ItemDpAssetbundle = arrDpBundles;

                    return retObj;
                }
                else
                {
                    //m_ItemDpAssetbundle = arrDpBundles;
                    return obj;
                }
            }
            catch (System.Exception ex)
            {
                Debug.Log("错误" + ex.Message);
                return null;
            }


        }

        return obj;
    }

    /// <summary>
    /// 清除Bundle包
    /// </summary>
    public void ClearAsssetBundle()
    {
        if (m_ManifestBundle != null)
        {
            m_ManifestBundle.Unload(m_ManifestBundle);
            m_ManifestBundle = null;
            m_ManifestFile = null;
        }

        foreach (string key in m_PrefabDPBundle.Keys)
        {
            AssetBundle dpBundle = m_PrefabDPBundle[key];
            dpBundle.Unload(false);
        }

        m_PrefabDPBundle.Clear();

        foreach (string key in m_LoadPrefabAssetBundle.Keys)
        {
            AssetBundle prefabBundle = m_LoadPrefabAssetBundle[key];
            if (prefabBundle != null)
            {
                prefabBundle.Unload(false);
            }

        }

        m_LoadPrefabAssetBundle.Clear();

        AssetBundle.UnloadAllAssetBundles(false);
    }

    /// <summary>
    /// 清除依赖包
    /// </summary>
    //private void ClearAssetDPBundle()
    //{
    //    foreach (var item in m_ItemDpAssetbundle)
    //    {
    //        item.Unload(false);
    //    }

    //    m_ItemDpAssetbundle.Clear();
    //}

    /// <summary>
    /// 清除相关包
    /// </summary>
    //public void ClearAssetRefBundle()
    //{
    //    foreach (var item in m_ItemRefAssetbundle)
    //    {
    //        item.Unload(false);
    //    }

    //    m_ItemRefAssetbundle.Clear();
    //}

    /// <summary>
    /// 从AssetBundle中异步加载资源
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="fileName"></param>
    /// <param name="cache"></param>
    /// <param name="returnClone"></param>
    /// <returns></returns>
    public void LoadFromAssetBundleAsync(string filePath, Action<GameObject> complete, bool cache = false, bool returnClone = true)
    {
        int fileNameIndex = filePath.LastIndexOf('/') + 1;
        int fileNameLength = filePath.Length - fileNameIndex;
        string fileFullName = filePath.Substring(fileNameIndex, fileNameLength);
        string[] Suffixs = fileFullName.Split('.');
        string fileName = Suffixs[0];
        string bundleName = filePath;

        //要返回的对象
        GameObject obj = null;
        //this.ClearAssetRefBundle();
        //键值表中有存储则直接返回
        if (m_PrefabTable.Contains(fileName))
        {
            obj = m_PrefabTable[fileName] as GameObject;
        }
        else
        {
            //所依赖的资源包
            List<AssetBundle> arrDpBundles = new List<AssetBundle>();

            //Manifest文件
            AssetBundleManifest manifestFile = null;

            //Manifest AB包
            AssetBundle manifestBundle = null;

            //加载文件AB包
            AssetBundle assetBundle = null;

            //拼接AssetBundle包路径
            string assetPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, bundleName);

            //拼接AssetBundleManiFest包路径
            string assetManifestPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, m_WindowsName);
            //加载AssetBundleManiFest文件
            AssetBundleMgr.Instance.InsertLoadAssetItem(assetManifestPath, (AssetBundle manifest) =>
            {

                manifestBundle = manifest;

                AssetBundleMgr.Instance.InsertLoadFileItem("AssetBundleManifest", manifestBundle, (Object mainfestFileObj) =>
                {
                    manifestFile = mainfestFileObj as AssetBundleManifest;
                    string[] arrDp = manifestFile.GetAllDependencies(bundleName);
                    //循环加载依赖AssetBundle

                    #region 加载依赖项

                    for (int i = 0; i < arrDp.Length; i++)
                    {
                        string strDpsPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, arrDp[i]); ;
                        //this.ClearAssetDPBundle();
                        AssetBundleMgr.Instance.InsertLoadAssetItem(strDpsPath, (AssetBundle dpBundle) =>
                        {
                            arrDpBundles.Add(dpBundle);
                            //如果所有依赖项加载完毕

                            if (arrDpBundles.Count >= arrDp.Length)
                            {
                                #region 加载指定Bundle

                                AssetBundleMgr.Instance.InsertLoadAssetItem(assetPath, (AssetBundle getBundleObj) =>
                                {
                                    assetBundle = getBundleObj;
                                    m_ItemDpAssetbundle.Add(getBundleObj);
                                    AssetBundleMgr.Instance.InsertLoadFileItem(fileName, assetBundle, (Object retFileObj) =>
                                    {
                                        obj = assetBundle.LoadAsset(fileName) as GameObject;
                                        //m_ItemRefAssetbundle.Add(assetBundle);
                                        //这里之所以要等待是因为Unity的Bug 它卸载时候线程会冲突 等待就可避免这个问题 也许有更好的办法 但我没发现

                                        manifestBundle.Unload(false);
                                        assetBundle.Unload(false);

                                        if (returnClone)
                                        {
                                            GameObject retObj = UnityEngine.Object.Instantiate(obj);
                                            m_ItemDpAssetbundle = arrDpBundles;

                                            if (complete != null)
                                            {
                                                complete(retObj);
                                            }
                                        }
                                        else
                                        {
                                            m_ItemDpAssetbundle = arrDpBundles;


                                            if (complete != null)
                                            {
                                                complete(obj);
                                            }

                                        }

                                    });
                                });

                                #endregion

                            }
                        });
                    }

                    #endregion

                    #region 加载指定Bundle

                    AssetBundleMgr.Instance.InsertLoadAssetItem(assetPath, (AssetBundle getBundleObj) =>
                    {
                        assetBundle = getBundleObj;
                        //m_ItemDpAssetbundle.Add(getBundleObj);
                        AssetBundleMgr.Instance.InsertLoadFileItem(fileName, assetBundle, (Object retFileObj) =>
                        {
                            Timer.Register(0.1f, () => {

                                foreach (var item in arrDpBundles)
                                {
                                    item.Unload(false);
                                }

                            });

                            obj = assetBundle.LoadAsset(fileName) as GameObject;
                            //m_ItemRefAssetbundle.Add(assetBundle);
                            //这里之所以要等待是因为Unity的Bug 它卸载时候线程会冲突 等待就可避免这个问题 也许有更好的办法 但我没发现

                            manifestBundle.Unload(false);
                            assetBundle.Unload(false);

                            if (returnClone)
                            {
                                GameObject retObj = UnityEngine.Object.Instantiate(obj);
                                //m_ItemDpAssetbundle = arrDpBundles;

                                if (complete != null)
                                {
                                    complete(retObj);
                                }
                            }
                            else
                            {
                                //m_ItemDpAssetbundle = arrDpBundles;


                                if (complete != null)
                                {
                                    complete(obj);
                                }

                            }

                        });
                    });

                    #endregion
                });
            });


        }


    }

    /// <summary>
    /// 从AssetBundle中加载场景
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="fileName"></param>
    /// <param name="cache"></param>
    /// <param name="returnClone"></param>
    /// <returns></returns>
    public void LoadSceneFromAssetBundle(string bundleName)
    {

        //所依赖的资源包
        List<AssetBundle> arrDpBundles = new List<AssetBundle>();

        //Manifest文件
        AssetBundleManifest manifestFile = null;

        //Manifest AB包
        AssetBundle manifestBundle = null;

        //加载文件AB包
        AssetBundle assetBundle = null;

        //拼接AssetBundle包路径
        string assetPath = string.Format("{0}{1}{2}", m_AssetBundleDirectorPath, bundleName, m_SceneFileName);

        //拼接AssetBundleManiFest包路径
        string assetManifestPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, m_WindowsName);


        //加载AssetBundleManiFest文件
        manifestBundle = AssetBundle.LoadFromFile(assetManifestPath);
        manifestFile = manifestBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");

        //获取依赖项
        string[] arrDp = manifestFile.GetAllDependencies(bundleName);

        //循环加载依赖AssetBundle
        for (int i = 0; i < arrDp.Length; i++)
        {
            string strDpsPath = string.Format("{0}{1}", m_AssetBundleDirectorPath, arrDp[i]); ;
            AssetBundle dpBundle = AssetBundle.LoadFromFile(strDpsPath);
            arrDpBundles.Add(dpBundle);
        }

        //加载AssetBundle文件读取GameObject
        assetBundle = AssetBundle.LoadFromFile(assetPath);

        this.m_SceneAssetBundle = assetBundle;
        this.m_SceneDPAssetbundle = arrDpBundles;
    }

    public void UnLoadSceneFromAssetBundle()
    {
        //卸载AssetBundle
        if (this.m_SceneAssetBundle != null)
        {
            this.m_SceneAssetBundle.Unload(false);
        }

        //循环卸载依赖AssetBundle
        foreach (AssetBundle assetBundle in m_SceneDPAssetbundle)
        {
            assetBundle.Unload(false);
        }
    }

    #endregion

    #region 释放资源

    public override void Dispose()
    {
        base.Dispose();
        m_PrefabTable.Clear();
        Debug.Log("销毁");
        this.ClearAsssetBundle();
    }
    #endregion
}
