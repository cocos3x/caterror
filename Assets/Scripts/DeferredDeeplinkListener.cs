using UnityEngine;
private class AdjustAndroid.DeferredDeeplinkListener : AndroidJavaProxy
{
    // Fields
    private System.Action<string> callback;
    
    // Methods
    public AdjustAndroid.DeferredDeeplinkListener(System.Action<string> pCallback)
    {
        this.callback = pCallback;
    }
    public bool launchReceivedDeeplink(UnityEngine.AndroidJavaObject deeplink)
    {
        if(this.callback == null)
        {
                return (bool)com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink;
        }
        
        this = deeplink.Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>());
        this.callback.Invoke(obj:  this);
        return (bool)com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink;
    }

}
