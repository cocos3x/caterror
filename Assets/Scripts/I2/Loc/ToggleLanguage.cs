using UnityEngine;

namespace I2.Loc
{
    public class ToggleLanguage : MonoBehaviour
    {
        // Methods
        private void Start()
        {
            this.Invoke(methodName:  "test", time:  3f);
        }
        private void test()
        {
            System.Collections.Generic.List<System.String> val_1 = I2.Loc.LocalizationManager.GetAllLanguages(SkipDisabled:  true);
            if(((val_1.IndexOf(item:  I2.Loc.LocalizationManager.CurrentLanguage)) & 2147483648) == 0)
            {
                    int val_4 = val_1.Count;
            }
            
            this.Invoke(methodName:  "test", time:  3f);
        }
        public ToggleLanguage()
        {
        
        }
    
    }

}
