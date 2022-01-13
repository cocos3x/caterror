using UnityEngine;
private sealed class JSONArray.<get_Children>d__17 : IEnumerable<Umeng.JSONNode>, IEnumerable, IEnumerator<Umeng.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private Umeng.JSONNode <>2__current;
    private int <>l__initialThreadId;
    public Umeng.JSONArray <>4__this;
    private System.Collections.Generic.List.Enumerator<Umeng.JSONNode> <>7__wrap1;
    
    // Properties
    private Umeng.JSONNode System.Collections.Generic.IEnumerator<Umeng.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONArray.<get_Children>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_2;
        List.Enumerator<Umeng.JSONNode> val_3;
        List.Enumerator<Umeng.JSONNode> val_6;
        int val_7;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_16;
        }
        
        val_6 = this.<>7__wrap1;
        this.<>1__state = -3;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        List.Enumerator<T> val_1 = this.<>4__this.m_List.GetEnumerator();
        val_6 = this.<>7__wrap1;
        mem[1152921512209835328] = val_2;
        this.<>1__state = -3;
        this.<>7__wrap1 = val_3;
        label_3:
        if((val_6 & 1) != 0)
        {
                this.<>2__current = val_6.Id;
            val_7 = 1;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        this.<>m__Finally1();
        val_7 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_7;
        label_16:
        val_7 = 0;
        return (bool)val_7;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        UniRx.Unit..cctor();
    }
    private Umeng.JSONNode System.Collections.Generic.IEnumerator<Umeng.JSONNode>.get_Current()
    {
        return (Umeng.JSONNode)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }
    private System.Collections.Generic.IEnumerator<Umeng.JSONNode> System.Collections.Generic.IEnumerable<Umeng.JSONNode>.GetEnumerator()
    {
        if((this.<>1__state) == 2)
        {
                if((this.<>l__initialThreadId) == System.Environment.CurrentManagedThreadId)
        {
                this.<>1__state = 0;
            return (System.Collections.Generic.IEnumerator<Umeng.JSONNode>)this;
        }
        
        }
        
        .<>1__state = 0;
        .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
        .<>4__this = this.<>4__this;
        this = new JSONArray.<get_Children>d__17();
        return (System.Collections.Generic.IEnumerator<Umeng.JSONNode>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<Umeng.JSONNode>.GetEnumerator();
    }

}
