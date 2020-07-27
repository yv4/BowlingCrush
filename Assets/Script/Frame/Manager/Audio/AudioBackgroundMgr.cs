using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 背景音乐管理器（支持音乐的淡入淡出）
/// </summary>
[RequireComponent(typeof(AudioSource))]
public class AudioBackgroundMgr : SingletonMono<AudioBackgroundMgr> {

    #region 成员

    /// <summary>
    /// 音源
    /// </summary>
    private AudioSource m_AudioSource;

    /// <summary>
    /// AudioListener
    /// </summary>
    private AudioListener m_AudioListener;

    /// <summary>
    /// 上一个obfuscate的背景音乐
    /// </summary>
    private AudioClip m_PreAudioClip;

    /// <summary>
    /// 播放的背景音乐名称
    /// </summary>
    private string m_AudioName;

    /// <summary>
    /// 最大音量
    /// </summary>
    private float m_MaxValume = 0.6f;


    private bool m_Enable = true;

    
    #endregion

    #region 生命周期

    protected override void OnAwake()
    {
        base.OnAwake();
        GetMemberReference();
    }

    protected override void OnStart()
    {
        base.OnStart();
        OnInit();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
    }

    protected override void OnBeforeDestroy()
    {
        base.OnBeforeDestroy();
    }

    #endregion

    #region 初始化与销毁

    void GetMemberReference()
    {
        
        m_AudioListener = this.gameObject.AddComponent<AudioListener>();
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.volume = 0;

        //是否循环
        m_AudioSource.loop = true;

        //2D音乐
        m_AudioSource.spatialBlend = 0f;
    }

    void OnInit()
    {

    }

    void DestroySelf()
    {
        m_AudioSource = null;
        m_PreAudioClip = null;
        m_AudioListener = null;
    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 播放背景音乐
    /// </summary>
    /// <param name="name"></param>
    public void Play(string name)
    {
        m_AudioName = name;
        if (m_Enable)
        {
            StartCoroutine(DoPlay());
        }
    }

    /// <summary>
    /// 播放AssetBundle包中背景音也
    /// </summary>
    public void PlayAssetBundle(string audioPath)
    {
        m_AudioName = audioPath;
        StartCoroutine(DoPlayFromAssetBundle(audioPath));
    }

    private IEnumerator DoPlayFromAssetBundle(string audioPath)
    {

        //淡出需要时间
        float fadeOut = 0.1f;

        //淡入需要时间
        float fadeIn = 0.1f;

        //延迟时间
        float delay = 0;

        //获取播放的音效
        AudioClip audioClip = ResourcesMgr.Instance.LoadFromAssetBundle<AudioClip>(audioPath,true,false);

        //若当前音乐正在播放中，则什么都不做
        if (m_AudioSource.isPlaying && m_AudioSource.clip == audioClip)
        {
            yield return 0;
        }
        else
        {
            float time1 = Time.time;

            //开始播放
            //先检查是否有未完成的播放音乐
            if (m_PreAudioClip != null)
            {
                //把上一个音乐淡出
                yield return StartCoroutine(StartFadeOut(fadeOut));
            }

            //设置延迟 如果淡出时间过短则等待一会继续
            float time2 = Time.time - time1;
            if (delay > time2)
            {
                yield return new WaitForSeconds(delay - time2);
            }

            //播放音乐
            m_AudioSource.clip = audioClip;
            m_PreAudioClip = audioClip;
            m_AudioSource.Play();

            //声音淡入
            yield return StartCoroutine(StartFadeIn(fadeIn));
        }
    }

    //播放音乐，使用协程是为了实现等待和淡入淡出效果
    private IEnumerator DoPlay()
    {
        //淡出需要时间
        float fadeOut = 0.1f;

        //淡入需要时间
        float fadeIn = 0.1f;

        //延迟时间
        float delay = 0;

        //获取播放的音效
        AudioClip audioClip = ResourcesMgr.Instance.Load<AudioClip>(m_AudioName, true);

        //若当前音乐正在播放中，则什么都不做
        if (m_AudioSource.isPlaying&&m_AudioSource.clip==audioClip)
        {
            yield return 0;
        }
        else
        {
            float time1 = Time.time;

            //开始播放
            //先检查是否有未完成的播放音乐
            if (m_PreAudioClip!=null)
            {
                //把上一个音乐淡出
                yield return StartCoroutine(StartFadeOut(fadeOut));
            }

            //设置延迟 如果淡出时间过短则等待一会继续
            float time2 = Time.time - time1;
            if (delay>time2)
            {
                yield return new WaitForSeconds(delay - time2);
            }

            //播放音乐
            m_AudioSource.clip = audioClip;
            m_PreAudioClip = audioClip;
            m_AudioSource.Play();

            //声音淡入
            yield return StartCoroutine(StartFadeIn(fadeIn));
        }
    }

    /// <summary>
    /// 声音淡出协程
    /// </summary>
    /// <param name="fadeOutTime"></param>
    /// <returns></returns>
    IEnumerator StartFadeOut(float fadeOutTime)
    {
        float time = 0f;
        while (time <= fadeOutTime)
        {
            if (time!=0)
            {
                //lerp插值,0返回form,1返回to
                m_AudioSource.volume = Mathf.Lerp(m_MaxValume,0f, time / fadeOutTime);
            }

            time += Time.deltaTime;
                ;
            yield return 1;
        }
        m_AudioSource.volume = 0;
    }

    /// <summary>
    /// 声音淡入协程
    /// </summary>
    /// <param name="fadeInTime"></param>
    /// <returns></returns>
    IEnumerator StartFadeIn(float fadeInTime)
    {
        float time = 0f;
        while(time<=fadeInTime)
        {
            if (time!=0)
            {
                m_AudioSource.volume = Mathf.Lerp(0f, m_MaxValume, time / fadeInTime);
            }

            time += Time.deltaTime;
            yield return 1;
        }

        m_AudioSource.volume = m_MaxValume;
    }

    public void StopPlayAudio()
    {
        m_Enable = false;
        m_AudioSource.volume = 0;
    }

    public void ResumePlayAudio()
    {
        m_Enable = true;
        m_AudioSource.volume = m_MaxValume;
    }

    public void RestartPlayAudio()
    {
        if (m_AudioName!=null&&!m_AudioName.Equals(""))
        {
            m_AudioSource.Stop();
            Play(m_AudioName);
        }
    }

    #endregion

    #region 委托方法

    #endregion
}
