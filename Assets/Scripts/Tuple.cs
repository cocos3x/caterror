using UnityEngine;
public static class Tuple
{
    // Methods
    public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 second)
    {
        if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
        {
                return (Tuple<T1, T2>)__RuntimeMethodHiddenParam + 48;
        }
        
        return (Tuple<T1, T2>)__RuntimeMethodHiddenParam + 48;
    }
    public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 second, T3 third)
    {
        if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
        {
                return (Tuple<T1, T2, T3>)__RuntimeMethodHiddenParam + 48;
        }
        
        return (Tuple<T1, T2, T3>)__RuntimeMethodHiddenParam + 48;
    }
    public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 second, T3 third, T4 fourth)
    {
        if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
        {
                return (Tuple<T1, T2, T3, T4>)__RuntimeMethodHiddenParam + 48;
        }
        
        return (Tuple<T1, T2, T3, T4>)__RuntimeMethodHiddenParam + 48;
    }
    public static void Unpack<T1, T2>(Tuple<T1, T2> tuple, out T1 ref1, out T2 ref2)
    {
        ref1 = tuple;
        ref2 = tuple;
    }
    public static void Unpack<T1, T2, T3>(Tuple<T1, T2, T3> tuple, out T1 ref1, out T2 ref2, T3 ref3)
    {
        ref1 = tuple;
        if(tuple != null)
        {
                ref2 = tuple;
        }
        else
        {
                ref2 = 0;
        }
    
    }
    public static void Unpack<T1, T2, T3, T4>(Tuple<T1, T2, T3, T4> tuple, out T1 ref1, out T2 ref2, T3 ref3, T4 ref4)
    {
        ref1 = tuple;
        if(tuple != null)
        {
                ref2 = tuple;
        }
        else
        {
                ref2 = 0;
        }
        
        if(tuple == null)
        {
            
        }
    
    }

}
