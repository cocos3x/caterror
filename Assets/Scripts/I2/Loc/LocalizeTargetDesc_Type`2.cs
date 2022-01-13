using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G>
    {
        // Methods
        public override bool CanLocalize(I2.Loc.Localize cmp)
        {
            return UnityEngine.Object.op_Inequality(x:  cmp, y:  0);
        }
        public override I2.Loc.ILocalizeTarget CreateTarget(I2.Loc.Localize cmp)
        {
            if(cmp == 0)
            {
                    return (I2.Loc.ILocalizeTarget)0;
            }
            
            0 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            mem2[0] = cmp;
            return (I2.Loc.ILocalizeTarget)0;
        }
        public LocalizeTargetDesc_Type<T, G>()
        {
            if(this == null)
            {
                
            }
        
        }
    
    }

}
