using UnityEngine;
private sealed class JSONNode.<get_Children>d__29 : IEnumerable<Umeng.JSONNode>, IEnumerable, IEnumerator<Umeng.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private Umeng.JSONNode <>2__current;
    private int <>l__initialThreadId;
    
    // Properties
    private Umeng.JSONNode System.Collections.Generic.IEnumerator<Umeng.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONNode.<get_Children>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        return false;
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
        
        JSONNode.<get_Children>d__29 val_2 = null;
        this = val_2;
        val_2 = new JSONNode.<get_Children>d__29();
        .<>1__state = 0;
        .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
        return (System.Collections.Generic.IEnumerator<Umeng.JSONNode>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<Umeng.JSONNode>.GetEnumerator();
    }

}
