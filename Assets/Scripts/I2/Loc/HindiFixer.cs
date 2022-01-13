using UnityEngine;

namespace I2.Loc
{
    public class HindiFixer
    {
        // Methods
        internal static string Fix(string text)
        {
            string val_9;
            var val_10;
            var val_11;
            var val_12;
            char val_13;
            int val_14;
            var val_15;
            val_9 = text;
            System.Char[] val_1 = val_9.ToCharArray();
            val_10 = 1152921504616697856;
            val_11 = 0;
            val_12 = 0;
            goto label_2;
            label_64:
            val_13 = (long)(long)(int)(W25);
            if((val_1[((long)(int)(W25)) << 1]) == 'ि')
            {
                    val_13 = val_1[0];
                if((System.Char.IsWhiteSpace(c:  val_13)) != true)
            {
                    val_13 = mem[val_1[0x0] + 32];
                val_13 = val_1[0x0] + 32;
                if(val_13 != 0)
            {
                    val_14 = val_1.Length;
                if(val_12 >= val_14)
            {
                    val_13 = mem[val_1[0x0] + 32];
                val_13 = val_1[0x0] + 32;
                val_14 = val_1.Length;
            }
            
                mem2[0] = val_13;
                val_11 = 1;
                mem2[0] = 2367;
            }
            
            }
            
            }
            
            if(W25 != (val_1.Length - 1))
            {
                    if((val_1[((long)(int)(W25)) << 1] + 32) == 2311)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2316;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
                if((val_1[((long)(int)(W25)) << 1] + 32) == 2371)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2372;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
                if((val_1[((long)(int)(W25)) << 1] + 32) == 2305)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2384;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
                if((val_1[((long)(int)(W25)) << 1] + 32) == 2315)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2400;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
                if((val_1[((long)(int)(W25)) << 1] + 32) == 2312)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2401;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
                if((val_1[((long)(int)(W25)) << 1] + 32) == 2367)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2402;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
                if((val_1[((long)(int)(W25)) << 1] + 32) == 2368)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2403;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
                if((val_1[((long)(int)(W25)) << 1] + 32) == 2404)
            {
                    if(val_1[4] == '़')
            {
                    mem2[0] = 2365;
                val_11 = 1;
                mem2[0] = 0;
            }
            
            }
            
            }
            
            val_12 = 1;
            label_2:
            if((val_12 + 1) < val_1.Length)
            {
                goto label_64;
            }
            
            if((val_11 & 1) == 0)
            {
                    return (string)val_9;
            }
            
            val_10 = 1152921504976867328;
            val_15 = null;
            val_15 = null;
            val_13 = HindiFixer.<>c.<>9__0_0;
            if(val_13 == null)
            {
                    System.Func<System.Char, System.Boolean> val_5 = null;
                val_13 = val_5;
                val_5 = new System.Func<System.Char, System.Boolean>(object:  HindiFixer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HindiFixer.<>c::<Fix>b__0_0(char x));
                HindiFixer.<>c.<>9__0_0 = val_13;
            }
            
            string val_8 = 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_1, predicate:  val_5)));
            bool val_9 = System.String.op_Equality(a:  val_8, b:  val_9);
            val_9 = val_8;
            return (string)val_9;
        }
        public HindiFixer()
        {
        
        }
    
    }

}
