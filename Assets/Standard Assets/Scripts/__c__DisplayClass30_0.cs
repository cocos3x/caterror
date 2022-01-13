using UnityEngine;
private sealed class IAPDemo.<>c__DisplayClass30_0
{
    // Fields
    public IAPDemo <>4__this;
    public UnityEngine.Purchasing.ConfigurationBuilder builder;
    public System.Action initializeUnityIap;
    
    // Methods
    public IAPDemo.<>c__DisplayClass30_0()
    {
    
    }
    internal void <Awake>b__0()
    {
        UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  this.<>4__this, builder:  this.builder);
    }
    internal void <Awake>b__2()
    {
        this.initializeUnityIap.Invoke();
    }

}
