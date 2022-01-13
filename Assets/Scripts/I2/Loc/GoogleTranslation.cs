using UnityEngine;

namespace I2.Loc
{
    public static class GoogleTranslation
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequest> mCurrentTranslations;
        private static System.Collections.Generic.List<I2.Loc.TranslationJob> mTranslationJobs;
        
        // Methods
        public static bool CanTranslate()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if(I2.Loc.LocalizationManager.Sources.Count >= 1)
            {
                    val_6 = (System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0))) ^ 1;
                return (bool)val_6 & 1;
            }
            
            val_6 = 0;
            return (bool)val_6 & 1;
        }
        public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Action<string, string> OnTranslationReady)
        {
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            System.Action<System.String, System.String> val_11;
            var val_12;
            string val_13;
            string val_14;
            var val_15;
            val_7 = LanguageCodeTo;
            GoogleTranslation.<>c__DisplayClass1_0 val_1 = new GoogleTranslation.<>c__DisplayClass1_0();
            if(val_1 != null)
            {
                    val_8 = val_1;
                .OnTranslationReady = OnTranslationReady;
                val_9 = 1152921512237901696;
                mem[1152921512237901704] = text;
            }
            else
            {
                    val_8 = 16;
                mem[16] = OnTranslationReady;
                val_9 = 24;
                mem[24] = text;
            }
            
            .LanguageCodeTo = val_7;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_10 = null;
            if(I2.Loc.GoogleTranslation.CanTranslate() == false)
            {
                goto label_7;
            }
            
            if((System.String.op_Equality(a:  (GoogleTranslation.<>c__DisplayClass1_0)[1152921512237901680].LanguageCodeTo, b:  LanguageCodeFrom)) == false)
            {
                goto label_8;
            }
            
            val_12 = 1152921509462714160;
            val_13 = val_9;
            goto label_10;
            label_7:
            val_11 = mem[16];
            val_13 = 0;
            val_14 = "WebService is not set correctly or needs to be reinstalled";
            val_15 = public System.Void System.Action<System.String, System.String>::Invoke(System.String arg1, System.String arg2);
            goto label_12;
            label_8:
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_4 = null;
            val_7 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>();
            .queries = val_7;
            if((System.String.IsNullOrEmpty(value:  (GoogleTranslation.<>c__DisplayClass1_0)[1152921512237901680].LanguageCodeTo)) == false)
            {
                goto label_13;
            }
            
            val_11 = System.String.alignConst;
            val_12 = 1152921509462714160;
            val_13 = val_11;
            label_10:
            val_14 = 0;
            label_12:
            mem[16].Invoke(arg1:  val_13, arg2:  val_14);
            return;
            label_13:
            I2.Loc.GoogleTranslation.CreateQueries(text:  mem[24], LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  (GoogleTranslation.<>c__DisplayClass1_0)[1152921512237901680].LanguageCodeTo, dict:  (GoogleTranslation.<>c__DisplayClass1_0)[1152921512237901680].queries);
            I2.Loc.GoogleTranslation.Translate(requests:  (GoogleTranslation.<>c__DisplayClass1_0)[1152921512237901680].queries, OnTranslationReady:  new System.Action<System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>, System.String>(object:  val_1, method:  System.Void GoogleTranslation.<>c__DisplayClass1_0::<Translate>b__0(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> results, string error)), usePOST:  false);
        }
        public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
        {
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_1 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>();
            I2.Loc.GoogleTranslation.AddQuery(text:  text, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  val_1);
            I2.Loc.TranslationJob_Main val_2 = new I2.Loc.TranslationJob_Main(requests:  val_1, OnTranslationReady:  0);
            do
            {
            
            }
            while(val_2 == null);
            
            if(val_2 != 2)
            {
                    return I2.Loc.GoogleTranslation.GetQueryResult(text:  text, LanguageCodeTo:  "", dict:  val_1);
            }
            
            return 0;
        }
        public static void Translate(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady, bool usePOST = True)
        {
            I2.Loc.GoogleTranslation.AddTranslationJob(job:  new I2.Loc.TranslationJob_Main(requests:  requests, OnTranslationReady:  OnTranslationReady));
        }
        public static bool ForceTranslate(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, bool usePOST = True)
        {
            I2.Loc.TranslationJob_Main val_1 = new I2.Loc.TranslationJob_Main(requests:  requests, OnTranslationReady:  0);
            do
            {
            
            }
            while(val_1 == null);
            
            return (bool)(val_1 != 2) ? 1 : 0;
        }
        public static System.Collections.Generic.List<string> ConvertTranslationRequest(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, bool encodeGET)
        {
            string val_8;
            string val_9;
            var val_10;
            var val_29;
            var val_30;
            string val_31;
            var val_32;
            var val_33;
            var val_34;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            Dictionary.Enumerator<TKey, TValue> val_3 = requests.GetEnumerator();
            val_29 = 1152921512238422704;
            val_30 = 1152921509333116704;
            label_35:
            if(((-958290464) & 1) == 0)
            {
                goto label_2;
            }
            
            val_31 = val_8;
            if(val_2.Length >= 1)
            {
                    System.Text.StringBuilder val_12 = val_2.Append(value:  "<I2Loc>");
            }
            
            System.Text.StringBuilder val_14 = val_2.Append(value:  I2.Loc.GoogleLanguages.GetGoogleLanguageCode(InternationalCode:  val_9));
            System.Text.StringBuilder val_15 = val_2.Append(value:  ":");
            val_32 = 0;
            goto label_10;
            label_18:
            if(val_32 != 0)
            {
                    System.Text.StringBuilder val_16 = val_2.Append(value:  ",");
            }
            
            var val_17 = val_10 + 0;
            System.Text.StringBuilder val_19 = val_2.Append(value:  I2.Loc.GoogleLanguages.GetGoogleLanguageCode(InternationalCode:  (val_10 + 0) + 32));
            val_32 = 1;
            label_10:
            if(val_32 < (val_10 + 24))
            {
                goto label_18;
            }
            
            System.Text.StringBuilder val_20 = val_2.Append(value:  "=");
            if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.TitleCase(s:  val_31), b:  val_31)) != false)
            {
                    val_33 = encodeGET;
                val_31 = val_31.ToLowerInvariant();
            }
            else
            {
                    val_33 = encodeGET;
            }
            
            if(val_33 == false)
            {
                goto label_25;
            }
            
            System.Text.StringBuilder val_25 = val_2.Append(value:  System.Uri.EscapeDataString(stringToEscape:  val_31));
            if(val_2.Length < 4001)
            {
                goto label_35;
            }
            
            val_1.Add(item:  val_2);
            val_2.Length = 0;
            goto label_35;
            label_25:
            System.Text.StringBuilder val_27 = val_2.Append(value:  val_31);
            goto label_35;
            label_2:
            val_34 = public System.Void Dictionary.Enumerator<System.String, I2.Loc.TranslationQuery>::Dispose();
            UniRx.Unit..cctor();
            val_1.Add(item:  val_2);
            return val_1;
        }
        private static void AddTranslationJob(I2.Loc.TranslationJob job)
        {
            null = null;
            I2.Loc.GoogleTranslation.mTranslationJobs.Add(item:  job);
            if(I2.Loc.GoogleTranslation.mTranslationJobs.Count != 1)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_3 = I2.Loc.CoroutineManager.Start(coroutine:  I2.Loc.GoogleTranslation.WaitForTranslations());
        }
        private static System.Collections.IEnumerator WaitForTranslations()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new GoogleTranslation.<WaitForTranslations>d__9();
        }
        public static string ParseTranslationResult(string html, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests)
        {
            string val_11;
            System.String[] val_12;
            string val_13;
            System.String[] val_14;
            var val_25;
            var val_26;
            TSource[] val_27;
            var val_28;
            var val_29;
            string val_30;
            var val_31;
            if((html.StartsWith(value:  "<!DOCTYPE html>")) != true)
            {
                    if((html.StartsWith(value:  "<HTML>")) == false)
            {
                goto label_4;
            }
            
            }
            
            if((html.Contains(value:  "The script completed but did not return anything")) != false)
            {
                    val_26 = "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
                return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
            }
            
            if((html.Contains(value:  "Service invoked too many times in a short time")) == false)
            {
                    return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
            }
            
            val_26 = "";
            return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
            label_4:
            string[] val_5 = new string[1];
            val_5[0] = "<I2Loc>";
            string[] val_7 = new string[1];
            val_7[0] = "<i2>";
            val_25 = 1152921504973193216;
            val_27 = System.Linq.Enumerable.ToArray<System.String>(source:  requests.Keys);
            val_28 = 0;
            goto label_21;
            label_49:
            TSource val_24 = val_27[0];
            I2.Loc.TranslationQuery val_10 = I2.Loc.GoogleTranslation.FindQueryFromOrigText(origText:  val_24, dict:  requests);
            System.String[] val_15 = (html.Split(separator:  val_5, options:  0)) + 0;
            val_29 = mem[(val_6 + 0) + 32];
            val_29 = (val_6 + 0) + 32;
            if(val_14 != 0)
            {
                    var val_25 = val_14 + 24;
                val_25 = val_25 - 1;
                if((val_25 & 2147483648) == 0)
            {
                    int val_26 = (long)val_25;
                do
            {
                val_30 = I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_26);
                var val_17 = val_14 + (((long)(int)((val_14 + 24 - 1))) << 3);
                val_26 = val_26 - 1;
                val_29 = val_29.Replace(oldValue:  val_30, newValue:  (val_14 + ((long)(int)((val_14 + 24 - 1))) << 3) + 32);
            }
            while((val_26 & 2147483648) == 0);
            
            }
            
            }
            
            System.String[] val_19 = val_29.Split(separator:  val_7, options:  0);
            if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.TitleCase(s:  val_24), b:  val_24)) == false)
            {
                goto label_37;
            }
            
            val_31 = 0;
            goto label_38;
            label_46:
            val_31 = 1;
            mem2[0] = I2.Loc.GoogleTranslation.TitleCase(s:  val_19[0]);
            label_38:
            if(val_31 < val_19.Length)
            {
                goto label_46;
            }
            
            label_37:
            val_28 = 1;
            val_11 = val_11;
            val_12 = val_12;
            val_13 = val_13;
            val_14 = val_14;
            requests.set_Item(key:  val_11, value:  new I2.Loc.TranslationQuery() {OrigText = val_11, Text = val_13, LanguageCode = val_13, TargetLanguagesCode = val_12, Results = val_19, Tags = val_14});
            val_27 = val_27;
            label_21:
            if(val_28 < (val_9 + 24))
            {
                goto label_49;
            }
            
            val_26 = 0;
            return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
        }
        public static bool IsTranslating()
        {
            var val_4;
            System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequest> val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = I2.Loc.GoogleTranslation.mCurrentTranslations;
            if(val_5.Count > 0)
            {
                    val_6 = 1;
                return (bool)(val_5.Count > 0) ? 1 : 0;
            }
            
            val_7 = null;
            val_7 = null;
            val_5 = I2.Loc.GoogleTranslation.mTranslationJobs;
            return (bool)(val_5.Count > 0) ? 1 : 0;
        }
        public static void CancelCurrentGoogleTranslations()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            I2.Loc.GoogleTranslation.mCurrentTranslations.Clear();
            List.Enumerator<T> val_1 = I2.Loc.GoogleTranslation.mTranslationJobs.GetEnumerator();
            label_7:
            if(((-957050280) & 1) == 0)
            {
                goto label_5;
            }
            
            if(0.Id != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_5:
            UniRx.Unit..cctor();
            val_4 = null;
            val_4 = null;
            I2.Loc.GoogleTranslation.mTranslationJobs.Clear();
        }
        public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_5;
            if((text.Contains(value:  "[i2s_")) == false)
            {
                goto label_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = I2.Loc.SpecializationManager.GetSpecializations(text:  text, buffer:  0).GetEnumerator();
            val_5 = 1152921509850599536;
            label_9:
            if(((-956913752) & 1) == 0)
            {
                goto label_6;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_4 = 0.Current;
            I2.Loc.GoogleTranslation.CreateQueries_Plurals(text:  val_4.Value, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  dict = dict);
            goto label_9;
            label_2:
            I2.Loc.GoogleTranslation.CreateQueries_Plurals(text:  text, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            return;
            label_6:
            UniRx.Unit..cctor();
        }
        private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_15;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_16;
            string val_17;
            string val_18;
            bool val_19;
            var val_20;
            string val_21;
            string val_22;
            val_16 = dict;
            val_17 = LanguageCodeTo;
            val_18 = LanguageCodeFrom;
            if(text != null)
            {
                    val_19 = text.Contains(value:  "{[#");
            }
            else
            {
                    val_19 = 0.Contains(value:  "{[#");
            }
            
            val_20 = 1152921504973193216;
            if(((val_19 | (text.Contains(value:  "[i2p_"))) != false) && ((I2.Loc.GoogleTranslation.HasParameters(text:  text)) != false))
            {
                    val_15 = 1152921504973086720;
                do
            {
                val_21 = 0;
                string val_6 = 0.ToString();
                UniRx.Unit..cctor();
                if((I2.Loc.GoogleLanguages.LanguageHasPluralType(langCode:  val_17, pluralType:  val_6)) != false)
            {
                    val_22 = I2.Loc.GoogleTranslation.GetPluralText(text:  text, pluralType:  val_6);
                string val_11 = I2.Loc.GoogleTranslation.GetPluralParameter(text:  val_22, forceTag:  val_19);
                val_21 = val_11;
                if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    val_16 = val_16;
                val_18 = val_18;
                val_20 = val_20;
                val_19 = val_19;
                val_15 = val_15;
                val_17 = val_17;
                val_22 = val_22.Replace(oldValue:  val_21, newValue:  I2.Loc.GoogleLanguages.GetPluralTestNumber(langCode:  val_17, pluralType:  null).ToString());
            }
            
                I2.Loc.GoogleTranslation.AddQuery(text:  val_22, LanguageCodeFrom:  val_18, LanguageCodeTo:  val_17, dict:  val_16);
            }
            
                I2.Loc.ePluralType val_15 = val_15 + 1;
            }
            while(val_15 < 6);
            
                return;
            }
            
            I2.Loc.GoogleTranslation.AddQuery(text:  text, LanguageCodeFrom:  val_18, LanguageCodeTo:  val_17, dict:  val_16);
        }
        public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            string val_4;
            string val_5;
            T[] val_6;
            var val_7;
            System.Collections.Generic.IEnumerable<TSource> val_16;
            T[] val_17;
            var val_18;
            if((System.String.IsNullOrEmpty(value:  text)) == true)
            {
                    return;
            }
            
            if((dict.ContainsKey(key:  text)) != false)
            {
                    I2.Loc.TranslationQuery val_3 = dict.Item[text];
                val_17 = val_6;
                if(((System.Array.IndexOf<System.String>(array:  val_17, value:  LanguageCodeTo)) & 2147483648) != 0)
            {
                    string[] val_9 = new string[1];
                val_16 = val_9;
                val_16[0] = LanguageCodeTo;
                val_17 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  val_17, second:  val_9)));
            }
            
                val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>::set_Item(System.String key, I2.Loc.TranslationQuery value);
                val_4 = val_4;
                val_5 = val_5;
                val_6 = val_17;
                val_7 = val_7;
            }
            else
            {
                    string[] val_13 = new string[1];
                val_16 = val_13;
                val_16[0] = LanguageCodeTo;
                I2.Loc.GoogleTranslation.ParseNonTranslatableElements(query: ref  new I2.Loc.TranslationQuery() {OrigText = text, Text = text, LanguageCode = LanguageCodeFrom, TargetLanguagesCode = val_13});
                val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>::set_Item(System.String key, I2.Loc.TranslationQuery value);
                val_5 = LanguageCodeFrom;
                val_7 = 0;
                val_4 = text;
            }
            
            dict.set_Item(key:  text, value:  new I2.Loc.TranslationQuery() {OrigText = val_4, Text = val_4, LanguageCode = val_5, TargetLanguagesCode = val_5});
        }
        private static string GetTranslation(string text, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            T[] val_3;
            var val_4;
            string val_7;
            var val_8;
            var val_9;
            val_7 = LanguageCodeTo;
            if((dict.ContainsKey(key:  text)) != false)
            {
                    I2.Loc.TranslationQuery val_2 = dict.Item[text];
                int val_5 = System.Array.IndexOf<System.String>(array:  val_3, value:  val_7);
                val_8 = "";
                if((val_4 != 0) && ((val_5 & 2147483648) == 0))
            {
                    val_7 = (long)val_5;
                val_8 = (val_4 + (((long)(int)(val_5)) << 3)) + 32;
            }
            
                val_9 = mem[((val_4 + ((long)(int)(val_5)) << 3) + 32)];
                val_9 = val_8;
                return (string)val_9;
            }
            
            val_9 = 0;
            return (string)val_9;
        }
        private static I2.Loc.TranslationQuery FindQueryFromOrigText(string origText, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            string val_6;
            System.String[] val_8;
            string val_9;
            string val_10;
            var val_13;
            I2.Loc.TranslationQuery val_0;
            Dictionary.Enumerator<TKey, TValue> val_1 = dict.GetEnumerator();
            label_3:
            if(((-955552384) & 1) == 0)
            {
                goto label_2;
            }
            
            if((System.String.op_Equality(a:  val_6, b:  origText)) == false)
            {
                goto label_3;
            }
            
            val_13 = 1152921512238478256;
            UniRx.Unit..cctor();
            val_0.LanguageCode = val_9;
            val_0.Results = val_8;
            val_0.OrigText = val_10;
            return val_0;
            label_2:
            val_13 = 1152921512238478256;
            UniRx.Unit..cctor();
            val_0.LanguageCode = 0;
            val_0.Results = 0;
            val_0.OrigText = 0;
            return val_0;
        }
        public static bool HasParameters(string text)
        {
            var val_4;
            int val_1 = text.IndexOf(value:  "{[");
            if((val_1 & 2147483648) == 0)
            {
                    var val_3 = ((text.IndexOf(value:  "]}", startIndex:  val_1)) > 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public static string GetPluralParameter(string text, bool forceTag)
        {
            int val_1 = text.IndexOf(value:  "{[#");
            if((val_1 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            label_8:
            int val_2 = val_1 + 2;
            int val_3 = text.IndexOf(value:  "]}", startIndex:  val_2);
            if((val_3 & 2147483648) != 0)
            {
                    return 0;
            }
            
            var val_5 = 2;
            val_5 = val_5 - val_1;
            val_2 = val_5 + val_3;
            return text.Substring(startIndex:  val_1, length:  val_2);
            label_2:
            if(forceTag == true)
            {
                    return 0;
            }
            
            if(((text.IndexOf(value:  "{[")) & 2147483648) == 0)
            {
                goto label_8;
            }
            
            return 0;
        }
        public static string GetPluralText(string text, string pluralType)
        {
            string val_9 = "[i2p_" + pluralType + "]";
            int val_2 = text.IndexOf(value:  val_9);
            if((val_2 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_9 = val_9.Length + val_2;
            if(text != null)
            {
                goto label_17;
            }
            
            label_18:
            label_17:
            int val_10 = val_9;
            int val_4 = text.IndexOf(value:  "[i2p_", startIndex:  val_10);
            if((val_4 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            if(text != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            val_10 = val_4 - val_9;
            return text.Substring(startIndex:  val_9, length:  val_10);
            label_2:
            int val_5 = text.IndexOf(value:  "[i2p_");
            if((val_5 & 2147483648) != 0)
            {
                    return (string)text;
            }
            
            if(text == null)
            {
                goto label_9;
            }
            
            if(val_5 == 0)
            {
                goto label_10;
            }
            
            return text.Substring(startIndex:  val_9, length:  val_10);
            label_5:
            int val_6 = text.Length;
            if(text != null)
            {
                goto label_13;
            }
            
            goto label_14;
            label_9:
            if(val_5 != 0)
            {
                    return text.Substring(startIndex:  val_9, length:  val_10);
            }
            
            label_10:
            int val_7 = text.IndexOf(value:  "]");
            if((val_7 & 2147483648) != 0)
            {
                    return (string)text;
            }
            
            int val_8 = val_7 + 1;
            if(text != null)
            {
                goto label_17;
            }
            
            goto label_18;
        }
        private static int FindClosingTag(string tag, System.Text.RegularExpressions.MatchCollection matches, int startIndex)
        {
            int val_7 = startIndex;
            int val_1 = matches.Count;
            if(val_1 > val_7)
            {
                    do
            {
                string val_2 = I2.Loc.I2Utils.GetCaptureMatch(match:  matches);
                if((val_2.Chars[0] & 65535) == ('/'))
            {
                    if((tag.StartsWith(value:  val_2.Substring(startIndex:  1))) == true)
            {
                    return (int)val_7;
            }
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_1);
            
            }
            
            val_7 = 0;
            return (int)val_7;
        }
        private static string GetGoogleNoTranslateTag(int tagNumber)
        {
            int val_3 = tagNumber;
            if(val_3 <= 69)
            {
                    return Substring(startIndex:  0, length:  val_3 + 1);
            }
            
            val_3 = val_3 + 1;
            do
            {
                val_3 = val_3 - 1;
            }
            while(val_3 != 0);
            
            return (string)"" + "+"("+");
        }
        private static void ParseNonTranslatableElements(ref I2.Loc.TranslationQuery query)
        {
            var val_33;
            string val_34;
            string val_35;
            int val_36;
            string val_37;
            var val_38;
            var val_39;
            string val_40;
            val_33 = 1152921512242389200;
            val_34 = query.Text;
            System.Text.RegularExpressions.MatchCollection val_1 = System.Text.RegularExpressions.Regex.Matches(input:  query.Text, pattern:  "\\{\\[(.*?)]}|\\[(.*?)]|\\<(.*?)>");
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.Count == 0)
            {
                    return;
            }
            
            val_35 = query.Text;
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            val_36 = val_1.Count;
            if(val_36 < 1)
            {
                goto label_5;
            }
            
            var val_33 = 0;
            label_39:
            string val_5 = I2.Loc.I2Utils.GetCaptureMatch(match:  val_1);
            if(((I2.Loc.GoogleTranslation.FindClosingTag(tag:  val_5, matches:  val_1, startIndex:  0)) & 2147483648) != 0)
            {
                goto label_8;
            }
            
            if((System.String.op_Equality(a:  val_5, b:  "i2nt")) == false)
            {
                goto label_9;
            }
            
            val_37 = query.Text.Substring(startIndex:  val_1.Index, length:  (val_1.Index - val_1.Index) + val_1.Length);
            val_33 = val_33;
            val_36 = val_36;
            val_34 = I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_3.Count)(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_3.Count)) + " ";
            if(query.Text != null)
            {
                goto label_37;
            }
            
            goto label_19;
            label_8:
            val_34 = val_1;
            val_37 = val_34.ToString();
            if(((val_37.StartsWith(value:  "{[")) == false) || ((val_37.EndsWith(value:  "]}")) == false))
            {
                goto label_24;
            }
            
            val_38 = val_3.Count;
            goto label_28;
            label_9:
            string val_22 = val_1.ToString();
            val_39 = query.Text.Replace(oldValue:  val_22, newValue:  I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_3.Count)(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_3.Count)) + " ");
            val_3.Add(item:  val_22);
            val_37 = val_1.ToString();
            val_38 = val_3;
            label_28:
            val_34 = I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_3.Count)(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_3.Count)) + " ";
            if(val_39 != null)
            {
                goto label_37;
            }
            
            label_19:
            label_37:
            val_40 = val_39.Replace(oldValue:  val_37, newValue:  val_34);
            val_3.Add(item:  val_37);
            label_24:
            val_33 = val_33 + 1;
            if(val_36 != val_33)
            {
                goto label_39;
            }
            
            label_5:
            query.Text = val_40;
            query.Tags = val_3.ToArray();
        }
        public static string GetQueryResult(string text, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_3;
            T[] val_4;
            string val_8;
            string val_9;
            var val_10;
            val_8 = LanguageCodeTo;
            val_9 = text;
            if((dict.ContainsKey(key:  val_9)) != false)
            {
                    I2.Loc.TranslationQuery val_2 = dict.Item[val_9];
                val_9 = val_3;
                if((val_9 != 0) && (((val_3 + 24) & 2147483648) == 0))
            {
                    if((System.String.IsNullOrEmpty(value:  val_8)) != false)
            {
                    val_10 = mem[val_3 + 32];
                val_10 = val_3 + 32;
                return (string)val_10;
            }
            
                int val_6 = System.Array.IndexOf<System.String>(array:  val_4, value:  val_8);
                if((val_6 & 2147483648) == 0)
            {
                    val_8 = (long)val_6;
                var val_7 = val_9 + (((long)(int)(val_6)) << 3);
                val_10 = mem[(val_3 + ((long)(int)(val_6)) << 3) + 32];
                val_10 = (val_3 + ((long)(int)(val_6)) << 3) + 32;
                return (string)val_10;
            }
            
            }
            
            }
            
            val_10 = 0;
            return (string)val_10;
        }
        public static string RebuildTranslation(string text, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string LanguageCodeTo)
        {
            string val_10 = text;
            if((val_10.Contains(value:  "[i2s_")) == false)
            {
                goto label_2;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = null;
            val_10 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Dictionary.Enumerator<TKey, TValue> val_4 = I2.Loc.SpecializationManager.GetSpecializations(text:  val_10 = text, buffer:  0).GetEnumerator();
            label_10:
            if(((-953671928) & 1) == 0)
            {
                goto label_6;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_5 = 0.Current;
            val_3.set_Item(key:  val_5.Value.Id, value:  I2.Loc.GoogleTranslation.RebuildTranslation_Plural(text:  val_5.Value, dict:  dict, LanguageCodeTo:  LanguageCodeTo));
            goto label_10;
            label_2:
            string val_8 = I2.Loc.GoogleTranslation.RebuildTranslation_Plural(text:  val_10, dict:  dict, LanguageCodeTo:  LanguageCodeTo);
            return (string)I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_3);
            label_6:
            UniRx.Unit..cctor();
            return (string)I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_3);
        }
        private static string RebuildTranslation_Plural(string text, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string LanguageCodeTo)
        {
            var val_23;
            var val_24;
            var val_25;
            string val_26;
            string val_27;
            string val_28;
            var val_29;
            var val_30;
            if(text != null)
            {
                    bool val_1 = text.Contains(value:  "{[#");
            }
            else
            {
                    bool val_2 = 0.Contains(value:  "{[#");
            }
            
            val_24 = 1152921504973193216;
            val_25 = text.Contains(value:  "[i2p_");
            bool val_23 = val_2;
            val_23 = val_23 | val_25;
            if((val_23 == false) || ((I2.Loc.GoogleTranslation.HasParameters(text:  text)) == false))
            {
                    return (string)I2.Loc.GoogleTranslation.GetTranslation(text:  text, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            }
            
            System.Text.StringBuilder val_5 = null;
            val_25 = val_5;
            val_5 = new System.Text.StringBuilder();
            val_23 = 1152921504973086720;
            label_27:
            string val_6 = 5.ToString();
            UniRx.Unit..cctor();
            val_26 = val_6;
            if((I2.Loc.GoogleLanguages.LanguageHasPluralType(langCode:  LanguageCodeTo, pluralType:  val_26)) == false)
            {
                goto label_11;
            }
            
            val_27 = I2.Loc.GoogleTranslation.GetPluralText(text:  text, pluralType:  val_6);
            int val_9 = I2.Loc.GoogleLanguages.GetPluralTestNumber(langCode:  LanguageCodeTo, pluralType:  null);
            string val_11 = I2.Loc.GoogleTranslation.GetPluralParameter(text:  val_27, forceTag:  val_2);
            if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    val_24 = 1152921504973193216;
                val_27 = val_27.Replace(oldValue:  val_11, newValue:  val_9.ToString());
            }
            
            val_28 = I2.Loc.GoogleTranslation.GetTranslation(text:  val_27, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    val_28 = val_28.Replace(oldValue:  val_9.ToString(), newValue:  val_11);
            }
            
            val_29 = val_28;
            if(null == 5)
            {
                goto label_22;
            }
            
            val_26 = 0;
            if((System.String.op_Equality(a:  val_28, b:  val_26)) == false)
            {
                goto label_23;
            }
            
            label_11:
            val_29 = 0;
            goto label_24;
            label_23:
            System.Text.StringBuilder val_20 = val_5.AppendFormat(format:  "[i2p_{0}]", arg0:  val_6);
            val_29 = 0;
            label_22:
            val_26 = val_28;
            System.Text.StringBuilder val_21 = val_5.Append(value:  val_26);
            label_24:
            I2.Loc.ePluralType val_24 = val_24 - 1;
            if((val_24 & 2147483648) == 0)
            {
                goto label_27;
            }
            
            val_30 = val_25;
            return (string)I2.Loc.GoogleTranslation.GetTranslation(text:  text, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
        }
        public static string UppercaseFirst(string s)
        {
            if((System.String.IsNullOrEmpty(value:  s)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            System.Char[] val_3 = s.ToLower().ToCharArray();
            val_3[0] = System.Char.ToUpper(c:  val_3[0]);
            return 0.CreateString(val:  val_3);
        }
        public static string TitleCase(string s)
        {
            if((System.String.IsNullOrEmpty(value:  s)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
            if(val_2 != null)
            {
                    return val_2.ToTitleCase(str:  s);
            }
            
            return val_2.ToTitleCase(str:  s);
        }
        private static GoogleTranslation()
        {
            I2.Loc.GoogleTranslation.mCurrentTranslations = new System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequest>();
            I2.Loc.GoogleTranslation.mTranslationJobs = new System.Collections.Generic.List<I2.Loc.TranslationJob>();
        }
    
    }

}
