using UnityEngine;
internal sealed class DeflateStream.AsyncWriteDelegate : MulticastDelegate
{
    // Methods
    public DeflateStream.AsyncWriteDelegate(object object, IntPtr method)
    {
        mem[1152921512143342448] = object;
        mem[1152921512143342456] = method;
        mem[1152921512143342432] = method;
    }
    public virtual void Invoke(byte[] array, int offset, int count, bool isAsync)
    {
        DeflateStream.AsyncWriteDelegate val_39;
        var val_40;
        var val_41;
        var val_43;
        var val_44;
        var val_45;
        var val_48;
        var val_49;
        var val_50;
        val_39 = this;
        if(X27 == 0)
        {
            goto label_0;
        }
        
        if((X27 + 24) == 0)
        {
                return;
        }
        
        goto label_65;
        label_0:
        if((X24 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 74) != 4)
        {
            goto label_5;
        }
        
        if((X24 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X25 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X25 == 0)
        {
            goto label_70;
        }
        
        if(((X25 + 265) & 1) != 0)
        {
                return;
        }
        
        long val_1 = X24.Index;
        if((X24 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_59 = X25;
        if((X25 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_38 = X25 + 176;
        var val_39 = 0;
        val_38 = val_38 + 8;
        label_16:
        if(((X25 + 176 + 8) + -8) == (X24 + 24))
        {
            goto label_15;
        }
        
        val_39 = val_39 + 1;
        val_38 = val_38 + 16;
        if(val_39 < (X25 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        val_40 = mem[X24 + 72];
        val_40 = X24 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        long val_2 = X24.Index;
        var val_40 = 0;
        val_40 = val_40 + 1;
        goto label_22;
        label_60:
        System.Byte[] val_4 = 1152921504986874816 + ((X24 + 72) << 4);
        val_43 = mem[(1152921504986874816 + (X24 + 72) << 4) + 304];
        goto label_23;
        label_18:
        bool val_5 = isAsync;
        System.Byte[] val_6 = 1152921504986874816 + val_40;
        goto label_58;
        label_45:
        if((array & 1) == 0)
        {
            goto label_25;
        }
        
        if((X24 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_41 = X24 + 72 + 176;
        var val_42 = 0;
        val_41 = val_41 + 8;
        label_28:
        if(((X24 + 72 + 176 + 8) + -8) == X24.Index)
        {
            goto label_27;
        }
        
        val_42 = val_42 + 1;
        val_41 = val_41 + 16;
        if(val_42 < (X24 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_43 = val_40;
        val_43 = val_43 + ((X24 + 72) << 4);
        val_45 = mem[(X24 + 72 + (X24 + 72) << 4) + 304];
        val_45 = (X24 + 72 + (X24 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_44 = val_40;
        bool val_8 = isAsync;
        val_44 = val_44 + (X24 + 72);
        goto label_58;
        label_64:
        val_43 = mem[(((X24 + 72 + X24 + 72) + (((X25 + 176 + 8) + 16) + offset)) + 296) + 8];
        val_43 = (((X24 + 72 + X24 + 72) + (((X25 + 176 + 8) + 16) + offset)) + 296) + 8;
        label_23:
        bool val_10 = isAsync;
        goto label_58;
        label_22:
        var val_47 = public System.Int32 System.Int64::CompareTo(object value);
        bool val_13 = isAsync;
        int val_14 = array.CompareTo(value:  offset);
        goto label_58;
        label_48:
        var val_46 = 1179403647;
        val_46 = val_46 + count;
        val_47 = val_47 + val_46;
        int val_15 = val_47 + 296;
        label_50:
        val_45 = mem[((System.Int64.CompareTo + (1179403647 + count)) + 296) + 8];
        val_45 = ((System.Int64.CompareTo + (1179403647 + count)) + 296) + 8;
        label_30:
        bool val_16 = isAsync;
        goto label_58;
        label_27:
        var val_48 = val_41;
        val_48 = val_48 + (X24 + 72);
        val_48 = val_40 + val_48;
        val_44 = val_48 + 296;
        label_29:
        bool val_17 = isAsync;
        int val_18 = val_40.CompareTo(value:  array);
        goto label_58;
        label_65:
        var val_19 = X27 + 0;
        val_40 = mem[(X27 + 0) + 32 + 32];
        val_40 = (X27 + 0) + 32 + 32;
        if((((X27 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X27 + 0) + 32 + 32 + 8 + 74) != 4)
        {
            goto label_38;
        }
        
        if(((X27 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_42;
        }
        
        if(val_40 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(mem[1152921512143495464] == 0)
        {
            goto label_42;
        }
        
        if(val_40 == 0)
        {
            goto label_56;
        }
        
        if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((((X27 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_45;
        }
        
        if((((X27 + 0) + 32 + 32 + 8.Index) & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X27 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_49 = (X27 + 0) + 32 + 32 + 176;
        var val_50 = 0;
        val_49 = val_49 + 8;
        label_49:
        if((((X27 + 0) + 32 + 32 + 176 + 8) + -8) == ((X27 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_50 = val_50 + 1;
        val_49 = val_49 + 16;
        if(val_50 < ((X27 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X27 + 0) + 32 + 32 + 8 + 74) == 4)
        {
            goto label_56;
        }
        
        label_42:
        isAsync = isAsync;
        goto label_58;
        label_38:
        if(((X27 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(val_40 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(mem[1152921512143495464] == 0)
        {
            goto label_56;
        }
        
        if(val_40 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((((X27 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_59;
        }
        
        if((((X27 + 0) + 32 + 32 + 8.Index) & 1) == 0)
        {
            goto label_60;
        }
        
        var val_51 = 0;
        val_51 = val_51 + 1;
        goto label_64;
        label_56:
        bool val_23 = isAsync;
        label_58:
        val_39 = 0 + 1;
        if(val_39 != (X27 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X24 + 74) == 4)
        {
            goto label_70;
        }
        
        label_9:
        isAsync = isAsync;
        label_96:
        label_5:
        if((X24 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X25 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        long val_24 = X24.Index;
        if((X24 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_24 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_52 = 0;
        val_52 = val_52 + 1;
        goto label_78;
        label_70:
        bool val_26 = isAsync;
        label_94:
        label_73:
        if((val_24 & 1) == 0)
        {
            goto label_79;
        }
        
        long val_27 = X24.Index;
        var val_53 = 0;
        val_53 = val_53 + 1;
        goto label_83;
        label_74:
        System.Byte[] val_29 = 1152921504986874816 + ((X24 + 72) << 4);
        val_48 = mem[(1152921504986874816 + (X24 + 72) << 4) + 304];
        goto label_84;
        label_79:
        System.Byte[] val_30 = 1152921504986874816 + (X24 + 72);
        goto label_85;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X25 + 286) == 0)
        {
            goto label_90;
        }
        
        var val_54 = X25 + 176;
        var val_55 = 0;
        val_54 = val_54 + 8;
        label_89:
        if(((X25 + 176 + 8) + -8) == X24.Index)
        {
            goto label_88;
        }
        
        val_55 = val_55 + 1;
        val_54 = val_54 + 16;
        if(val_55 < (X25 + 286))
        {
            goto label_89;
        }
        
        goto label_90;
        label_13:
        var val_56 = X25;
        val_56 = val_56 + ((X24 + 72) << 4);
        val_50 = mem[(X25 + (X24 + 72) << 4) + 304];
        val_50 = (X25 + (X24 + 72) << 4) + 304;
        goto label_91;
        label_86:
        var val_57 = X25;
        val_57 = val_57 + (X24 + 72);
        goto label_92;
        label_78:
        val_48 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(array, typeof(X24 + 24), slot: 0) + 8];
        val_48 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(array, typeof(X24 + 24), slot: 0) + 8;
        label_84:
        bool val_34 = isAsync;
        goto label_94;
        label_83:
        label_85:
        bool val_37 = isAsync;
        goto label_94;
        label_15:
        var val_58 = val_38;
        val_58 = val_58 + (X24 + 72);
        val_59 = val_59 + val_58;
        val_41 = val_59 + 296;
        label_17:
        val_50 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0) + 8];
        val_50 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0) + 8;
        label_91:
        isAsync = isAsync;
        goto label_96;
        label_88:
        var val_60 = val_54;
        val_60 = val_60 + (X24 + 72);
        val_60 = X25 + val_60;
        val_49 = val_60 + 296;
        label_90:
        label_92:
        isAsync = isAsync;
        goto label_96;
    }
    public virtual System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, bool isAsync, System.AsyncCallback callback, object object)
    {
        bool val_1 = isAsync;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
