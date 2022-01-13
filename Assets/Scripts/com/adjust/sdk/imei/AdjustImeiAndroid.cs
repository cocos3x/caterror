using UnityEngine;

namespace com.adjust.sdk.imei
{
    public class AdjustImeiAndroid
    {
        // Fields
        private static UnityEngine.AndroidJavaClass ajcAdjustImei;
        
        // Methods
        public static void ReadImei()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(com.adjust.sdk.imei.AdjustImeiAndroid.ajcAdjustImei == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.imei.AdjustImei");
                val_4 = null;
                val_4 = null;
                com.adjust.sdk.imei.AdjustImeiAndroid.ajcAdjustImei = val_1;
                val_3 = null;
            }
            
            val_3 = null;
            val_1.CallStatic(methodName:  "readImei", args:  System.Array.Empty<System.Object>());
        }
        public static void DoNotReadImei()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(com.adjust.sdk.imei.AdjustImeiAndroid.ajcAdjustImei == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.imei.AdjustImei");
                val_4 = null;
                val_4 = null;
                com.adjust.sdk.imei.AdjustImeiAndroid.ajcAdjustImei = val_1;
                val_3 = null;
            }
            
            val_3 = null;
            val_1.CallStatic(methodName:  "doNotReadImei", args:  System.Array.Empty<System.Object>());
        }
        public AdjustImeiAndroid()
        {
        
        }
        private static AdjustImeiAndroid()
        {
            com.adjust.sdk.imei.AdjustImeiAndroid.ajcAdjustImei = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.imei.AdjustImei");
        }
    
    }

}
