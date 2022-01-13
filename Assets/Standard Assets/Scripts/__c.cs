using UnityEngine;
[Serializable]
private sealed class IAPDemo.<>c
{
    // Fields
    public static readonly IAPDemo.<>c <>9;
    public static System.Action<string> <>9__30_1;
    
    // Methods
    private static IAPDemo.<>c()
    {
        IAPDemo.<>c.<>9 = new IAPDemo.<>c();
    }
    public IAPDemo.<>c()
    {
    
    }
    internal void <Awake>b__30_1(string message)
    {
        UnityEngine.Debug.LogError(message:  "Failed to initialize and login to UnityChannel: "("Failed to initialize and login to UnityChannel: ") + message);
    }

}
