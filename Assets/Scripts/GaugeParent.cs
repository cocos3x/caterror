using UnityEngine;
public abstract class GaugeParent : MonoBehaviour
{
    // Fields
    protected UnityEngine.Coroutine coroutine;
    protected float percentage;
    
    // Properties
    public float Percentage { get; }
    
    // Methods
    public float get_Percentage()
    {
        return (float)this.percentage;
    }
    public virtual void Initialize(float percentage)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        goto typeof(GaugeParent).__il2cppRuntimeField_178;
    }
    public void GaugeAnimation(float toParcentage, float duration)
    {
        this.GaugeAnimation(fromPercentage:  this.percentage, toParcentage:  toParcentage, duration:  duration);
    }
    public void GaugeAnimation(float fromPercentage, float toParcentage, float duration)
    {
        GaugeParent.<>c__DisplayClass6_0 val_1 = new GaugeParent.<>c__DisplayClass6_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .fromPercentage = fromPercentage;
        }
        else
        {
                mem[16] = this;
            mem[24] = fromPercentage;
        }
        
        .toParcentage = toParcentage;
        if(this.gameObject.activeInHierarchy != false)
        {
                MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
            this.coroutine = MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void GaugeParent.<>c__DisplayClass6_0::<GaugeAnimation>b__0(float lerp)), callback:  new System.Action(object:  val_1, method:  System.Void GaugeParent.<>c__DisplayClass6_0::<GaugeAnimation>b__1()));
        }
    
    }
    public abstract void UpdateGauge(float percentage); // 0
    protected GaugeParent()
    {
    
    }

}
