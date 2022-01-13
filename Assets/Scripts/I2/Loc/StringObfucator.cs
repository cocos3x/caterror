using UnityEngine;

namespace I2.Loc
{
    public class StringObfucator
    {
        // Fields
        public static char[] StringObfuscatorPassword;
        
        // Methods
        public static string Encode(string NormalString)
        {
            return (string)I2.Loc.StringObfucator.ToBase64(regularString:  I2.Loc.StringObfucator.XoREncode(NormalString:  NormalString));
        }
        public static string Decode(string ObfucatedString)
        {
            return (string)I2.Loc.StringObfucator.XoREncode(NormalString:  I2.Loc.StringObfucator.FromBase64(base64string:  ObfucatedString));
        }
        private static string ToBase64(string regularString)
        {
            return System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8);
        }
        private static string FromBase64(string base64string)
        {
            if((System.Convert.FromBase64String(s:  base64string)) == null)
            {
                goto label_3;
            }
            
            label_6:
            System.Text.Encoding.UTF8 = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_358;
            label_3:
            if(System.Text.Encoding.UTF8 != 0)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        private static string XoREncode(string NormalString)
        {
            var val_9;
            System.Char[] val_10;
            int val_11;
            var val_12;
            val_9 = null;
            val_9 = null;
            val_10 = NormalString.ToCharArray();
            if(val_1.Length < 1)
            {
                    return (string)val_12;
            }
            
            val_11 = val_1.Length & 4294967295;
            var val_9 = 0;
            goto label_7;
            label_11:
            val_11 = val_1.Length;
            label_7:
            int val_3 = val_9 - ((val_9 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length) * I2.Loc.StringObfucator.StringObfuscatorPassword.Length);
            System.Char[] val_4 = I2.Loc.StringObfucator.StringObfuscatorPassword + (((long)(int)(0 - ((0 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length) * I2.Loc.StringObfucator.StringObfuscatorPassword.Length))) << 1);
            System.Char[] val_6 = ((I2.Loc.StringObfucator.StringObfuscatorPassword + ((long)(int)(0 - ((0 / I2.Loc.StringObfucator.StringObfuscatorPassword.Length) * I2.Loc.StringObfucator.StringObfuscatorPassword.Length))) << 1) + 32) ^ 1152921504990337264;
            var val_7 = (((val_9 & 1) != 0) ? 23 : 50) * val_9;
            val_6 = val_6 & 65535;
            val_7 = val_7 & 255;
            val_6 = val_7 ^ val_6;
            mem2[0] = val_6;
            val_9 = val_9 + 1;
            if(val_9 < (long)val_11)
            {
                goto label_11;
            }
            
            return (string)val_12;
        }
        public StringObfucator()
        {
        
        }
        private static StringObfucator()
        {
            I2.Loc.StringObfucator.StringObfuscatorPassword = ToCharArray();
        }
    
    }

}
