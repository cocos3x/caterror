using UnityEngine;

namespace I2.Loc
{
    public static class LocalizationManager
    {
        // Fields
        private static string mCurrentLanguage;
        private static string mLanguageCode;
        private static System.Globalization.CultureInfo mCurrentCulture;
        private static bool mChangeCultureInfo;
        public static bool IsRight2Left;
        public static bool HasJoinedWords;
        public static System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager> ParamManagers;
        private static string[] LanguagesRTL;
        public static System.Collections.Generic.List<I2.Loc.LanguageSourceData> Sources;
        public static string[] GlobalSources;
        private static string mCurrentDeviceLanguage;
        public static System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor> mLocalizeTargets;
        private static I2.Loc.LocalizationManager.OnLocalizeCallback OnLocalizeEvent;
        private static bool mLocalizeIsScheduled;
        private static bool mLocalizeIsScheduledWithForcedValue;
        public static bool HighlightLocalizedTargets;
        
        // Properties
        public static string CurrentLanguage { get; set; }
        public static string CurrentLanguageCode { get; set; }
        public static string CurrentRegion { get; set; }
        public static string CurrentRegionCode { get; set; }
        public static System.Globalization.CultureInfo CurrentCulture { get; }
        
        // Methods
        public static void InitializeIfNeeded()
        {
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_4;
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentLanguage)) != true)
            {
                    val_6 = null;
                val_6 = null;
                val_4 = I2.Loc.LocalizationManager.Sources;
                if(val_4.Count != 0)
            {
                    return;
            }
            
            }
            
            I2.Loc.LocalizationManager.AutoLoadGlobalParamManagers();
            bool val_3 = I2.Loc.LocalizationManager.UpdateSources();
            I2.Loc.LocalizationManager.SelectStartupLanguage();
        }
        public static string GetVersion()
        {
            return "2.8.12 f1";
        }
        public static int GetRequiredWebServiceVersion()
        {
            return 5;
        }
        public static string GetWebServiceURL(I2.Loc.LanguageSourceData source)
        {
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_7 = source;
            if(val_7 != null)
            {
                    if((System.String.IsNullOrEmpty(value:  source.Google_WebServiceURL)) == false)
            {
                    return (string)mem[val_6.Google_WebServiceURL];
            }
            
            }
            
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_8 = 0;
            goto label_5;
            label_18:
            val_9 = null;
            val_9 = null;
            if(I2.Loc.LocalizationManager.Sources.Item[0] == null)
            {
                goto label_9;
            }
            
            val_10 = null;
            val_10 = null;
            I2.Loc.LanguageSourceData val_3 = I2.Loc.LocalizationManager.Sources.Item[0];
            if((System.String.IsNullOrEmpty(value:  val_3.Google_WebServiceURL)) == false)
            {
                goto label_14;
            }
            
            label_9:
            val_8 = 1;
            label_5:
            val_11 = null;
            val_11 = null;
            if(val_8 < I2.Loc.LocalizationManager.Sources.Count)
            {
                goto label_18;
            }
            
            return (string)mem[val_6.Google_WebServiceURL];
            label_14:
            val_12 = null;
            val_12 = null;
            I2.Loc.LanguageSourceData val_6 = I2.Loc.LocalizationManager.Sources.Item[0];
            val_7 = val_6.Google_WebServiceURL;
            return (string)mem[val_6.Google_WebServiceURL];
        }
        public static string get_CurrentLanguage()
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            return (string)I2.Loc.LocalizationManager.mCurrentLanguage;
        }
        public static void set_CurrentLanguage(string value)
        {
            var val_5;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            string val_1 = I2.Loc.LocalizationManager.GetSupportedLanguage(Language:  value, ignoreDisabled:  false);
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if((System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mCurrentLanguage, b:  val_1)) == false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_1, LanguageCode:  I2.Loc.LocalizationManager.GetLanguageCode(Language:  val_1), RememberLanguage:  true, Force:  false);
        }
        public static string get_CurrentLanguageCode()
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            return (string)I2.Loc.LocalizationManager.mLanguageCode;
        }
        public static void set_CurrentLanguageCode(string value)
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            if((System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mLanguageCode, b:  value)) == false)
            {
                    return;
            }
            
            string val_2 = I2.Loc.LocalizationManager.GetLanguageFromCode(Code:  value, exactMatch:  true);
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_2, LanguageCode:  value, RememberLanguage:  true, Force:  false);
        }
        public static string get_CurrentRegion()
        {
            var val_10;
            var val_11;
            string val_1 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_10 = "/\\";
            if(("/\\") == null)
            {
                    val_10 = "/\\";
            }
            
            System.Char[] val_10 = ToCharArray();
            int val_3 = val_1.IndexOfAny(anyOf:  val_10);
            if(val_3 >= 1)
            {
                    val_10 = val_3 + 1;
                return val_1.Substring(startIndex:  val_10);
            }
            
            int val_5 = val_1.IndexOfAny(anyOf:  ToCharArray());
            val_11 = "])";
            if("])" == null)
            {
                    val_11 = "])";
            }
            
            int val_7 = val_1.LastIndexOfAny(anyOf:  ToCharArray());
            if(val_5 < 1)
            {
                    return (string)System.String.alignConst;
            }
            
            if(val_7 == val_5)
            {
                    return (string)System.String.alignConst;
            }
            
            return val_1.Substring(startIndex:  val_5 + 1, length:  val_7 + (~val_5));
        }
        public static void set_CurrentRegion(string value)
        {
            string val_12;
            var val_13;
            int val_14;
            var val_16;
            val_12 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_13 = "/\\";
            if(("/\\") == null)
            {
                    val_13 = "/\\";
            }
            
            System.Char[] val_12 = ToCharArray();
            val_14 = val_12.IndexOfAny(anyOf:  val_12);
            if(val_14 >= 1)
            {
                    val_12 = val_14 + 1;
                string val_5 = val_12.Substring(startIndex:  val_12)(val_12.Substring(startIndex:  val_12)) + value;
            }
            else
            {
                    val_14 = val_12.IndexOfAny(anyOf:  ToCharArray());
                val_16 = "])";
                if("])" == null)
            {
                    val_16 = "])";
            }
            
                if((val_14 >= 1) && (val_14 != (val_12.LastIndexOfAny(anyOf:  ToCharArray()))))
            {
                    val_12 = val_12.Substring(startIndex:  val_14);
            }
            
            }
            
            I2.Loc.LocalizationManager.CurrentLanguage = val_12 + "(" + value + ")";
        }
        public static string get_CurrentRegionCode()
        {
            var val_4;
            string val_1 = I2.Loc.LocalizationManager.CurrentLanguageCode;
            val_4 = " -_/\\";
            if((" -_/\\") == null)
            {
                    val_4 = " -_/\\";
            }
            
            System.Char[] val_4 = ToCharArray();
            int val_3 = val_1.IndexOfAny(anyOf:  val_4);
            if((val_3 & 2147483648) != 0)
            {
                    return (string)System.String.alignConst;
            }
            
            val_4 = val_3 + 1;
            return val_1.Substring(startIndex:  val_4);
        }
        public static void set_CurrentRegionCode(string value)
        {
            string val_6;
            var val_7;
            val_6 = I2.Loc.LocalizationManager.CurrentLanguageCode;
            val_7 = " -_/\\";
            if((" -_/\\") == null)
            {
                    val_7 = " -_/\\";
            }
            
            int val_3 = val_6.IndexOfAny(anyOf:  ToCharArray());
            if(val_3 >= 1)
            {
                    val_6 = val_6.Substring(startIndex:  0, length:  val_3);
            }
            
            I2.Loc.LocalizationManager.CurrentLanguageCode = val_6 + "-"("-") + value;
        }
        public static System.Globalization.CultureInfo get_CurrentCulture()
        {
            null = null;
            return (System.Globalization.CultureInfo)I2.Loc.LocalizationManager.mCurrentCulture;
        }
        public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = True, bool Force = False)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = null;
            val_11 = null;
            if((System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mCurrentLanguage, b:  LanguageName)) != false)
            {
                    val_12 = 1;
            }
            else
            {
                    val_13 = null;
                val_13 = null;
                val_12 = System.String.op_Inequality(a:  I2.Loc.LocalizationManager.mLanguageCode, b:  LanguageCode);
            }
            
            val_12 = val_12 | Force;
            if(val_12 == false)
            {
                    return;
            }
            
            if(RememberLanguage != false)
            {
                    I2.Loc.PersistentStorage.SetSetting_String(key:  "I2 Language", value:  LanguageName);
            }
            
            val_14 = null;
            val_14 = null;
            I2.Loc.LocalizationManager.mCurrentLanguage = LanguageName;
            I2.Loc.LocalizationManager.mLanguageCode = LanguageCode;
            val_15 = null;
            I2.Loc.LocalizationManager.mCurrentCulture = I2.Loc.LocalizationManager.CreateCultureForCode(code:  LanguageCode);
            if(I2.Loc.LocalizationManager.mChangeCultureInfo != false)
            {
                    I2.Loc.LocalizationManager.SetCurrentCultureInfo();
                val_15 = null;
            }
            
            val_15 = null;
            I2.Loc.LocalizationManager.IsRight2Left = I2.Loc.LocalizationManager.IsRTL(Code:  I2.Loc.LocalizationManager.mLanguageCode);
            I2.Loc.LocalizationManager.HasJoinedWords = I2.Loc.GoogleLanguages.LanguageCode_HasJoinedWord(languageCode:  I2.Loc.LocalizationManager.mLanguageCode);
            I2.Loc.LocalizationManager.LocalizeAll(Force:  Force);
        }
        private static System.Globalization.CultureInfo CreateCultureForCode(string code)
        {
            return (System.Globalization.CultureInfo)System.Globalization.CultureInfo.CreateSpecificCulture(name:  code);
        }
        public static void EnableChangingCultureInfo(bool bEnable)
        {
            var val_2 = null;
            if((I2.Loc.LocalizationManager.mChangeCultureInfo != true) && (bEnable != false))
            {
                    I2.Loc.LocalizationManager.SetCurrentCultureInfo();
                val_2 = null;
            }
            
            val_2 = null;
            I2.Loc.LocalizationManager.mChangeCultureInfo = bEnable;
        }
        private static void SetCurrentCultureInfo()
        {
            var val_2 = null;
            System.Threading.Thread.CurrentThread.CurrentCulture = I2.Loc.LocalizationManager.mCurrentCulture;
        }
        private static void SelectStartupLanguage()
        {
            var val_23;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_24;
            var val_25;
            string val_26;
            var val_27;
            string val_28;
            string val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            string val_38;
            val_23 = null;
            val_23 = null;
            val_24 = I2.Loc.LocalizationManager.Sources;
            val_25 = 1152921512237657712;
            if(val_24.Count == 0)
            {
                    return;
            }
            
            string val_2 = I2.Loc.PersistentStorage.GetSetting_String(key:  "I2 Language", defaultValue:  System.String.alignConst);
            val_26 = I2.Loc.LocalizationManager.GetCurrentDeviceLanguage(force:  false);
            if(((System.String.IsNullOrEmpty(value:  val_2)) == true) || ((I2.Loc.LocalizationManager.HasLanguage(Language:  val_2, AllowDiscartingRegion:  true, Initialize:  false, SkipDisabled:  true)) == false))
            {
                goto label_10;
            }
            
            val_27 = 1;
            val_28 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  val_2);
            val_29 = val_2;
            goto label_13;
            label_10:
            val_30 = null;
            val_30 = null;
            I2.Loc.LanguageSourceData val_7 = I2.Loc.LocalizationManager.Sources.Item[0];
            if(val_7.IgnoreDeviceLanguage == true)
            {
                goto label_18;
            }
            
            string val_8 = I2.Loc.LocalizationManager.GetSupportedLanguage(Language:  val_26, ignoreDisabled:  true);
            val_26 = val_8;
            if((System.String.IsNullOrEmpty(value:  val_8)) == false)
            {
                goto label_21;
            }
            
            label_18:
            val_31 = null;
            val_31 = null;
            val_24 = I2.Loc.LocalizationManager.Sources;
            val_32 = val_24.Count;
            if(val_32 < 1)
            {
                    return;
            }
            
            label_46:
            val_33 = null;
            val_33 = null;
            I2.Loc.LanguageSourceData val_11 = I2.Loc.LocalizationManager.Sources.Item[0];
            if(val_11.mLanguages.Count < 1)
            {
                goto label_31;
            }
            
            val_34 = 0;
            goto label_32;
            label_45:
            val_35 = null;
            val_35 = null;
            I2.Loc.LanguageSourceData val_13 = I2.Loc.LocalizationManager.Sources.Item[0];
            if(val_13.mLanguages.Item[0].IsEnabled() == true)
            {
                goto label_39;
            }
            
            val_34 = 1;
            label_32:
            val_36 = null;
            val_36 = null;
            I2.Loc.LanguageSourceData val_16 = I2.Loc.LocalizationManager.Sources.Item[0];
            if(val_34 < val_16.mLanguages.Count)
            {
                goto label_45;
            }
            
            label_31:
            val_24 = 0 + 1;
            if(val_24 < val_32)
            {
                goto label_46;
            }
            
            return;
            label_39:
            val_37 = null;
            val_37 = null;
            I2.Loc.LanguageSourceData val_18 = I2.Loc.LocalizationManager.Sources.Item[0];
            I2.Loc.LanguageData val_19 = val_18.mLanguages.Item[0];
            val_38 = val_19.Name;
            I2.Loc.LanguageSourceData val_20 = I2.Loc.LocalizationManager.Sources.Item[0];
            val_26 = val_20.mLanguages.Item[0];
            val_28 = val_21.Code;
            val_29 = val_38;
            goto label_57;
            label_21:
            val_28 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  val_26);
            val_29 = val_26;
            label_57:
            val_27 = 0;
            label_13:
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_29, LanguageCode:  val_28, RememberLanguage:  false, Force:  false);
        }
        public static bool HasLanguage(string Language, bool AllowDiscartingRegion = True, bool Initialize = True, bool SkipDisabled = True)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = AllowDiscartingRegion;
            if(Initialize != false)
            {
                    I2.Loc.LocalizationManager.InitializeIfNeeded();
            }
            
            val_9 = null;
            val_9 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 < 1)
            {
                goto label_7;
            }
            
            var val_8 = 0;
            label_13:
            val_10 = null;
            val_10 = null;
            SkipDisabled = SkipDisabled;
            if(((I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  SkipDisabled)) & 2147483648) == 0)
            {
                goto label_12;
            }
            
            val_8 = val_8 + 1;
            if(val_8 < val_1)
            {
                goto label_13;
            }
            
            label_7:
            if(val_8 != false)
            {
                    val_11 = null;
                val_11 = null;
                val_8 = I2.Loc.LocalizationManager.Sources.Count;
                if(val_8 >= 1)
            {
                    var val_9 = 0;
                do
            {
                val_12 = null;
                val_12 = null;
                val_13 = 1;
                if(((I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  Language, AllowDiscartingRegion:  true, SkipDisabled:  SkipDisabled)) & 2147483648) == 0)
            {
                    return (bool)val_13;
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 < val_8);
            
            }
            
            }
            
            val_13 = 0;
            return (bool)val_13;
            label_12:
            val_13 = 1;
            return (bool)val_13;
        }
        public static string GetSupportedLanguage(string Language, bool ignoreDisabled = False)
        {
            bool val_26;
            string val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_33;
            var val_34;
            int val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_41;
            var val_42;
            var val_43;
            string val_44;
            var val_45;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_46;
            var val_47;
            var val_48;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_49;
            var val_50;
            var val_51;
            var val_52;
            int val_53;
            var val_54;
            val_26 = ignoreDisabled;
            string val_1 = I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  Language, ShowWarnings:  false);
            val_27 = val_1;
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                goto label_17;
            }
            
            val_28 = 1152921504974790656;
            val_29 = null;
            val_29 = null;
            val_30 = I2.Loc.LocalizationManager.Sources.Count;
            val_31 = null;
            var val_4 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            if(val_30 < 1)
            {
                goto label_7;
            }
            
            val_33 = 0;
            label_13:
            val_34 = null;
            val_35 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndexFromCode(Code:  val_27, exactMatch:  true, ignoreDisabled:  val_26);
            if((val_35 & 2147483648) == 0)
            {
                goto label_12;
            }
            
            val_36 = null;
            val_33 = val_33 + 1;
            var val_8 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            if(val_33 < val_30)
            {
                goto label_13;
            }
            
            label_7:
            val_36 = null;
            val_30 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_30 < 1)
            {
                goto label_17;
            }
            
            val_33 = 0;
            label_23:
            val_37 = null;
            val_37 = null;
            val_35 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndexFromCode(Code:  val_27, exactMatch:  false, ignoreDisabled:  val_26);
            if((val_35 & 2147483648) == 0)
            {
                goto label_22;
            }
            
            val_33 = val_33 + 1;
            if(val_33 < val_30)
            {
                goto label_23;
            }
            
            label_17:
            val_38 = null;
            val_38 = null;
            val_28 = 1152921512237657712;
            int val_13 = I2.Loc.LocalizationManager.Sources.Count;
            val_39 = null;
            var val_14 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            if(val_13 < 1)
            {
                goto label_27;
            }
            
            val_27 = 0;
            label_33:
            val_41 = null;
            val_30 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  val_26);
            if((val_30 & 2147483648) == 0)
            {
                goto label_32;
            }
            
            val_42 = null;
            val_27 = val_27 + 1;
            var val_18 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            if(val_27 < val_13)
            {
                goto label_33;
            }
            
            label_27:
            val_42 = null;
            val_27 = I2.Loc.LocalizationManager.Sources;
            int val_19 = val_27.Count;
            if(val_19 < 1)
            {
                    return (string)mem[val_25.Name];
            }
            
            val_28 = 1152921512253062960;
            val_27 = 0;
            label_43:
            val_43 = null;
            val_43 = null;
            val_30 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  Language, AllowDiscartingRegion:  true, SkipDisabled:  val_26);
            if((val_30 & 2147483648) == 0)
            {
                goto label_42;
            }
            
            val_27 = val_27 + 1;
            if(val_27 < val_19)
            {
                goto label_43;
            }
            
            return (string)mem[val_25.Name];
            label_32:
            val_45 = null;
            val_45 = null;
            val_46 = I2.Loc.LocalizationManager.Sources;
            val_47 = public I2.Loc.LanguageSourceData System.Collections.Generic.List<I2.Loc.LanguageSourceData>::get_Item(int index);
            goto label_48;
            label_12:
            val_48 = null;
            val_48 = null;
            val_49 = I2.Loc.LocalizationManager.Sources;
            val_50 = public I2.Loc.LanguageSourceData System.Collections.Generic.List<I2.Loc.LanguageSourceData>::get_Item(int index);
            goto label_52;
            label_42:
            val_51 = null;
            val_51 = null;
            val_46 = I2.Loc.LocalizationManager.Sources;
            val_47 = public I2.Loc.LanguageSourceData System.Collections.Generic.List<I2.Loc.LanguageSourceData>::get_Item(int index);
            label_48:
            I2.Loc.LanguageSourceData val_23 = val_46.Item[0];
            val_52 = 1152921512252851632;
            val_53 = val_30;
            goto label_58;
            label_22:
            val_54 = null;
            val_54 = null;
            val_49 = I2.Loc.LocalizationManager.Sources;
            val_50 = public I2.Loc.LanguageSourceData System.Collections.Generic.List<I2.Loc.LanguageSourceData>::get_Item(int index);
            label_52:
            I2.Loc.LanguageSourceData val_24 = val_49.Item[0];
            val_52 = 1152921512252851632;
            val_53 = val_35;
            label_58:
            val_26 = val_24.mLanguages.Item[val_53];
            val_44 = val_25.Name;
            return (string)mem[val_25.Name];
        }
        public static string GetLanguageCode(string Language)
        {
            string val_8;
            var val_9;
            var val_10;
            var val_11;
            string val_12;
            var val_13;
            val_8 = Language;
            val_9 = null;
            val_9 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            val_10 = null;
            val_10 = null;
            int val_3 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_3 < 1)
            {
                    return (string)mem[val_7.Code];
            }
            
            var val_8 = 0;
            label_16:
            val_11 = null;
            val_11 = null;
            int val_5 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  val_8, AllowDiscartingRegion:  true, SkipDisabled:  true);
            if((val_5 & 2147483648) == 0)
            {
                goto label_15;
            }
            
            val_8 = val_8 + 1;
            if(val_8 < val_3)
            {
                goto label_16;
            }
            
            return (string)mem[val_7.Code];
            label_15:
            val_13 = null;
            val_13 = null;
            I2.Loc.LanguageSourceData val_6 = I2.Loc.LocalizationManager.Sources.Item[0];
            val_8 = val_6.mLanguages.Item[val_5];
            val_12 = val_7.Code;
            return (string)mem[val_7.Code];
        }
        public static string GetLanguageFromCode(string Code, bool exactMatch = True)
        {
            string val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_12;
            var val_13;
            string val_14;
            var val_15;
            val_9 = Code;
            val_10 = null;
            val_10 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = I2.Loc.LocalizationManager.Sources;
            int val_3 = val_12.Count;
            if(val_3 < 1)
            {
                    return (string)mem[val_8.Name];
            }
            
            val_12 = 0;
            label_16:
            val_13 = null;
            val_13 = null;
            int val_6 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndexFromCode(Code:  val_9, exactMatch:  exactMatch, ignoreDisabled:  false);
            if((val_6 & 2147483648) == 0)
            {
                goto label_15;
            }
            
            val_12 = val_12 + 1;
            if(val_12 < val_3)
            {
                goto label_16;
            }
            
            return (string)mem[val_8.Name];
            label_15:
            val_15 = null;
            val_15 = null;
            I2.Loc.LanguageSourceData val_7 = I2.Loc.LocalizationManager.Sources.Item[0];
            val_9 = val_7.mLanguages.Item[val_6];
            val_14 = val_8.Name;
            return (string)mem[val_8.Name];
        }
        public static System.Collections.Generic.List<string> GetAllLanguages(bool SkipDisabled = True)
        {
            var val_11;
            var val_12;
            System.Collections.Generic.List<System.String> val_13;
            var val_14;
            System.Func<System.String, System.Boolean> val_15;
            val_11 = null;
            val_11 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_3 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            .Languages = new System.Collections.Generic.List<System.String>();
            val_12 = null;
            val_12 = null;
            int val_5 = I2.Loc.LocalizationManager.Sources.Count;
            val_13 = (LocalizationManager.<>c__DisplayClass33_0)[1152921512280851184].Languages;
            if(val_5 < 1)
            {
                    return val_13;
            }
            
            var val_11 = 0;
            do
            {
                val_14 = null;
                val_14 = null;
                val_15 = (LocalizationManager.<>c__DisplayClass33_0)[1152921512280851184].<>9__0;
                if(val_15 == null)
            {
                    System.Func<System.String, System.Boolean> val_9 = null;
                val_15 = val_9;
                val_9 = new System.Func<System.String, System.Boolean>(object:  new LocalizationManager.<>c__DisplayClass33_0(), method:  System.Boolean LocalizationManager.<>c__DisplayClass33_0::<GetAllLanguages>b__0(string x));
                .<>9__0 = val_15;
            }
            
                val_13.AddRange(collection:  System.Linq.Enumerable.Where<System.String>(source:  I2.Loc.LocalizationManager.Sources.Item[0].GetLanguages(skipDisabled:  SkipDisabled), predicate:  val_9));
                val_13 = (LocalizationManager.<>c__DisplayClass33_0)[1152921512280851184].Languages;
                val_11 = val_11 + 1;
            }
            while(val_5 != val_11);
            
            return val_13;
        }
        public static System.Collections.Generic.List<string> GetAllLanguagesCode(bool allowRegions = True, bool SkipDisabled = True)
        {
            bool val_10;
            var val_11;
            System.Collections.Generic.List<System.String> val_12;
            var val_13;
            System.Func<System.String, System.Boolean> val_14;
            val_10 = allowRegions;
            .Languages = new System.Collections.Generic.List<System.String>();
            val_11 = null;
            val_11 = null;
            int val_3 = I2.Loc.LocalizationManager.Sources.Count;
            val_12 = (LocalizationManager.<>c__DisplayClass34_0)[1152921512281037936].Languages;
            if(val_3 < 1)
            {
                    return val_12;
            }
            
            var val_9 = 0;
            val_10 = val_10;
            do
            {
                val_13 = null;
                val_13 = null;
                val_14 = (LocalizationManager.<>c__DisplayClass34_0)[1152921512281037936].<>9__0;
                if(val_14 == null)
            {
                    System.Func<System.String, System.Boolean> val_7 = null;
                val_14 = val_7;
                val_7 = new System.Func<System.String, System.Boolean>(object:  new LocalizationManager.<>c__DisplayClass34_0(), method:  System.Boolean LocalizationManager.<>c__DisplayClass34_0::<GetAllLanguagesCode>b__0(string x));
                .<>9__0 = val_14;
            }
            
                val_12.AddRange(collection:  System.Linq.Enumerable.Where<System.String>(source:  I2.Loc.LocalizationManager.Sources.Item[0].GetLanguagesCode(allowRegions:  val_10, skipDisabled:  SkipDisabled), predicate:  val_7));
                val_12 = (LocalizationManager.<>c__DisplayClass34_0)[1152921512281037936].Languages;
                val_9 = val_9 + 1;
            }
            while(val_3 != val_9);
            
            return val_12;
        }
        public static bool IsLanguageEnabled(string Language)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 < 1)
            {
                goto label_4;
            }
            
            val_5 = 0;
            label_10:
            val_6 = null;
            val_6 = null;
            if((I2.Loc.LocalizationManager.Sources.Item[0].IsLanguageEnabled(Language:  Language)) == false)
            {
                goto label_9;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_10;
            }
            
            label_4:
            val_7 = 1;
            return (bool)val_7;
            label_9:
            val_7 = 0;
            return (bool)val_7;
        }
        private static void LoadCurrentLanguage()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = 0;
            goto label_1;
            label_11:
            val_6 = null;
            val_6 = null;
            I2.Loc.LocalizationManager.Sources.Item[0].LoadLanguage(languageIndex:  I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  I2.Loc.LocalizationManager.mCurrentLanguage, AllowDiscartingRegion:  true, SkipDisabled:  false), UnloadOtherLanguages:  true, useFallback:  true, onlyCurrentSpecialization:  true, forceLoad:  false);
            val_5 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            if(val_5 < I2.Loc.LocalizationManager.Sources.Count)
            {
                goto label_11;
            }
        
        }
        public static void PreviewLanguage(string NewLanguage)
        {
            null = null;
            I2.Loc.LocalizationManager.mCurrentLanguage = NewLanguage;
            I2.Loc.LocalizationManager.mLanguageCode = I2.Loc.LocalizationManager.GetLanguageCode(Language:  I2.Loc.LocalizationManager.mCurrentLanguage);
            I2.Loc.LocalizationManager.IsRight2Left = I2.Loc.LocalizationManager.IsRTL(Code:  I2.Loc.LocalizationManager.mLanguageCode);
            I2.Loc.LocalizationManager.HasJoinedWords = I2.Loc.GoogleLanguages.LanguageCode_HasJoinedWord(languageCode:  I2.Loc.LocalizationManager.mLanguageCode);
        }
        public static void AutoLoadGlobalParamManagers()
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager> val_5;
            var val_6;
            val_3 = 0;
            goto label_3;
            label_17:
            T val_3 = UnityEngine.Object.FindObjectsOfType<I2.Loc.LocalizationParamsManager>()[0];
            if((val_1[0x0][0] + 32) != 0)
            {
                    val_4 = null;
                val_4 = null;
                val_5 = I2.Loc.LocalizationManager.ParamManagers;
                if((val_5.Contains(item:  val_3)) != true)
            {
                    UnityEngine.Debug.Log(message:  val_3);
                val_6 = null;
                val_6 = null;
                val_5 = I2.Loc.LocalizationManager.ParamManagers;
                val_5.Add(item:  val_3);
            }
            
            }
            
            val_3 = 1;
            label_3:
            if(val_3 < val_1.Length)
            {
                goto label_17;
            }
        
        }
        public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = True)
        {
            var val_3;
            LocalizationManager._GetParam val_5;
            val_3 = null;
            val_3 = null;
            val_5 = LocalizationManager.<>c.<>9__41_0;
            if(val_5 == null)
            {
                    val_5 = new LocalizationManager._GetParam();
                mem[1152921512281773936] = LocalizationManager.<>c.__il2cppRuntimeField_static_fields;
                mem[1152921512281773944] = System.Object LocalizationManager.<>c::<ApplyLocalizationParams>b__41_0(string p);
                mem[1152921512281773920] = System.Object LocalizationManager.<>c::<ApplyLocalizationParams>b__41_0(string p);
                LocalizationManager.<>c.<>9__41_0 = val_5;
            }
            
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  string val_2 = translation, getParam:  new LocalizationManager._GetParam(), allowLocalizedParameters:  allowLocalizedParameters);
        }
        public static void ApplyLocalizationParams(ref string translation, UnityEngine.GameObject root, bool allowLocalizedParameters = True)
        {
            .root = root;
            mem[1152921512281919600] = new LocalizationManager.<>c__DisplayClass42_0();
            mem[1152921512281919608] = System.Object LocalizationManager.<>c__DisplayClass42_0::<ApplyLocalizationParams>b__0(string p);
            mem[1152921512281919584] = System.Object LocalizationManager.<>c__DisplayClass42_0::<ApplyLocalizationParams>b__0(string p);
            allowLocalizedParameters = allowLocalizedParameters;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  string val_2 = translation, getParam:  new LocalizationManager._GetParam(), allowLocalizedParameters:  allowLocalizedParameters);
        }
        public static void ApplyLocalizationParams(ref string translation, System.Collections.Generic.Dictionary<string, object> parameters, bool allowLocalizedParameters = True)
        {
            .parameters = parameters;
            mem[1152921512282065264] = new LocalizationManager.<>c__DisplayClass43_0();
            mem[1152921512282065272] = System.Object LocalizationManager.<>c__DisplayClass43_0::<ApplyLocalizationParams>b__0(string p);
            mem[1152921512282065248] = System.Object LocalizationManager.<>c__DisplayClass43_0::<ApplyLocalizationParams>b__0(string p);
            allowLocalizedParameters = allowLocalizedParameters;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  string val_2 = translation, getParam:  new LocalizationManager._GetParam(), allowLocalizedParameters:  allowLocalizedParameters);
        }
        public static void ApplyLocalizationParams(ref string translation, I2.Loc.LocalizationManager._GetParam getParam, bool allowLocalizedParameters = True)
        {
            var val_38;
            string val_39;
            int val_40;
            string val_41;
            string val_42;
            string val_43;
            var val_44;
            val_38 = getParam;
            I2.Loc.LanguageSourceData val_17 = 0;
            if(translation == null)
            {
                    return;
            }
            
            int val_1 = translation.Length;
            val_39 = 0;
            label_37:
            if(0 >= translation.Length)
            {
                goto label_19;
            }
            
            val_40 = translation.IndexOf(value:  "{[", startIndex:  0);
            if((val_40 & 2147483648) != 0)
            {
                goto label_19;
            }
            
            val_41 = translation.IndexOf(value:  "]}", startIndex:  val_40);
            if((val_41 & 2147483648) != 0)
            {
                goto label_19;
            }
            
            int val_6 = translation.IndexOf(value:  "{[", startIndex:  val_40 + 1);
            if(val_6 >= 1)
            {
                    if(val_6 < val_41)
            {
                goto label_37;
            }
            
            }
            
            int val_7 = val_40 + 2;
            var val_10 = ((translation.Chars[val_7] & 65535) == '#') ? (2 + 1) : 2;
            int val_11 = val_41 - val_40;
            val_7 = val_10 + val_40;
            val_42 = val_38.Invoke(param:  translation.Substring(startIndex:  val_7, length:  val_11 - val_10));
            if(val_42 == null)
            {
                goto label_16;
            }
            
            if(null == null)
            {
                goto label_15;
            }
            
            goto label_16;
            label_15:
            if(allowLocalizedParameters == true)
            {
                goto label_17;
            }
            
            label_16:
            if(((val_41 + 2) & 2147483648) == 0)
            {
                goto label_37;
            }
            
            goto label_19;
            label_17:
            I2.Loc.TermData val_18 = I2.Loc.LocalizationManager.GetTermData(term:  val_42, source: out  val_17);
            if(val_18 != null)
            {
                    val_43 = I2.Loc.LocalizationManager.CurrentLanguage;
                if(val_17 == 0)
            {
                    val_43 = val_43;
            }
            
                int val_20 = val_17.GetLanguageIndex(language:  val_43, AllowDiscartingRegion:  true, SkipDisabled:  true);
                if((val_20 & 2147483648) == 0)
            {
                    val_42 = val_18.GetTranslation(idx:  val_20, specialization:  0, editMode:  false);
            }
            
            }
            
            val_41 = translation;
            translation = val_41.Replace(oldValue:  translation.Substring(startIndex:  val_40, length:  val_11 + 2), newValue:  val_42);
            if((System.Int32.TryParse(s:  val_42, result: out  0)) != false)
            {
                    I2.Loc.ePluralType val_28 = I2.Loc.GoogleLanguages.GetPluralType(langCode:  I2.Loc.LocalizationManager.CurrentLanguageCode, n:  0);
                val_41 = val_28;
                val_39 = val_28.ToString();
                UniRx.Unit..cctor();
            }
            
            val_42 = val_42.Length + val_40;
            if((val_42 & 2147483648) == 0)
            {
                goto label_37;
            }
            
            label_19:
            if(val_39 == null)
            {
                    return;
            }
            
            val_40 = "[i2p_";
            string val_31 = "[i2p_" + val_39 + "]";
            int val_32 = translation.IndexOf(value:  val_31, comparisonType:  5);
            if((val_32 & 2147483648) == 0)
            {
                    val_44 = val_31.Length + val_32;
            }
            else
            {
                    val_44 = 0;
            }
            
            val_38 = translation.IndexOf(value:  "[i2p_", startIndex:  val_44 + 1, comparisonType:  5);
            if((val_38 & 2147483648) != 0)
            {
                    val_38 = translation.Length;
            }
            
            translation = translation.Substring(startIndex:  0, length:  val_38 - val_44);
        }
        internal static string GetLocalizationParam(string ParamName, UnityEngine.GameObject root)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            if(((UnityEngine.Object.op_Implicit(exists:  root)) == false) || (val_2.Length < 1))
            {
                goto label_6;
            }
            
            val_9 = 0;
            label_18:
            if(val_9 >= val_2.Length)
            {
                    val_10 = 0;
            }
            
            val_8 = root.GetComponents<UnityEngine.MonoBehaviour>()[val_9];
            if(val_8 == 0)
            {
                goto label_12;
            }
            
            if(val_9 >= val_2.Length)
            {
                    val_10 = 0;
            }
            
            if((val_2[0x0] + 32.enabled) == false)
            {
                goto label_12;
            }
            
            var val_12 = val_8;
            if((val_2[0x0][0] + 286) == 0)
            {
                goto label_13;
            }
            
            var val_10 = val_2[0x0][0] + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_15:
            if(((val_2[0x0][0] + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (val_2[0x0][0] + 286))
            {
                goto label_15;
            }
            
            label_13:
            val_10 = 0;
            goto label_16;
            label_14:
            val_12 = val_12 + (((val_2[0x0][0] + 176 + 8)) << 4);
            val_11 = val_12 + 296;
            label_16:
            val_12 = val_8;
            if((val_12.GetParameterValue(Param:  ParamName)) != null)
            {
                    return (string)val_12;
            }
            
            label_12:
            val_9 = val_9 + 1;
            if(val_9 < (long)val_2.Length)
            {
                goto label_18;
            }
            
            label_6:
            val_9 = 1152921504974790656;
            val_13 = null;
            val_13 = null;
            int val_5 = I2.Loc.LocalizationManager.ParamManagers.Count;
            if(val_5 >= 1)
            {
                    val_8 = 0;
                do
            {
                val_14 = null;
                val_14 = null;
                val_15 = public I2.Loc.ILocalizationParamsManager System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager>::get_Item(int index);
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_15 = 0;
                val_12 = I2.Loc.LocalizationManager.ParamManagers.Item[0];
                if((val_12.GetParameterValue(Param:  ParamName)) != null)
            {
                    return (string)val_12;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_5);
            
            }
            
            val_12 = 0;
            return (string)val_12;
        }
        private static string GetPluralType(System.Text.RegularExpressions.MatchCollection matches, string langCode, I2.Loc.LocalizationManager._GetParam getParam)
        {
            int val_1 = matches.Count;
            if(val_1 < 1)
            {
                    return 0;
            }
            
            var val_12 = 0;
            label_14:
            object val_6 = getParam.Invoke(param:  matches.Item[matches.Count - 1].Value);
            if(val_6 == null)
            {
                goto label_12;
            }
            
            if(null == null)
            {
                goto label_11;
            }
            
            goto label_12;
            label_11:
            if((System.Int32.TryParse(s:  val_6, result: out  0)) == true)
            {
                goto label_13;
            }
            
            label_12:
            val_12 = val_12 + 1;
            if(val_12 < val_1)
            {
                goto label_14;
            }
            
            return 0;
            label_13:
            string val_11 = I2.Loc.GoogleLanguages.GetPluralType(langCode:  langCode, n:  0).ToString();
            UniRx.Unit..cctor();
            return 0;
        }
        public static string ApplyRTLfix(string line)
        {
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  line, maxCharacters:  0, ignoreNumbers:  true);
        }
        public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
        {
            bool val_43;
            string val_44;
            string val_45;
            string val_46;
            var val_47;
            string val_48;
            var val_49;
            var val_50;
            int val_51;
            val_43 = ignoreNumbers;
            val_44 = line;
            if((System.String.IsNullOrEmpty(value:  val_44)) == true)
            {
                    return (string)val_49;
            }
            
            char val_2 = val_44.Chars[0];
            char val_3 = val_2 & 65535;
            if(val_3 <= ('?'))
            {
                    val_3 = 1 << val_3;
                val_3 = val_3 & (-9223301659520663552);
                if(val_3 != 0)
            {
                    val_45 = val_44.Substring(startIndex:  1)(val_44.Substring(startIndex:  1)) + val_2;
            }
            
            }
            
            int val_8 = 0;
            int val_7 = 0;
            System.Collections.Generic.List<System.String> val_6 = new System.Collections.Generic.List<System.String>();
            if((I2.Loc.I2Utils.FindNextTag(line:  val_45, iStart:  0, tagStart: out  val_7, tagEnd: out  val_8)) != false)
            {
                    val_43 = 1152921509333116704;
                do
            {
                val_46 = "@@" + val_6.Count + 40000(val_6.Count + 40000) + "@@";
                val_6.Add(item:  val_45.Substring(startIndex:  0, length:  (1 - val_7) + val_8));
                if(val_45 != null)
            {
                    val_47 = val_8;
                val_48 = val_45.Substring(startIndex:  0, length:  0);
            }
            else
            {
                    val_47 = val_8;
                val_48 = 0.Substring(startIndex:  0, length:  0);
            }
            
                string val_19 = val_48 + val_46 + val_45.Substring(startIndex:  1)(val_45.Substring(startIndex:  1));
                val_45 = val_19;
            }
            while((I2.Loc.I2Utils.FindNextTag(line:  val_19, iStart:  5, tagStart: out  val_7, tagEnd: out  5)) == true);
            
            }
            
            var val_47 = ~val_43;
            val_49 = I2.Loc.RTLFixer.Fix(str:  I2.Loc.I2Utils.SplitLine(line:  val_45.Replace(oldValue:  "\r\n", newValue:  "\n"), maxCharacters:  maxCharacters), showTashkeel:  true, useHinduNumbers:  val_47 & 1);
            val_50 = 0;
            goto label_29;
            label_39:
            int val_26 = val_49.Length;
            if(val_26 < 1)
            {
                goto label_37;
            }
            
            label_28:
            val_47 = val_49.Chars[0] & 65535;
            if(val_47 != '@')
            {
                goto label_18;
            }
            
            val_46 = 0 + 1;
            if((val_49.Chars[val_46] & 65535) != '@')
            {
                goto label_26;
            }
            
            int val_30 = 0 + 2;
            if(((((uint)(val_49.Chars[val_30] >> 6) & 1023) < 625) || (((val_49.Chars[0 + 3]) & 65535) != '@')) || (((val_49.Chars[0 + 4]) & 65535) != '@'))
            {
                goto label_26;
            }
            
            goto label_27;
            label_18:
            val_46 = 0 + 1;
            label_26:
            val_43 = val_46;
            if(val_46 < val_26)
            {
                goto label_28;
            }
            
            label_37:
            val_50 = 1;
            goto label_29;
            label_27:
            char val_38 = val_49.Chars[val_30];
            var val_48 = 2;
            val_48 = val_48 & (~(val_38 << 1));
            val_48 = val_48 + val_38;
            val_51 = val_48 + 40000;
            if(val_51 >= val_6.Count)
            {
                    val_51 = val_6.Count - 1;
            }
            
            string val_45 = val_49.Substring(startIndex:  0, length:  0)(val_49.Substring(startIndex:  0, length:  0)) + val_6.Item[val_51] + val_49.Substring(startIndex:  0 + 5)(val_49.Substring(startIndex:  0 + 5));
            goto label_37;
            label_29:
            if(val_50 < val_6.Count)
            {
                goto label_39;
            }
            
            return (string)val_49;
        }
        public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = False)
        {
            null = null;
            if(I2.Loc.LocalizationManager.IsRight2Left == false)
            {
                    return (string)text;
            }
            
            ignoreNumber = ignoreNumber;
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  text, maxCharacters:  maxCharacters, ignoreNumbers:  ignoreNumber);
        }
        public static bool IsRTL(string Code)
        {
            null = null;
            int val_1 = System.Array.IndexOf<System.String>(array:  I2.Loc.LocalizationManager.LanguagesRTL, value:  Code);
            val_1 = (val_1 >> 31) ^ 1;
            return (bool)val_1;
        }
        public static bool UpdateSources()
        {
            I2.Loc.LocalizationManager.UnregisterDeletededSources();
            I2.Loc.LocalizationManager.RegisterSourceInResources();
            I2.Loc.LocalizationManager.RegisterSceneSources();
            return (bool)(I2.Loc.LocalizationManager.Sources.Count > 0) ? 1 : 0;
        }
        private static void UnregisterDeletededSources()
        {
            var val_4;
            int val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = I2.Loc.LocalizationManager.Sources.Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_6 = null;
                val_6 = null;
                if(I2.Loc.LocalizationManager.Sources.Item[val_5] == null)
            {
                    val_7 = null;
                val_7 = null;
                I2.Loc.LocalizationManager.RemoveSource(Source:  I2.Loc.LocalizationManager.Sources.Item[val_5]);
            }
            
                val_5 = val_5 - 1;
            }
            while((val_5 & 2147483648) == 0);
        
        }
        private static void RegisterSceneSources()
        {
            I2.Loc.LanguageSourceData val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = UnityEngine.Resources.FindObjectsOfTypeAll(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_6 = val_5;
            if(val_6 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_6 = 0;
            label_4:
            val_7 = 0;
            goto label_5;
            label_18:
            val_8 = null;
            var val_4 = val_6 + 0;
            val_8 = null;
            val_5 = mem[(val_6 + 0) + 32 + 24];
            val_5 = (val_6 + 0) + 32 + 24;
            if((I2.Loc.LocalizationManager.Sources.Contains(item:  val_5)) != true)
            {
                    if(((val_6 + 0) + 32 + 24 + 16) == 0)
            {
                    mem2[0] = (val_6 + 0) + 32;
            }
            
                I2.Loc.LocalizationManager.AddSource(Source:  (val_6 + 0) + 32 + 24);
            }
            
            val_7 = 1;
            label_5:
            if(val_7 < 7783104)
            {
                goto label_18;
            }
        
        }
        private static void RegisterSourceInResources()
        {
            UnityEngine.Object val_5;
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            goto label_3;
            label_21:
            val_5 = I2.Loc.ResourceManager.pInstance.GetAsset<I2.Loc.LanguageSourceAsset>(Name:  I2.Loc.LocalizationManager.ParamManagers);
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) != false)
            {
                    val_8 = null;
                val_8 = null;
                if((I2.Loc.LocalizationManager.Sources.Contains(item:  val_2.mSource)) != true)
            {
                    if(val_2.mSource.mIsGlobalSource != true)
            {
                    val_2.mSource.mIsGlobalSource = true;
            }
            
                val_2.mSource.owner = val_5;
                val_5 = val_2.mSource;
                I2.Loc.LocalizationManager.AddSource(Source:  val_5);
            }
            
            }
            
            val_7 = 1;
            label_3:
            if(val_7 < I2.Loc.LocalizationManager.GlobalSources.Length)
            {
                goto label_21;
            }
        
        }
        internal static void AddSource(I2.Loc.LanguageSourceData Source)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = 1152921504974790656;
            val_9 = null;
            val_9 = null;
            if((I2.Loc.LocalizationManager.Sources.Contains(item:  Source)) == true)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            I2.Loc.LocalizationManager.Sources.Add(item:  Source);
            if((Source.HasGoogleSpreadsheet() != false) && (Source.GoogleUpdateFrequency != 1))
            {
                    Source.Import_Google_FromCache();
                if(Source.GoogleUpdateDelay > 0f)
            {
                    UnityEngine.Coroutine val_4 = I2.Loc.CoroutineManager.Start(coroutine:  I2.Loc.LocalizationManager.Delayed_Import_Google(source:  Source, delay:  Source.GoogleUpdateDelay, justCheck:  false));
            }
            else
            {
                    Source.Import_Google(ForceUpdate:  false, justCheck:  false);
            }
            
            }
            
            val_11 = 0;
            goto label_16;
            label_21:
            Source.mLanguages.Item[0].SetLoaded(loaded:  true);
            val_11 = 1;
            label_16:
            val_8 = System.Linq.Enumerable.Count<I2.Loc.LanguageData>(source:  Source.mLanguages);
            if(val_11 < val_8)
            {
                goto label_21;
            }
            
            if(Source.mDictionary.Count != 0)
            {
                    return;
            }
            
            Source.UpdateDictionary(force:  true);
        }
        private static System.Collections.IEnumerator Delayed_Import_Google(I2.Loc.LanguageSourceData source, float delay, bool justCheck)
        {
            LocalizationManager.<Delayed_Import_Google>d__59 val_1 = new LocalizationManager.<Delayed_Import_Google>d__59();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .source = source;
                .delay = delay;
            }
            else
            {
                    mem[40] = source;
                mem[32] = delay;
            }
            
            .justCheck = justCheck;
            return (System.Collections.IEnumerator)val_1;
        }
        internal static void RemoveSource(I2.Loc.LanguageSourceData Source)
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.Sources.Remove(item:  Source);
        }
        public static bool IsGlobalSource(string SourceName)
        {
            null = null;
            int val_1 = System.Array.IndexOf<System.String>(array:  I2.Loc.LocalizationManager.GlobalSources, value:  SourceName);
            val_1 = (val_1 >> 31) ^ 1;
            return (bool)val_1;
        }
        public static I2.Loc.LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = True)
        {
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_7;
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_8 = fallbackToFirst;
            if((System.String.IsNullOrEmpty(value:  term)) == true)
            {
                goto label_5;
            }
            
            val_9 = null;
            val_9 = null;
            val_7 = I2.Loc.LocalizationManager.Sources;
            int val_2 = val_7.Count;
            if(val_2 < 1)
            {
                goto label_5;
            }
            
            val_7 = 0;
            label_11:
            val_10 = null;
            val_10 = null;
            if((I2.Loc.LocalizationManager.Sources.Item[0].GetTermData(term:  term, allowCategoryMistmatch:  false)) != null)
            {
                goto label_10;
            }
            
            val_7 = val_7 + 1;
            if(val_7 < val_2)
            {
                goto label_11;
            }
            
            label_5:
            if(val_8 != false)
            {
                    val_11 = null;
                val_11 = null;
                val_8 = I2.Loc.LocalizationManager.Sources;
                if(val_8.Count >= 1)
            {
                    val_12 = null;
                val_12 = null;
                val_8 = I2.Loc.LocalizationManager.Sources;
                val_13 = 0;
                val_14 = public I2.Loc.LanguageSourceData System.Collections.Generic.List<I2.Loc.LanguageSourceData>::get_Item(int index);
                return (I2.Loc.LanguageSourceData)val_8.Item[0];
            }
            
            }
            
            val_15 = 0;
            return (I2.Loc.LanguageSourceData)val_8.Item[0];
            label_10:
            val_16 = null;
            val_16 = null;
            val_8 = I2.Loc.LocalizationManager.Sources;
            val_14 = public I2.Loc.LanguageSourceData System.Collections.Generic.List<I2.Loc.LanguageSourceData>::get_Item(int index);
            val_13 = val_7;
            return (I2.Loc.LanguageSourceData)val_8.Item[0];
        }
        public static UnityEngine.Object FindAsset(string value)
        {
            var val_5;
            var val_6;
            var val_7;
            UnityEngine.Object val_8;
            val_5 = null;
            val_5 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 >= 1)
            {
                    val_6 = 0;
                do
            {
                val_7 = null;
                val_7 = null;
                val_8 = I2.Loc.LocalizationManager.Sources.Item[0].FindAsset(Name:  value);
                if((UnityEngine.Object.op_Implicit(exists:  val_8)) == true)
            {
                    return (UnityEngine.Object)val_8;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_1);
            
            }
            
            val_8 = 0;
            return (UnityEngine.Object)val_8;
        }
        public static void ApplyDownloadedDataFromGoogle()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                val_4 = null;
                val_4 = null;
                I2.Loc.LocalizationManager.Sources.Item[0].ApplyDownloadedDataFromGoogle();
                val_3 = val_3 + 1;
            }
            while(val_1 != val_3);
        
        }
        public static string GetCurrentDeviceLanguage(bool force = False)
        {
            var val_2;
            var val_3;
            val_2 = 14649;
            if(force == true)
            {
                goto label_1;
            }
            
            if(((35 & 2) != 0) && (0 == 0))
            {
                    val_2 = null;
            }
            
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage)) == false)
            {
                goto label_4;
            }
            
            label_1:
            I2.Loc.LocalizationManager.DetectDeviceLanguage();
            label_4:
            val_3 = null;
            val_3 = null;
            return (string)I2.Loc.LocalizationManager.mCurrentDeviceLanguage;
        }
        private static void DetectDeviceLanguage()
        {
            var val_14;
            var val_15;
            string val_16;
            var val_17;
            var val_18;
            var val_19;
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "java/util/Locale");
            val_14 = null;
            val_14 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getDefault", args:  System.Array.Empty<System.Object>()).Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>());
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage)) != true)
            {
                    val_15 = null;
                val_15 = null;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = I2.Loc.LocalizationManager.mCurrentDeviceLanguage.Replace(oldChar:  '_', newChar:  '-');
                val_16 = I2.Loc.LocalizationManager.mCurrentDeviceLanguage;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = I2.Loc.GoogleLanguages.GetLanguageName(code:  val_16, useParenthesesForRegion:  true, allowDiscardRegion:  true);
                if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage)) == false)
            {
                    return;
            }
            
            }
            
            val_16 = UnityEngine.Application.systemLanguage.ToString();
            UniRx.Unit..cctor();
            val_17 = null;
            val_17 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = val_16;
            val_18 = null;
            if((System.String.op_Equality(a:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage, b:  "ChineseSimplified")) != false)
            {
                    val_18 = null;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = "Chinese (Simplified)";
            }
            
            val_18 = null;
            if((System.String.op_Equality(a:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage, b:  "ChineseTraditional")) == false)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = "Chinese (Traditional)";
        }
        public static void RegisterTarget(I2.Loc.ILocalizeTargetDescriptor desc)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            .desc = desc;
            val_6 = null;
            val_6 = null;
            if((I2.Loc.LocalizationManager.mLocalizeTargets.FindIndex(match:  new System.Predicate<I2.Loc.ILocalizeTargetDescriptor>(object:  new LocalizationManager.<>c__DisplayClass69_0(), method:  System.Boolean LocalizationManager.<>c__DisplayClass69_0::<RegisterTarget>b__0(I2.Loc.ILocalizeTargetDescriptor x)))) != 1)
            {
                    return;
            }
            
            val_7 = 0;
            goto label_6;
            label_16:
            I2.Loc.ILocalizeTargetDescriptor val_4 = I2.Loc.LocalizationManager.mLocalizeTargets.Item[0];
            if(val_4.Priority > ((LocalizationManager.<>c__DisplayClass69_0)[1152921512285473648].desc.Priority))
            {
                goto label_12;
            }
            
            val_7 = 1;
            label_6:
            val_8 = null;
            val_8 = null;
            val_9 = null;
            if(val_7 < I2.Loc.LocalizationManager.mLocalizeTargets.Count)
            {
                goto label_16;
            }
            
            val_9 = null;
            I2.Loc.LocalizationManager.mLocalizeTargets.Add(item:  (LocalizationManager.<>c__DisplayClass69_0)[1152921512285473648].desc);
            return;
            label_12:
            val_10 = null;
            val_10 = null;
            I2.Loc.LocalizationManager.mLocalizeTargets.Insert(index:  0, item:  (LocalizationManager.<>c__DisplayClass69_0)[1152921512285473648].desc);
        }
        public static void add_OnLocalizeEvent(I2.Loc.LocalizationManager.OnLocalizeCallback value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  I2.Loc.LocalizationManager.OnLocalizeEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(I2.Loc.LocalizationManager.OnLocalizeEvent != 1152921504974794832);
        
        }
        public static void remove_OnLocalizeEvent(I2.Loc.LocalizationManager.OnLocalizeCallback value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  I2.Loc.LocalizationManager.OnLocalizeEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(I2.Loc.LocalizationManager.OnLocalizeEvent != 1152921504974794832);
        
        }
        public static string GetTranslation(string Term, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            string val_4 = 0;
            bool val_5 = I2.Loc.LocalizationManager.TryGetTranslation(Term:  Term, Translation: out  val_4, FixForRTL:  FixForRTL, maxLineLengthForRTL:  maxLineLengthForRTL, ignoreRTLnumbers:  ignoreRTLnumbers, applyParameters:  applyParameters, localParametersRoot:  localParametersRoot, overrideLanguage:  overrideLanguage);
            return val_4;
        }
        public static string GetTermTranslation(string Term, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            FixForRTL = FixForRTL;
            ignoreRTLnumbers = ignoreRTLnumbers;
            applyParameters = applyParameters;
            return I2.Loc.LocalizationManager.GetTranslation(Term:  Term, FixForRTL:  FixForRTL, maxLineLengthForRTL:  maxLineLengthForRTL, ignoreRTLnumbers:  ignoreRTLnumbers, applyParameters:  applyParameters, localParametersRoot:  localParametersRoot, overrideLanguage:  overrideLanguage);
        }
        public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            bool val_8;
            var val_9;
            var val_10;
            val_8 = FixForRTL;
            Translation = 0;
            if((System.String.IsNullOrEmpty(value:  Term)) == true)
            {
                    return false;
            }
            
            val_8 = 1152921504974790656;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            int val_2 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_2 < 1)
            {
                    return false;
            }
            
            var val_8 = 0;
            label_11:
            val_9 = null;
            val_9 = null;
            if((I2.Loc.LocalizationManager.Sources.Item[0].TryGetTranslation(term:  Term, Translation: out  string val_4 = Translation, overrideLanguage:  overrideLanguage, overrideSpecialization:  0, skipDisabled:  false, allowCategoryMistmatch:  false)) == true)
            {
                goto label_10;
            }
            
            val_8 = val_8 + 1;
            if(val_8 < val_2)
            {
                goto label_11;
            }
            
            return false;
            label_10:
            if(applyParameters != false)
            {
                    I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  val_4, root:  localParametersRoot, allowLocalizedParameters:  true);
            }
            
            val_10 = null;
            val_10 = null;
            if(I2.Loc.LocalizationManager.IsRight2Left == false)
            {
                    return false;
            }
            
            if(val_8 == false)
            {
                    return false;
            }
            
            Translation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  Translation, maxCharacters:  maxLineLengthForRTL, ignoreNumbers:  ignoreRTLnumbers);
            return false;
        }
        public static T GetTranslatedObject<T>(string Term, I2.Loc.Localize optionalLocComp)
        {
            var val_15;
            string val_16;
            var val_17;
            UnityEngine.Object val_18;
            val_15 = __RuntimeMethodHiddenParam;
            val_16 = Term;
            val_17 = 1152921504793800704;
            if(optionalLocComp == 0)
            {
                goto label_3;
            }
            
            val_15 = ???;
            val_16 = ???;
            val_17 = ???;
            goto __RuntimeMethodHiddenParam + 48;
            label_3:
            UnityEngine.Object val_2 = I2.Loc.LocalizationManager.FindAsset(value:  val_16);
            if(val_2 == null)
            {
                goto label_9;
            }
            
            val_18 = val_2;
            if(val_18 != null)
            {
                goto label_10;
            }
            
            label_9:
            val_18 = 0;
            label_10:
            if((UnityEngine.Object.op_Implicit(exists:  val_18)) == true)
            {
                    return (object)val_18;
            }
            
            val_18 = I2.Loc.ResourceManager.pInstance;
            return (object)val_18;
        }
        public static string GetAppName(string languageCode)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if((System.String.IsNullOrEmpty(value:  languageCode)) == true)
            {
                    return UnityEngine.Application.productName;
            }
            
            val_12 = 0;
            goto label_2;
            label_24:
            val_13 = null;
            val_13 = null;
            I2.Loc.LanguageSourceData val_2 = I2.Loc.LocalizationManager.Sources.Item[0];
            if((System.String.IsNullOrEmpty(value:  val_2.mTerm_AppName)) != true)
            {
                    val_14 = null;
                val_14 = null;
                int val_5 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndexFromCode(Code:  languageCode, exactMatch:  false, ignoreDisabled:  false);
                if((val_5 & 2147483648) == 0)
            {
                    val_15 = null;
                val_15 = null;
                I2.Loc.LanguageSourceData val_7 = I2.Loc.LocalizationManager.Sources.Item[0];
                I2.Loc.TermData val_8 = I2.Loc.LocalizationManager.Sources.Item[0].GetTermData(term:  val_7.mTerm_AppName, allowCategoryMistmatch:  false);
                if(val_8 != null)
            {
                    string val_9 = val_8.GetTranslation(idx:  val_5, specialization:  0, editMode:  false);
                if((System.String.IsNullOrEmpty(value:  val_9)) == false)
            {
                    return val_9;
            }
            
            }
            
            }
            
            }
            
            val_12 = 1;
            label_2:
            val_16 = null;
            val_16 = null;
            if(val_12 < I2.Loc.LocalizationManager.Sources.Count)
            {
                goto label_24;
            }
            
            return UnityEngine.Application.productName;
        }
        public static void LocalizeAll(bool Force = False)
        {
            var val_7;
            I2.Loc.LocalizationManager.LoadCurrentLanguage();
            val_7 = null;
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_3;
            }
            
            val_7 = null;
            bool val_2 = (I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue == true) ? 1 : 0;
            val_2 = val_2 | Force;
            I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue = val_2;
            if(I2.Loc.LocalizationManager.mLocalizeIsScheduled == false)
            {
                goto label_6;
            }
            
            return;
            label_3:
            I2.Loc.LocalizationManager.DoLocalizeAll(Force:  Force);
            return;
            label_6:
            UnityEngine.Coroutine val_6 = I2.Loc.CoroutineManager.Start(coroutine:  I2.Loc.LocalizationManager.Coroutine_LocalizeAll());
        }
        private static System.Collections.IEnumerator Coroutine_LocalizeAll()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new LocalizationManager.<Coroutine_LocalizeAll>d__83();
        }
        private static void DoLocalizeAll(bool Force = False)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            OnLocalizeCallback val_10;
            UnityEngine.Object[] val_2 = UnityEngine.Resources.FindObjectsOfTypeAll(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_2 == null)
            {
                goto label_3;
            }
            
            val_5 = val_2;
            if(val_5 == null)
            {
                goto label_4;
            }
            
            val_6 = val_5;
            goto label_5;
            label_4:
            label_3:
            val_5 = 0;
            val_6 = 0;
            label_5:
            if(7783104 < 1)
            {
                goto label_6;
            }
            
            val_7 = 7783104 & 4294967295;
            val_8 = 0;
            var val_4 = val_5 + 32;
            goto label_7;
            label_10:
            val_7 = 7783104;
            val_8 = 1;
            label_7:
            (val_5 + 32) + 8.OnLocalize(Force:  Force);
            if((val_7 - 1) != val_8)
            {
                goto label_10;
            }
            
            label_6:
            val_9 = null;
            val_9 = null;
            val_10 = I2.Loc.LocalizationManager.OnLocalizeEvent;
            if(val_10 == null)
            {
                    return;
            }
            
            val_10 = I2.Loc.LocalizationManager.OnLocalizeEvent;
            if(val_10 == null)
            {
                    val_10 = 0;
            }
            
            val_10.Invoke();
        }
        public static System.Collections.Generic.List<string> GetCategories()
        {
            var val_5;
            var val_6;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_5 = null;
            val_5 = null;
            int val_2 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_5 = 0;
            do
            {
                val_6 = null;
                val_6 = null;
                System.Collections.Generic.List<System.String> val_4 = I2.Loc.LocalizationManager.Sources.Item[0].GetCategories(OnlyMainCategory:  false, Categories:  val_1);
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
            
            return val_1;
        }
        public static System.Collections.Generic.List<string> GetTermsList(string Category)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = null;
            val_10 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            val_11 = null;
            val_11 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 1)
            {
                    val_12 = null;
                val_12 = null;
                I2.Loc.LanguageSourceData val_4 = I2.Loc.LocalizationManager.Sources.Item[0];
                if(val_4 != null)
            {
                    return val_4.GetTermsList(Category:  Category);
            }
            
                return val_4.GetTermsList(Category:  Category);
            }
            
            System.Collections.Generic.HashSet<System.String> val_5 = new System.Collections.Generic.HashSet<System.String>();
            val_13 = null;
            val_13 = null;
            int val_6 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_6 < 1)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  val_5);
            }
            
            var val_10 = 0;
            do
            {
                val_14 = null;
                val_14 = null;
                val_5.UnionWith(other:  I2.Loc.LocalizationManager.Sources.Item[0].GetTermsList(Category:  Category));
                val_10 = val_10 + 1;
            }
            while(val_6 != val_10);
            
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  val_5);
        }
        public static I2.Loc.TermData GetTermData(string term)
        {
            var val_4;
            var val_5;
            var val_6;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 >= 1)
            {
                    val_4 = 0;
                do
            {
                val_5 = null;
                val_5 = null;
                if((I2.Loc.LocalizationManager.Sources.Item[0].GetTermData(term:  term, allowCategoryMistmatch:  false)) != null)
            {
                    return (I2.Loc.TermData)val_6;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1);
            
            }
            
            val_6 = 0;
            return (I2.Loc.TermData)val_6;
        }
        public static I2.Loc.TermData GetTermData(string term, out I2.Loc.LanguageSourceData source)
        {
            System.Collections.Generic.List<I2.Loc.LanguageSourceData> val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_5 = I2.Loc.LocalizationManager.Sources;
            int val_1 = val_5.Count;
            if(val_1 < 1)
            {
                goto label_4;
            }
            
            val_5 = 0;
            label_10:
            val_6 = null;
            val_6 = null;
            val_7 = I2.Loc.LocalizationManager.Sources.Item[0].GetTermData(term:  term, allowCategoryMistmatch:  false);
            if(val_7 != null)
            {
                goto label_9;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_10;
            }
            
            label_4:
            val_8 = 0;
            val_7 = 0;
            goto label_11;
            label_9:
            val_9 = null;
            val_9 = null;
            label_11:
            source = I2.Loc.LocalizationManager.Sources.Item[0];
            return (I2.Loc.TermData)val_7;
        }
        private static LocalizationManager()
        {
            I2.Loc.LocalizationManager.mChangeCultureInfo = false;
            I2.Loc.LocalizationManager.IsRight2Left = false;
            I2.Loc.LocalizationManager.HasJoinedWords = false;
            I2.Loc.LocalizationManager.ParamManagers = new System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager>();
            string[] val_2 = new string[20];
            val_2[0] = "ar-DZ";
            val_2[1] = "ar";
            val_2[2] = "ar-BH";
            val_2[3] = "ar-EG";
            val_2[4] = "ar-IQ";
            val_2[5] = "ar-JO";
            val_2[6] = "ar-KW";
            val_2[7] = "ar-LB";
            val_2[8] = "ar-LY";
            val_2[9] = "ar-MA";
            val_2[10] = "ar-OM";
            val_2[11] = "ar-QA";
            val_2[12] = "ar-SA";
            val_2[13] = "ar-SY";
            val_2[14] = "ar-TN";
            val_2[15] = "ar-AE";
            val_2[16] = "ar-YE";
            val_2[17] = "he";
            val_2[18] = "ur";
            val_2[19] = "ji";
            I2.Loc.LocalizationManager.LanguagesRTL = val_2;
            I2.Loc.LocalizationManager.Sources = new System.Collections.Generic.List<I2.Loc.LanguageSourceData>();
            string[] val_4 = new string[1];
            val_4[0] = "I2Languages";
            I2.Loc.LocalizationManager.GlobalSources = val_4;
            I2.Loc.LocalizationManager.mLocalizeTargets = new System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor>();
            I2.Loc.LocalizationManager.mLocalizeIsScheduled = false;
            I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue = false;
            I2.Loc.LocalizationManager.HighlightLocalizedTargets = false;
        }
    
    }

}
