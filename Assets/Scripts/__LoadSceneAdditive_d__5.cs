using UnityEngine;
private sealed class TransitionManager.<_LoadSceneAdditive>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameScenes scene;
    public TransitionManager <>4__this;
    public SceneType sceneType;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransitionManager.<_LoadSceneAdditive>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UniRx.Unit..cctor();
        this.scene = null;
        val_4 = 1;
        this.<>2__current = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  this.scene.ToString(), mode:  1);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Vector2Int val_3 = new UnityEngine.Vector2Int(x:  this.sceneType, y:  this.scene);
        this.<>4__this.loadedSceneList.Add(item:  new System.ValueTuple<SceneType, GameScenes>() {Item2 = val_3.m_X});
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
