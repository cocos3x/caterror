using UnityEngine;
private sealed class GoogleTranslation.<>c__DisplayClass1_0
{
    // Fields
    public System.Action<string, string> OnTranslationReady;
    public string text;
    public System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> queries;
    public string LanguageCodeTo;
    
    // Methods
    public GoogleTranslation.<>c__DisplayClass1_0()
    {
    
    }
    internal void <Translate>b__0(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> results, string error)
    {
        string val_4;
        System.Action<System.String, System.String> val_5;
        var val_6;
        string val_7;
        string val_8;
        val_4 = results;
        if(((System.String.IsNullOrEmpty(value:  error)) != false) && (val_4.Count != 0))
        {
                val_4 = this.LanguageCodeTo;
            val_5 = I2.Loc.GoogleTranslation.RebuildTranslation(text:  this.text, dict:  this.queries, LanguageCodeTo:  val_4);
            val_6 = 1152921509462714160;
            val_7 = val_5;
            val_8 = 0;
        }
        else
        {
                val_5 = this.OnTranslationReady;
            val_6 = 1152921509462714160;
            val_7 = 0;
            val_8 = error;
        }
        
        val_5.Invoke(arg1:  val_7, arg2:  val_8);
    }

}
