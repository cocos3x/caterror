using UnityEngine;
[Serializable]
public struct InfiniteFloat
{
    // Fields
    private float value;
    private long index;
    private static readonly string[] unit;
    private static readonly string[] unitC;
    
    // Properties
    public float Value { get; }
    public long Index { get; }
    public static InfiniteFloat Zero { get; }
    public static InfiniteFloat One { get; }
    
    // Methods
    public float get_Value()
    {
        return (float)S0;
    }
    public long get_Index()
    {
        return (long)this;
    }
    public InfiniteFloat(float value, long index = 0)
    {
    
    }
    public InfiniteFloat(ulong value)
    {
    
    }
    public static InfiniteFloat get_Zero()
    {
        return InfiniteFloat.CreateInstance(value:  0f, index:  0);
    }
    public static InfiniteFloat get_One()
    {
        return InfiniteFloat.CreateInstance(value:  1f, index:  0);
    }
    public void Reset()
    {
        mem[1152921512098878656] = 0;
        mem[1152921512098878664] = 0;
    }
    public static InfiniteFloat op_Addition(InfiniteFloat i1, InfiniteFloat i2)
    {
        long val_4;
        float val_5;
        val_4 = i1.index;
        long val_1 = val_4 - i2.index;
        if()
        {
                long val_2 = i2.index - val_4;
            float val_4 = 10f;
            val_5 = val_4;
            val_4 = val_5 * i2.value;
            val_4 = val_4 + i1.value;
            return InfiniteFloat.CreateInstance(value:  i1.value + i2.value, index:  val_4);
        }
        
        if()
        {
                return InfiniteFloat.CreateInstance(value:  i1.value + i2.value, index:  val_4);
        }
        
        float val_5 = 10f;
        val_5 = val_5;
        val_5 = val_5 * i1.value;
        val_5 = val_5 + i2.value;
        val_4 = i2.index;
        return InfiniteFloat.CreateInstance(value:  i1.value + i2.value, index:  val_4);
    }
    public static InfiniteFloat op_Subtraction(InfiniteFloat i1, InfiniteFloat i2)
    {
        long val_4;
        float val_5;
        val_4 = i1.index;
        long val_1 = val_4 - i2.index;
        if()
        {
                long val_2 = i2.index - val_4;
            float val_4 = 10f;
            val_5 = val_4;
            val_4 = val_5 * i2.value;
            val_4 = i1.value - val_4;
            return InfiniteFloat.CreateInstance(value:  i1.value - i2.value, index:  val_4);
        }
        
        if()
        {
                return InfiniteFloat.CreateInstance(value:  i1.value - i2.value, index:  val_4);
        }
        
        float val_5 = 10f;
        val_5 = val_5;
        val_5 = val_5 * i1.value;
        val_5 = val_5 - i2.value;
        val_4 = i2.index;
        return InfiniteFloat.CreateInstance(value:  i1.value - i2.value, index:  val_4);
    }
    public static InfiniteFloat op_Multiply(InfiniteFloat i1, InfiniteFloat i2)
    {
        return InfiniteFloat.CreateInstance(value:  i1.value * i2.value, index:  i2.index + i1.index);
    }
    public static InfiniteFloat op_Division(InfiniteFloat i1, InfiniteFloat i2)
    {
        return InfiniteFloat.CreateInstance(value:  i1.value / i2.value, index:  i1.index - i2.index);
    }
    public static bool op_GreaterThan(InfiniteFloat i1, InfiniteFloat i2)
    {
        return (bool)(i1.value > i2.value) ? 1 : 0;
    }
    public static bool op_GreaterThanOrEqual(InfiniteFloat i1, InfiniteFloat i2)
    {
        if(i1.index != i2.index)
        {
                return (bool)(i1.index > i2.index) ? 1 : 0;
        }
        
        return (bool)(i1.value >= i2.value) ? 1 : 0;
    }
    public static bool op_LessThan(InfiniteFloat i1, InfiniteFloat i2)
    {
        if(i1.index != i2.index)
        {
                return (bool)(i1.index < i2.index) ? 1 : 0;
        }
        
        return (bool)(i1.value < 0) ? 1 : 0;
    }
    public static bool op_LessThanOrEqual(InfiniteFloat i1, InfiniteFloat i2)
    {
        if(i1.index != i2.index)
        {
                return (bool)(i1.index < i2.index) ? 1 : 0;
        }
        
        return (bool)(i1.value <= i2.value) ? 1 : 0;
    }
    public static InfiniteFloat op_Addition(InfiniteFloat i, float f)
    {
        float val_1 = 10f;
        val_1 = val_1 * f;
        val_1 = val_1 + i.value;
        return InfiniteFloat.CreateInstance(value:  val_1, index:  i.index);
    }
    public static InfiniteFloat op_Addition(float f, InfiniteFloat i)
    {
        float val_1 = 10f;
        val_1 = val_1 * f;
        val_1 = val_1 + i.value;
        return InfiniteFloat.CreateInstance(value:  val_1, index:  i.index);
    }
    public static InfiniteFloat op_Subtraction(InfiniteFloat i, float f)
    {
        float val_1 = 10f;
        val_1 = val_1 * f;
        val_1 = i.value - val_1;
        return InfiniteFloat.CreateInstance(value:  val_1, index:  i.index);
    }
    public static InfiniteFloat op_Subtraction(float f, InfiniteFloat i)
    {
        float val_1 = 10f;
        val_1 = val_1 * f;
        val_1 = val_1 - i.value;
        return InfiniteFloat.CreateInstance(value:  val_1, index:  i.index);
    }
    public static InfiniteFloat op_Multiply(InfiniteFloat i, float f)
    {
        f = i.value * f;
        return InfiniteFloat.CreateInstance(value:  f, index:  i.index);
    }
    public static InfiniteFloat op_Multiply(float f, InfiniteFloat i)
    {
        f = i.value * f;
        return InfiniteFloat.CreateInstance(value:  f, index:  i.index);
    }
    public static InfiniteFloat op_Division(InfiniteFloat i, float f)
    {
        f = i.value / f;
        return InfiniteFloat.CreateInstance(value:  f, index:  i.index);
    }
    public static InfiniteFloat op_Division(float f, InfiniteFloat i)
    {
        f = f / i.value;
        return InfiniteFloat.CreateInstance(value:  f, index:  -i.index);
    }
    public static bool op_GreaterThan(InfiniteFloat i, float f)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 < 0) ? 1 : 0;
    }
    public static bool op_GreaterThan(float f, InfiniteFloat i)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 > i.value) ? 1 : 0;
    }
    public static bool op_GreaterThanOrEqual(InfiniteFloat i, float f)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 <= i.value) ? 1 : 0;
    }
    public static bool op_GreaterThanOrEqual(float f, InfiniteFloat i)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 >= i.value) ? 1 : 0;
    }
    public static bool op_LessThan(InfiniteFloat i, float f)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 > i.value) ? 1 : 0;
    }
    public static bool op_LessThan(float f, InfiniteFloat i)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 < 0) ? 1 : 0;
    }
    public static bool op_LessThanOrEqual(InfiniteFloat i, float f)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 >= i.value) ? 1 : 0;
    }
    public static bool op_LessThanOrEqual(float f, InfiniteFloat i)
    {
        float val_2 = 10f;
        val_2 = val_2 * f;
        return (bool)(val_2 <= i.value) ? 1 : 0;
    }
    public static InfiniteFloat op_Multiply(InfiniteFloat i, double d)
    {
        long val_2 = 0;
        InfiniteFloat.ToShorten(value: ref  double val_1 = 1.2882318977711E-231, index: ref  val_2);
        float val_5 = (float)d;
        val_5 = i.value * val_5;
        InfiniteFloat val_4 = InfiniteFloat.CreateInstance(value:  val_5, index:  val_2 + i.index);
        return new InfiniteFloat() {value = val_4.value, index = val_4.index};
    }
    public static InfiniteFloat op_Multiply(double d, InfiniteFloat i)
    {
        long val_2 = 0;
        InfiniteFloat.ToShorten(value: ref  double val_1 = 1.28823189780314E-231, index: ref  val_2);
        float val_5 = (float)d;
        val_5 = i.value * val_5;
        InfiniteFloat val_4 = InfiniteFloat.CreateInstance(value:  val_5, index:  val_2 + i.index);
        return new InfiniteFloat() {value = val_4.value, index = val_4.index};
    }
    public static InfiniteFloat op_Division(InfiniteFloat i, double d)
    {
        long val_2 = 0;
        InfiniteFloat.ToShorten(value: ref  double val_1 = 1.28823189783518E-231, index: ref  val_2);
        float val_5 = (float)d;
        val_5 = i.value / val_5;
        InfiniteFloat val_4 = InfiniteFloat.CreateInstance(value:  val_5, index:  i.index - val_2);
        return new InfiniteFloat() {value = val_4.value, index = val_4.index};
    }
    public static InfiniteFloat op_Division(double d, InfiniteFloat i)
    {
        long val_2 = 0;
        InfiniteFloat.ToShorten(value: ref  double val_1 = 1.28823189786722E-231, index: ref  val_2);
        float val_5 = (float)d;
        val_5 = val_5 / i.value;
        InfiniteFloat val_4 = InfiniteFloat.CreateInstance(value:  val_5, index:  val_2 - i.index);
        return new InfiniteFloat() {value = val_4.value, index = val_4.index};
    }
    public InfiniteFloat Pow(int p)
    {
    
    }
    public InfiniteFloat Pow(float p)
    {
    
    }
    public InfiniteFloat Sqrt()
    {
    
    }
    public InfiniteFloat Exp()
    {
    
    }
    public InfiniteFloat Log()
    {
    
    }
    public static InfiniteFloat Factorial(uint i)
    {
        if(i == 0)
        {
                return InfiniteFloat.One;
        }
        
        return InfiniteFloat.op_Multiply(f:  (float)(double)i, i:  new InfiniteFloat() {value = i - 1});
    }
    public InfiniteFloat Floor()
    {
    
    }
    public int FloorToInt()
    {
    
    }
    private static void ToShorten(ref float value, ref long index)
    {
        object val_4;
        long val_5;
        float val_6;
        float val_7;
        float val_8;
        if((System.Single.IsInfinity(f:  value)) == false)
        {
            goto label_1;
        }
        
        val_4 = "float value is Infinity.";
        goto label_4;
        label_1:
        if((System.Single.IsNaN(f:  value)) == false)
        {
            goto label_5;
        }
        
        val_4 = "float value is NaN.";
        label_4:
        UnityEngine.Debug.LogWarning(message:  val_4);
        value = 1f;
        label_5:
        val_5 = index;
        if(val_5 >= 1)
        {
                long val_3 = val_5 - (-1);
            if(val_3 != 0)
        {
                float val_4 = 10f;
            val_4 = value * val_4;
            value = val_4;
            val_5 = index - val_3;
            index = val_5;
        }
        
        }
        
        val_6 = value;
        if(val_6 <= 0f)
        {
            goto label_12;
        }
        
        if(val_6 >= 1000f)
        {
                do
        {
            val_6 = val_6 * 0.001f;
            value = val_6;
            val_5 = index + 3;
            index = val_5;
            val_7 = value;
        }
        while(val_7 >= 1000f);
        
        }
        
        if(val_7 < 10f)
        {
            goto label_18;
        }
        
        do
        {
            if((val_5 & 9223372036854775808) == 0)
        {
            goto label_18;
        }
        
            val_7 = val_7 * 0.1f;
            value = val_7;
            val_5 = index + 1;
            index = val_5;
            val_7 = value;
        }
        while(val_7 >= 10f);
        
        goto label_18;
        label_21:
        val_7 = val_7 * 1000f;
        value = val_7;
        val_5 = index - 3;
        index = val_5;
        val_7 = value;
        label_18:
        if((val_7 >= 0) || (val_7 <= 0f))
        {
            goto label_22;
        }
        
        if(val_5 >= 1)
        {
            goto label_21;
        }
        
        goto label_22;
        label_25:
        val_7 = val_7 * 10f;
        value = val_7;
        val_5 = index - 1;
        index = val_5;
        val_7 = value;
        label_22:
        if((val_7 >= 0) || (val_7 <= 0f))
        {
            goto label_40;
        }
        
        if(val_5 <= 0)
        {
            goto label_25;
        }
        
        goto label_42;
        label_12:
        if(val_6 >= 0)
        {
            goto label_27;
        }
        
        if(val_6 <= (-1000f))
        {
                do
        {
            val_6 = val_6 * 0.001f;
            value = val_6;
            val_5 = index + 3;
            index = val_5;
            val_8 = value;
        }
        while(val_8 <= (-1000f));
        
        }
        
        if(val_8 > (-10f))
        {
            goto label_31;
        }
        
        label_32:
        if((val_5 & 9223372036854775808) == 0)
        {
            goto label_31;
        }
        
        val_8 = val_8 * 0.1f;
        value = val_8;
        val_5 = index + 1;
        index = val_5;
        val_8 = value;
        if(val_8 <= (-10f))
        {
            goto label_32;
        }
        
        label_31:
        if((val_8 <= (-1f)) || (val_8 >= 0))
        {
            goto label_38;
        }
        
        label_37:
        if(val_5 < 1)
        {
            goto label_38;
        }
        
        val_8 = val_8 * 1000f;
        value = val_8;
        val_5 = index - 3;
        index = val_5;
        val_8 = value;
        if(val_8 <= (-1f))
        {
            goto label_38;
        }
        
        if(val_8 < 0)
        {
            goto label_37;
        }
        
        goto label_38;
        label_41:
        val_8 = val_8 * 10f;
        value = val_8;
        val_5 = index - 1;
        index = val_5;
        val_8 = value;
        label_38:
        if((val_8 <= (-1f)) || (val_8 >= 0))
        {
            goto label_40;
        }
        
        if(val_5 <= 0)
        {
            goto label_41;
        }
        
        goto label_42;
        label_40:
        if(val_5 < 1)
        {
                return;
        }
        
        label_42:
        val_3 = val_5 - 5;
        if(val_3 < 1)
        {
                return;
        }
        
        float val_5 = 10f;
        val_5 = value * val_5;
        value = val_5;
        long val_6 = index;
        val_6 = val_6 - val_3;
        index = val_6;
        return;
        label_27:
        index = 0;
    }
    private static void ToShorten(ref double value, ref long index)
    {
        object val_3;
        double val_4;
        double val_5;
        double val_6;
        if((System.Double.IsInfinity(d:  value)) == false)
        {
            goto label_3;
        }
        
        val_3 = "double value is Infinity.";
        goto label_6;
        label_3:
        if((System.Double.IsNaN(d:  value)) == false)
        {
            goto label_9;
        }
        
        val_3 = "double value is NaN.";
        label_6:
        UnityEngine.Debug.LogWarning(message:  val_3);
        value = 1;
        return;
        label_9:
        val_4 = value;
        if(val_4 < 0f)
        {
                if(val_4 <= (-1000))
        {
                do
        {
            val_4 = val_4 * 0.001;
            value = val_4;
            long val_3 = index;
            val_3 = val_3 + 3;
            index = val_3;
            val_5 = value;
        }
        while(val_5 <= (-1000));
        
        }
        
            if(val_5 <= (-1))
        {
                return;
        }
        
            if(val_5 >= 0)
        {
                return;
        }
        
            do
        {
            val_5 = val_5 * 10;
            value = val_5;
            long val_4 = index;
            val_4 = val_4 - 1;
            index = val_4;
            if(value <= (-1))
        {
                return;
        }
        
        }
        while(value < 0);
        
            return;
        }
        
        if(val_4 >= 1000)
        {
                do
        {
            val_4 = val_4 * 0.001;
            value = val_4;
            long val_5 = index;
            val_5 = val_5 + 3;
            index = val_5;
            val_6 = value;
        }
        while(val_6 >= 1000);
        
        }
        
        if(val_6 >= 0)
        {
                return;
        }
        
        if(val_6 <= 0f)
        {
                return;
        }
        
        do
        {
            val_6 = val_6 * 10;
            value = val_6;
            long val_6 = index;
            val_6 = val_6 - 1;
            index = val_6;
            if(value >= 0)
        {
                return;
        }
        
        }
        while(value > 0f);
    
    }
    public static InfiniteFloat CreateInstance(float value, long index = 0)
    {
        long val_2 = index;
        InfiniteFloat.ToShorten(value: ref  float val_1 = -0.4107331f, index: ref  val_2);
        return new InfiniteFloat() {value = value, index = val_2};
    }
    public override string ToString()
    {
    
    }
    public string ToString(string[] unit)
    {
    
    }
    public string ToString(uint decimalCount = 1, int minIndex = 3)
    {
    
    }
    public string ToStringInt(uint decimalCount = 1, int minIndex = 3)
    {
    
    }
    private string _ToString(string[] unit, bool isInt, uint decimalCount, int minIndex)
    {
        bool val_1 = isInt;
    }
    public string ToChineseNumerals()
    {
    
    }
    public string ToChineseNumerals(string[] unit, string lastUnit)
    {
    
    }
    public string ToChineseNumeralsInt()
    {
    
    }
    public string ToChineseNumeralsInt(string[] unit, string lastUnit)
    {
    
    }
    private string _ToChineseNumerals(string zeroIndexFormat, string[] unit, string lastUnit, bool isInt)
    {
        bool val_1 = isInt;
    }
    public float ToFloat()
    {
    
    }
    public ulong ToULong()
    {
        mem2[0] = null;
        mem2[0] = null;
        return (ulong)new InfiniteFloat();
    }
    public static InfiniteFloat Lerp(InfiniteFloat a, InfiniteFloat b, float t)
    {
        InfiniteFloat val_1 = InfiniteFloat.op_Subtraction(i1:  new InfiniteFloat() {value = b.value, index = b.index}, i2:  new InfiniteFloat() {value = a.value, index = a.index});
        InfiniteFloat val_2 = InfiniteFloat.op_Multiply(i:  new InfiniteFloat() {value = val_1.value, index = val_1.index}, f:  t);
        return InfiniteFloat.op_Addition(i1:  new InfiniteFloat() {value = a.value, index = a.index}, i2:  new InfiniteFloat() {value = val_2.value, index = val_2.index});
    }
    private static InfiniteFloat()
    {
        string[] val_1 = new string[6];
        val_1[0] = "";
        val_1[1] = "K";
        val_1[2] = "M";
        val_1[3] = "B";
        val_1[4] = "T";
        val_1[5] = "Q";
        InfiniteFloat.unit = val_1;
        string[] val_2 = new string[13];
        val_2[0] = "";
        val_2[1] = "万";
        val_2[2] = "億";
        val_2[3] = "兆";
        val_2[4] = "京";
        val_2[5] = "垓";
        val_2[6] = "秭";
        val_2[7] = "穣";
        val_2[8] = "溝";
        val_2[9] = "澗";
        val_2[10] = "正";
        val_2[11] = "載";
        val_2[12] = "極";
        InfiniteFloat.unitC = val_2;
    }

}
