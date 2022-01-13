using UnityEngine;
public static class TextureExtensions
{
    // Methods
    public static bool isBogus(UnityEngine.Texture tex)
    {
        UnityEngine.Texture2D val_5;
        if((UnityEngine.Object.op_Implicit(exists:  tex)) == false)
        {
                return true;
        }
        
        if(tex != null)
        {
                var val_2 = (null == null) ? tex : 0;
            return TextureExtensions.Equivalent(bytes1:  UnityEngine.ImageConversion.EncodeToPNG(tex:  val_5 = 0), bytes2:  new byte[122] {137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 8, 0, 0, 0, 8, 8, 2, 0, 0, 0, 75, 109, 41, 220, 0, 0, 0, 65, 73, 68, 65, 84, 8, 29, 85, 142, 81, 10, 0, 48, 8, 66, 107, 236, 254, 87, 110, 106, 35, 172, 143, 74, 243, 65, 89, 85, 129, 202, 100, 239, 146, 115, 184, 183, 11, 109, 33, 29, 126, 114, 141, 75, 213, 65, 44, 131, 70, 24, 97, 46, 50, 34, 72, 25, 39, 181, 9, 251, 205, 14, 10, 78, 123, 43, 35, 17, 17, 228, 109, 164, 219, 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130});
        }
        
        return TextureExtensions.Equivalent(bytes1:  UnityEngine.ImageConversion.EncodeToPNG(tex:  val_5), bytes2:  new byte[122] {137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 8, 0, 0, 0, 8, 8, 2, 0, 0, 0, 75, 109, 41, 220, 0, 0, 0, 65, 73, 68, 65, 84, 8, 29, 85, 142, 81, 10, 0, 48, 8, 66, 107, 236, 254, 87, 110, 106, 35, 172, 143, 74, 243, 65, 89, 85, 129, 202, 100, 239, 146, 115, 184, 183, 11, 109, 33, 29, 126, 114, 141, 75, 213, 65, 44, 131, 70, 24, 97, 46, 50, 34, 72, 25, 39, 181, 9, 251, 205, 14, 10, 78, 123, 43, 35, 17, 17, 228, 109, 164, 219, 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130});
    }
    public static bool Equivalent(byte[] bytes1, byte[] bytes2)
    {
        int val_3;
        int val_4;
        var val_5;
        var val_6;
        if(bytes1 == null)
        {
            goto label_0;
        }
        
        if(bytes2 != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        val_3 = bytes1.Length;
        val_4 = bytes2.Length;
        if(val_3 != val_4)
        {
            goto label_2;
        }
        
        if(val_3 < 1)
        {
            goto label_5;
        }
        
        val_5 = 0;
        goto label_4;
        label_8:
        val_3 = bytes1.Length;
        val_5 = W22 + 1;
        if(val_5 >= val_3)
        {
            goto label_5;
        }
        
        val_4 = bytes2.Length;
        label_4:
        if(val_5 >= val_4)
        {
                val_3 = bytes1.Length;
        }
        
        if((bytes1[(long)val_5][32].Equals(obj:  bytes2[(long)val_5])) == true)
        {
            goto label_8;
        }
        
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_0:
        if(bytes2 != null)
        {
            goto label_10;
        }
        
        goto label_11;
        label_5:
        val_6 = 1;
        return (bool)val_6;
    }

}
