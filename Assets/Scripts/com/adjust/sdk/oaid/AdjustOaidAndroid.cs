using UnityEngine;

namespace com.adjust.sdk.oaid
{
    public class AdjustOaidAndroid
    {
        // Fields
        private static UnityEngine.AndroidJavaClass ajcAdjustOaid;
        private static UnityEngine.AndroidJavaObject ajoCurrentActivity;
        
        // Methods
        public static void ReadOaid()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(com.adjust.sdk.oaid.AdjustOaidAndroid.ajcAdjustOaid == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.oaid.AdjustOaid");
                val_4 = null;
                val_4 = null;
                com.adjust.sdk.oaid.AdjustOaidAndroid.ajcAdjustOaid = val_1;
                val_3 = null;
            }
            
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = com.adjust.sdk.oaid.AdjustOaidAndroid.ajoCurrentActivity;
            val_1.CallStatic(methodName:  "readOaid", args:  val_2);
        }
        public static void DoNotReadOaid()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(com.adjust.sdk.oaid.AdjustOaidAndroid.ajcAdjustOaid == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.oaid.AdjustOaid");
                val_4 = null;
                val_4 = null;
                com.adjust.sdk.oaid.AdjustOaidAndroid.ajcAdjustOaid = val_1;
                val_3 = null;
            }
            
            val_3 = null;
            val_1.CallStatic(methodName:  "doNotReadOaid", args:  System.Array.Empty<System.Object>());
        }
        public AdjustOaidAndroid()
        {
        
        }
        private static AdjustOaidAndroid()
        {
            com.adjust.sdk.oaid.AdjustOaidAndroid.ajcAdjustOaid = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.oaid.AdjustOaid");
            com.adjust.sdk.oaid.AdjustOaidAndroid.ajoCurrentActivity = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
    
    }

}
