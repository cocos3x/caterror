using UnityEngine;
public static class LocalCacheManager
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, object> dictionary;
    
    // Methods
    public static void Save(string tag, object value)
    {
        null = null;
        LocalCacheManager.dictionary.set_Item(key:  tag, value:  value);
    }
    public static T Load<T>(string tag, T defaultValue)
    {
        var val_8;
        var val_9;
        val_8 = __RuntimeMethodHiddenParam;
        val_9 = defaultValue;
        if((LocalCacheManager.Exists(tag:  tag)) == false)
        {
                return (object)val_9;
        }
        
        val_8 = ???;
        val_9 = ???;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T Load<T>(string tag)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        object val_1 = LocalCacheManager.dictionary.Item[tag];
        if(val_1 != null)
        {
                val_4 = val_1;
            if(val_4 != null)
        {
                return (AvatarData)val_4;
        }
        
        }
        
        val_4 = 0;
        return (AvatarData)val_4;
    }
    public static bool Exists(string tag)
    {
        null = null;
        if(LocalCacheManager.dictionary != null)
        {
                return LocalCacheManager.dictionary.ContainsKey(key:  tag);
        }
        
        return LocalCacheManager.dictionary.ContainsKey(key:  tag);
    }
    public static bool Remove(string tag)
    {
        null = null;
        if(LocalCacheManager.dictionary != null)
        {
                return LocalCacheManager.dictionary.Remove(key:  tag);
        }
        
        return LocalCacheManager.dictionary.Remove(key:  tag);
    }
    public static void Clear()
    {
        null = null;
        LocalCacheManager.dictionary.Clear();
    }
    private static LocalCacheManager()
    {
        LocalCacheManager.dictionary = new System.Collections.Generic.Dictionary<System.String, System.Object>();
    }

}
