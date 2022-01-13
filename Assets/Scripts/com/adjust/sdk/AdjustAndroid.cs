using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustAndroid
    {
        // Fields
        private const string sdkPrefix = "unity4.20.0";
        private static bool launchDeferredDeeplink;
        private static UnityEngine.AndroidJavaClass ajcAdjust;
        private static UnityEngine.AndroidJavaObject ajoCurrentActivity;
        private static com.adjust.sdk.AdjustAndroid.DeferredDeeplinkListener onDeferredDeeplinkListener;
        private static com.adjust.sdk.AdjustAndroid.AttributionChangeListener onAttributionChangedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingFailedListener onEventTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingSucceededListener onEventTrackingSucceededListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingFailedListener onSessionTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingSucceededListener onSessionTrackingSucceededListener;
        
        // Methods
        public static void Start(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            object val_43;
            System.Object[] val_44;
            var val_45;
            string val_46;
            var val_47;
            var val_48;
            var val_49;
            string val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            if(adjustConfig != null)
            {
                    val_43 = mem[adjustConfig.environment == 0x1 ? "production" : "sandbox"];
                val_43 = (adjustConfig.environment == 1) ? "production" : "sandbox";
            }
            else
            {
                    val_43 = mem[0 == 0x1 ? "production" : "sandbox"];
                val_43 = (0 == 1) ? "production" : "sandbox";
            }
            
            if((adjustConfig.allowSuppressLogLevel & 1) != 0)
            {
                    val_44 = new object[4];
                val_45 = null;
                val_45 = null;
                val_44[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
                val_46 = adjustConfig.appToken;
                val_44[1] = val_46;
                val_44[2] = val_43;
                val_47 = 1152921504627453952;
                val_44[3] = adjustConfig.allowSuppressLogLevel.HasValue;
            }
            else
            {
                    object[] val_4 = new object[3];
                val_44 = val_4;
                val_48 = null;
                val_48 = null;
                val_44[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
                val_44[1] = adjustConfig.appToken;
                val_44[2] = val_43;
            }
            
            UnityEngine.AndroidJavaObject val_5 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustConfig", args:  val_4);
            val_49 = null;
            val_49 = null;
            com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink = adjustConfig.launchDeferredDeeplink;
            if((adjustConfig.logLevel & 1) != 0)
            {
                    val_46 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel).Equals(value:  "SUPPRESS");
                if(val_46 != false)
            {
                    val_47 = 1152921509279302896;
                val_50 = "SUPRESS";
                val_51 = public UnityEngine.AndroidJavaObject UnityEngine.AndroidJavaObject::GetStatic<UnityEngine.AndroidJavaObject>(string fieldName);
            }
            else
            {
                    val_50 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel);
                val_51 = public UnityEngine.AndroidJavaObject UnityEngine.AndroidJavaObject::GetStatic<UnityEngine.AndroidJavaObject>(string fieldName);
            }
            
                UnityEngine.AndroidJavaObject val_10 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.LogLevel").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  val_50);
                if(val_10 != null)
            {
                    object[] val_11 = new object[1];
                val_11[0] = val_10;
                val_5.Call(methodName:  "setLogLevel", args:  val_11);
            }
            
            }
            
            object[] val_12 = new object[1];
            val_12[0] = "unity4.20.0";
            val_5.Call(methodName:  "setSdkPrefix", args:  val_12);
            if((adjustConfig.delayStart & 1) != 0)
            {
                    object[] val_13 = new object[1];
                val_13[0] = adjustConfig.delayStart;
                val_5.Call(methodName:  "setDelayStart", args:  val_13);
            }
            
            if((adjustConfig.eventBufferingEnabled & 1) != 0)
            {
                    object[] val_14 = new object[1];
                val_14[0] = adjustConfig.eventBufferingEnabled & 1;
                object[] val_17 = new object[1];
                val_17[0] = new UnityEngine.AndroidJavaObject(className:  "java.lang.Boolean", args:  val_14);
                val_5.Call(methodName:  "setEventBufferingEnabled", args:  val_17);
            }
            
            if((adjustConfig.sendInBackground & 1) != 0)
            {
                    object[] val_18 = new object[1];
                val_18[0] = adjustConfig.sendInBackground & 1;
                val_5.Call(methodName:  "setSendInBackground", args:  val_18);
            }
            
            if(adjustConfig.userAgent != null)
            {
                    object[] val_20 = new object[1];
                val_20[0] = adjustConfig.userAgent;
                val_5.Call(methodName:  "setUserAgent", args:  val_20);
            }
            
            if((System.String.IsNullOrEmpty(value:  adjustConfig.processName)) != true)
            {
                    object[] val_22 = new object[1];
                val_22[0] = adjustConfig.processName;
                val_5.Call(methodName:  "setProcessName", args:  val_22);
            }
            
            if(adjustConfig.defaultTracker != null)
            {
                    object[] val_23 = new object[1];
                val_23[0] = adjustConfig.defaultTracker;
                val_5.Call(methodName:  "setDefaultTracker", args:  val_23);
            }
            
            if(adjustConfig.externalDeviceId != null)
            {
                    object[] val_24 = new object[1];
                val_24[0] = adjustConfig.externalDeviceId;
                val_5.Call(methodName:  "setExternalDeviceId", args:  val_24);
            }
            
            if((com.adjust.sdk.AdjustAndroid.IsAppSecretSet(adjustConfig:  adjustConfig)) != false)
            {
                    object[] val_26 = new object[5];
                val_46 = 1152921512444764448;
                val_26[0] = adjustConfig.secretId;
                val_26[1] = adjustConfig.info1;
                val_26[2] = adjustConfig.info2;
                val_26[3] = adjustConfig.info3;
                val_26[4] = adjustConfig.info4;
                val_5.Call(methodName:  "setAppSecret", args:  val_26);
            }
            
            if((adjustConfig.isDeviceKnown & 1) != 0)
            {
                    object[] val_27 = new object[1];
                val_27[0] = adjustConfig.isDeviceKnown & 1;
                val_5.Call(methodName:  "setDeviceKnown", args:  val_27);
            }
            
            if(adjustConfig.attributionChangedDelegate != null)
            {
                    val_52 = null;
                val_52 = null;
                com.adjust.sdk.AdjustAndroid.onAttributionChangedListener = new AdjustAndroid.AttributionChangeListener(pCallback:  adjustConfig.attributionChangedDelegate);
                object[] val_30 = new object[1];
                val_30[0] = com.adjust.sdk.AdjustAndroid.onAttributionChangedListener;
                val_5.Call(methodName:  "setOnAttributionChangedListener", args:  val_30);
            }
            
            if(adjustConfig.eventSuccessDelegate != null)
            {
                    val_53 = null;
                val_53 = null;
                com.adjust.sdk.AdjustAndroid.onEventTrackingSucceededListener = new AdjustAndroid.EventTrackingSucceededListener(pCallback:  adjustConfig.eventSuccessDelegate);
                object[] val_32 = new object[1];
                val_32[0] = com.adjust.sdk.AdjustAndroid.onEventTrackingSucceededListener;
                val_5.Call(methodName:  "setOnEventTrackingSucceededListener", args:  val_32);
            }
            
            if(adjustConfig.eventFailureDelegate != null)
            {
                    val_54 = null;
                val_54 = null;
                com.adjust.sdk.AdjustAndroid.onEventTrackingFailedListener = new AdjustAndroid.EventTrackingFailedListener(pCallback:  adjustConfig.eventFailureDelegate);
                object[] val_34 = new object[1];
                val_34[0] = com.adjust.sdk.AdjustAndroid.onEventTrackingFailedListener;
                val_5.Call(methodName:  "setOnEventTrackingFailedListener", args:  val_34);
            }
            
            if(adjustConfig.sessionSuccessDelegate != null)
            {
                    val_55 = null;
                val_55 = null;
                com.adjust.sdk.AdjustAndroid.onSessionTrackingSucceededListener = new AdjustAndroid.SessionTrackingSucceededListener(pCallback:  adjustConfig.sessionSuccessDelegate);
                object[] val_36 = new object[1];
                val_36[0] = com.adjust.sdk.AdjustAndroid.onSessionTrackingSucceededListener;
                val_5.Call(methodName:  "setOnSessionTrackingSucceededListener", args:  val_36);
            }
            
            if(adjustConfig.sessionFailureDelegate != null)
            {
                    val_56 = null;
                val_56 = null;
                com.adjust.sdk.AdjustAndroid.onSessionTrackingFailedListener = new AdjustAndroid.SessionTrackingFailedListener(pCallback:  adjustConfig.sessionFailureDelegate);
                object[] val_38 = new object[1];
                val_38[0] = com.adjust.sdk.AdjustAndroid.onSessionTrackingFailedListener;
                val_5.Call(methodName:  "setOnSessionTrackingFailedListener", args:  val_38);
            }
            
            if(adjustConfig.deferredDeeplinkDelegate != null)
            {
                    val_57 = null;
                val_57 = null;
                com.adjust.sdk.AdjustAndroid.onDeferredDeeplinkListener = new AdjustAndroid.DeferredDeeplinkListener(pCallback:  adjustConfig.deferredDeeplinkDelegate);
                object[] val_40 = new object[1];
                val_40[0] = com.adjust.sdk.AdjustAndroid.onDeferredDeeplinkListener;
                val_5.Call(methodName:  "setOnDeeplinkResponseListener", args:  val_40);
            }
            
            val_58 = null;
            val_58 = null;
            object[] val_41 = new object[1];
            if(val_41 == null)
            {
                goto label_174;
            }
            
            if(val_5 != null)
            {
                goto label_175;
            }
            
            goto label_178;
            label_174:
            if(val_5 == null)
            {
                goto label_178;
            }
            
            label_175:
            label_178:
            val_41[0] = val_5;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onCreate", args:  val_41);
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onResume", args:  System.Array.Empty<System.Object>());
        }
        public static void TrackEvent(com.adjust.sdk.AdjustEvent adjustEvent)
        {
            System.Collections.Generic.List<System.String> val_15;
            var val_16;
            var val_17;
            object val_18;
            System.Collections.Generic.List<System.String> val_19;
            var val_20;
            var val_21;
            object[] val_1 = new object[1];
            val_1[0] = adjustEvent.eventToken;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustEvent", args:  val_1);
            if((adjustEvent.revenue & 1) != 0)
            {
                    object[] val_3 = new object[2];
                val_3[0] = ???;
                val_3[1] = adjustEvent.currency;
                val_2.Call(methodName:  "setRevenue", args:  val_3);
            }
            
            val_15 = adjustEvent.callbackList;
            if(val_15 == null)
            {
                goto label_15;
            }
            
            val_16 = 1152921509342334928;
            val_17 = 0;
            goto label_16;
            label_30:
            string val_4 = adjustEvent.callbackList.Item[0];
            val_18 = adjustEvent.callbackList.Item[1];
            object[] val_6 = new object[2];
            if(val_6 == null)
            {
                goto label_19;
            }
            
            if(val_4 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(val_4 == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            val_6[0] = val_4;
            val_6[1] = val_18;
            val_2.Call(methodName:  "addCallbackParameter", args:  val_6);
            val_15 = adjustEvent.callbackList;
            val_17 = 1 + 1;
            label_16:
            if(val_17 < val_15.Count)
            {
                goto label_30;
            }
            
            label_15:
            val_19 = adjustEvent.partnerList;
            if(val_19 == null)
            {
                goto label_31;
            }
            
            val_16 = 1152921509342334928;
            val_20 = 0;
            goto label_32;
            label_46:
            string val_8 = adjustEvent.partnerList.Item[0];
            val_18 = adjustEvent.partnerList.Item[1];
            object[] val_10 = new object[2];
            if(val_10 == null)
            {
                goto label_35;
            }
            
            if(val_8 != null)
            {
                goto label_36;
            }
            
            goto label_39;
            label_35:
            if(val_8 == null)
            {
                goto label_39;
            }
            
            label_36:
            label_39:
            val_10[0] = val_8;
            val_10[1] = val_18;
            val_2.Call(methodName:  "addPartnerParameter", args:  val_10);
            val_19 = adjustEvent.partnerList;
            val_20 = 1 + 1;
            label_32:
            if(val_20 < val_19.Count)
            {
                goto label_46;
            }
            
            label_31:
            if(adjustEvent.transactionId != null)
            {
                    object[] val_12 = new object[1];
                val_12[0] = adjustEvent.transactionId;
                val_2.Call(methodName:  "setOrderId", args:  val_12);
            }
            
            if(adjustEvent.callbackId != null)
            {
                    object[] val_13 = new object[1];
                val_13[0] = adjustEvent.callbackId;
                val_2.Call(methodName:  "setCallbackId", args:  val_13);
            }
            
            val_21 = null;
            val_21 = null;
            object[] val_14 = new object[1];
            val_14[0] = val_2;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "trackEvent", args:  val_14);
        }
        public static bool IsEnabled()
        {
            null = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust != null)
            {
                    return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.Boolean>(methodName:  "isEnabled", args:  System.Array.Empty<System.Object>());
            }
            
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.Boolean>(methodName:  "isEnabled", args:  System.Array.Empty<System.Object>());
        }
        public static void SetEnabled(bool enabled)
        {
            var val_3;
            bool val_1 = enabled;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setEnabled", args:  val_2);
        }
        public static void SetOfflineMode(bool enabled)
        {
            var val_3;
            bool val_1 = enabled;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setOfflineMode", args:  val_2);
        }
        public static void SendFirstPackages()
        {
            null = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "sendFirstPackages", args:  System.Array.Empty<System.Object>());
        }
        public static void SetDeviceToken(string deviceToken)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(deviceToken != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(deviceToken == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = deviceToken;
            val_1[1] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setPushToken", args:  val_1);
        }
        public static string GetAdid()
        {
            null = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust != null)
            {
                    return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getAdid", args:  System.Array.Empty<System.Object>());
            }
            
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getAdid", args:  System.Array.Empty<System.Object>());
        }
        public static void GdprForgetMe()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "gdprForgetMe", args:  val_1);
        }
        public static void DisableThirdPartySharing()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "disableThirdPartySharing", args:  val_1);
        }
        public static com.adjust.sdk.AdjustAttribution GetAttribution()
        {
            var val_28;
            object val_29;
            var val_30;
            string val_31;
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
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            val_28 = null;
            val_28 = null;
            UnityEngine.AndroidJavaObject val_2 = com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getAttribution", args:  System.Array.Empty<System.Object>());
            if(val_2 == null)
            {
                goto label_4;
            }
            
            val_29 = new com.adjust.sdk.AdjustAttribution();
            val_29 = new System.Object();
            val_30 = null;
            val_30 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName), b:  "")) == false)
            {
                goto label_7;
            }
            
            val_31 = 0;
            if(val_29 != null)
            {
                goto label_12;
            }
            
            goto label_9;
            label_7:
            val_32 = null;
            val_32 = null;
            val_31 = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
            if(val_29 != null)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            .<trackerName>k__BackingField = val_31;
            val_33 = null;
            val_33 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken), b:  "")) != false)
            {
                    val_34 = 0;
            }
            else
            {
                    val_35 = null;
                val_35 = null;
            }
            
            .<trackerToken>k__BackingField = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
            val_36 = null;
            val_36 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork), b:  "")) != false)
            {
                    val_37 = 0;
            }
            else
            {
                    val_38 = null;
                val_38 = null;
            }
            
            .<network>k__BackingField = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
            val_39 = null;
            val_39 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign), b:  "")) != false)
            {
                    val_40 = 0;
            }
            else
            {
                    val_41 = null;
                val_41 = null;
            }
            
            .<campaign>k__BackingField = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
            val_42 = null;
            val_42 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup), b:  "")) != false)
            {
                    val_43 = 0;
            }
            else
            {
                    val_44 = null;
                val_44 = null;
            }
            
            .<adgroup>k__BackingField = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
            val_45 = null;
            val_45 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative), b:  "")) != false)
            {
                    val_46 = 0;
            }
            else
            {
                    val_47 = null;
                val_47 = null;
            }
            
            .<creative>k__BackingField = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
            val_48 = null;
            val_48 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel), b:  "")) != false)
            {
                    val_49 = 0;
            }
            else
            {
                    val_50 = null;
                val_50 = null;
            }
            
            .<clickLabel>k__BackingField = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
            val_51 = null;
            val_51 = null;
            if((System.String.op_Equality(a:  val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != false)
            {
                    val_52 = 0;
            }
            else
            {
                    val_53 = null;
                val_53 = null;
                string val_27 = val_2.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            }
            
            .<adid>k__BackingField = val_27;
            return (com.adjust.sdk.AdjustAttribution)val_29;
            label_4:
            val_29 = 0;
            return (com.adjust.sdk.AdjustAttribution)val_29;
        }
        public static void AddSessionPartnerParameter(string key, string value)
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[2];
            val_2[0] = key;
            val_2[1] = value;
            val_1.CallStatic(methodName:  "addSessionPartnerParameter", args:  val_2);
        }
        public static void AddSessionCallbackParameter(string key, string value)
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[2];
            val_2[0] = key;
            val_2[1] = value;
            val_1.CallStatic(methodName:  "addSessionCallbackParameter", args:  val_2);
        }
        public static void RemoveSessionPartnerParameter(string key)
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = key;
            val_1.CallStatic(methodName:  "removeSessionPartnerParameter", args:  val_2);
        }
        public static void RemoveSessionCallbackParameter(string key)
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = key;
            val_1.CallStatic(methodName:  "removeSessionCallbackParameter", args:  val_2);
        }
        public static void ResetSessionPartnerParameters()
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            val_1.CallStatic(methodName:  "resetSessionPartnerParameters", args:  System.Array.Empty<System.Object>());
        }
        public static void ResetSessionCallbackParameters()
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            val_1.CallStatic(methodName:  "resetSessionCallbackParameters", args:  System.Array.Empty<System.Object>());
        }
        public static void AppWillOpenUrl(string url)
        {
            var val_5;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(url != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(url == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = url;
            UnityEngine.AndroidJavaObject val_3 = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri").CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "parse", args:  val_2);
            val_5 = null;
            val_5 = null;
            object[] val_4 = new object[2];
            if(val_4 == null)
            {
                goto label_10;
            }
            
            if(val_3 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_3 == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_4[0] = val_3;
            val_4[1] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "appWillOpenUrl", args:  val_4);
        }
        public static void TrackAdRevenue(string source, string payload)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_6 = null;
                val_6 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = payload;
            val_7 = null;
            val_7 = null;
            object[] val_4 = new object[2];
            val_4[0] = source;
            val_4[1] = new UnityEngine.AndroidJavaObject(className:  "org.json.JSONObject", args:  val_2);
            val_1.CallStatic(methodName:  "trackAdRevenue", args:  val_4);
        }
        public static void OnPause()
        {
            null = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onPause", args:  System.Array.Empty<System.Object>());
        }
        public static void OnResume()
        {
            null = null;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onResume", args:  System.Array.Empty<System.Object>());
        }
        public static void SetReferrer(string referrer)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(referrer != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(referrer == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = referrer;
            val_1[1] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setReferrer", args:  val_1);
        }
        public static void GetGoogleAdId(System.Action<string> onDeviceIdsRead)
        {
            var val_3 = null;
            object[] val_2 = new object[2];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            val_2[1] = new AdjustAndroid.DeviceIdsReadListener(pCallback:  onDeviceIdsRead);
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "getGoogleAdId", args:  val_2);
        }
        public static string GetAmazonAdId()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust != null)
            {
                    return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getAmazonAdId", args:  val_1);
            }
            
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getAmazonAdId", args:  val_1);
        }
        public static string GetSdkVersion()
        {
            null = null;
            return "unity4.20.0@" + com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>())(com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>()));
        }
        public static void SetTestOptions(System.Collections.Generic.Dictionary<string, string> testOptions)
        {
            null = null;
            UnityEngine.AndroidJavaObject val_1 = com.adjust.sdk.AdjustUtils.TestOptionsMap2AndroidJavaObject(testOptionsMap:  testOptions, ajoCurrentActivity:  com.adjust.sdk.AdjustAndroid.ajoCurrentActivity);
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_5;
            }
            
            if(val_1 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_1 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_2[0] = val_1;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setTestOptions", args:  val_2);
        }
        private static bool IsAppSecretSet(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            if((adjustConfig.secretId & 1) == 0)
            {
                    return false;
            }
            
            if((adjustConfig.info1 & 1) == 0)
            {
                    return false;
            }
            
            if((adjustConfig.info2 & 1) == 0)
            {
                    return false;
            }
            
            if((adjustConfig.info3 & 1) == 0)
            {
                    return false;
            }
            
            adjustConfig = ???;
            return false;
        }
        public AdjustAndroid()
        {
        
        }
        private static AdjustAndroid()
        {
            com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink = true;
            com.adjust.sdk.AdjustAndroid.ajcAdjust = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
            com.adjust.sdk.AdjustAndroid.ajoCurrentActivity = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
    
    }

}
