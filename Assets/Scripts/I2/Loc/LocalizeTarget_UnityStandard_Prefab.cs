using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<UnityEngine.GameObject>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_Prefab()
        {
            I2.Loc.LocalizeTarget_UnityStandard_Prefab.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Prefab val_1 = new I2.Loc.LocalizeTargetDesc_Prefab();
            if(val_1 != null)
            {
                    mem[1152921512303396624] = "Prefab";
            }
            else
            {
                    mem[16] = "Prefab";
            }
            
            mem[1152921512303396632] = 250;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            return true;
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
            var val_14;
            I2.Loc.Localize val_15;
            var val_16;
            string val_17;
            val_15 = cmp;
            if((System.String.IsNullOrEmpty(value:  mainTranslation)) == true)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  37224448)) != false)
            {
                    if((System.String.op_Equality(a:  name, b:  mainTranslation)) == true)
            {
                    return;
            }
            
            }
            
            val_14 = val_15.transform;
            val_16 = null;
            val_16 = null;
            System.Char[] val_14 = I2.Loc.LanguageSourceData.CategorySeparators;
            int val_6 = mainTranslation.LastIndexOfAny(anyOf:  val_14);
            val_17 = mainTranslation;
            if((val_6 & 2147483648) == 0)
            {
                    val_14 = val_6 + 1;
                val_17 = mainTranslation.Substring(startIndex:  val_14);
            }
            
            UnityEngine.Transform val_8 = this.InstantiateNewPrefab(cmp:  val_15, mainTranslation:  mainTranslation);
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8.name = val_17;
            val_15 = val_14.childCount - 1;
            if((val_15 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_11 = val_14.GetChild(index:  val_15);
                if(val_11 != val_8)
            {
                    UnityEngine.Object.Destroy(obj:  val_11.gameObject);
            }
            
                val_15 = val_15 - 1;
            }
            while((val_15 & 2147483648) == 0);
        
        }
        private UnityEngine.Transform InstantiateNewPrefab(I2.Loc.Localize cmp, string mainTranslation)
        {
            UnityEngine.Transform val_11;
            var val_12;
            val_11 = this;
            UnityEngine.GameObject val_1 = cmp.FindTranslatedObject<UnityEngine.GameObject>(value:  mainTranslation);
            val_12 = 0;
            if(val_1 == 0)
            {
                    return (UnityEngine.Transform)val_12;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1);
            mem[1152921512304553688] = val_3;
            val_12 = 0;
            if(val_3 == 0)
            {
                    return (UnityEngine.Transform)val_12;
            }
            
            val_11 = cmp.transform;
            val_12 = val_12.transform;
            val_12.SetParent(p:  val_11);
            if((UnityEngine.Object.op_Implicit(exists:  37224448)) != false)
            {
                    val_11 = transform;
            }
            
            UnityEngine.Quaternion val_9 = val_11.rotation;
            val_12.rotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            UnityEngine.Vector3 val_10 = val_11.position;
            val_12.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            return (UnityEngine.Transform)val_12;
        }
        public LocalizeTarget_UnityStandard_Prefab()
        {
        
        }
    
    }

}
