using UnityEngine;

namespace GameAnalyticsSDK
{
    public class GameAnalytics : MonoBehaviour
    {
        // Fields
        private static GameAnalyticsSDK.Setup.Settings _settings;
        private static GameAnalyticsSDK.GameAnalytics _instance;
        private static bool _hasInitializeBeenCalled;
        private static System.Action OnRemoteConfigsUpdatedEvent;
        
        // Properties
        public static GameAnalyticsSDK.Setup.Settings SettingsGA { get; set; }
        
        // Methods
        public static GameAnalyticsSDK.Setup.Settings get_SettingsGA()
        {
            if(GameAnalyticsSDK.GameAnalytics._settings != 0)
            {
                    return (GameAnalyticsSDK.Setup.Settings)GameAnalyticsSDK.GameAnalytics._settings;
            }
            
            GameAnalyticsSDK.GameAnalytics.InitAPI();
            return (GameAnalyticsSDK.Setup.Settings)GameAnalyticsSDK.GameAnalytics._settings;
        }
        private static void set_SettingsGA(GameAnalyticsSDK.Setup.Settings value)
        {
            GameAnalyticsSDK.GameAnalytics._settings = value;
        }
        private void OnEnable()
        {
            UnityEngine.Application.add_logMessageReceived(value:  new Application.LogCallback(object:  0, method:  public static System.Void GameAnalyticsSDK.Events.GA_Debug::HandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
        }
        private void OnDisable()
        {
            UnityEngine.Application.remove_logMessageReceived(value:  new Application.LogCallback(object:  0, method:  public static System.Void GameAnalyticsSDK.Events.GA_Debug::HandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
        }
        public void Awake()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(GameAnalyticsSDK.GameAnalytics._instance != 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "Destroying duplicate GameAnalytics object - only one is allowed per scene!");
                UnityEngine.Object.Destroy(obj:  this.gameObject);
                return;
            }
            
            GameAnalyticsSDK.GameAnalytics._instance = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        private void OnDestroy()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(GameAnalyticsSDK.GameAnalytics._instance != this)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics._instance = 0;
        }
        private void OnApplicationQuit()
        {
        
        }
        private static void InitAPI()
        {
            GameAnalyticsSDK.Setup.Settings val_5;
            if((UnityEngine.Resources.Load(path:  "GameAnalytics/Settings", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null)
            {
                    val_5 = 0;
            }
            
            GameAnalyticsSDK.GameAnalytics._settings = val_5;
            GameAnalyticsSDK.State.GAState.Init();
        }
        private static void InternalInitialize()
        {
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Setup.Settings val_2 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_2.InfoLogBuild != false)
            {
                    GameAnalyticsSDK.Events.GA_Setup.SetInfoLog(enabled:  true);
            }
            
            GameAnalyticsSDK.Setup.Settings val_3 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_3.VerboseLogBuild != false)
            {
                    val_39 = 1;
                GameAnalyticsSDK.Events.GA_Setup.SetVerboseLog(enabled:  true);
            }
            
            int val_4 = GameAnalyticsSDK.GameAnalytics.GetPlatformIndex();
            val_40 = null;
            val_40 = null;
            val_41 = "unity ";
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetUnitySdkVersion(unitySdkVersion:  "unity " + GameAnalyticsSDK.Setup.Settings.VERSION);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetUnityEngineVersion(unityEngineVersion:  "unity " + GameAnalyticsSDK.GameAnalytics.GetUnityVersion());
            if((val_4 & 2147483648) != 0)
            {
                goto label_31;
            }
            
            if(val_8.UsePlayerSettingsBuildNumber == false)
            {
                goto label_28;
            }
            
            val_42 = 0;
            goto label_13;
            label_24:
            if(GameAnalyticsSDK.GameAnalytics.SettingsGA.Item[0] == 11)
            {
                goto label_14;
            }
            
            GameAnalyticsSDK.Setup.Settings val_10 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_10.Platforms.Item[0] != 8)
            {
                goto label_17;
            }
            
            label_14:
            GameAnalyticsSDK.Setup.Settings val_12 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_12.Build.set_Item(index:  0, value:  UnityEngine.Application.version);
            label_17:
            val_42 = 1;
            label_13:
            GameAnalyticsSDK.Setup.Settings val_14 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_41 = val_14.Platforms.Count;
            GameAnalyticsSDK.Setup.Settings val_16 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_42 < val_41)
            {
                goto label_24;
            }
            
            if(val_16.Platforms.Item[val_4] == 11)
            {
                goto label_25;
            }
            
            GameAnalyticsSDK.Setup.Settings val_18 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_18.Platforms.Item[val_4] != 8)
            {
                goto label_28;
            }
            
