using UnityEngine;
public sealed class Tuple<T1, T2, T3>
{
    // Fields
    private readonly T1 item1;
    private readonly T2 item2;
    private readonly T3 item3;
    
    // Properties
    public T1 Item1 { get; }
    public T2 Item2 { get; }
    public T3 Item3 { get; }
    
    // Methods
    public T1 get_Item1()
    {
        return (object)this;
    }
    public T2 get_Item2()
    {
        return (object)this;
    }
    public T3 get_Item3()
    {
        return (object)this;
    }
    public Tuple<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
    {
        val_1 = new System.Object();
        mem[1152921512130519072] = item1;
        mem[1152921512130519080] = val_1;
        mem[1152921512130519088] = item3;
    }
    public override int GetHashCode()
    {
        var val_1;
        var val_3;
        val_1 = 8993;
        if(this != null)
        {
                val_1 = 8070450705295254289;
        }
        
        if(this != null)
        {
                val_3 = this;
        }
        else
        {
                val_3 = 0;
        }
        
        val_3 = val_3 + val_1;
        this = this + (val_3 * 23);
        return (int)this;
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
    public static bool op_Equality(Tuple<T1, T2, T3> a, Tuple<T1, T2, T3> b)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = b;
        Tuple<T1, T2, T3> val_1 = a | val_3;
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
        
        label_11:
        if(val_1 == null)
        {
            goto label_3;
        }
        
        label_13:
        if(val_1 == null)
        {
            goto label_4;
        }
        
        label_14:
        if(((X21 & 1) == 0) || ((X21 & 1) == 0))
        {
            goto label_12;
        }
        
        val_3 = ???;
        val_5 = ???;
        goto Tuple<T1, T2, T3>.__il2cppRuntimeField_vtable;
        label_2:
        if((val_3 + 16) != 0)
        {
            goto label_12;
        }
        
        goto label_11;
        label_3:
        if(val_1 != null)
        {
            goto label_12;
        }
        
        goto label_13;
        label_4:
        if(val_1 == null)
        {
            goto label_14;
        }
        
        label_12:
        val_4 = 0;
        return (bool)val_4;
    }
    public static bool op_Inequality(Tuple<T1, T2, T3> a, Tuple<T1, T2, T3> b)
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
        
        Tuple<T1, T2, T3> val_1 = a;
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public void Unpack(System.Action<T1, T2, T3> unpackerDelegate)
    {
        if(unpackerDelegate == null)
        {
            
        }
    
    }

}
