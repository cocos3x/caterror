using UnityEngine;

namespace I2.Loc
{
    public class SetLanguageDropdown : MonoBehaviour
    {
        // Methods
        private void OnEnable()
        {
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(val_1 == 0)
            {
                    return;
            }
            
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_5 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            System.Collections.Generic.List<System.String> val_6 = I2.Loc.LocalizationManager.GetAllLanguages(SkipDisabled:  true);
            if(val_1 != null)
            {
                    val_1.ClearOptions();
            }
            else
            {
                    val_1.ClearOptions();
            }
            
            val_1.AddOptions(options:  val_6);
            int val_7 = val_6.IndexOf(item:  I2.Loc.LocalizationManager.CurrentLanguage);
            if(val_1 != null)
            {
                    val_1.value = val_7;
            }
            else
            {
                    val_1.value = val_7;
            }
            
            val_1.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void I2.Loc.SetLanguageDropdown::OnValueChanged(int index)));
            val_1.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void I2.Loc.SetLanguageDropdown::OnValueChanged(int index)));
        }
        private void OnValueChanged(int index)
        {
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if((index & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if(val_1 != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            I2.Loc.LocalizationManager.CurrentLanguage = val_1.options.Item[index].text;
            return;
            label_1:
            val_1.value = 0;
            if(val_1 != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        public SetLanguageDropdown()
        {
        
        }
    
    }

}
