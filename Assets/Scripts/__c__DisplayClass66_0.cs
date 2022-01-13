using UnityEngine;
private sealed class Purchaser.<>c__DisplayClass66_0
{
    // Fields
    public System.Action callback;
    
    // Methods
    public Purchaser.<>c__DisplayClass66_0()
    {
    
    }
    internal void <WaitOneFrame>b__0()
    {
        this.callback.Invoke();
    }

}
