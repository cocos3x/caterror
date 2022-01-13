using UnityEngine;

namespace I2.Loc
{
    public class RealTimeTranslation : MonoBehaviour
    {
        // Fields
        private string OriginalText;
        private string TranslatedText;
        private bool IsTranslating;
        
        // Methods
        public void OnGUI()
        {
            UnityEngine.GUILayout.Label(text:  "Translate:", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_2 = new UnityEngine.GUILayoutOption[1];
            UnityEngine.GUILayoutOption val_4 = UnityEngine.GUILayout.Width(width:  (float)UnityEngine.Screen.width);
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(val_4 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_4 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = val_4;
            this.OriginalText = UnityEngine.GUILayout.TextArea(text:  this.OriginalText, options:  val_2);
            UnityEngine.GUILayout.Space(pixels:  10f);
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_7 = new UnityEngine.GUILayoutOption[1];
            UnityEngine.GUILayoutOption val_8 = UnityEngine.GUILayout.Height(height:  100f);
            if(val_7 == null)
            {
                goto label_7;
            }
            
            if(val_8 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_8 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_7[0] = val_8;
            if((UnityEngine.GUILayout.Button(text:  "English -> Español", options:  val_7)) != false)
            {
                    this.StartTranslating(fromCode:  "en", toCode:  "es");
            }
            
            UnityEngine.GUILayoutOption[] val_10 = new UnityEngine.GUILayoutOption[1];
            UnityEngine.GUILayoutOption val_11 = UnityEngine.GUILayout.Height(height:  100f);
            if(val_10 == null)
            {
                goto label_14;
            }
            
            if(val_11 != null)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if(val_11 == null)
            {
                goto label_18;
            }
            
            label_15:
            label_18:
            val_10[0] = val_11;
            if((UnityEngine.GUILayout.Button(text:  "Español -> English", options:  val_10)) != false)
            {
                    this.StartTranslating(fromCode:  "es", toCode:  "en");
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.Space(pixels:  10f);
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            string val_15 = UnityEngine.GUILayout.TextArea(text:  "Multiple Translation with 1 call:\n\'This is an example\' -> en,zh\n\'Hola\' -> en", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_16 = new UnityEngine.GUILayoutOption[1];
            UnityEngine.GUILayoutOption val_17 = UnityEngine.GUILayout.ExpandHeight(expand:  true);
            if(val_16 == null)
            {
                goto label_21;
            }
            
            if(val_17 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_17 == null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            val_16[0] = val_17;
            if((UnityEngine.GUILayout.Button(text:  "Multi Translate", options:  val_16)) != false)
            {
                    this.ExampleMultiTranslations_Async();
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayoutOption[] val_19 = new UnityEngine.GUILayoutOption[1];
            UnityEngine.GUILayoutOption val_21 = UnityEngine.GUILayout.Width(width:  (float)UnityEngine.Screen.width);
            if(val_19 == null)
            {
                goto label_28;
            }
            
            if(val_21 != null)
            {
                goto label_29;
            }
            
            goto label_32;
            label_28:
            if(val_21 == null)
            {
                goto label_32;
            }
            
            label_29:
            label_32:
            val_19[0] = val_21;
            string val_22 = UnityEngine.GUILayout.TextArea(text:  this.TranslatedText, options:  val_19);
            UnityEngine.GUILayout.Space(pixels:  10f);
            if(this.IsTranslating == false)
            {
                    return;
            }
            
            UnityEngine.GUILayout.Label(text:  "Contacting Google....", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        }
        public void StartTranslating(string fromCode, string toCode)
        {
            this.IsTranslating = true;
            I2.Loc.GoogleTranslation.Translate(text:  this.OriginalText, LanguageCodeFrom:  fromCode, LanguageCodeTo:  toCode, OnTranslationReady:  new System.Action<System.String, System.String>(object:  this, method:  System.Void I2.Loc.RealTimeTranslation::OnTranslationReady(string Translation, string errorMsg)));
        }
        private void OnTranslationReady(string Translation, string errorMsg)
        {
            this.IsTranslating = false;
            if(errorMsg != null)
            {
                    UnityEngine.Debug.LogError(message:  errorMsg);
                return;
            }
            
            this.TranslatedText = Translation;
        }
        public void ExampleMultiTranslations_Blocking()
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_8;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_1 = null;
            val_8 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>();
            I2.Loc.GoogleTranslation.AddQuery(text:  "This is an example", LanguageCodeFrom:  "en", LanguageCodeTo:  "es", dict:  val_1);
            I2.Loc.GoogleTranslation.AddQuery(text:  "This is an example", LanguageCodeFrom:  "auto", LanguageCodeTo:  "zh", dict:  val_1);
            I2.Loc.GoogleTranslation.AddQuery(text:  "Hola", LanguageCodeFrom:  "es", LanguageCodeTo:  "en", dict:  val_1);
            if((I2.Loc.GoogleTranslation.ForceTranslate(requests:  val_1, usePOST:  true)) == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "en", dict:  val_1));
            UnityEngine.Debug.Log(message:  I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "zh", dict:  val_1));
            UnityEngine.Debug.Log(message:  I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "", dict:  val_1));
            I2.Loc.TranslationQuery val_6 = val_1.Item["Hola"];
            val_8 = val_7;
            UnityEngine.Debug.Log(message:  val_7 + 32);
        }
        public void ExampleMultiTranslations_Async()
        {
            this.IsTranslating = true;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_1 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>();
            I2.Loc.GoogleTranslation.AddQuery(text:  "This is an example", LanguageCodeFrom:  "en", LanguageCodeTo:  "es", dict:  val_1);
            I2.Loc.GoogleTranslation.AddQuery(text:  "This is an example", LanguageCodeFrom:  "auto", LanguageCodeTo:  "zh", dict:  val_1);
            I2.Loc.GoogleTranslation.AddQuery(text:  "Hola", LanguageCodeFrom:  "es", LanguageCodeTo:  "en", dict:  val_1);
            I2.Loc.GoogleTranslation.Translate(requests:  val_1, OnTranslationReady:  new System.Action<System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>, System.String>(object:  this, method:  System.Void I2.Loc.RealTimeTranslation::OnMultitranslationReady(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string errorMsg)), usePOST:  true);
        }
        private void OnMultitranslationReady(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string errorMsg)
        {
            if((System.String.IsNullOrEmpty(value:  errorMsg)) != false)
            {
                    this.IsTranslating = false;
                this.TranslatedText = "";
                string val_3 = "" + I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "es", dict:  dict)(I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "es", dict:  dict)) + "\n";
                this.TranslatedText = val_3;
                string val_5 = val_3 + I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "zh", dict:  dict)(I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "zh", dict:  dict)) + "\n";
                this.TranslatedText = val_5;
                string val_7 = val_5 + I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "", dict:  dict)(I2.Loc.GoogleTranslation.GetQueryResult(text:  "This is an example", LanguageCodeTo:  "", dict:  dict)) + "\n";
                this.TranslatedText = val_7;
                I2.Loc.TranslationQuery val_8 = dict.Item["Hola"];
                this.TranslatedText = val_7 + val_9 + 32(val_9 + 32);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  errorMsg);
        }
        public bool IsWaitingForTranslation()
        {
            return (bool)this.IsTranslating;
        }
        public string GetTranslatedText()
        {
            return (string)this.TranslatedText;
        }
        public void SetOriginalText(string text)
        {
            this.OriginalText = text;
        }
        public RealTimeTranslation()
        {
            this.OriginalText = "This is an example showing how to use the google translator to translate chat messages within the game.\nIt also supports multiline translations.";
            this.TranslatedText = System.String.alignConst;
        }
    
    }

}
