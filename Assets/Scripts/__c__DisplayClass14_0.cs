using UnityEngine;
private sealed class FadeManager.<>c__DisplayClass14_0
{
    // Fields
    public FadeManager <>4__this;
    public float interval;
    public System.Action callback;
    
    // Methods
    public FadeManager.<>c__DisplayClass14_0()
    {
    
    }
    internal void <FadeIn>b__0(float t)
    {
        this.<>4__this.fadeAlpha = UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  t / this.interval);
        if(this.interval > t)
        {
                return;
        }
        
        this.<>4__this.isFading = false;
        this.<>4__this.onFadeInEnd.Invoke();
        this.callback.Invoke();
    }

}
