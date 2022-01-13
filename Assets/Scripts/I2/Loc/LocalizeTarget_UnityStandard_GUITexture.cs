using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_GUITexture : LocalizeTarget<UnityEngine.GUITexture>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_GUITexture()
        {
            I2.Loc.LocalizeTarget_UnityStandard_GUITexture.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.GUITexture, I2.Loc.LocalizeTarget_UnityStandard_GUITexture> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.GUITexture, I2.Loc.LocalizeTarget_UnityStandard_GUITexture>();
            if(val_1 != null)
            {
                    mem[1152921512300590816] = "GUITexture";
            }
            else
            {
                    mem[16] = "GUITexture";
            }
            
            mem[1152921512300590824] = 100;
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
            var val_5;
            int val_6;
            val_5 = this;
            if((UnityEngine.Object.op_Implicit(exists:  texture)) != false)
            {
                    val_5 = this.texture;
                string val_4 = val_5.name;
            }
            else
            {
                    val_6 = System.String.alignConst;
            }
            
            primaryTerm = val_6;
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
        public LocalizeTarget_UnityStandard_GUITexture()
        {
        
        }
    
    }

}
