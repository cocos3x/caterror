using UnityEngine;
private sealed class ResolutionAdjustment.<Measurement>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ResolutionAdjustment <>4__this;
    private System.Collections.Generic.List<float> <list>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ResolutionAdjustment.<Measurement>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<System.Single> val_13;
        int val_18;
        val_13 = this;
        if((this.<>1__state) <= 3)
        {
                var val_12 = 28871360 + (this.<>1__state) << 2;
            val_12 = val_12 + 28871360;
        }
        else
        {
                val_18 = 0;
            return (bool)val_18;
        }
    
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
