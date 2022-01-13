using UnityEngine;
private class AdjustAndroid.EventTrackingSucceededListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustEventSuccess> callback;
    
    // Methods
    public AdjustAndroid.EventTrackingSucceededListener(System.Action<com.adjust.sdk.AdjustEventSuccess> pCallback)
    {
        this.callback = pCallback;
    }
    public void onFinishedEventTrackingSucceeded(UnityEngine.AndroidJavaObject eventSuccessData)
    {
        var val_20;
        string val_21;
        var val_22;
        var val_23;
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
        if(eventSuccessData == null)
        {
                return;
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        com.adjust.sdk.AdjustEventSuccess val_1 = new com.adjust.sdk.AdjustEventSuccess();
        val_20 = null;
        val_20 = null;
        val_21 = 0;
        if((System.String.op_Equality(a:  eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != true)
        {
                val_22 = null;
            val_22 = null;
            val_21 = eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        }
        
        .<Adid>k__BackingField = val_21;
        val_23 = null;
        val_23 = null;
        val_24 = 0;
        if((System.String.op_Equality(a:  eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage), b:  "")) != true)
        {
                val_25 = null;
            val_25 = null;
        }
        
        .<Message>k__BackingField = eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyMessage);
        val_26 = null;
        val_26 = null;
        val_27 = 0;
        if((System.String.op_Equality(a:  eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp), b:  "")) != true)
        {
                val_28 = null;
            val_28 = null;
        }
        
        .<Timestamp>k__BackingField = eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTimestamp);
        val_29 = null;
        val_29 = null;
        val_30 = 0;
        if((System.String.op_Equality(a:  eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken), b:  "")) != true)
        {
                val_31 = null;
            val_31 = null;
        }
        
        .<EventToken>k__BackingField = eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyEventToken);
        val_32 = null;
        val_32 = null;
        val_33 = 0;
        if((System.String.op_Equality(a:  eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId), b:  "")) != true)
        {
                val_34 = null;
            val_34 = null;
        }
        
        .<CallbackId>k__BackingField = eventSuccessData.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCallbackId);
        val_35 = null;
        val_35 = null;
        val_1.BuildJsonResponseFromString(jsonResponseString:  eventSuccessData.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyJsonResponse).Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()));
        this.callback.Invoke(obj:  val_1);
    }

}
