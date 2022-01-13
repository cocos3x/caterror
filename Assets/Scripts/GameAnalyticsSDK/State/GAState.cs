using UnityEngine;

namespace GameAnalyticsSDK.State
{
    internal static class GAState
    {
        // Fields
        private static GameAnalyticsSDK.Setup.Settings _settings;
        
        // Methods
        public static void Init()
        {
            GameAnalyticsSDK.Setup.Settings val_5;
            if((UnityEngine.Resources.Load(path:  "GameAnalytics/Settings", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null)
            {
                    val_5 = 0;
            }
            
            GameAnalyticsSDK.State.GAState._settings = val_5;
        }
        private static bool ListContainsString(System.Collections.Generic.List<string> _list, string _string)
        {
            if(_list != null)
            {
                    return _list.Contains(item:  _string);
            }
            
            return _list.Contains(item:  _string);
        }
        public static bool IsManualSessionHandlingEnabled()
        {
            if(GameAnalyticsSDK.State.GAState._settings != null)
            {
                    return (bool)GameAnalyticsSDK.State.GAState._settings.UseManualSessionHandling;
            }
            
            return (bool)GameAnalyticsSDK.State.GAState._settings.UseManualSessionHandling;
        }
        public static bool HasAvailableResourceCurrency(string _currency)
        {
            if(GameAnalyticsSDK.State.GAState._settings != null)
            {
                    return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.ResourceCurrencies, _string:  _currency);
            }
            
            return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.ResourceCurrencies, _string:  _currency);
        }
        public static bool HasAvailableResourceItemType(string _itemType)
        {
            if(GameAnalyticsSDK.State.GAState._settings != null)
            {
                    return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.ResourceItemTypes, _string:  _itemType);
            }
            
            return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.ResourceItemTypes, _string:  _itemType);
        }
        public static bool HasAvailableCustomDimensions01(string _dimension01)
        {
            if(GameAnalyticsSDK.State.GAState._settings != null)
            {
                    return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.CustomDimensions01, _string:  _dimension01);
            }
            
            return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.CustomDimensions01, _string:  _dimension01);
        }
        public static bool HasAvailableCustomDimensions02(string _dimension02)
        {
            if(GameAnalyticsSDK.State.GAState._settings != null)
            {
                    return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.CustomDimensions02, _string:  _dimension02);
            }
            
            return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.CustomDimensions02, _string:  _dimension02);
        }
        public static bool HasAvailableCustomDimensions03(string _dimension03)
        {
            if(GameAnalyticsSDK.State.GAState._settings != null)
            {
                    return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.CustomDimensions03, _string:  _dimension03);
            }
            
            return GameAnalyticsSDK.State.GAState.ListContainsString(_list:  GameAnalyticsSDK.State.GAState._settings.CustomDimensions03, _string:  _dimension03);
        }
    
    }

}
