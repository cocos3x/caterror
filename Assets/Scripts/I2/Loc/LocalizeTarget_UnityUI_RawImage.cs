using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<UnityEngine.UI.RawImage>
    {
        // Methods
        private static LocalizeTarget_UnityUI_RawImage()
        {
            I2.Loc.LocalizeTarget_UnityUI_RawImage.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.RawImage, I2.Loc.LocalizeTarget_UnityUI_RawImage> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.UI.RawImage, I2.Loc.LocalizeTarget_UnityUI_RawImage>();
            if(val_1 != null)
            {
                    mem[1152921512308830336] = "RawImage";
            }
            else
            {
                    mem[16] = "RawImage";
            }
            
            mem[1152921512308830344] = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 2;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
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
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            var val_3;
            string val_4;
            val_3 = this;
            if((UnityEngine.Object.op_Implicit(exists:  37224448)) != false)
            {
                    val_3 = val_3;
                string val_2 = this.name;
            }
            else
            {
                    val_4 = "";
            }
            
            primaryTerm = val_4;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            UnityEngine.Texture val_1 = texture;
            if(val_1 != 0)
            {
                    if((System.String.op_Inequality(a:  val_1.name, b:  mainTranslation)) == false)
            {
                    return;
            }
            
            }
            
            this.texture = cmp.FindTranslatedObject<UnityEngine.Texture>(value:  mainTranslation);
        }
        public LocalizeTarget_UnityUI_RawImage()
        {
        
        }
    
    }

}
