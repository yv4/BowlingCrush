using DG.Tweening;
using MobiiGame.Sdk.Gift;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadBar : UIBase
{

    #region 成员变量

    private bool m_SettingOpen;
    private bool m_SoundOpen = true;
    private bool m_ShockOpen = true;
    private Sprite m_EnableAudioSprite;
    private Sprite m_UnableAudioSprite;
    private Sprite m_EnableShakeSprite;
    private Sprite m_UnableShakeSprite;

    #region 按钮相关

    private Button m_SettingBut;
    private Button m_AudioBut;
    private Button m_ShakeBut;
    private Button m_DollarBut;

    #endregion

    #region 文本相关

    private Text m_CoinText;
    private Text m_DollerText;

    #endregion

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {

        #region 获取成员引用

        #region 按钮相关

        m_SettingBut = BaseOption.FindChild<Button>(this.gameObject, "Setting_But");
        m_AudioBut = BaseOption.FindChild<Button>(this.gameObject, "Audio_But");
        m_ShakeBut = BaseOption.FindChild<Button>(this.gameObject, "Shake_But");
        m_DollarBut = BaseOption.FindChild<Button>(this.gameObject, "DollerLabel");

        #endregion

        #region 文本相关

        m_CoinText = BaseOption.FindChild<Text>(this.gameObject, "Coin_Text");
        m_DollerText = BaseOption.FindChild<Text>(this.gameObject, "Doller_Text");

        #endregion

        m_EnableAudioSprite = ResourcesMgr.Instance.LoadSprite(GameTags.AudioEnableSprite);
        m_UnableAudioSprite = ResourcesMgr.Instance.LoadSprite(GameTags.AudioUnEnableSprite);
        m_EnableShakeSprite = ResourcesMgr.Instance.LoadSprite(GameTags.ShakeEnableSprite);
        m_UnableShakeSprite = ResourcesMgr.Instance.LoadSprite(GameTags.ShakeUnEnableSprite);

        #endregion

        #region 添加成员委托方法监听

        #region 按钮相关

        BaseOption.AddButClickMethod(m_SettingBut, SettingClickMethod);
        BaseOption.AddButClickMethod(m_AudioBut, AudioClickMethod);
        BaseOption.AddButClickMethod(m_ShakeBut, ShakeClickMethod);
        BaseOption.AddButClickMethod(m_DollarBut, DollarButClickMethod);

        #endregion

        #endregion

    }


    protected override void OnInit()
    {
        InitSettingOption();
    }

    private void Update()
    {
    }

    protected override void DestroySelf()
    {
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 设置数据
    /// </summary>
    /// <param name="data"></param>
    public void SetData(UserResourceEntity data)
    {
        m_CoinText.text = data.CoinCount.ToString();
        m_DollerText.text = data.DollorCount.ToString();
    }

    /// <summary>
    /// 初始化设置操作
    /// </summary>
    private void InitSettingOption()
    {
        m_AudioBut.image.color = new Color(1, 1, 1, 0);
        m_ShakeBut.image.color = new Color(1, 1, 1, 0);
        m_AudioBut.transform.localScale = Vector3.zero;
        m_ShakeBut.transform.localScale = Vector3.zero;
        m_SettingOpen = false;
    }

    #endregion

    #region 委托方法

    #region 按钮相关

    /// <summary>
    /// 激励卡点击
    /// </summary>
    private void DollarButClickMethod()
    {
        GiftCardDialog.ShowCardDetailDialog();
    }

    /// <summary>
    /// 设置按钮点击
    /// </summary>
    private void SettingClickMethod()
    {
        m_SettingOpen = !m_SettingOpen;

        if (m_SettingOpen)
        {
            m_AudioBut.image.DOKill();
            m_ShakeBut.image.DOKill();
            m_AudioBut.transform.DOKill();
            m_ShakeBut.transform.DOKill();

            m_AudioBut.image.color = Color.white;
            m_ShakeBut.image.color = Color.white;
            m_AudioBut.transform.localScale = Vector3.zero;
            m_ShakeBut.transform.localScale = Vector3.zero;
            m_AudioBut.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBounce);
            m_ShakeBut.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBounce);
        }
        else
        {
            m_AudioBut.transform.DOScale(1.2f, 0.2f);
            m_ShakeBut.transform.DOScale(1.2f, 0.2f);
            m_AudioBut.image.DOFade(0, 0.2f).OnComplete(() =>
            {
                m_AudioBut.transform.localScale = Vector3.zero;
            });
            m_ShakeBut.image.DOFade(0, 0.2f).OnComplete(() =>
            {
                m_ShakeBut.transform.localScale = Vector3.zero;
            });
        }

    }

    /// <summary>
    /// 震动设置按钮
    /// </summary>
    private void ShakeClickMethod()
    {
        m_ShockOpen = !m_ShockOpen;

        if (m_ShockOpen)
        {
            m_ShakeBut.gameObject.GetComponent<Image>().sprite = m_EnableShakeSprite;
        }
        else
        {
            m_ShakeBut.gameObject.GetComponent<Image>().sprite = m_UnableShakeSprite;
        }

        EventObserverMgr<bool>.Instance.Dispatch(ObserverEventType.SceneActEvent, ObserverEventContent.CloseShock, m_ShockOpen);
    }

    /// <summary>
    /// 音效设置按钮
    /// </summary>
    private void AudioClickMethod()
    {
        m_SoundOpen = !m_SoundOpen;

        if (m_SoundOpen)
        {
            m_AudioBut.gameObject.GetComponent<Image>().sprite = m_EnableAudioSprite;
        }
        else
        {
            m_AudioBut.gameObject.GetComponent<Image>().sprite = m_UnableAudioSprite;
        }

        

        EventObserverMgr<bool>.Instance.Dispatch(ObserverEventType.PlayerCtrlEvent, ObserverEventContent.CloseAudio, m_SoundOpen);
    }

    private void InitSetSetting()
    {
        int num = PlayerPrefs.GetInt(GameTags.SoundEanble);
        int num2 = PlayerPrefs.GetInt(GameTags.ShockEnable);

        if (num > 0)
        {
            m_SoundOpen = true;
            SetAudioEnable(true);

        }
        else
        {
            m_SoundOpen = false;
            SetAudioEnable(false);
        }

        if (num2 > 0)
        {
            m_ShockOpen = true;
            SetShockEnable(true);
        }
        else
        {
            m_ShockOpen = false;
            SetShockEnable(false);
        }
    }

    /// <summary>
    /// 设置音乐开启关闭
    /// </summary>
    /// <param name="enable"></param>
    private void SetAudioEnable(bool enable)
    {
        if (enable)
        {
            //m_SoundStateImg.sprite = m_EnableSprite;
            //m_SoundIcon.sprite = m_SoundEnableSprite;
        }
        else
        {
            //m_SoundStateImg.sprite = m_UnEnableSprite;
            //m_SoundIcon.sprite = m_SoundDisableSprite;
        }
    }

    /// <summary>
    /// 设置震动开启关闭
    /// </summary>
    /// <param name="enable"></param>
    private void SetShockEnable(bool enable)
    {
        if (enable)
        {
            //m_ShockStateImg.sprite = m_EnableSprite;
            //m_ShockIcon.sprite = m_ShockEnableSprite;
        }
        else
        {
            //m_ShockStateImg.sprite = m_UnEnableSprite;
            //m_ShockIcon.sprite = m_ShockDisableSprite;
        }
    }


    #endregion

    #endregion

}