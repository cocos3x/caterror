using UnityEngine;
private class AdjustAndroid.SessionTrackingFailedListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustSessionFailure> callback;
    
    // Methods
    public AdjustAndroid.SessionTrackingFailedListener(System.Action<com.adjust.sdk.AdjustSessionFailure> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedSessionTrackingFailed(UnityEngine.AndroidJavaObject sessionFailureData)
    {
        var val_16;
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        if(sessionFailureData == null)
        {
                return;
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        com.adjust.sdk.AdjustSessionFailure val_1 = new com.adjust.sdk.AdjustSessionFailure();
        val_16 = null;
        val_16 = null;
        val_17 = 0;
        if((System.String.op_Equality(a:  sessionFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != true)
        {
                val_18 = null;
            val_18 = null;
            val_17 = sessionFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        }
        
        .<Adid>k__BackingField = val_17;
        val_19 = null;
        val_19 = null;
        val_20 = 0;
        if((System.String.op_Equality(a:  sessionFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage), b:  "")) != true)
        {
                val_21 = null;
            val_21 = null;
        }
        
        .<Message>k__BackingField = sessionFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_22 = null;
        val_22 = null;
        .<WillRetry>k__BackingField = sessionFailureData.Get<System.Boolean>(fieldName:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
        val_23 = 0;
        if((System.String.op_Equality(a:  sessionFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp), b:  "")) != true)
        {
                val_24 = null;
            val_24 = null;
        }
        
        .<Timestamp>k__BackingField = sessionFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_25 = null;
        val_25 = null;
        val_1.BuildJsonResponseFromString(jsonResponseString:  sessionFailureData.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse).Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()));
        this.callback.Invoke(obj:  val_1);
    }

}
