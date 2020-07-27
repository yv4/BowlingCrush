using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISettingWindow : UIOpenWindowsBase
{

    #region 成员变量

    private Image m_SoundIcon;
    private Image m_SoundStateImg;

    private Image m_ShockIcon;
    private Image m_ShockStateImg;

    private Button m_SoundSwitchBut;
    private Button m_ShockSwitchBut;

    private Sprite m_EnableSprite;
    private Sprite m_UnEnableSprite;
    private Sprite m_SoundEnableSprite;
    private Sprite m_SoundDisableSprite;
    private Sprite m_ShockEnableSprite;
    private Sprite m_ShockDisableSprite;

    private bool m_SoundOpen = true;
    private bool m_ShockOpen = true;

    #endregion

    #region 生命周期

    protected override void GetMemberReference()
    {
        base.GetMemberReference();
        this.WindowName = GameTags.UISettingWindow;

        m_SoundIcon = BaseOption.FindChild<Image>(this.gameObject, "SoundIcon");
        m_ShockIcon = BaseOption.FindChild<Image>(this.gameObject, "ShockIcon");

        m_SoundStateImg = BaseOption.FindChild<Image>(this.gameObject, "SoundBut");
        m_ShockStateImg = BaseOption.FindChild<Image>(this.gameObject, "ShockBut");

        m_SoundSwitchBut = BaseOption.FindChild<Button>(this.gameObject, "SoundBut");
        m_SoundSwitchBut.onClick.AddListener(() => { SoundButClickMethod(); });
        m_ShockSwitchBut = BaseOption.FindChild<Button>(this.gameObject, "ShockBut");
        m_ShockSwitchBut.onClick.AddListener(() => { ShockButClickMethod(); });

    }

    protected override void OnInit()
    {
        int num = PlayerPrefs.GetInt("SoundEnable");
        int num2 = PlayerPrefs.GetInt("ShockEnable");
      
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

    protected override void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 设置音乐开启关闭
    /// </summary>
    /// <param name="enable"></param>
    private void SetAudioEnable(bool enable)
    {
        if (enable)
        {
            m_SoundStateImg.sprite = m_EnableSprite;
            m_SoundIcon.sprite = m_SoundEnableSprite;
        }
        else
        {
            m_SoundStateImg.sprite = m_UnEnableSprite;
            m_SoundIcon.sprite = m_SoundDisableSprite;
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
            m_ShockStateImg.sprite = m_EnableSprite;
            m_ShockIcon.sprite = m_ShockEnableSprite;
        }
        else
        {
            m_ShockStateImg.sprite = m_UnEnableSprite;
            m_ShockIcon.sprite = m_ShockDisableSprite;
        }
    }

    #endregion

    #region 委托方法

    /// <summary>
    /// 声音点击委托
    /// </summary>
    private void SoundButClickMethod()
    {
        m_SoundOpen = !m_SoundOpen;

        if (m_SoundOpen)
        {
            m_SoundStateImg.sprite = m_EnableSprite;
            m_SoundIcon.sprite = m_SoundEnableSprite;
        }
        else
        {
            m_SoundStateImg.sprite = m_UnEnableSprite;
            m_SoundIcon.sprite = m_SoundDisableSprite;
        }

    }

    /// <summary>
    /// 震动点击委托
    /// </summary>
    private void ShockButClickMethod()
    {
        m_ShockOpen = !m_ShockOpen;

        if (m_ShockOpen)
        {
            m_ShockStateImg.sprite = m_EnableSprite;
            m_ShockIcon.sprite = m_ShockEnableSprite;
        }
        else
        {
            m_ShockStateImg.sprite = m_UnEnableSprite;
            m_ShockIcon.sprite = m_ShockDisableSprite;
        }

    }

    #endregion

}
