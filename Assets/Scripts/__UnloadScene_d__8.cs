using UnityEngine;
private sealed class TransitionManager.<_UnloadScene>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameScenes scene;
    public TransitionManager <>4__this;
    private TransitionManager.<>c__DisplayClass8_0 <>8__1;
    public System.Action callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransitionManager.<_UnloadScene>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_7;
        GameScenes val_8;
        int val_9;
        System.Collections.Generic.List<System.ValueTuple<SceneType, GameScenes>> val_10;
        var val_11;
        val_7 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new TransitionManager.<>c__DisplayClass8_0();
        .scene = this.scene;
        val_8 = this.<>8__1.scene;
        UniRx.Unit..cctor();
        mem2[0] = null;
        this.<>2__current = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  this.<>8__1.scene.ToString());
        val_9 = 1;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
                val_10 = this.<>4__this.loadedSceneList;
            val_11 = val_10;
        }
        else
        {
                val_11 = 7783104;
            val_10 = 7783104;
        }
        
        System.ValueTuple<SceneType, GameScenes> val_5 = val_10.Find(match:  new System.Predicate<System.ValueTuple<SceneType, GameScenes>>(object:  this.<>8__1, method:  System.Boolean TransitionManager.<>c__DisplayClass8_0::<_UnloadScene>b__0(System.ValueTuple<SceneType, GameScenes> t)));
        val_8 = val_5.Item2;
        bool val_6 = val_11.Remove(item:  new System.ValueTuple<SceneType, GameScenes>() {Item2 = val_8});
        val_7 = this.callback;
        val_7.Invoke();
        label_2:
        val_9 = 0;
        return (bool)val_9;
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
