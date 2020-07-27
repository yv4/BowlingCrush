using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Text;
using TimerDelay;
/// <summary>
/// UI窗口管理器
/// </summary>
public class UIViewMgr : Singleton<UIViewMgr>
{
    private Dictionary<ViewUIType, UIBase> m_DicSubView = new Dictionary<ViewUIType, UIBase>();

    /// <summary>
    /// 已经打开的窗口键值表
    /// </summary>
    private Dictionary<string, UIWindowBase> m_DicWindow = new Dictionary<string, UIWindowBase>();

    /// <summary>
    /// 已经打开的窗口数量
    /// </summary>
    public int OpenWindowCount
    {
        get
        {
            return m_DicWindow.Count;
        }
    }

    /// <summary>
    /// 关闭所有窗口
    /// </summary>
    public void CloseAllWindow()
    {
        if (m_DicWindow != null)
        {
            m_DicWindow.Clear();
        }
    }

    #region 克隆子视图

    public GameObject GetSubViewPrefab(ViewUIType type)
    {
       return ResourcesMgr.Instance.Load(ResourcesMgr.ResourceType.UIOther, string.Format("{0}", type.ToString()),true,false);
    }

    public GameObject GetSubViewClone(ViewUIType type, Transform parent)
    {
        if (type == ViewUIType.None)
        {
            return null;
        }

        GameObject obj = null;
        UIBase viewBase = null;

       
        if (!m_DicSubView.ContainsKey(type))
        {
            #region LoadSubView
            //在资源管理类中加载预设并缓存
            obj = ResourcesMgr.Instance.Load(ResourcesMgr.ResourceType.UIOther, string.Format("{0}", type.ToString()));
            if (obj == null)
            {
                return null;
            }

            viewBase = obj.GetComponent<UIBase>();
            if (viewBase == null) return null;

            //添加入键值表
            m_DicSubView.Add(type, viewBase);

            obj.transform.SetParent(parent);
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = Vector3.one;
            #endregion
        }
        else
        {
            //提取窗口
            obj = m_DicSubView[type].gameObject;
            viewBase = obj.GetComponent<UIBase>();
        }


        return obj;
    }

    #endregion

    #region 打开窗口

    /// <summary>
    /// 打开窗口
    /// </summary>
    /// <param name="type">窗口类型</param>
    /// <returns></returns>
    public GameObject OpenWindow(string type,Transform parent,bool fullScreen=false)
    {

        GameObject obj = null;
        UIWindowBase windowBase = null;

        //如果窗口不能存在则
        if (!m_DicWindow.ContainsKey(type))
        {
            #region Load窗口
            //在资源管理类中加载预设并缓存
            obj = ResourcesMgr.Instance.Load(type.ToString());
            //obj = ResourcesMgr.Instance.LoadFromAssetBundle(type);
            if (obj == null)
            {
                return null;
            }
            
            windowBase = obj.GetComponent<UIWindowBase>();
            if (windowBase == null) return null;

            //添加入键值表
            m_DicWindow.Add(type, windowBase);

            //设置当前窗口类型
            windowBase.CurrentUIType = type;
            
            obj.transform.parent = parent;
            if (fullScreen)
            {
                obj.transform.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
                obj.transform.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
            }
          
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = Vector3.one;
            #endregion
        }
        else
        {
            //提取窗口
            obj = m_DicWindow[type].gameObject;
            windowBase = obj.GetComponent<UIWindowBase>();
        }

        //层级管理
       LayerUIMgr.Instance.SetLayer(obj);

        StartShowWindow(windowBase, true);
        return obj;
    }


    /// <summary>
    /// 打开窗口
    /// </summary>
    /// <param name="type">窗口类型</param>
    /// <returns></returns>
    public GameObject OpenWindow(string type, Transform parent,Vector2 pos,RectTransform.Edge edge,Vector2 edgePos)
    {
       

        GameObject obj = null;
        UIWindowBase windowBase = null;

        //如果窗口不能存在则
        if (!m_DicWindow.ContainsKey(type))
        {
            #region Load窗口
            //在资源管理类中加载预设并缓存
            obj = ResourcesMgr.Instance.Load(ResourcesMgr.ResourceType.UIWindow, string.Format("{0}", type.ToString()));
            if (obj == null)
            {
                return null;
            }

            windowBase = obj.GetComponent<UIWindowBase>();
            if (windowBase == null) return null;

            //添加入键值表
            m_DicWindow.Add(type, windowBase);

            //设置当前窗口类型
            windowBase.CurrentUIType = type;

            obj.transform.parent = parent;
            obj.transform.localPosition = pos;
            obj.transform.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(edge, edgePos.x, edgePos.y);
            obj.transform.localScale = Vector3.one;
            #endregion
        }
        else
        {
            //提取窗口
            obj = m_DicWindow[type].gameObject;
            windowBase = obj.GetComponent<UIWindowBase>();
        }

        //层级管理
        LayerUIMgr.Instance.SetLayer(obj);

        StartShowWindow(windowBase, true);
        return obj;
    }

