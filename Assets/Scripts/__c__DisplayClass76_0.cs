using UnityEngine;
private sealed class SoundManager.<>c__DisplayClass76_0
{
    // Fields
    public System.Func<float, float> lerpToVolume;
    public SoundManager <>4__this;
    
    // Methods
    public SoundManager.<>c__DisplayClass76_0()
    {
    
    }
    internal void <Fade>b__0(float lerp)
    {
        var val_4;
        SoundManager val_12;
        float val_13;
        UnityEngine.AudioSource val_14;
        SoundManager val_15;
        SoundManager val_16;
        SoundManager val_17;
        var val_18;
        var val_19;
        float val_1 = this.lerpToVolume.Invoke(arg:  lerp);
        val_12 = this.<>4__this;
        val_13 = val_1;
        if(val_12 != null)
        {
                val_14 = this.<>4__this.bgmSource;
            val_15 = val_12;
        }
        else
        {
                val_15 = this.<>4__this;
            val_14 = this.<>4__this.bgmSource;
            if(val_15 != null)
        {
                val_12 = val_15;
        }
        else
        {
                val_12 = this.<>4__this;
            if(val_12 == null)
        {
            goto label_35;
        }
        
        }
        
        }
        
        val_1 = val_13 * (this.<>4__this.uniqueBGMVolume);
        val_1 = val_1 * (this.<>4__this.bgmVolume);
        val_14.volume = val_1;
        val_16 = this.<>4__this;
        if((this.<>4__this) == null)
        {
                val_16 = this.<>4__this;
            if(val_16 == null)
        {
            goto label_35;
        }
        
        }
        
        float val_11 = this.<>4__this.seVolume;
        val_11 = val_13 * val_11;
        List.Enumerator<T> val_2 = this.<>4__this.seSourceList.GetEnumerator();
        val_15 = 1152921512045900832;
        label_13:
        if(((-1142807168) & 1) == 0)
        {
            goto label_11;
        }
        
        val_4.Id.ChangeVolume(volume:  val_11);
        goto label_13;
        label_11:
        UniRx.Unit..cctor();
        Dictionary.Enumerator<TKey, TValue> val_6 = this.<>4__this.seLoopSourceDic.GetEnumerator();
        label_22:
        if(((-1142807216) & 1) == 0)
        {
            goto label_20;
        }
        
        System.Collections.Generic.KeyValuePair<TKey, TValue> val_8 = val_4.Current;
        val_8.Value.ChangeVolume(volume:  val_11);
        goto label_22;
        label_20:
        UniRx.Unit..cctor();
        val_17 = this.<>4__this;
        if((this.<>4__this) == null)
        {
                val_17 = this.<>4__this;
            if(val_17 == null)
        {
            goto label_35;
        }
        
        }
        
        val_13 = val_13 * (this.<>4__this.voiceVolume);
        List.Enumerator<T> val_9 = this.<>4__this.voiceSourceList.GetEnumerator();
        label_33:
        if(((-1142807168) & 1) == 0)
        {
            goto label_31;
        }
        
        val_4.Id.ChangeVolume(volume:  val_13);
        goto label_33;
        label_31:
        val_18 = 0;
        val_19 = 0;
        goto label_34;
        label_35:
        if((public System.Single System.Func<System.Single, System.Single>::Invoke(System.Single arg)) != 1)
        {
            goto label_36;
        }
        
        val_19 = 1179403647;
        val_18 = 0;
        label_34:
        UniRx.Unit..cctor();
        if(val_18 != 1)
        {
                if(val_19 == 0)
        {
                return;
        }
        
            if(263 == 263)
        {
                return;
        }
        
            return;
        }
        
        if(val_19 != 0)
        {
                return;
        }
        
        return;
        label_36:
    }

}
