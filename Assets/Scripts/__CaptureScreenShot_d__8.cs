using UnityEngine;
private sealed class ScreenShotManager.<_CaptureScreenShot>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ScreenShotManager <>4__this;
    public System.Action justBeforeAction;
    public System.Action justAfterAction;
    private ScreenShotManager.<>c__DisplayClass8_0 <>8__1;
    public System.Action callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ScreenShotManager.<_CaptureScreenShot>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        if((this.<>1__state) <= 4)
        {
                var val_8 = 28871408 + (this.<>1__state) << 2;
            val_8 = val_8 + 28871408;
        }
        else
        {
                val_9 = 0;
            return (bool)val_9;
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
