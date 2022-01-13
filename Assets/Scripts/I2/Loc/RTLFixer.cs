using UnityEngine;

namespace I2.Loc
{
    public class RTLFixer
    {
        // Methods
        public static string Fix(string str)
        {
            return I2.Loc.RTLFixer.Fix(str:  str, showTashkeel:  false, useHinduNumbers:  true);
        }
        public static string Fix(string str, bool rtl)
        {
            string val_14;
            var val_15;
            string val_16;
            var val_17;
            if(rtl != false)
            {
                    return I2.Loc.RTLFixer.Fix(str:  str, showTashkeel:  false, useHinduNumbers:  true);
            }
            
            char[] val_1 = new char[1];
            val_1[0] = 32;
            val_14 = "";
            val_15 = 0;
            val_16 = val_14;
            goto label_6;
            label_16:
            string val_14 = str.Split(separator:  val_1)[0];
            if(val_14 != null)
            {
                    val_17 = val_14.ToLower();
            }
            else
            {
                    val_17 = 0.ToLower();
            }
            
            int val_5 = val_14.Length;
            str.Split(separator:  val_1)[0] = (val_5 < 0) ? (val_5 + 1) : (val_5);
            if((System.Char.IsLower(c:  val_17.Chars[(str.Split(separator:  val_1)[0]) >> 1])) != false)
            {
                    val_14 = "";
                val_16 = val_16 + I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true)(I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true)) + val_14 + " ";
            }
            else
            {
                    val_14 = val_14 + val_14 + " ";
            }
            
            val_15 = 1;
            label_6:
            if(val_15 < val_2.Length)
            {
                goto label_16;
            }
            
            if((System.String.op_Inequality(a:  val_14, b:  "")) == false)
            {
                    return val_16;
            }
            
            return val_16 + I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true)(I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true));
        }
        public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
        {
            string val_17;
            var val_18;
            string val_19;
            val_17 = str;
            string val_1 = I2.Loc.HindiFixer.Fix(text:  val_17);
            if((System.String.op_Inequality(a:  val_1, b:  val_17)) != false)
            {
                    return val_1;
            }
            
            val_18 = null;
            val_18 = null;
            I2.Loc.RTLFixerTool.showTashkeel = showTashkeel;
            I2.Loc.RTLFixerTool.useHinduNumbers = useHinduNumbers;
            val_19 = "\n";
            if((val_17.Contains(value:  "\n")) != false)
            {
                    val_17 = val_17.Replace(oldValue:  "\n", newValue:  System.Environment.NewLine);
            }
            
            if((val_17.Contains(value:  System.Environment.NewLine)) == false)
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  val_17);
            }
            
            string[] val_10 = new string[1];
            val_19 = System.Environment.NewLine;
            val_10[0] = val_19;
            System.String[] val_12 = val_17.Split(separator:  val_10, options:  0);
            if(val_12.Length == 0)
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  val_17);
            }
            
            if(val_12.Length == 0)
            {
                goto label_16;
            }
            
            if(val_12.Length != 1)
            {
                goto label_17;
            }
            
            return I2.Loc.RTLFixerTool.FixLine(str:  val_17);
            label_16:
            label_17:
            if(val_12.Length < 2)
            {
                    return val_1;
            }
            
            do
            {
                string val_16 = I2.Loc.RTLFixerTool.FixLine(str:  val_12[0])(I2.Loc.RTLFixerTool.FixLine(str:  val_12[0])) + System.Environment.NewLine + I2.Loc.RTLFixerTool.FixLine(str:  val_12[1])(I2.Loc.RTLFixerTool.FixLine(str:  val_12[1]));
            }
            while((1 + 1) < val_12.Length);
            
            return val_1;
        }
        public RTLFixer()
        {
        
        }
    
    }

}
