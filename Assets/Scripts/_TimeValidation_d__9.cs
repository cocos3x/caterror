using UnityEngine;
private sealed class TimeValidator.<TimeValidation>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<System.DateTime> succeededCallback;
    public TimeValidator <>4__this;
    private TimeValidator.<>c__DisplayClass9_0 <>8__1;
    public System.Action failedCallback;
    private int <retryCounter>5__2;
    private int <timeout>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TimeValidator.<TimeValidation>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_5;
        TimeValidator.<>c__DisplayClass9_0 val_6;
        var val_7;
        var val_8;
        int val_9;
        val_5 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_14;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new TimeValidator.<>c__DisplayClass9_0();
        .succeededCallback = this.succeededCallback;
        val_6 = this.<>8__1;
        this.<retryCounter>5__2 = 3;
        this.<>8__1.isTimeOut = true;
        this.<timeout>5__3 = 3000;
        goto label_5;
        label_1:
        int val_5 = this.<retryCounter>5__2;
        int val_6 = this.<timeout>5__3;
        val_6 = this.<>8__1;
        this.<>1__state = 0;
        val_5 = val_5 - 1;
        val_6 = val_6 + (val_6 << 2);
        this.<retryCounter>5__2 = val_5;
        this.<timeout>5__3 = val_6;
        label_5:
        val_7 = mem[this.<>8__1];
        if(((mem[this.<>8__1] + 16) != 0) && ((this.<retryCounter>5__2) > 0))
        {
                NtpRequest val_2 = null;
            val_7 = val_2;
            val_2 = new NtpRequest();
            val_8 = null;
            val_8 = null;
            this.<>2__current = val_2.GetNetworkTime(behaviour:  this.<>4__this, succeededCallback:  new System.Action<System.DateTime>(object:  mem[this.<>8__1], method:  System.Void TimeValidator.<>c__DisplayClass9_0::<TimeValidation>b__0(System.DateTime result)), failedCallback:  ActionExtensions.EmptyAction, timeout:  this.<timeout>5__3);
            val_9 = 1;
            this.<>1__state = val_9;
            return (bool)val_9;
        }
        
        if((mem[this.<>8__1] + 16) != 0)
        {
                val_5 = this.failedCallback;
            val_5.Invoke();
        }
        
        label_14:
        val_9 = 0;
        return (bool)val_9;
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
