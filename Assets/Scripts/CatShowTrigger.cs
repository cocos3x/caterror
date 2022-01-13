using UnityEngine;
public abstract class CatShowTrigger : CatActionTrigger
{
    // Fields
    private float searchTime;
    private float hideLerpTime;
    
    // Methods
    public override UnityEngine.Coroutine SearchWait(Cat cat, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action callback)
    {
        return MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  cat, seconds:  this.searchTime, act:  callback);
    }
    public override UnityEngine.Coroutine BeginHide(Cat cat, System.Action callback)
    {
        Cat val_3 = cat;
        CatShowTrigger.<>c__DisplayClass3_0 val_1 = new CatShowTrigger.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                .cat = val_3;
            return MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_3 = mem[16], duration:  this.hideLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void CatShowTrigger.<>c__DisplayClass3_0::<BeginHide>b__0(float t)), callback:  callback);
        }
        
        mem[16] = val_3;
        return MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_3, duration:  this.hideLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void CatShowTrigger.<>c__DisplayClass3_0::<BeginHide>b__0(float t)), callback:  callback);
    }
    protected CatShowTrigger()
    {
        this.searchTime = Infinityf;
        this.hideLerpTime = 2f;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
