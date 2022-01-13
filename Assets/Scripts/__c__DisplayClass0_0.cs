using UnityEngine;
private sealed class JPRewardAd.<>c__DisplayClass0_0
{
    // Fields
    public UnityEngine.Events.UnityAction success;
    public bool showPop;
    public UnityEngine.Events.UnityAction not_success;
    public System.Action <>9__1;
    public System.Action <>9__2;
    public System.Action <>9__3;
    
    // Methods
    public JPRewardAd.<>c__DisplayClass0_0()
    {
    
    }
    internal void <ShowRV>b__0(JoypacVideoStatus obj)
    {
        if(obj > 4)
        {
                return;
        }
        
        var val_11 = 28872688 + (obj) << 2;
        val_11 = val_11 + 28872688;
        goto (28872688 + (obj) << 2 + 28872688);
    }
    internal void <ShowRV>b__1()
    {
        if(this.not_success == null)
        {
                return;
        }
        
        this.not_success.Invoke();
    }
    internal void <ShowRV>b__2()
    {
        if(this.not_success == null)
        {
                return;
        }
        
        this.not_success.Invoke();
    }
    internal void <ShowRV>b__3()
    {
        if(this.not_success == null)
        {
                return;
        }
        
        this.not_success.Invoke();
    }

}
