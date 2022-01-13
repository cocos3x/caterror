using UnityEngine;
public class RestoreButton : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        this.gameObject.SetActive(value:  false);
    }
    public void Success()
    {
        PopupView val_2 = PopupView.Show(_callback:  0, _withCloseButton:  false, _descriptionStr:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Restore/Success", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0));
    }
    public void Fail()
    {
        PopupView val_2 = PopupView.Show(_callback:  0, _withCloseButton:  false, _descriptionStr:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Restore/Fail", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0));
    }
    public RestoreButton()
    {
    
    }

}
