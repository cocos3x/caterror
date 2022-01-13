using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class LanguageSourceData
    {
        // Fields
        public I2.Loc.ILanguageSource owner;
        public bool UserAgreesToHaveItOnTheScene;
        public bool UserAgreesToHaveItInsideThePluginsFolder;
        public bool GoogleLiveSyncIsUptoDate;
        public bool mIsGlobalSource;
        public System.Collections.Generic.List<I2.Loc.TermData> mTerms;
        public bool CaseInsensitiveTerms;
        public System.Collections.Generic.Dictionary<string, I2.Loc.TermData> mDictionary;
        public I2.Loc.LanguageSourceData.MissingTranslationAction OnMissingTranslation;
        public string mTerm_AppName;
        public System.Collections.Generic.List<I2.Loc.LanguageData> mLanguages;
        public bool IgnoreDeviceLanguage;
        public I2.Loc.LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;
        public string Google_WebServiceURL;
        public string Google_SpreadsheetKey;
        public string Google_SpreadsheetName;
        public string Google_LastUpdatedVersion;
        public I2.Loc.LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;
        public I2.Loc.LanguageSourceData.eGoogleUpdateFrequency GoogleInEditorCheckFrequency;
        public I2.Loc.LanguageSourceData.eGoogleUpdateSynchronization GoogleUpdateSynchronization;
        public float GoogleUpdateDelay;
        private System.Action<I2.Loc.LanguageSourceData, bool, string> Event_OnSourceUpdateFromGoogle;
        public System.Collections.Generic.List<UnityEngine.Object> Assets;
        public System.Collections.Generic.Dictionary<string, UnityEngine.Object> mAssetDictionary;
        private string mDelayedGoogleData;
        public static string EmptyCategory;
        public static char[] CategorySeparators;
        
        // Properties
        public UnityEngine.Object ownerObject { get; }
        
        // Methods
        public UnityEngine.Object get_ownerObject()
        {
            var val_2 = 0;
            return (UnityEngine.Object);
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
            while(this.Event_OnSourceUpdateFromGoogle != 1152921512252374520);
        
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
            while(this.Event_OnSourceUpdateFromGoogle != 1152921512252511096);
        
        }
        public void Awake()
        {
            I2.Loc.LocalizationManager.AddSource(Source:  this);
            this.UpdateDictionary(force:  false);
            this.UpdateAssetDictionary();
            I2.Loc.LocalizationManager.LocalizeAll(Force:  true);
        }
        public void OnDestroy()
        {
            I2.Loc.LocalizationManager.RemoveSource(Source:  this);
        }
        public bool IsEqualTo(I2.Loc.LanguageSourceData Source)
        {
            string val_11;
            var val_12;
            var val_13;
            val_11 = 1152921512251296432;
            val_12 = Source.mLanguages.Count;
            if(val_12 != this.mLanguages.Count)
            {
                goto label_15;
            }
            
            val_12 = this.mLanguages.Count;
            if(val_12 < 1)
            {
                goto label_6;
            }
            
            var val_11 = 0;
            label_11:
            I2.Loc.LanguageData val_4 = this.mLanguages.Item[0];
            val_11 = val_4.Name;
            if(((Source.GetLanguageIndex(language:  val_11, AllowDiscartingRegion:  true, SkipDisabled:  true)) & 2147483648) != 0)
            {
                goto label_15;
            }
            
            val_11 = val_11 + 1;
            if(val_11 < val_12)
            {
                goto label_11;
            }
            
            label_6:
            val_11 = 1152921512251359920;
            val_12 = Source.mTerms.Count;
            if(val_12 == this.mTerms.Count)
            {
                    do
            {
                if(0 >= this.mTerms.Count)
            {
                    return (bool)val_13;
            }
            
                I2.Loc.TermData val_9 = this.mTerms.Item[0];
                val_12 = 0 + 1;
            }
            while((Source.GetTermData(term:  val_9.Term, allowCategoryMistmatch:  false)) != null);
            
                return (bool)val_13;
            }
            
            label_15:
            val_13 = 0;
            return (bool)val_13;
        }
        internal bool ManagerHasASimilarSource()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 >= 1)
            {
                    val_5 = 0;
                do
            {
                val_6 = null;
                val_6 = null;
                I2.Loc.LanguageSourceData val_2 = I2.Loc.LocalizationManager.Sources.Item[0];
                if(val_2 != null)
            {
                    if(val_2 != this)
            {
                    if((val_2.IsEqualTo(Source:  this)) == true)
            {
                goto label_10;
            }
            
            }
            
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < val_1);
            
            }
            
            val_7 = 0;
            return (bool)val_7;
            label_10:
            val_7 = 1;
            return (bool)val_7;
        }
        public void ClearAllData()
        {
            this.mTerms.Clear();
            this.mLanguages.Clear();
            this.mDictionary.Clear();
            this.mAssetDictionary.Clear();
        }
        public bool IsGlobalSource()
        {
            return (bool)this.mIsGlobalSource;
        }
        public void Editor_SetDirty()
        {
        
        }
        public void UpdateAssetDictionary()
        {
            var val_9;
            var val_11;
            System.Func<UnityEngine.Object, System.String> val_13;
            var val_14;
            System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String> val_16;
            System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_18;
            val_9 = null;
            val_9 = null;
            if((LanguageSourceData.<>c.<>9__39_0) == null)
            {
                goto label_3;
            }
            
            label_23:
            int val_1 = this.Assets.RemoveAll(match:  LanguageSourceData.<>c.<>9__39_0);
            val_11 = null;
            val_11 = null;
            val_13 = LanguageSourceData.<>c.<>9__39_1;
            if(val_13 == null)
            {
                    System.Func<UnityEngine.Object, System.String> val_3 = null;
                val_13 = val_3;
                val_3 = new System.Func<UnityEngine.Object, System.String>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.String LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_1(UnityEngine.Object o));
                LanguageSourceData.<>c.<>9__39_1 = val_13;
            }
            
            val_14 = null;
            val_14 = null;
            val_16 = LanguageSourceData.<>c.<>9__39_2;
            if(val_16 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String> val_5 = null;
                val_16 = val_5;
                val_5 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.String LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_2(System.Linq.IGrouping<string, UnityEngine.Object> g));
                val_14 = null;
                LanguageSourceData.<>c.<>9__39_2 = val_16;
            }
            
            val_14 = null;
            val_18 = LanguageSourceData.<>c.<>9__39_3;
            if(val_18 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_6 = null;
                val_18 = val_6;
                val_6 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Object LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_3(System.Linq.IGrouping<string, UnityEngine.Object> g));
                LanguageSourceData.<>c.<>9__39_3 = val_18;
            }
            
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String, UnityEngine.Object>(source:  System.Linq.Enumerable.GroupBy<UnityEngine.Object, System.String>(source:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  this.Assets), keySelector:  val_3), keySelector:  val_5, elementSelector:  val_6);
            return;
            label_3:
            LanguageSourceData.<>c.<>9__39_0 = new System.Predicate<UnityEngine.Object>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LanguageSourceData.<>c::<UpdateAssetDictionary>b__39_0(UnityEngine.Object x));
            if(this.Assets != null)
            {
                goto label_23;
            }
            
            goto label_23;
        }
        public UnityEngine.Object FindAsset(string Name)
        {
            var val_6;
            var val_7;
            UnityEngine.Object val_3 = 0;
            if(this.Assets == null)
            {
                goto label_1;
            }
            
            if(this.mAssetDictionary == null)
            {
                goto label_2;
            }
            
            val_6 = this.mAssetDictionary.Count;
            if(val_6 == this.Assets.Count)
            {
                goto label_4;
            }
            
            label_2:
            this.UpdateAssetDictionary();
            label_4:
            var val_5 = ((this.mAssetDictionary.TryGetValue(key:  Name, value: out  val_3)) != true) ? (val_3) : 0;
            return (UnityEngine.Object)val_7;
            label_1:
            val_7 = 0;
            return (UnityEngine.Object)val_7;
        }
        public bool HasAsset(UnityEngine.Object Obj)
        {
            if(this.Assets != null)
            {
                    return this.Assets.Contains(item:  Obj);
            }
            
            return this.Assets.Contains(item:  Obj);
        }
        public void AddAsset(UnityEngine.Object Obj)
        {
            if((this.Assets.Contains(item:  Obj)) != false)
            {
                    return;
            }
            
            this.Assets.Add(item:  Obj);
            this.UpdateAssetDictionary();
        }
        public string Export_I2CSV(string Category, char Separator = '\x2c', bool specializationsAsRows = True)
        {
            var val_4;
            var val_5;
            var val_30;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.Append(value:  "Key[*]Type[*]Desc");
            List.Enumerator<T> val_3 = this.mLanguages.GetEnumerator();
            label_11:
            if(((-942497120) & 1) == 0)
            {
                goto label_3;
            }
            
            System.Text.StringBuilder val_7 = val_1.Append(value:  "[*]");
            if((val_4 & 1) != 0)
            {
                    System.Text.StringBuilder val_8 = val_1.Append(value:  '$');
            }
            
            System.Text.StringBuilder val_10 = val_1.Append(value:  I2.Loc.GoogleLanguages.GetCodedLanguage(Language:  val_6.m_stringLength, code:  val_5.Id));
            goto label_11;
            label_3:
            UniRx.Unit..cctor();
            System.Text.StringBuilder val_11 = val_1.Append(value:  "[ln]");
            val_30 = null;
            val_30 = null;
            if((LanguageSourceData.<>c.<>9__43_0) == null)
            {
                goto label_24;
            }
            
            label_66:
            this.mTerms.Sort(comparison:  LanguageSourceData.<>c.<>9__43_0);
            int val_12 = this.mLanguages.Count;
            List.Enumerator<T> val_13 = this.mTerms.GetEnumerator();
            label_62:
            if(((-942497152) & 1) == 0)
            {
                goto label_28;
            }
            
            string val_14 = val_5.Id;
            if((System.String.IsNullOrEmpty(value:  Category)) == true)
            {
                goto label_29;
            }
            
            val_32 = null;
            val_32 = null;
            if((System.String.op_Equality(a:  Category, b:  I2.Loc.LanguageSourceData.EmptyCategory)) == false)
            {
                goto label_32;
            }
            
            val_33 = null;
            val_33 = null;
            if(((val_14.m_stringLength.IndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators)) & 2147483648) == 0)
            {
                goto label_39;
            }
            
            goto label_48;
            label_32:
            label_39:
            if(((val_14.m_stringLength.StartsWith(value:  Category + "/"("/"))) == false) || ((System.String.op_Inequality(a:  Category, b:  val_14.m_stringLength)) == false))
            {
                goto label_62;
            }
            
            string val_23 = val_14.m_stringLength.Substring(startIndex:  Category.Length + 1);
            if((1 & 1) != 0)
            {
                goto label_47;
            }
            
            label_49:
            System.Text.StringBuilder val_24 = val_1.Append(value:  "[ln]");
            goto label_47;
            label_29:
            label_48:
            if((1 & 1) == 0)
            {
                goto label_49;
            }
            
            label_47:
            if(specializationsAsRows == false)
            {
                goto label_50;
            }
            
            System.Collections.Generic.List<System.String> val_25 = val_14.GetAllSpecializations();
            val_34 = 0;
            goto label_51;
            label_58:
            if(val_34 != 0)
            {
                    System.Text.StringBuilder val_26 = val_1.Append(value:  "[ln]");
            }
            
            I2.Loc.LanguageSourceData.AppendI2Term(Builder:  val_1, nLanguages:  val_12, Term:  val_14.m_stringLength, termData:  val_14, Separator:  0, forceSpecialization:  val_25.Item[0]);
            val_34 = 1;
            label_51:
            if(val_34 < val_25.Count)
            {
                goto label_58;
            }
            
            goto label_62;
            label_50:
            I2.Loc.LanguageSourceData.AppendI2Term(Builder:  val_1, nLanguages:  val_12, Term:  val_14.m_stringLength, termData:  val_14, Separator:  0, forceSpecialization:  0);
            goto label_62;
            label_24:
            LanguageSourceData.<>c.<>9__43_0 = new System.Comparison<I2.Loc.TermData>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LanguageSourceData.<>c::<Export_I2CSV>b__43_0(I2.Loc.TermData a, I2.Loc.TermData b));
            if(this.mTerms != null)
            {
                goto label_66;
            }
            
            goto label_66;
            label_28:
            val_35 = public System.Void List.Enumerator<I2.Loc.TermData>::Dispose();
            UniRx.Unit..cctor();
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        private static void AppendI2Term(System.Text.StringBuilder Builder, int nLanguages, string Term, I2.Loc.TermData termData, char Separator, string forceSpecialization)
        {
            var val_18;
            string val_19;
            I2.Loc.LanguageSourceData.AppendI2Text(Builder:  Builder, text:  Term);
            if(((System.String.IsNullOrEmpty(value:  forceSpecialization)) != true) && ((System.String.op_Inequality(a:  forceSpecialization, b:  "Any")) != false))
            {
                    if(Builder != null)
            {
                    System.Text.StringBuilder val_3 = Builder.Append(value:  "[");
                System.Text.StringBuilder val_4 = Builder.Append(value:  forceSpecialization);
            }
            else
            {
                    System.Text.StringBuilder val_5 = 0.Append(value:  "[");
                System.Text.StringBuilder val_6 = 0.Append(value:  forceSpecialization);
            }
            
                System.Text.StringBuilder val_7 = Builder.Append(value:  "]");
            }
            
            System.Text.StringBuilder val_8 = Builder.Append(value:  "[*]");
            string val_9 = termData.TermType.ToString();
            UniRx.Unit..cctor();
            mem2[0] = null;
            if(Builder != null)
            {
                    System.Text.StringBuilder val_10 = Builder.Append(value:  val_9);
            }
            else
            {
                    System.Text.StringBuilder val_11 = 0.Append(value:  val_9);
            }
            
            System.Text.StringBuilder val_12 = Builder.Append(value:  "[*]");
            System.Text.StringBuilder val_13 = Builder.Append(value:  termData.Description);
            val_18 = 0;
            goto label_14;
            label_24:
            System.Text.StringBuilder val_14 = Builder.Append(value:  "[*]");
            val_19 = termData.Languages[0];
            if((System.String.IsNullOrEmpty(value:  forceSpecialization)) != true)
            {
                    val_19 = termData.GetTranslation(idx:  0, specialization:  forceSpecialization, editMode:  false);
            }
            
            I2.Loc.LanguageSourceData.AppendI2Text(Builder:  Builder, text:  val_19);
            val_18 = 1;
            label_14:
            if(val_18 < (UnityEngine.Mathf.Min(a:  nLanguages, b:  termData.Languages.Length)))
            {
                goto label_24;
            }
        
        }
        private static void AppendI2Text(System.Text.StringBuilder Builder, string text)
        {
            if((System.String.IsNullOrEmpty(value:  text)) != false)
            {
                    return;
            }
            
            if((text.StartsWith(value:  "\'")) != true)
            {
                    if((text.StartsWith(value:  "=")) == false)
            {
                goto label_5;
            }
            
            }
            
            System.Text.StringBuilder val_4 = Builder.Append(value:  ''');
            label_5:
            System.Text.StringBuilder val_5 = Builder.Append(value:  text);
        }
        private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
        {
            var val_15;
            var val_16;
            System.String[] val_17;
            var val_18;
            I2.Loc.LanguageData val_1 = this.mLanguages.Item[langIndex];
            if((val_1.Flags & 4) != 0)
            {
                goto label_3;
            }
            
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            val_15 = "=";
            val_16 = 0;
            goto label_4;
            label_27:
            if(val_16 >= 1)
            {
                    System.Text.StringBuilder val_3 = val_2.Append(value:  "[i2t]");
            }
            
            if(val_2 != null)
            {
                    System.Text.StringBuilder val_5 = val_2.Append(value:  val_4.Term);
            }
            else
            {
                    System.Text.StringBuilder val_6 = val_2.Append(value:  val_4.Term);
            }
            
            System.Text.StringBuilder val_7 = val_2.Append(value:  "=");
            val_17 = val_4.Languages;
            string val_15 = val_17[(long)langIndex];
            string val_9 = val_15;
            if(((this.OnMissingTranslation != 1) || ((System.String.IsNullOrEmpty(value:  val_15)) == false)) || ((this.TryGetFallbackTranslation(termData:  this.mTerms.Item[0], Translation: out  val_9, langIndex:  langIndex, overrideSpecialization:  0, skipDisabled:  true)) == false))
            {
                goto label_17;
            }
            
            System.Text.StringBuilder val_11 = val_2.Append(value:  "[i2fb]");
            if(fillTermWithFallback == false)
            {
                goto label_17;
            }
            
            val_17 = val_4.Languages;
            if(val_17 == null)
            {
                goto label_18;
            }
            
            if(val_9 != 0)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_9 == 0)
            {
                goto label_22;
            }
            
            label_19:
            label_22:
            val_17[(long)langIndex] = val_9;
            label_17:
            if((System.String.IsNullOrEmpty(value:  val_9)) != true)
            {
                    System.Text.StringBuilder val_13 = val_2.Append(value:  val_9);
            }
            
            val_16 = 1;
            label_4:
            if(val_16 < this.mTerms.Count)
            {
                goto label_27;
            }
            
            val_18 = val_2;
            return (string)val_18;
            label_3:
            val_18 = 0;
            return (string)val_18;
        }
        public string Export_CSV(string Category, char Separator = '\x2c', bool specializationsAsRows = True)
        {
            var val_5;
            var val_6;
            var val_28;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            int val_35;
            var val_38;
            var val_40;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            int val_2 = this.mLanguages.Count;
            System.Text.StringBuilder val_3 = val_1.AppendFormat(format:  "Key{0}Type{0}Desc", arg0:  Separator);
            List.Enumerator<T> val_4 = this.mLanguages.GetEnumerator();
            label_13:
            if(((-941269584) & 1) == 0)
            {
                goto label_4;
            }
            
            System.Text.StringBuilder val_8 = val_1.Append(value:  Separator);
            if((val_5 & 1) != 0)
            {
                    System.Text.StringBuilder val_9 = val_1.Append(value:  '$');
            }
            
            I2.Loc.LanguageSourceData.AppendString(Builder:  val_1, Text:  I2.Loc.GoogleLanguages.GetCodedLanguage(Language:  val_7.m_stringLength, code:  val_6.Id), Separator:  Separator);
            goto label_13;
            label_4:
            UniRx.Unit..cctor();
            System.Text.StringBuilder val_11 = val_1.Append(value:  "\n");
            val_28 = null;
            val_28 = null;
            if((LanguageSourceData.<>c.<>9__47_0) == null)
            {
                goto label_26;
            }
            
            label_68:
            this.mTerms.Sort(comparison:  LanguageSourceData.<>c.<>9__47_0);
            List.Enumerator<T> val_12 = this.mTerms.GetEnumerator();
            val_31 = 0;
            val_32 = 0;
            label_64:
            if(((-941269616) & 1) == 0)
            {
                goto label_29;
            }
            
            string val_13 = val_6.Id;
            if((System.String.IsNullOrEmpty(value:  Category)) == true)
            {
                goto label_30;
            }
            
            val_33 = null;
            val_33 = null;
            if((System.String.op_Equality(a:  Category, b:  I2.Loc.LanguageSourceData.EmptyCategory)) == false)
            {
                goto label_33;
            }
            
            val_34 = null;
            val_34 = null;
            if(((val_13.m_stringLength.IndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators)) & 2147483648) == 0)
            {
                goto label_40;
            }
            
            goto label_47;
            label_33:
            label_40:
            if(((val_13.m_stringLength.StartsWith(value:  Category + "/"("/"))) == false) || ((System.String.op_Inequality(a:  Category, b:  val_13.m_stringLength)) == false))
            {
                goto label_64;
            }
            
            val_35 = val_13.m_stringLength.Substring(startIndex:  Category.Length + 1);
            goto label_46;
            label_30:
            label_47:
            val_35 = val_13.m_stringLength;
            label_46:
            if(specializationsAsRows == false)
            {
                goto label_61;
            }
            
            List.Enumerator<T> val_24 = val_13.GetAllSpecializations().GetEnumerator();
            label_53:
            if(((-941269648) & 1) == 0)
            {
                goto label_50;
            }
            
            I2.Loc.LanguageSourceData.AppendTerm(Builder:  val_1, nLanguages:  val_2, Term:  val_35, termData:  val_13, specialization:  val_6.Id, Separator:  Separator);
            goto label_53;
            label_50:
            var val_27 = 0;
            val_27 = val_27 + 1;
            mem2[0] = 407;
            UniRx.Unit..cctor();
            var val_29 = val_27;
            if((val_29 == 1) || ((-941269728 + ((0 + 1)) << 2) != 407))
            {
                goto label_58;
            }
            
            var val_28 = 0;
            val_28 = val_28 ^ (val_29 >> 31);
            val_29 = val_29 + val_28;
            goto label_64;
            label_58:
            if( != 0)
            {
                
            }
            
            label_61:
            I2.Loc.LanguageSourceData.AppendTerm(Builder:  val_1, nLanguages:  val_2, Term:  val_35, termData:  val_13, specialization:  0, Separator:  Separator);
            goto label_64;
            label_26:
            LanguageSourceData.<>c.<>9__47_0 = new System.Comparison<I2.Loc.TermData>(object:  LanguageSourceData.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LanguageSourceData.<>c::<Export_CSV>b__47_0(I2.Loc.TermData a, I2.Loc.TermData b));
            if(this.mTerms != null)
            {
                goto label_68;
            }
            
            goto label_68;
            label_29:
            val_38 = val_29 + 1;
            mem2[0] = 435;
            val_40 = public System.Void List.Enumerator<I2.Loc.TermData>::Dispose();
            UniRx.Unit..cctor();
            if( == 1)
            {
                goto label_89;
            }
            
            if(( == 0) || ((-941269728 + (((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31))) << 2) == 435))
            {
                goto label_94;
            }
            
            label_93:
            val_40 = 0;
            label_94:
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
            label_89:
            if( != 0)
            {
                goto label_93;
            }
            
            goto label_94;
        }
        private static void AppendTerm(System.Text.StringBuilder Builder, int nLanguages, string Term, I2.Loc.TermData termData, string specialization, char Separator)
        {
            var val_14;
            string val_15;
            I2.Loc.LanguageSourceData.AppendString(Builder:  Builder, Text:  Term, Separator:  Separator);
            if((System.String.IsNullOrEmpty(value:  specialization)) != true)
            {
                    if((System.String.op_Inequality(a:  specialization, b:  "Any")) != false)
            {
                    System.Text.StringBuilder val_3 = Builder.AppendFormat(format:  "[{0}]", arg0:  specialization);
            }
            
            }
            
            System.Text.StringBuilder val_4 = Builder.Append(value:  Separator);
            string val_5 = termData.TermType.ToString();
            UniRx.Unit..cctor();
            mem2[0] = null;
            if(Builder != null)
            {
                    System.Text.StringBuilder val_6 = Builder.Append(value:  val_5);
            }
            else
            {
                    System.Text.StringBuilder val_7 = 0.Append(value:  val_5);
            }
            
            System.Text.StringBuilder val_8 = Builder.Append(value:  Separator);
            I2.Loc.LanguageSourceData.AppendString(Builder:  Builder, Text:  termData.Description, Separator:  Separator);
            val_14 = 0;
            goto label_14;
            label_24:
            System.Text.StringBuilder val_9 = Builder.Append(value:  Separator);
            val_15 = termData.Languages[0];
            if((System.String.IsNullOrEmpty(value:  specialization)) != true)
            {
                    val_15 = termData.GetTranslation(idx:  0, specialization:  specialization, editMode:  false);
            }
            
            I2.Loc.LanguageSourceData.AppendTranslation(Builder:  Builder, Text:  val_15, Separator:  Separator, tags:  0);
            val_14 = 1;
            label_14:
            if(val_14 < (UnityEngine.Mathf.Min(a:  nLanguages, b:  termData.Languages.Length)))
            {
                goto label_24;
            }
            
            System.Text.StringBuilder val_13 = Builder.Append(value:  "\n");
        }
        private static void AppendString(System.Text.StringBuilder Builder, string Text, char Separator)
        {
            if((System.String.IsNullOrEmpty(value:  Text)) == true)
            {
                    return;
            }
            
            string val_2 = Text.Replace(oldValue:  "\\n", newValue:  "\n");
            if(((val_2.IndexOfAny(anyOf:  Separator + "\n\"".ToCharArray())) & 2147483648) == 0)
            {
                    System.Text.StringBuilder val_7 = Builder.AppendFormat(format:  "\"{0}\"", arg0:  val_2.Replace(oldValue:  "\"", newValue:  "\"\""));
                return;
            }
            
            System.Text.StringBuilder val_8 = Builder.Append(value:  val_2);
        }
        private static void AppendTranslation(System.Text.StringBuilder Builder, string Text, char Separator, string tags)
        {
            string val_11 = Text;
            if((System.String.IsNullOrEmpty(value:  val_11 = Text)) == true)
            {
                    return;
            }
            
            val_11 = val_11.Replace(oldValue:  "\\n", newValue:  "\n");
            if(((val_11.IndexOfAny(anyOf:  Separator + "\n\"".ToCharArray())) & 2147483648) == 0)
            {
                    val_11 = val_11.Replace(oldValue:  "\"", newValue:  "\"\"");
                System.Text.StringBuilder val_7 = Builder.AppendFormat(format:  "\"{0}{1}\"", arg0:  tags, arg1:  val_11);
                return;
            }
            
            if(Builder != null)
            {
                    System.Text.StringBuilder val_8 = Builder.Append(value:  tags);
            }
            else
            {
                    System.Text.StringBuilder val_9 = 0.Append(value:  tags);
            }
            
            System.Text.StringBuilder val_10 = Builder.Append(value:  val_11);
        }
        public UnityEngine.Networking.UnityWebRequest Export_Google_CreateWWWcall(I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            UnityEngine.WWWForm val_2 = new UnityEngine.WWWForm();
            if(val_2 != null)
            {
                    val_2.AddField(fieldName:  "key", value:  this.Google_SpreadsheetKey);
                val_2.AddField(fieldName:  "action", value:  "SetLanguageSource");
            }
            else
            {
                    val_2.AddField(fieldName:  "key", value:  this.Google_SpreadsheetKey);
                val_2.AddField(fieldName:  "action", value:  "SetLanguageSource");
            }
            
            val_2.AddField(fieldName:  "data", value:  this.Export_Google_CreateData());
            UniRx.Unit..cctor();
            val_2.AddField(fieldName:  "updateMode", value:  UpdateMode.ToString());
            UnityEngine.Networking.UnityWebRequest val_5 = UnityEngine.Networking.UnityWebRequest.Post(uri:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  this), formData:  val_2);
            UnityEngine.Networking.UnityWebRequestAsyncOperation val_6 = val_5.SendWebRequest();
            return val_5;
        }
        private string Export_Google_CreateData()
        {
            var val_10;
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            List.Enumerator<T> val_3 = this.GetCategories(OnlyMainCategory:  true, Categories:  0).GetEnumerator();
            label_8:
            if(((-939959352) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = 0.Id;
            if((1 & 1) == 0)
            {
                    System.Text.StringBuilder val_5 = val_2.Append(value:  "<I2Loc>");
            }
            
            System.Text.StringBuilder val_7 = val_2.Append(value:  val_4);
            System.Text.StringBuilder val_8 = val_2.Append(value:  "<I2Loc>");
            System.Text.StringBuilder val_9 = val_2.Append(value:  this.Export_I2CSV(Category:  val_4, Separator:  ',', specializationsAsRows:  true));
            goto label_8;
            label_2:
            val_10 = public System.Void List.Enumerator<System.String>::Dispose();
            UniRx.Unit..cctor();
            if(val_2 != null)
            {
                    return (string)val_2;
            }
            
            return (string)val_2;
        }
        public string Import_CSV(string Category, string CSVstring, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1, char Separator = '\x2c')
        {
            return this.Import_CSV(Category:  Category, CSV:  I2.Loc.LocalizationReader.ReadCSV(Text:  CSVstring, Separator:  Separator), UpdateMode:  UpdateMode);
        }
        public string Import_I2CSV(string Category, string I2CSVstring, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            return this.Import_CSV(Category:  Category, CSV:  I2.Loc.LocalizationReader.ReadI2CSV(Text:  I2CSVstring), UpdateMode:  UpdateMode);
        }
        public string Import_CSV(string Category, System.Collections.Generic.List<string[]> CSV, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            System.String[] val_71;
            System.String[] val_72;
            I2.Loc.LanguageSourceData val_73;
            string val_74;
            int val_75;
            var val_76;
            var val_77;
            I2.Loc.TermData val_78;
            System.Int32[] val_79;
            int val_80;
            string val_81;
            I2.Loc.LanguageSourceData val_82;
            I2.Loc.LanguageSourceData val_83;
            I2.Loc.LanguageSourceData val_84;
            var val_85;
            string val_86;
            var val_87;
            I2.Loc.TermData val_88;
            var val_89;
            var val_90;
            string val_27 = 0;
            string val_28 = 0;
            System.String[] val_1 = CSV.Item[0];
            string[] val_2 = new string[1];
            val_71 = val_2;
            val_71[0] = "Key";
            string[] val_3 = new string[1];
            val_72 = val_3;
            val_72[0] = "Type";
            string[] val_4 = new string[2];
            val_4[0] = "Desc";
            val_73 = "Description";
            val_74 = "Description";
            val_4[1] = val_74;
            if(val_1 == null)
            {
                    val_73 = 0;
            }
            
            if((val_1.Length < 2) || ((this.ArrayContains(MainText:  val_1[0], texts:  val_2)) == false))
            {
                goto label_19;
            }
            
            if(UpdateMode == 1)
            {
                    val_73 = this;
                this.ClearAllData();
            }
            
            val_75 = val_1.Length;
            val_76 = 1;
            if(val_75 >= 3)
            {
                goto label_21;
            }
            
            goto label_22;
            label_19:
            val_77 = "Bad Spreadsheet Format.\nFirst columns should be \'Key\', \'Type\' and \'Desc\'";
            return (string)System.String.__il2cppRuntimeField_static_fields;
            label_21:
            bool val_6 = this.ArrayContains(MainText:  val_1[1], texts:  val_3);
            bool val_8 = val_6.ArrayContains(MainText:  val_1[1], texts:  val_4);
            val_75 = val_1.Length;
            label_22:
            if(val_75 > 3)
            {
                    bool val_12 = val_8.ArrayContains(MainText:  val_1[2], texts:  val_3);
                var val_13 = (val_12 != true) ? 2 : (((val_6 & true) != 0) ? (-val_76) : (val_76));
                bool val_14 = val_12.ArrayContains(MainText:  val_1[2], texts:  val_4);
                var val_16 = (val_14 != true) ? 2 : (((val_8 & true) != 0) ? (-1) : 1);
                var val_17 = ((val_12 | val_14) != true) ? 3 : (((val_6 | val_8) != true) ? (1 + 1) : 1);
            }
            
            val_78 = 0;
            int val_19 = UnityEngine.Mathf.Max(a:  val_1.Length - val_17, b:  0);
            val_71 = val_19;
            val_72 = new int[0];
            if(val_19 <= 0)
            {
                goto label_29;
            }
            
            var val_77 = 0;
            goto label_54;
            label_51:
            I2.Loc.LanguageData val_21 = new I2.Loc.LanguageData();
            if(val_21 != null)
            {
                    .Name = val_27;
                .Code = val_19;
            }
            else
            {
                    mem[16] = val_27;
                .Code = val_19;
            }
            
            .Flags = val_72[32];
            val_78 = public System.Void System.Collections.Generic.List<I2.Loc.LanguageData>::Add(I2.Loc.LanguageData item);
            this.mLanguages.Add(item:  val_21);
            val_80 = this.mLanguages.Count - 1;
            if(val_72 != null)
            {
                goto label_36;
            }
            
            goto label_36;
            label_54:
            var val_23 = val_17 + val_77;
            if(val_23 >= val_1.Length)
            {
                    val_78 = 0;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_1[(long)val_23])) == false)
            {
                goto label_38;
            }
            
            if(val_77 >= val_20.Length)
            {
                    val_78 = 0;
            }
            
            val_80 = 0;
            goto label_53;
            label_38:
            val_81 = mem[val_1[(long)(int)((val_15 != true ? 3 : val_10 != true ? (1 + 1) : 1 + 0))] + 32];
            val_81 = val_1[(long)(int)((val_15 != true ? 3 : val_10 != true ? (1 + 1) : 1 + 0))] + 32;
            if((val_81.StartsWith(value:  "$")) != false)
            {
                    val_81 = val_81.Substring(startIndex:  1);
            }
            
            I2.Loc.GoogleLanguages.UnPackCodeFromLanguageName(CodedLanguage:  val_81, Language: out  val_27, code: out  val_28);
            if((System.String.IsNullOrEmpty(value:  val_28)) != false)
            {
                    val_82 = this;
                val_78 = 1;
                int val_30 = this.GetLanguageIndex(language:  val_27, AllowDiscartingRegion:  true, SkipDisabled:  false);
            }
            else
            {
                    val_82 = this;
                val_78 = 1;
            }
            
            val_80 = this.GetLanguageIndexFromCode(Code:  val_28, exactMatch:  true, ignoreDisabled:  false);
            if((val_80 & 2147483648) != 0)
            {
                goto label_51;
            }
            
            label_36:
            val_79 = val_72[32];
            if(val_77 >= val_20.Length)
            {
                    val_78 = 0;
            }
            
            label_53:
            mem2[0] = val_80;
            val_77 = val_77 + 1;
            if(val_71 != val_77)
            {
                goto label_54;
            }
            
            val_83 = this;
            val_84 = 1152921512257541624;
            goto label_55;
            label_29:
            val_83 = this;
            val_84 = 1152921512257541624;
            label_55:
            int val_32 = val_84.Count;
            int val_33 = mem[1152921512257541584].Count;
            if(val_33 >= 1)
            {
                    do
            {
                val_78 = public I2.Loc.TermData System.Collections.Generic.List<I2.Loc.TermData>::get_Item(int index);
                I2.Loc.TermData val_34 = mem[1152921512257541584].Item[0];
                if(val_32 > val_34.Languages.Length)
            {
                    System.Array.Resize<System.String>(array: ref  val_34 + 40, newSize:  val_32);
                val_78 = public static System.Void System.Array::Resize<System.Byte>(ref T[] array, int newSize);
                System.Array.Resize<System.Byte>(array: ref  val_34.Flags, newSize:  val_32);
            }
            
                val_71 = 0 + 1;
            }
            while(val_33 != val_71);
            
            }
            
            val_74 = CSV;
            int val_37 = val_74.Count;
            val_85 = 1152921512251296432;
            if(val_37 < 2)
            {
                goto label_65;
            }
            
            label_118:
            System.String[] val_38 = val_74.Item[1];
            val_86 = val_38[0];
            if((System.String.IsNullOrEmpty(value:  Category)) != true)
            {
                    val_86 = Category + "/"("/") + val_86;
            }
            
            val_78 = 0;
            if((val_86.EndsWith(value:  "]")) != false)
            {
                    val_78 = 0;
                int val_42 = val_86.LastIndexOf(value:  '[');
                if(val_42 >= 1)
            {
                    if(val_86 != null)
            {
                    val_87 = val_86.Length;
            }
            else
            {
                    val_87 = 0.Length;
            }
            
                var val_78 = -2;
                val_78 = val_78 - val_42;
                string val_47 = val_86.Substring(startIndex:  val_42 + 1, length:  val_78 + val_87);
                val_78 = 0;
                string val_51 = val_86.Remove(startIndex:  val_42);
            }
            
            }
            
            I2.Loc.LanguageSourceData.ValidateFullTerm(Term: ref  val_51);
            if((System.String.IsNullOrEmpty(value:  val_51)) == true)
            {
                goto label_115;
            }
            
            val_78 = 0;
            val_88 = this.GetTermData(term:  val_51, allowCategoryMistmatch:  false);
            if(val_88 == null)
            {
                goto label_81;
            }
            
            if(UpdateMode != 3)
            {
                goto label_82;
            }
            
            goto label_115;
            label_81:
            I2.Loc.TermData val_54 = null;
            val_88 = val_54;
            val_54 = new I2.Loc.TermData();
            .Term = val_51;
            int val_55 = this.mLanguages.Count;
            .Languages = new string[0];
            int val_57 = this.mLanguages.Count;
            val_89 = 0;
            .Flags = new byte[0];
            goto label_87;
            label_95:
            if((I2.Loc.TermData)[1152921512257774304].Languages == null)
            {
                goto label_88;
            }
            
            if(System.String.alignConst != 0)
            {
                goto label_89;
            }
            
            goto label_92;
            label_88:
            if(System.String.alignConst == 0)
            {
                goto label_92;
            }
            
            label_89:
            label_92:
            (I2.Loc.TermData)[1152921512257774304].Languages[0] = System.String.alignConst;
            val_85 = 1152921512251296432;
            val_89 = 1;
            label_87:
            if(val_89 < this.mLanguages.Count)
            {
                goto label_95;
            }
            
            mem[1152921512257541584].Add(item:  val_54);
            val_78 = val_88;
            mem[1152921512257541600].Add(key:  val_51, value:  val_54);
            label_82:
            if(val_13 >= 1)
            {
                    if(val_13 >= val_38.Length)
            {
                    val_78 = 0;
            }
            
                .TermType = I2.Loc.LanguageSourceData.GetTermType(type:  val_38[(long)val_13]);
            }
            
            if(val_16 >= 1)
            {
                    if(val_16 >= val_38.Length)
            {
                    val_78 = 0;
            }
            
                string val_80 = val_38[(long)val_16];
                .Description = val_80;
            }
            
            val_90 = 0;
            goto label_106;
            label_117:
            var val_61 = val_17 + val_90;
            if(val_61 >= val_80)
            {
                    val_78 = 0;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_38[(long)val_61])) != true)
            {
                    if(val_90 >= val_20.Length)
            {
                    val_78 = 0;
            }
            
                int val_82 = val_72[0];
                if((val_82 & 2147483648) == 0)
            {
                    if((System.String.op_Equality(a:  val_38[(long)(int)((val_15 != true ? 3 : val_10 != true ? (1 + 1) : 1 + val_90))] + 32, b:  "-")) != false)
            {
                    val_78 = System.String.alignConst;
            }
            else
            {
                    string val_65 = ((System.String.op_Equality(a:  val_38[(long)(int)((val_15 != true ? 3 : val_10 != true ? (1 + 1) : 1 + val_90))] + 32, b:  "")) != true) ? 0 : (val_38[(long)(int)((val_15 != true ? 3 : val_10 != true ? (1 + 1) : 1 + val_90))] + 32);
            }
            
                val_54.SetTranslation(idx:  val_82, translation:  val_65, specialization:  ((System.String.op_Equality(a:  val_47, b:  "touch")) != true) ? "Touch" : (val_47));
            }
            
            }
            
            val_90 = 1;
            label_106:
            if(val_90 < val_20.Length)
            {
                    if(val_90 < (val_38.Length - val_17))
            {
                goto label_117;
            }
            
            }
            
            label_115:
            val_74 = CSV;
            val_71 = 1 + 1;
            if(val_71 != val_37)
            {
                goto label_118;
            }
            
            label_65:
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_74 = this;
            this.SaveLanguages(unloadAll:  this.HasUnloadedLanguages(), fileLocation:  val_65);
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        private bool ArrayContains(string MainText, string[] texts)
        {
            int val_2;
            var val_3;
            var val_4;
            if(texts.Length < 1)
            {
                goto label_3;
            }
            
            val_2 = texts.Length & 4294967295;
            val_3 = 0;
            goto label_2;
            label_6:
            val_3 = 1;
            if(val_3 >= (long)val_2)
            {
                goto label_3;
            }
            
            val_2 = texts.Length;
            label_2:
            if(((MainText.IndexOf(value:  X21, comparisonType:  5)) & 2147483648) != 0)
            {
                goto label_6;
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_3:
            val_4 = 0;
            return (bool)val_4;
        }
        public static I2.Loc.eTermType GetTermType(string type)
        {
            var val_3;
            var val_4 = 0;
            label_4:
            UniRx.Unit..cctor();
            if((System.String.Equals(a:  val_4 + 1.ToString(), b:  type, comparisonType:  5)) == true)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            if(val_4 <= 9)
            {
                goto label_4;
            }
            
            val_3 = 0;
            return (I2.Loc.eTermType)val_3;
            label_3:
            val_3 = val_4 + 1;
            return (I2.Loc.eTermType)val_3;
        }
        private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
        {
            var val_16;
            var val_17;
            int val_18;
            val_16 = onlyCurrentSpecialization;
            val_17 = 0;
            goto label_1;
            label_28:
            val_16 = langData.IndexOf(value:  "[i2t]", startIndex:  0);
            if((val_16 & 2147483648) != 0)
            {
                goto label_3;
            }
            
            label_12:
            val_18 = langData.IndexOf(value:  "=", startIndex:  0);
            if(val_18 >= val_16)
            {
                    return;
            }
            
            if((this.GetTermData(term:  langData.Substring(startIndex:  0, length:  val_18 - val_17), allowCategoryMistmatch:  false)) == null)
            {
                goto label_7;
            }
            
            val_18 = val_18 + 1;
            if(val_18 != val_16)
            {
                goto label_8;
            }
            
            val_18 = 0;
            goto label_18;
            label_3:
            int val_8 = langData.Length;
            if(langData != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_8:
            string val_9 = langData.Substring(startIndex:  val_18, length:  val_16 - val_18);
            bool val_10 = val_9.StartsWith(value:  "[i2fb]");
            val_18 = (val_10 != true) ? 0 : (val_9);
            if((val_10 != false) && (useFallback != false))
            {
                    val_18 = val_9.Substring(startIndex:  6);
            }
            
            var val_12 = (val_18 == null) ? 1 : 0;
            val_12 = val_12 | val_16 ^ 1;
            if(val_12 != true)
            {
                    val_18 = I2.Loc.SpecializationManager.GetSpecializedText(text:  val_18, specialization:  0);
            }
            
            label_18:
            if(val_6.Languages == null)
            {
                goto label_21;
            }
            
            if(val_18 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_18 == null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            val_6.Languages[(long)langIndex] = val_18;
            label_7:
            val_17 = val_16 + 5;
            label_1:
            if(val_17 < langData.Length)
            {
                goto label_28;
            }
        
        }
        public static void FreeUnusedLanguages()
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            goto label_5;
            label_16:
            I2.Loc.TermData val_4 = val_1.mTerms.Item[0];
            val_8 = 0;
            goto label_7;
            label_13:
            if((I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  I2.Loc.LocalizationManager.CurrentLanguage, AllowDiscartingRegion:  true, SkipDisabled:  true)) != val_8)
            {
                    val_4.Languages[0] = 0;
            }
            
            val_8 = 1;
            label_7:
            if(val_8 < val_4.Languages.Length)
            {
                goto label_13;
            }
            
            val_7 = 1;
            label_5:
            if(val_7 < val_1.mTerms.Count)
            {
                goto label_16;
            }
        
        }
        public void Import_Google_FromCache()
        {
            string val_22;
            var val_23;
            string val_24;
            if(this.GoogleUpdateFrequency == 1)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            string val_2 = this.GetSourcePlayerPrefName();
            string val_4 = I2.Loc.PersistentStorage.LoadFile(fileType:  1, fileName:  "I2Source_" + val_2 + ".loc", logExceptions:  false);
            val_22 = val_4;
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    return;
            }
            
            if((val_22.StartsWith(value:  "[i2e]", comparisonType:  4)) != false)
            {
                    if(val_22 != null)
            {
                    val_23 = val_22.Length;
            }
            else
            {
                    val_23 = 0.Length;
            }
            
                val_22 = I2.Loc.StringObfucator.Decode(ObfucatedString:  val_22.Substring(startIndex:  5, length:  val_23 - 5));
            }
            
            if((I2.Loc.PersistentStorage.HasSetting(key:  "I2SourceVersion_" + val_2)) != false)
            {
                    string val_15 = I2.Loc.PersistentStorage.GetSetting_String(key:  "I2SourceVersion_" + val_2, defaultValue:  this.Google_LastUpdatedVersion);
                val_24 = val_15;
                if((val_15.IsNewerVersion(currentVersion:  this.Google_LastUpdatedVersion, newVersion:  val_24)) != false)
            {
                    if(val_24.Length >= 20)
            {
                    val_24 = System.String.alignConst;
            }
            
                this.Google_LastUpdatedVersion = val_24;
                string val_18 = this.Import_Google_Result(JsonString:  val_22, UpdateMode:  1, saveInPlayerPrefs:  false);
                return;
            }
            
            }
            
            bool val_20 = I2.Loc.PersistentStorage.DeleteFile(fileType:  1, fileName:  "I2Source_" + val_2 + ".loc", logExceptions:  false);
            I2.Loc.PersistentStorage.DeleteSetting(key:  "I2SourceVersion_" + val_2);
        }
        private bool IsNewerVersion(string currentVersion, string newVersion)
        {
            var val_8;
            long val_3 = 0;
            long val_5 = 0;
            if((System.String.IsNullOrEmpty(value:  newVersion)) != false)
            {
                    val_8 = 0;
                return (bool)val_8;
            }
            
            if((System.String.IsNullOrEmpty(value:  currentVersion)) != true)
            {
                    if((System.Int64.TryParse(s:  newVersion, result: out  val_3)) != false)
            {
                    if((System.Int64.TryParse(s:  currentVersion, result: out  val_5)) != false)
            {
                    var val_7 = (val_3 > val_5) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        public void Import_Google(bool ForceUpdate, bool justCheck)
        {
            string val_15;
            if(ForceUpdate != true)
            {
                    if(this.GoogleUpdateFrequency == 1)
            {
                    return;
            }
            
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_15 = this.GetSourcePlayerPrefName();
            if(((this.GoogleUpdateFrequency == 0) || (ForceUpdate == true)) || ((System.DateTime.TryParse(s:  I2.Loc.PersistentStorage.GetSetting_String(key:  "LastGoogleUpdate_" + val_15, defaultValue:  ""), result: out  new System.DateTime())) == false))
            {
                goto label_11;
            }
            
            System.DateTime val_6 = System.DateTime.Now;
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6.dateData}, d2:  new System.DateTime());
            if((this.GoogleUpdateFrequency - 2) > 3)
            {
                goto label_11;
            }
            
            var val_15 = 28872624 + ((this.GoogleUpdateFrequency - 2)) << 2;
            val_15 = val_15 + 28872624;
            goto (28872624 + ((this.GoogleUpdateFrequency - 2)) << 2 + 28872624);
            label_11:
            val_15 = "LastGoogleUpdate_" + val_15;
            System.DateTime val_11 = System.DateTime.Now;
            I2.Loc.PersistentStorage.SetSetting_String(key:  val_15, value:  val_11.dateData);
            UnityEngine.Coroutine val_14 = I2.Loc.CoroutineManager.Start(coroutine:  this.Import_Google_Coroutine(JustCheck:  justCheck));
        }
        private string GetSourcePlayerPrefName()
        {
            I2.Loc.ILanguageSource val_11;
            var val_12;
            var val_13;
            var val_14;
            val_11 = this.owner;
            if(val_11 == null)
            {
                    return (string)val_11;
            }
            
            val_12 = null;
            val_12 = null;
            val_11 = name;
            if((System.String.IsNullOrEmpty(value:  this.Google_SpreadsheetKey)) != true)
            {
                    val_11 = val_11 + this.Google_SpreadsheetKey;
            }
            
            val_13 = null;
            val_13 = null;
            if(this.owner != null)
            {
                    val_14 = null;
                val_14 = null;
                var val_5 = (((I2.Loc.ILanguageSource.__il2cppRuntimeField_typeHierarchy + (UnityEngine.Object.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_14) ? this.owner : 0;
            }
            
            if(((System.Array.IndexOf<System.String>(array:  I2.Loc.LocalizationManager.GlobalSources, value:  0.name)) & 2147483648) == 0)
            {
                    return (string)val_11;
            }
            
            UnityEngine.SceneManagement.Scene val_8 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_11 = val_8.m_Handle.name + "_" + val_11;
            return (string)val_11;
        }
        private System.Collections.IEnumerator Import_Google_Coroutine(bool JustCheck)
        {
            LanguageSourceData.<Import_Google_Coroutine>d__65 val_1 = new LanguageSourceData.<Import_Google_Coroutine>d__65(<>1__state:  0);
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .JustCheck = JustCheck;
            return (System.Collections.IEnumerator)val_1;
        }
        private void ApplyDownloadedDataOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void I2.Loc.LanguageSourceData::ApplyDownloadedDataOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
            this.ApplyDownloadedDataFromGoogle();
        }
        public void ApplyDownloadedDataFromGoogle()
        {
            object val_4;
            if((System.String.IsNullOrEmpty(value:  this.mDelayedGoogleData)) != false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.Import_Google_Result(JsonString:  this.mDelayedGoogleData, UpdateMode:  1, saveInPlayerPrefs:  true))) != false)
            {
                    if(this.Event_OnSourceUpdateFromGoogle != null)
            {
                    this.Event_OnSourceUpdateFromGoogle.Invoke(arg1:  this, arg2:  true, arg3:  "");
            }
            
                I2.Loc.LocalizationManager.LocalizeAll(Force:  true);
                val_4 = "Done Google Sync";
            }
            else
            {
                    if(this.Event_OnSourceUpdateFromGoogle != null)
            {
                    this.Event_OnSourceUpdateFromGoogle.Invoke(arg1:  this, arg2:  false, arg3:  "");
            }
            
                val_4 = "Done Google Sync: source was up-to-date";
            }
            
            UnityEngine.Debug.Log(message:  val_4);
        }
        public UnityEngine.Networking.UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
        {
            int val_12;
            var val_13;
            if(this.HasGoogleSpreadsheet() != false)
            {
                    val_12 = I2.Loc.PersistentStorage.GetSetting_String(key:  "I2SourceVersion_" + this.GetSourcePlayerPrefName(), defaultValue:  this.Google_LastUpdatedVersion);
                int val_5 = val_12.Length;
                if(val_5 >= 20)
            {
                    val_12 = System.String.alignConst;
            }
            
                if((val_5.IsNewerVersion(currentVersion:  val_12, newVersion:  this.Google_LastUpdatedVersion)) != false)
            {
                    this.Google_LastUpdatedVersion = val_12;
            }
            
                val_13 = UnityEngine.Networking.UnityWebRequest.Get(uri:  System.String.Format(format:  "{0}?key={1}&action=GetLanguageSource&version={2}", arg0:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  this), arg1:  this.Google_SpreadsheetKey, arg2:  (ForceUpdate != true) ? "0" : (this.Google_LastUpdatedVersion)));
                UnityEngine.Networking.UnityWebRequestAsyncOperation val_11 = val_13.SendWebRequest();
                return (UnityEngine.Networking.UnityWebRequest)val_13;
            }
            
            val_13 = 0;
            return (UnityEngine.Networking.UnityWebRequest)val_13;
        }
        public bool HasGoogleSpreadsheet()
        {
            var val_6;
            if((System.String.IsNullOrEmpty(value:  this.Google_WebServiceURL)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  this.Google_SpreadsheetKey)) == false)
            {
                goto label_2;
            }
            
            }
            
            val_6 = 0;
            goto label_3;
            label_2:
            bool val_4 = System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  this));
            val_6 = val_4 ^ 1;
            label_3:
            val_4 = val_6;
            return (bool)val_4;
        }
        public string Import_Google_Result(string JsonString, I2.Loc.eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = False)
        {
            string val_35;
            I2.Loc.eSpreadsheetUpdateMode val_36;
            int val_37;
            var val_38;
            int val_39;
            var val_40;
            var val_41;
            int val_42;
            System.StringComparison val_43;
            var val_44;
            var val_45;
            var val_46;
            val_35 = saveInPlayerPrefs;
            val_36 = UpdateMode;
            val_37 = System.String.alignConst;
            if((System.String.IsNullOrEmpty(value:  JsonString)) == true)
            {
                    return (string)val_46;
            }
            
            if((System.String.op_Equality(a:  JsonString, b:  "\"\"")) == true)
            {
                    return (string)val_46;
            }
            
            val_38 = "version=";
            int val_35 = JsonString.IndexOf(value:  "version=", comparisonType:  4);
            val_39 = JsonString.IndexOf(value:  "script_version=", comparisonType:  4);
            if(((val_39 | val_35) & 2147483648) != 0)
            {
                goto label_5;
            }
            
            val_40 = "version=";
            if(("version=") == null)
            {
                    val_40 = "version=";
            }
            
            val_41 = "script_version=";
            if(("script_version=") == null)
            {
                    val_41 = "script_version=";
            }
            
            val_35 = Length + val_35;
            int val_36 = val_35;
            val_38 = JsonString.IndexOf(value:  ",", startIndex:  val_36, comparisonType:  4);
            val_36 = val_38 - val_35;
            val_42 = JsonString.Substring(startIndex:  val_35, length:  val_36);
            val_39 = Length + val_39;
            int val_37 = val_39;
            val_37 = (JsonString.IndexOf(value:  ",", startIndex:  val_37, comparisonType:  4)) - val_39;
            val_39 = System.Int32.Parse(s:  JsonString.Substring(startIndex:  val_39, length:  val_37));
            val_36 = val_36;
            if(val_42.Length >= 20)
            {
                    val_42 = System.String.alignConst;
            }
            
            int val_14 = I2.Loc.LocalizationManager.GetRequiredWebServiceVersion();
            if(val_39 != val_14)
            {
                goto label_16;
            }
            
            if(val_35 != false)
            {
                    bool val_15 = val_14.IsNewerVersion(currentVersion:  this.Google_LastUpdatedVersion, newVersion:  val_42);
                if(val_15 == false)
            {
                    return (string)val_46;
            }
            
                val_35 = this.GetSourcePlayerPrefName();
                val_39 = "I2Source_" + val_35 + ".loc";
                bool val_20 = I2.Loc.PersistentStorage.SaveFile(fileType:  1, fileName:  val_39, data:  "[i2e]" + I2.Loc.StringObfucator.Encode(NormalString:  JsonString)(I2.Loc.StringObfucator.Encode(NormalString:  JsonString)), logExceptions:  true);
                I2.Loc.PersistentStorage.SetSetting_String(key:  "I2SourceVersion_" + val_35, value:  val_42);
                I2.Loc.PersistentStorage.ForceSaveSettings();
            }
            
            this.Google_LastUpdatedVersion = val_42;
            if(val_36 == 1)
            {
                    this.ClearAllData();
            }
            
            val_43 = 4;
            int val_22 = JsonString.IndexOf(value:  "[i2category]", comparisonType:  val_43);
            if(val_22 >= 1)
            {
                    val_38 = "[/i2category]";
                do
            {
                val_44 = "[i2category]";
                if("[i2category]" == null)
            {
                    val_44 = "[i2category]";
            }
            
                int val_38 = Length;
                val_38 = val_38 + val_22;
                int val_39 = val_38;
                int val_24 = JsonString.IndexOf(value:  "[/i2category]", startIndex:  val_39, comparisonType:  4);
                val_39 = val_24 - val_38;
                val_35 = JsonString.Substring(startIndex:  val_38, length:  val_39);
                val_45 = "[/i2category]";
                if(("[/i2category]") == null)
            {
                    val_45 = "[/i2category]";
            }
            
                int val_40 = Length;
                val_40 = val_40 + val_24;
                int val_41 = val_40;
                int val_27 = JsonString.IndexOf(value:  "[/i2csv]", startIndex:  val_41, comparisonType:  4);
                val_41 = val_27 - val_40;
                val_39 = JsonString.Substring(startIndex:  val_40, length:  val_41);
                val_43 = I2.Loc.LocalizationReader.ReadI2CSV(Text:  val_39);
                string val_31 = this.Import_CSV(Category:  val_35, CSV:  val_43, UpdateMode:  val_36);
                var val_32 = (val_36 == 1) ? 2 : (val_36);
            }
            while((JsonString.IndexOf(value:  "[i2category]", startIndex:  val_27, comparisonType:  4)) >= 1);
            
            }
            
            this.GoogleLiveSyncIsUptoDate = true;
            if(UnityEngine.Application.isPlaying != false)
            {
                    this.SaveLanguages(unloadAll:  true, fileLocation:  val_43);
            }
            
            bool val_34 = System.String.IsNullOrEmpty(value:  val_37);
            return (string)val_46;
            label_5:
            val_46 = "Invalid Response from Google, Most likely the WebService needs to be updated";
            return (string)val_46;
            label_16:
            val_46 = "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
            return (string)val_46;
        }
        public int GetLanguageIndex(string language, bool AllowDiscartingRegion = True, bool SkipDisabled = True)
        {
            var val_11;
            var val_12;
            var val_13;
            string val_14;
            val_11 = AllowDiscartingRegion;
            int val_1 = this.mLanguages.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_12 = 1152921512252851632;
            val_13 = 0;
            label_10:
            if(SkipDisabled == false)
            {
                goto label_3;
            }
            
            val_14 = this.mLanguages.Item[0];
            if((val_2.Flags & 1) != 0)
            {
                goto label_6;
            }
            
            label_3:
            val_14 = this.mLanguages.Item[0];
            if((System.String.Compare(strA:  val_3.Name, strB:  language, comparisonType:  5)) == 0)
            {
                    return (int)val_13;
            }
            
            label_6:
            val_13 = val_13 + 1;
            if(val_13 < val_1)
            {
                goto label_10;
            }
            
            label_2:
            if(val_11 == false)
            {
                goto label_13;
            }
            
            val_11 = this.mLanguages.Count;
            if(val_11 < 1)
            {
                goto label_13;
            }
            
            val_12 = 1152921512252851632;
            var val_11 = 0;
            val_13 = 0;
            label_22:
            if(SkipDisabled == false)
            {
                goto label_14;
            }
            
            val_14 = this.mLanguages.Item[0];
            if((val_6.Flags & 1) != 0)
            {
                goto label_17;
            }
            
            label_14:
            I2.Loc.LanguageData val_7 = this.mLanguages.Item[0];
            val_14 = val_7.Name;
            int val_8 = I2.Loc.LanguageSourceData.GetCommonWordInLanguageNames(Language1:  val_14, Language2:  language);
            var val_9 = (val_8 > 0) ? (val_8) : 0;
            label_17:
            val_11 = val_11 + 1;
            if(val_11 != val_11)
            {
                goto label_22;
            }
            
            if((((val_8 > 0) ? (val_11) : (val_13)) & 2147483648) == 0)
            {
                    return (int)val_13;
            }
            
            label_13:
            val_13 = 0;
            return (int)val_13;
        }
        public I2.Loc.LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = True)
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_3;
            var val_4;
            val_3 = this;
            AllowDiscartingRegion = AllowDiscartingRegion;
            int val_1 = this.GetLanguageIndex(language:  language, AllowDiscartingRegion:  AllowDiscartingRegion, SkipDisabled:  false);
            if((val_1 & 2147483648) == 0)
            {
                    val_3 = this.mLanguages;
                I2.Loc.LanguageData val_2 = val_3.Item[val_1];
                return (I2.Loc.LanguageData)val_4;
            }
            
            val_4 = 0;
            return (I2.Loc.LanguageData)val_4;
        }
        public bool IsCurrentLanguage(int languageIndex)
        {
            if(this.mLanguages.Item[languageIndex] != null)
            {
                    return System.String.op_Equality(a:  I2.Loc.LocalizationManager.CurrentLanguage, b:  val_2.Name);
            }
            
            return System.String.op_Equality(a:  I2.Loc.LocalizationManager.CurrentLanguage, b:  val_2.Name);
        }
        public int GetLanguageIndexFromCode(string Code, bool exactMatch = True, bool ignoreDisabled = False)
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = exactMatch;
            int val_1 = this.mLanguages.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_10 = 0;
            label_10:
            if(ignoreDisabled == false)
            {
                goto label_3;
            }
            
            val_11 = this.mLanguages.Item[0];
            if((val_2.Flags & 1) != 0)
            {
                goto label_6;
            }
            
            label_3:
            val_11 = this.mLanguages.Item[0];
            if((System.String.Compare(strA:  val_3.Code, strB:  Code, comparisonType:  5)) == 0)
            {
                    return (int)val_10;
            }
            
            label_6:
            val_10 = val_10 + 1;
            if(val_10 < val_1)
            {
                goto label_10;
            }
            
            label_2:
            if(val_9 == true)
            {
                goto label_13;
            }
            
            val_9 = this.mLanguages.Count;
            if(val_9 < 1)
            {
                goto label_13;
            }
            
            val_11 = 1152921512252851632;
            val_10 = 0;
            label_21:
            if(ignoreDisabled == false)
            {
                goto label_14;
            }
            
            I2.Loc.LanguageData val_6 = this.mLanguages.Item[0];
            if((val_6.Flags & 1) != 0)
            {
                goto label_17;
            }
            
            label_14:
            I2.Loc.LanguageData val_7 = this.mLanguages.Item[0];
            if((System.String.Compare(strA:  val_7.Code, indexA:  0, strB:  Code, indexB:  0, length:  2, comparisonType:  5)) == 0)
            {
                    return (int)val_10;
            }
            
            label_17:
            val_10 = val_10 + 1;
            if(val_10 < val_9)
            {
                goto label_21;
            }
            
            label_13:
            val_10 = 0;
            return (int)val_10;
        }
        public static int GetCommonWordInLanguageNames(string Language1, string Language2)
        {
            System.Collections.Generic.IEnumerable<TSource> val_12;
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            val_13 = Language1;
            if((System.String.IsNullOrEmpty(value:  val_13)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  Language2)) == false)
            {
                goto label_2;
            }
            
            }
            
            val_14 = 0;
            return (int)val_14;
            label_2:
            System.Char[] val_3 = ToCharArray();
            val_13 = val_13.ToLower().Split(separator:  val_3);
            val_12 = Language2.ToLower().Split(separator:  val_3);
            val_15 = 0;
            val_14 = 0;
            goto label_9;
            label_13:
            string val_12 = val_13[0];
            if((System.String.IsNullOrEmpty(value:  val_12)) != true)
            {
                    val_13[0] = System.Linq.Enumerable.Contains<System.String>(source:  val_12, value:  val_12);
                val_14 = val_14 + val_13[0];
            }
            
            val_15 = 1;
            label_9:
            if(val_15 < val_5.Length)
            {
                goto label_13;
            }
            
            val_16 = 0;
            goto label_14;
            label_18:
            string val_13 = val_12[0];
            if((System.String.IsNullOrEmpty(value:  val_13)) != true)
            {
                    val_12[0] = System.Linq.Enumerable.Contains<System.String>(source:  val_13, value:  val_13);
                val_14 = val_14 + val_12[0];
            }
            
            val_16 = 1;
            label_14:
            if(val_16 < val_7.Length)
            {
                goto label_18;
            }
            
            return (int)val_14;
        }
        public static bool AreTheSameLanguage(string Language1, string Language2)
        {
            return (bool)((System.String.Compare(strA:  I2.Loc.LanguageSourceData.GetLanguageWithoutRegion(Language:  Language1), strB:  I2.Loc.LanguageSourceData.GetLanguageWithoutRegion(Language:  Language2), comparisonType:  5)) == 0) ? 1 : 0;
        }
        public static string GetLanguageWithoutRegion(string Language)
        {
            int val_2 = Language.IndexOfAny(anyOf:  ToCharArray());
            if((val_2 & 2147483648) != 0)
            {
                    return (string)Language;
            }
            
            string val_3 = Language.Substring(startIndex:  0, length:  val_2);
            if(val_3 != null)
            {
                    return val_3.Trim();
            }
            
            return val_3.Trim();
        }
        public void AddLanguage(string LanguageName)
        {
            this.AddLanguage(LanguageName:  LanguageName, LanguageCode:  I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  LanguageName, ShowWarnings:  false));
        }
        public void AddLanguage(string LanguageName, string LanguageCode)
        {
            string val_9 = LanguageName;
            if(((this.GetLanguageIndex(language:  val_9 = LanguageName, AllowDiscartingRegion:  false, SkipDisabled:  true)) & 2147483648) == 0)
            {
                    return;
            }
            
            I2.Loc.LanguageData val_2 = new I2.Loc.LanguageData();
            if(val_2 != null)
            {
                    .Name = val_9;
            }
            else
            {
                    mem[16] = val_9;
            }
            
            .Code = LanguageCode;
            this.mLanguages.Add(item:  val_2);
            int val_3 = this.mLanguages.Count;
            val_9 = this.mTerms.Count;
            if(val_9 < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                I2.Loc.TermData val_5 = this.mTerms.Item[0];
                System.Array.Resize<System.String>(array: ref  val_5.Languages, newSize:  val_3);
                I2.Loc.TermData val_7 = this.mTerms.Item[0];
                System.Array.Resize<System.Byte>(array: ref  val_7.Flags, newSize:  val_3);
                val_9 = val_9 + 1;
            }
            while(val_9 != val_9);
        
        }
        public void RemoveLanguage(string LanguageName)
        {
            int val_14;
            int val_1 = this.GetLanguageIndex(language:  LanguageName, AllowDiscartingRegion:  false, SkipDisabled:  false);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            int val_2 = this.mLanguages.Count;
            int val_3 = this.mTerms.Count;
            if(val_3 < 1)
            {
                goto label_4;
            }
            
            int val_4 = val_2 - 1;
            var val_16 = 0;
            label_29:
            val_14 = val_1;
            goto label_5;
            label_26:
            I2.Loc.TermData val_5 = this.mTerms.Item[0];
            string val_14 = val_5.Languages[(long)(long)(int)(W28)];
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            if(val_14 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_14 == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            int val_6 = val_3 + (((long)(int)(val_1)) << 3);
            mem2[0] = val_14;
            I2.Loc.TermData val_7 = this.mTerms.Item[0];
            I2.Loc.TermData val_8 = this.mTerms.Item[0];
            val_14 = W28;
            val_7.Flags[(long)val_14] = val_8.Flags[(long)(long)(int)(W28)];
            label_5:
            I2.Loc.TermData val_10 = this.mTerms.Item[0];
            if((val_14 + 1) < val_2)
            {
                goto label_26;
            }
            
            System.Array.Resize<System.String>(array: ref  val_10.Languages, newSize:  val_4);
            I2.Loc.TermData val_12 = this.mTerms.Item[0];
            System.Array.Resize<System.Byte>(array: ref  val_12.Flags, newSize:  val_4);
            val_16 = val_16 + 1;
            if(val_16 != val_3)
            {
                goto label_29;
            }
            
            label_4:
            this.mLanguages.RemoveAt(index:  val_1);
        }
        public System.Collections.Generic.List<string> GetLanguages(bool skipDisabled = True)
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            int val_2 = this.mLanguages.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_5 = 0;
            label_10:
            if(skipDisabled == false)
            {
                goto label_3;
            }
            
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[0];
            if((val_3.Flags & 1) != 0)
            {
                goto label_6;
            }
            
            label_3:
            I2.Loc.LanguageData val_4 = this.mLanguages.Item[0];
            val_1.Add(item:  val_4.Name);
            label_6:
            val_5 = val_5 + 1;
            if(val_2 != val_5)
            {
                goto label_10;
            }
            
            return val_1;
        }
        public System.Collections.Generic.List<string> GetLanguagesCode(bool allowRegions = True, bool skipDisabled = True)
        {
            string val_9;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            int val_2 = this.mLanguages.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_9 = 0;
            label_16:
            if(skipDisabled == false)
            {
                goto label_3;
            }
            
            val_9 = this.mLanguages.Item[0];
            if((val_3.Flags & 1) != 0)
            {
                goto label_14;
            }
            
            label_3:
            I2.Loc.LanguageData val_4 = this.mLanguages.Item[0];
            val_9 = val_4.Code;
            if((val_9 != null) && (allowRegions != true))
            {
                    if(val_9.Length >= 3)
            {
                    val_9 = val_9.Substring(startIndex:  0, length:  2);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  val_9)) != true)
            {
                    if((val_1.Contains(item:  val_9)) != true)
            {
                    val_1.Add(item:  val_9);
            }
            
            }
            
            label_14:
            val_9 = val_9 + 1;
            if(val_2 != val_9)
            {
                goto label_16;
            }
            
            return val_1;
        }
        public bool IsLanguageEnabled(string Language)
        {
            var val_4;
            var val_5;
            val_4 = this;
            int val_1 = this.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  true);
            if((val_1 & 2147483648) == 0)
            {
                    val_4 = this.mLanguages.Item[val_1];
                var val_3 = ((val_2.Flags & 1) != 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public void EnableLanguage(string Language, bool bEnabled)
        {
            int val_1 = this.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  true);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            I2.Loc.LanguageData val_2 = this.mLanguages.Item[val_1];
            byte val_5 = val_2.Flags;
            val_5 = val_5 & 254;
            val_2.Flags = (bEnabled != true) ? (val_5) : (val_5 | 1);
        }
        public bool AllowUnloadingLanguages()
        {
            return (bool)(this._AllowUnloadingLanguages != 0) ? 1 : 0;
        }
        private string GetSavedLanguageFileName(int languageIndex)
        {
            if((languageIndex & 2147483648) != 0)
            {
                    return 0;
            }
            
            string[] val_1 = new string[5];
            val_1[0] = "LangSource_";
            val_1[1] = this.GetSourcePlayerPrefName();
            val_1[2] = "_";
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[languageIndex];
            val_1[3] = val_3.Name;
            val_1[4] = ".loc";
            return +val_1;
        }
        public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
        {
            bool val_10;
            var val_11;
            val_10 = useFallback;
            val_11 = UnloadOtherLanguages;
            if(this._AllowUnloadingLanguages == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            if((languageIndex & 2147483648) != 0)
            {
                goto label_8;
            }
            
            if(forceLoad == true)
            {
                goto label_4;
            }
            
            I2.Loc.LanguageData val_2 = this.mLanguages.Item[languageIndex];
            if((val_2.Flags & 4) == 0)
            {
                goto label_8;
            }
            
            label_4:
            string val_4 = I2.Loc.PersistentStorage.LoadFile(fileType:  2, fileName:  this.GetSavedLanguageFileName(languageIndex:  languageIndex), logExceptions:  false);
            if((System.String.IsNullOrEmpty(value:  val_4)) != true)
            {
                    onlyCurrentSpecialization = onlyCurrentSpecialization;
                this.Import_Language_from_Cache(langIndex:  languageIndex, langData:  val_4, useFallback:  val_10, onlyCurrentSpecialization:  onlyCurrentSpecialization);
                I2.Loc.LanguageData val_7 = this.mLanguages.Item[languageIndex];
                byte val_10 = val_7.Flags;
                val_10 = val_10 & 251;
                val_7.Flags = val_10;
            }
            
            label_8:
            if(val_11 == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_10 = 1152921512251296432;
            val_11 = 0;
            goto label_13;
            label_16:
            if(languageIndex != val_11)
            {
                    this.UnloadLanguage(languageIndex:  0);
            }
            
            val_11 = 1;
            label_13:
            if(val_11 < this.mLanguages.Count)
            {
                goto label_16;
            }
        
        }
        public void LoadAllLanguages(bool forceLoad = False)
        {
            goto label_1;
            label_3:
            this.LoadLanguage(languageIndex:  0, UnloadOtherLanguages:  false, useFallback:  false, onlyCurrentSpecialization:  false, forceLoad:  forceLoad);
            0 = 1;
            label_1:
            if(0 < this.mLanguages.Count)
            {
                goto label_3;
            }
        
        }
        public void UnloadLanguage(int languageIndex)
        {
            System.Collections.Generic.List<I2.Loc.TermData> val_12;
            int val_13 = languageIndex;
            if(this._AllowUnloadingLanguages == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_12 = this.mLanguages.Item[val_13];
            if((val_3.Flags & 4) != 0)
            {
                    return;
            }
            
            val_12 = this.mLanguages.Item[val_13];
            if((val_4.Flags & 2) != 0)
            {
                    return;
            }
            
            if((this.IsCurrentLanguage(languageIndex:  val_13 = languageIndex)) == true)
            {
                    return;
            }
            
            if((I2.Loc.PersistentStorage.HasFile(fileType:  2, fileName:  this.GetSavedLanguageFileName(languageIndex:  val_13), logExceptions:  true)) == false)
            {
                    return;
            }
            
            val_12 = this.mTerms;
            List.Enumerator<T> val_8 = val_12.GetEnumerator();
            goto label_13;
            label_17:
            string val_10 = 0.Id + (((long)(int)(languageIndex)) << 3);
            mem2[0] = 0;
            label_13:
            if(((-932882296) & 1) != 0)
            {
                goto label_17;
            }
            
            UniRx.Unit..cctor();
            val_13 = this.mLanguages.Item[val_13];
            byte val_12 = val_11.Flags;
            val_12 = val_12 | 4;
            val_11.Flags = val_12;
        }
        public void SaveLanguages(bool unloadAll, I2.Loc.PersistentStorage.eFileType fileLocation = 2)
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_11;
            var val_12;
            if(this._AllowUnloadingLanguages == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            val_11 = 0;
            goto label_3;
            label_6:
            string val_4 = this.Export_Language_to_Cache(langIndex:  0, fillTermWithFallback:  this.IsCurrentLanguage(languageIndex:  0));
            if((System.String.IsNullOrEmpty(value:  val_4)) != true)
            {
                    bool val_7 = I2.Loc.PersistentStorage.SaveFile(fileType:  2, fileName:  this.GetSavedLanguageFileName(languageIndex:  0), data:  val_4, logExceptions:  true);
            }
            
            val_11 = 1;
            label_3:
            if(val_11 < this.mLanguages.Count)
            {
                goto label_6;
            }
            
            if(unloadAll == false)
            {
                    return;
            }
            
            val_12 = 0;
            goto label_8;
            label_11:
            if((this.IsCurrentLanguage(languageIndex:  0)) != true)
            {
                    this.UnloadLanguage(languageIndex:  0);
            }
            
            val_12 = 1;
            label_8:
            val_11 = this.mLanguages;
            if(val_12 < val_11.Count)
            {
                goto label_11;
            }
        
        }
        public bool HasUnloadedLanguages()
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_3;
            var val_4;
            var val_3 = 0;
            label_5:
            val_3 = this.mLanguages;
            if(val_3 >= val_3.Count)
            {
                goto label_2;
            }
            
            val_3 = this.mLanguages.Item[0];
            val_3 = val_3 + 1;
            if((val_2.Flags & 4) == 0)
            {
                goto label_5;
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_2:
            val_4 = 0;
            return (bool)val_4;
        }
        public System.Collections.Generic.List<string> GetCategories(bool OnlyMainCategory = False, System.Collections.Generic.List<string> Categories)
        {
            System.Collections.Generic.List<System.String> val_7 = Categories;
            if(val_7 == null)
            {
                    System.Collections.Generic.List<System.String> val_1 = null;
                val_7 = val_1;
                val_1 = new System.Collections.Generic.List<System.String>();
            }
            
            List.Enumerator<T> val_2 = this.mTerms.GetEnumerator();
            label_10:
            if(((-932410104) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = 0.Id;
            string val_5 = I2.Loc.LanguageSourceData.GetCategoryFromFullTerm(FullTerm:  val_4.m_stringLength, OnlyMainCategory:  OnlyMainCategory);
            if((val_1.Contains(item:  val_5)) == true)
            {
                goto label_10;
            }
            
            val_1.Add(item:  val_5);
            goto label_10;
            label_3:
            UniRx.Unit..cctor();
            val_1.Sort();
            return (System.Collections.Generic.List<System.String>)val_7;
        }
        public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = False)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = null;
            if(OnlyMainCategory != false)
            {
                    val_4 = null;
                val_5 = FullTerm;
                int val_1 = val_5.IndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators);
            }
            else
            {
                    val_6 = null;
                val_5 = FullTerm;
                System.Char[] val_3 = I2.Loc.LanguageSourceData.CategorySeparators;
                int val_2 = val_5.LastIndexOfAny(anyOf:  val_3);
            }
            
            if((val_2 & 2147483648) != 0)
            {
                    return (string)FullTerm;
            }
            
            val_3 = val_2 + 1;
            return FullTerm.Substring(startIndex:  val_3);
        }
        public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = False)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = null;
            if(OnlyMainCategory != false)
            {
                    val_4 = null;
                val_5 = FullTerm;
                int val_1 = val_5.IndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators);
            }
            else
            {
                    val_6 = null;
                val_5 = FullTerm;
                int val_2 = val_5.LastIndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators);
            }
            
            if((val_2 & 2147483648) == 0)
            {
                    if(FullTerm != null)
            {
                    return FullTerm.Substring(startIndex:  0, length:  val_2);
            }
            
                return FullTerm.Substring(startIndex:  0, length:  val_2);
            }
            
            val_7 = null;
            val_7 = null;
            return (string)I2.Loc.LanguageSourceData.EmptyCategory;
        }
        public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = False)
        {
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_7 = FullTerm;
            val_8 = null;
            if(OnlyMainCategory != false)
            {
                    val_9 = null;
                val_10 = val_7;
                int val_1 = val_10.IndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators);
            }
            else
            {
                    val_11 = null;
                val_10 = val_7;
                int val_2 = val_10.LastIndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators);
            }
            
            if((val_2 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            if(val_7 == null)
            {
                goto label_10;
            }
            
            Category = val_7.Substring(startIndex:  0, length:  val_2);
            goto label_11;
            label_9:
            val_12 = null;
            val_12 = null;
            Category = I2.Loc.LanguageSourceData.EmptyCategory;
            goto label_14;
            label_10:
            Category = 0.Substring(startIndex:  0, length:  val_2);
            label_11:
            val_7 = val_7.Substring(startIndex:  val_2 + 1);
            label_14:
            Key = val_7;
        }
        public void UpdateDictionary(bool force = False)
        {
            System.Collections.Generic.List<I2.Loc.TermData> val_13;
            PersistentStorage.eFileType val_15;
            if((force != true) && (this.mDictionary != null))
            {
                    val_13 = this.mTerms;
                if(this.mDictionary.Count == val_13.Count)
            {
                    return;
            }
            
            }
            
            if(this.CaseInsensitiveTerms != false)
            {
                    System.StringComparer val_3 = System.StringComparer.OrdinalIgnoreCase;
            }
            else
            {
                    System.StringComparer val_4 = System.StringComparer.Ordinal;
            }
            
            val_13 = this.mDictionary;
            if(val_13.Comparer != val_4)
            {
                    System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData> val_6 = null;
                val_13 = val_6;
                val_15 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>::.ctor(System.Collections.Generic.IEqualityComparer<TKey> comparer);
                val_6 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>(comparer:  val_4);
                this.mDictionary = val_13;
            }
            else
            {
                    this.mDictionary.Clear();
            }
            
            int val_7 = this.mTerms.Count;
            if(val_7 >= 1)
            {
                    do
            {
                I2.Loc.TermData val_8 = this.mTerms.Item[0];
                I2.Loc.LanguageSourceData.ValidateFullTerm(Term: ref  val_8.Term);
                this.mDictionary.set_Item(key:  mem[val_8.Term], value:  this.mTerms.Item[0]);
                val_15 = public I2.Loc.TermData System.Collections.Generic.List<I2.Loc.TermData>::get_Item(int index);
                this.mTerms.Item[0].Validate();
                val_13 = 0 + 1;
            }
            while(val_7 != val_13);
            
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.SaveLanguages(unloadAll:  true, fileLocation:  val_15);
        }
        public string GetTranslation(string term, string overrideLanguage, string overrideSpecialization, bool skipDisabled = False, bool allowCategoryMistmatch = False)
        {
            if((this.TryGetTranslation(term:  term, Translation: out  0, overrideLanguage:  overrideLanguage, overrideSpecialization:  overrideSpecialization, skipDisabled:  skipDisabled, allowCategoryMistmatch:  allowCategoryMistmatch)) == true)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public bool TryGetTranslation(string term, out string Translation, string overrideLanguage, string overrideSpecialization, bool skipDisabled = False, bool allowCategoryMistmatch = False)
        {
            var val_11;
            if(overrideLanguage == null)
            {
                goto label_1;
            }
            
            label_15:
            int val_1 = this.GetLanguageIndex(language:  overrideLanguage, AllowDiscartingRegion:  true, SkipDisabled:  false);
            if((val_1 & 2147483648) != 0)
            {
                goto label_7;
            }
            
            if(skipDisabled == false)
            {
                goto label_4;
            }
            
            I2.Loc.LanguageData val_2 = this.mLanguages.Item[val_1];
            if((val_2.Flags & 1) != 0)
            {
                goto label_7;
            }
            
            label_4:
            I2.Loc.TermData val_4 = this.GetTermData(term:  term, allowCategoryMistmatch:  allowCategoryMistmatch);
            if(val_4 == null)
            {
                goto label_8;
            }
            
            string val_5 = val_4.GetTranslation(idx:  val_1, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_5;
            if((System.String.op_Equality(a:  val_5, b:  "---")) == false)
            {
                goto label_9;
            }
            
            label_22:
            Translation = System.String.alignConst;
            goto label_23;
            label_1:
            string val_7 = I2.Loc.LocalizationManager.CurrentLanguage;
            if(this != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_9:
            if((System.String.IsNullOrEmpty(value:  Translation)) == false)
            {
                goto label_23;
            }
            
            Translation = 0;
            label_8:
            if(this.OnMissingTranslation != 2)
            {
                goto label_17;
            }
            
            Translation = System.String.Format(format:  "<!-Missing Translation [{0}]-!>", arg0:  term);
            label_23:
            val_11 = 1;
            return (bool)val_11;
            label_17:
            if((this.OnMissingTranslation == 1) && (val_4 != null))
            {
                    skipDisabled = skipDisabled;
                return this.TryGetFallbackTranslation(termData:  val_4, Translation: out  string val_10 = Translation, langIndex:  val_1, overrideSpecialization:  overrideSpecialization, skipDisabled:  skipDisabled);
            }
            
            if(this.OnMissingTranslation == 3)
            {
                goto label_21;
            }
            
            if(this.OnMissingTranslation == 0)
            {
                goto label_22;
            }
            
            label_7:
            val_11 = 0;
            Translation = 0;
            return (bool)val_11;
            label_21:
            Translation = term;
            goto label_23;
        }
        private bool TryGetFallbackTranslation(I2.Loc.TermData termData, out string Translation, int langIndex, string overrideSpecialization, bool skipDisabled = False)
        {
            string val_19;
            int val_20;
            var val_21;
            var val_22;
            var val_23;
            I2.Loc.LanguageData val_1 = this.mLanguages.Item[langIndex];
            val_19 = val_1.Code;
            if((System.String.IsNullOrEmpty(value:  val_19)) == true)
            {
                goto label_3;
            }
            
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_19, value:  '-')) != false)
            {
                    if(val_19 != null)
            {
                    val_20 = val_19.IndexOf(value:  '-');
            }
            else
            {
                    val_20 = 0.IndexOf(value:  '-');
            }
            
                val_19 = val_19.Substring(startIndex:  0, length:  val_20);
            }
            
            val_21 = 0;
            goto label_7;
            label_20:
            if(langIndex == val_21)
            {
                goto label_16;
            }
            
            I2.Loc.LanguageData val_7 = this.mLanguages.Item[0];
            if((val_7.Code.StartsWith(value:  val_19)) == false)
            {
                goto label_16;
            }
            
            if(skipDisabled == false)
            {
                goto label_13;
            }
            
            I2.Loc.LanguageData val_9 = this.mLanguages.Item[0];
            if((val_9.Flags & 1) != 0)
            {
                goto label_16;
            }
            
            label_13:
            val_22 = 1;
            string val_10 = termData.GetTranslation(idx:  0, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_10;
            if((System.String.IsNullOrEmpty(value:  val_10)) == false)
            {
                    return (bool)val_22;
            }
            
            label_16:
            val_21 = 1;
            label_7:
            if(val_21 < this.mLanguages.Count)
            {
                goto label_20;
            }
            
            label_3:
            val_23 = 0;
            goto label_21;
            label_35:
            if(langIndex == val_23)
            {
                goto label_31;
            }
            
            if(skipDisabled == false)
            {
                goto label_23;
            }
            
            I2.Loc.LanguageData val_13 = this.mLanguages.Item[0];
            if((val_13.Flags & 1) != 0)
            {
                goto label_31;
            }
            
            label_23:
            if(val_19 == null)
            {
                goto label_27;
            }
            
            I2.Loc.LanguageData val_14 = this.mLanguages.Item[0];
            if((val_14.Code.StartsWith(value:  val_19)) == true)
            {
                goto label_31;
            }
            
            label_27:
            val_22 = 1;
            string val_16 = termData.GetTranslation(idx:  0, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_16;
            if((System.String.IsNullOrEmpty(value:  val_16)) == false)
            {
                    return (bool)val_22;
            }
            
            label_31:
            val_23 = 1;
            label_21:
            if(val_23 < this.mLanguages.Count)
            {
                goto label_35;
            }
            
            val_22 = 0;
            Translation = 0;
            return (bool)val_22;
        }
        public I2.Loc.TermData AddTerm(string term)
        {
            return this.AddTerm(NewTerm:  term, termType:  0, SaveSource:  false);
        }
        public I2.Loc.TermData GetTermData(string term, bool allowCategoryMistmatch = False)
        {
            string val_9;
            var val_10;
            val_9 = term;
            I2.Loc.TermData val_3 = 0;
            val_10 = 0;
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                    return (I2.Loc.TermData);
            }
            
            if(this.mDictionary.Count == 0)
            {
                    this.UpdateDictionary(force:  false);
            }
            
            if((this.mDictionary.TryGetValue(key:  val_9, value: out  val_3)) != false)
            {
                    val_10 = val_3;
                return (I2.Loc.TermData);
            }
            
            if(allowCategoryMistmatch == false)
            {
                goto label_7;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_6 = this.mDictionary.GetEnumerator();
            val_10 = 0;
            label_15:
            if(((-930858592) & 1) == 0)
            {
                goto label_11;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_7 = 0.Current;
            val_9 = ;
            if((val_7.Value.IsTerm(name:  I2.Loc.LanguageSourceData.GetKeyFromFullTerm(FullTerm:  val_9, OnlyMainCategory:  false), allowCategoryMistmatch:  true)) == false)
            {
                goto label_15;
            }
            
            if(val_10 != 0)
            {
                goto label_14;
            }
            
            goto label_15;
            label_7:
            val_10 = 0;
            return (I2.Loc.TermData);
            label_14:
            val_10 = 0;
            label_11:
            UniRx.Unit..cctor();
            return (I2.Loc.TermData);
        }
        public bool ContainsTerm(string term)
        {
            return (bool)((this.GetTermData(term:  term, allowCategoryMistmatch:  false)) != 0) ? 1 : 0;
        }
        public System.Collections.Generic.List<string> GetTermsList(string Category)
        {
            string val_11;
            var val_12;
            var val_13;
            val_11 = Category;
            if(this.mDictionary.Count != this.mTerms.Count)
            {
                    this.UpdateDictionary(force:  false);
            }
            
            if((System.String.IsNullOrEmpty(value:  val_11)) != false)
            {
                    val_11 = this.mDictionary.Keys;
                System.Collections.Generic.List<System.String> val_5 = null;
                val_12 = val_5;
                val_5 = new System.Collections.Generic.List<System.String>(collection:  val_11);
                return (System.Collections.Generic.List<System.String>)val_12;
            }
            
            System.Collections.Generic.List<System.String> val_6 = null;
            val_12 = val_6;
            val_6 = new System.Collections.Generic.List<System.String>();
            val_13 = 0;
            goto label_7;
            label_15:
            I2.Loc.TermData val_7 = this.mTerms.Item[0];
            if((System.String.op_Equality(a:  I2.Loc.LanguageSourceData.GetCategoryFromFullTerm(FullTerm:  val_7.Term, OnlyMainCategory:  false), b:  val_11)) != false)
            {
                    val_6.Add(item:  val_7.Term);
            }
            
            val_13 = 1;
            label_7:
            if(val_13 < this.mTerms.Count)
            {
                goto label_15;
            }
            
            return (System.Collections.Generic.List<System.String>)val_12;
        }
        public I2.Loc.TermData AddTerm(string NewTerm, I2.Loc.eTermType termType, bool SaveSource = True)
        {
            I2.Loc.eTermType val_10;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData> val_11;
            I2.Loc.TermData val_12;
            val_10 = termType;
            val_11 = this;
            string val_1 = NewTerm;
            I2.Loc.LanguageSourceData.ValidateFullTerm(Term: ref  val_1);
            string val_2 = val_1.Trim();
            if(this.mLanguages.Count == 0)
            {
                    this.AddLanguage(LanguageName:  "English", LanguageCode:  "en");
            }
            
            val_12 = this.GetTermData(term:  val_2, allowCategoryMistmatch:  false);
            if(val_12 != null)
            {
                    return val_12;
            }
            
            I2.Loc.TermData val_5 = null;
            val_12 = val_5;
            val_5 = new I2.Loc.TermData();
            if(val_12 != null)
            {
                    .Term = val_2;
            }
            else
            {
                    mem[16] = val_2;
            }
            
            .TermType = val_10;
            int val_6 = this.mLanguages.Count;
            .Languages = new string[0];
            int val_8 = this.mLanguages.Count;
            .Flags = new byte[0];
            val_10 = this.mTerms;
            val_10.Add(item:  val_5);
            val_11 = this.mDictionary;
            val_11.Add(key:  val_2, value:  val_5);
            return val_12;
        }
        public void RemoveTerm(string term)
        {
            System.Collections.Generic.List<I2.Loc.TermData> val_5 = this.mTerms;
            int val_1 = val_5.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            label_6:
            I2.Loc.TermData val_2 = this.mTerms.Item[0];
            if((System.String.op_Equality(a:  val_2.Term, b:  term)) == true)
            {
                goto label_5;
            }
            
            val_5 = 0 + 1;
            if(val_5 < val_1)
            {
                goto label_6;
            }
            
            return;
            label_5:
            this.mTerms.RemoveAt(index:  0);
            bool val_4 = this.mDictionary.Remove(key:  term);
        }
        public static void ValidateFullTerm(ref string Term)
        {
            var val_13;
            string val_14;
            var val_15;
            var val_16;
            var val_17;
            string val_1 = Term.Replace(oldChar:  '\', newChar:  '/');
            Term = val_1;
            string val_2 = val_1.Trim();
            Term = val_2;
            val_13 = null;
            val_13 = null;
            val_14 = I2.Loc.LanguageSourceData.EmptyCategory;
            if((val_2.StartsWith(value:  val_14, comparisonType:  4)) != false)
            {
                    val_15 = null;
                val_15 = null;
                val_14 = I2.Loc.LanguageSourceData.EmptyCategory;
                if(Term.Length > val_14.Length)
            {
                    val_16 = null;
                val_16 = null;
                val_14 = I2.Loc.LanguageSourceData.EmptyCategory.Length;
                if((Term.Chars[val_14] & 65535) == ('/'))
            {
                    val_17 = null;
                val_17 = null;
                val_14 = I2.Loc.LanguageSourceData.EmptyCategory.Length;
                Term = Term.Substring(startIndex:  val_14 + 1);
            }
            
            }
            
            }
            
            Term = I2.Loc.I2Utils.GetValidTermName(text:  Term, allowCategory:  true);
        }
        public LanguageSourceData()
        {
            this.GoogleLiveSyncIsUptoDate = true;
            this.mTerms = new System.Collections.Generic.List<I2.Loc.TermData>();
            this.mDictionary = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>(comparer:  System.StringComparer.Ordinal);
            this.OnMissingTranslation = true;
            this.mLanguages = new System.Collections.Generic.List<I2.Loc.LanguageData>();
            this.GoogleUpdateSynchronization = true;
            this.GoogleUpdateFrequency = 3;
            this.Assets = new System.Collections.Generic.List<UnityEngine.Object>();
            this.mAssetDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer.Ordinal);
        }
        private static LanguageSourceData()
        {
            I2.Loc.LanguageSourceData.EmptyCategory = "Default";
            I2.Loc.LanguageSourceData.CategorySeparators = ToCharArray();
        }
    
    }

}
