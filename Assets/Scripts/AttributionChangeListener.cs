using UnityEngine;
private class AdjustAndroid.AttributionChangeListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustAttribution> callback;
    
    // Methods
    public AdjustAndroid.AttributionChangeListener(System.Action<com.adjust.sdk.AdjustAttribution> pCallback)
    {
        this.callback = pCallback;
    }
    public void onAttributionChanged(UnityEngine.AndroidJavaObject attribution)
    {
        var val_26;
        string val_27;
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
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        if(this.callback == null)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName), b:  "")) != true)
        {
                val_28 = null;
            val_28 = null;
            val_27 = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
        }
        
        .<trackerName>k__BackingField = val_27;
        val_29 = null;
        val_29 = null;
        val_30 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken), b:  "")) != true)
        {
                val_31 = null;
            val_31 = null;
        }
        
        .<trackerToken>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
        val_32 = null;
        val_32 = null;
        val_33 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork), b:  "")) != true)
        {
                val_34 = null;
            val_34 = null;
        }
        
        .<network>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
        val_35 = null;
        val_35 = null;
        val_36 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign), b:  "")) != true)
        {
                val_37 = null;
            val_37 = null;
        }
        
        .<campaign>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
        val_38 = null;
        val_38 = null;
        val_39 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup), b:  "")) != true)
        {
                val_40 = null;
            val_40 = null;
        }
        
        .<adgroup>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
        val_41 = null;
        val_41 = null;
        val_42 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative), b:  "")) != true)
        {
                val_43 = null;
            val_43 = null;
        }
        
        .<creative>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
        val_44 = null;
        val_44 = null;
        val_45 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel), b:  "")) != true)
        {
                val_46 = null;
            val_46 = null;
        }
        
        .<clickLabel>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
        val_47 = null;
        val_47 = null;
        val_48 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != true)
        {
                val_49 = null;
            val_49 = null;
        }
        
        .<adid>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        this.callback.Invoke(obj:  new com.adjust.sdk.AdjustAttribution());
    }

}
