using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallWaitForSeconds>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<float> act;
    public float seconds;
    public System.Action callback;
    private float <t>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonoBehaviourExtensions.<DoCallWaitForSeconds>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_2;
        int val_3;
        val_2 = this;
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
        this.act.Invoke(obj:  0f);
        goto label_6;
        label_1:
        float val_2 = this.<t>5__2;
        this.<>1__state = 0;
        val_2 = val_2 + UnityEngine.Time.deltaTime;
        this.<t>5__2 = val_2;
        this.act.Invoke(obj:  val_2);
        if((this.<t>5__2) < 0)
        {
            goto label_6;
        }
        
        val_2 = this.callback;
        val_2.Invoke();
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_6:
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
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
