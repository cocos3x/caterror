using UnityEngine;
public sealed class LocalizationManager.OnLocalizeCallback : MulticastDelegate
{
    // Methods
    public LocalizationManager.OnLocalizeCallback(object object, IntPtr method)
    {
        mem[1152921512288292416] = object;
        mem[1152921512288292424] = method;
        mem[1152921512288292400] = method;
    }
    public virtual void Invoke()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if(X23 == 0)
        {
            goto label_0;
        }
        
        if((X23 + 24) == 0)
        {
                return;
        }
        
        var val_16 = 0;
        goto label_28;
        label_20:
        if((this & 1) == 0)
        {
            goto label_3;
        }
        
        if((X20 + 286) == 0)
        {
            goto label_7;
        }
        
        var val_8 = X20 + 176;
        var val_9 = 0;
        val_8 = val_8 + 8;
        label_6:
        if(((X20 + 176 + 8) + -8) == X21.Index)
        {
            goto label_5;
        }
        
        val_9 = val_9 + 1;
        val_8 = val_8 + 16;
        if(val_9 < (X20 + 286))
        {
            goto label_6;
        }
        
        goto label_7;
        label_21:
        var val_10 = X20;
        val_10 = val_10 + ((X21 + 72) << 4);
        val_11 = mem[(X20 + (X21 + 72) << 4) + 304];
        val_11 = (X20 + (X21 + 72) << 4) + 304;
        goto label_27;
        label_3:
        var val_11 = X20;
        val_11 = val_11 + (X21 + 72);
        goto label_27;
        label_23:
        var val_12 = X11;
        val_12 = val_12 + W2;
        val_11 = val_11 + val_12;
        var val_2 = val_11 + 296;
        label_25:
        val_11 = mem[(((X20 + X21 + 72) + (X11 + W2)) + 296) + 8];
        val_11 = (((X20 + X21 + 72) + (X11 + W2)) + 296) + 8;
        goto label_27;
        label_5:
        var val_13 = val_8;
        val_13 = val_13 + (X21 + 72);
        val_13 = X20 + val_13;
        val_10 = val_13 + 296;
        label_7:
        int val_3 = X20.CompareTo(value:  public System.Int32 System.Int64::CompareTo(object value));
        goto label_27;
        label_28:
        var val_4 = X23 + 0;
        if((((X23 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_13;
        }
        
        if(((X23 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_27;
        }
        
        if(((X23 + 0) + 32 + 32) != 0)
        {
                if((((X23 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_27;
        }
        
        }
        
        if(((X23 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_27;
        }
        
        if(((X23 + 0) + 32 + 32) != 0)
        {
                if((((X23 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_27;
        }
        
        }
        
        if((((X23 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_20;
        }
        
        if((((X23 + 0) + 32 + 32 + 8.Index) & 1) == 0)
        {
            goto label_21;
        }
        
        if(((X23 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_25;
        }
        
        var val_14 = (X23 + 0) + 32 + 32 + 176;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_24:
        if((((X23 + 0) + 32 + 32 + 176 + 8) + -8) == ((X23 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_23;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < ((X23 + 0) + 32 + 32 + 286))
        {
            goto label_24;
        }
        
        goto label_25;
        label_13:
        if(((X23 + 0) + 32 + 32 + 8 + 74) != 0)
        {
            
        }
        
        label_27:
        val_16 = val_16 + 1;
        if(val_16 != (X23 + 24))
        {
            goto label_28;
        }
        
        return;
        label_0:
        if((X21 & 1) == 0)
        {
            goto label_30;
        }
        
        if((X21 + 72) == 1)
        {
            goto label_34;
        }
        
        if(X20 != 0)
        {
                if(((X20 + 265) & 1) != 0)
        {
            goto label_34;
        }
        
        }
        
        if((X20 + 265) == 0)
        {
            goto label_34;
        }
        
        if(X20 != 0)
        {
                if(((X20 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        long val_6 = X21.Index;
        if((X21 & 1) == 0)
        {
            goto label_37;
        }
        
        if((val_6 & 1) == 0)
        {
            goto label_38;
        }
        
        var val_24 = X20;
        if((X20 + 286) == 0)
        {
            goto label_42;
        }
        
        var val_17 = X20 + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_41:
        if(((X20 + 176 + 8) + -8) == (X21 + 24))
        {
            goto label_40;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (X20 + 286))
        {
            goto label_41;
        }
        
        goto label_42;
        label_30:
        if((X21 + 74) == 0)
        {
            goto label_43;
        }
        
        label_34:
        label_52:
        label_43:
        label_37:
        if((val_6 & 1) == 0)
        {
            goto label_44;
        }
        
        if((X20 + 286) == 0)
        {
            goto label_52;
        }
        
        var val_19 = X20 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_47:
        if(((X20 + 176 + 8) + -8) == X21.Index)
        {
            goto label_46;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X20 + 286))
        {
            goto label_47;
        }
        
        goto label_52;
        label_38:
        var val_21 = X20;
        val_21 = val_21 + ((X21 + 72) << 4);
        val_14 = mem[(X20 + (X21 + 72) << 4) + 304];
        val_14 = (X20 + (X21 + 72) << 4) + 304;
        goto label_52;
        label_44:
        var val_22 = X20;
        val_22 = val_22 + (X21 + 72);
        goto label_52;
        label_40:
        var val_23 = val_17;
        val_23 = val_23 + (X21 + 72);
        val_24 = val_24 + val_23;
        val_12 = val_24 + 296;
        label_42:
        val_14 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(X21 + 24), slot: 0) + 8];
        val_14 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X20, typeof(X21 + 24), slot: 0) + 8;
        goto label_52;
        label_46:
        var val_25 = val_19;
        val_25 = val_25 + (X21 + 72);
        val_25 = X20 + val_25;
        val_13 = val_25 + 296;
        goto label_52;
    }
    public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
