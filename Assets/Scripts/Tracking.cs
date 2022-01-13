using UnityEngine;
public class Tracking : MonoBehaviour
{
    // Fields
    private static Tracking _instance;
    
    // Properties
    public static Tracking Instance { get; }
    
    // Methods
    public static Tracking get_Instance()
    {
        var val_10;
        Tracking val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = null;
        val_10 = null;
        val_11 = Tracking._instance;
        if((UnityEngine.Object.op_Implicit(exists:  val_11)) != true)
        {
                val_12 = null;
            val_11 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_12 = null;
            val_13 = 0;
            Tracking._instance = ;
            if((UnityEngine.Object.op_Implicit(exists:  Tracking._instance)) != true)
        {
                val_14 = null;
            val_11 = new UnityEngine.GameObject(name:  "Tracking").AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_14 = null;
            val_15 = 0;
            Tracking._instance = ;
        }
        
        }
        
        val_16 = null;
        val_16 = null;
        return (Tracking)Tracking._instance;
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    public static UnityEngine.AndroidJavaObject getApplicationContext()
    {
        var val_7;
        var val_8;
        var val_10;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_7 = 0;
        val_8 = 0;
        if(val_2 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_2.Dispose();
        }
        
        if(val_7 == 1)
        {
            goto label_8;
        }
        
        val_10 = val_8;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_8 != 0)
        {
                val_8 = 0;
        }
        
        val_10 = 0;
        val_7 = 0;
        if(val_1 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_1.Dispose();
        label_12:
        if(val_7 != 1)
        {
                return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationContext", args:  System.Array.Empty<System.Object>());
        }
        
        if(val_10 == 0)
        {
                return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationContext", args:  System.Array.Empty<System.Object>());
        }
        
        return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationContext", args:  System.Array.Empty<System.Object>());
    }
    public void init(string appKey, string channelId)
    {
        var val_12;
        var val_13;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_12 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        object[] val_2 = new object[3];
        val_2[0] = Tracking.getApplicationContext();
        val_2[1] = appKey;
        val_2[2] = channelId;
        val_1.CallStatic(methodName:  "initWithKeyAndChannelId", args:  val_2);
        val_13 = 0;
        if(val_12 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_1.Dispose();
        }
        
        if(val_13 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_12 = ???;
        val_13 = ???;
    }
    public void register(string account)
    {
        var val_9;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        object[] val_2 = new object[1];
        val_2[0] = account;
        val_1.CallStatic(methodName:  "setRegisterWithAccountID", args:  val_2);
        if(val_9 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_9 = ???;
    }
    public void login(string account)
    {
        var val_9;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        object[] val_2 = new object[1];
        val_2[0] = account;
        val_1.CallStatic(methodName:  "setLoginSuccessBusiness", args:  val_2);
        if(val_9 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_9 = ???;
    }
    public void setryzfStart(string ryTID, string ryzfType, string hbType, float hbAmount)
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        object[] val_2 = new object[4];
        val_2[0] = ryTID;
        val_2[1] = ryzfType;
        val_2[2] = hbType;
        val_2[3] = hbAmount;
        val_1.CallStatic(methodName:  "setPaymentStart", args:  val_2);
        if(val_1 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public void setryzf(string ryTID, string ryzfType, string hbType, float hbAmount)
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        object[] val_2 = new object[4];
        val_2[0] = ryTID;
        val_2[1] = ryzfType;
        val_2[2] = hbType;
        val_2[3] = hbAmount;
        val_1.CallStatic(methodName:  "setPayment", args:  val_2);
        if(val_1 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public void setDD(string ryTID, string hbType, float hbAmount)
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        object[] val_2 = new object[3];
        val_2[0] = ryTID;
        val_2[1] = hbType;
        val_2[2] = hbAmount;
        val_1.CallStatic(methodName:  "setOrder", args:  val_2);
        if(val_1 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public void setEvent(string eventName)
    {
        var val_9;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        object[] val_2 = new object[2];
        val_2[0] = eventName;
        val_1.CallStatic(methodName:  "setEvent", args:  val_2);
        if(val_9 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_9 = ???;
    }
    public string getDeviceId()
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.sdk.Tracking");
        if(val_1 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return (string)val_1.CallStatic<System.String>(methodName:  "getDeviceId", args:  System.Array.Empty<System.Object>());
        }
        
        if(0 == 0)
        {
                return (string)val_1.CallStatic<System.String>(methodName:  "getDeviceId", args:  System.Array.Empty<System.Object>());
        }
        
        return (string)val_1.CallStatic<System.String>(methodName:  "getDeviceId", args:  System.Array.Empty<System.Object>());
    }
    public void setPrintLog(bool print)
    {
        var val_9;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.reyun.tracking.common.ReYunConst");
        val_1.SetStatic<System.Boolean>(fieldName:  "DebugMode", val:  print);
        if(val_9 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_9 = ???;
    }
    public Tracking()
    {
    
    }
    private static Tracking()
    {
    
    }

}
