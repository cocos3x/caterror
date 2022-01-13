using UnityEngine;

namespace I2.Loc
{
    public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
    {
        // Fields
        public I2.Loc.LanguageSourceData mSource;
        public int version;
        public bool NeverDestroy;
        public bool UserAgreesToHaveItOnTheScene;
        public bool UserAgreesToHaveItInsideThePluginsFolder;
        public bool GoogleLiveSyncIsUptoDate;
        public System.Collections.Generic.List<UnityEngine.Object> Assets;
        public string Google_WebServiceURL;
        public string Google_SpreadsheetKey;
        public string Google_SpreadsheetName;
        public string Google_LastUpdatedVersion;
        public I2.Loc.LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;
        public float GoogleUpdateDelay;
        private System.Action<I2.Loc.LanguageSourceData, bool, string> Event_OnSourceUpdateFromGoogle;
        public System.Collections.Generic.List<I2.Loc.LanguageData> mLanguages;
        public bool IgnoreDeviceLanguage;
        public I2.Loc.LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;
        public System.Collections.Generic.List<I2.Loc.TermData> mTerms;
        public bool CaseInsensitiveTerms;
        public I2.Loc.LanguageSourceData.MissingTranslationAction OnMissingTranslation;
        public string mTerm_AppName;
        
        // Properties
        public I2.Loc.LanguageSourceData SourceData { get; set; }
        
        // Methods
        public I2.Loc.LanguageSourceData get_SourceData()
        {
            return (I2.Loc.LanguageSourceData)this.mSource;
        }
        public void set_SourceData(I2.Loc.LanguageSourceData value)
        {
            this.mSource = value;
        }
        public void add_Event_OnSourceUpdateFromGoogle(System.Action<I2.Loc.LanguageSourceData, bool, string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.Event_OnSourceUpdateFromGoogle, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Event_OnSourceUpdateFromGoogle != 1152921512250427336);
        
        }
        public void remove_Event_OnSourceUpdateFromGoogle(System.Action<I2.Loc.LanguageSourceData, bool, string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.Event_OnSourceUpdateFromGoogle, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Event_OnSourceUpdateFromGoogle != 1152921512250563912);
        
        }
        private void Awake()
        {
            this.mSource.owner = this;
            this.mSource.Awake();
        }
        private void OnDestroy()
        {
            this.NeverDestroy = false;
            this.mSource.OnDestroy();
        }
        public string GetSourceName()
        {
            string val_8 = this.gameObject.name;
            UnityEngine.Transform val_3 = this.transform;
            if(val_3 != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_8:
            val_8 = val_3.name + "_" + val_8;
            label_5:
            if((UnityEngine.Object.op_Implicit(exists:  val_3.parent)) == true)
            {
                goto label_8;
            }
            
            return (string)val_8;
        }
        public void OnBeforeSerialize()
        {
            this.version = 1;
        }
        public void OnAfterDeserialize()
        {
            System.Action<I2.Loc.LanguageSourceData, System.Boolean, System.String> val_7;
            var val_8;
            if(this.version != 0)
            {
                    if(this.mSource != null)
            {
                    return;
            }
            
            }
            
            this.mSource = new I2.Loc.LanguageSourceData();
            .owner = this;
            this.mSource.UserAgreesToHaveItOnTheScene = this.UserAgreesToHaveItOnTheScene;
            this.mSource.UserAgreesToHaveItInsideThePluginsFolder = this.UserAgreesToHaveItInsideThePluginsFolder;
            this.mSource.IgnoreDeviceLanguage = this.IgnoreDeviceLanguage;
            this.mSource._AllowUnloadingLanguages = this._AllowUnloadingLanguages;
            this.mSource.CaseInsensitiveTerms = this.CaseInsensitiveTerms;
            this.mSource.OnMissingTranslation = this.OnMissingTranslation;
            this.mSource.mTerm_AppName = this.mTerm_AppName;
            this.mSource.GoogleLiveSyncIsUptoDate = this.GoogleLiveSyncIsUptoDate;
            this.mSource.Google_WebServiceURL = this.Google_WebServiceURL;
            this.mSource.Google_SpreadsheetKey = this.Google_SpreadsheetKey;
            this.mSource.Google_SpreadsheetName = this.Google_SpreadsheetName;
            this.mSource.Google_LastUpdatedVersion = this.Google_LastUpdatedVersion;
            this.mSource.GoogleUpdateFrequency = this.GoogleUpdateFrequency;
            this.mSource.GoogleUpdateDelay = this.GoogleUpdateDelay;
            val_7 = this.Event_OnSourceUpdateFromGoogle;
            this.mSource.add_Event_OnSourceUpdateFromGoogle(value:  val_7);
            if(this.mLanguages != null)
            {
                    if(this.mLanguages.Count >= 1)
            {
                    this.mSource.mLanguages.Clear();
                val_7 = this.mLanguages;
                this.mSource.mLanguages.AddRange(collection:  val_7);
                this.mLanguages.Clear();
            }
            
            }
            
            if(this.Assets != null)
            {
                    if(this.Assets.Count >= 1)
            {
                    this.mSource.Assets.Clear();
                val_7 = this.Assets;
                this.mSource.Assets.AddRange(collection:  val_7);
                this.Assets.Clear();
            }
            
            }
            
            if((this.mTerms == null) || (this.mTerms.Count < 1))
            {
                goto label_34;
            }
            
            this.mSource.mTerms.Clear();
            val_8 = 0;
            goto label_37;
            label_42:
            this.mSource.mTerms.Add(item:  this.mTerms.Item[0]);
            val_8 = 1;
            label_37:
            val_7 = this.mTerms;
            if(val_8 < val_7.Count)
            {
                goto label_42;
            }
            
            this.mTerms.Clear();
            label_34:
            this.version = 1;
            this.Event_OnSourceUpdateFromGoogle = 0;
        }
        public LanguageSource()
        {
            this.mSource = new I2.Loc.LanguageSourceData();
            this.GoogleLiveSyncIsUptoDate = true;
            this.Assets = new System.Collections.Generic.List<UnityEngine.Object>();
            this.GoogleUpdateFrequency = 3;
            this.mLanguages = new System.Collections.Generic.List<I2.Loc.LanguageData>();
            this.mTerms = new System.Collections.Generic.List<I2.Loc.TermData>();
            this.OnMissingTranslation = true;
        }
    
    }

}
