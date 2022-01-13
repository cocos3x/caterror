using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<UnityEngine.GameObject>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_Child()
        {
            I2.Loc.LocalizeTarget_UnityStandard_Child.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Child val_1 = new I2.Loc.LocalizeTargetDesc_Child();
            if(val_1 != null)
            {
                    mem[1152921512297889824] = "Child";
            }
            else
            {
                    mem[16] = "Child";
            }
            
            mem[1152921512297889832] = 200;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            return (bool)(cmp.transform.childCount > 1) ? 1 : 0;
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 4;
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
            primaryTerm = cmp.name;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_11;
            string val_12;
            var val_13;
            var val_14;
            val_12 = mainTranslation;
            if((System.String.IsNullOrEmpty(value:  val_12)) == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = cmp.transform;
            val_13 = null;
            val_13 = null;
            System.Char[] val_11 = I2.Loc.LanguageSourceData.CategorySeparators;
            int val_3 = val_12.LastIndexOfAny(anyOf:  val_11);
            if((val_3 & 2147483648) == 0)
            {
                    val_11 = val_3 + 1;
                val_12 = val_12.Substring(startIndex:  val_11);
            }
            
            val_11 = 0;
            goto label_8;
            label_14:
            UnityEngine.Transform val_5 = val_2.GetChild(index:  0);
            if(val_5 != null)
            {
                    val_14 = val_5.gameObject;
            }
            else
            {
                    val_14 = 0.gameObject;
            }
            
            string val_12 = val_12;
            val_12 = System.String.op_Equality(a:  val_5.name, b:  val_12);
            val_14.SetActive(value:  val_12);
            val_11 = 1;
            label_8:
            if(val_11 < val_2.childCount)
            {
                goto label_14;
            }
        
        }
        public LocalizeTarget_UnityStandard_Child()
        {
        
        }
    
    }

}
