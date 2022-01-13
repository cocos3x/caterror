using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    public static class GA_Setup
    {
        // Methods
        public static void SetAvailableCustomDimensions01(System.Collections.Generic.List<string> customDimensions)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateCustomDimensions(customDimensions:  customDimensions.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableCustomDimensions01(list:  GA_MiniJSON.Serializer.Serialize(obj:  customDimensions));
        }
        public static void SetAvailableCustomDimensions02(System.Collections.Generic.List<string> customDimensions)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateCustomDimensions(customDimensions:  customDimensions.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableCustomDimensions02(list:  GA_MiniJSON.Serializer.Serialize(obj:  customDimensions));
        }
        public static void SetAvailableCustomDimensions03(System.Collections.Generic.List<string> customDimensions)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateCustomDimensions(customDimensions:  customDimensions.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableCustomDimensions03(list:  GA_MiniJSON.Serializer.Serialize(obj:  customDimensions));
        }
        public static void SetAvailableResourceCurrencies(System.Collections.Generic.List<string> resourceCurrencies)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateResourceCurrencies(resourceCurrencies:  resourceCurrencies.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableResourceCurrencies(list:  GA_MiniJSON.Serializer.Serialize(obj:  resourceCurrencies));
        }
        public static void SetAvailableResourceItemTypes(System.Collections.Generic.List<string> resourceItemTypes)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateResourceItemTypes(resourceItemTypes:  resourceItemTypes.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableResourceItemTypes(list:  GA_MiniJSON.Serializer.Serialize(obj:  resourceItemTypes));
        }
        public static void SetInfoLog(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetInfoLog(enabled:  enabled);
        }
        public static void SetVerboseLog(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetVerboseLog(enabled:  enabled);
        }
        public static void SetCustomDimension01(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomDimension01(customDimension:  customDimension);
        }
        public static void SetCustomDimension02(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomDimension02(customDimension:  customDimension);
        }
        public static void SetCustomDimension03(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomDimension03(customDimension:  customDimension);
        }
    
    }

}
