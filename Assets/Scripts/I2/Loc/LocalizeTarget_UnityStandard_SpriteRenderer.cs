using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<UnityEngine.SpriteRenderer>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_SpriteRenderer()
        {
            I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.SpriteRenderer, I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.SpriteRenderer, I2.Loc.LocalizeTarget_UnityStandard_SpriteRenderer>();
            if(val_1 != null)
            {
                    mem[1152921512304955568] = "SpriteRenderer";
            }
            else
            {
                    mem[16] = "SpriteRenderer";
            }
            
            mem[1152921512304955576] = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 5;
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
            if(sprite != 0)
            {
                    val_5 = this.sprite;
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
        public LocalizeTarget_UnityStandard_SpriteRenderer()
        {
        
        }
    
    }

}
