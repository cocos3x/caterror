using UnityEngine;
private sealed class SoundManager.<>c__DisplayClass48_0
{
    // Fields
    public SoundManager <>4__this;
    public string filePath;
    public float volume;
    public float interval;
    
    // Methods
    public SoundManager.<>c__DisplayClass48_0()
    {
    
    }
    internal void <ChangeFadeBGM>b__0()
    {
        var val_1;
        this.<>4__this.PlayBGM(filePath:  this.filePath, volume:  this.volume, loop:  true);
        val_1 = null;
        val_1 = null;
        float val_1 = 0.5f;
        val_1 = this.interval * val_1;
        this.<>4__this.FadeIn(duration:  val_1, callback:  ActionExtensions.EmptyAction);
    }

}