    #endregion

    #region 关闭窗口

    public void CloseWindow(string type)
    {
        if (m_DicWindow.ContainsKey(type))
        {
            StartShowWindow(m_DicWindow[type], false);
        }
    }

    #endregion

    #region 打开与关闭窗口处理方法

    /// <summary>
    ///  打开与关闭窗口处理方法
    /// </summary>
    /// <param name="windowBase"></param>
    /// <param name="isOpen"></param>
    private void StartShowWindow(UIWindowBase windowBase, bool isOpen)
    {
        switch (windowBase.showStyle)
        {
            case WindowShowStyle.Normal:
                ShowNormal(windowBase, isOpen);
                break;
            case WindowShowStyle.CenterToBig:
                ShowCenterToBig(windowBase, isOpen);
                break;
            case WindowShowStyle.FromTop:
                ShowFromDir(windowBase, 0, isOpen, windowBase.transform.localPosition);
                break;
            case WindowShowStyle.FromDown:
                break;
            case WindowShowStyle.FromLeft:
                break;
            case WindowShowStyle.FromRight:
                ShowFromDir(windowBase, 3, isOpen, windowBase.transform.localPosition);
                break;
            default:
                break;
        }
    }

    public void StartShowView(UIBase uiBase, ViewShowStyle showStyle, bool isOpen)
    {
        switch (showStyle)
        {
            case ViewShowStyle.Normal:
                ShowNormal(uiBase, isOpen);
                break;
            case ViewShowStyle.ConterToBig:
                ShowCenterToBig(uiBase, isOpen);
                break;
            case ViewShowStyle.FromTop:
                ShowFromDir(uiBase, 0, isOpen, uiBase.transform.localPosition);
                break;
            case ViewShowStyle.FromDown:
                ShowFromDir(uiBase, 1, isOpen, uiBase.transform.localPosition);
                break;
            case ViewShowStyle.FromLeft:
                ShowFromDir(uiBase,2,isOpen,uiBase.transform.localPosition);
                break;
            case ViewShowStyle.FromRight:
                ShowFromDir(uiBase, 3, isOpen, uiBase.transform.localPosition);
                break;
            default:
                break;
        }
    }

    #endregion

    #region 各种打开效果

    /// <summary>
    /// 正常打开
    /// </summary>
    /// <param name="windowBase"></param>
    /// <param name="isOpen"></param>
    private void ShowNormal(UIBase windowBase,bool isOpen)
    {

        if (isOpen)
        {
            windowBase.gameObject.SetActive(true);
        }
        else
        {
            if(windowBase.GetType() == typeof(UIWindowBase))
            {

                DestoryWindow((UIWindowBase)windowBase);
            }
            else
            {
                windowBase.InActive();
                windowBase.gameObject.SetActive(false);
            }
           
        }
    }

    private void ShowCentToBigSpecial(Transform scaleContent,UIBase windowBase, bool open)
    {
        UIOpenWindowsBase openUI = (UIOpenWindowsBase)windowBase;
        Color color = openUI.BackgroundImg.color;
        Vector3 scaleVal = Vector3.zero;
        windowBase.transform.localScale = Vector3.one;

        if (open)
        {
            if (openUI.ShowBg)
            {
                color.a = 0.8f;
                scaleVal = Vector3.one;
                scaleContent.localScale = Vector3.zero;
            }
            else
            {
                scaleVal = Vector3.one;
                scaleContent.localScale = Vector3.zero;
            }

            openUI.BackgroundImg.DOColor(color, 1).OnComplete(() => {

                windowBase.EffectHaveSet = true;

            });
        }
        else
        {
            if (openUI.ShowBg)
            {
                color.a = 0f;
                scaleVal = Vector3.zero;

                openUI.BackgroundImg.DOColor(color, 0.1f).OnComplete(() => {

                    scaleContent.transform.localScale = Vector3.one;
                    windowBase.transform.localScale = Vector3.zero;
                    windowBase.EffectHaveSet = false;

                    if (windowBase.GetType() == typeof(UIWindowBase))
                    {
                        DestoryWindow((UIWindowBase)windowBase);
                    }
                    else
                    {
                        windowBase.InActive();
                        windowBase.gameObject.SetActive(false);
                    }
                });

            }
            else
            {
                Timer.Register(windowBase.Duration, () =>
                {
                    windowBase.InActive();
                    windowBase.gameObject.SetActive(false);
                });
            }
         
        }

        scaleContent.DOScale(scaleVal, windowBase.Duration);
    }

