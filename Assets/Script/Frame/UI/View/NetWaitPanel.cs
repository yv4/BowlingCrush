using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TimerDelay;
using UnityEngine;
using UnityEngine.UI;

public class NetWaitPanel : Singleton<NetWaitPanel>
{

    private CanvasGroup m_NetWaitPanel;
    private Text m_Message;
    private Tween m_FontTween;
    private bool m_ReceiveCallBack;//是否接到回调
    private float m_WaitTimeThreshold = 15;//回调等待阀值
    private float m_WaitTimer;//回调等待计时器


    #region 成员方法

    /// <summary>
    /// 显示等待
    /// </summary>
    /// <param name="message"></param>
    /// <param name="parent"></param>
    /// <param name="pos"></param>
    /// <param name="refresh"></param>
    public void ShowMessage(string message, Transform parent, Vector2 pos, bool refresh = false)
    {
        if (m_NetWaitPanel == null || refresh)
        {
            //GameObject obj = ResourcesMgr.Instance.LoadFromAssetBundle(GameTags.NetWaiPanel, true, true);
            GameObject obj = ResourcesMgr.Instance.Load(GameTags.MessageWindow, true, true);
            m_NetWaitPanel = obj.GetComponent<CanvasGroup>();
            m_Message = BaseOption.FindChild<Text>(obj, "Text");

        }

        m_NetWaitPanel.transform.parent = parent;
        m_NetWaitPanel.transform.localPosition = pos;
        m_NetWaitPanel.transform.SetAsLastSibling();
        m_NetWaitPanel.gameObject.SetActive(true);
        m_NetWaitPanel.gameObject.transform.SetAsLastSibling();
        m_Message.text = "";
        m_ReceiveCallBack = false;

        Timer.Register(m_WaitTimeThreshold, () => {
            if (!m_ReceiveCallBack)
            {
                EventObserverMgr<int>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.ExceedNetTime);
                HideMessage();
            }
        });

        #region DotTween

        m_FontTween = m_Message.DOText(message, 3.0f).SetLoops(-1, LoopType.Restart);

        #endregion
    }

    /// <summary>
    /// 隐藏等待
    /// </summary>
    public void HideMessage()
    {
        m_ReceiveCallBack = true;
        m_FontTween.Kill();
        m_NetWaitPanel.gameObject.SetActive(false);
    }

    #endregion

}
