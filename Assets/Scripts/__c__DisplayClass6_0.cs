using UnityEngine;
private sealed class TimeValidator.<>c__DisplayClass6_0
{
    // Fields
    public TimeValidator <>4__this;
    public System.Action<TimeValidationResult> callback;
    
    // Methods
    public TimeValidator.<>c__DisplayClass6_0()
    {
    
    }
    internal void <TimeValidation>b__0()
    {
        bool val_1 = this.<>4__this.callbackList.Remove(item:  this.callback);
    }

}
