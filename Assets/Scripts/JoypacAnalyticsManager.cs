using UnityEngine;
public class JoypacAnalyticsManager : MonoBehaviour
{
    // Fields
    private static JoypacAnalyticsManager s_instance;
    private static bool updateEventToGA;
    public static bool isFirebaseInitSucc;
    
    // Properties
    public static JoypacAnalyticsManager Instance { get; }
    
    // Methods
    public static JoypacAnalyticsManager get_Instance()
    {
        var val_6;
        JoypacAnalyticsManager val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = JoypacAnalyticsManager.s_instance;
        if(val_7 != 0)
        {
            goto label_15;
        }
        
        val_8 = null;
        val_7 = UnityEngine.Object.FindObjectOfType<JoypacAnalyticsManager>();
        val_8 = null;
        JoypacAnalyticsManager.s_instance = val_7;
        if(JoypacAnalyticsManager.s_instance != 0)
        {
            goto label_10;
        }
        
        UnityEngine.GameObject val_4 = new UnityEngine.GameObject();
        if(val_4 == null)
        {
            goto label_11;
        }
        
        val_4.name = "JoypacAnalyticsManager";
        val_7 = val_4;
        goto label_12;
        label_10:
        UnityEngine.Debug.LogWarning(message:  "A JoypacAnalyticsManager object already exists in this scene - you should never have more than one per scene!");
        goto label_15;
        label_11:
        0.name = "JoypacAnalyticsManager";
        val_7 = 0;
        label_12:
        val_9 = null;
        val_9 = null;
        JoypacAnalyticsManager.s_instance = val_4.AddComponent<JoypacAnalyticsManager>();
        UnityEngine.Object.DontDestroyOnLoad(target:  val_7);
        label_15:
        val_10 = null;
        val_10 = null;
        return (JoypacAnalyticsManager)JoypacAnalyticsManager.s_instance;
    }
    public void Init()
    {
        this.InitUmeng();
        this.InitGA();
        this.InitAdjust();
    }
    private void InitUmeng()
    {
        JoyPacUmengBridge.getInstance().initOnlineConfig();
    }
    private void InitGA()
    {
        if((UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != 0)
        {
            goto label_5;
        }
        
        UnityEngine.GameObject val_4 = new UnityEngine.GameObject();
        if(val_4 == null)
        {
            goto label_6;
        }
        
        val_4.name = "GameAnalytics";
        goto label_7;
        label_5:
        UnityEngine.Debug.LogWarning(message:  "A GameAnalytics object already exists in this scene - you should never have more than one per scene!");
        goto label_10;
        label_6:
        0.name = "GameAnalytics";
        label_7:
        val_4.transform.parent = this.transform;
        if(val_4 != null)
        {
                GameAnalyticsSDK.Events.GA_SpecialEvents val_7 = val_4.AddComponent<GameAnalyticsSDK.Events.GA_SpecialEvents>();
        }
        else
        {
                GameAnalyticsSDK.Events.GA_SpecialEvents val_8 = val_4.AddComponent<GameAnalyticsSDK.Events.GA_SpecialEvents>();
        }
        
        GameAnalyticsSDK.GameAnalytics val_9 = val_4.AddComponent<GameAnalyticsSDK.GameAnalytics>();
        label_10:
        GameAnalyticsSDK.GameAnalytics.Initialize();
        GameAnalyticsSDK.Wrapper.GA_Wrapper.SetBuild(build:  UnityEngine.Application.version);
        GameAnalyticsSDK.Wrapper.GA_Wrapper.Initialize(gamekey:  "960dcb5804d7bc4c3e6c4ad1b6ce6997", gamesecret:  "afd89bceb9d459378c7c4ea9efa39298e467e378");
        LogTool.DebugLog(log:  "GA: init :GA_gameKey=960dcb5804d7bc4c3e6c4ad1b6ce6997GA_secretKey=afd89bceb9d459378c7c4ea9efa39298e467e378 Application.version="("GA: init :GA_gameKey=960dcb5804d7bc4c3e6c4ad1b6ce6997GA_secretKey=afd89bceb9d459378c7c4ea9efa39298e467e378 Application.version=") + UnityEngine.Application.version, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs", name:  "InitGA");
    }
    private void InitAdjust()
    {
        var val_9;
        System.Action<System.String> val_11;
        if((UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != 0)
        {
            goto label_5;
        }
        
        UnityEngine.GameObject val_4 = new UnityEngine.GameObject();
        if(val_4 == null)
        {
            goto label_6;
        }
        
        val_4.name = "Adjust";
        goto label_7;
        label_5:
        UnityEngine.Debug.LogWarning(message:  "A GameAnalytics object already exists in this scene - you should never have more than one per scene!");
        goto label_10;
        label_6:
        0.name = "Adjust";
        label_7:
        com.adjust.sdk.Adjust val_5 = val_4.AddComponent<com.adjust.sdk.Adjust>();
        label_10:
        com.adjust.sdk.imei.AdjustImei.ReadImei();
        com.adjust.sdk.oaid.AdjustOaid.ReadOaid();
        com.adjust.sdk.AdjustConfig val_6 = new com.adjust.sdk.AdjustConfig(appToken:  "z0asa8is4tts", environment:  1, allowSuppressLogLevel:  true);
        val_6.setLogLevel(logLevel:  7);
        val_9 = null;
        val_9 = null;
        val_11 = JoypacAnalyticsManager.<>c.<>9__7_0;
        if(val_11 == null)
        {
            goto label_14;
        }
        
        if(val_6 == null)
        {
            goto label_15;
        }
        
        label_19:
        val_6.setLogDelegate(logDelegate:  val_11);
        goto label_16;
        label_14:
        System.Action<System.String> val_7 = null;
        val_11 = val_7;
        val_7 = new System.Action<System.String>(object:  JoypacAnalyticsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void JoypacAnalyticsManager.<>c::<InitAdjust>b__7_0(string msg));
        JoypacAnalyticsManager.<>c.<>9__7_0 = val_11;
        if(val_6 != null)
        {
            goto label_19;
        }
        
        label_15:
        val_6.setLogDelegate(logDelegate:  val_7);
        label_16:
        val_6.setAppSecret(secretId:  1, info1:  30, info2:  206, info3:  84, info4:  247);
        val_6.setAttributionChangedDelegate(attributionChangedDelegate:  new System.Action<com.adjust.sdk.AdjustAttribution>(object:  this, method:  public System.Void JoypacAnalyticsManager::AttributionChangedCallback(com.adjust.sdk.AdjustAttribution attribution)), sceneName:  "Adjust");
        com.adjust.sdk.Adjust.start(adjustConfig:  val_6);
    }
    private void InitFirebase()
    {
    
    }
    private void LogFirstDeviceInfo()
    {
    
    }
    public static void DesignEvent(JoypacLogType _logType, string sort, string type, string position, bool onlyFirst = False, string extra = "")
    {
        var val_23;
        string val_24;
        string val_25;
        JoypacLogType val_26;
        var val_27;
        string val_28;
        string val_29;
        string val_30;
        string val_31;
        string val_32;
        val_24 = position;
        val_25 = sort;
        val_26 = _logType;
        if(((JoypacUtils.IfRemoveAds() == false) || (JoypacUtils.NoAdsAndNoRewardVideo() == false)) || ((System.String.op_Equality(a:  val_25, b:  "Ad")) == false))
        {
            goto label_3;
        }
        
        val_27 = 0;
        val_28 = "joypac: vip dont log event sort== \'Ad\'";
        val_29 = "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs";
        val_30 = "DesignEvent";
        goto label_6;
        label_3:
        if(onlyFirst == false)
        {
            goto label_7;
        }
        
        val_23 = 1152921504943640576;
        if((CryptoPrefs.HasKey(key:  JoypacAnalyticsManager.GetString(sort:  val_25, type:  type, position:  val_24, extra:  extra))) == false)
        {
            goto label_12;
        }
        
        val_31 = JoypacAnalyticsManager.GetString(sort:  val_25, type:  type, position:  val_24, extra:  extra)(JoypacAnalyticsManager.GetString(sort:  val_25, type:  type, position:  val_24, extra:  extra)) + "  not first ";
        val_27 = 5;
        val_28 = val_31;
        val_29 = "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs";
        val_30 = "DesignEvent";
        label_6:
        LogTool.DebugLog(log:  val_28, color:  5, path:  val_29, name:  val_30);
        return;
        label_12:
        CryptoPrefs.SetInt(key:  JoypacAnalyticsManager.GetString(sort:  val_25, type:  type, position:  val_24, extra:  extra), val:  1);
        label_7:
        object[] val_9 = new object[4];
        val_9[0] = "type";
        val_9[1] = val_26;
        val_9[2] = " ";
        val_9[3] = JoypacAnalyticsManager.GetString(sort:  val_25, type:  type, position:  val_24, extra:  extra);
        LogTool.DebugLog(log:  +val_9, color:  5, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs", name:  "DesignEvent");
        if((val_26 & 4) != 0)
        {
                LogTool.Error(log:  "Adjust dont have DesignEvent", path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs", name:  "DesignEvent");
        }
        
        if((val_26 & 1) != 0)
        {
                string val_12 = JoypacAnalyticsManager.GetString(sort:  val_25, type:  type, position:  val_24, extra:  extra);
            if((System.String.IsNullOrEmpty(value:  val_12)) != true)
        {
                GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName:  val_12);
        }
        
        }
        
        if((val_26 & 32) != 0)
        {
            goto label_45;
        }
        
        if((val_26 & 2) == 0)
        {
                return;
        }
        
        label_85:
        string val_14 = JoypacAnalyticsManager.GetString(sort:  val_25, type:  type, position:  val_24, extra:  extra);
        val_32 = val_14;
        if((System.String.IsNullOrEmpty(value:  val_14)) == false)
        {
                return;
        }
        
        if(val_32.Length >= 40)
        {
            goto label_82;
        }
        
        JoyPacUmengBridge.getInstance().uMengEventWithLabel(eventName:  val_32, label:  "");
        return;
        label_45:
        if((System.String.IsNullOrEmpty(value:  val_25)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  type)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  val_24)) == false)
        {
            goto label_58;
        }
        
        }
        
        }
        
        string[] val_21 = new string[6];
        val_26 = "Error sort=";
        val_21[0] = val_26;
        val_21[1] = val_25;
        val_25 = " type=";
        val_21[2] = val_25;
        val_21[3] = type;
        val_21[4] = " position=";
        val_21[5] = val_24;
        val_32 = +val_21;
        label_82:
        LogTool.Error(log:  val_32, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs", name:  "DesignEvent");
        return;
        label_58:
        JoypacAnalyticsManager.JoypacEventLog(event_sort:  val_25, event_type:  type, event_position:  val_24, event_extra:  extra);
        if((val_26 & 2) != 0)
        {
            goto label_85;
        }
    
    }
    private static string GetString(string sort, string type, string position, string extra = "")
    {
        if((System.String.IsNullOrEmpty(value:  extra)) != false)
        {
                return System.String.Format(format:  "{0}:{1}:{2}", arg0:  sort, arg1:  type, arg2:  position);
        }
        
        object[] val_2 = new object[4];
        val_2[0] = sort;
        val_2[1] = type;
        val_2[2] = position;
        val_2[3] = extra;
        return System.String.Format(format:  "{0}:{1}:{2}:{3}", args:  val_2);
    }
    public void ReyunLogEventToken(string _eventToken)
    {
    
    }
    public void AdjustLogEventToken(string _eventToken)
    {
        if((System.String.IsNullOrEmpty(value:  _eventToken)) != false)
        {
                return;
        }
        
        com.adjust.sdk.Adjust.trackEvent(adjustEvent:  new com.adjust.sdk.AdjustEvent(eventToken:  _eventToken));
        LogTool.DebugLog(log:  "Joypac LogEventWithLabel Adjust: "("Joypac LogEventWithLabel Adjust: ") + _eventToken, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs", name:  "AdjustLogEventToken");
    }
    public void AttributionChangedCallback(com.adjust.sdk.AdjustAttribution attribution)
    {
        LogTool.DebugLog(log:  "adjust:Attribution changed", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs", name:  "AttributionChangedCallback");
        string val_2 = UnityEngine.JsonUtility.ToJson(obj:  new JoypacAdjustAttribution(attribution:  attribution));
        LogTool.DebugLog(log:  "adjust:attribution to json ="("adjust:attribution to json =") + val_2, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JoypacAnalyticsManager.cs", name:  "AttributionChangedCallback");
        JoypacAnalyticsManager.ReceiveAdJustData(json:  val_2);
    }
    public static void JoypacEventLog(string event_sort, string event_type, string event_position, string event_extra)
    {
        JoypacSDKAdapter.Instance.joypacEventLog(event_sort:  event_sort, event_type:  event_type, event_position:  event_position, event_extra:  event_extra);
    }
    public static void ReceiveAdJustData(string json)
    {
        JoypacSDKAdapter.Instance.ReceiveAdJustData(json:  json);
    }
    public JoypacAnalyticsManager()
    {
    
    }
    private static JoypacAnalyticsManager()
    {
    
    }

}
