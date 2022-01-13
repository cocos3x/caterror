using UnityEngine;

namespace I2.Loc
{
    public class LocalizeDropdown : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<string> _Terms;
        
        // Methods
        public void Start()
        {
            mem[1152921512275879568] = this;
            mem[1152921512275879576] = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            mem[1152921512275879552] = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            I2.Loc.LocalizationManager.add_OnLocalizeEvent(value:  new LocalizationManager.OnLocalizeCallback());
            this.OnLocalize();
        }
        public void OnDestroy()
        {
            mem[1152921512275999760] = this;
            mem[1152921512275999768] = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            mem[1152921512275999744] = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  new LocalizationManager.OnLocalizeCallback());
        }
        private void OnEnable()
        {
            if(this._Terms.Count == 0)
            {
                    this.FillValues();
            }
            
            this.OnLocalize();
        }
        public void OnLocalize()
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.gameObject == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.CurrentLanguage)) != false)
            {
                    return;
            }
            
            this.UpdateLocalization();
        }
        private void FillValues()
        {
            var val_8 = this;
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(val_1 == 0)
            {
                    if(I2.Loc.I2Utils.IsPlaying() != false)
            {
                    this.FillValuesTMPro();
                return;
            }
            
            }
            
            List.Enumerator<T> val_5 = val_1.options.GetEnumerator();
            label_11:
            if(((-920427464) & 1) == 0)
            {
                goto label_8;
            }
            
            this._Terms.Add(item:  0.Id.text);
            goto label_11;
            label_8:
            UniRx.Unit..cctor();
        }
        public void UpdateLocalization()
        {
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(val_1 == 0)
            {
                    this.UpdateLocalizationTMPro();
                return;
            }
            
            val_1.options.Clear();
            List.Enumerator<T> val_4 = this._Terms.GetEnumerator();
            label_13:
            if(((-920266344) & 1) == 0)
            {
                goto label_8;
            }
            
            new Dropdown.OptionData() = new Dropdown.OptionData(text:  I2.Loc.LocalizationManager.GetTranslation(Term:  0.Id, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0));
            val_1.options.Add(item:  new Dropdown.OptionData());
            goto label_13;
            label_8:
            UniRx.Unit..cctor();
            val_1.RefreshShownValue();
        }
        public void UpdateLocalizationTMPro()
        {
            TMPro.TMP_Dropdown val_1 = this.GetComponent<TMPro.TMP_Dropdown>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.options.Clear();
            List.Enumerator<T> val_4 = this._Terms.GetEnumerator();
            label_12:
            if(((-920093928) & 1) == 0)
            {
                goto label_7;
            }
            
            new TMP_Dropdown.OptionData() = new TMP_Dropdown.OptionData(text:  I2.Loc.LocalizationManager.GetTranslation(Term:  0.Id, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0));
            val_1.options.Add(item:  new TMP_Dropdown.OptionData());
            goto label_12;
            label_7:
            UniRx.Unit..cctor();
            val_1.RefreshShownValue();
        }
        private void FillValuesTMPro()
        {
            var val_7 = this;
            TMPro.TMP_Dropdown val_1 = this.GetComponent<TMPro.TMP_Dropdown>();
            if(val_1 == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_4 = val_1.options.GetEnumerator();
            label_9:
            if(((-919928648) & 1) == 0)
            {
                goto label_6;
            }
            
            this._Terms.Add(item:  0.Id.text);
            goto label_9;
            label_6:
            UniRx.Unit..cctor();
        }
        public LocalizeDropdown()
        {
            this._Terms = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
