using UnityEngine;
private class IAPDemo.UnityChannelLoginHandler : ILoginListener
{
    // Fields
    internal System.Action initializeSucceededAction;
    internal System.Action<string> initializeFailedAction;
    internal System.Action<UnityEngine.Store.UserInfo> loginSucceededAction;
    internal System.Action<string> loginFailedAction;
    
    // Methods
    public void OnInitialized()
    {
        this.initializeSucceededAction.Invoke();
    }
    public void OnInitializeFailed(string message)
    {
        this.initializeFailedAction.Invoke(obj:  message);
    }
    public void OnLogin(UnityEngine.Store.UserInfo userInfo)
    {
        this.loginSucceededAction.Invoke(obj:  userInfo);
    }
    public void OnLoginFailed(string message)
    {
        this.loginFailedAction.Invoke(obj:  message);
    }
    public IAPDemo.UnityChannelLoginHandler()
    {
    
    }

}
