using UnityEngine;
public sealed class StopFeintTrigger : CatFeintTrigger
{
    // Fields
    private float showLerpTime;
    private float stopTime;
    private float hideLerpTime;
    
    // Methods
    public override void BeginShow(Cat cat, float from, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action<float> lerpShowBody, System.Action callback, System.Action feintCallback)
    {
        Cat val_5;
        var val_6;
        val_5 = cat;
        StopFeintTrigger.<>c__DisplayClass3_0 val_1 = new StopFeintTrigger.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                val_6 = val_1;
            .changeCoroutine = changeCoroutine;
            mem[1152921511894575152] = lerpShowBody;
            mem[1152921511894575168] = val_5;
            mem[1152921511894575176] = this;
            mem[1152921511894575184] = feintCallback;
        }
        else
        {
                mem[16] = lerpShowBody;
            mem[32] = val_5;
            mem[40] = this;
            mem[48] = feintCallback;
            val_6 = 56;
            mem[56] = changeCoroutine;
            val_5 = mem[32];
        }
        
        UnityEngine.Coroutine val_4 = MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_5, duration:  this.showLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void StopFeintTrigger.<>c__DisplayClass3_0::<BeginShow>b__0(float t)), callback:  new System.Action(object:  val_1, method:  System.Void StopFeintTrigger.<>c__DisplayClass3_0::<BeginShow>b__1()));
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
    public StopFeintTrigger()
    {
        this.showLerpTime = 1f;
        this.stopTime = 0f;
        this.hideLerpTime = 1f;
    }

}
