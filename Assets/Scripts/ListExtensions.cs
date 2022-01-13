using UnityEngine;
public static class ListExtensions
{
    // Methods
    public static T Back<T>(System.Collections.Generic.List<T> list)
    {
        System.Collections.Generic.List<T> val_1 = list - 1;
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public static T Front<T>(System.Collections.Generic.List<T> list)
    {
        if(list == null)
        {
            
        }
    
    }
    public static bool Empty<T>(System.Collections.Generic.List<T> list)
    {
        return (bool)(list == 0) ? 1 : 0;
    }
    public static System.Collections.Generic.List<T> Shuffle<T>(System.Collections.Generic.List<T> list)
    {
        System.Random val_1 = new System.Random();
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<T> Shuffle<T>(System.Collections.Generic.List<T> list, System.Random rand)
    {
        System.Collections.Generic.List<T> val_2 = list;
        if(val_2 < 2)
        {
                return (System.Collections.Generic.List<T>)list;
        }
        
        do
        {
            val_2 = val_2 - 1;
            if(list != null)
        {
            
        }
        
        }
        while((val_2 + 1) > 2);
        
        return (System.Collections.Generic.List<T>)list;
    }
    public static T RandomChoose<T>(System.Collections.Generic.IList<T> list)
    {
        System.Random val_1 = new System.Random();
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T RandomChoose<T>(System.Collections.Generic.IList<T> list, System.Random rand)
    {
        var val_4;
        var val_3 = 0;
        val_3 = val_3 + 1;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = 0;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(list, typeof(__RuntimeMethodHiddenParam + 48 + 8), slot: 0);
    }
    public static System.Collections.Generic.List<T> RandomChoose<T>(System.Collections.Generic.IList<T> list, int count)
    {
        System.Random val_1 = new System.Random();
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<T> RandomChoose<T>(System.Collections.Generic.IList<T> list, int count, System.Random rand)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = count;
        val_3 = list;
        val_4 = __RuntimeMethodHiddenParam + 48;
        if(val_2 <= 0)
        {
                return (System.Collections.Generic.List<T>)val_4;
        }
        
        val_5 = val_3;
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_5 = __RuntimeMethodHiddenParam + 48 + 24;
        if(val_3 < val_2)
        {
                return (System.Collections.Generic.List<T>)val_4;
        }
        
        val_3 = __RuntimeMethodHiddenParam + 48;
        do
        {
            val_2 = val_2 - 1;
        }
        while(val_2 != 0);
        
        val_4 = val_3;
        return (System.Collections.Generic.List<T>)val_4;
    }
    public static T RandomChooseRatio<T>(System.Collections.Generic.IEnumerable<T> list)
    {
        System.Random val_1 = new System.Random();
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T RandomChooseRatio<T>(System.Collections.Generic.IEnumerable<T> list, System.Random rand)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_12;
        var val_14;
        var val_15;
        var val_16;
        val_5 = mem[__RuntimeMethodHiddenParam + 48 + 294];
        val_5 = __RuntimeMethodHiddenParam + 48 + 294;
        if((val_5 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_5 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
        val_6 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
        val_6 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
        if(val_6 == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_7 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_7 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_7 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
            val_8 = mem[__RuntimeMethodHiddenParam + 48];
            val_8 = __RuntimeMethodHiddenParam + 48;
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 48];
            val_8 = __RuntimeMethodHiddenParam + 48;
        }
        
            val_6 = __RuntimeMethodHiddenParam + 48 + 16;
            mem2[0] = val_6;
        }
        
        float val_7 = V0.16B;
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_9 = __RuntimeMethodHiddenParam + 48 + 40;
        val_7 = val_7 * (float)V0.16B;
        float val_10 = 0f;
        label_36:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_12 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        if(list.MoveNext() == false)
        {
            goto label_28;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_12 = __RuntimeMethodHiddenParam + 48 + 48;
        val_14 = list;
        val_10 = val_10 + S0;
        if(val_10 <= val_7)
        {
            goto label_36;
        }
        
        val_15 = 0;
        goto label_37;
        label_28:
        val_15 = 0;
        val_14 = 0;
        label_37:
        val_16 = 0;
        if(list == null)
        {
            
        }
        else
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            list.Dispose();
        }
        
        if( != 1)
        {
                if( == false)
        {
                return (object);
        }
        
            if(128 == 128)
        {
                return (object);
        }
        
            return (object);
        }
        
        if( == true)
        {
                return (object);
        }
        
        return (object);
    }
    public static System.Collections.Generic.List<T> RandomChooseRatio<T>(System.Collections.Generic.List<T> list, int count)
    {
        System.Random val_1 = new System.Random();
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<T> RandomChooseRatio<T>(System.Collections.Generic.List<T> list, int count, System.Random rand)
    {
        var val_1;
        var val_2;
        val_1 = count;
        val_2 = list;
        if(val_2 < val_1)
        {
                return (System.Collections.Generic.List<T>)val_2;
        }
        
        val_2 = __RuntimeMethodHiddenParam + 48 + 8;
        if(val_1 < 1)
        {
                return (System.Collections.Generic.List<T>)val_2;
        }
        
        do
        {
            val_1 = val_1 - 1;
        }
        while(val_1 != 0);
        
        return (System.Collections.Generic.List<T>)val_2;
    }

}
