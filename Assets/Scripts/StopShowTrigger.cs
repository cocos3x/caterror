using UnityEngine;
public sealed class StopShowTrigger : CatShowTrigger
{
    // Fields
    private float firstShowLerpTime;
    private float stopTime;
    private float secondShowLerpTime;
    private float searchLerpTime;
    
    // Methods
    public override void BeginShow(Cat cat, float from, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action<float> lerpShowBody, System.Action callback, System.Action feintCallback)
    {
        Cat val_5;
        var val_6;
        val_5 = cat;
        StopShowTrigger.<>c__DisplayClass4_0 val_1 = new StopShowTrigger.<>c__DisplayClass4_0();
        if(val_1 != null)
        {
                val_6 = val_1;
            .changeCoroutine = changeCoroutine;
            mem[1152921511895568048] = lerpShowBody;
            mem[1152921511895568064] = val_5;
            mem[1152921511895568072] = this;
            mem[1152921511895568080] = callback;
        }
        else
        {
                mem[16] = lerpShowBody;
            mem[32] = val_5;
            mem[40] = this;
            mem[48] = callback;
            val_6 = 56;
            mem[56] = changeCoroutine;
            val_5 = mem[32];
        }
        
        UnityEngine.Coroutine val_4 = MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_5, duration:  this.firstShowLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void StopShowTrigger.<>c__DisplayClass4_0::<BeginShow>b__0(float t)), callback:  new System.Action(object:  val_1, method:  System.Void StopShowTrigger.<>c__DisplayClass4_0::<BeginShow>b__1()));
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .coroutine = val_4;
        if(val_6 != 0)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        val_6.Invoke(obj:  val_4);
        return;
        label_3:
        mem[24] = val_4;
        if(mem[56] != 0)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    public override UnityEngine.Coroutine BeginSearch(Cat cat, System.Action callback)
    {
        Cat val_3 = cat;
        StopShowTrigger.<>c__DisplayClass5_0 val_1 = new StopShowTrigger.<>c__DisplayClass5_0();
        if(val_1 != null)
        {
                .cat = val_3;
            return MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_3 = mem[16], duration:  this.searchLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void StopShowTrigger.<>c__DisplayClass5_0::<BeginSearch>b__0(float t)), callback:  callback);
        }
        
        mem[16] = val_3;
        return MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_3, duration:  this.searchLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void StopShowTrigger.<>c__DisplayClass5_0::<BeginSearch>b__0(float t)), callback:  callback);
    }
    public StopShowTrigger()
    {
        this.firstShowLerpTime = ;
        this.stopTime = ;
        this.secondShowLerpTime = 1f;
        this.searchLerpTime = 2f;
    }

}
