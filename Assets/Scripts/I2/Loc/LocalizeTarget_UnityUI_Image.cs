using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_Image : LocalizeTarget<UnityEngine.UI.Image>
    {
        // Methods
        private static LocalizeTarget_UnityUI_Image()
        {
            I2.Loc.LocalizeTarget_UnityUI_Image.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Image, I2.Loc.LocalizeTarget_UnityUI_Image> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.Image, I2.Loc.LocalizeTarget_UnityUI_Image>();
            if(val_1 != null)
            {
                    mem[1152921512307528160] = "Image";
            }
            else
            {
                    mem[16] = "Image";
            }
            
            mem[1152921512307528168] = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override bool CanUseSecondaryTerm()
        {
            return false;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return false;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return (I2.Loc.eTermType)(this.sprite != 0) ? 2 : 5;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            string val_11;
            string val_12;
            val_11 = this;
            if((UnityEngine.Object.op_Implicit(exists:  37224448)) != false)
            {
                    string val_2 = name;
            }
            else
            {
                    val_12 = "";
            }
            
            primaryTerm = val_12;
            UnityEngine.Sprite val_3 = sprite;
            if(val_3 != 0)
            {
                    UnityEngine.Sprite val_5 = val_3.sprite;
                if((System.String.op_Inequality(a:  val_5.name, b:  primaryTerm)) != false)
            {
                    val_11 = primaryTerm;
                primaryTerm = val_11 + "." + val_5.sprite.name;
            }
            
            }
            
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            UnityEngine.Sprite val_1 = sprite;
            if(val_1 != 0)
            {
                    if((System.String.op_Inequality(a:  val_1.name, b:  mainTranslation)) == false)
            {
                    return;
            }
            
            }
            
            this.sprite = cmp.FindTranslatedObject<UnityEngine.Sprite>(value:  mainTranslation);
        }
        public LocalizeTarget_UnityUI_Image()
        {
        
        }
    
    }

}
