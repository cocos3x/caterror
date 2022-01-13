using UnityEngine;

namespace I2.Loc
{
    public class CallbackNotification : MonoBehaviour
    {
        // Methods
        public void OnModifyLocalization()
        {
            string val_4;
            if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.MainTranslation)) == true)
            {
                    return;
            }
            
            val_4 = I2.Loc.LocalizationManager.GetTranslation(Term:  "Color/Red", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0);
            I2.Loc.Localize.MainTranslation = I2.Loc.Localize.MainTranslation.Replace(oldValue:  "{PLAYER_COLOR}", newValue:  val_4);
        }
        public CallbackNotification()
        {
        
        }
    
    }

}
