using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallTimerRealtime>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<int> action;
    public float interval;
    public float seconds;
    public System.Action callback;
    private float <startupTime>5__2;
    private int <counter>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonoBehaviourExtensions.<DoCallTimerRealtime>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_5;
        int val_6;
        val_5 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<startupTime>5__2 = UnityEngine.Time.realtimeSinceStartup;
        this.<counter>5__3 = 0;
        this.action.Invoke(obj:  1);
        goto label_7;
        label_1:
        this.<>1__state = 0;
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        float val_3 = val_2 - (this.<startupTime>5__2);
        val_2 = val_3 / this.interval;
        if((this.<counter>5__3) != (int)val_2)
        {
                this.<counter>5__3 = (int)val_2;
            this.action.Invoke(obj:  (int)val_2 + 1);
        }
        
        if(val_3 < 0)
        {
            goto label_7;
        }
        
        val_5 = this.callback;
        val_5.Invoke();
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        val_6 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_6;
        return (bool)val_6;
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
