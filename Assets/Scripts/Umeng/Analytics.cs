using UnityEngine;

namespace Umeng
{
    public class Analytics
    {
        // Fields
        private static bool hasInit;
        protected static UnityEngine.AndroidJavaClass UMConfigure;
        protected static UnityEngine.AndroidJavaClass Agent;
        protected static UnityEngine.AndroidJavaObject Context;
        private const string Version = "3.2";
        
        // Methods
        public static void StartWithAppKeyAndChannelId(string appKey, string channelId)
        {
            Umeng.Analytics.UMCommonSetAppkeyAndChannel(appkey:  appKey, channelId:  channelId, deviceType:  0, pushSecret:  0);
            object[] val_1 = new object[1];
            val_1[0] = Umeng.Analytics.Context;
            Umeng.Analytics.Agent.CallStatic(methodName:  "init", args:  val_1);
            if(Umeng.Analytics.Version != null)
            {
                    return;
            }
            
            Umeng.Analytics.onResume();
            Umeng.Analytics.AddUmengAndroidLifeCycleCallBack();
            Umeng.Analytics.Version = 1;
        }
        private static void UMCommonSetAppkeyAndChannel(string appkey, string channelId, Umeng.Analytics.DeviceType deviceType = 0, string pushSecret)
        {
            null = null;
            object[] val_1 = new object[2];
            val_1[0] = "Unity";
            val_1[1] = "3.2";
            Umeng.Analytics.UMConfigure.CallStatic(methodName:  "setWraperType", args:  val_1);
            object[] val_2 = new object[5];
            if(val_2 == null)
            {
                goto label_11;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(Umeng.Analytics.Context == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_2[0] = Umeng.Analytics.Context;
            val_2[1] = appkey;
            val_2[2] = channelId;
            val_2[3] = deviceType;
            val_2[4] = pushSecret;
            Umeng.Analytics.UMConfigure.CallStatic(methodName:  "init", args:  val_2);
        }
        public static void SetLogEnabled(bool value)
        {
            var val_3;
            bool val_1 = value;
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
            Umeng.Analytics.UMConfigure.CallStatic(methodName:  "setLogEnabled", args:  val_2);
        }
        public static void Event(string eventId)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            val_1[1] = eventId;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onEvent", args:  val_1);
        }
        public static void Event(string eventId, string label)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            val_1[1] = eventId;
            val_1[2] = label;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onEvent", args:  val_1);
        }
        public static void Event(string eventId, System.Collections.Generic.Dictionary<string, string> attributes)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            val_1[1] = eventId;
            val_1[2] = Umeng.Analytics.ToJavaHashMap(dic:  attributes);
            Umeng.Analytics.Agent.CallStatic(methodName:  "onEvent", args:  val_1);
        }
        public static void PageBegin(string pageName)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(pageName != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(pageName == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = pageName;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onPageStart", args:  val_1);
        }
        public static void PageEnd(string pageName)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(pageName != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(pageName == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = pageName;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onPageEnd", args:  val_1);
        }
        public static void Event(string eventId, System.Collections.Generic.Dictionary<string, string> attributes, int value)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_6;
            string val_7;
            val_6 = attributes;
            if(val_6 == null)
            {
                    val_6 = null;
                val_6 = new System.Collections.Generic.Dictionary<System.String, System.String>();
                if(val_6 == null)
            {
                goto label_12;
            }
            
            }
            
            label_12:
            if((null.ContainsKey(key:  "__ct__")) != false)
            {
                    val_7 = value.ToString();
                null.set_Item(key:  "__ct__", value:  val_7);
                Umeng.Analytics.Event(eventId:  eventId, attributes:  null);
                return;
            }
            
            val_7 = value.ToString();
            null.Add(key:  "__ct__", value:  val_7);
            Umeng.Analytics.Event(eventId:  eventId, attributes:  null);
            bool val_5 = null.Remove(key:  "__ct__");
        }
        public static string GetTestDeviceInfo()
        {
            var val_3;
            UnityEngine.Debug.Log(message:  "GetDeviceInfo return ");
            val_3 = null;
            val_3 = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_5;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(Umeng.Analytics.Context == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_1[0] = Umeng.Analytics.Context;
            return (string)Umeng.Analytics.UMConfigure.CallStatic<System.String[]>(methodName:  "getTestDeviceInfo", args:  val_1)[0];
        }
        public static void SetLogEncryptEnabled(bool value)
        {
            var val_3;
            bool val_1 = value;
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
            Umeng.Analytics.UMConfigure.CallStatic(methodName:  "setEncryptEnabled", args:  val_2);
        }
        public static void SetLatency(int value)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if((long)value != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if((long)value == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = (long)value;
            Umeng.Analytics.Agent.CallStatic(methodName:  "setLatencyWindow", args:  val_1);
        }
        public static void SetContinueSessionMillis(long milliseconds)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(milliseconds != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(milliseconds == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = milliseconds;
            Umeng.Analytics.Agent.CallStatic(methodName:  "setSessionContinueMillis", args:  val_1);
        }
        public static void SetCheckDevice(bool value)
        {
            var val_3;
            bool val_1 = value;
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
            Umeng.Analytics.Agent.CallStatic(methodName:  "setCheckDevice", args:  val_2);
        }
        private static void AddUmengAndroidLifeCycleCallBack()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            if(val_1 != null)
            {
                    UmengAndroidLifeCycleCallBack val_2 = val_1.AddComponent<UmengAndroidLifeCycleCallBack>();
            }
            else
            {
                    UmengAndroidLifeCycleCallBack val_3 = val_1.AddComponent<UmengAndroidLifeCycleCallBack>();
            }
            
            val_1.name = "UmengManager";
        }
        public static void onResume()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onResume", args:  val_1);
        }
        public static void onPause()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onPause", args:  val_1);
        }
        public static void onKillProcess()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onKillProcess", args:  val_1);
        }
        private static UnityEngine.AndroidJavaObject AndroidJavaJsonObject(Umeng.JSONObject jSONObject)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(jSONObject != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(jSONObject == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = jSONObject;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "org.json.JSONObject", args:  val_1);
        }
        private static Umeng.JSONObject jsonObjectFromJava(UnityEngine.AndroidJavaObject androidJavaJsonObject)
        {
            var val_6;
            if((Umeng.JSONNode.Parse(aJSON:  androidJavaJsonObject.Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()))) == null)
            {
                    return (Umeng.JSONObject)val_6;
            }
            
