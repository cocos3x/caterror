using UnityEngine;
private sealed class TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0
{
    // Fields
    public TextWithCountUpInfiniteFloat <>4__this;
    public InfiniteFloat oldValue;
    public InfiniteFloat toValue;
    public string format;
    
    // Methods
    public TextWithCountUpInfiniteFloat.<>c__DisplayClass8_0()
    {
    
    }
    internal void <_CountUpAnimation>b__0(float t)
    {
        InfiniteFloat val_1 = InfiniteFloat.Lerp(a:  new InfiniteFloat() {value = this.oldValue, index = X22}, b:  new InfiniteFloat() {value = this.toValue, index = X21}, t:  t);
        this.<>4__this.value = val_1;
        mem2[0] = val_1.index;
        this.<>4__this.text = System.String.Format(format:  this.format, arg0:  this.<>4__this.value);
    }
    internal void <_CountUpAnimation>b__1(float t)
    {
        InfiniteFloat val_1 = InfiniteFloat.Lerp(a:  new InfiniteFloat() {value = this.oldValue, index = X22}, b:  new InfiniteFloat() {value = this.toValue, index = X21}, t:  t);
        this.<>4__this.value = val_1;
        mem2[0] = val_1.index;
        this.<>4__this.text = System.String.Format(format:  this.format, arg0:  this.<>4__this.value);
    }
    internal void <_CountUpAnimation>b__2(float t)
    {
        InfiniteFloat val_1 = InfiniteFloat.Lerp(a:  new InfiniteFloat() {value = this.oldValue, index = X22}, b:  new InfiniteFloat() {value = this.toValue, index = X21}, t:  t);
        this.<>4__this.value = val_1;
        mem2[0] = val_1.index;
        this.<>4__this.text = System.String.Format(format:  this.format, arg0:  this.<>4__this.value);
    }
    internal void <_CountUpAnimation>b__3(float t)
    {
        InfiniteFloat val_3;
        TextWithCountUpInfiniteFloat val_4;
        TextWithCountUpInfiniteFloat val_5;
        InfiniteFloat val_1 = InfiniteFloat.Lerp(a:  new InfiniteFloat() {value = this.oldValue, index = X22}, b:  new InfiniteFloat() {value = this.toValue, index = X21}, t:  t);
        this.<>4__this.value = val_1;
        mem2[0] = val_1.index;
        if((this.<>4__this) == null)
        {
            goto label_4;
        }
        
        val_3 = this.<>4__this.value;
        val_4 = this.<>4__this;
        val_5 = this.<>4__this;
        goto label_7;
        label_4:
        val_4 = this.<>4__this;
        val_3 = this.<>4__this.value;
        if(val_4 == null)
        {
            goto label_6;
        }
        
        val_5 = val_4;
        goto label_7;
        label_6:
        val_5 = this.<>4__this;
        if(val_5 == null)
        {
            goto label_8;
        }
        
        label_7:
        this.<>4__this.text = System.String.Format(format:  this.format, arg0:  val_3);
        return;
        label_8:
    }

}
