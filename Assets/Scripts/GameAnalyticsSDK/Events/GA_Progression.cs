using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    public static class GA_Progression
    {
        // Methods
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  0, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, int score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  0, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, int score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, int score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        private static void CreateEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, System.Nullable<int> score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            if(((-810675944) & 1) != 0)
            {
                    GameAnalyticsSDK.Wrapper.GA_Wrapper.AddProgressionEventWithScore(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  -810675944, fields:  fields);
                return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddProgressionEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, fields:  fields);
        }
    
    }

}
