using UnityEngine;
public sealed class Tuple<T1, T2>
{
    // Fields
    private readonly T1 item1;
    private readonly T2 item2;
    
    // Properties
    public T1 Item1 { get; }
    public T2 Item2 { get; }
    
    // Methods
    public T1 get_Item1()
    {
        return (object)this;
    }
    public T2 get_Item2()
    {
        return (object)this;
    }
    public Tuple<T1, T2>(T1 item1, T2 item2)
    {
        val_1 = new System.Object();
        mem[1152921512129209136] = item1;
        mem[1152921512129209144] = val_1;
    }
    public override string ToString()
    {
        if(this != null)
        {
                return System.String.Format(format:  "Tuple({0}, {1})", arg0:  this, arg1:  this);
        }
        
        return System.String.Format(format:  "Tuple({0}, {1})", arg0:  this, arg1:  this);
    }
    public override int GetHashCode()
    {
        if(this != null)
        {
                8993 = 8070450705267610129;
        }
        
        if(this == null)
        {
                return (int)-9223371856312500063;
        }
        
        return (int)-9223371856312500063;
    }
    public override bool Equals(object o)
    {
        object val_2 = o;
        if(val_2 == null)
        {
                return false;
        }
        
        if(o != null)
        {
                if(o != null)
        {
            goto label_4;
        }
        
        }
        
        label_4:
        val_2 = this;
        return false;
    }
    public bool Equals(Tuple<T1, T2> other)
    {
        goto __RuntimeMethodHiddenParam + 24 + 192 + 40;
    }
    public static bool op_Equality(Tuple<T1, T2> a, Tuple<T1, T2> b)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = b;
        Tuple<T1, T2> val_1 = a | val_3;
        var val_2 = (val_1 == 0) ? 1 : 0;
        if(a == null)
        {
                return (bool)val_4;
        }
        
        if(val_3 == null)
        {
                return (bool)val_4;
        }
        
        if(X21 == 0)
        {
            goto label_2;
        }
        
        label_8:
        if(val_1 == null)
        {
            goto label_3;
        }
        
        label_9:
        if((X21 & 1) == 0)
        {
            goto label_7;
        }
        
        val_3 = ???;
        val_5 = ???;
        goto Tuple<T1, T2>.__il2cppRuntimeField_vtable;
        label_2:
        if((val_3 + 16) != 0)
        {
            goto label_7;
        }
        
        goto label_8;
        label_3:
        if(val_1 == null)
        {
            goto label_9;
        }
        
        label_7:
        val_4 = 0;
        return (bool)val_4;
    }
    public static bool op_Inequality(Tuple<T1, T2> a, Tuple<T1, T2> b)
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        val_2 = __RuntimeMethodHiddenParam + 24;
        if((val_1 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24];
            val_2 = __RuntimeMethodHiddenParam + 24;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        Tuple<T1, T2> val_1 = a;
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public void Unpack(System.Action<T1, T2> unpackerDelegate)
    {
        if(unpackerDelegate == null)
        {
            
        }
    
    }

}
