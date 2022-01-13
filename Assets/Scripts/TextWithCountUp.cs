using UnityEngine;
public class TextWithCountUp : Text
{
    // Fields
    private UnityEngine.Coroutine coroutine;
    
    // Methods
    public void CountUpAnimation(string format, int oldCount, int count, float duration)
    {
        if(this.gameObject.activeInHierarchy != false)
        {
                MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
            this.coroutine = this._CountUpAnimation(format:  format, oldCount:  oldCount, count:  count, duration:  duration);
            return;
        }
        
        this.text = System.String.Format(format:  format, arg0:  count);
    }
    private UnityEngine.Coroutine _CountUpAnimation(string format, int oldCount, int count, float duration)
    {
        TextWithCountUp.<>c__DisplayClass2_0 val_1 = new TextWithCountUp.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .format = format;
            .oldCount = oldCount;
        }
        else
        {
                mem[16] = this;
            mem[24] = format;
            mem[32] = oldCount;
        }
        
        .count = count;
        return MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void TextWithCountUp.<>c__DisplayClass2_0::<_CountUpAnimation>b__0(float lerp)), callback:  new System.Action(object:  val_1, method:  System.Void TextWithCountUp.<>c__DisplayClass2_0::<_CountUpAnimation>b__1()));
    }
    public void CountUpAnimation(string format, float oldCount, float count, float duration)
    {
        if(this.gameObject.activeInHierarchy != false)
        {
                MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
            this.coroutine = this._CountUpAnimation(format:  format, oldCount:  oldCount, count:  count, duration:  duration);
            return;
        }
        
        this.text = System.String.Format(format:  format, arg0:  count);
    }
    private UnityEngine.Coroutine _CountUpAnimation(string format, float oldCount, float count, float duration)
    {
        TextWithCountUp.<>c__DisplayClass4_0 val_1 = new TextWithCountUp.<>c__DisplayClass4_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .format = format;
            .oldCount = oldCount;
        }
        else
        {
                mem[16] = this;
            mem[24] = format;
            mem[32] = oldCount;
        }
        
        .count = count;
        return MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void TextWithCountUp.<>c__DisplayClass4_0::<_CountUpAnimation>b__0(float lerp)), callback:  new System.Action(object:  val_1, method:  System.Void TextWithCountUp.<>c__DisplayClass4_0::<_CountUpAnimation>b__1()));
    }
    public TextWithCountUp()
    {
    
    }

}
