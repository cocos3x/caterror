using UnityEngine;

namespace I2.Loc
{
    public abstract class LocalizeTarget<T> : ILocalizeTarget
    {
        // Fields
        public T mTarget;
        
        // Methods
        public override bool IsValid(I2.Loc.Localize cmp)
        {
            I2.Loc.Localize val_7;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  37244928, y:  0);
            if((val_1 != false) && (val_1 != 0))
            {
                    UnityEngine.GameObject val_3 = val_1.gameObject;
                if(val_3 != cmp.gameObject)
            {
                    mem[1152921512291875704] = 0;
            }
            
            }
            
            if(val_3 == 0)
            {
                    val_7 = cmp;
                mem[1152921512291875704] = val_7;
                return UnityEngine.Object.op_Inequality(x:  cmp, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  cmp, y:  0);
        }
        protected LocalizeTarget<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
