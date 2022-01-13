using UnityEngine;

namespace I2.Loc
{
    public static class GoogleLanguages
    {
        // Fields
        public static System.Collections.Generic.Dictionary<string, I2.Loc.GoogleLanguages.LanguageCodeDef> mLanguageDef;
        
        // Methods
        public static string GetLanguageCode(string Filter, bool ShowWarnings = False)
        {
            var val_6;
            var val_10;
            System.String[] val_13;
            var val_14;
            var val_15;
            int val_16;
            if((System.String.IsNullOrEmpty(value:  Filter)) == true)
            {
                goto label_20;
            }
            
            val_14 = " /(),";
            if((" /(),") == null)
            {
                    val_14 = " /(),";
            }
            
            val_13 = Filter.ToLowerInvariant().Split(separator:  ToCharArray());
            val_15 = null;
            val_15 = null;
            Dictionary.Enumerator<TKey, TValue> val_5 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_11:
            if(((-961736120) & 1) == 0)
            {
                goto label_8;
            }
            
            if((I2.Loc.GoogleLanguages.LanguageMatchesFilter(Language:  val_6.Id, Filters:  val_13)) == false)
            {
                goto label_11;
            }
            
            val_16 = val_10;
            UniRx.Unit..cctor();
            return (string)val_16;
            label_8:
            UniRx.Unit..cctor();
            if(ShowWarnings != true)
            {
                
            }
            else
            {
                    UnityEngine.Debug.Log(message:  System.String.Format(format:  "Language \'{0}\' not recognized. Please, add the language code to GoogleTranslation.cs", arg0:  Filter));
            }
            
            label_20:
            val_16 = System.String.alignConst;
            return (string)val_16;
        }
        public static System.Collections.Generic.List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
        {
            var val_9;
            string val_14;
            string val_33;
            var val_34;
            var val_35;
            System.Collections.Generic.Dictionary<System.String, LanguageCodeDef> val_36;
            var val_37;
            var val_38;
            var val_39;
            val_33 = Filter;
            val_34 = " /(),";
            if((" /(),") == null)
            {
                    val_34 = " /(),";
            }
            
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            val_35 = null;
            val_35 = null;
            val_36 = I2.Loc.GoogleLanguages.mLanguageDef;
            Dictionary.Enumerator<TKey, TValue> val_5 = val_36.GetEnumerator();
            val_37 = 1152921512235021056;
            val_38 = 1152921512235022080;
            label_19:
            if(((-961384432) & 1) == 0)
            {
                goto label_7;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_33)) != true)
            {
                    if((I2.Loc.GoogleLanguages.LanguageMatchesFilter(Language:  val_9.Id, Filters:  val_33.ToLowerInvariant().Split(separator:  ToCharArray()))) == false)
            {
                goto label_19;
            }
            
            }
            
            string[] val_13 = new string[1];
            val_13[0] = "[" + val_14 + "]";
            string val_16 = +val_13;
            if((CodesToExclude.Contains(value:  val_16)) == true)
            {
                goto label_19;
            }
            
            val_4.Add(item:  val_9.Id + " " + val_16);
            goto label_19;
            label_7:
            UniRx.Unit..cctor();
            int val_21 = val_4.Count - 2;
            if((val_21 & 2147483648) != 0)
            {
                    return val_4;
            }
            
            val_38 = " [";
            val_37 = 1152921512235350480;
            do
            {
                if(val_4 != null)
            {
                    val_39 = val_4.Item[val_21];
            }
            else
            {
                    val_39 = val_4.Item[val_21];
            }
            
                string val_26 = val_39.Substring(startIndex:  0, length:  val_4.Item[val_21].IndexOf(value:  " ["));
                val_33 = val_21 + 1;
                val_36 = val_4.Item[val_33];
                if((val_36.StartsWith(value:  val_26)) != false)
            {
                    val_36 = val_26 + "/"("/") + val_4.Item[val_21];
                val_4.set_Item(index:  val_21, value:  val_36);
                val_4.Insert(index:  val_33, item:  val_26 + "/"("/"));
            }
            
                val_21 = val_21 - 1;
            }
            while((val_21 & 2147483648) == 0);
            
