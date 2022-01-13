using UnityEngine;

namespace I2.Loc
{
    public class GlobalParametersExample : RegisterGlobalParameters
    {
        // Methods
        public override string GetParameterValue(string ParamName)
        {
            var val_4;
            if((System.String.op_Equality(a:  ParamName, b:  "WINNER")) != false)
            {
                    val_4 = "Javier";
                return (string)5.ToString();
            }
            
            val_4 = 0;
            if((System.String.op_Equality(a:  ParamName, b:  "NUM PLAYERS")) == false)
            {
                    return (string)5.ToString();
            }
            
            return (string)5.ToString();
        }
        public GlobalParametersExample()
        {
        
        }
    
    }

}
