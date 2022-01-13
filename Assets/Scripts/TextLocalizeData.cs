using UnityEngine;
[Serializable]
public sealed class TextLocalizeData
{
    // Fields
    private int localizeTextId;
    private TextWithFontChanger[] textArray;
    
    // Methods
    public void Localize(LanguageManager manager)
    {
        goto label_1;
        label_5:
        this.textArray[0].text = manager.GetWordUI(id:  this.localizeTextId);
        0 = 1;
        label_1:
        if(0 < this.textArray.Length)
        {
            goto label_5;
        }
    
    }
    public TextLocalizeData()
    {
    
    }

}
