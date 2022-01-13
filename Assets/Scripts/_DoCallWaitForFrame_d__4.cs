using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallWaitForFrame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int frameCount;
    public System.Action act;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonoBehaviourExtensions.<DoCallWaitForFrame>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        int val_2;
        val_1 = this.<>1__state;
        if(val_1 == 1)
        {
            goto label_0;
        }
        
        if(val_1 != 0)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        this.<i>5__2 = 0;
        goto label_2;
        label_0:
        this.<>1__state = 0;
        val_1 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_1;
        label_2:
        if(val_1 >= this.frameCount)
        {
            goto label_3;
        }
        
        val_2 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_2;
        return (bool)val_2;
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_3:
        this.act.Invoke();
        val_2 = 0;
        return (bool)val_2;
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
