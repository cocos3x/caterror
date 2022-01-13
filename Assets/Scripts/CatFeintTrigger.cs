using UnityEngine;
public abstract class CatFeintTrigger : CatActionTrigger
{
    // Methods
    public override UnityEngine.Coroutine BeginSearch(Cat cat, System.Action callback)
    {
        return 0;
    }
    public override UnityEngine.Coroutine SearchWait(Cat cat, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action callback)
    {
        return 0;
    }
    public override UnityEngine.Coroutine BeginHide(Cat cat, System.Action callback)
    {
        return 0;
    }
    protected CatFeintTrigger()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
