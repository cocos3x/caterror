using UnityEngine;
public class TextWithCountUpInt : Text
{
    // Fields
    private int value;
    private UnityEngine.Coroutine coroutine;
    
    // Methods
    public void ChangeValue(string format, int value)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.value = value;
        this.text = System.String.Format(format:  format, arg0:  value);
    }
    public void CountUpAnimation(string format, int toValue, float duration)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.coroutine = this._CountUpAnimation(format:  format, oldValue:  this.value, toValue:  toValue, duration:  duration);
    }
    private UnityEngine.Coroutine _CountUpAnimation(string format, int oldValue, int toValue, float duration)
    {
        TextWithCountUpInt.<>c__DisplayClass4_0 val_1 = new TextWithCountUpInt.<>c__DisplayClass4_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .oldValue = oldValue;
            .toValue = toValue;
        }
        else
        {
                mem[16] = this;
            mem[24] = oldValue;
            .toValue = toValue;
        }
        
        .format = format;
        if(this.gameObject.activeInHierarchy != false)
        {
                return MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void TextWithCountUpInt.<>c__DisplayClass4_0::<_CountUpAnimation>b__0(float lerp)));
        }
        
        this.text = System.String.Format(format:  (TextWithCountUpInt.<>c__DisplayClass4_0)[1152921512083264720].format, arg0:  (TextWithCountUpInt.<>c__DisplayClass4_0)[1152921512083264720].toValue);
        return 0;
    }
    public TextWithCountUpInt()
    {
    
    }

}
