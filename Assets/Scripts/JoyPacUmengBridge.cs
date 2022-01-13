using UnityEngine;
public class JoyPacUmengBridge
{
    // Fields
    public static JoyPacUmengBridge joyPacUmengBridge;
    private UnityEngine.AndroidJavaObject unityUmengBridgeManager;
    
    // Methods
    private JoyPacUmengBridge()
    {
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        this.unityUmengBridgeManager = new UnityEngine.AndroidJavaObject(className:  "com.joypac.unityumengbridge.UnityUmengBridge", args:  System.Array.Empty<System.Object>());
    }
    public static JoyPacUmengBridge getInstance()
    {
        null = null;
        return (JoyPacUmengBridge)JoyPacUmengBridge.joyPacUmengBridge;
    }
    public void initOnlineConfig()
    {
        UnityEngine.Debug.Log(message:  "initOnlineConfig strat");
        this.unityUmengBridgeManager.Call(methodName:  "uMenginitOnlineConfig", args:  System.Array.Empty<System.Object>());
        UnityEngine.Debug.Log(message:  "initOnlineConfig end");
    }
    public string getConfigParamsJson(string key)
    {
        UnityEngine.Debug.Log(message:  "getConfigParamsJson strat");
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(key != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(key == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = key;
        string val_2 = this.unityUmengBridgeManager.Call<System.String>(methodName:  "uMengGetParamJson", args:  val_1);
        UnityEngine.Debug.Log(message:  "getConfigParamsJson end value:"("getConfigParamsJson end value:") + val_2);
        return val_2;
    }
    public void uMengEventWithLabel(string eventName, string label)
    {
        UnityEngine.Debug.Log(message:  "uMengEventWithLabel");
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(eventName != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(eventName == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = eventName;
        val_1[1] = label;
        this.unityUmengBridgeManager.Call(methodName:  "uMengEventWithLabel", args:  val_1);
    }
    public void uMengEventWithAttributes(string eventName, string jsonStr)
    {
        UnityEngine.Debug.Log(message:  "uMengEventWithAttributes");
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(eventName != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(eventName == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = eventName;
        val_1[1] = jsonStr;
        this.unityUmengBridgeManager.Call(methodName:  "uMengEventWithAttributes", args:  val_1);
    }
    private static JoyPacUmengBridge()
    {
        JoyPacUmengBridge.joyPacUmengBridge = new JoyPacUmengBridge();
    }

}
