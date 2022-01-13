using UnityEngine;
private sealed class NtpRequest.<WaitForRequest>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NtpRequest <>4__this;
    public System.Action<System.DateTime> succeededCallback;
    public System.Action failedCallback;
    private int <startTickCount>5__2;
    private bool <isTimeouted>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NtpRequest.<WaitForRequest>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_5;
        System.Action<System.DateTime> val_6;
        bool val_7;
        var val_8;
        val_5 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_18;
        }
        
        this.<>1__state = 0;
        this.<startTickCount>5__2 = System.Environment.TickCount;
        this.<isTimeouted>5__3 = false;
        if((this.<>4__this) != null)
        {
            goto label_7;
        }
        
        goto label_5;
        label_1:
        val_6 = 0;
        this.<>1__state = 0;
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_7;
        }
        
        label_5:
        label_7:
        val_7 = this.<>4__this.threadRunning;
        if(val_7 == false)
        {
            goto label_11;
        }
        
        val_7 = this.<>4__this.ntpDateTime;
        val_8 = null;
        val_8 = null;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_7}, t2:  new System.DateTime() {dateData = System.DateTime.MinValue})) == true)
        {
            goto label_11;
        }
        
        int val_5 = this.<startTickCount>5__2;
        val_5 = System.Environment.TickCount - val_5;
        if(val_5 <= (this.<>4__this.timeout))
        {
            goto label_12;
        }
        
        this.<isTimeouted>5__3 = true;
        label_11:
        this.<>4__this.CloseRequest();
        this.<>4__this.threadRunning = false;
        if((this.<isTimeouted>5__3) == false)
        {
            goto label_13;
        }
        
        val_7 = this.<>4__this.retryCount;
        int val_6 = this.<>4__this.NTP_SERVER.Length;
        val_6 = val_6 - 1;
        if(val_7 >= val_6)
        {
            goto label_15;
        }
        
        int val_7 = this.<>4__this.retryCount;
        val_7 = val_7 + 1;
        this.<>4__this.retryCount = val_7;
        this.<isTimeouted>5__3 = false;
        this.<>4__this._threadStart();
        this.<>2__current = this.<>4__this.WaitForRequest(succeededCallback:  this.succeededCallback, failedCallback:  this.failedCallback);
        this.<>1__state = 2;
        val_6 = 1;
        return (bool)val_6;
        label_13:
        val_6 = this.succeededCallback;
        if(val_6 == null)
        {
                return (bool)val_6;
        }
        
        val_6.Invoke(obj:  new System.DateTime() {dateData = this.<>4__this.ntpDateTime});
        goto label_18;
        label_15:
        val_5 = this.failedCallback;
        val_5.Invoke();
        label_18:
        val_6 = 0;
        return (bool)val_6;
        label_12:
        this.<>2__current = 0;
        this.<>1__state = 1;
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
