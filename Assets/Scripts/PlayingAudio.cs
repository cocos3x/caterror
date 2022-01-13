using UnityEngine;
public class SoundManager.PlayingAudio
{
    // Fields
    private string name;
    public UnityEngine.AudioSource audioSource;
    private System.Action callBack;
    private float uniqueVolume;
    
    // Properties
    public string Name { get; }
    
    // Methods
    public string get_Name()
    {
        return (string)this.name;
    }
    public SoundManager.PlayingAudio(string name, UnityEngine.AudioSource audioSource, float uniqueVolume, System.Action callBack)
    {
        this.name = name;
        this.audioSource = audioSource;
        this.uniqueVolume = uniqueVolume;
        this.callBack = callBack;
    }
    public bool IsPlaying()
    {
        if(this.audioSource != null)
        {
                return this.audioSource.isPlaying;
        }
        
        return this.audioSource.isPlaying;
    }
    public void PlayCallBack()
    {
        this.callBack.Invoke();
        UnityEngine.Object.Destroy(obj:  this.audioSource);
    }
    public void Stop()
    {
        this.audioSource.Stop();
    }
    public void StopDestroy()
    {
        this.audioSource.Stop();
        UnityEngine.Object.Destroy(obj:  this.audioSource);
    }
    public void ChangeVolume(float volume)
    {
        volume = this.uniqueVolume * volume;
        this.audioSource.volume = volume;
    }
    public void ChangeMute(bool mute)
    {
        mute = mute;
        this.audioSource.mute = mute;
    }

}
