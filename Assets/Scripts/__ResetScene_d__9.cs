using UnityEngine;
private sealed class TransitionManager.<_ResetScene>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TransitionManager <>4__this;
    private System.Collections.Generic.List.Enumerator<UnityEngine.Coroutine> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransitionManager.<_ResetScene>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
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
        var val_9;
        List.Enumerator<UnityEngine.Coroutine> val_10;
        List.Enumerator<UnityEngine.Coroutine> val_13;
        System.Collections.Generic.List<System.ValueTuple<SceneType, GameScenes>> val_14;
        var val_15;
        int val_16;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_35;
        }
        
        val_13 = this.<>7__wrap1;
        this.<>1__state = -3;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        System.Collections.Generic.List<UnityEngine.Coroutine> val_1 = new System.Collections.Generic.List<UnityEngine.Coroutine>();
        System.Collections.Generic.List<System.ValueTuple<SceneType, GameScenes>> val_12 = this.<>4__this.loadedSceneList;
        val_12 = val_12.Count - 1;
        if((val_12 & 2147483648) == 0)
        {
                do
        {
            val_14 = this.<>4__this.loadedSceneList;
            System.ValueTuple<SceneType, GameScenes> val_3 = val_14.Item[val_12];
            if(val_3.Item2 != 1)
        {
                System.ValueTuple<SceneType, GameScenes> val_4 = this.<>4__this.loadedSceneList.Item[val_12];
            val_15 = null;
            val_15 = null;
            null.Add(item:  this.<>4__this.StartCoroutine(routine:  this.<>4__this._UnloadScene(scene:  val_4.Item2 >> 32, callback:  ActionExtensions.EmptyAction)));
            val_14 = this.<>4__this.loadedSceneList;
            val_14.RemoveAt(index:  val_12);
        }
        
            val_12 = val_12 - 1;
        }
        while((val_12 & 2147483648) == 0);
        
        }
        
        List.Enumerator<T> val_8 = null.GetEnumerator();
        val_13 = this.<>7__wrap1;
        mem[1152921511982636360] = val_9;
        this.<>1__state = -3;
        this.<>7__wrap1 = val_10;
        label_3:
        if((val_13 & 1) != 0)
        {
                this.<>2__current = val_13.Id;
            val_16 = 1;
            this.<>1__state = val_16;
            return (bool)val_16;
        }
        
        this.<>m__Finally1();
        val_16 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_16;
        label_35:
        val_16 = 0;
        return (bool)val_16;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        UniRx.Unit..cctor();
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
