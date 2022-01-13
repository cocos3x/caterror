using UnityEngine;
public sealed class TextLocalizer : MonoBehaviour
{
    // Fields
    private TextFontLocalizeData[] localizeDataArray;
    
    // Methods
    private void Awake()
    {
        goto label_1;
        label_5:
        this.localizeDataArray[0].Localize(manager:  SingletonMonoBehaviour<LanguageManager>.Instance);
        0 = 1;
        label_1:
        if(0 < this.localizeDataArray.Length)
        {
            goto label_5;
        }
    
    }
    public TextLocalizer()
    {
    
    }

}
