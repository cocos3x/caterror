using UnityEngine;
public class TextWithCountUpInfiniteFloat : Text
{
    // Fields
    private bool isFloat;
    private bool isChineseNumerals;
    private uint decimalCount;
    private int minUnitIndex;
    private InfiniteFloat value;
    private UnityEngine.Coroutine coroutine;
    
    // Methods
    public void ChangeValue(string format, InfiniteFloat value)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.value = value;
        mem[1152921512081599560] = value.index;
        if(this.isFloat == false)
        {
            goto label_1;
        }
        
        if(this.isChineseNumerals == false)
        {
            goto label_2;
        }
        
        goto label_6;
        label_1:
        if(this.isChineseNumerals == false)
        {
            goto label_4;
        }
        
        goto label_6;
        label_2:
        goto label_6;
        label_4:
        label_6:
        this.text = System.String.Format(format:  format, arg0:  value.value);
    }
    public void CountUpAnimation(string format, InfiniteFloat toValue, float duration)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.coroutine = this._CountUpAnimation(format:  format, oldValue:  new InfiniteFloat() {value = this.value, index = toValue.index}, toValue:  new InfiniteFloat() {value = toValue.value, index = toValue.index}, duration:  duration);
    }
    private UnityEngine.Coroutine _CountUpAnimation(string format, InfiniteFloat oldValue, InfiniteFloat toValue, float duration)
    {
        var val_6;
        IntPtr val_8;
        string val_9;
        var val_10;
        TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0 val_1 = new TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                mem[1152921512081959808] = toValue.index;
            mem[1152921512081959792] = oldValue.index;
            val_6 = 1152921512081959808;
            mem[1152921512081959776] = this;
            mem[1152921512081959784] = oldValue.value;
            mem[1152921512081959800] = toValue.value;
        }
        else
        {
                mem[16] = this;
            mem[24] = oldValue.value;
            mem[32] = oldValue.index;
            val_6 = 40;
            mem[40] = toValue.value;
            mem[48] = toValue.index;
        }
        
        .format = format;
        bool val_3 = this.gameObject.activeInHierarchy;
        if(this.isFloat == false)
        {
            goto label_4;
        }
        
        if(this.isChineseNumerals == false)
        {
            goto label_5;
        }
        
        if(val_3 == false)
        {
            goto label_6;
        }
        
        val_8 = 1152921512081857680;
        goto label_12;
        label_4:
        if(this.isChineseNumerals == false)
        {
            goto label_8;
        }
        
        if(val_3 == false)
        {
            goto label_9;
        }
        
        val_8 = 1152921512081862800;
        goto label_12;
        label_5:
        if(val_3 == false)
        {
            goto label_11;
        }
        
        val_8 = 1152921512081867920;
        goto label_12;
        label_6:
        val_9 = (TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0)[1152921512081959760].format;
        val_10 = 40;
        goto label_16;
        label_8:
        if(val_3 == false)
        {
            goto label_14;
        }
        
        System.Action<System.Single> val_4 = null;
        val_8 = 1152921512081877136;
        label_12:
        val_4 = new System.Action<System.Single>(object:  val_1, method:  val_8);
        return MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  val_4);
        label_9:
        val_9 = (TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0)[1152921512081959760].format;
        val_10 = 40;
        goto label_16;
        label_11:
        val_9 = (TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0)[1152921512081959760].format;
        goto label_16;
        label_14:
        val_9 = (TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0)[1152921512081959760].format;
        val_10 = 40;
        label_16:
        this.text = System.String.Format(format:  val_9, arg0:  mem[40]);
        return 0;
    }
    public TextWithCountUpInfiniteFloat()
    {
        this.isFloat = true;
        this.decimalCount = 3;
        this.minUnitIndex = 3;
    }

}
