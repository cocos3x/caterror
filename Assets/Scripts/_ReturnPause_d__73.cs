using UnityEngine;
private sealed class SoundManager.<ReturnPause>d__73 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SoundManager <>4__this;
    private int <i>5__2;
    private int <waitFrameCounter>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SoundManager.<ReturnPause>d__73(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SoundManager val_2;
        int val_3;
        var val_4;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<i>5__2 = 1;
        this.<waitFrameCounter>5__3 = 20;
        goto label_3;
        label_1:
        val_2 = this.<>4__this;
        this.<>1__state = 0;
        this.<i>5__2 = (this.<i>5__2) + 1;
        if((this.<i>5__2) >= (this.<waitFrameCounter>5__3))
        {
            goto label_4;
        }
        
        label_3:
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_4:
        if(val_2 != null)
        {
                this.<>4__this.isPausing = false;
        }
        else
        {
                mem[129] = 0;
        }
        
        val_2.UnPauseBGM();
        val_4 = null;
        val_4 = null;
        val_2.FadeIn(duration:  1f, callback:  ActionExtensions.EmptyAction);
        label_2:
        val_3 = 0;
        return (bool)val_3;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
