using UnityEngine;
private sealed class SoundManager.<>c__DisplayClass30_0
{
    // Fields
    public float volume;
    
    // Methods
    public SoundManager.<>c__DisplayClass30_0()
    {
    
    }
    internal void <ChangeVolumeSE>b__0(SoundManager.PlayingAudio se)
    {
        se.ChangeVolume(volume:  this.volume);
    }

}
