using UnityEngine;
private sealed class Purchaser.<>c__DisplayClass60_0
{
    // Fields
    public Purchaser <>4__this;
    public string failedTitle;
    public string failedExplanation;
    
    // Methods
    public Purchaser.<>c__DisplayClass60_0()
    {
    
    }
    internal void <OnPurchaseFailed>b__0()
    {
        this.<>4__this.onPurchaseFailedEvent.Invoke(arg0:  this.failedTitle, arg1:  this.failedExplanation);
    }

}
