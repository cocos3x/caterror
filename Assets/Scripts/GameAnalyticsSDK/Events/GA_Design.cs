using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    public static class GA_Design
    {
        // Methods
        public static void NewEvent(string eventName, float eventValue, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Design.CreateNewEvent(eventName:  eventName, eventValue:  new System.Nullable<System.Single>() {HasValue = false}, fields:  fields);
        }
        public static void NewEvent(string eventName, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Design.CreateNewEvent(eventName:  eventName, eventValue:  new System.Nullable<System.Single>() {HasValue = false}, fields:  fields);
        }
        private static void CreateNewEvent(string eventName, System.Nullable<float> eventValue, System.Collections.Generic.IDictionary<string, object> fields)
        {
            if(((-811958360) & 1) != 0)
            {
                    GameAnalyticsSDK.Wrapper.GA_Wrapper.AddDesignEvent(eventID:  eventName, eventValue:  V0.16B, fields:  fields);
                return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddDesignEvent(eventID:  eventName, fields:  fields);
        }
    
    }

}
