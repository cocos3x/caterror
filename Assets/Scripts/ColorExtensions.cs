using UnityEngine;
public static class ColorExtensions
{
    // Fields
    public static UnityEngine.Color invisibleWhite;
    
    // Methods
    public static UnityEngine.Color Add(UnityEngine.Color c1, UnityEngine.Color c2)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = c1.r, g = c1.g, b = c1.b, a = c1.a}, b:  new UnityEngine.Color() {r = c2.r, g = c2.g, b = c2.b, a = c2.a});
        return new UnityEngine.Color() {r = UnityEngine.Mathf.Clamp(value:  val_1.r, min:  0f, max:  1f), g = UnityEngine.Mathf.Clamp(value:  val_1.g, min:  0f, max:  1f), b = UnityEngine.Mathf.Clamp(value:  val_1.b, min:  0f, max:  1f), a = UnityEngine.Mathf.Clamp(value:  val_1.a, min:  0f, max:  1f)};
    }
    public static UnityEngine.Color AddR(UnityEngine.Color c, float f)
    {
        f = c.r + f;
        return ColorExtensions.SetR(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a}, f:  f);
    }
    public static UnityEngine.Color SetR(UnityEngine.Color c, float f)
    {
        return new UnityEngine.Color() {r = UnityEngine.Mathf.Clamp(value:  f, min:  0f, max:  1f), g = c.g, b = c.b, a = c.a};
    }
    public static UnityEngine.Color AddG(UnityEngine.Color c, float f)
    {
        f = c.g + f;
        return ColorExtensions.SetG(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a}, f:  f);
    }
    public static UnityEngine.Color SetG(UnityEngine.Color c, float f)
    {
        return new UnityEngine.Color() {r = c.r, g = UnityEngine.Mathf.Clamp(value:  f, min:  0f, max:  1f), b = c.b, a = c.a};
    }
    public static UnityEngine.Color AddB(UnityEngine.Color c, float f)
    {
        f = c.b + f;
        return ColorExtensions.SetB(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a}, f:  f);
    }
    public static UnityEngine.Color SetB(UnityEngine.Color c, float f)
    {
        return new UnityEngine.Color() {r = c.r, g = c.g, b = UnityEngine.Mathf.Clamp(value:  f, min:  0f, max:  1f), a = c.a};
    }
    public static UnityEngine.Color AddA(UnityEngine.Color c, float f)
    {
        f = c.a + f;
        return ColorExtensions.SetA(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a}, f:  f);
    }
    public static UnityEngine.Color SetA(UnityEngine.Color c, float f)
    {
        return new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = UnityEngine.Mathf.Clamp(value:  f, min:  0f, max:  1f)};
    }
    private static string Slice(string aString, int num)
    {
        var val_4;
        if(aString != null)
        {
                val_4 = aString.Length;
            return aString.Substring(startIndex:  num, length:  val_4 - 1);
        }
        
        val_4 = 0.Length;
        return aString.Substring(startIndex:  num, length:  val_4 - 1);
    }
    public static string ToColorCode(UnityEngine.Color color)
    {
        UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
        byte val_2 = val_1.r & 65280;
        val_2 = val_2 | 16777216;
        return (string)"#" + ColorExtensions.Slice(aString:  val_2.ToString(format:  "X"), num:  1)(ColorExtensions.Slice(aString:  val_2.ToString(format:  "X"), num:  1));
    }
    private static ColorExtensions()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.black;
        UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        ColorExtensions.invisibleWhite = val_3.r;
        ColorExtensions.invisibleWhite.__il2cppRuntimeField_4 = val_3.g;
        ColorExtensions.invisibleWhite.__il2cppRuntimeField_8 = val_3.b;
        ColorExtensions.invisibleWhite.__il2cppRuntimeField_C = val_3.a;
    }

}
