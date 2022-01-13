using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    public static class GA_Business
    {
        // Methods
        public static void NewEventGooglePlay(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string signature, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddBusinessEventWithReceipt(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, receipt:  receipt, store:  "google_play", signature:  signature, fields:  fields);
        }
        public static void NewEvent(string currency, int amount, string itemType, string itemId, string cartType, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddBusinessEvent(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, fields:  fields);
        }
    
    }

}
