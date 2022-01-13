using UnityEngine;
private sealed class MonoBehaviourExtensions.<DoCallTimer>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float firstTime;
    public float interval;
    public System.Action<int> action;
    public float seconds;
    public System.Action callback;
    private float <t>5__2;
    private float <timer>5__3;
    private int <counter>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonoBehaviourExtensions.<DoCallTimer>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_4;
        int val_5;
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
        this.<t>5__2 = 0f;
        this.<timer>5__3 = this.firstTime;
        this.<counter>5__4 = 1;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = (this.<t>5__2) + val_1;
        this.<t>5__2 = val_1;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = (this.<timer>5__3) + val_2;
        this.<timer>5__3 = val_2;
        if(val_2 >= this.interval)
        {
                do
        {
            val_2 = val_2 - this.interval;
            this.<timer>5__3 = val_2;
            int val_3 = (this.<counter>5__4) + 1;
            this.<counter>5__4 = val_3;
            this.action.Invoke(obj:  val_3);
        }
        while((this.<timer>5__3) >= this.interval);
        
        }
        
        if((this.<t>5__2) < 0)
        {
            goto label_7;
        }
        
        val_4 = this.callback;
        val_4.Invoke();
        label_2:
        val_5 = 0;
        return (bool)val_5;
        label_7:
        val_5 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_5;
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
