using UnityEngine;
private sealed class TimeValidator.<>c__DisplayClass9_0
{
    // Fields
    public bool isTimeOut;
    public System.Action<System.DateTime> succeededCallback;
    
    // Methods
    public TimeValidator.<>c__DisplayClass9_0()
    {
    
    }
    internal void <TimeValidation>b__0(System.DateTime result)
    {
        this.isTimeOut = false;
        this.succeededCallback.Invoke(obj:  new System.DateTime() {dateData = result.dateData});
    }

}