            val_6 = 0;
            return (Umeng.JSONObject)val_6;
        }
        private static UnityEngine.AndroidJavaObject ToJavaObject(object obj)
        {
            object val_11;
            System.Object[] val_12;
            var val_13;
            string val_15;
            val_11 = obj;
            if(val_11 == null)
            {
                goto label_1;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                goto label_6;
            }
            
            if(null != null)
            {
                goto label_7;
            }
            
            val_12 = new object[1];
            int val_2 = System.Convert.ToInt32(value:  false);
            val_11 = val_2;
            if(val_2 != 0)
            {
                goto label_16;
            }
            
            goto label_17;
            label_1:
            label_7:
            UnityEngine.Debug.Log(message:  "不支持加入" + val_11.GetType() + "类型,此kv对被丢弃");
            val_13 = 0;
            return (UnityEngine.AndroidJavaObject)val_13;
            label_2:
            val_12 = new object[1];
            label_16:
            label_17:
            val_12[0] = val_11;
            val_15 = "java.lang.Integer";
            goto label_31;
            label_3:
            val_12 = new object[1];
            val_12[0] = val_11;
            val_15 = "java.lang.Long";
            goto label_31;
            label_4:
            val_12 = new object[1];
            val_12[0] = val_11;
            val_15 = "java.lang.Float";
            goto label_31;
            label_5:
            val_12 = new object[1];
            val_12[0] = val_11;
            val_15 = "java.lang.Double";
            goto label_31;
            label_6:
            object[] val_9 = new object[1];
            val_12 = val_9;
            val_12[0] = val_11;
            UnityEngine.AndroidJavaObject val_10 = null;
            val_15 = "java.lang.String";
            label_31:
            val_13 = val_10;
            val_10 = new UnityEngine.AndroidJavaObject(className:  val_15, args:  val_9);
            return (UnityEngine.AndroidJavaObject)val_13;
        }
        private static UnityEngine.AndroidJavaObject ToJavaHashMap(System.Collections.Generic.Dictionary<string, object> dic)
        {
            var val_6;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  System.Array.Empty<System.Object>());
            Dictionary.Enumerator<TKey, TValue> val_3 = dic.GetEnumerator();
            label_13:
            if(((-1003868656) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_7 = val_6.Current;
            UnityEngine.AndroidJavaObject val_8 = Umeng.Analytics.ToJavaObject(obj:  val_7.Value);
            if(val_8 == null)
            {
                goto label_13;
            }
            
            object[] val_9 = new object[2];
            val_9[0] = val_7.Value.Id;
            val_9[1] = val_8;
            UnityEngine.AndroidJavaObject val_11 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "put", args:  val_9);
            goto label_13;
            label_2:
            UniRx.Unit..cctor();
            return val_2;
        }
        private static UnityEngine.AndroidJavaObject ToJavaHashMap(System.Collections.Generic.Dictionary<string, string> dic)
        {
            var val_6;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  System.Array.Empty<System.Object>());
            Dictionary.Enumerator<TKey, TValue> val_3 = dic.GetEnumerator();
            label_11:
            if(((-1003637840) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_7 = val_6.Current;
            object[] val_8 = new object[2];
            val_8[0] = val_7.Value.Id;
            val_8[1] = ;
            UnityEngine.AndroidJavaObject val_10 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "put", args:  val_8);
            goto label_11;
            label_2:
            UniRx.Unit..cctor();
            return val_2;
        }
        private static UnityEngine.AndroidJavaObject ToJavaList(string[] list)
        {
            System.Object[] val_5;
            var val_6;
            val_5 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.ArrayList", args:  val_5);
            val_6 = 0;
            goto label_1;
            label_11:
            string val_5 = list[0];
            object[] val_3 = new object[1];
            val_5 = val_3;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            if(val_5 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_5 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_5[0] = val_5;
            bool val_4 = val_2.Call<System.Boolean>(methodName:  "add", args:  val_3);
            val_6 = 1;
            label_1:
            if(val_6 < list.Length)
            {
                goto label_11;
            }
            
            return val_2;
        }
        public static void EventObject(string eventID, System.Collections.Generic.Dictionary<string, object> dict)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            val_1[1] = eventID;
            val_1[2] = Umeng.Analytics.ToJavaHashMap(dic:  dict);
            Umeng.Analytics.Agent.CallStatic(methodName:  "onEventObject", args:  val_1);
        }
        public static void RegisterPreProperties(Umeng.JSONObject jsonObject)
        {
            var val_14;
            var val_15;
            var val_17;
            Umeng.JSONObject val_1 = new Umeng.JSONObject();
            System.Collections.IEnumerator val_2 = jsonObject.GetEnumerator();
            label_30:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            object val_6 = val_2.Current;
            if(( & 1) != 0)
            {
                goto label_14;
            }
            
            if(( & 1) == 0)
            {
                goto label_16;
            }
            
            label_14:
            UnityEngine.Debug.LogError(message:  "不支持加入Object/Array类型,此kv对被丢弃");
            goto label_30;
            label_16:
            if(( & 1) == 0)
            {
                goto label_21;
            }
            
            string val_7 = null.Id;
            Umeng.JSONNode val_9 = Umeng.JSONNode.op_Implicit(n:  System.Convert.ToInt32(value:  false));
            if(val_1 != null)
            {
                goto label_30;
            }
            
            goto label_30;
            label_21:
            string val_10 = null.Id;
            if(val_1 != null)
            {
                goto label_30;
            }
            
            goto label_30;
            label_7:
            val_14 = 0;
            val_15 = 0;
            if(val_2 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_2.Dispose();
            }
            
            val_17 = null;
            val_17 = null;
            object[] val_12 = new object[2];
            val_12[0] = Umeng.Analytics.Context;
            val_12[1] = Umeng.Analytics.AndroidJavaJsonObject(jSONObject:  val_1);
            Umeng.Analytics.Agent.CallStatic(methodName:  "registerPreProperties", args:  val_12);
        }
        public static void UnregisterPreProperty(string propertyName)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            val_1[1] = propertyName;
            Umeng.Analytics.Agent.CallStatic(methodName:  "unregisterPreProperty", args:  val_1);
        }
        public static Umeng.JSONObject GetPreProperties()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            return Umeng.Analytics.jsonObjectFromJava(androidJavaJsonObject:  Umeng.Analytics.Agent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getPreProperties", args:  val_1));
        }
        public static void ClearPreProperties()
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            Umeng.Analytics.Agent.CallStatic(methodName:  "clearPreProperties", args:  val_1);
        }
        public static void SetFirstLaunchEvent(string[] trackID)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(Umeng.Analytics.Context != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Umeng.Analytics.Context == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = Umeng.Analytics.Context;
            val_1[1] = Umeng.Analytics.ToJavaList(list:  trackID);
            Umeng.Analytics.Agent.CallStatic(methodName:  "setFirstLaunchEvent", args:  val_1);
        }
        public Analytics()
        {
        
        }
        private static Analytics()
        {
            Umeng.Analytics.Version = 0;
            Umeng.Analytics.UMConfigure = new UnityEngine.AndroidJavaClass(className:  "com.umeng.commonsdk.UMConfigure");
            Umeng.Analytics.Agent = new UnityEngine.AndroidJavaClass(className:  "com.umeng.analytics.game.UMGameAgent");
            Umeng.Analytics.Context = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
    
    }

}
