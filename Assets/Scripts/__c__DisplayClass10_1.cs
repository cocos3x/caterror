using UnityEngine;
private sealed class SyncButtonColor.<>c__DisplayClass10_1
{
    // Fields
    public UnityEngine.Color fromColor;
    public UnityEngine.Color targetColor;
    public SyncButtonColor.<>c__DisplayClass10_0 CS$<>8__locals1;
    
    // Methods
    public SyncButtonColor.<>c__DisplayClass10_1()
    {
    
    }
    internal void <ChangeDefaultColor>b__1(float t)
    {
        UnityEngine.Color val_2 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.fromColor}, b:  new UnityEngine.Color() {r = this.targetColor}, t:  t);
        if((this.CS$<>8__locals1.kvp.Id) == null)
        {
            
        }
    
    }

}
