using UnityEngine;

namespace I2.Loc
{
    public class BaseSpecializationManager
    {
        // Fields
        public string[] mSpecializations;
        public System.Collections.Generic.Dictionary<string, string> mSpecializationsFallbacks;
        
        // Methods
        public virtual void InitializeSpecializations()
        {
            string[] val_1 = new string[12];
            val_1[0] = "Any";
            val_1[1] = "PC";
            val_1[2] = "Touch";
            val_1[3] = "Controller";
            val_1[4] = "VR";
            val_1[5] = "XBox";
            val_1[6] = "PS4";
            val_1[7] = "OculusVR";
            val_1[8] = "ViveVR";
            val_1[9] = "GearVR";
            val_1[10] = "Android";
            val_1[11] = "IOS";
            mem[1152921512233029232] = val_1;
            System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_2 != null)
            {
                    val_2.Add(key:  "XBox", value:  "Controller");
            }
            else
            {
                    val_2.Add(key:  "XBox", value:  "Controller");
            }
            
            val_2.Add(key:  "PS4", value:  "Controller");
            if(val_2 != null)
            {
                    val_2.Add(key:  "OculusVR", value:  "VR");
            }
            else
            {
                    val_2.Add(key:  "OculusVR", value:  "VR");
            }
            
            val_2.Add(key:  "ViveVR", value:  "VR");
            if(val_2 != null)
            {
                    val_2.Add(key:  "GearVR", value:  "VR");
            }
            else
            {
                    val_2.Add(key:  "GearVR", value:  "VR");
            }
            
            val_2.Add(key:  "Android", value:  "Touch");
            val_2.Add(key:  "IOS", value:  "Touch");
            mem[1152921512233029240] = val_2;
        }
        public virtual string GetCurrentSpecialization()
        {
            if(this.mSpecializations != null)
            {
                    return "Android";
            }
            
            return "Android";
        }
        public virtual string GetFallbackSpecialization(string specialization)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_4 = this.mSpecializationsFallbacks;
            if(val_4 != null)
            {
                    return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -963445064 : "Any";
            }
            
            val_4 = this.mSpecializationsFallbacks;
            if(val_4 != null)
            {
                    return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -963445064 : "Any";
            }
            
            val_4 = 0;
            return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -963445064 : "Any";
        }
        public BaseSpecializationManager()
        {
        
        }
    
    }

}
