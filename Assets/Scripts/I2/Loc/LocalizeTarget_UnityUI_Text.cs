using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_Text : LocalizeTarget<UnityEngine.UI.Text>
    {
        // Fields
        private UnityEngine.TextAnchor mAlignment_RTL;
        private UnityEngine.TextAnchor mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_UnityUI_Text()
        {
            I2.Loc.LocalizeTarget_UnityUI_Text.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Text, I2.Loc.LocalizeTarget_UnityUI_Text> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Text, I2.Loc.LocalizeTarget_UnityUI_Text>();
            if(val_1 != null)
            {
                    mem[1152921512310075152] = "Text";
            }
            else
            {
                    mem[16] = "Text";
            }
            
            mem[1152921512310075160] = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 1;
        }
        public override bool CanUseSecondaryTerm()
        {
            return true;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return true;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            string val_6;
            int val_7;
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  37224448)) != false)
            {
                    val_6 = 37224448;
            }
            
            primaryTerm = val_6;
            if(primaryTerm.font != 0)
            {
                    string val_5 = this.font.name;
            }
            else
            {
                    val_7 = System.String.alignConst;
            }
            
            secondaryTerm = val_7;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_18;
            var val_19;
            string val_20;
            var val_21;
            UnityEngine.TextAnchor val_22;
            var val_23;
            var val_24;
            UnityEngine.TextAnchor val_25;
            UnityEngine.TextAnchor val_26;
            var val_27;
            var val_28;
            string val_1 = mainTranslation;
            val_18 = this;
            UnityEngine.Font val_3 = cmp.GetSecondaryTranslatedObj<UnityEngine.Font>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            if(val_3 != 0)
            {
                    UnityEngine.Font val_5 = X22.font;
                if(val_3 != val_5)
            {
                    val_5.font = val_3;
            }
            
            }
            
            if(this.mInitializeAlignment == false)
            {
                goto label_10;
            }
            
            this.mInitializeAlignment = false;
            val_19 = null;
            val_19 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            UnityEngine.TextAnchor val_8 = alignment;
            val_8.InitAlignment(isRTL:  (I2.Loc.LocalizationManager.IsRight2Left == true) ? 1 : 0, alignment:  val_8, alignLTR: out  this.mAlignment_LTR, alignRTL: out  this.mAlignment_RTL);
            goto label_14;
            label_10:
            UnityEngine.TextAnchor val_11 = val_3.alignment;
            if(this.mAlignmentWasRTL == false)
            {
                goto label_16;
            }
            
            if(val_11 >= 9)
            {
                goto label_20;
            }
            
            val_22 = val_11;
            if(((365 >> (val_11 & 65535)) & 1) == 0)
            {
                goto label_22;
            }
            
            val_23 = mem[26982960 + (val_11) << 2];
            val_23 = 26982960 + (val_11) << 2;
            val_24 = 26982912;
            goto label_19;
            label_16:
            if(val_11 >= 9)
            {
                goto label_20;
            }
            
            val_22 = val_11;
            if(((365 >> (val_11 & 65535)) & 1) == 0)
            {
                goto label_22;
            }
            
            val_23 = mem[26982912 + (val_11) << 2];
            val_23 = 26982912 + (val_11) << 2;
            val_24 = 26982960;
            label_19:
            val_22 = mem[val_24 + (val_11) << 2];
            val_22 = val_24 + (val_11) << 2;
            val_21 = val_23;
            goto label_22;
            label_20:
            val_22 = val_11;
            label_22:
            if(this.mAlignmentWasRTL == false)
            {
                goto label_23;
            }
            
            val_25 = val_18;
            if(this.mAlignment_RTL == val_11)
            {
                goto label_26;
            }
            
            val_26 = this.mAlignment_LTR;
            goto label_25;
            label_23:
            val_26 = val_18;
            if(this.mAlignment_LTR == val_22)
            {
                goto label_26;
            }
            
            val_25 = this.mAlignment_RTL;
            label_25:
            this.mAlignment_LTR = val_22;
            mem2[0] = val_11;
            label_26:
            val_20 = 1152921504974790656;
            val_27 = null;
            val_27 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            label_14:
            if(val_1 == 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  val_20, b:  val_1)) == false)
            {
                    return;
            }
            
            if(cmp.CorrectAlignmentForRTL != false)
            {
                    val_28 = null;
                val_28 = null;
                cmp.alignment = (I2.Loc.LocalizationManager.IsRight2Left == false) ? this.mAlignment_LTR : this.mAlignment_RTL;
            }
            
            val_20 = val_1;
        }
        private void InitAlignment(bool isRTL, UnityEngine.TextAnchor alignment, out UnityEngine.TextAnchor alignLTR, out UnityEngine.TextAnchor alignRTL)
        {
            alignRTL = alignment;
            alignLTR = alignment;
            if(isRTL != false)
            {
                    if(alignment > 8)
            {
                    return;
            }
            
                var val_1 = 26982780 + (alignment) << 2;
                val_1 = val_1 + 26982780;
            }
            else
            {
                    if(alignment > 8)
            {
                    return;
            }
            
                var val_2 = 26982744 + (alignment) << 2;
                val_2 = val_2 + 26982744;
            }
        
        }
        public LocalizeTarget_UnityUI_Text()
        {
            this.mAlignment_RTL = 2;
            this.mInitializeAlignment = true;
        }
    
    }

}
