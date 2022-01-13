using UnityEngine;
private sealed class PlayGif.<TUI>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PlayGif <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayGif.<TUI>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_9;
        }
        
        this.<>1__state = 0;
        this.<i>5__2 = 0;
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        goto label_3;
        label_0:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        label_3:
        label_4:
        if((this.<>4__this.isRun) == false)
        {
            goto label_9;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = (this.<>4__this.timer) + val_1;
        this.<>4__this.timer = val_1;
        if(val_1 >= (this.<>4__this.interval))
        {
            goto label_6;
        }
        
        label_16:
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_6:
        this.<>4__this.timer = 0f;
        if((this.<i>5__2) >= (this.<>4__this.UIArray.Length))
        {
            goto label_9;
        }
        
        this.<i>5__2 = (this.<i>5__2) + 1;
        this.<>4__this.image.sprite = this.<>4__this.UIArray[this.<i>5__2];
        if(((this.<>4__this.Loop) == false) || ((this.<i>5__2) < (this.<>4__this.UIArray.Length)))
        {
            goto label_16;
        }
        
        this.<i>5__2 = 0;
        goto label_16;
        label_9:
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
