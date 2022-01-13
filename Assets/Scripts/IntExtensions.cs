using UnityEngine;
public static class IntExtensions
{
    // Methods
    public static int RandomPlusMinus()
    {
        int val_1 = UnityEngine.Random.Range(min:  0, max:  2);
        val_1 = (val_1 << 1) - 1;
        return (int)val_1;
    }
    public static int RandomChooseRatio(int[] ratioArray)
    {
        return IntExtensions.RandomChooseRatio(rand:  new System.Random(), ratioArray:  ratioArray);
    }
    public static int RandomChooseRatio(System.Random rand, int[] ratioArray)
    {
        var val_3;
        var val_4;
        int val_5;
        int val_2 = (System.Linq.Enumerable.Sum(source:  ratioArray)) + 1;
        val_3 = rand;
        val_4 = 0;
        goto label_1;
        label_6:
        val_5 = ratioArray[0];
        if(val_3 <= val_5)
        {
                return 0;
        }
        
        if(val_4 >= ratioArray.Length)
        {
                val_5 = mem[ratioArray[0x0] + 32];
            val_5 = ratioArray[0x0] + 32;
        }
        
        val_3 = val_3 - val_5;
        val_4 = 1;
        label_1:
        if(val_4 < ratioArray.Length)
        {
            goto label_6;
        }
        
        return 0;
    }
    public static int PickUp(int value, int i)
    {
        var val_1;
        int val_1 = i;
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        val_1 = val_1 - 1;
        if()
        {
            goto label_2;
        }
        
        val_1 = 0;
        return (int)val_1;
        label_1:
        val_1 = 0;
        return (int)val_1;
        label_2:
        int val_2 = 10;
        val_2 = value / val_2;
        val_1 = 0;
        return (int)val_1;
    }
    public static string ToStringWithDigitCommas(int value)
    {
        return (string)System.String.Format(format:  "{0:#,0}", arg0:  value);
    }
    public static string ToTimeString(int value)
    {
        int val_4 = 0;
        val_4 = val_4 + value;
        val_4 = (val_4 >> 5) + (val_4 >> 31);
        return (string)System.String.Format(format:  "{0:D2}:{1:D2}", arg0:  val_4, arg1:  value - (val_4 * 60));
    }
    public static string ToChineseNumerals(int number)
    {
        return IntExtensions.ToChineseNumerals(number:  (long)number);
    }
    public static string ToChineseNumerals(long number)
    {
        long val_18;
        System.String[] val_19;
        System.String[] val_20;
        string val_21;
        string val_22;
        var val_23;
        val_18 = number;
        if((val_18 & 9223372036854775808) != 0)
        {
            goto label_1;
        }
        
        if(val_18 == 0)
        {
            goto label_2;
        }
        
        val_18 = new string[10];
        val_18[0] = "";
        val_18[1] = "一";
        val_18[2] = "二";
        val_18[3] = "三";
        val_18[4] = "四";
        val_18[5] = "五";
        val_18[6] = "六";
        val_18[7] = "七";
        val_18[8] = "八";
        val_18[9] = "九";
        val_19 = new string[4];
        val_19[0] = "";
        val_19[1] = "十";
        val_19[2] = "百";
        val_19[3] = "千";
        val_20 = new string[5];
        val_20[0] = "";
        val_20[1] = "万";
        val_20[2] = "億";
        val_20[3] = "兆";
        val_21 = "京";
        val_20[4] = val_21;
        val_22 = "";
        if(val_18 < 1)
        {
                return (string)val_22;
        }
        
        var val_18 = 0;
        val_20 = 26215;
        label_77:
        var val_4 = (val_18 < 0) ? 3 : (val_18);
        var val_5 = X28 >> 2;
        val_4 = val_4 & 4294967292;
        val_23 = val_18 - val_4;
        val_21 = val_18 - ((val_5 + ((X28) >> 63)) * 10);
        if(val_23 == 0)
        {
            goto label_64;
        }
        
        if(val_21 != 1)
        {
            goto label_69;
        }
        
        val_21 = (long)val_23;
        string val_7 = val_19[val_21] + val_22;
        goto label_68;
        label_64:
        if(1616 >= 1)
        {
                var val_10 = ((val_18 < 0) ? (val_18 + 3) : (val_18)) >> 2;
            System.String[] val_11 = val_20 + (((long)((0 < 0x0 ? (0 + 3) : 0>>2) & 0x3FFFFFFF)) << 3);
            val_19 = val_19;
            val_18 = val_18;
            val_22 = (val_3 + ((long)((0 < 0x0 ? (0 + 3) : 0>>2) & 0x3FFFFFFF)) << 3) + 32((val_3 + ((long)((0 < 0x0 ? (0 + 3) : 0>>2) & 0x3FFFFFFF)) << 3) + 32) + val_22;
            val_20 = 26215;
        }
        
        label_69:
        if(val_21 == 0)
        {
            goto label_72;
        }
        
        val_21 = val_18[val_21];
        val_23 = (long)val_23;
        System.String[] val_13 = val_19 + (((long)(int)((0 - (0 < 0x0 ? 3 : 0 & 4294967292)))) << 3);
        label_68:
        val_22 = val_21 + (val_2 + ((long)(int)((0 - (0 < 0x0 ? 3 : 0 & 4294967292)))) << 3) + 32((val_2 + ((long)(int)((0 - (0 < 0x0 ? 3 : 0 & 4294967292)))) << 3) + 32) + val_22;
        label_72:
        val_18 = val_18 + 1;
        if(val_18 > 9)
        {
            goto label_77;
        }
        
        return (string)val_22;
        label_1:
        val_22 = val_5 + ((X28) >> 63).ToString();
        return (string)val_22;
        label_2:
        val_22 = "〇";
        return (string)val_22;
    }
    public static string ToMetricPrefix(ulong value, int decimalPoint = 1)
    {
        System.Collections.Generic.IEnumerable<TSource> val_14;
        var val_15;
        var val_16;
        System.Func<System.Char, System.Boolean> val_18;
        val_14 = System.String.Format(format:  "{0:#,0}", arg0:  value);
        if(val_14.Length < 4)
        {
                return (string)val_14;
        }
        
        if(val_14 != null)
        {
                val_15 = val_14.IndexOf(value:  ',');
        }
        else
        {
                val_15 = 0.IndexOf(value:  ',');
        }
        
        string[] val_8 = new string[9];
        val_8[0] = "";
        val_8[1] = "k";
        val_8[2] = "M";
        val_8[3] = "G";
        val_8[4] = "T";
        val_8[5] = "P";
        val_8[6] = "E";
        val_8[7] = "Z";
        val_8[8] = "Y";
        val_16 = null;
        val_16 = null;
        val_18 = IntExtensions.<>c.<>9__8_0;
        if(val_18 == null)
        {
                System.Func<System.Char, System.Boolean> val_9 = null;
            val_18 = val_9;
            val_9 = new System.Func<System.Char, System.Boolean>(object:  IntExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean IntExtensions.<>c::<ToMetricPrefix>b__8_0(char c));
            IntExtensions.<>c.<>9__8_0 = val_18;
        }
        
        val_14 = System.String.Format(format:  "{0}{1}", arg0:  val_14.Substring(startIndex:  0, length:  val_15 + 2).Replace(oldChar:  ',', newChar:  '.'), arg1:  val_8[(long)UnityEngine.Mathf.Min(a:  System.Linq.Enumerable.Count<System.Char>(source:  val_14, predicate:  val_9), b:  val_8.Length - 1)]);
        return (string)val_14;
    }

}
