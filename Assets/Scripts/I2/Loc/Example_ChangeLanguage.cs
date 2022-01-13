using UnityEngine;

namespace I2.Loc
{
    public class Example_ChangeLanguage : MonoBehaviour
    {
        // Methods
        public void SetLanguage_English()
        {
            this.SetLanguage(LangName:  "English");
        }
        public void SetLanguage_French()
        {
            this.SetLanguage(LangName:  "French");
        }
        public void SetLanguage_Spanish()
        {
            this.SetLanguage(LangName:  "Spanish");
        }
        public void SetLanguage(string LangName)
        {
            if((I2.Loc.LocalizationManager.HasLanguage(Language:  LangName, AllowDiscartingRegion:  true, Initialize:  true, SkipDisabled:  true)) == false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.CurrentLanguage = LangName;
        }
        public Example_ChangeLanguage()
        {
        
        }
    
    }

}
