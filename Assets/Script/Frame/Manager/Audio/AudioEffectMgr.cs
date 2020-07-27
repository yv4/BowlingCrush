using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffectMgr : SingletonMono<AudioEffectMgr>
{

    #region 成员

    public static float Volume = 1f;

    /// <summary>
    /// 声音播放器缓存列表
    /// </summary>
    private List<AudioInfo> m_AudioList = new List<AudioInfo>();
    public bool ShockEnable = true;
    public bool AudioEnable = true;

    #endregion

    #region 生命周期

    #endregion

    #region 初始化与销毁

    void GetMemberReference()
    {

    }

    void OnInit()
    {

    }

    void DestroySelf()
    {

    }

    #endregion

    #region 成员方法

    /// <summary>
    /// 调用手机震动
    /// </summary>
    public void PlayShock()
    {
        if (!ShockEnable)
        {
            return;
        }

        //Handheld.Vibrate();
    }

    /// <summary>
    /// 设置是否播放音乐
    /// </summary>
    /// <param name="enable"></param>
    public void SetPlayAudio(bool enable)
    {
        AudioEnable = enable;
    }

    /// <summary>
    /// 在指定的位置，播放指定名称的声音
    /// </summary>
    /// <param name="audioPath"></param>
    /// <param name="pos"></param>
    /// <param name="is3D"></param>
    public void Play(string audioPath, Vector3 pos, bool is3D = false)
    {
        if (!AudioEnable)
        {
            return;
        }

        //AssetBundleMgr.Instance.LoadFromAssetBundle(bundleName, fileName);

        AudioClip audioClip = ResourcesMgr.Instance.Load<AudioClip>(audioPath);

        if (audioClip == null)
        {
            return;
        }

        //在列表中寻找一个适合的播放器
        AudioInfo info = FindSameAudio(audioClip.name);
        if (info != null)
        {
            //设置要播放的音效
            info.AudioName = audioClip.name;
            info.CurrentAudioSource.clip = audioClip;

            //开始播放
            info.Play(pos, is3D);
        }
        else
        {
            //移除多余的播放器
            RemoveOverSound();

            //新建播放器
            info = new AudioInfo(audioClip, gameObject);

            //添加到列表
            m_AudioList.Add(info);

            //开始播放
            info.Play(pos, is3D);



        }
    }

   

    /// <summary>
    /// 查找是指定名称的声音，是否在列表中存在，并且可用于播放新声音
    /// </summary>
    /// <param name="audioName"></param>
    /// <returns></returns>

    /// 规则：
    ///    1：如果列表中有同名已经播放完毕的声音，则直接将其返回。
    ///    2：如果有两个或更多个同名的，但是正在播放的声音，则把其中结束时刻最早的那个直接返回（这样就会把结束期最早的那个提前停止，改为播放新声音了）
    ///       之所以判断两个，是为了增加真实感，仅判断1个会看到有点假。如果太多则会太浪费cpu和内存
    ///    3：如果以上两个条件都不满足，则直接返回null
    private AudioInfo FindSameAudio(string audioName)
    {
        //如果列表中已经播放完了，则将其直接返回
        foreach (AudioInfo infoItem in m_AudioList)
        {
            if (Time.time > infoItem.PlayEndTime)
            {
                return infoItem;
            }
        }

        //判断是否存在没有播放完毕的同名的声音
        List<AudioInfo> infoArray = new List<AudioInfo>();
        foreach (AudioInfo infoItem in m_AudioList)
        {
            if (infoItem.AudioName.Equals(audioName))
            {
                infoArray.Add(infoItem);
            }
        }

        //如果只有一个正在播放的同名声音，或者一个也没有则直接返回
        if (infoArray.Count <= 1)
        {
            infoArray = null;
            return null;
        }

        //程序执行到这里，就表示至少已经存在2个同名的、正在播放的声音。则把结束时刻最早的那个作为返回值返回(这样我们就实现了停止最早的那个声音，让其改为播放新声音了)
        AudioInfo info = infoArray[0];
        for (int i = 1; i < infoArray.Count; i++)
        {
            if (info.PlayEndTime > infoArray[i].PlayEndTime)
            {
                info = infoArray[i];
            }
        }
        infoArray = null;
        return info;

    }

    private void RemoveOverSound()
    {
        //如果列表中的个数超过8个，则先把已经播放完毕的，全部移除
        if (m_AudioList.Count >= 8)
        {
            //倒序遍历
            for (int i = m_AudioList.Count - 1; i >= 0; i--)
            {
                //如果播放完了Destroy掉
                if (Time.time > m_AudioList[i].PlayEndTime)
                {
                    AudioInfo item = m_AudioList[i];
                    m_AudioList.Remove(item);
                    item.Destroy();
                }
            }
        }

        //如果列表中的个数仍然超过8个，则把最早结束的移除，直到少于8个
        while (m_AudioList.Count >= 8)
        {
            AudioInfo item = m_AudioList[0];
            foreach (AudioInfo info2 in m_AudioList)
            {
                if (item.PlayEndTime > info2.PlayEndTime)
                {
                    item = info2;
                }
            }
            m_AudioList.Remove(item);
            item.Destroy();
        }
    }

#endregion

    #region 委托方法

#endregion

    #region 内部类

    /// <summary>
    /// 声音播放器
    /// </summary>
    public class AudioInfo
    {
        /// <summary>
        /// 音频播放器
        /// </summary>
        public AudioSource CurrentAudioSource;

        /// <summary>
        /// 播放音频名称
        /// </summary>
        public string AudioName;

        /// <summary>
        /// 播放结束时间
        /// </summary>
        public float PlayEndTime = 0;

        /// <summary>
        /// 是否3D音效
        /// </summary>
        public bool Is3D;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="audioClip"></param>
        /// <param name="root"></param>
        public AudioInfo(AudioClip audioClip, GameObject root = null)
        {
            AudioName = audioClip.name;

            //新建GameObject
            GameObject obj = new GameObject("Audio_" + AudioName);
            if (root != null)
            {
                obj.transform.parent = root.transform;
            }

            //跨场景不释放
            Object.DontDestroyOnLoad(obj);

            //新建GameObject上挂载组件
            CurrentAudioSource = obj.AddComponent<AudioSource>();
            CurrentAudioSource.loop = false;
            CurrentAudioSource.volume = AudioEffectMgr.Volume;
            //按距离衰减模式---起始衰减距离（当AudioSource到AudioListener之间的距离，大于这个数值时才开始音量衰减）
            CurrentAudioSource.minDistance = 30;
            //按距离衰减模式---结束衰减距离（当AudioSource到AudioListener之间的距离，小于这个数值时则声音再也听不到了
            CurrentAudioSource.maxDistance = 200;
            CurrentAudioSource.clip = audioClip;
            CurrentAudioSource.panStereo = 0;

        }

        /// <summary>
        /// 销毁方法 外部手动调用
        /// </summary>
        public void Destroy()
        {
            //停止播放音效
            Stop();

            Object.Destroy(this.CurrentAudioSource.gameObject);
        }

        /// <summary>
        /// 在指定的坐标点处，播放音效
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="is3D"></param>
        public void Play(Vector3 pos, bool is3D = false)
        {
            //记录下播放结束时刻
            PlayEndTime = Time.time + this.CurrentAudioSource.clip.length;

            //将特效音源移动到相关位置
            CurrentAudioSource.gameObject.transform.position = pos;
            CurrentAudioSource.Stop();

            //开始播放
            CurrentAudioSource.spatialBlend = is3D ? 1 : 0;
            CurrentAudioSource.Play();
        }

        /// <summary>
        /// 停止播放
        /// </summary>
        public void Stop()
        {
            //停止播放时间
            CurrentAudioSource.Stop();
            //结束时间设为0
            PlayEndTime = 0f;

        }

    }

#endregion
}
