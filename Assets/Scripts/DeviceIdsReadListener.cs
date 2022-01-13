using UnityEngine;
private class AdjustAndroid.DeviceIdsReadListener : AndroidJavaProxy
{
    // Fields
    private System.Action<string> onPlayAdIdReadCallback;
    
    // Methods
    public AdjustAndroid.DeviceIdsReadListener(System.Action<string> pCallback)
    {
        this.onPlayAdIdReadCallback = pCallback;
    }
    public void onGoogleAdIdRead(string playAdId)
    {
        if(this.onPlayAdIdReadCallback == null)
        {
                return;
        }
        
        this.onPlayAdIdReadCallback.Invoke(obj:  playAdId);
    }
    public void onGoogleAdIdRead(UnityEngine.AndroidJavaObject ajoAdId)
    {
        string val_3;
        if(ajoAdId != null)
        {
                val_3 = ajoAdId.Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>());
        }
        else
        {
                val_3 = 0;
        }
        
        this.onGoogleAdIdRead(playAdId:  val_3);
    }

}
