using UnityEngine;
public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    // Fields
    private string bgmFilePath;
    private UnityEngine.AudioSource bgmSource;
    private float uniqueBGMVolume;
    private System.Collections.Generic.List<SoundManager.PlayingAudio> seSourceList;
    private System.Collections.Generic.Dictionary<string, SoundManager.PlayingAudio> seLoopSourceDic;
    private System.Collections.Generic.List<SoundManager.PlayingAudio> voiceSourceList;
    public UnityEngine.Audio.AudioMixerGroup defaultBGMAudioMixer;
    public UnityEngine.Audio.AudioMixerGroup defaultSEAudioMixer;
    public UnityEngine.Audio.AudioMixerGroup defaultVoiceAudioMixer;
    public float bgmVolume;
    public float seVolume;
    public float voiceVolume;
    public float pauseTime;
    private bool enabledBGM;
    private bool enabledSE;
    private bool enabledVoice;
    private System.Collections.Generic.Dictionary<string, UnityEngine.AudioClip> audioClipDict;
    private bool isPause;
    private bool isPausing;
    
    // Properties
    public float UniqueBGMVolume { get; }
    
    // Methods
    public float get_UniqueBGMVolume()
    {
        return (float)this.uniqueBGMVolume;
    }
    public float GetVolume(SoundType soundType)
    {
        float val_2;
        if(soundType != 2)
        {
                var val_1 = (soundType != 0) ? this.seVolume : this.bgmVolume;
            return val_2;
        }
        
        val_2 = this.voiceVolume;
        return val_2;
    }
    public void EnabledSound(SoundType soundType, bool enabled)
    {
        if(soundType == 0)
        {
            goto label_0;
        }
        
        bool val_1 = enabled;
        if(soundType != 2)
        {
            goto label_1;
        }
        
        this.enabledVoice = val_1;
        return;
        label_0:
        this.enabledBGM = enabled;
        return;
        label_1:
        this.enabledSE = val_1;
    }
    public bool IsEnabled(SoundType soundType)
    {
        bool val_2;
        if(soundType != 2)
        {
                var val_1 = (soundType != 0) ? this.enabledSE : this.enabledBGM;
            return val_2;
        }
        
        val_2 = this.enabledVoice;
        return val_2;
    }
    private void Awake()
    {
        if(this.CheckInstance() == true)
        {
                return;
        }
        
        this.enabledBGM = UsayaStorageManager.LoadOrDefault<System.Boolean>(filename:  1, tag:  "EnabledBGM", defaultValue:  true);
        this.enabledSE = UsayaStorageManager.LoadOrDefault<System.Boolean>(filename:  1, tag:  "EnabledSE", defaultValue:  true);
        this.enabledVoice = UsayaStorageManager.LoadOrDefault<System.Boolean>(filename:  1, tag:  "EnabledVoice", defaultValue:  true);
        this.bgmVolume = UsayaStorageManager.LoadOrDefault<System.Single>(filename:  1, tag:  "VolumeBGM", defaultValue:  this.bgmVolume);
        this.seVolume = UsayaStorageManager.LoadOrDefault<System.Single>(filename:  1, tag:  "VolumeSE", defaultValue:  this.seVolume);
        this.voiceVolume = UsayaStorageManager.LoadOrDefault<System.Single>(filename:  1, tag:  "VolumeVoice", defaultValue:  this.voiceVolume);
    }
    public void SaveEnabledBGM(bool enabled)
    {
        bool val_1 = enabled;
        UsayaStorageManager.Save<System.Boolean>(filename:  1, tag:  "EnabledBGM", value:  val_1);
        this.enabledBGM = val_1;
        if(this.bgmSource == 0)
        {
                return;
        }
        
        this.bgmSource.mute = (this.enabledBGM == false) ? 1 : 0;
    }
    public void SaveEnabledSE(bool enabled)
    {
        bool val_1 = enabled;
        UsayaStorageManager.Save<System.Boolean>(filename:  1, tag:  "EnabledSE", value:  val_1);
        this.enabledSE = val_1;
        this.seSourceList.ForEach(action:  new System.Action<PlayingAudio>(object:  this, method:  System.Void SoundManager::<SaveEnabledSE>b__23_0(SoundManager.PlayingAudio se)));
    }
    public void SaveVolumeBGM()
    {
        this.SaveVolumeBGM(volume:  this.bgmVolume);
    }
    public void SaveVolumeBGM(float volume)
    {
        UsayaStorageManager.Save<System.Single>(filename:  1, tag:  "VolumeBGM", value:  volume);
        this.ChangeVolumeBGM(volume:  volume);
    }
    public void ChangeVolumeBGM(float volume)
    {
        float val_5;
        this.bgmVolume = volume;
        if(this.bgmSource == 0)
        {
                return;
        }
        
        volume = this.uniqueBGMVolume * volume;
        this.bgmSource.volume = volume;
        if(this.bgmSource != null)
        {
                val_5 = this.bgmSource.volume;
        }
        else
        {
                val_5 = 0.volume;
        }
        
        this.bgmSource.mute = (val_5 <= 0f) ? 1 : 0;
    }
    public void ChangeVolumeUniqueBGM(float volume)
    {
        this.uniqueBGMVolume = volume;
        if(this.bgmSource == 0)
        {
                return;
        }
        
        this.bgmSource.volume = this.uniqueBGMVolume * this.bgmVolume;
    }
    public void SaveVolumeSE()
    {
        this.SaveVolumeSE(volume:  this.seVolume);
    }
    public void SaveVolumeSE(float volume)
    {
        UsayaStorageManager.Save<System.Single>(filename:  1, tag:  "VolumeSE", value:  volume);
        this.ChangeVolumeSE(volume:  volume);
    }
    public void ChangeVolumeSE(float volume)
    {
        object val_5;
        float val_6;
        SoundManager.<>c__DisplayClass30_0 val_1 = null;
        val_5 = val_1;
        val_1 = new SoundManager.<>c__DisplayClass30_0();
        if(val_5 != null)
        {
                val_6 = val_5;
            .volume = volume;
        }
        else
        {
                val_6 = 2.242078E-44f;
            mem[16] = volume;
        }
        
        this.seVolume = val_6;
        this.seSourceList.ForEach(action:  new System.Action<PlayingAudio>(object:  val_1, method:  System.Void SoundManager.<>c__DisplayClass30_0::<ChangeVolumeSE>b__0(SoundManager.PlayingAudio se)));
        Dictionary.Enumerator<TKey, TValue> val_3 = this.seLoopSourceDic.GetEnumerator();
        label_8:
        if(((-1152501624) & 1) == 0)
        {
            goto label_5;
        }
        
        System.Collections.Generic.KeyValuePair<TKey, TValue> val_4 = 0.Current;
        val_4.Value.ChangeVolume(volume:  mem[16]);
        goto label_8;
        label_5:
        UniRx.Unit..cctor();
    }
    public void SaveVolumeVoice()
    {
        this.SaveVolumeVoice(volume:  this.voiceVolume);
    }
    public void SaveVolumeVoice(float volume)
    {
        UsayaStorageManager.Save<System.Single>(filename:  1, tag:  "VolumeVoice", value:  volume);
        this.ChangeVolumeVoice(volume:  volume);
    }
    public void ChangeVolumeVoice(float volume)
    {
        float val_3;
        SoundManager.<>c__DisplayClass33_0 val_1 = new SoundManager.<>c__DisplayClass33_0();
        if(val_1 != null)
        {
                val_3 = val_1;
            .volume = volume;
        }
        else
        {
                val_3 = 2.242078E-44f;
            mem[16] = volume;
        }
        
        this.voiceVolume = val_3;
        this.voiceSourceList.ForEach(action:  new System.Action<PlayingAudio>(object:  val_1, method:  System.Void SoundManager.<>c__DisplayClass33_0::<ChangeVolumeVoice>b__0(SoundManager.PlayingAudio voice)));
    }
    public void ChangeVolume(SoundType soundType, float volume)
    {
        if(soundType == 2)
        {
            goto label_0;
        }
        
        if(soundType != 0)
        {
            goto label_1;
        }
        
        this.ChangeVolumeBGM(volume:  volume);
        return;
        label_0:
        this.ChangeVolumeVoice(volume:  volume);
        return;
        label_1:
        this.ChangeVolumeSE(volume:  volume);
    }
    private void LateUpdate()
    {
        var val_9;
        System.Collections.Generic.List<PlayingAudio> val_10;
        System.Collections.Generic.List<PlayingAudio> val_9 = this.seSourceList;
        val_9 = val_9.Count - 1;
        if((val_9 & 2147483648) == 0)
        {
                val_9 = 1152921512044883360;
            do
        {
            val_10 = this.seSourceList.Item[val_9];
            if(val_10.IsPlaying() != true)
        {
                this.seSourceList.Item[val_9].PlayCallBack();
            val_10 = this.seSourceList;
            val_10.RemoveAt(index:  val_9);
        }
        
            val_9 = val_9 - 1;
        }
        while((val_9 & 2147483648) == 0);
        
        }
        
        System.Collections.Generic.List<PlayingAudio> val_10 = this.voiceSourceList;
        val_10 = val_10.Count - 1;
        if((val_10 & 2147483648) != 0)
        {
                return;
        }
        
        val_9 = 1152921512044884384;
        do
        {
            val_10 = this.voiceSourceList.Item[val_10];
            if(val_10.IsPlaying() != true)
        {
                this.voiceSourceList.Item[val_10].PlayCallBack();
            val_10 = this.voiceSourceList;
            val_10.RemoveAt(index:  val_10);
        }
        
            val_10 = val_10 - 1;
        }
        while((val_10 & 2147483648) == 0);
    
    }
    public void PauseBGM()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bgmSource)) == false)
        {
                return;
        }
        
        this.bgmSource.Pause();
    }
    public void UnPauseBGM()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bgmSource)) == false)
        {
                return;
        }
        
        this.bgmSource.UnPause();
    }
    public void PauseTimeBGM()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bgmSource)) == false)
        {
                return;
        }
        
        this.pauseTime = this.bgmSource.time;
        this.bgmSource.Pause();
    }
    public void UnPauseTimeBGM()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bgmSource)) == false)
        {
                return;
        }
        
        this.bgmSource.UnPause();
        this.bgmSource.time = this.pauseTime;
    }
    public void ReplayBGM()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bgmSource)) == false)
        {
                return;
        }
        
        this.bgmSource.Stop();
        this.bgmSource.Play();
    }
    public void StopBGM()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bgmSource)) == false)
        {
                return;
        }
        
        this.bgmFilePath = "";
        this.bgmSource.Stop();
        this.bgmSource.clip = 0;
    }
    public void StopSE()
    {
        List.Enumerator<T> val_1 = this.seSourceList.GetEnumerator();
        label_4:
        if(((-1150857544) & 1) == 0)
        {
            goto label_2;
        }
        
        0.Id.Stop();
        goto label_4;
        label_2:
        UniRx.Unit..cctor();
        this.seSourceList.Clear();
    }
    public void StopSELoop()
    {
        Dictionary.Enumerator<TKey, TValue> val_1 = this.seLoopSourceDic.GetEnumerator();
        label_4:
        if(((-1150724072) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Collections.Generic.KeyValuePair<TKey, TValue> val_2 = 0.Current;
        val_2.Value.StopDestroy();
        goto label_4;
        label_2:
        UniRx.Unit..cctor();
        this.seLoopSourceDic.Clear();
    }
    public void StopSELoop(string filePath)
    {
        if((this.seLoopSourceDic.ContainsKey(key:  filePath)) == false)
        {
                return;
        }
        
        this.seLoopSourceDic.Item[filePath].StopDestroy();
        bool val_3 = this.seLoopSourceDic.Remove(key:  filePath);
    }
    public void StopVoice()
    {
        List.Enumerator<T> val_1 = this.voiceSourceList.GetEnumerator();
        label_4:
        if(((-1150435528) & 1) == 0)
        {
            goto label_2;
        }
        
        0.Id.Stop();
        goto label_4;
        label_2:
        UniRx.Unit..cctor();
        this.voiceSourceList.Clear();
    }
    public void StopAll()
    {
        this.StopBGM();
        this.StopSE();
        this.StopSELoop();
        this.StopVoice();
    }
    public void StopAllFade(float interval)
    {
        this.FadeOut(duration:  interval, callback:  new System.Action(object:  this, method:  public System.Void SoundManager::StopAll()));
    }
    public void ChangeFadeBGM(string filePath, float interval, float volume = 1, bool loop = True)
    {
        SoundManager.<>c__DisplayClass48_0 val_1 = new SoundManager.<>c__DisplayClass48_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .volume = volume;
        mem[1152921512046773232] = this;
        mem[1152921512046773240] = filePath;
        mem[1152921512046773252] = interval;
        if(this.bgmFilePath != null)
        {
            goto label_7;
        }
        
        label_8:
        label_7:
        if((this.bgmFilePath.Contains(value:  filePath)) != false)
        {
                return;
        }
        
        if(this.bgmFilePath.Length < 1)
        {
            goto label_6;
        }
        
        float val_6 = 0.5f;
        val_6 = ((SoundManager.<>c__DisplayClass48_0)[1152921512046773216].interval) * val_6;
        this.FadeOut(duration:  val_6, callback:  new System.Action(object:  val_1, method:  System.Void SoundManager.<>c__DisplayClass48_0::<ChangeFadeBGM>b__0()));
        return;
        label_1:
        mem[16] = this;
        mem[24] = filePath;
        mem[32] = volume;
        .interval = interval;
        if(this.bgmFilePath != null)
        {
            goto label_7;
        }
        
        goto label_8;
        label_6:
        this.PlayBGM(filePath:  mem[1152921512046773240], volume:  .volume, loop:  loop);
    }
    public void PlayBGM(string filePath, float volume = 1, bool loop = True)
    {
        if((this.bgmFilePath.Contains(value:  filePath)) != false)
        {
                return;
        }
        
        this.bgmFilePath = filePath;
        this.PlayBGM(clip:  this.LoadAudioClip(filePath:  filePath, soundType:  0), volume:  volume, loop:  loop);
    }
    public void PlayBGM(UnityEngine.AudioClip clip, float volume = 1, bool loop = True)
    {
        UnityEngine.AudioSource val_9;
        if(this.bgmSource != 0)
        {
            goto label_3;
        }
        
        val_9 = this.gameObject.AddComponent<UnityEngine.AudioSource>();
        this.bgmSource = val_9;
        if(val_9 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_3:
        val_9 = this.bgmSource;
        if(val_9 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        if(val_9.clip == clip)
        {
                return;
        }
        
        this.uniqueBGMVolume = volume;
        this.pauseTime = 0f;
        this.bgmSource.time = 0f;
        this.bgmSource.Stop();
        this.bgmSource.clip = clip;
        this.bgmSource.loop = loop;
        this.bgmSource.volume = this.uniqueBGMVolume * this.bgmVolume;
        this.bgmSource.mute = (this.enabledBGM == false) ? 1 : 0;
        this.bgmSource.Play();
        this.bgmSource.outputAudioMixerGroup = this.defaultBGMAudioMixer;
    }
    public void PlaySE(string filePath, int maxCount = 0, float volume = 1, float pitch = 1)
    {
        this.PlaySE(clip:  this.LoadAudioClip(filePath:  filePath, soundType:  1), maxCount:  maxCount, volume:  volume, pitch:  pitch);
    }
    public void PlaySE(UnityEngine.AudioClip clip, int maxCount = 0, float volume = 1, float pitch = 1)
    {
        var val_2;
        if(clip == 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        this.PlaySE(clip:  clip, callBack:  ActionExtensions.EmptyAction, maxCount:  maxCount, volume:  volume, pitch:  pitch);
    }
    public void PlaySE(string filePath, System.Action callBack, int maxCount = 0, float volume = 1)
    {
        this.PlaySE(clip:  this.LoadAudioClip(filePath:  filePath, soundType:  1), callBack:  callBack, maxCount:  maxCount, volume:  volume, pitch:  1f);
    }
    public void PlaySE(UnityEngine.AudioClip clip, System.Action callBack, int maxCount = 0, float volume = 1, float pitch = 1)
    {
        if(clip == 0)
        {
                return;
        }
        
        if(this.isPausing != false)
        {
                return;
        }
        
        this.PlaySE(clip:  clip, maxCount:  maxCount, volume:  volume, pitch:  pitch, callBack:  callBack, list:  this.seSourceList);
    }
    private void PlaySE(UnityEngine.AudioClip clip, int maxCount, float volume, float pitch, System.Action callBack, System.Collections.Generic.List<SoundManager.PlayingAudio> list)
    {
        string val_1 = clip.name;
        if((val_1.FindCountOverPlayingAudio(clipName:  val_1, maxCount:  maxCount, list:  list)) != null)
        {
                val_2.audioSource.Stop();
            val_2.audioSource.Play();
            return;
        }
        
        float val_6 = this.seVolume;
        val_6 = val_6 * volume;
        .name = val_1;
        .audioSource = this.CreateAudioSource(clip:  clip, volume:  val_6, pitch:  pitch, mute:  (this.enabledSE == false) ? 1 : 0, audioMixerGroup:  list);
        .uniqueVolume = volume;
        .callBack = callBack;
        list.Add(item:  new SoundManager.PlayingAudio());
    }
    public UnityEngine.AudioSource PlaySELoop(string filePath, float volume = 1, float pitch = 1)
    {
        string val_8;
        System.Collections.Generic.Dictionary<System.String, PlayingAudio> val_9;
        UnityEngine.AudioSource val_10;
        var val_11;
        val_8 = filePath;
        val_9 = this;
        if((this.seLoopSourceDic.ContainsKey(key:  val_8)) != false)
        {
                val_8 = this.seLoopSourceDic.Item[val_8];
            val_10 = val_2.audioSource;
            return val_10;
        }
        
        UnityEngine.AudioClip val_3 = this.LoadAudioClip(filePath:  val_8, soundType:  1);
        float val_8 = this.seVolume;
        val_8 = val_8 * volume;
        val_10 = this.CreateAudioSource(clip:  val_3, volume:  val_8, pitch:  pitch, mute:  (this.enabledSE == false) ? 1 : 0, audioMixerGroup:  null);
        val_10.loop = true;
        val_9 = this.seLoopSourceDic;
        val_11 = null;
        val_11 = null;
        .name = val_3.name;
        .audioSource = val_10;
        .uniqueVolume = volume;
        .callBack = ActionExtensions.EmptyAction;
        val_9.Add(key:  val_8, value:  new SoundManager.PlayingAudio());
        return val_10;
    }
    public void PlayVoice(string filePath, int maxCount = 0, float volume = 1, float pitch = 1)
    {
        this.PlayVoice(clip:  this.LoadAudioClip(filePath:  filePath, soundType:  2), maxCount:  maxCount, volume:  volume, pitch:  pitch);
    }
    public void PlayVoice(UnityEngine.AudioClip clip, int maxCount = 0, float volume = 1, float pitch = 1)
    {
        var val_2;
        if(clip == 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        this.PlayVoice(clip:  clip, callBack:  ActionExtensions.EmptyAction, maxCount:  maxCount, volume:  volume, pitch:  pitch);
    }
    public void PlayVoice(string filePath, System.Action callBack, int maxCount = 0, float volume = 1)
    {
        this.PlayVoice(clip:  this.LoadAudioClip(filePath:  filePath, soundType:  2), callBack:  callBack, maxCount:  maxCount, volume:  volume, pitch:  1f);
    }
    public void PlayVoice(UnityEngine.AudioClip clip, System.Action callBack, int maxCount = 0, float volume = 1, float pitch = 1)
    {
        if(clip != 0)
        {
                if(this.isPausing == false)
        {
            goto label_4;
        }
        
        }
        
        callBack.Invoke();
        return;
        label_4:
        this.PlayVoice(clip:  clip, maxCount:  maxCount, volume:  volume, pitch:  pitch, callBack:  callBack, list:  this.voiceSourceList);
    }
    private void PlayVoice(UnityEngine.AudioClip clip, int maxCount, float volume, float pitch, System.Action callBack, System.Collections.Generic.List<SoundManager.PlayingAudio> list)
    {
        string val_1 = clip.name;
        if((val_1.FindCountOverPlayingAudio(clipName:  val_1, maxCount:  maxCount, list:  list)) != null)
        {
                val_2.audioSource.Stop();
            val_2.audioSource.Play();
            return;
        }
        
        float val_6 = this.voiceVolume;
        val_6 = val_6 * volume;
        .name = val_1;
        .audioSource = this.CreateAudioSource(clip:  clip, volume:  val_6, pitch:  pitch, mute:  (this.enabledVoice == false) ? 1 : 0, audioMixerGroup:  list);
        .uniqueVolume = volume;
        .callBack = callBack;
        list.Add(item:  new SoundManager.PlayingAudio());
    }
    private SoundManager.PlayingAudio FindCountOverPlayingAudio(string clipName, int maxCount, System.Collections.Generic.List<SoundManager.PlayingAudio> list)
    {
        var val_3;
        var val_9;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_18;
        if(maxCount < 1)
        {
            goto label_33;
        }
        
        List.Enumerator<T> val_1 = list.GetEnumerator();
        val_11 = 0;
        val_12 = 0;
        val_13 = 0;
        goto label_20;
        label_21:
        string val_4 = val_3.Id;
        if(((System.String.op_Equality(a:  val_4.m_stringLength, b:  clipName)) == false) || (1 < maxCount))
        {
            goto label_20;
        }
        
        List.Enumerator<T> val_6 = list.GetEnumerator();
        label_10:
        if(((-1147924384) & 1) == 0)
        {
            goto label_8;
        }
        
        if((System.String.op_Equality(a:  val_7.m_stringLength, b:  clipName)) == false)
        {
            goto label_10;
        }
        
        val_13 = val_3.Id;
        val_14 = 1;
        goto label_12;
        label_8:
        val_14 = 0 + 1;
        mem2[0] = 104;
        label_12:
        UniRx.Unit..cctor();
        if( == 1)
        {
            goto label_16;
        }
        
        if(val_9 == 104)
        {
            goto label_17;
        }
        
        if(val_9 == 131)
        {
            goto label_18;
        }
        
        label_16:
        val_11 = 0;
        val_12 = 0;
        if( == 0)
        {
            goto label_20;
        }
        
        val_11 = 0;
        val_12 = 0;
        goto label_20;
        label_17:
        val_12 = ;
        var val_10 = 0;
        val_10 = val_10 ^ 0;
         =  + val_10;
        label_20:
        if(((-1147924352) & 1) != 0)
        {
            goto label_21;
        }
        
        val_18 =  + 1;
        mem2[0] = 129;
        goto label_22;
        label_18:
        UniRx.Unit..cctor();
        return (PlayingAudio)val_13;
        label_22:
        UniRx.Unit..cctor();
        if( == 1)
        {
            goto label_30;
        }
        
        if((1152921512048857120 + ((val_15 + (0 ^ 0))) << 2) == 129)
        {
            goto label_33;
        }
        
        if((1152921512048857120 + ((val_15 + (0 ^ 0))) << 2) == 131)
        {
                return (PlayingAudio)val_13;
        }
        
        label_30:
        label_33:
        val_13 = 0;
        return (PlayingAudio)val_13;
    }
    private UnityEngine.AudioSource CreateAudioSource(UnityEngine.AudioClip clip, float volume, float pitch, bool mute, UnityEngine.Audio.AudioMixerGroup audioMixerGroup)
    {
        UnityEngine.Audio.AudioMixerGroup val_5;
        UnityEngine.AudioSource val_2 = this.gameObject.AddComponent<UnityEngine.AudioSource>();
        if(val_2 != null)
        {
                val_2.Stop();
            val_2.clip = clip;
            val_2.volume = volume;
            val_2.pitch = pitch;
            val_2.mute = mute;
            val_2.Play();
            val_5 = this.defaultVoiceAudioMixer;
        }
        else
        {
                val_2.Stop();
            val_2.clip = clip;
            val_2.volume = volume;
            val_2.pitch = pitch;
            val_2.mute = mute;
            val_2.Play();
            val_5 = this.defaultVoiceAudioMixer;
        }
        
        val_2.outputAudioMixerGroup = val_5;
        return val_2;
    }
    private UnityEngine.AudioClip LoadAudioClip(string filePath, SoundType soundType)
    {
        string val_8;
        string val_9;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip> val_10;
        val_8 = filePath;
        if((val_8.Contains(value:  "/")) == true)
        {
            goto label_5;
        }
        
        if(soundType == 2)
        {
            goto label_3;
        }
        
        if(soundType == 1)
        {
            goto label_4;
        }
        
        if(soundType != 0)
        {
            goto label_5;
        }
        
        val_9 = "Sounds/BGM/";
        goto label_7;
        label_3:
        val_9 = "Sounds/Voice/";
        goto label_7;
        label_4:
        val_9 = "Sounds/SE/";
        label_7:
        val_8 = val_9 + val_8;
        label_5:
        val_10 = this.audioClipDict;
        if((val_10.TryGetValue(key:  val_8, value: out  0)) == true)
        {
                return val_10;
        }
        
        UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  val_8, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        this.audioClipDict.Add(key:  val_8, value:  val_10);
        return val_10;
    }
    private void UpdateMute()
    {
        if(this.bgmSource != 0)
        {
                this.bgmSource.mute = (this.enabledBGM == false) ? 1 : 0;
        }
        
        this.seSourceList.ForEach(action:  new System.Action<PlayingAudio>(object:  this, method:  System.Void SoundManager::<UpdateMute>b__67_0(SoundManager.PlayingAudio se)));
        this.voiceSourceList.ForEach(action:  new System.Action<PlayingAudio>(object:  this, method:  System.Void SoundManager::<UpdateMute>b__67_1(SoundManager.PlayingAudio voice)));
    }
    public void ChangeBGMAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup amg)
    {
        this.bgmSource.outputAudioMixerGroup = amg;
    }
    public void ResetBGMAudioMixerGroup()
    {
        this.bgmSource.outputAudioMixerGroup = this.defaultBGMAudioMixer;
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bgmSource)) == false)
        {
                return;
        }
        
        if(pauseStatus != false)
        {
                this.isPause = true;
            this.bgmSource.volume = 0f;
            this.PauseBGM();
            this.isPausing = true;
            return;
        }
        
        if(this.isPause == false)
        {
                return;
        }
        
        this.isPause = false;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.ReturnPause());
    }
    private System.Collections.IEnumerator ReturnPause()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new SoundManager.<ReturnPause>d__73();
    }
    private void FadeIn(float duration, System.Action callback)
    {
        var val_2 = null;
        if((SoundManager.<>c.<>9__74_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.Fade(duration:  duration, lerpToVolume:  SoundManager.<>c.<>9__74_0, callback:  callback);
        return;
        label_3:
        SoundManager.<>c.<>9__74_0 = new System.Func<System.Single, System.Single>(object:  SoundManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Single SoundManager.<>c::<FadeIn>b__74_0(float lerp));
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void FadeOut(float duration, System.Action callback)
    {
        var val_2 = null;
        if((SoundManager.<>c.<>9__75_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.Fade(duration:  duration, lerpToVolume:  SoundManager.<>c.<>9__75_0, callback:  callback);
        return;
        label_3:
        SoundManager.<>c.<>9__75_0 = new System.Func<System.Single, System.Single>(object:  SoundManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Single SoundManager.<>c::<FadeOut>b__75_0(float lerp));
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void Fade(float duration, System.Func<float, float> lerpToVolume, System.Action callback)
    {
        SoundManager.<>c__DisplayClass76_0 val_1 = new SoundManager.<>c__DisplayClass76_0();
        if(val_1 != null)
        {
                .lerpToVolume = lerpToVolume;
        }
        else
        {
                mem[16] = lerpToVolume;
        }
        
        .<>4__this = this;
        UnityEngine.Coroutine val_3 = MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void SoundManager.<>c__DisplayClass76_0::<Fade>b__0(float lerp)), callback:  callback);
    }
    public SoundManager()
    {
        this.bgmFilePath = "";
        this.seSourceList = new System.Collections.Generic.List<PlayingAudio>();
        this.seLoopSourceDic = new System.Collections.Generic.Dictionary<System.String, PlayingAudio>();
        this.voiceSourceList = new System.Collections.Generic.List<PlayingAudio>();
        this.bgmVolume = 1f;
        this.seVolume = 1f;
        this.voiceVolume = 1f;
        this.enabledBGM = true;
        this.enabledSE = true;
        this.enabledVoice = true;
        this.audioClipDict = new System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip>();
    }
    private void <SaveEnabledSE>b__23_0(SoundManager.PlayingAudio se)
    {
        se.ChangeMute(mute:  (this.enabledSE == false) ? 1 : 0);
    }
    private void <UpdateMute>b__67_0(SoundManager.PlayingAudio se)
    {
        se.ChangeMute(mute:  (this.enabledSE == false) ? 1 : 0);
    }
    private void <UpdateMute>b__67_1(SoundManager.PlayingAudio voice)
    {
        voice.ChangeMute(mute:  (this.enabledVoice == false) ? 1 : 0);
    }

}
