using UnityEngine;
public class TextWithCountUpFloat : Text
{
    // Fields
    private float value;
    private UnityEngine.Coroutine coroutine;
    
    // Methods
    public void ChangeValue(string format, float value)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.value = value;
        this.text = System.String.Format(format:  format, arg0:  value);
    }
    public void CountUpAnimation(string format, float toValue, float duration)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.coroutine = this._CountUpAnimation(format:  format, oldValue:  this.value, toValue:  toValue, duration:  duration);
    }
    private UnityEngine.Coroutine _CountUpAnimation(string format, float oldValue, float toValue, float duration)
    {
        var val_6;
        TextWithCountUpFloat.<>c__DisplayClass4_0 val_1 = new TextWithCountUpFloat.<>c__DisplayClass4_0();
        if(val_1 != null)
        {
                val_6 = val_1;
            .toValue = toValue;
            mem[1152921512081100384] = this;
            mem[1152921512081100392] = oldValue;
        }
        else
        {
                mem[16] = this;
            mem[24] = oldValue;
            val_6 = val_1;
            .toValue = toValue;
        }
        
        .format = format;
        if(this.gameObject.activeInHierarchy != false)
        {
                return MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void TextWithCountUpFloat.<>c__DisplayClass4_0::<_CountUpAnimation>b__0(float lerp)));
        }
        
        this.text = System.String.Format(format:  (TextWithCountUpFloat.<>c__DisplayClass4_0)[1152921512081100368].format, arg0:  .toValue);
        return 0;
    }
    public TextWithCountUpFloat()
    {
    
    }

}
