using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public struct LocalizedString
    {
        // Fields
        public string mTerm;
        public bool mRTL_IgnoreArabicFix;
        public int mRTL_MaxLineLength;
        public bool mRTL_ConvertNumbers;
        public bool m_DontLocalizeParameters;
        
        // Methods
        public static string op_Implicit(I2.Loc.LocalizedString s)
        {
            string val_5 = I2.Loc.LocalizationManager.GetTranslation(Term:  mem[s.mTerm], FixForRTL:  ((mem[s.mTerm + 8]) == 0) ? 1 : 0, maxLineLengthForRTL:  mem[s.mTerm + 12], ignoreRTLnumbers:  (s.mTerm.m_stringLength == 0) ? 1 : 0, applyParameters:  true, localParametersRoot:  0, overrideLanguage:  0);
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  val_5, allowLocalizedParameters:  ((mem[s.mTerm + 17]) == 0) ? 1 : 0);
            return val_5;
        }
        public static I2.Loc.LocalizedString op_Implicit(string term)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = term;
            return new I2.Loc.LocalizedString() {mTerm = term, mRTL_IgnoreArabicFix = false, mRTL_ConvertNumbers = false, m_DontLocalizeParameters = false};
        }
        public LocalizedString(I2.Loc.LocalizedString str)
        {
            this.mRTL_ConvertNumbers = mem[str.mTerm];
            mem[1152921512320159624] = ((mem[str.mTerm + 8]) != 0) ? 1 : 0;
            mem[1152921512320159632] = (str.mTerm.m_stringLength != 0) ? 1 : 0;
            mem[1152921512320159628] = mem[str.mTerm + 12];
            mem[1152921512320159633] = ((mem[str.mTerm + 17]) != 0) ? 1 : 0;
        }
        public override string ToString()
        {
            return 26983276;
        }
    
    }

}
