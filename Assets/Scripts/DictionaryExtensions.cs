using UnityEngine;
public static class DictionaryExtensions
{
    // Methods
    public static U GetOrDefault<T, U>(System.Collections.Generic.Dictionary<T, U> dict, T key, U defaultValue)
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = __RuntimeMethodHiddenParam;
        val_8 = defaultValue;
        val_9 = key;
        if((dict & 1) == 0)
        {
                return (object)val_8;
        }
        
        val_9 = ???;
        val_8 = ???;
        val_7 = ???;
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }

}
