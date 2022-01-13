using UnityEngine;
public sealed class DefaultShowFindTrigger : CatShowTrigger
{
    // Fields
    private float showLerpTime;
    private float searchLerpTime;
    private float beginFindTime;
    private float findMoveSpeed;
    private bool isFirstMoveRight;
    private float initialFindAngle;
    private float findAngle;
    private float findWaitTime;
    
    // Methods
    public override void BeginShow(Cat cat, float from, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action<float> lerpShowBody, System.Action callback, System.Action feintCallback)
    {
        .lerpShowBody = lerpShowBody;
        changeCoroutine.Invoke(obj:  MonoBehaviourExtensions.CallLerp(monoBehaviour:  cat, duration:  this.showLerpTime, act:  new System.Action<System.Single>(object:  new DefaultShowFindTrigger.<>c__DisplayClass8_0(), method:  System.Void DefaultShowFindTrigger.<>c__DisplayClass8_0::<BeginShow>b__0(float t)), callback:  callback));
    }
    public override UnityEngine.Coroutine BeginSearch(Cat cat, System.Action callback)
    {
        Cat val_3;
        UnityEngine.MonoBehaviour val_4;
        val_3 = cat;
        DefaultShowFindTrigger.<>c__DisplayClass9_0 val_1 = new DefaultShowFindTrigger.<>c__DisplayClass9_0();
        if(val_1 != null)
        {
                val_4 = val_1;
            .cat = val_3;
        }
        else
        {
                val_4 = 16;
            mem[16] = val_3;
            val_3 = mem[16];
        }
        
        mem2[0] = this.initialFindAngle;
        return MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_4, duration:  this.searchLerpTime, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void DefaultShowFindTrigger.<>c__DisplayClass9_0::<BeginSearch>b__0(float t)), callback:  callback);
    }
    public override UnityEngine.Coroutine SearchWait(Cat cat, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action callback)
    {
        Cat val_3 = cat;
        DefaultShowFindTrigger.<>c__DisplayClass10_0 val_1 = new DefaultShowFindTrigger.<>c__DisplayClass10_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .cat = val_3;
            .changeCoroutine = changeCoroutine;
            return MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  val_3 = mem[24], seconds:  this.beginFindTime, act:  new System.Action(object:  val_1, method:  System.Void DefaultShowFindTrigger.<>c__DisplayClass10_0::<SearchWait>b__0()));
        }
        
        mem[16] = this;
        mem[24] = val_3;
        mem[32] = changeCoroutine;
        return MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  val_3, seconds:  this.beginFindTime, act:  new System.Action(object:  val_1, method:  System.Void DefaultShowFindTrigger.<>c__DisplayClass10_0::<SearchWait>b__0()));
    }
    private void Find(Cat cat, System.Action<UnityEngine.Coroutine> changeCoroutine)
    {
        Cat val_4;
        System.Action<UnityEngine.Coroutine> val_5;
        float val_6;
        bool val_7;
        val_4 = cat;
        DefaultShowFindTrigger.<>c__DisplayClass11_0 val_1 = new DefaultShowFindTrigger.<>c__DisplayClass11_0();
        if(val_1 != null)
        {
                val_5 = val_1;
            .changeCoroutine = changeCoroutine;
            mem[1152921511890638648] = val_4;
            mem[1152921511890638656] = this;
            val_6 = this.findAngle;
            val_7 = this.isFirstMoveRight;
        }
        else
        {
                val_5 = 16;
            mem[16] = changeCoroutine;
            mem[24] = val_4;
            mem[32] = this;
            val_4 = mem[24];
            val_6 = this.findAngle;
            val_7 = this.isFirstMoveRight;
        }
        
        float val_3 = (val_7 == true) ? 1f : -1f;
        val_3 = -(val_6 * val_3);
        this.FindMove(cat:  val_4, toAngle:  val_3, changeCoroutine:  val_5, callback:  new System.Action(object:  val_1, method:  System.Void DefaultShowFindTrigger.<>c__DisplayClass11_0::<Find>b__0()));
    }
    private void FindMove(Cat cat, float toAngle, System.Action<UnityEngine.Coroutine> changeCoroutine, System.Action callback)
    {
        float val_4;
        Cat val_5;
        float val_6;
        DefaultShowFindTrigger.<>c__DisplayClass12_0 val_1 = new DefaultShowFindTrigger.<>c__DisplayClass12_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .cat = cat;
        mem[1152921511890796732] = toAngle;
        if(cat != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        if(val_1 == null)
        {
            goto label_3;
        }
        
        val_4 = val_1;
        .fromAngle = cat.findAngle;
        val_5 = .cat;
        val_6 = mem[1152921511890796732];
        goto label_4;
        label_1:
        mem[16] = cat;
        .toAngle = toAngle;
        if(mem[16] != 0)
        {
            goto label_5;
        }
        
        goto label_6;
        label_3:
        val_4 = 3.363116E-44f;
        mem[24] = cat.findAngle;
        val_5 = .cat;
        val_6 = .toAngle;
        label_4:
        toAngle = val_6 - val_4;
        toAngle = System.Math.Abs(toAngle) / this.findMoveSpeed;
        changeCoroutine.Invoke(obj:  MonoBehaviourExtensions.CallLerp(monoBehaviour:  val_5, duration:  toAngle, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void DefaultShowFindTrigger.<>c__DisplayClass12_0::<FindMove>b__0(float t)), callback:  callback));
    }
    public DefaultShowFindTrigger()
    {
        this.beginFindTime = 1f;
        this.findMoveSpeed = 0f;
        this.isFirstMoveRight = true;
        this.findAngle = 45f;
        this.findWaitTime = 3f;
        mem[1152921511890889020] = ;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
