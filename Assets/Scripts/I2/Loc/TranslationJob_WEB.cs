using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_WEB : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        public string mErrorMessage;
        private string mCurrentBatch_ToLanguageCode;
        private string mCurrentBatch_FromLanguageCode;
        private System.Collections.Generic.List<string> mCurrentBatch_Text;
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> mQueries;
        
        // Methods
        public TranslationJob_WEB(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            val_1 = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            val_1.FindAllQueries();
            val_1.ExecuteNextBatch();
        }
        private void FindAllQueries()
        {
            var val_6;
            var val_7;
            string val_9;
            string val_10;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_16;
            var val_17;
            var val_18;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_1 = null;
            val_16 = val_1;
            val_1 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>>();
            this.mQueries = val_16;
            Dictionary.Enumerator<TKey, TValue> val_2 = this._requests.GetEnumerator();
            goto label_2;
            label_8:
            val_17 = 0;
            goto label_3;
            label_7:
            var val_8 = val_7 + 0;
            val_16 = val_9;
            val_6 = 0;
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_12 = new System.Collections.Generic.KeyValuePair<System.String, System.String>(key:  val_16, value:  val_10 + ":"(":") + (val_7 + 0) + 32((val_7 + 0) + 32));
            this.mQueries.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, System.String>() {Value = val_12.Value});
            val_17 = 1;
            label_3:
            if(val_17 < (val_7 + 24))
            {
                goto label_7;
            }
            
            label_2:
            if(((-949151840) & 1) != 0)
            {
                goto label_8;
            }
            
            UniRx.Unit..cctor();
            val_18 = null;
            val_18 = null;
            if((TranslationJob_WEB.<>c.<>9__8_0) == null)
            {
                goto label_21;
            }
            
            label_26:
            this.mQueries.Sort(comparison:  TranslationJob_WEB.<>c.<>9__8_0);
            return;
            label_21:
            TranslationJob_WEB.<>c.<>9__8_0 = new System.Comparison<System.Collections.Generic.KeyValuePair<System.String, System.String>>(object:  TranslationJob_WEB.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TranslationJob_WEB.<>c::<FindAllQueries>b__8_0(System.Collections.Generic.KeyValuePair<string, string> a, System.Collections.Generic.KeyValuePair<string, string> b));
            if(this.mQueries != null)
            {
                goto label_26;
            }
            
            goto label_26;
        }
        private void ExecuteNextBatch()
        {
            var val_17;
            string val_18;
            System.Char[] val_19;
            string val_20;
            if(this.mQueries.Count == 0)
            {
                goto label_2;
            }
            
            this.mCurrentBatch_Text = new System.Collections.Generic.List<System.String>();
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
            val_17 = 0;
            val_18 = 0;
            goto label_3;
            label_15:
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_4 = this.mQueries.Item[0];
            string val_5 = val_4.Value.Id;
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_6 = this.mQueries.Item[0];
            if(val_18 != 0)
            {
                    if((System.String.op_Equality(a:  val_6.Value, b:  val_18)) == false)
            {
                goto label_7;
            }
            
            }
            
            if(val_17 != 0)
            {
                    System.Text.StringBuilder val_8 = val_3.Append(value:  "|||");
            }
            
            System.Text.StringBuilder val_9 = val_3.Append(value:  val_5);
            this.mCurrentBatch_Text.Add(item:  val_5);
            val_18 = ;
            label_7:
            if(val_3.Length > 200)
            {
                goto label_13;
            }
            
            val_17 = 1;
            label_3:
            if(val_17 < this.mQueries.Count)
            {
                goto label_15;
            }
            
            label_13:
            this.mQueries.RemoveRange(index:  0, count:  1);
            char[] val_12 = new char[1];
            val_12[0] = ':';
            val_19 = val_12;
            System.String[] val_13 = val_6.Value.Split(separator:  val_12);
            if(val_13.Length == 0)
            {
                    val_19 = 0;
            }
            
            val_20 = val_13[0];
            this.mCurrentBatch_FromLanguageCode = val_20;
            if(val_13.Length <= 1)
            {
                    val_19 = 0;
                val_20 = this.mCurrentBatch_FromLanguageCode;
            }
            
            string val_17 = val_13[1];
            this.mCurrentBatch_ToLanguageCode = val_17;
            string val_15 = System.String.Format(format:  "http://www.google.com/translate_t?hl=en&vi=c&ie=UTF8&oe=UTF8&submit=Translate&langpair={0}|{1}&text={2}", arg0:  val_20, arg1:  val_17, arg2:  System.Uri.EscapeUriString(stringToEscape:  val_3));
            UnityEngine.Debug.Log(message:  val_15);
            UnityEngine.Networking.UnityWebRequest val_16 = UnityEngine.Networking.UnityWebRequest.Get(uri:  val_15);
            mem[1152921512247892552] = val_16;
            I2.Loc.I2Utils.SendWebRequest(www:  val_16);
            return;
            label_2:
            mem[1152921512247892544] = 1;
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this != null)
            {
                    if(this.isDone != false)
            {
                    System.Byte[] val_3 = X20.downloadHandler.data;
                this.ProcessResult(bytes:  val_3, errorMsg:  X21.error);
                val_3.Dispose();
                mem[1152921512248160216] = 0;
            }
            else
            {
                    if(X20 != 0)
            {
                    return (eJobState)this;
            }
            
            }
            
            }
            
            this.ExecuteNextBatch();
            return (eJobState)this;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            System.Byte[] val_5 = bytes;
            if((System.String.IsNullOrEmpty(value:  errorMsg)) == false)
            {
                goto label_6;
            }
            
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            if(val_5 == null)
            {
                goto label_2;
            }
            
            label_9:
            val_5 = val_2.ParseTranslationResult(html:  val_2, OriginalText:  "aab");
            UnityEngine.Debug.Log(message:  val_5);
            if((System.String.IsNullOrEmpty(value:  errorMsg)) != false)
            {
                    if(this._OnTranslationReady == null)
            {
                    return;
            }
            
                this._OnTranslationReady.Invoke(arg1:  this._requests, arg2:  0);
                return;
            }
            
            label_6:
            mem[1152921512248374688] = 2;
            this.mErrorMessage = errorMsg;
            return;
            label_2:
            if(val_2 != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        private string ParseTranslationResult(string html, string OriginalText)
        {
            var val_19;
            var val_20;
            System.Text.RegularExpressions.MatchEvaluator val_22;
            var val_24;
            System.Text.RegularExpressions.MatchEvaluator val_26;
            string val_27;
            string val_28;
            int val_19 = html.IndexOf(value:  "TRANSLATED_TEXT=\'");
            val_19 = "TRANSLATED_TEXT=\'";
            if(("TRANSLATED_TEXT=\'") == null)
            {
                    val_19 = "TRANSLATED_TEXT=\'";
            }
            
            val_19 = Length + val_19;
            int val_20 = val_19;
            val_20 = (html.IndexOf(value:  "\';var", startIndex:  val_20)) - val_19;
            val_20 = null;
            val_20 = null;
            val_22 = TranslationJob_WEB.<>c.<>9__12_0;
            if(val_22 == null)
            {
                    val_22 = new System.Text.RegularExpressions.MatchEvaluator();
                val_22 = new System.Text.RegularExpressions.MatchEvaluator(object:  TranslationJob_WEB.<>c.__il2cppRuntimeField_static_fields, method:  System.String TranslationJob_WEB.<>c::<ParseTranslationResult>b__12_0(System.Text.RegularExpressions.Match match));
                TranslationJob_WEB.<>c.<>9__12_0 = val_22;
            }
            
            val_24 = null;
            val_24 = null;
            val_26 = TranslationJob_WEB.<>c.<>9__12_1;
            val_27 = "&#(\\d+);";
            if(val_26 == null)
            {
                    val_26 = new System.Text.RegularExpressions.MatchEvaluator();
                val_26 = new System.Text.RegularExpressions.MatchEvaluator(object:  TranslationJob_WEB.<>c.__il2cppRuntimeField_static_fields, method:  System.String TranslationJob_WEB.<>c::<ParseTranslationResult>b__12_1(System.Text.RegularExpressions.Match match));
                TranslationJob_WEB.<>c.<>9__12_1 = val_26;
            }
            
            val_28 = System.Text.RegularExpressions.Regex.Replace(input:  System.Text.RegularExpressions.Regex.Replace(input:  html.Substring(startIndex:  val_19, length:  val_20), pattern:  "\\\\x([a-fA-F0-9]{2})", evaluator:  new System.Text.RegularExpressions.MatchEvaluator()), pattern:  val_27, evaluator:  new System.Text.RegularExpressions.MatchEvaluator()).Replace(oldValue:  "<br>", newValue:  "\n");
            if((System.String.op_Equality(a:  OriginalText.ToUpper(), b:  OriginalText)) != false)
            {
                    val_28 = val_28.ToUpper();
                return (string)val_28;
            }
            
            val_27 = 1152921504973193216;
            if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.UppercaseFirst(s:  OriginalText), b:  OriginalText)) != false)
            {
                    val_28 = I2.Loc.GoogleTranslation.UppercaseFirst(s:  val_28);
                return (string)val_28;
            }
            
            if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.TitleCase(s:  OriginalText), b:  OriginalText)) == false)
            {
                    return (string)val_28;
            }
            
            val_28 = I2.Loc.GoogleTranslation.TitleCase(s:  val_28);
            return (string)val_28;
        }
    
    }

}
