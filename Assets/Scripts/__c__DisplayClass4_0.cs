using UnityEngine;
private sealed class TextWithCountUpInt.<>c__DisplayClass4_0
{
    // Fields
    public TextWithCountUpInt <>4__this;
    public int oldValue;
    public int toValue;
    public string format;
    
    // Methods
    public TextWithCountUpInt.<>c__DisplayClass4_0()
    {
    
    }
    internal void <_CountUpAnimation>b__0(float lerp)
    {
        this.<>4__this.value = (int)UnityEngine.Mathf.Lerp(a:  (float)this.oldValue, b:  (float)this.toValue, t:  lerp);
        this.<>4__this.text = System.String.Format(format:  this.format, arg0:  this.<>4__this.value);
    }

}