            label_25:
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAutoDetectAppVersion(flag:  true);
            goto label_31;
            label_28:
            GameAnalyticsSDK.Setup.Settings val_20 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetBuild(build:  val_20.Build.Item[val_4]);
            label_31:
            GameAnalyticsSDK.Setup.Settings val_22 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_22.CustomDimensions01.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_24 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableCustomDimensions01(customDimensions:  val_24.CustomDimensions01);
            }
            
            GameAnalyticsSDK.Setup.Settings val_25 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_25.CustomDimensions02.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_27 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableCustomDimensions02(customDimensions:  val_27.CustomDimensions02);
            }
            
            GameAnalyticsSDK.Setup.Settings val_28 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_28.CustomDimensions03.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_30 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableCustomDimensions03(customDimensions:  val_30.CustomDimensions03);
            }
            
            GameAnalyticsSDK.Setup.Settings val_31 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_31.ResourceItemTypes.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_33 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableResourceItemTypes(resourceItemTypes:  val_33.ResourceItemTypes);
            }
            
            GameAnalyticsSDK.Setup.Settings val_34 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_34.ResourceCurrencies.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_36 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableResourceCurrencies(resourceCurrencies:  val_36.ResourceCurrencies);
            }
            
            val_38 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_37.UseManualSessionHandling == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics.SetEnabledManualSessionHandling(enabled:  true);
        }
        public static void Initialize()
        {
            string val_8;
            GameAnalyticsSDK.GameAnalytics.InternalInitialize();
            int val_1 = GameAnalyticsSDK.GameAnalytics.GetPlatformIndex();
            if((val_1 & 2147483648) == 0)
            {
                    val_8 = GameAnalyticsSDK.GameAnalytics.SettingsGA.GetSecretKey(index:  val_1);
                GameAnalyticsSDK.Wrapper.GA_Wrapper.Initialize(gamekey:  GameAnalyticsSDK.GameAnalytics.SettingsGA.GetGameKey(index:  val_1), gamesecret:  val_8);
                GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled = true;
                return;
            }
            
            GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled = true;
            val_8 = "GameAnalytics: Unsupported platform (events will not be sent in editor; or missing platform in settings): "("GameAnalytics: Unsupported platform (events will not be sent in editor; or missing platform in settings): ") + UnityEngine.Application.platform;
            UnityEngine.Debug.LogWarning(message:  val_8);
        }
        public static void NewBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Business.NewEvent(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewBusinessEventGooglePlay(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string signature)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Business.NewEventGooglePlay(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, receipt:  receipt, signature:  signature, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewDesignEvent(string eventName)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Design.CreateNewEvent(eventName:  eventName, eventValue:  new System.Nullable<System.Single>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewDesignEvent(string eventName, float eventValue)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Design.NewEvent(eventName:  eventName, eventValue:  eventValue, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  0, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, int score)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.NewEvent(progressionStatus:  progressionStatus, progression01:  progression01, score:  score, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, int score)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.NewEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, score:  score, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, int score)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.NewEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  score, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewResourceEvent(GameAnalyticsSDK.GAResourceFlowType flowType, string currency, float amount, string itemType, string itemId)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Resource.NewEvent(flowType:  flowType, currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewErrorEvent(GameAnalyticsSDK.GAErrorSeverity severity, string message)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Error.CreateNewEvent(severity:  severity, message:  message, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, long duration)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Ads.NewEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, duration:  duration);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, GameAnalyticsSDK.GAAdError noAdReason)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Ads.NewEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, noAdReason:  noAdReason);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void NewAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Ads.NewEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        public static void SetCustomId(string userId)
        {
            UnityEngine.Debug.Log(message:  "Initializing with custom id: "("Initializing with custom id: ") + userId);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomUserId(userId:  userId);
        }
        public static void SetEnabledManualSessionHandling(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetEnabledManualSessionHandling(enabled:  enabled);
        }
        public static void SetEnabledEventSubmission(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetEnabledEventSubmission(enabled:  enabled);
        }
        public static void StartSession()
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.StartSession();
        }
        public static void EndSession()
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.EndSession();
        }
        public static void SetCustomDimension01(string customDimension)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetCustomDimension01(customDimension:  customDimension);
        }
        public static void SetCustomDimension02(string customDimension)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetCustomDimension02(customDimension:  customDimension);
        }
        public static void SetCustomDimension03(string customDimension)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetCustomDimension03(customDimension:  customDimension);
        }
        public static void add_OnRemoteConfigsUpdatedEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent != 1152921504979001368);
        
        }
        public static void remove_OnRemoteConfigsUpdatedEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent != 1152921504979001368);
        
        }
        public void OnRemoteConfigsUpdated()
        {
            if(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent == null)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent.Invoke();
        }
        public static void RemoteConfigsUpdated()
        {
            if(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent == null)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent.Invoke();
        }
        public static string GetRemoteConfigsValueAsString(string key)
        {
            return GameAnalyticsSDK.GameAnalytics.GetRemoteConfigsValueAsString(key:  key, defaultValue:  0);
        }
        public static string GetRemoteConfigsValueAsString(string key, string defaultValue)
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GetRemoteConfigsValueAsString(key:  key, defaultValue:  defaultValue);
        }
        public static bool IsRemoteConfigsReady()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.IsRemoteConfigsReady();
        }
        public static string GetRemoteConfigsContentAsString()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GetRemoteConfigsContentAsString();
        }
        public static string GetABTestingId()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GetABTestingId();
        }
        public static string GetABTestingVariantId()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GetABTestingVariantId();
        }
        public static void SubscribeMoPubImpressions()
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SubscribeMoPubImpressions();
        }
        public static void StartTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.StartTimer(key:  key);
        }
        public static void PauseTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.PauseTimer(key:  key);
        }
        public static void ResumeTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.ResumeTimer(key:  key);
        }
        public static long StopTimer(string key)
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.StopTimer(key:  key);
        }
        private static string GetUnityVersion()
        {
            string val_9;
            System.Char[] val_10;
            var val_11;
            string val_12;
            int val_4 = 0;
            val_9 = "";
            char[] val_2 = new char[1];
            val_10 = val_2;
            val_10[0] = '.';
            val_11 = 0;
            goto label_4;
            label_19:
            if((System.Int32.TryParse(s:  UnityEngine.Application.unityVersion.Split(separator:  val_2)[0], result: out  val_4)) == false)
            {
                goto label_6;
            }
            
            val_12 = mem[val_3[0x0] + 32];
            val_12 = val_3[0x0] + 32;
            if(val_11 != 0)
            {
                goto label_8;
            }
            
            val_9 = val_12;
            goto label_16;
            label_6:
            val_10 = System.Text.RegularExpressions.Regex.Split(input:  val_3[0x0] + 32, pattern:  "[^\\d]+");
            if((val_6.Length == 0) || ((System.Int32.TryParse(s:  val_10[0], result: out  val_4)) == false))
            {
                goto label_16;
            }
            
            val_12 = val_10[0];
            label_8:
            val_9 = val_9 + "." + val_12;
            label_16:
            val_11 = 1;
            label_4:
            if(val_11 < val_3.Length)
            {
                goto label_19;
            }
            
            return (string)val_9;
        }
        private static int GetPlatformIndex()
        {
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_11;
            var val_12;
            UnityEngine.RuntimePlatform val_13;
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_14;
            var val_15;
            val_11 = UnityEngine.Application.platform;
            if((val_11 - 18) < 3)
            {
                    GameAnalyticsSDK.Setup.Settings val_3 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                val_11 = val_3.Platforms;
                val_12 = 1152921512356015184;
                val_13 = 20;
                return val_10.Platforms.IndexOf(item:  val_13 = val_11);
            }
            
            if(val_11 == 31)
            {
                goto label_5;
            }
            
            if(val_11 != 8)
            {
                goto label_6;
            }
            
            GameAnalyticsSDK.Setup.Settings val_4 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_11 = val_4.Platforms.Contains(item:  8);
            GameAnalyticsSDK.Setup.Settings val_6 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_14 = val_6.Platforms;
            val_15 = public System.Int32 System.Collections.Generic.List<UnityEngine.RuntimePlatform>::IndexOf(UnityEngine.RuntimePlatform item);
            if(val_11 == false)
            {
                goto label_11;
            }
            
            label_17:
            val_13 = 8;
            return val_10.Platforms.IndexOf(item:  val_13);
            label_5:
            GameAnalyticsSDK.Setup.Settings val_7 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_11 = val_7.Platforms.Contains(item:  31);
            GameAnalyticsSDK.Setup.Settings val_9 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_14 = val_9.Platforms;
            val_15 = public System.Int32 System.Collections.Generic.List<UnityEngine.RuntimePlatform>::IndexOf(UnityEngine.RuntimePlatform item);
            if(val_11 == false)
            {
                goto label_17;
            }
            
            label_11:
            val_13 = 31;
            return val_10.Platforms.IndexOf(item:  val_13);
            label_6:
            GameAnalyticsSDK.Setup.Settings val_10 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_12 = 1152921512356015184;
            return val_10.Platforms.IndexOf(item:  val_13);
        }
        public static void SetBuildAllPlatforms(string build)
        {
            goto label_1;
            label_6:
            GameAnalyticsSDK.Setup.Settings val_1 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_1.Build.set_Item(index:  0, value:  build);
            0 = 1;
            label_1:
            GameAnalyticsSDK.Setup.Settings val_2 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(0 < val_2.Build.Count)
            {
                goto label_6;
            }
        
        }
        public GameAnalytics()
        {
        
        }
    
    }

}
