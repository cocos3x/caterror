using UnityEngine;

namespace GameAnalyticsSDK.Setup
{
    public class Settings : ScriptableObject
    {
        // Fields
        public static string VERSION;
        public static bool CheckingForUpdates;
        public int TotalMessagesSubmitted;
        public int TotalMessagesFailed;
        public int DesignMessagesSubmitted;
        public int DesignMessagesFailed;
        public int QualityMessagesSubmitted;
        public int QualityMessagesFailed;
        public int ErrorMessagesSubmitted;
        public int ErrorMessagesFailed;
        public int BusinessMessagesSubmitted;
        public int BusinessMessagesFailed;
        public int UserMessagesSubmitted;
        public int UserMessagesFailed;
        public string CustomArea;
        private System.Collections.Generic.List<string> gameKey;
        private System.Collections.Generic.List<string> secretKey;
        public System.Collections.Generic.List<string> Build;
        public System.Collections.Generic.List<string> SelectedPlatformOrganization;
        public System.Collections.Generic.List<string> SelectedPlatformStudio;
        public System.Collections.Generic.List<string> SelectedPlatformGame;
        public System.Collections.Generic.List<int> SelectedPlatformGameID;
        public System.Collections.Generic.List<int> SelectedOrganization;
        public System.Collections.Generic.List<int> SelectedStudio;
        public System.Collections.Generic.List<int> SelectedGame;
        public string NewVersion;
        public string Changes;
        public bool SignUpOpen;
        public string StudioName;
        public string GameName;
        public string OrganizationName;
        public string OrganizationIdentifier;
        public string EmailGA;
        public string PasswordGA;
        public string TokenGA;
        public string ExpireTime;
        public string LoginStatus;
        public bool JustSignedUp;
        public bool HideSignupWarning;
        public bool IntroScreen;
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Organization> Organizations;
        public bool InfoLogEditor;
        public bool InfoLogBuild;
        public bool VerboseLogBuild;
        public bool UseManualSessionHandling;
        public bool SendExampleGameDataToMyGame;
        public bool UseIMEI;
        public bool InternetConnectivity;
        public System.Collections.Generic.List<string> CustomDimensions01;
        public System.Collections.Generic.List<string> CustomDimensions02;
        public System.Collections.Generic.List<string> CustomDimensions03;
        public System.Collections.Generic.List<string> ResourceItemTypes;
        public System.Collections.Generic.List<string> ResourceCurrencies;
        public UnityEngine.RuntimePlatform LastCreatedGamePlatform;
        public System.Collections.Generic.List<UnityEngine.RuntimePlatform> Platforms;
        public GameAnalyticsSDK.Setup.Settings.InspectorStates CurrentInspectorState;
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Settings.HelpTypes> ClosedHints;
        public bool DisplayHints;
        public UnityEngine.Vector2 DisplayHintsScrollState;
        public UnityEngine.Texture2D Logo;
        public UnityEngine.Texture2D UpdateIcon;
        public UnityEngine.Texture2D InfoIcon;
        public UnityEngine.Texture2D DeleteIcon;
        public UnityEngine.Texture2D GameIcon;
        public UnityEngine.Texture2D HomeIcon;
        public UnityEngine.Texture2D InstrumentIcon;
        public UnityEngine.Texture2D QuestionIcon;
        public UnityEngine.Texture2D UserIcon;
        public UnityEngine.Texture2D AmazonIcon;
        public UnityEngine.Texture2D GooglePlayIcon;
        public UnityEngine.Texture2D iosIcon;
        public UnityEngine.Texture2D macIcon;
        public UnityEngine.Texture2D windowsPhoneIcon;
        public UnityEngine.GUIStyle SignupButton;
        public bool UsePlayerSettingsBuildNumber;
        public bool SubmitErrors;
        public int MaxErrorCount;
        public bool SubmitFpsAverage;
        public bool SubmitFpsCritical;
        public bool IncludeGooglePlay;
        public int FpsCriticalThreshold;
        public int FpsCirticalSubmitInterval;
        public System.Collections.Generic.List<bool> PlatformFoldOut;
        public bool CustomDimensions01FoldOut;
        public bool CustomDimensions02FoldOut;
        public bool CustomDimensions03FoldOut;
        public bool ResourceItemTypesFoldOut;
        public bool ResourceCurrenciesFoldOut;
        public static readonly UnityEngine.RuntimePlatform[] AvailablePlatforms;
        
