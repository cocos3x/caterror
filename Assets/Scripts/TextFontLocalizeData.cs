using UnityEngine;
[Serializable]
public sealed class TextFontLocalizeData
{
    // Fields
    private TextLocalizeData[] textLocalizeDataArray;
    
    // Methods
    public void Localize(LanguageManager manager)
    {
        goto label_0;
        label_4:
        this.textLocalizeDataArray[0].Localize(manager:  manager);
        0 = 1;
        label_0:
        if(0 < this.textLocalizeDataArray.Length)
        {
            goto label_4;
        }
    
    }
    public TextFontLocalizeData()
    {
    
    }

}
