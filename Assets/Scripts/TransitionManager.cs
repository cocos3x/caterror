using UnityEngine;
public sealed class TransitionManager : SingletonMonoBehaviour<TransitionManager>
{
    // Fields
    private System.Collections.Generic.List<System.ValueTuple<SceneType, GameScenes>> loadedSceneList;
    
    // Methods
    private void Awake()
    {
        TransitionManager val_1 = SingletonMonoBehaviour<TransitionManager>.Instance;
        UnityEngine.Coroutine val_3 = val_1.StartCoroutine(routine:  val_1._LoadScene(scene:  1));
    }
    public void LoadScene(GameScenes scene)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this._LoadScene(scene:  scene));
    }
    private System.Collections.IEnumerator _LoadScene(GameScenes scene)
    {
        TransitionManager.<_LoadScene>d__3 val_1 = new TransitionManager.<_LoadScene>d__3();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .scene = scene;
        return (System.Collections.IEnumerator)val_1;
    }
    public void LoadSceneAdditive(GameScenes scene, SceneType sceneType = 0)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this._LoadSceneAdditive(scene:  scene, sceneType:  sceneType));
    }
    private System.Collections.IEnumerator _LoadSceneAdditive(GameScenes scene, SceneType sceneType)
    {
        TransitionManager.<_LoadSceneAdditive>d__5 val_1 = new TransitionManager.<_LoadSceneAdditive>d__5();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .scene = scene;
        }
        else
        {
                mem[40] = this;
            mem[32] = scene;
        }
        
        .sceneType = sceneType;
        return (System.Collections.IEnumerator)val_1;
    }
    public void UnloadScene(GameScenes scene)
    {
        null = null;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this._UnloadScene(scene:  scene, callback:  ActionExtensions.EmptyAction));
    }
    public void UnloadScene(GameScenes scene, System.Action callback)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this._UnloadScene(scene:  scene, callback:  callback));
    }
    private System.Collections.IEnumerator _UnloadScene(GameScenes scene, System.Action callback)
    {
        TransitionManager.<_UnloadScene>d__8 val_1 = new TransitionManager.<_UnloadScene>d__8();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .scene = scene;
        }
        else
        {
                mem[40] = this;
            mem[32] = scene;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator _ResetScene()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new TransitionManager.<_ResetScene>d__9();
    }
    public bool Exists(GameScenes scene)
    {
        var val_4;
        List.Enumerator<T> val_1 = this.loadedSceneList.GetEnumerator();
        label_3:
        if(((-1217258008) & 1) == 0)
        {
            goto label_2;
        }
        
        if((0.Id >> 32) != scene)
        {
            goto label_3;
        }
        
        val_4 = 1;
        goto label_4;
        label_2:
        val_4 = 0;
        label_4:
        UniRx.Unit..cctor();
        return (bool);
    }
    public TransitionManager()
    {
        this.loadedSceneList = new System.Collections.Generic.List<System.ValueTuple<SceneType, GameScenes>>();
    }

}
