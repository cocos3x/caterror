using UnityEngine;
private sealed class GoogleTranslation.<WaitForTranslations>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GoogleTranslation.<WaitForTranslations>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        int val_8;
        if((this.<>1__state) >= 2)
        {
            goto label_5;
        }
        
        this.<>1__state = 0;
        val_4 = null;
        val_4 = null;
        if(I2.Loc.GoogleTranslation.mTranslationJobs.Count <= 0)
        {
            goto label_5;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = 0;
        goto label_9;
        label_17:
        T val_4 = I2.Loc.GoogleTranslation.mTranslationJobs.ToArray()[0];
        if(val_4 != 0)
        {
                val_7 = null;
            val_7 = null;
            bool val_3 = I2.Loc.GoogleTranslation.mTranslationJobs.Remove(item:  val_4);
        }
        
        val_6 = 1;
        label_9:
        if(val_6 < val_2.Length)
        {
            goto label_17;
        }
        
        val_8 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_8;
        return (bool)val_8;
        label_5:
        val_8 = 0;
        return (bool)val_8;
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
