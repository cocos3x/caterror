using UnityEngine;

namespace com.adjust.sdk.oaid
{
    public class AdjustOaid : MonoBehaviour
    {
        // Fields
        private const string errorMsgEditor = "[AdjustOaid]: Adjust OAID plugin can not be used in Editor.";
        private const string errorMsgPlatform = "[AdjustOaid]: Adjust OAID plugin can only be used in Android apps.";
        public bool startManually;
        public bool readOaid;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.transform.gameObject);
            if(this.startManually != false)
            {
                    return;
            }
            
            if(this.readOaid != false)
            {
                    com.adjust.sdk.oaid.AdjustOaid.ReadOaid();
                return;
            }
            
            com.adjust.sdk.oaid.AdjustOaid.DoNotReadOaid();
        }
        public static void ReadOaid()
        {
            com.adjust.sdk.oaid.AdjustOaidAndroid.ReadOaid();
        }
        public static void DoNotReadOaid()
        {
            com.adjust.sdk.oaid.AdjustOaidAndroid.DoNotReadOaid();
        }
        private static bool IsEditor()
        {
            return false;
        }
        public AdjustOaid()
        {
            this.startManually = true;
        }
    
    }

}