   /// <summary>
   /// 中间变大
   /// </summary>
   /// <param name="windowBase"></param>
   /// <param name="isOpen"></param>
    private void ShowCenterToBig(UIBase windowBase,bool isOpen)
    {
        windowBase.gameObject.SetActive(true);
     
        Transform scaleContent = windowBase.transform;
        bool special = false;
        if (windowBase is UIOpenWindowsBase)
        {
            scaleContent = windowBase.transform.Find(GameTags.ScaleContent);
            special = true;
        }

        if (!special)
        {
            //如果是特殊UI 则改变其背景色透明度
            if (windowBase is UIOpenWindowsBase)
            {
                UIOpenWindowsBase openUI = (UIOpenWindowsBase)windowBase;
                Color color = openUI.BackgroundImg.color;
                if (color.a!=0)
                {
                    color.a = 0.8f;
                    openUI.BackgroundImg.DOColor(color, 1);
                }
               
            }

            windowBase.transform.localScale = Vector3.zero;
            if (!windowBase.EffectHaveSet)
            {
                windowBase.EffectHaveSet = true;
               
                scaleContent.DOScale(Vector3.one, windowBase.Duration)
                    .SetAutoKill(false)
                    .SetEase(GlobalInit.Instance.UIAnimationCurve)
                    .OnRewind(() => {

                        if (windowBase.GetType() == typeof(UIWindowBase))
                        {

                            DestoryWindow((UIWindowBase)windowBase);
                        }
                        else
                        {
                            windowBase.InActive();
                            windowBase.gameObject.SetActive(false);
                        }
                    });
                
            }

            if (isOpen)
            {
                scaleContent.DOPlayForward();
            }
            else
            {
                scaleContent.DOPlayBackwards();
            }
        }
        else
        {
            ShowCentToBigSpecial(scaleContent, windowBase, isOpen);
            //UIOpenWindowsBase openUI = (UIOpenWindowsBase)windowBase;
            //Color color = openUI.BackgroundImg.color;
            //color.a = 0f;
            //openUI.BackgroundImg.DOColor(color, 1).OnComplete(()=> {

            //    scaleContent.transform.localScale = Vector3.one;
            //    windowBase.transform.localScale = Vector3.zero;
            //    windowBase.EffectHaveSet = false;

            //    if (windowBase.GetType() == typeof(UIWindowBase))
            //    {
            //        DestoryWindow((UIWindowBase)windowBase);
            //    }
            //    else
            //    {
            //        windowBase.InActive();
            //        windowBase.gameObject.SetActive(false);
            //    }
            //});

            //windowBase.EffectHaveSet = true;
            //scaleContent.DOScale(Vector3.zero, windowBase.Duration);
        }

    }

    /// <summary>
    /// 从不同的方向加载
    /// </summary>
    /// <param name="windowBase"></param>
    /// <param name="dirType">0=从上 1=从下 2=从左 3=从右</param>
    /// <param name="isOpen"></param>
    private void ShowFromDir(UIBase windowBase, int dirType, bool isOpen,Vector3 toPos)
    {
        windowBase.gameObject.SetActive(true);
        Vector3 from = windowBase.transform.localPosition;
        switch (dirType)
        {
            case 0:
                from = new Vector3(from.x, 1000, 0);
                break;
            case 1:
                from = new Vector3(from.x, -1000, 0);
                break;
            case 2:
                from = new Vector3(-1400, from.y, 0);
                break;
            case 3:
                from = new Vector3(1400, from.y, 0);
                break;
        }

        windowBase.transform.localPosition = from;

        if (!windowBase.EffectHaveSet)
        {
            windowBase.EffectHaveSet = true;
            windowBase.transform.DOLocalMove(toPos, windowBase.Duration)
            .SetAutoKill(false)
            .SetEase(GlobalInit.Instance.UIAnimationCurve)
            .Pause().OnRewind(() =>
            {
                if (windowBase.GetType() == typeof(UIWindowBase))
                {
                    DestoryWindow((UIWindowBase)windowBase);
                }
                else
                {
                    windowBase.gameObject.SetActive(false);
                }

            });
        }
            
        if (isOpen)
            windowBase.transform.DOPlayForward();
        else
            windowBase.transform.DOPlayBackwards();
    }

    #endregion

    #region 销毁窗口

    private void DestoryWindow(UIWindowBase windowBase)
    {
        m_DicWindow.Remove(windowBase.CurrentUIType);
        UnityEngine.Object.Destroy(windowBase.gameObject);
    }

    public void ClearAllDic()
    {
        m_DicSubView.Clear();
        m_DicWindow.Clear();
    }

    #endregion
}
