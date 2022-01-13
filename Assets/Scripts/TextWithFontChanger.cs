using UnityEngine;
public class TextWithFontChanger : Text
{
    // Methods
    protected override void Start()
    {
        this.Start();
        LanguageManager val_1 = SingletonMonoBehaviour<LanguageManager>.Instance;
        if(val_1.GetDeviceLanguageDataType() == 0)
        {
                return;
        }
        
        this.font = val_1.Font;
    }
    public TextWithFontChanger()
    {
    
    }

}
