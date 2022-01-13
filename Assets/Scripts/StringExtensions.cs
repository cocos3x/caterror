using UnityEngine;
public static class StringExtensions
{
    // Methods
    public static int ToInt(string str)
    {
        return System.Int32.Parse(s:  str);
    }
    public static UnityEngine.Color ToColor(string str)
    {
        if((UnityEngine.ColorUtility.TryParseHtmlString(htmlString:  str, color: out  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) != false)
        {
                return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.magenta;
        return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    public static int ToLayer(string str)
    {
        return UnityEngine.LayerMask.NameToLayer(layerName:  str);
    }
    public static int ToLayerMask(string str)
    {
        int val_1 = UnityEngine.LayerMask.NameToLayer(layerName:  str);
        val_1 = 1 << (val_1 & 31);
        return (int)val_1;
    }
    public static int ToLayerMask(string[] strArray)
    {
        var val_2;
        var val_3;
        val_2 = 0;
        val_3 = 0;
        goto label_0;
        label_3:
        strArray[0] = (UnityEngine.LayerMask.NameToLayer(layerName:  strArray[0])) & 31;
        strArray[0] = 1 << strArray[0];
        val_3 = strArray[0] | val_3;
        val_2 = 1;
        label_0:
        if(val_2 < strArray.Length)
        {
            goto label_3;
        }
        
        return (int)val_3;
    }
    public static System.Collections.Generic.List<int> ToIntList(string str)
    {
        if(str == null)
        {
                return (System.Collections.Generic.List<System.Int32>)new System.Collections.Generic.List<System.Int32>();
        }
        
        char[] val_1 = new char[1];
        val_1[0] = ',';
        return System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<System.String, System.Int32>(source:  str.Split(separator:  val_1), selector:  new System.Func<System.String, System.Int32>(object:  0, method:  public static System.Int32 System.Int32::Parse(string s))));
    }
    public static bool CheckPictograph(string text)
    {
        System.Text.Encoding val_1 = System.Text.Encoding.GetEncoding(name:  "Shift_JIS");
        if(val_1 != null)
        {
                return System.String.op_Inequality(a:  text, b:  val_1);
        }
        
        return System.String.op_Inequality(a:  text, b:  val_1);
    }
    public static int CompareVersion(string a, string b)
    {
        System.Char[] val_9;
        string val_10;
        var val_11;
        val_10 = a;
        if((System.String.op_Equality(a:  val_10, b:  b)) == true)
        {
            goto label_12;
        }
        
        char[] val_2 = new char[1];
        val_2[0] = '.';
        val_10 = val_10.Split(separator:  val_2);
        char[] val_4 = new char[1];
        val_9 = val_4;
        val_9[0] = '.';
        System.String[] val_5 = b.Split(separator:  val_4);
        if(val_10 == null)
        {
            goto label_8;
        }
        
        label_20:
        int val_6 = System.Math.Max(val1:  val_3.Length, val2:  val_5.Length);
        if(val_6 >= 1)
        {
                var val_9 = 0;
            do
        {
            if(val_9 >= (val_3.Length << ))
        {
                return (int)val_11;
        }
        
            if(val_9 >= val_5.Length)
        {
                return (int)val_11;
        }
        
            val_9 = System.Int32.Parse(s:  null);
            val_11 = val_9 - (System.Int32.Parse(s:  null));
            if(val_11 != 0)
        {
                return (int)val_11;
        }
        
            val_9 = val_9 + 1;
        }
        while(val_9 < (long)val_6);
        
        }
        
        label_12:
        val_11 = 0;
        return (int)val_11;
        label_8:
        if(val_5 != null)
        {
            goto label_20;
        }
        
        goto label_20;
    }
    public static bool IsVersion(string str)
    {
        System.Text.RegularExpressions.Regex val_1 = new System.Text.RegularExpressions.Regex(pattern:  "[0-9]+\\.[0-9]+\\.[0-9]+");
        if(val_1 != null)
        {
                return val_1.IsMatch(input:  str);
        }
        
        return val_1.IsMatch(input:  str);
    }
    public static string Compression(string str)
    {
        System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
        System.IO.MemoryStream val_2 = new System.IO.MemoryStream();
        new Unity.IO.Compression.DeflateStream() = new Unity.IO.Compression.DeflateStream(stream:  val_2, mode:  1, leaveOpen:  true);
        new Unity.IO.Compression.DeflateStream().Close();
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_2.Dispose();
        return System.Convert.ToBase64String(inArray:  val_2, options:  1);
    }
    public static string DeCompression(string str)
    {
        var val_9;
        var val_10;
        var val_11;
        System.IO.MemoryStream val_2 = new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  str));
        new System.IO.MemoryStream() = new System.IO.MemoryStream();
        new Unity.IO.Compression.DeflateStream() = new Unity.IO.Compression.DeflateStream(stream:  val_2, mode:  0);
        label_6:
        if(new Unity.IO.Compression.DeflateStream().ReadByte() == 1)
        {
            goto label_4;
        }
        
        if(new System.IO.MemoryStream() != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        val_9 = new System.IO.MemoryStream();
        val_10 = 0;
        val_11 = 0;
        var val_9 = 0;
        val_9 = val_9 + 1;
        new System.IO.MemoryStream().Dispose();
        if( == 1)
        {
                if(null != null)
        {
                val_10 = 0;
        }
        
            val_11 = 0;
        }
        
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
        }
        
        if(System.Text.Encoding.UTF8 == null)
        {
            
        }
    
    }
    public static string DataToXML<T>(T data, bool isShorten = True)
    {
        System.Runtime.Serialization.DataContractSerializer val_2 = new System.Runtime.Serialization.DataContractSerializer(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
        var val_6 = 0;
        val_6 = val_6 + 1;
        new System.IO.MemoryStream().Dispose();
        if(0 != 1)
        {
                return (string)System.Text.Encoding.UTF8;
        }
        
        if(0 == 0)
        {
                return (string)System.Text.Encoding.UTF8;
        }
        
        return (string)System.Text.Encoding.UTF8;
    }
    public static T XMLToData<T>(string xml)
    {
        var val_7;
        var val_8;
        var val_9;
        System.Text.Encoding val_4 = System.Text.Encoding.UTF8;
        val_7 = new System.Runtime.Serialization.DataContractSerializer(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
        if(val_7 != null)
        {
                val_8 = val_7;
            if(val_8 == null)
        {
                val_8 = 0;
        }
        
            val_9 = 0;
            val_7 = 0;
        }
        else
        {
                val_8 = 0;
            val_9 = 0;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        new System.IO.MemoryStream().Dispose();
        if(val_7 != 1)
        {
                return (GameData)val_8;
        }
        
        if(val_9 == 0)
        {
                return (GameData)val_8;
        }
        
        return (GameData)val_8;
    }

}
