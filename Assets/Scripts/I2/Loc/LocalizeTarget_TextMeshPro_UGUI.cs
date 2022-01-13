using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TMPro.TextMeshProUGUI>
    {
        // Fields
        public TMPro.TextAlignmentOptions mAlignment_RTL;
        public TMPro.TextAlignmentOptions mAlignment_LTR;
        public bool mAlignmentWasRTL;
        public bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_TextMeshPro_UGUI()
        {
            I2.Loc.LocalizeTarget_TextMeshPro_UGUI.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshProUGUI, I2.Loc.LocalizeTarget_TextMeshPro_UGUI> val_1 = new I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshProUGUI, I2.Loc.LocalizeTarget_TextMeshPro_UGUI>();
            if(val_1 != null)
            {
                    mem[1152921512295019504] = "TextMeshPro UGUI";
            }
            else
            {
                    mem[16] = "TextMeshPro UGUI";
            }
            
            mem[1152921512295019512] = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 9;
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
            var val_7;
            int val_8;
            val_7 = 0;
            primaryTerm = text;
            if(primaryTerm.font != 0)
            {
                    string val_6 = this.font.name;
            }
            else
            {
                    val_8 = System.String.alignConst;
            }
            
            secondaryTerm = val_8;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_30;
            string val_31;
            string val_32;
            var val_33;
            TMPro.TextAlignmentOptions val_34;
            TMPro.TextAlignmentOptions val_35;
            var val_36;
            TMPro.TextAlignmentOptions val_37;
            TMPro.TextAlignmentOptions val_38;
            var val_39;
            var val_40;
            var val_41;
            val_30 = this;
            string val_2 = secondaryTranslation;
            string val_1 = mainTranslation;
            TMPro.TextAlignmentOptions val_24 = 0;
            TMPro.TMP_FontAsset val_3 = cmp.GetSecondaryTranslatedObj<TMPro.TMP_FontAsset>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2);
            if(val_3 != 0)
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  X22, newFont:  val_3);
            }
            else
            {
                    UnityEngine.Material val_5 = cmp.GetSecondaryTranslatedObj<UnityEngine.Material>(mainTranslation: ref  val_1, secondaryTranslation: ref  val_2);
                if((val_5 != 0) && (X22.fontMaterial != val_5))
            {
                    val_31 = X23.font.name;
                if((val_5.name.StartsWith(value:  val_31, comparisonType:  4)) != true)
            {
                    if((val_2.EndsWith(value:  val_5.name, comparisonType:  4)) != false)
            {
                    val_32 = val_2;
            }
            else
            {
                    val_32 = val_5.name;
            }
            
                val_31 = 1152921504975642624;
                TMPro.TMP_FontAsset val_16 = I2.Loc.LocalizeTarget_TextMeshPro_Label.GetTMPFontFromMaterial(cmp:  cmp, matName:  val_32);
                if(val_16 != 0)
            {
                    I2.Loc.LocalizeTarget_TextMeshPro_Label.SetFont(label:  val_31, newFont:  val_16);
            }
            
            }
            
                I2.Loc.LocalizeTarget_TextMeshPro_Label.SetMaterial(label:  val_16, newMat:  val_5);
            }
            
            }
            
            if(this.mInitializeAlignment == false)
            {
                goto label_35;
            }
            
            this.mInitializeAlignment = false;
            val_33 = null;
            val_33 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            val_34 = alignment;
            val_31 = this.mAlignment_LTR;
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  (I2.Loc.LocalizationManager.IsRight2Left == true) ? 1 : 0, alignment:  val_34, alignLTR: out  val_31, alignRTL: out  this.mAlignment_RTL);
            goto label_41;
            label_35:
            I2.Loc.LocalizeTarget_TextMeshPro_Label.InitAlignment_TMPro(isRTL:  (this.mAlignmentWasRTL == true) ? 1 : 0, alignment:  val_5.alignment, alignLTR: out  val_24, alignRTL: out  val_24);
            if(this.mAlignmentWasRTL == false)
            {
                goto label_45;
            }
            
            val_35 = val_30;
            val_36 = 0;
            if(this.mAlignment_RTL == val_36)
            {
                goto label_48;
            }
            
            val_37 = 0;
            val_38 = this.mAlignment_LTR;
            goto label_47;
            label_45:
            val_38 = val_30;
            val_37 = 0;
            if(this.mAlignment_LTR == val_37)
            {
                goto label_48;
            }
            
            val_36 = 0;
            val_35 = this.mAlignment_RTL;
            label_47:
            this.mAlignment_LTR = val_37;
            mem2[0] = val_36;
            label_48:
            val_34 = 1152921504974790656;
            val_39 = null;
            val_39 = null;
            this.mAlignmentWasRTL = I2.Loc.LocalizationManager.IsRight2Left;
            label_41:
            if(val_1 == 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  text, b:  val_1)) == false)
            {
                    return;
            }
            
            if((val_1 != 0) && (cmp.CorrectAlignmentForRTL != false))
            {
                    val_40 = null;
                val_40 = null;
                cmp.alignment = (I2.Loc.LocalizationManager.IsRight2Left == false) ? this.mAlignment_LTR : this.mAlignment_RTL;
                val_41 = null;
                val_41 = null;
                val_34 = I2.Loc.LocalizationManager.IsRight2Left;
                cmp.isRightToLeftText = (val_34 == true) ? 1 : 0;
            }
            
            this.text = I2.Loc.I2Utils.ReverseText(source:  val_1);
        }
        public LocalizeTarget_TextMeshPro_UGUI()
        {
            this.mAlignment_RTL = 516;
            this.mInitializeAlignment = true;
        }
    
    }

}
