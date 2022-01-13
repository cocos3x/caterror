using UnityEngine;
[Serializable]
public class Serialization<T>
{
    // Fields
    private System.Collections.Generic.List<T> target;
    
    // Methods
    public System.Collections.Generic.List<T> ToList()
    {
        return (System.Collections.Generic.List<T>)this;
    }
    public Serialization<T>(System.Collections.Generic.List<T> target)
    {
        mem[1152921512120001312] = target;
    }

}
