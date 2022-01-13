using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    public static class GA_Debug
    {
        // Fields
        public static int MaxErrorCount;
        private static int _errorCount;
        private static bool _showLogOnGUI;
        public static System.Collections.Generic.List<string> Messages;
        
        // Methods
        public static void HandleLog(string logString, string stackTrace, UnityEngine.LogType type)
        {
            string val_16;
            var val_17;
            var val_19;
            var val_20;
            string val_21;
            GameAnalyticsSDK.GAErrorSeverity val_22;
            val_16 = stackTrace;
            val_17 = null;
            val_17 = null;
            if(GameAnalyticsSDK.Events.GA_Debug._showLogOnGUI != false)
            {
                    val_17 = null;
                if(GameAnalyticsSDK.Events.GA_Debug.Messages == null)
            {
                    System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
                val_17 = null;
                val_17 = null;
                GameAnalyticsSDK.Events.GA_Debug.Messages = val_1;
            }
            
                val_17 = null;
                val_1.Add(item:  logString);
            }
            
            if(GameAnalyticsSDK.GameAnalytics.SettingsGA == 0)
            {
                    return;
            }
            
            GameAnalyticsSDK.Setup.Settings val_4 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_4.SubmitErrors == false)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            if(type == 3)
            {
                    return;
            }
            
            if(GameAnalyticsSDK.Events.GA_Debug._errorCount >= GameAnalyticsSDK.Events.GA_Debug.MaxErrorCount)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_16)) != false)
            {
                    System.Diagnostics.StackTrace val_6 = new System.Diagnostics.StackTrace();
                val_16 = val_6;
            }
            
            val_20 = null;
            val_20 = null;
            int val_16 = GameAnalyticsSDK.Events.GA_Debug._errorCount;
            val_16 = val_16 + 1;
            GameAnalyticsSDK.Events.GA_Debug._errorCount = val_16;
            val_21 = logString.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' ')(logString.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' ')) + " " + val_6.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' ')(val_6.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' '));
            if(val_21.Length > 8192)
            {
                    val_21 = val_21.Substring(startIndex:  8192);
            }
            
            if(type <= 4)
            {
                    val_22 = mem[28871920 + (type) << 2];
                val_22 = 28871920 + (type) << 2;
            }
            else
            {
                    val_22 = 2;
            }
            
            GameAnalyticsSDK.Events.GA_Error.CreateNewEvent(severity:  val_22, message:  val_21, fields:  0);
        }
        private static void SubmitError(string message, UnityEngine.LogType type)
        {
            GameAnalyticsSDK.GAErrorSeverity val_1;
            if(type <= 4)
            {
                    val_1 = mem[28871920 + (type) << 2];
                val_1 = 28871920 + (type) << 2;
            }
            else
            {
                    val_1 = 2;
            }
            
            GameAnalyticsSDK.Events.GA_Error.CreateNewEvent(severity:  val_1, message:  message, fields:  0);
        }
        public static void EnabledLog()
        {
            null = null;
            GameAnalyticsSDK.Events.GA_Debug._showLogOnGUI = true;
        }
        private static GA_Debug()
        {
            GameAnalyticsSDK.Events.GA_Debug.MaxErrorCount = 10;
            GameAnalyticsSDK.Events.GA_Debug._errorCount = 0;
            GameAnalyticsSDK.Events.GA_Debug._showLogOnGUI = false;
        }
    
    }

}
