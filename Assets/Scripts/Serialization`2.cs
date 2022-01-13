using UnityEngine;
[Serializable]
public class Serialization<TKey, TValue> : ISerializationCallbackReceiver
{
    // Fields
    private System.Collections.Generic.List<TKey> keys;
    private System.Collections.Generic.List<TValue> values;
    private System.Collections.Generic.Dictionary<TKey, TValue> target;
    
    // Methods
    public System.Collections.Generic.Dictionary<TKey, TValue> ToDictionary()
    {
        return (System.Collections.Generic.Dictionary<TKey, TValue>)this;
    }
    public Serialization<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> target)
    {
        mem[1152921512120233520] = target;
    }
    public void OnBeforeSerialize()
    {
        mem[1152921512120349600] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        mem[1152921512120349608] = __RuntimeMethodHiddenParam + 24 + 192 + 32;
    }
    public void OnAfterDeserialize()
    {
        var val_3;
        var val_4;
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
        mem[1152921512120461616] = val_3;
        if()
        {
                return;
        }
        
        val_4 = 0;
        goto label_7;
        label_11:
        val_4 = 1;
        label_7:
        if(((System.Math.Min(val1:  37244928, val2:  X22)) - 1) != val_4)
        {
            goto label_11;
        }
    
    }

}
