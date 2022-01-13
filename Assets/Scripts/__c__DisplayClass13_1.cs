using UnityEngine;
private sealed class PageScrollRect.<>c__DisplayClass13_1
{
    // Fields
    public float from;
    public PageScrollRect.<>c__DisplayClass13_0 CS$<>8__locals1;
    
    // Methods
    public PageScrollRect.<>c__DisplayClass13_1()
    {
    
    }
    internal void <ChangePage>b__0(float t)
    {
        UnityEngine.Vector2 val_3 = this.CS$<>8__locals1.<>4__this.content.anchoredPosition;
        UnityEngine.Vector2 val_6 = Vector2Extensions.SetX(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, f:  UnityEngine.Mathf.Lerp(a:  this.from, b:  this.CS$<>8__locals1.destX, t:  t * t));
        this.CS$<>8__locals1.<>4__this.content.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }

}
