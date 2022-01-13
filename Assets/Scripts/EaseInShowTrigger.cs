using UnityEngine;
public sealed class EaseInShowTrigger : CatShowTrigger
{
    // Fields
    private float showLerpTime;
    private float searchLerpTime;
    
    // Methods
    public override void BeginShow(Cat cat, float from, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action<float> lerpShowBody, System.Action callback, System.Action feintCallback)
    {
        .lerpShowBody = lerpShowBody;
        changeCoroutine.Invoke(obj:  MonoBehaviourExtensions.CallLerp(monoBehaviour:  cat, duration:  this.showLerpTime, act:  new System.Action<System.Single>(object:  new EaseInShowTrigger.<>c__DisplayClass2_0(), method:  System.Void EaseInShowTrigger.<>c__DisplayClass2_0::<BeginShow>b__0(float t)), callback:  callback));
    }
    public override UnityEngine.Coroutine BeginSearch(Cat cat, System.Action callback)
    {
        Cat val_3 = cat;
        EaseInShowTrigger.<>c__DisplayClass3_0 val_1 = new EaseInShowTrigger.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                .cat = val_3;
            return MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_3 = mem[16], duration:  this.searchLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void EaseInShowTrigger.<>c__DisplayClass3_0::<BeginSearch>b__0(float t)), callback:  callback);
        }
        
        mem[16] = val_3;
        return MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_3, duration:  this.searchLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void EaseInShowTrigger.<>c__DisplayClass3_0::<BeginSearch>b__0(float t)), callback:  callback);
    }
    public EaseInShowTrigger()
    {
        this.showLerpTime = 3f;
        this.searchLerpTime = 2f;
    }

}
