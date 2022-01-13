using UnityEngine;
private class AdjustAndroid.EventTrackingFailedListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustEventFailure> callback;
    
    // Methods
    public AdjustAndroid.EventTrackingFailedListener(System.Action<com.adjust.sdk.AdjustEventFailure> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedEventTrackingFailed(UnityEngine.AndroidJavaObject eventFailureData)
    {
        var val_22;
        string val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        if(eventFailureData == null)
        {
                return;
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        com.adjust.sdk.AdjustEventFailure val_1 = new com.adjust.sdk.AdjustEventFailure();
        val_22 = null;
        val_22 = null;
        val_23 = 0;
        if((System.String.op_Equality(a:  eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != true)
        {
                val_24 = null;
            val_24 = null;
            val_23 = eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        }
        
        .<Adid>k__BackingField = val_23;
        val_25 = null;
        val_25 = null;
        val_26 = 0;
        if((System.String.op_Equality(a:  eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage), b:  "")) != true)
        {
                val_27 = null;
            val_27 = null;
        }
        
        .<Message>k__BackingField = eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_28 = null;
        val_28 = null;
        .<WillRetry>k__BackingField = eventFailureData.Get<System.Boolean>(fieldName:  com.adjust.sdk.AdjustUtils.KeyWillRetry);
        val_29 = 0;
        if((System.String.op_Equality(a:  eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp), b:  "")) != true)
        {
                val_30 = null;
            val_30 = null;
        }
        
        .<Timestamp>k__BackingField = eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_31 = null;
        val_31 = null;
        val_32 = 0;
        if((System.String.op_Equality(a:  eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken), b:  "")) != true)
        {
                val_33 = null;
            val_33 = null;
        }
        
        .<EventToken>k__BackingField = eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken);
        val_34 = null;
        val_34 = null;
        val_35 = 0;
        if((System.String.op_Equality(a:  eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId), b:  "")) != true)
        {
                val_36 = null;
            val_36 = null;
        }
        
        .<CallbackId>k__BackingField = eventFailureData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
        val_37 = null;
        val_37 = null;
        val_1.BuildJsonResponseFromString(jsonResponseString:  eventFailureData.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse).Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()));
        this.callback.Invoke(obj:  val_1);
    }

}
