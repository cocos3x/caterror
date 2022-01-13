using UnityEngine;

namespace com.adjust.sdk.imei
{
    public class AdjustImei : MonoBehaviour
    {
        // Fields
        private const string errorMsgEditor = "[AdjustImei]: Adjust IMEI plugin can not be used in Editor.";
        private const string errorMsgPlatform = "[AdjustImei]: Adjust IMEI plugin can only be used in Android apps.";
        public bool startManually;
        public bool readImei;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.transform.gameObject);
            if(this.startManually != false)
            {
                    return;
            }
            
            if(this.readImei != false)
            {
                    com.adjust.sdk.imei.AdjustImei.ReadImei();
                return;
            }
            
            com.adjust.sdk.imei.AdjustImei.DoNotReadImei();
        }
        public static void ReadImei()
        {
            com.adjust.sdk.imei.AdjustImeiAndroid.ReadImei();
        }
        public static void DoNotReadImei()
        {
            com.adjust.sdk.imei.AdjustImeiAndroid.DoNotReadImei();
        }
        private static bool IsEditor()
        {
            return false;
        }
        public AdjustImei()
        {
            this.startManually = true;
        }
    
    }

}
