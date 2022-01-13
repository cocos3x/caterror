using UnityEngine;
public sealed class LocalizationManager._GetParam : MulticastDelegate
{
    // Methods
    public LocalizationManager._GetParam(object object, IntPtr method)
    {
        mem[1152921512287795136] = object;
        mem[1152921512287795144] = method;
        mem[1152921512287795120] = method;
    }
    public virtual object Invoke(string param)
    {
        var val_22;
        var val_23;
        var val_24;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_32;
        var val_33;
        var val_34;
        if(X24 == 0)
        {
            goto label_0;
        }
        
        if((X24 + 24) == 0)
        {
            goto label_73;
        }
        
        val_22 = 0;
        var val_35 = 0;
        goto label_65;
        label_0:
        if((X21 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X21 + 74) != 1)
        {
            goto label_5;
        }
        
        if((X21 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X22 == 0)
        {
            goto label_71;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
            goto label_73;
        }
        
        long val_1 = X21.Index;
        if((X21 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_43 = X22;
        if((X22 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_21 = X22 + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_16:
        if(((X22 + 176 + 8) + -8) == (X21 + 24))
        {
            goto label_15;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (X22 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        long val_2 = X21.Index;
        var val_23 = 0;
        val_23 = val_23 + 1;
        goto label_22;
        label_60:
        string val_3 = 1152921504623247360 + ((X21 + 72) << 4);
        val_26 = mem[(1152921504623247360 + (X21 + 72) << 4) + 304];
        goto label_23;
        label_18:
        val_27 = param;
        string val_4 = 1152921504623247360 + (X21 + 72);
        goto label_52;
        label_45:
        if((val_27 & 1) == 0)
        {
            goto label_25;
        }
        
        if((X21 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_24 = X21 + 72 + 176;
        var val_25 = 0;
        val_24 = val_24 + 8;
        label_28:
        if(((X21 + 72 + 176 + 8) + -8) == X21.Index)
        {
            goto label_27;
        }
        
        val_25 = val_25 + 1;
        val_24 = val_24 + 16;
        if(val_25 < (X21 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_26 = X21 + 72;
        val_26 = val_26 + ((X21 + 72) << 4);
        val_29 = mem[(X21 + 72 + (X21 + 72) << 4) + 304];
        val_29 = (X21 + 72 + (X21 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_27 = X21 + 72;
        val_27 = X21 + 72;
        val_27 = val_27 + (X21 + 72);
        goto label_52;
        label_64:
        val_26 = mem[(((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8];
        val_26 = (((X21 + 72 + X21 + 72) + (((X22 + 176 + 8) + 16) + (X21 + 72 + X21 + 72) + 296 + 8)) + 296) + 8;
        label_23:
        val_27 = param;
        goto label_52;
        label_22:
        var val_30 = public System.Int32 System.Int64::CompareTo(object value);
        val_27 = param;
        int val_8 = val_27.CompareTo(value:  public System.Int32 System.Int64::CompareTo(object value));
        goto label_52;
        label_48:
        var val_29 = 1179403647;
        val_29 = val_29 + (X21 + 72);
        val_30 = val_30 + val_29;
        var val_9 = val_30 + 296;
        label_50:
        val_29 = mem[((System.Int64.CompareTo + (1179403647 + X21 + 72)) + 296) + 8];
        val_29 = ((System.Int64.CompareTo + (1179403647 + X21 + 72)) + 296) + 8;
        label_30:
        val_27 = X21 + 72;
        goto label_52;
        label_27:
        var val_31 = val_24;
        val_31 = val_31 + (X21 + 72);
        val_31 = (X21 + 72) + val_31;
        val_28 = val_31 + 296;
        label_29:
        val_27 = X21 + 72;
        int val_10 = val_27.CompareTo(value:  param);
        goto label_52;
        label_65:
        var val_11 = X24 + 0;
        val_23 = mem[(X24 + 0) + 32 + 32 + 8];
        val_23 = (X24 + 0) + 32 + 32 + 8;
        if((val_23 & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 74) != 1)
        {
            goto label_38;
        }
        
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_42;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_42;
        }
        
        if(((X24 + 0) + 32 + 32) == 0)
        {
            goto label_56;
        }
        
        if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((val_23 & 1) == 0)
        {
            goto label_45;
        }
        
        if((val_23.Index & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X24 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_32 = (X24 + 0) + 32 + 32 + 176;
        var val_33 = 0;
        val_32 = val_32 + 8;
        label_49:
        if((((X24 + 0) + 32 + 32 + 176 + 8) + -8) == ((X24 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_33 = val_33 + 1;
        val_32 = val_32 + 16;
        if(val_33 < ((X24 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X24 + 0) + 32 + 32 + 8 + 74) == 1)
        {
            goto label_56;
        }
        
        label_42:
        val_27 = (X24 + 0) + 32 + 32;
        goto label_52;
        label_38:
        if(((X24 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(((X24 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_56;
        }
        
        if(((X24 + 0) + 32 + 32) != 0)
        {
                if((((X24 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((val_23 & 1) == 0)
        {
            goto label_59;
        }
        
        if((val_23.Index & 1) == 0)
        {
            goto label_60;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        goto label_64;
        label_56:
        val_27 = param;
        label_52:
        val_22 = val_27;
        label_58:
        val_35 = val_35 + 1;
        if(val_35 != (X24 + 24))
        {
            goto label_65;
        }
        
        return (object)val_22;
        label_4:
        if((X21 + 74) == 1)
        {
            goto label_71;
        }
        
        label_9:
        label_97:
        label_5:
        if((X21 + 72) == 65535)
        {
            goto label_71;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_71;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_71;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_73;
        }
        
        }
        
        long val_14 = X21.Index;
        if((X21 & 1) == 0)
        {
            goto label_74;
        }
        
        if((val_14 & 1) == 0)
        {
            goto label_75;
        }
        
        var val_36 = 0;
        val_36 = val_36 + 1;
        goto label_79;
        label_73:
        val_22 = 0;
        return (object)val_22;
        label_71:
        label_95:
        label_74:
        if((val_14 & 1) == 0)
        {
            goto label_80;
        }
        
        long val_15 = X21.Index;
        var val_37 = 0;
        val_37 = val_37 + 1;
        goto label_95;
        label_75:
        string val_16 = 1152921504623247360 + ((X21 + 72) << 4);
        val_32 = mem[(1152921504623247360 + (X21 + 72) << 4) + 304];
        goto label_95;
        label_80:
        string val_17 = 1152921504623247360 + (X21 + 72);
        goto label_95;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_87;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_97;
        }
        
        var val_38 = X22 + 176;
        var val_39 = 0;
        val_38 = val_38 + 8;
        label_90:
        if(((X22 + 176 + 8) + -8) == X21.Index)
        {
            goto label_89;
        }
        
        val_39 = val_39 + 1;
        val_38 = val_38 + 16;
        if(val_39 < (X22 + 286))
        {
            goto label_90;
        }
        
        goto label_97;
        label_13:
        var val_40 = X22;
        val_40 = val_40 + ((X21 + 72) << 4);
        val_34 = mem[(X22 + (X21 + 72) << 4) + 304];
        val_34 = (X22 + (X21 + 72) << 4) + 304;
        goto label_97;
        label_87:
        var val_41 = X22;
        val_41 = val_41 + (X21 + 72);
        goto label_97;
        label_79:
        val_32 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(param, typeof(X21 + 24), slot: 0) + 8];
        val_32 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(param, typeof(X21 + 24), slot: 0) + 8;
        goto label_95;
        label_15:
        var val_42 = val_21;
        val_42 = val_42 + (X21 + 72);
        val_43 = val_43 + val_42;
        val_24 = val_43 + 296;
        label_17:
        val_34 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8];
        val_34 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X21 + 24), slot: 0) + 8;
        goto label_97;
        label_89:
        var val_44 = val_38;
        val_44 = val_44 + (X21 + 72);
        val_44 = X22 + val_44;
        val_33 = val_44 + 296;
        goto label_97;
    }
    public virtual System.IAsyncResult BeginInvoke(string param, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual object EndInvoke(System.IAsyncResult result)
    {
    
    }

}
