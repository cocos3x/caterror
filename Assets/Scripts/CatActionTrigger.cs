using UnityEngine;
public abstract class CatActionTrigger : MonoBehaviour
{
    // Fields
    private bool isUsed;
    
    // Properties
    public bool IdUsed { get; }
    
    // Methods
    public bool get_IdUsed()
    {
        return (bool)this.isUsed;
    }
    public void Use()
    {
        this.isUsed = true;
    }
    public abstract void BeginShow(Cat cat, float from, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action<float> lerpShowBody, System.Action callback, System.Action feintCallback); // 0
    public abstract UnityEngine.Coroutine BeginSearch(Cat cat, System.Action callback); // 0
    public abstract UnityEngine.Coroutine SearchWait(Cat cat, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action callback); // 0
    public abstract UnityEngine.Coroutine BeginHide(Cat cat, System.Action callback); // 0
    protected CatActionTrigger()
    {
    
    }

}
