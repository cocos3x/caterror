using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustUtils
    {
        // Fields
        public static string KeyAdid;
        public static string KeyMessage;
        public static string KeyNetwork;
        public static string KeyAdgroup;
        public static string KeyCampaign;
        public static string KeyCreative;
        public static string KeyWillRetry;
        public static string KeyTimestamp;
        public static string KeyCallbackId;
        public static string KeyEventToken;
        public static string KeyClickLabel;
        public static string KeyTrackerName;
        public static string KeyTrackerToken;
        public static string KeyJsonResponse;
        public static string KeyTestOptionsBaseUrl;
        public static string KeyTestOptionsGdprUrl;
        public static string KeyTestOptionsBasePath;
        public static string KeyTestOptionsGdprPath;
        public static string KeyTestOptionsDeleteState;
        public static string KeyTestOptionsUseTestConnectionOptions;
        public static string KeyTestOptionsTimerIntervalInMilliseconds;
        public static string KeyTestOptionsTimerStartInMilliseconds;
        public static string KeyTestOptionsSessionIntervalInMilliseconds;
        public static string KeyTestOptionsSubsessionIntervalInMilliseconds;
        public static string KeyTestOptionsTeardown;
        public static string KeyTestOptionsNoBackoffWait;
        public static string KeyTestOptionsiAdFrameworkEnabled;
        
        // Methods
        public static int ConvertLogLevel(System.Nullable<com.adjust.sdk.AdjustLogLevel> logLevel)
        {
            var val_1;
            if(((-725267048) & 1) != 0)
            {
                    return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public static int ConvertBool(System.Nullable<bool> value)
        {
            var val_1;
            if(((-725155044) & 1) != 0)
            {
                    val_1 = 0;
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public static double ConvertDouble(System.Nullable<double> value)
        {
            if(( & 1) == 0)
            {
                    return -1;
            }
            
            return -1;
        }
        public static long ConvertLong(System.Nullable<long> value)
        {
            var val_1;
            if(( & 1) != 0)
            {
                    val_1;
                return (long)val_1;
            }
            
            val_1 = 0;
            return (long)val_1;
        }
        public static string ConvertListToJson(System.Collections.Generic.List<string> list)
        {
            var val_5;
            var val_6;
            var val_7;
            if(list == null)
            {
                goto label_1;
            }
            
            com.adjust.sdk.JSONArray val_1 = null;
            val_5 = val_1;
            val_1 = new com.adjust.sdk.JSONArray();
            List.Enumerator<T> val_2 = list.GetEnumerator();
            label_4:
            if(((-724802728) & 1) == 0)
            {
                goto label_2;
            }
            
            new com.adjust.sdk.JSONData() = new System.Object();
            .m_Data = 0.Id;
            val_1.Add(aItem:  new com.adjust.sdk.JSONData());
            goto label_4;
            label_1:
            val_6 = 0;
            return (string)val_6;
            label_2:
            val_7 = public System.Void List.Enumerator<System.String>::Dispose();
            UniRx.Unit..cctor();
            val_6 = val_5;
            return (string)val_6;
        }
        public static string GetJsonResponseCompact(System.Collections.Generic.Dictionary<string, object> dictionary)
        {
            var val_5;
            string val_23;
            string val_24;
            string val_25;
            var val_26;
            string val_27;
            string val_28;
            string val_29;
            val_23 = dictionary;
            val_24 = "";
            if(val_23 == null)
            {
                    return (string)val_29 + "}";
            }
            
            val_25 = val_24 + "{";
            Dictionary.Enumerator<TKey, TValue> val_2 = val_23.GetEnumerator();
            var val_22 = 0;
            label_51:
            if(((-724616880) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_6 = val_5.Current;
            if(val_6.Value != 0)
            {
                    if(val_6.Value == null)
            {
                goto label_4;
            }
            
            }
            
            val_26 = 0;
            goto label_7;
            label_4:
            val_22 = val_22 + 1;
            if(val_22 >= 2)
            {
                goto label_8;
            }
            
            val_27 = val_25;
            goto label_9;
            label_7:
            val_22 = val_22 + 1;
            if(val_22 >= 2)
            {
                    val_28 = val_25 + ",";
            }
            
            string val_11 = val_28 + "\"" + val_6.Value.Id + "\":"("\":")(val_28 + "\"" + val_6.Value.Id + "\":"("\":")) + ;
            goto label_51;
            label_8:
            val_27 = val_25 + ",";
            label_9:
            if(((val_6.Value.StartsWith(value:  "{")) == false) || ((val_6.Value.EndsWith(value:  "}")) == false))
            {
                goto label_16;
            }
            
            string[] val_15 = new string[5];
            val_15[0] = val_27;
            val_15[1] = "\"";
            val_15[2] = val_6.Value.Id;
            val_15[3] = "\":";
            val_15[4] = ;
            string val_17 = +val_15;
            goto label_51;
            label_16:
            string[] val_18 = new string[6];
            val_18[0] = val_27;
            val_18[1] = "\"";
            val_18[2] = val_6.Value.Id;
            val_18[3] = "\":\"";
            val_18[4] = ;
            val_18[5] = "\"";
            string val_20 = +val_18;
            goto label_51;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_29 + "}";
        }
        public static string GetJsonString(com.adjust.sdk.JSONNode node, string key)
        {
            if((com.adjust.sdk.JSONNode.op_Equality(a:  node, b:  0)) == true)
            {
                    return 0;
            }
            
            key = 0;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  null, b:  0)) == true)
            {
                    return 0;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  null, b:  "")) != false)
            {
                    return 0;
            }
        
        }
        public static void WriteJsonResponseDictionary(com.adjust.sdk.JSONClass jsonObject, System.Collections.Generic.Dictionary<string, object> output)
        {
            var val_11;
            var val_12;
            System.Collections.IEnumerator val_1 = jsonObject.GetEnumerator();
            label_25:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_1.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            string val_7 = null.Id;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  null, b:  0)) == false)
            {
                goto label_17;
            }
            
            output.Add(key:  val_7, value:  null);
            goto label_25;
            label_17:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            output.Add(key:  val_7, value:  null);
            goto label_25;
            label_7:
            val_11 = 0;
            val_12 = 0;
            if(val_1 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_1.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        public static string TryGetValue(System.Collections.Generic.Dictionary<string, string> dictionary, string key)
        {
            var val_5;
            string val_1 = 0;
            if((dictionary.TryGetValue(key:  key, value: out  val_1)) != false)
            {
                    var val_4 = ((System.String.op_Equality(a:  val_1, b:  "")) != true) ? 0 : (val_1);
                return (string)val_5;
            }
            
            val_5 = 0;
            return (string)val_5;
        }
        public static UnityEngine.AndroidJavaObject TestOptionsMap2AndroidJavaObject(System.Collections.Generic.Dictionary<string, string> testOptionsMap, UnityEngine.AndroidJavaObject ajoCurrentActivity)
        {
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            string val_74;
            var val_75;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustTestOptions", args:  System.Array.Empty<System.Object>());
            val_54 = null;
            val_54 = null;
            val_2.Set<System.String>(fieldName:  "baseUrl", val:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsBaseUrl]);
            val_2.Set<System.String>(fieldName:  "gdprUrl", val:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprUrl]);
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsBasePath)) != false)
            {
                    val_55 = null;
                val_55 = null;
                if((System.String.IsNullOrEmpty(value:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsBasePath])) != true)
            {
                    val_56 = null;
                val_56 = null;
                val_2.Set<System.String>(fieldName:  "basePath", val:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsBasePath]);
            }
            
            }
            
            val_57 = null;
            val_57 = null;
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprPath)) != false)
            {
                    val_58 = null;
                val_58 = null;
                if((System.String.IsNullOrEmpty(value:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprPath])) != true)
            {
                    val_59 = null;
                val_59 = null;
                val_2.Set<System.String>(fieldName:  "gdprPath", val:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprPath]);
            }
            
            }
            
            val_60 = null;
            val_60 = null;
            if((ajoCurrentActivity != null) && ((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsDeleteState)) != false))
            {
                    val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "context", val:  ajoCurrentActivity);
            }
            
            val_61 = null;
            val_61 = null;
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsUseTestConnectionOptions)) != false)
            {
                    val_62 = null;
                val_62 = null;
                object[] val_19 = new object[1];
                val_19[0] = System.String.op_Equality(a:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsUseTestConnectionOptions].ToLower(), b:  "true");
                val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "useTestConnectionOptions", val:  new UnityEngine.AndroidJavaObject(className:  "java.lang.Boolean", args:  val_19));
            }
            
            val_63 = null;
            val_63 = null;
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerIntervalInMilliseconds)) != false)
            {
                    val_64 = null;
                val_64 = null;
                object[] val_24 = new object[1];
                val_24[0] = System.Int64.Parse(s:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerIntervalInMilliseconds]);
                val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "timerIntervalInMilliseconds", val:  new UnityEngine.AndroidJavaObject(className:  "java.lang.Long", args:  val_24));
            }
            
            val_65 = null;
            val_65 = null;
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerStartInMilliseconds)) != false)
            {
                    val_66 = null;
                val_66 = null;
                object[] val_29 = new object[1];
                val_29[0] = System.Int64.Parse(s:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerStartInMilliseconds]);
                val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "timerStartInMilliseconds", val:  new UnityEngine.AndroidJavaObject(className:  "java.lang.Long", args:  val_29));
            }
            
            val_67 = null;
            val_67 = null;
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsSessionIntervalInMilliseconds)) != false)
            {
                    val_68 = null;
                val_68 = null;
                object[] val_34 = new object[1];
                val_34[0] = System.Int64.Parse(s:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsSessionIntervalInMilliseconds]);
                val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "sessionIntervalInMilliseconds", val:  new UnityEngine.AndroidJavaObject(className:  "java.lang.Long", args:  val_34));
            }
            
            val_69 = null;
            val_69 = null;
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsSubsessionIntervalInMilliseconds)) != false)
            {
                    val_70 = null;
                val_70 = null;
                object[] val_39 = new object[1];
                val_39[0] = System.Int64.Parse(s:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsSubsessionIntervalInMilliseconds]);
                val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "subsessionIntervalInMilliseconds", val:  new UnityEngine.AndroidJavaObject(className:  "java.lang.Long", args:  val_39));
            }
            
            val_71 = null;
            val_71 = null;
            if((testOptionsMap.ContainsKey(key:  com.adjust.sdk.AdjustUtils.KeyTestOptionsTeardown)) != false)
            {
                    val_72 = null;
                val_72 = null;
                object[] val_46 = new object[1];
                val_46[0] = System.String.op_Equality(a:  testOptionsMap.Item[com.adjust.sdk.AdjustUtils.KeyTestOptionsTeardown].ToLower(), b:  "true");
                val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "teardown", val:  new UnityEngine.AndroidJavaObject(className:  "java.lang.Boolean", args:  val_46));
            }
            
            val_73 = null;
            val_73 = null;
            val_74 = com.adjust.sdk.AdjustUtils.KeyTestOptionsNoBackoffWait;
            if((testOptionsMap.ContainsKey(key:  val_74)) == false)
            {
                    return val_2;
            }
            
            val_75 = null;
            val_75 = null;
            string val_54 = com.adjust.sdk.AdjustUtils.KeyTestOptionsNoBackoffWait;
            val_54 = System.String.op_Equality(a:  testOptionsMap.Item[val_54].ToLower(), b:  "true");
            object[] val_52 = new object[1];
            val_52[0] = val_54;
            UnityEngine.AndroidJavaObject val_53 = null;
            val_74 = val_53;
            val_53 = new UnityEngine.AndroidJavaObject(className:  "java.lang.Boolean", args:  val_52);
            val_2.Set<UnityEngine.AndroidJavaObject>(fieldName:  "noBackoffWait", val:  val_53);
            return val_2;
        }
        public AdjustUtils()
        {
        
        }
        private static AdjustUtils()
        {
            com.adjust.sdk.AdjustUtils.KeyAdid = "adid";
            com.adjust.sdk.AdjustUtils.KeyMessage = "message";
            com.adjust.sdk.AdjustUtils.KeyNetwork = "network";
            com.adjust.sdk.AdjustUtils.KeyAdgroup = "adgroup";
            com.adjust.sdk.AdjustUtils.KeyCampaign = "campaign";
            com.adjust.sdk.AdjustUtils.KeyCreative = "creative";
            com.adjust.sdk.AdjustUtils.KeyWillRetry = "willRetry";
            com.adjust.sdk.AdjustUtils.KeyTimestamp = "timestamp";
            com.adjust.sdk.AdjustUtils.KeyCallbackId = "callbackId";
            com.adjust.sdk.AdjustUtils.KeyEventToken = "eventToken";
            com.adjust.sdk.AdjustUtils.KeyClickLabel = "clickLabel";
            com.adjust.sdk.AdjustUtils.KeyTrackerName = "trackerName";
            com.adjust.sdk.AdjustUtils.KeyTrackerToken = "trackerToken";
            com.adjust.sdk.AdjustUtils.KeyJsonResponse = "jsonResponse";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsBaseUrl = "baseUrl";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprUrl = "gdprUrl";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsBasePath = "basePath";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsGdprPath = "gdprPath";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsDeleteState = "deleteState";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsUseTestConnectionOptions = "useTestConnectionOptions";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerIntervalInMilliseconds = "timerIntervalInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsTimerStartInMilliseconds = "timerStartInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsSessionIntervalInMilliseconds = "sessionIntervalInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsSubsessionIntervalInMilliseconds = "subsessionIntervalInMilliseconds";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsTeardown = "teardown";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsNoBackoffWait = "noBackoffWait";
            com.adjust.sdk.AdjustUtils.KeyTestOptionsiAdFrameworkEnabled = "iAdFrameworkEnabled";
        }
    
    }

}
