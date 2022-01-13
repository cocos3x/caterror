using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallWaitForRealTimeSeconds>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<float> act;
    public float seconds;
    public System.Action callback;
    private float <startupTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonoBehaviourExtensions.<DoCallWaitForRealTimeSeconds>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_4;
        var val_6;
        int val_7;
        val_4 = this;
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
        val_6 = 1152921511891093088;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        float val_3 = UnityEngine.Time.realtimeSinceStartup - (this.<startupTime>5__2);
        if(val_3 >= this.seconds)
        {
            goto label_5;
        }
        
        val_6 = 1152921511891093088;
        label_4:
        this.act.Invoke(obj:  val_3);
        val_7 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_5:
        this.act.Invoke(obj:  this.seconds);
        val_4 = this.callback;
        val_4.Invoke();
        label_2:
        val_7 = 0;
        return (bool)val_7;
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
