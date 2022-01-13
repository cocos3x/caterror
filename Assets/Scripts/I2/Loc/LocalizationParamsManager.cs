using UnityEngine;

namespace I2.Loc
{
    public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
    {
        // Fields
        public System.Collections.Generic.List<I2.Loc.LocalizationParamsManager.ParamValue> _Params;
        public bool _IsGlobalManager;
        
        // Methods
        public string GetParameterValue(string ParamName)
        {
            var val_5;
            string val_6;
            System.Collections.Generic.List<ParamValue> val_7;
            val_6 = ParamName;
            val_7 = this._Params;
            if(val_7 == null)
            {
                    return (string)val_7;
            }
            
            int val_1 = val_7.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_5 = 0;
            label_5:
            ParamValue val_2 = this._Params.Item[0];
            if((System.String.op_Equality(a:  val_2.Name, b:  val_6)) == true)
            {
                goto label_4;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_5;
            }
            
            label_2:
            val_7 = 0;
            return (string)val_7;
            label_4:
            val_6 = this._Params;
            ParamValue val_4 = val_6.Item[0];
            val_7 = val_4.Value;
            return (string)val_7;
        }
        public void SetParameterValue(string ParamName, string ParamValue, bool localize = True)
        {
            System.Collections.Generic.List<ParamValue> val_5;
            System.Collections.Generic.List<ParamValue> val_6;
            val_5 = this._Params;
            int val_1 = val_5.Count;
            val_6 = this._Params;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_5 = 0;
            label_5:
            ParamValue val_2 = val_6.Item[0];
            if((System.String.op_Equality(a:  val_2.Name, b:  ParamName)) == true)
            {
                goto label_4;
            }
            
            val_6 = this._Params;
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_5;
            }
            
            label_2:
            val_6.Add(item:  new ParamValue() {Name = ParamName, Value = ParamValue});
            if(localize == false)
            {
                    return;
            }
            
            label_10:
            this.OnLocalize();
            return;
            label_4:
            ParamValue val_4 = this._Params.Item[0];
            this._Params.set_Item(index:  0, value:  new ParamValue() {Name = val_4.Name, Value = ParamValue});
            if(localize == true)
            {
                goto label_10;
            }
        
        }
        public void OnLocalize()
        {
            I2.Loc.Localize val_1 = this.GetComponent<I2.Loc.Localize>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.OnLocalize(Force:  true);
        }
        public virtual void OnEnable()
        {
            if(this._IsGlobalManager == false)
            {
                    return;
            }
            
            this.DoAutoRegister();
        }
        public void DoAutoRegister()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((I2.Loc.LocalizationManager.ParamManagers.Contains(item:  this)) != false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            I2.Loc.LocalizationManager.ParamManagers.Add(item:  this);
            I2.Loc.LocalizationManager.LocalizeAll(Force:  true);
        }
        public void OnDisable()
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.ParamManagers.Remove(item:  this);
        }
        public LocalizationParamsManager()
        {
            this._Params = new System.Collections.Generic.List<ParamValue>();
        }
    
    }

}
