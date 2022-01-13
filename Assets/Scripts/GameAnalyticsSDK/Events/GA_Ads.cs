using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    public static class GA_Ads
    {
        // Methods
        public static void NewEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, long duration)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddAdEventWithDuration(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, duration:  duration);
        }
        public static void NewEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, GameAnalyticsSDK.GAAdError noAdReason)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddAdEventWithReason(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, noAdReason:  noAdReason);
        }
        public static void NewEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddAdEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement);
        }
    
    }

}
