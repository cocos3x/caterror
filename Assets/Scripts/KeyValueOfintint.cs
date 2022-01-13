using UnityEngine;
public sealed class KeyValueOfintint
{
    // Fields
    public int Key;
    public int Value;
    
    // Methods
    public KeyValueOfintint(System.Collections.Generic.KeyValuePair<int, int> value)
    {
        this.Key = value.Value.GetHashCode();
        this.Value = value.Value;
    }

}
