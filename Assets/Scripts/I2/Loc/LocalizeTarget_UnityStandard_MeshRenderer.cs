using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<UnityEngine.MeshRenderer>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_MeshRenderer()
        {
            I2.Loc.LocalizeTarget_UnityStandard_MeshRenderer.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.MeshRenderer, I2.Loc.LocalizeTarget_UnityStandard_MeshRenderer> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.MeshRenderer, I2.Loc.LocalizeTarget_UnityStandard_MeshRenderer>();
            if(val_1 != null)
            {
                    mem[1152921512301853056] = "MeshRenderer";
            }
            else
            {
                    mem[16] = "MeshRenderer";
            }
            
            mem[1152921512301853064] = 800;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 8;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 6;
        }
        public override bool CanUseSecondaryTerm()
        {
            return true;
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
            var val_13;
            UnityEngine.Object val_14;
            var val_15;
            if(37224448 == 0)
            {
                    val_13 = 0;
                secondaryTerm = 0;
            }
            else
            {
                    UnityEngine.MeshFilter val_2 = GetComponent<UnityEngine.MeshFilter>();
                val_13 = 0;
                if(val_2 != 0)
            {
                    val_13 = 0;
            }
            
            }
            
            primaryTerm = val_2.sharedMesh.name;
            val_15 = 0;
            if(primaryTerm != 0)
            {
                    val_14 = primaryTerm.sharedMaterial;
                val_15 = 0;
            }
            
            secondaryTerm = this.sharedMaterial.name;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            string val_12;
            string val_1 = mainTranslation;
            UnityEngine.Material val_3 = cmp.GetSecondaryTranslatedObj<UnityEngine.Material>(mainTranslation: ref  val_1, secondaryTranslation: ref  secondaryTranslation);
            if(val_3 != 0)
            {
                    UnityEngine.Material val_5 = X22.sharedMaterial;
                if(val_5 != val_3)
            {
                    val_5.material = val_3;
            }
            
            }
            
            val_12 = val_1;
            UnityEngine.Mesh val_7 = cmp.FindTranslatedObject<UnityEngine.Mesh>(value:  val_12);
            UnityEngine.MeshFilter val_8 = cmp.GetComponent<UnityEngine.MeshFilter>();
            if(val_7 == 0)
            {
                    return;
            }
            
            val_12 = val_8.sharedMesh;
            if(val_12 == val_7)
            {
                    return;
            }
            
            val_8.mesh = val_7;
        }
        public LocalizeTarget_UnityStandard_MeshRenderer()
        {
        
        }
    
    }

}