        // Methods
        public void SetCustomUserID(string customID)
        {
            bool val_1 = System.String.op_Inequality(a:  customID, b:  System.String.alignConst);
        }
        public void RemovePlatformAtIndex(int index)
        {
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_2;
            if((index & 2147483648) != 0)
            {
                    return;
            }
            
            val_2 = this.Platforms;
            if(val_2.Count <= index)
            {
                    return;
            }
            
            this.gameKey.RemoveAt(index:  index);
            this.secretKey.RemoveAt(index:  index);
            this.Build.RemoveAt(index:  index);
            this.SelectedPlatformOrganization.RemoveAt(index:  index);
            this.SelectedPlatformStudio.RemoveAt(index:  index);
            this.SelectedPlatformGame.RemoveAt(index:  index);
            this.SelectedPlatformGameID.RemoveAt(index:  index);
            this.SelectedOrganization.RemoveAt(index:  index);
            this.SelectedStudio.RemoveAt(index:  index);
            this.SelectedGame.RemoveAt(index:  index);
            this.PlatformFoldOut.RemoveAt(index:  index);
            this.Platforms.RemoveAt(index:  index);
        }
        public void AddPlatform(UnityEngine.RuntimePlatform platform)
        {
            this.gameKey.Add(item:  "");
            this.secretKey.Add(item:  "");
            this.Build.Add(item:  "0.1");
            this.SelectedPlatformOrganization.Add(item:  "");
            this.SelectedPlatformStudio.Add(item:  "");
            this.SelectedPlatformGame.Add(item:  "");
            this.SelectedPlatformGameID.Add(item:  0);
            this.SelectedOrganization.Add(item:  0);
            this.SelectedStudio.Add(item:  0);
            this.SelectedGame.Add(item:  0);
            this.PlatformFoldOut.Add(item:  true);
            this.Platforms.Add(item:  platform);
        }
        public string[] GetAvailablePlatforms()
        {
            var val_8;
            var val_9;
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_10;
            var val_11;
            UnityEngine.RuntimePlatform val_12;
            var val_13;
            string val_14;
            var val_15;
            var val_16;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_8 = 0;
            goto label_1;
            label_28:
            val_9 = null;
            val_9 = null;
            if((GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32) == 31)
            {
                goto label_6;
            }
            
            if((GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32) != 8)
            {
                goto label_7;
            }
            
            val_10 = this.Platforms;
            val_11 = public System.Boolean System.Collections.Generic.List<UnityEngine.RuntimePlatform>::Contains(UnityEngine.RuntimePlatform item);
            val_12 = 31;
            goto label_9;
            label_6:
            val_10 = this.Platforms;
            val_11 = public System.Boolean System.Collections.Generic.List<UnityEngine.RuntimePlatform>::Contains(UnityEngine.RuntimePlatform item);
            val_12 = 8;
            label_9:
            if((val_10.Contains(item:  val_12)) != true)
            {
                    if((this.Platforms.Contains(item:  GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32)) == false)
            {
                goto label_13;
            }
            
            }
            
            val_13 = this.Platforms;
            goto label_17;
            label_7:
            val_13 = this.Platforms;
            if((GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32) != 20)
            {
                goto label_17;
            }
            
            if((val_13.Contains(item:  GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32)) == true)
            {
                goto label_21;
            }
            
            val_14 = "WSA";
            val_15 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            goto label_20;
            label_17:
            if((val_13.Contains(item:  GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32)) == true)
            {
                goto label_21;
            }
            
            label_13:
            UniRx.Unit..cctor();
            val_15 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            val_14 = GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32.ToString();
            label_20:
            val_1.Add(item:  val_14);
            label_21:
            val_8 = 1;
            label_1:
            val_16 = null;
            val_16 = null;
            if(val_8 < GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length)
            {
                goto label_28;
            }
            
            return (System.String[])val_1.ToArray();
        }
        public bool IsGameKeyValid(int index, string value)
        {
            var val_4;
            string val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_7:
            if(index == val_4)
            {
                goto label_2;
            }
            
            val_5 = this.gameKey.Item[0];
            if((value.Equals(value:  val_5)) == true)
            {
                goto label_5;
            }
            
            label_2:
            val_4 = 1;
            label_1:
            val_5 = this.Platforms;
            if(val_4 < val_5.Count)
            {
                goto label_7;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_5:
            val_6 = 0;
            return (bool)val_6;
        }
        public bool IsSecretKeyValid(int index, string value)
        {
            var val_4;
            string val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_7:
            if(index == val_4)
            {
                goto label_2;
            }
            
            val_5 = this.secretKey.Item[0];
            if((value.Equals(value:  val_5)) == true)
            {
                goto label_5;
            }
            
            label_2:
            val_4 = 1;
            label_1:
            val_5 = this.Platforms;
            if(val_4 < val_5.Count)
            {
                goto label_7;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_5:
            val_6 = 0;
            return (bool)val_6;
        }
        public void UpdateGameKey(int index, string value)
        {
            System.Collections.Generic.List<System.String> val_5;
            var val_6;
            val_5 = this;
            if((System.String.IsNullOrEmpty(value:  value)) == false)
            {
                goto label_1;
            }
            
            val_5 = this.gameKey;
            val_6 = 1152921512235350480;
            goto label_3;
            label_1:
            bool val_2 = this.IsGameKeyValid(index:  index, value:  value);
            if(this.gameKey == null)
            {
                goto label_4;
            }
            
            if(val_2 == false)
            {
                goto label_5;
            }
            
            label_6:
            val_6 = 1152921512235350480;
            label_3:
            label_10:
            this.gameKey.set_Item(index:  index, value:  value);
            return;
            label_4:
            if(val_2 == true)
            {
                goto label_6;
            }
            
            label_5:
            if((this.gameKey.Item[index].Equals(value:  value)) == false)
            {
                    return;
            }
            
            if(this.gameKey != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        public void UpdateSecretKey(int index, string value)
        {
            System.Collections.Generic.List<System.String> val_5;
            var val_6;
            val_5 = this;
            if((System.String.IsNullOrEmpty(value:  value)) == false)
            {
                goto label_1;
            }
            
            val_5 = this.secretKey;
            val_6 = 1152921512235350480;
            goto label_3;
            label_1:
            bool val_2 = this.IsSecretKeyValid(index:  index, value:  value);
            if(this.secretKey == null)
            {
                goto label_4;
            }
            
            if(val_2 == false)
            {
                goto label_5;
            }
            
            label_6:
            val_6 = 1152921512235350480;
            label_3:
            label_10:
            this.secretKey.set_Item(index:  index, value:  value);
            return;
            label_4:
            if(val_2 == true)
            {
                goto label_6;
            }
            
            label_5:
            if((this.secretKey.Item[index].Equals(value:  value)) == false)
            {
                    return;
            }
            
            if(this.secretKey != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        public string GetGameKey(int index)
        {
            if(this.gameKey != null)
            {
                    return this.gameKey.Item[index];
            }
            
            return this.gameKey.Item[index];
        }
        public string GetSecretKey(int index)
        {
            if(this.secretKey != null)
            {
                    return this.secretKey.Item[index];
            }
            
            return this.secretKey.Item[index];
        }
        public void SetCustomArea(string customArea)
        {
        
        }
        public void SetKeys(string gamekey, string secretkey)
        {
        
        }
        public Settings()
        {
            this.CustomArea = System.String.alignConst;
            this.gameKey = new System.Collections.Generic.List<System.String>();
            this.secretKey = new System.Collections.Generic.List<System.String>();
            this.Build = new System.Collections.Generic.List<System.String>();
            this.SelectedPlatformOrganization = new System.Collections.Generic.List<System.String>();
            this.SelectedPlatformStudio = new System.Collections.Generic.List<System.String>();
            this.SelectedPlatformGame = new System.Collections.Generic.List<System.String>();
            this.SelectedPlatformGameID = new System.Collections.Generic.List<System.Int32>();
            this.SelectedOrganization = new System.Collections.Generic.List<System.Int32>();
            this.SelectedStudio = new System.Collections.Generic.List<System.Int32>();
            this.SelectedGame = new System.Collections.Generic.List<System.Int32>();
            this.NewVersion = "";
            this.Changes = "";
            this.StudioName = "";
            this.GameName = "";
            this.OrganizationName = "";
            this.OrganizationIdentifier = "";
            this.EmailGA = "";
            this.PasswordGA = "";
            this.TokenGA = "";
            this.ExpireTime = "";
            this.SignUpOpen = true;
            this.IntroScreen = true;
            this.InfoLogEditor = true;
            this.InfoLogBuild = true;
            this.LoginStatus = "Not logged in.";
            this.CustomDimensions01 = new System.Collections.Generic.List<System.String>();
            this.CustomDimensions02 = new System.Collections.Generic.List<System.String>();
            this.CustomDimensions03 = new System.Collections.Generic.List<System.String>();
            this.ResourceItemTypes = new System.Collections.Generic.List<System.String>();
            this.ResourceCurrencies = new System.Collections.Generic.List<System.String>();
            this.Platforms = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
            this.ClosedHints = new System.Collections.Generic.List<HelpTypes>();
            this.SubmitErrors = true;
            this.SubmitFpsAverage = true;
            this.SubmitFpsCritical = true;
            this.IncludeGooglePlay = true;
            this.FpsCirticalSubmitInterval = true;
            this.MaxErrorCount = 10;
            this.FpsCriticalThreshold = 20;
            this.PlatformFoldOut = new System.Collections.Generic.List<System.Boolean>();
        }
        private static Settings()
        {
            GameAnalyticsSDK.Setup.Settings.VERSION = "6.3.0";
            GameAnalyticsSDK.Setup.Settings.CheckingForUpdates = false;
            GameAnalyticsSDK.Setup.Settings.AvailablePlatforms = new UnityEngine.RuntimePlatform[8];
        }
    
    }

}
