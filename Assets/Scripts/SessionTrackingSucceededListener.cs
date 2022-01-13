using UnityEngine;
private class AdjustAndroid.SessionTrackingSucceededListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustSessionSuccess> callback;
    
    // Methods
    public AdjustAndroid.SessionTrackingSucceededListener(System.Action<com.adjust.sdk.AdjustSessionSuccess> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedSessionTrackingSucceeded(UnityEngine.AndroidJavaObject sessionSuccessData)
    {
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(sessionSuccessData == null)
        {
                return;
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        com.adjust.sdk.AdjustSessionSuccess val_1 = new com.adjust.sdk.AdjustSessionSuccess();
        val_14 = null;
        val_14 = null;
        val_15 = 0;
        if((System.String.op_Equality(a:  sessionSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != true)
        {
                val_16 = null;
            val_16 = null;
            val_15 = sessionSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        }
        
        .<Adid>k__BackingField = val_15;
        val_17 = null;
        val_17 = null;
        val_18 = 0;
        if((System.String.op_Equality(a:  sessionSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage), b:  "")) != true)
        {
                val_19 = null;
            val_19 = null;
        }
        
        .<Message>k__BackingField = sessionSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_20 = null;
        val_20 = null;
        val_21 = 0;
        if((System.String.op_Equality(a:  sessionSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp), b:  "")) != true)
        {
                val_22 = null;
            val_22 = null;
        }
        
        .<Timestamp>k__BackingField = sessionSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_23 = null;
        val_23 = null;
        val_1.BuildJsonResponseFromString(jsonResponseString:  sessionSuccessData.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse).Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()));
        this.callback.Invoke(obj:  val_1);
    }

}
