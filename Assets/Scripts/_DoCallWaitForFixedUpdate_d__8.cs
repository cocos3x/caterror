using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallWaitForFixedUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
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
    public MonoBehaviourExtensions.<DoCallWaitForFixedUpdate>d__8(int <>1__state)
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
        int val_4;
        val_2 = this;
        val_3 = this.<>1__state;
        if(val_3 == 1)
        {
            goto label_1;
        }
        
        if(val_3 != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<i>5__2 = 0;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        val_3 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_3;
        label_3:
        if(val_3 < this.frameCount)
        {
                val_4 = 1;
            this.<>2__current = new UnityEngine.WaitForFixedUpdate();
            this.<>1__state = val_4;
            return (bool)val_4;
        }
        
        val_2 = this.act;
        val_2.Invoke();
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
