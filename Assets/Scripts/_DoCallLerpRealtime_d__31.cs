using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallLerpRealtime>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<float> act;
    public float duration;
    public System.Action callback;
    private float <startupTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonoBehaviourExtensions.<DoCallLerpRealtime>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_4;
        System.Action<System.Single> val_6;
        var val_7;
        int val_8;
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
        val_6 = this.act;
        this.<startupTime>5__2 = UnityEngine.Time.realtimeSinceStartup;
        val_7 = 1152921511891093088;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_6 = this.act;
        float val_3 = val_2 - (this.<startupTime>5__2);
        if(val_3 >= this.duration)
        {
            goto label_5;
        }
        
        val_7 = 1152921511891093088;
        val_2 = val_3 / this.duration;
        label_4:
        val_6.Invoke(obj:  val_2);
        val_8 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_8;
        return (bool)val_8;
        label_5:
        val_6.Invoke(obj:  1f);
        val_4 = this.callback;
        val_4.Invoke();
        label_2:
        val_8 = 0;
        return (bool)val_8;
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
