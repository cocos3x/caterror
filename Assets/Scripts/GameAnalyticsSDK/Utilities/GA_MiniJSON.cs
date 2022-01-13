using UnityEngine;

namespace GameAnalyticsSDK.Utilities
{
    public class GA_MiniJSON
    {
        // Methods
        public static object Deserialize(string json)
        {
            if(json == null)
            {
                    return (object)json;
            }
            
            return GA_MiniJSON.Parser.Parse(jsonString:  json);
        }
        public static string Serialize(object obj)
        {
            return GA_MiniJSON.Serializer.Serialize(obj:  obj);
        }
        public GA_MiniJSON()
        {
        
        }
    
    }

}
