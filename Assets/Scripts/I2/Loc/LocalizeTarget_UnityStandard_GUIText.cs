using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_GUIText : LocalizeTarget<UnityEngine.GUIText>
    {
        // Fields
        private UnityEngine.TextAlignment mAlignment_RTL;
        private UnityEngine.TextAlignment mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_UnityStandard_GUIText()
        {
            I2.Loc.LocalizeTarget_UnityStandard_GUIText.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.GUIText, I2.Loc.LocalizeTarget_UnityStandard_GUIText> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.GUIText, I2.Loc.LocalizeTarget_UnityStandard_GUIText>();
            if(val_1 != null)
            {
                    mem[1152921512299287616] = "GUIText";
            }
            else
            {
                    mem[16] = "GUIText";
            }
            
            mem[1152921512299287624] = 100;
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
            string val_8;
            var val_10;
            var val_11;
            val_8 = Secondary;
            val_10 = 0;
            primaryTerm = text;
            val_11 = 0;
            if((System.String.IsNullOrEmpty(value:  val_8)) != false)
            {
                    val_8 = val_8.font;
                val_11 = 0;
            }
            
            secondaryTerm = this.font.name;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_12;
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            string val_1 = mainTranslation;
            val_12 = this;
            val_13 = cmp.GetSecondaryTranslatedObj<UnityEngine.Font>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            if(val_13 != 0)
            {
                    UnityEngine.Font val_5 = X22.font;
                if(val_5 != val_13)
            {
                    val_5.font = val_13;
            }
            
            }
            
            if(this.mInitializeAlignment != false)
            {
                    this.mInitializeAlignment = false;
                UnityEngine.TextAlignment val_7 = val_13.alignment;
                this.mAlignment_RTL = val_7;
                this.mAlignment_LTR = val_7;
                val_13 = 1152921504974790656;
                val_14 = null;
                val_14 = null;
                if((I2.Loc.LocalizationManager.IsRight2Left != false) && (this.mAlignment_RTL == 2))
            {
                    this.mAlignment_LTR = 0;
            }
            
                val_14 = null;
                if((I2.Loc.LocalizationManager.IsRight2Left != true) && (this.mAlignment_LTR == 0))
            {
                    this.mAlignment_RTL = 2;
            }
            
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  text, b:  val_1)) == false)
            {
                    return;
            }
            
            if(cmp.CorrectAlignmentForRTL != false)
            {
                    if(cmp.alignment != 1)
            {
                    val_15 = null;
                val_15 = null;
                val_13 = mem[I2.Loc.LocalizationManager.IsRight2Left == false ? this.mAlignment_LTR : this.mAlignment_RTL];
                val_13 = (I2.Loc.LocalizationManager.IsRight2Left == false) ? this.mAlignment_LTR : this.mAlignment_RTL;
                cmp.alignment = val_13;
            }
            
            }
            
            this.text = val_1;
        }
        public LocalizeTarget_UnityStandard_GUIText()
        {
            this.mAlignment_RTL = 2;
            this.mInitializeAlignment = true;
        }
    
    }

}
