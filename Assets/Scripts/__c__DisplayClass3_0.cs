using UnityEngine;
private sealed class SpriteColorChanger.<>c__DisplayClass3_0
{
    // Fields
    public System.Collections.Generic.List<System.ValueTuple<UnityEngine.SpriteRenderer, UnityEngine.Color>> list;
    public UnityEngine.Color color;
    
    // Methods
    public SpriteColorChanger.<>c__DisplayClass3_0()
    {
    
    }
    internal void <ChangeColorFade>b__0(UnityEngine.SpriteRenderer spriteRenderer)
    {
        UnityEngine.Color val_1 = spriteRenderer.color;
        this.list.Add(item:  new System.ValueTuple<UnityEngine.SpriteRenderer, UnityEngine.Color>() {Item2 = new UnityEngine.Color() {r = -2.048321f, g = 2.524355E-29f, b = -2.045235f, a = 2.524355E-29f}});
    }
    internal void <ChangeColorFade>b__1(float t)
    {
        var val_2;
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        var val_8 = this;
        List.Enumerator<T> val_1 = this.list.GetEnumerator();
        label_4:
        if(((-1073410824) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Color val_7 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6}, b:  new UnityEngine.Color() {r = this.color}, t:  t);
        val_2.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        goto label_4;
        label_2:
        UniRx.Unit..cctor();
    }

}
