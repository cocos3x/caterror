using UnityEngine;

namespace I2.Loc
{
    public class Example_LocalizedString : MonoBehaviour
    {
        // Fields
        public I2.Loc.LocalizedString _MyLocalizedString;
        public string _NormalString;
        public string _StringWithTermPopup;
        
        // Methods
        public void Start()
        {
            string val_5;
            object val_9;
            object val_11;
            object val_15;
            UnityEngine.Debug.Log(message:  this._MyLocalizedString);
            UnityEngine.Debug.Log(message:  I2.Loc.LocalizationManager.GetTranslation(Term:  this._NormalString, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0));
            UnityEngine.Debug.Log(message:  I2.Loc.LocalizationManager.GetTranslation(Term:  this._StringWithTermPopup, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0));
            I2.Loc.LocalizedString val_3 = I2.Loc.LocalizedString.op_Implicit(term:  "Term2");
            UnityEngine.Debug.Log(message:  I2.Loc.LocalizedString.op_Implicit(s:  new I2.Loc.LocalizedString() {mTerm = val_5, mRTL_IgnoreArabicFix = false, mRTL_ConvertNumbers = val_3.mRTL_ConvertNumbers, m_DontLocalizeParameters = val_3.m_DontLocalizeParameters}));
            UnityEngine.Debug.Log(message:  this._MyLocalizedString.mTerm);
            I2.Loc.LocalizedString val_7 = I2.Loc.LocalizedString.op_Implicit(term:  "Term3");
            UnityEngine.Debug.Log(message:  val_9);
            I2.Loc.LocalizedString val_10 = I2.Loc.LocalizedString.op_Implicit(term:  "Term3");
            UnityEngine.Debug.Log(message:  val_11);
            I2.Loc.LocalizedString val_14 = I2.Loc.LocalizedString.op_Implicit(term:  "Term3");
            UnityEngine.Debug.Log(message:  val_15);
            UnityEngine.Debug.Log(message:  val_15);
        }
        public Example_LocalizedString()
        {
        
        }
    
    }

}
