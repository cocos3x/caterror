using UnityEngine;
private sealed class TransitionManager.<_LoadScene>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TransitionManager <>4__this;
    public GameScenes scene;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransitionManager.<_LoadScene>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<System.ValueTuple<SceneType, GameScenes>> val_12;
        int val_13;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        System.Collections.Generic.List<System.ValueTuple<SceneType, GameScenes>> val_12 = this.<>4__this.loadedSceneList;
        val_12 = val_12.Count - 1;
        if((val_12 & 2147483648) == 0)
        {
                do
        {
            System.ValueTuple<SceneType, GameScenes> val_2 = this.<>4__this.loadedSceneList.Item[val_12];
            if(val_2.Item2 != 1)
        {
                System.ValueTuple<SceneType, GameScenes> val_3 = this.<>4__this.loadedSceneList.Item[val_12];
            UniRx.Unit..cctor();
            bool val_5 = UnityEngine.SceneManagement.SceneManager.UnloadScene(sceneName:  val_3.Item2.ToString());
            this.<>4__this.loadedSceneList.RemoveAt(index:  val_12);
        }
        
            val_12 = val_12 - 1;
        }
        while((val_12 & 2147483648) == 0);
        
        }
        
        UnityEngine.AsyncOperation val_6 = UnityEngine.Resources.UnloadUnusedAssets();
        System.GC.Collect();
        UniRx.Unit..cctor();
        mem2[0] = null;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.scene.ToString(), mode:  1);
        val_12 = this.<>4__this.loadedSceneList;
        UnityEngine.Vector2Int val_8 = new UnityEngine.Vector2Int(x:  0, y:  this.scene);
        val_12.Add(item:  new System.ValueTuple<SceneType, GameScenes>() {Item2 = val_8.m_X});
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_13;
        return (bool)val_13;
        label_1:
        this.<>1__state = 0;
        val_12 = this.scene;
        UniRx.Unit..cctor();
        mem2[0] = null;
        UnityEngine.SceneManagement.Scene val_10 = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name:  this.scene.ToString());
        val_10.m_Handle = val_10.m_Handle & 4294967295;
        bool val_11 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_10.m_Handle});
        label_2:
        val_13 = 0;
        return (bool)val_13;
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
