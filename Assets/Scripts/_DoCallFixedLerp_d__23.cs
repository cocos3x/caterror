using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallFixedLerp>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<float> act;
    public float duration;
    public System.Action callback;
    private float <t>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonoBehaviourExtensions.<DoCallFixedLerp>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_3;
        var val_4;
        int val_5;
        val_3 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<t>5__2 = 0f;
        val_4 = 1152921511891093088;
        goto label_4;
        label_1:
        float val_3 = this.<t>5__2;
        this.<>1__state = 0;
        float val_1 = UnityEngine.Time.fixedDeltaTime;
        val_1 = val_1 / this.duration;
        val_3 = val_3 + val_1;
        this.<t>5__2 = val_3;
        if(val_3 >= 1f)
        {
            goto label_5;
        }
        
        val_4 = 1152921511891093088;
        label_4:
        this.act.Invoke(obj:  val_3);
        val_5 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_5;
        return (bool)val_5;
        label_5:
        this.act.Invoke(obj:  1f);
        val_3 = this.callback;
        val_3.Invoke();
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
