using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TMPro.TextMeshPro>
    {
        // Fields
        private TMPro.TextAlignmentOptions mAlignment_RTL;
        private TMPro.TextAlignmentOptions mAlignment_LTR;
        private bool mAlignmentWasRTL;
        private bool mInitializeAlignment;
        
        // Methods
        private static LocalizeTarget_TextMeshPro_Label()
        {
            I2.Loc.LocalizeTarget_TextMeshPro_Label.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshPro, I2.Loc.LocalizeTarget_TextMeshPro_Label> val_1 = new I2.Loc.LocalizeTargetDesc_Type<TMPro.TextMeshPro, I2.Loc.LocalizeTarget_TextMeshPro_Label>();
            if(val_1 != null)
            {
                    mem[1152921512293069792] = "TextMeshPro Label";
            }
            else
            {
                    mem[16] = "TextMeshPro Label";
            }
            
            mem[1152921512293069800] = 100;
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
        internal static TMPro.TMP_FontAsset GetTMPFontFromMaterial(I2.Loc.Localize cmp, string matName)
        {
            int val_11;
            UnityEngine.Object val_12;
            val_11 = matName.Length - 1;
            if(val_11 < 1)
            {
                goto label_13;
            }
            
            label_18:
            if(((IndexOf(value:  matName.Chars[val_11])) & 2147483648) != 0)
            {
                goto label_5;
            }
            
            val_11 = val_11 - 1;
            if(val_11 >= 2)
            {
                goto label_18;
            }
            
            goto label_13;
            label_5:
            val_12 = cmp.GetObject<TMPro.TMP_FontAsset>(Translation:  matName.Substring(startIndex:  0, length:  val_11 + 1));
            if(val_12 != 0)
            {
                    return (TMPro.TMP_FontAsset)val_12;
            }
            
            if(val_11 < 1)
            {
                goto label_13;
            }
            
            label_17:
            if(((IndexOf(value:  matName.Chars[val_11])) & 2147483648) == 0)
            {
                goto label_16;
            }
            
            val_11 = val_11 - 1;
            if(val_11 > 1)
            {
                goto label_17;
            }
            
            label_16:
            if(val_11 >= 1)
            {
                goto label_18;
            }
            
            label_13:
            val_12 = 0;
            return (TMPro.TMP_FontAsset)val_12;
        }
        internal static void InitAlignment_TMPro(bool isRTL, TMPro.TextAlignmentOptions alignment, out TMPro.TextAlignmentOptions alignLTR, out TMPro.TextAlignmentOptions alignRTL)
        {
            var val_1;
            alignRTL = alignment;
            alignLTR = alignment;
            if(isRTL == false)
            {
                goto label_0;
            }
            
            if(alignment <= 1028)
            {
                goto label_1;
            }
            
            if(alignment <= 4097)
            {
                goto label_2;
            }
            
            if(alignment == 4100)
            {
                goto label_3;
            }
            
            if(alignment == 8193)
            {
                goto label_4;
            }
            
            if(alignment != 8196)
            {
                    return;
            }
            
            alignLTR = 8193;
            return;
            label_0:
            if(alignment <= 1028)
            {
                goto label_6;
            }
            
            if(alignment <= 4097)
            {
                goto label_7;
            }
            
            if(alignment == 4100)
            {
                goto label_8;
            }
            
            if(alignment == 8193)
            {
                goto label_9;
            }
            
            if(alignment != 8196)
            {
                    return;
            }
            
            val_1 = 8193;
            goto label_41;
            label_1:
            if(alignment <= 513)
            {
                goto label_12;
            }
            
            if(alignment == 516)
            {
                goto label_13;
            }
            
            if(alignment == 1025)
            {
                goto label_14;
            }
            
            if(alignment != 1028)
            {
                    return;
            }
            
            alignLTR = 1025;
            return;
            label_6:
            if(alignment <= 513)
            {
                goto label_16;
            }
            
            if(alignment == 516)
            {
                goto label_17;
            }
            
            if(alignment == 1025)
            {
                goto label_18;
            }
            
            if(alignment != 1028)
            {
                    return;
            }
            
            val_1 = 1025;
            goto label_41;
            label_2:
            if(alignment == 2049)
            {
                goto label_21;
            }
            
            if(alignment == 2052)
            {
                goto label_22;
            }
            
            if(alignment != 4097)
            {
                    return;
            }
            
            alignLTR = 4100;
            return;
            label_7:
            if(alignment == 2049)
            {
                goto label_24;
            }
            
            if(alignment == 2052)
            {
                goto label_25;
            }
            
            if(alignment != 4097)
            {
                    return;
            }
            
            val_1 = 4100;
            goto label_41;
            label_12:
            if(alignment == 257)
            {
                goto label_28;
            }
            
            if(alignment == 260)
            {
                goto label_29;
            }
            
            if(alignment != 513)
            {
                    return;
            }
            
            alignLTR = 516;
            return;
            label_16:
            if(alignment == 257)
            {
                goto label_31;
            }
            
            if(alignment == 260)
            {
                goto label_32;
            }
            
            if(alignment != 513)
            {
                    return;
            }
            
            val_1 = 516;
            goto label_41;
            label_3:
            alignLTR = 4097;
            return;
            label_4:
            alignLTR = 8196;
            return;
            label_8:
            val_1 = 4097;
            goto label_41;
            label_9:
            val_1 = 8196;
            goto label_41;
            label_13:
            alignLTR = 513;
            return;
            label_14:
            alignLTR = 1028;
            return;
            label_17:
            val_1 = 513;
            goto label_41;
            label_18:
            val_1 = 1028;
            goto label_41;
            label_21:
            alignLTR = 2052;
            return;
            label_22:
            alignLTR = 2049;
            return;
            label_24:
            val_1 = 2052;
            goto label_41;
            label_25:
            val_1 = 2049;
            goto label_41;
            label_28:
            alignLTR = 260;
            return;
            label_29:
            alignLTR = 257;
            return;
            label_31:
            val_1 = 260;
            goto label_41;
            label_32:
            val_1 = 257;
            label_41:
            alignRTL = 257;
        }
        internal static void SetFont(TMPro.TMP_Text label, TMPro.TMP_FontAsset newFont)
        {
            TMPro.TMP_Text val_6 = label;
            goto label_3;
            label_13:
            val_6 = val_6.linkedTextComponent;
            label_3:
            if(val_6.font != newFont)
            {
                    val_6.font = newFont;
            }
            
            if(val_6.linkedTextComponent != 0)
            {
                goto label_13;
            }
        
        }
        internal static void SetMaterial(TMPro.TMP_Text label, UnityEngine.Material newMat)
        {
            TMPro.TMP_Text val_5 = label;
            goto label_2;
            label_10:
            val_5 = val_5.linkedTextComponent;
            label_2:
            bool val_2 = UnityEngine.Object.op_Inequality(x:  val_5, y:  newMat);
            if(val_5.linkedTextComponent != 0)
            {
                goto label_10;
            }
        
        }
        public LocalizeTarget_TextMeshPro_Label()
        {
            this.mAlignment_RTL = 516;
            this.mInitializeAlignment = true;
        }
    
    }

}