            return val_4;
        }
        private static bool LanguageMatchesFilter(string Language, string[] Filters)
        {
            string val_8;
            int val_9;
            var val_10;
            var val_11;
            string val_1 = Language.ToLowerInvariant();
            if(Filters.Length < 1)
            {
                goto label_3;
            }
            
            val_9 = Filters.Length & 4294967295;
            val_10 = 0;
            goto label_4;
            label_16:
            val_9 = Filters.Length;
            label_4:
            if((System.String.op_Inequality(a:  null, b:  "")) == false)
            {
                goto label_6;
            }
            
            val_8 = 1152921504989482960.ToLower();
            if((val_1.Contains(value:  val_8)) == false)
            {
                goto label_10;
            }
            
            val_8 = val_1.IndexOf(value:  1152921504989482960);
            string val_7 = val_1.Remove(startIndex:  val_8, count:  1152921504989482960.Length);
            label_6:
            val_10 = val_10 + 1;
            if(val_10 < (long)val_9)
            {
                goto label_16;
            }
            
            label_3:
            val_11 = 1;
            return (bool)val_11;
            label_10:
            val_11 = 0;
            return (bool)val_11;
        }
        public static string GetFormatedLanguageName(string Language)
        {
            string val_8;
            string val_9;
            val_8 = Language;
            int val_1 = val_8.IndexOf(value:  " [");
            if(val_1 >= 1)
            {
                    val_8 = val_8.Substring(startIndex:  0, length:  val_1);
            }
            
            int val_3 = val_8.IndexOf(value:  '/');
            if(val_3 >= 1)
            {
                    string val_4 = val_8.Substring(startIndex:  0, length:  val_3);
                val_9 = val_4;
                if((System.String.op_Equality(a:  val_8, b:  val_4 + "/"("/") + val_9)) == true)
            {
                    return (string)val_9;
            }
            
                return val_8.Replace(oldValue:  "/", newValue:  " (")(val_8.Replace(oldValue:  "/", newValue:  " (")) + ")";
            }
            
            val_9 = val_8;
            return (string)val_9;
        }
        public static string GetCodedLanguage(string Language, string code)
        {
            if((System.String.Compare(strA:  code, strB:  I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  Language, ShowWarnings:  false), comparisonType:  5)) == 0)
            {
                    return (string)Language;
            }
            
            return Language + " [" + code + "]";
        }
        public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
        {
            var val_10;
            int val_11;
            val_10 = 1152921512236241520;
            if((System.String.IsNullOrEmpty(value:  CodedLanguage)) == false)
            {
                goto label_1;
            }
            
            Language = System.String.alignConst;
            val_11 = System.String.alignConst;
            goto label_11;
            label_1:
            int val_2 = CodedLanguage.IndexOf(value:  "[");
            if((val_2 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            Language = CodedLanguage.Substring(startIndex:  0, length:  val_2).Trim();
            if(CodedLanguage == null)
            {
                goto label_7;
            }
            
            val_10 = CodedLanguage.IndexOf(value:  "]", startIndex:  val_2);
            goto label_8;
            label_4:
            Language = CodedLanguage;
            string val_6 = I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  CodedLanguage, ShowWarnings:  false);
            goto label_11;
            label_7:
            int val_10 = val_2;
            val_10 = 0.IndexOf(value:  "]", startIndex:  val_10);
            label_8:
            val_10 = val_10 + (~val_2);
            label_11:
            code = CodedLanguage.Substring(startIndex:  val_2 + 1, length:  val_10);
        }
        public static string GetGoogleLanguageCode(string InternationalCode)
        {
            string val_4;
            string val_6;
            string val_8;
            var val_10;
            string val_12;
            var val_13;
            val_12 = InternationalCode;
            val_13 = null;
            val_13 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_5:
            if(((-960443624) & 1) == 0)
            {
                goto label_8;
            }
            
            if((System.String.op_Equality(a:  val_12, b:  val_4)) == false)
            {
                goto label_5;
            }
            
            if((System.String.op_Equality(a:  val_6, b:  "-")) != false)
            {
                    val_12 = 0;
            }
            else
            {
                    if((System.String.IsNullOrEmpty(value:  val_8)) != true)
            {
                    val_12 = val_10;
            }
            
            }
            
            label_8:
            UniRx.Unit..cctor();
            return (string)val_12;
        }
        public static string GetLanguageName(string code, bool useParenthesesForRegion = False, bool allowDiscardRegion = True)
        {
            var val_5;
            string val_6;
            int val_18;
            var val_19;
            var val_21;
            var val_22;
            var val_23;
            val_18 = allowDiscardRegion;
            val_19 = null;
            val_19 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_5:
            if(((-960302976) & 1) == 0)
            {
                goto label_4;
            }
            
            if((System.String.op_Equality(a:  code, b:  val_6)) == false)
            {
                goto label_5;
            }
            
            val_21 = val_5.Id;
            if(useParenthesesForRegion != false)
            {
                    int val_9 = val_21.IndexOf(value:  '/');
                if(val_9 >= 1)
            {
                    val_21 = val_21.Substring(startIndex:  0, length:  val_9)(val_21.Substring(startIndex:  0, length:  val_9)) + " (" + val_21.Substring(startIndex:  val_9 + 1)(val_21.Substring(startIndex:  val_9 + 1)) + ")";
            }
            
            }
            
            val_22 = 1;
            goto label_11;
            label_4:
            val_22 = 0;
            val_21 = 0;
            label_11:
            UniRx.Unit..cctor();
            var val_14 = (val_22 != 0) ? (val_21) : 0;
            if((val_22 & 1) != 0)
            {
                    return (string)val_23;
            }
            
            if(val_18 != true)
            {
                    return (string)val_23;
            }
            
            val_18 = code.IndexOf(value:  "-");
            if(val_18 >= 1)
            {
                    bool val_17 = useParenthesesForRegion;
                val_23 = code.Substring(startIndex:  0, length:  val_18);
                return (string)val_23;
            }
            
            val_23 = 0;
            return (string)val_23;
        }
        public static System.Collections.Generic.List<string> GetAllInternationalCodes()
        {
            string val_5;
            var val_8;
            System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
            val_8 = null;
            val_8 = null;
            Dictionary.Enumerator<TKey, TValue> val_2 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_6:
            if(((-960155112) & 1) == 0)
            {
                goto label_4;
            }
            
            bool val_6 = val_1.Add(item:  val_5);
            goto label_6;
            label_4:
            UniRx.Unit..cctor();
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  val_1);
        }
        public static bool LanguageCode_HasJoinedWord(string languageCode)
        {
            string val_4;
            string val_6;
            var val_8;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_11 = null;
            val_11 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_6:
            if(((-960030824) & 1) != 0)
            {
                    if((System.String.op_Equality(a:  languageCode, b:  val_4)) != true)
            {
                    if((System.String.op_Equality(a:  languageCode, b:  val_6)) == false)
            {
                goto label_6;
            }
            
            }
            
                val_12 = 1;
                var val_9 = (val_8 == true) ? 1 : 0;
            }
            else
            {
                    val_12 = 0;
                val_13 = 0;
            }
            
            UniRx.Unit..cctor();
            val_14 = val_13 & val_12;
            return (bool)val_14;
        }
        private static int GetPluralRule(string langCode)
        {
            string val_7;
            var val_9;
            var val_11;
            var val_12;
            var val_13;
            val_11 = langCode;
            if(val_11.Length >= 3)
            {
                    val_11 = val_11.Substring(startIndex:  0, length:  2);
            }
            
            val_12 = null;
            val_12 = null;
            Dictionary.Enumerator<TKey, TValue> val_4 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_9:
            if(((-959902424) & 1) == 0)
            {
                goto label_8;
            }
            
            if((System.String.op_Equality(a:  val_7, b:  val_11.ToLower())) == false)
            {
                goto label_9;
            }
            
            val_13 = val_9;
            goto label_10;
            label_8:
            val_13 = 0;
            label_10:
            UniRx.Unit..cctor();
            return (int)val_13;
        }
        public static bool LanguageHasPluralType(string langCode, string pluralType)
        {
            if((System.String.op_Equality(a:  pluralType, b:  "Plural")) == true)
            {
                    return true;
            }
            
            if((System.String.op_Equality(a:  pluralType, b:  "Zero")) == true)
            {
                    return true;
            }
            
            if((System.String.op_Equality(a:  pluralType, b:  "One")) != false)
            {
                    return true;
            }
            
            if(((I2.Loc.GoogleLanguages.GetPluralRule(langCode:  langCode)) - 3) > 13)
            {
                    return true;
            }
            
            var val_6 = 28872452 + ((val_4 - 3)) << 2;
            val_6 = val_6 + 28872452;
            goto (28872452 + ((val_4 - 3)) << 2 + 28872452);
        }
        public static I2.Loc.ePluralType GetPluralType(string langCode, int n)
        {
            var val_17;
            if(n == 0)
            {
                goto label_1;
            }
            
            if(n != 1)
            {
                goto label_2;
            }
            
            val_17 = 1;
            return (I2.Loc.ePluralType)val_17;
            label_1:
            val_17 = 0;
            return (I2.Loc.ePluralType)val_17;
            label_2:
            if(((I2.Loc.GoogleLanguages.GetPluralRule(langCode:  langCode)) - 2) > 14)
            {
                    return (I2.Loc.ePluralType)val_17;
            }
            
            var val_19 = 28872508 + ((val_1 - 2)) << 2;
            val_19 = val_19 + 28872508;
            goto (28872508 + ((val_1 - 2)) << 2 + 28872508);
        }
        public static int GetPluralTestNumber(string langCode, I2.Loc.ePluralType pluralType)
        {
            var val_1;
            if(pluralType <= 4)
            {
                    var val_1 = 28872604 + (pluralType) << 2;
                val_1 = val_1 + 28872604;
            }
            else
            {
                    val_1 = 936;
                return 936;
            }
        
        }
        private static bool inRange(int amount, int min, int max)
        {
            amount = ((amount >= min) ? 1 : 0) & ((amount <= max) ? 1 : 0);
            return (bool)amount;
        }
        private static GoogleLanguages()
        {
            System.Collections.Generic.Dictionary<System.String, LanguageCodeDef> val_2 = new System.Collections.Generic.Dictionary<System.String, LanguageCodeDef>(comparer:  System.StringComparer.Ordinal);
            val_2.Add(key:  "Abkhazian", value:  new LanguageCodeDef() {Code = "ab", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Afar", value:  new LanguageCodeDef() {Code = "aa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Afrikaans", value:  new LanguageCodeDef() {Code = "af", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Akan", value:  new LanguageCodeDef() {Code = "ak", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Albanian", value:  new LanguageCodeDef() {Code = "sq", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Amharic", value:  new LanguageCodeDef() {Code = "am", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Arabic", value:  new LanguageCodeDef() {Code = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Algeria", value:  new LanguageCodeDef() {Code = "ar-DZ", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Bahrain", value:  new LanguageCodeDef() {Code = "ar-BH", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Egypt", value:  new LanguageCodeDef() {Code = "ar-EG", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Iraq", value:  new LanguageCodeDef() {Code = "ar-IQ", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Jordan", value:  new LanguageCodeDef() {Code = "ar-JO", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Kuwait", value:  new LanguageCodeDef() {Code = "ar-KW", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Lebanon", value:  new LanguageCodeDef() {Code = "ar-LB", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Libya", value:  new LanguageCodeDef() {Code = "ar-LY", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Morocco", value:  new LanguageCodeDef() {Code = "ar-MA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Oman", value:  new LanguageCodeDef() {Code = "ar-OM", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Qatar", value:  new LanguageCodeDef() {Code = "ar-QA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Saudi Arabia", value:  new LanguageCodeDef() {Code = "ar-SA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Syria", value:  new LanguageCodeDef() {Code = "ar-SY", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Tunisia", value:  new LanguageCodeDef() {Code = "ar-TN", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/U.A.E.", value:  new LanguageCodeDef() {Code = "ar-AE", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Arabic/Yemen", value:  new LanguageCodeDef() {Code = "ar-YE", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            val_2.Add(key:  "Aragonese", value:  new LanguageCodeDef() {Code = "an", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Armenian", value:  new LanguageCodeDef() {Code = "hy", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Assamese", value:  new LanguageCodeDef() {Code = "as", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Avaric", value:  new LanguageCodeDef() {Code = "av", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Avestan", value:  new LanguageCodeDef() {Code = "ae", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Aymara", value:  new LanguageCodeDef() {Code = "ay", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Azerbaijani", value:  new LanguageCodeDef() {Code = "az", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Bambara", value:  new LanguageCodeDef() {Code = "bm", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Bashkir", value:  new LanguageCodeDef() {Code = "ba", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Basque", value:  new LanguageCodeDef() {Code = "eu", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Basque/Spain", value:  new LanguageCodeDef() {Code = "eu-ES", GoogleCode = "eu", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Belarusian", value:  new LanguageCodeDef() {Code = "be", HasJoinedWords = false, PluralRule = 6});
            val_2.Add(key:  "Bengali", value:  new LanguageCodeDef() {Code = "bn", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Bihari", value:  new LanguageCodeDef() {Code = "bh", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Bislama", value:  new LanguageCodeDef() {Code = "bi", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Bosnian", value:  new LanguageCodeDef() {Code = "bs", HasJoinedWords = false, PluralRule = 6});
            val_2.Add(key:  "Breton", value:  new LanguageCodeDef() {Code = "br", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Bulgariaa", value:  new LanguageCodeDef() {Code = "bg", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Burmese", value:  new LanguageCodeDef() {Code = "my", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Catalan", value:  new LanguageCodeDef() {Code = "ca", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Chamorro", value:  new LanguageCodeDef() {Code = "ch", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Chechen", value:  new LanguageCodeDef() {Code = "ce", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Chichewa", value:  new LanguageCodeDef() {Code = "ny", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Chinese", value:  new LanguageCodeDef() {Code = "zh", GoogleCode = "zh-CN", HasJoinedWords = 1});
            val_2.Add(key:  "Chinese/Hong Kong", value:  new LanguageCodeDef() {Code = "zh-HK", GoogleCode = "zh-TW", HasJoinedWords = true});
            val_2.Add(key:  "Chinese/Macau", value:  new LanguageCodeDef() {Code = "zh-MO", GoogleCode = "zh-CN", HasJoinedWords = true});
            val_2.Add(key:  "Chinese/PRC", value:  new LanguageCodeDef() {Code = "zh-CN", GoogleCode = "zh-CN", HasJoinedWords = true});
            val_2.Add(key:  "Chinese/Simplified", value:  new LanguageCodeDef() {Code = "zh-CN", GoogleCode = "zh-CN", HasJoinedWords = true});
            val_2.Add(key:  "Chinese/Singapore", value:  new LanguageCodeDef() {Code = "zh-SG", GoogleCode = "zh-CN", HasJoinedWords = true});
            val_2.Add(key:  "Chinese/Taiwan", value:  new LanguageCodeDef() {Code = "zh-TW", GoogleCode = "zh-TW", HasJoinedWords = true});
            val_2.Add(key:  "Chinese/Traditional", value:  new LanguageCodeDef() {Code = "zh-TW", GoogleCode = "zh-TW", HasJoinedWords = true});
            val_2.Add(key:  "Chuvash", value:  new LanguageCodeDef() {Code = "cv", GoogleCode = "-", HasJoinedWords = false, PluralRule = true});
            val_2.Add(key:  "Cornish", value:  new LanguageCodeDef() {Code = "kw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Corsican", value:  new LanguageCodeDef() {Code = "co", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Cree", value:  new LanguageCodeDef() {Code = "cr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Croatian", value:  new LanguageCodeDef() {Code = "hr", HasJoinedWords = false, PluralRule = 6});
            val_2.Add(key:  "Croatian/Bosnia and Herzegovina", value:  new LanguageCodeDef() {Code = "hr-BA", GoogleCode = "hr", HasJoinedWords = false, PluralRule = 5});
            val_2.Add(key:  "Czech", value:  new LanguageCodeDef() {Code = "cs", HasJoinedWords = false, PluralRule = 7});
            val_2.Add(key:  "Danish", value:  new LanguageCodeDef() {Code = "da", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Divehi", value:  new LanguageCodeDef() {Code = "dv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Dutch", value:  new LanguageCodeDef() {Code = "nl", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Dutch/Belgium", value:  new LanguageCodeDef() {Code = "nl-BE", GoogleCode = "nl", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Dutch/Netherlands", value:  new LanguageCodeDef() {Code = "nl-NL", GoogleCode = "nl", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Dzongkha", value:  new LanguageCodeDef() {Code = "dz", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English", value:  new LanguageCodeDef() {Code = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Australia", value:  new LanguageCodeDef() {Code = "en-AU", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Belize", value:  new LanguageCodeDef() {Code = "en-BZ", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Canada", value:  new LanguageCodeDef() {Code = "en-CA", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Caribbean", value:  new LanguageCodeDef() {Code = "en-CB", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Ireland", value:  new LanguageCodeDef() {Code = "en-IE", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Jamaica", value:  new LanguageCodeDef() {Code = "en-JM", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/New Zealand", value:  new LanguageCodeDef() {Code = "en-NZ", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Republic of the Philippines", value:  new LanguageCodeDef() {Code = "en-PH", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/South Africa", value:  new LanguageCodeDef() {Code = "en-ZA", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Trinidad", value:  new LanguageCodeDef() {Code = "en-TT", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/United Kingdom", value:  new LanguageCodeDef() {Code = "en-GB", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/United States", value:  new LanguageCodeDef() {Code = "en-US", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "English/Zimbabwe", value:  new LanguageCodeDef() {Code = "en-ZW", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Esperanto", value:  new LanguageCodeDef() {Code = "eo", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Estonian", value:  new LanguageCodeDef() {Code = "et", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Ewe", value:  new LanguageCodeDef() {Code = "ee", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Faeroese", value:  new LanguageCodeDef() {Code = "fo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Fijian", value:  new LanguageCodeDef() {Code = "fj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Finnish", value:  new LanguageCodeDef() {Code = "fi", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "French", value:  new LanguageCodeDef() {Code = "fr", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "French/Belgium", value:  new LanguageCodeDef() {Code = "fr-BE", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "French/Canada", value:  new LanguageCodeDef() {Code = "fr-CA", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "French/France", value:  new LanguageCodeDef() {Code = "fr-FR", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "French/Luxembourg", value:  new LanguageCodeDef() {Code = "fr-LU", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "French/Principality of Monaco", value:  new LanguageCodeDef() {Code = "fr-MC", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "French/Switzerland", value:  new LanguageCodeDef() {Code = "fr-CH", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "Fulah", value:  new LanguageCodeDef() {Code = "ff", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Galician", value:  new LanguageCodeDef() {Code = "gl", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Galician/Spain", value:  new LanguageCodeDef() {Code = "gl-ES", GoogleCode = "gl", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Georgian", value:  new LanguageCodeDef() {Code = "ka", HasJoinedWords = false});
            val_2.Add(key:  "German", value:  new LanguageCodeDef() {Code = "de", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "German/Austria", value:  new LanguageCodeDef() {Code = "de-AT", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "German/Germany", value:  new LanguageCodeDef() {Code = "de-DE", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "German/Liechtenstein", value:  new LanguageCodeDef() {Code = "de-LI", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "German/Luxembourg", value:  new LanguageCodeDef() {Code = "de-LU", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "German/Switzerland", value:  new LanguageCodeDef() {Code = "de-CH", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Greek", value:  new LanguageCodeDef() {Code = "el", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Guaraní", value:  new LanguageCodeDef() {Code = "gn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Gujarati", value:  new LanguageCodeDef() {Code = "gu", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Haitian", value:  new LanguageCodeDef() {Code = "ht", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Hausa", value:  new LanguageCodeDef() {Code = "ha", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Hebrew", value:  new LanguageCodeDef() {Code = "he", GoogleCode = "iw", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Herero", value:  new LanguageCodeDef() {Code = "hz", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Hindi", value:  new LanguageCodeDef() {Code = "hi", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Hiri Motu", value:  new LanguageCodeDef() {Code = "ho", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Hungarian", value:  new LanguageCodeDef() {Code = "hu", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Interlingua", value:  new LanguageCodeDef() {Code = "ia", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Indonesian", value:  new LanguageCodeDef() {Code = "id", HasJoinedWords = false});
            val_2.Add(key:  "Interlingue", value:  new LanguageCodeDef() {Code = "ie", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Irish", value:  new LanguageCodeDef() {Code = "ga", HasJoinedWords = false, PluralRule = 10});
            val_2.Add(key:  "Igbo", value:  new LanguageCodeDef() {Code = "ig", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Inupiaq", value:  new LanguageCodeDef() {Code = "ik", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Ido", value:  new LanguageCodeDef() {Code = "io", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Icelandic", value:  new LanguageCodeDef() {Code = "is", HasJoinedWords = false, PluralRule = 14});
            val_2.Add(key:  "Italian", value:  new LanguageCodeDef() {Code = "it", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Italian/Italy", value:  new LanguageCodeDef() {Code = "it-IT", GoogleCode = "it", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Italian/Switzerland", value:  new LanguageCodeDef() {Code = "it-CH", GoogleCode = "it", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Inuktitut", value:  new LanguageCodeDef() {Code = "iu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Japanese", value:  new LanguageCodeDef() {Code = "ja", HasJoinedWords = true});
            val_2.Add(key:  "Javanese", value:  new LanguageCodeDef() {Code = "jv", HasJoinedWords = false, PluralRule = true});
            val_2.Add(key:  "Kalaallisut", value:  new LanguageCodeDef() {Code = "kl", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kannada", value:  new LanguageCodeDef() {Code = "kn", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kanuri", value:  new LanguageCodeDef() {Code = "kr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kashmiri", value:  new LanguageCodeDef() {Code = "ks", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kazakh", value:  new LanguageCodeDef() {Code = "kk", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Central Khmer", value:  new LanguageCodeDef() {Code = "km", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kikuyu", value:  new LanguageCodeDef() {Code = "ki", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kinyarwanda", value:  new LanguageCodeDef() {Code = "rw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kirghiz", value:  new LanguageCodeDef() {Code = "ky", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Komi", value:  new LanguageCodeDef() {Code = "kv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kongo", value:  new LanguageCodeDef() {Code = "kg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Korean", value:  new LanguageCodeDef() {Code = "ko", HasJoinedWords = false});
            val_2.Add(key:  "Kurdish", value:  new LanguageCodeDef() {Code = "ku", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Kuanyama", value:  new LanguageCodeDef() {Code = "kj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Latin", value:  new LanguageCodeDef() {Code = "la", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Luxembourgish", value:  new LanguageCodeDef() {Code = "lb", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Ganda", value:  new LanguageCodeDef() {Code = "lg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Limburgan", value:  new LanguageCodeDef() {Code = "li", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Lingala", value:  new LanguageCodeDef() {Code = "ln", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Lao", value:  new LanguageCodeDef() {Code = "lo", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Latvian", value:  new LanguageCodeDef() {Code = "lv", HasJoinedWords = false, PluralRule = 5});
            val_2.Add(key:  "Luba-Katanga", value:  new LanguageCodeDef() {Code = "lu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Lithuanian", value:  new LanguageCodeDef() {Code = "lt", HasJoinedWords = false, PluralRule = 5});
            val_2.Add(key:  "Manx", value:  new LanguageCodeDef() {Code = "gv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Macedonian", value:  new LanguageCodeDef() {Code = "mk", HasJoinedWords = false, PluralRule = 13});
            val_2.Add(key:  "Malagasy", value:  new LanguageCodeDef() {Code = "mg", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Malay", value:  new LanguageCodeDef() {Code = "ms", HasJoinedWords = false});
            val_2.Add(key:  "Malay/Brunei Darussalam", value:  new LanguageCodeDef() {Code = "ms-BN", GoogleCode = "ms", HasJoinedWords = false});
            val_2.Add(key:  "Malay/Malaysia", value:  new LanguageCodeDef() {Code = "ms-MY", GoogleCode = "ms", HasJoinedWords = false});
            val_2.Add(key:  "Malayalam", value:  new LanguageCodeDef() {Code = "ml", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Maltese", value:  new LanguageCodeDef() {Code = "mt", HasJoinedWords = false, PluralRule = 12});
            val_2.Add(key:  "Maori", value:  new LanguageCodeDef() {Code = "mi", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "Marathi", value:  new LanguageCodeDef() {Code = "mr", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Marshallese", value:  new LanguageCodeDef() {Code = "mh", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Mongolian", value:  new LanguageCodeDef() {Code = "mn", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Nauru", value:  new LanguageCodeDef() {Code = "na", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Navajo", value:  new LanguageCodeDef() {Code = "nv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "North Ndebele", value:  new LanguageCodeDef() {Code = "nd", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Nepali", value:  new LanguageCodeDef() {Code = "ne", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Ndonga", value:  new LanguageCodeDef() {Code = "ng", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Northern Sotho", value:  new LanguageCodeDef() {Code = "ns", GoogleCode = "st", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Norwegian", value:  new LanguageCodeDef() {Code = "nb", GoogleCode = "no", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Norwegian/Nynorsk", value:  new LanguageCodeDef() {Code = "nn", GoogleCode = "no", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Sichuan Yi", value:  new LanguageCodeDef() {Code = "ii", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "South Ndebele", value:  new LanguageCodeDef() {Code = "nr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Occitan", value:  new LanguageCodeDef() {Code = "oc", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Ojibwa", value:  new LanguageCodeDef() {Code = "oj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Church Slavic", value:  new LanguageCodeDef() {Code = "cu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Oromo", value:  new LanguageCodeDef() {Code = "om", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Oriya", value:  new LanguageCodeDef() {Code = "or", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Ossetian", value:  new LanguageCodeDef() {Code = "os", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Pali", value:  new LanguageCodeDef() {Code = "pi", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Pashto", value:  new LanguageCodeDef() {Code = "ps", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Persian", value:  new LanguageCodeDef() {Code = "fa", HasJoinedWords = false});
            val_2.Add(key:  "Polish", value:  new LanguageCodeDef() {Code = "pl", HasJoinedWords = false, PluralRule = 8});
            val_2.Add(key:  "Portuguese", value:  new LanguageCodeDef() {Code = "pt", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Portuguese/Brazil", value:  new LanguageCodeDef() {Code = "pt-BR", GoogleCode = "pt", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "Portuguese/Portugal", value:  new LanguageCodeDef() {Code = "pt-PT", GoogleCode = "pt", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Punjabi", value:  new LanguageCodeDef() {Code = "pa", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Quechua", value:  new LanguageCodeDef() {Code = "qu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Quechua/Bolivia", value:  new LanguageCodeDef() {Code = "qu-BO", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Quechua/Ecuador", value:  new LanguageCodeDef() {Code = "qu-EC", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Quechua/Peru", value:  new LanguageCodeDef() {Code = "qu-PE", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Rhaeto-Romanic", value:  new LanguageCodeDef() {Code = "rm", GoogleCode = "ro", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Romanian", value:  new LanguageCodeDef() {Code = "ro", HasJoinedWords = false, PluralRule = 4});
            val_2.Add(key:  "Rundi", value:  new LanguageCodeDef() {Code = "rn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Russian", value:  new LanguageCodeDef() {Code = "ru", HasJoinedWords = false, PluralRule = 6});
            val_2.Add(key:  "Russian/Republic of Moldova", value:  new LanguageCodeDef() {Code = "ru-MO", GoogleCode = "ru", HasJoinedWords = false, PluralRule = 6});
            val_2.Add(key:  "Sanskrit", value:  new LanguageCodeDef() {Code = "sa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Sardinian", value:  new LanguageCodeDef() {Code = "sc", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Sindhi", value:  new LanguageCodeDef() {Code = "sd", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Northern Sami", value:  new LanguageCodeDef() {Code = "se", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Samoan", value:  new LanguageCodeDef() {Code = "sm", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Sango", value:  new LanguageCodeDef() {Code = "sg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Serbian", value:  new LanguageCodeDef() {Code = "sr", HasJoinedWords = false, PluralRule = 6});
            val_2.Add(key:  "Serbian/Bosnia and Herzegovina", value:  new LanguageCodeDef() {Code = "sr-BA", GoogleCode = "sr", HasJoinedWords = false, PluralRule = 5});
            val_2.Add(key:  "Serbian/Serbia and Montenegro", value:  new LanguageCodeDef() {Code = "sr-SP", GoogleCode = "sr", HasJoinedWords = false, PluralRule = 5});
            val_2.Add(key:  "Scottish Gaelic", value:  new LanguageCodeDef() {Code = "gd", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Shona", value:  new LanguageCodeDef() {Code = "sn", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Sinhala", value:  new LanguageCodeDef() {Code = "si", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Slovak", value:  new LanguageCodeDef() {Code = "sk", HasJoinedWords = false, PluralRule = 7});
            val_2.Add(key:  "Slovenian", value:  new LanguageCodeDef() {Code = "sl", HasJoinedWords = false, PluralRule = 9});
            val_2.Add(key:  "Somali", value:  new LanguageCodeDef() {Code = "so", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Southern Sotho", value:  new LanguageCodeDef() {Code = "st", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish", value:  new LanguageCodeDef() {Code = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Argentina", value:  new LanguageCodeDef() {Code = "es-AR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Bolivia", value:  new LanguageCodeDef() {Code = "es-BO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Castilian", value:  new LanguageCodeDef() {Code = "es-ES", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Chile", value:  new LanguageCodeDef() {Code = "es-CL", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Colombia", value:  new LanguageCodeDef() {Code = "es-CO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Costa Rica", value:  new LanguageCodeDef() {Code = "es-CR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Dominican Republic", value:  new LanguageCodeDef() {Code = "es-DO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Ecuador", value:  new LanguageCodeDef() {Code = "es-EC", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/El Salvador", value:  new LanguageCodeDef() {Code = "es-SV", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Guatemala", value:  new LanguageCodeDef() {Code = "es-GT", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Honduras", value:  new LanguageCodeDef() {Code = "es-HN", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Mexico", value:  new LanguageCodeDef() {Code = "es-MX", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Nicaragua", value:  new LanguageCodeDef() {Code = "es-NI", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Panama", value:  new LanguageCodeDef() {Code = "es-PA", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Paraguay", value:  new LanguageCodeDef() {Code = "es-PY", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Peru", value:  new LanguageCodeDef() {Code = "es-PE", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Puerto Rico", value:  new LanguageCodeDef() {Code = "es-PR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Spain", value:  new LanguageCodeDef() {Code = "es-ES", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Uruguay", value:  new LanguageCodeDef() {Code = "es-UY", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Venezuela", value:  new LanguageCodeDef() {Code = "es-VE", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Spanish/Latin Americas", value:  new LanguageCodeDef() {Code = "es-US", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Sundanese", value:  new LanguageCodeDef() {Code = "su", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Swahili", value:  new LanguageCodeDef() {Code = "sw", HasJoinedWords = false});
            val_2.Add(key:  "Swati", value:  new LanguageCodeDef() {Code = "ss", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Swedish", value:  new LanguageCodeDef() {Code = "sv", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Swedish/Finland", value:  new LanguageCodeDef() {Code = "sv-FI", GoogleCode = "sv", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Swedish/Sweden", value:  new LanguageCodeDef() {Code = "sv-SE", GoogleCode = "sv", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Tamil", value:  new LanguageCodeDef() {Code = "ta", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Tatar", value:  new LanguageCodeDef() {Code = "tt", GoogleCode = "-", HasJoinedWords = false});
            val_2.Add(key:  "Telugu", value:  new LanguageCodeDef() {Code = "te", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Tajik", value:  new LanguageCodeDef() {Code = "tg", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Thai", value:  new LanguageCodeDef() {Code = "th", HasJoinedWords = true});
            val_2.Add(key:  "Tigrinya", value:  new LanguageCodeDef() {Code = "ti", GoogleCode = "-", HasJoinedWords = false, PluralRule = true});
            val_2.Add(key:  "Tibetan", value:  new LanguageCodeDef() {Code = "bo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Turkmen", value:  new LanguageCodeDef() {Code = "tk", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Tagalog", value:  new LanguageCodeDef() {Code = "tl", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Tswana", value:  new LanguageCodeDef() {Code = "tn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Tonga", value:  new LanguageCodeDef() {Code = "to", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Turkish", value:  new LanguageCodeDef() {Code = "tr", HasJoinedWords = false});
            val_2.Add(key:  "Tsonga", value:  new LanguageCodeDef() {Code = "ts", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Twi", value:  new LanguageCodeDef() {Code = "tw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Tahitian", value:  new LanguageCodeDef() {Code = "ty", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Uighur", value:  new LanguageCodeDef() {Code = "ug", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Ukrainian", value:  new LanguageCodeDef() {Code = "uk", HasJoinedWords = false, PluralRule = 6});
            val_2.Add(key:  "Urdu", value:  new LanguageCodeDef() {Code = "ur", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Uzbek", value:  new LanguageCodeDef() {Code = "uz", HasJoinedWords = false, PluralRule = 2});
            val_2.Add(key:  "Venda", value:  new LanguageCodeDef() {Code = "ve", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Vietnamese", value:  new LanguageCodeDef() {Code = "vi", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Volapük", value:  new LanguageCodeDef() {Code = "vo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Walloon", value:  new LanguageCodeDef() {Code = "wa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Welsh", value:  new LanguageCodeDef() {Code = "cy", HasJoinedWords = false, PluralRule = 16});
            val_2.Add(key:  "Wolof", value:  new LanguageCodeDef() {Code = "wo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Frisian", value:  new LanguageCodeDef() {Code = "fy", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Xhosa", value:  new LanguageCodeDef() {Code = "xh", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Yiddish", value:  new LanguageCodeDef() {Code = "yi", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Yoruba", value:  new LanguageCodeDef() {Code = "yo", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Zhuang", value:  new LanguageCodeDef() {Code = "za", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            val_2.Add(key:  "Zulu", value:  new LanguageCodeDef() {Code = "zu", HasJoinedWords = false, PluralRule = 1});
            I2.Loc.GoogleLanguages.mLanguageDef = val_2;
        }
    
    }

}
