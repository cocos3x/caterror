using UnityEngine;
private sealed class SyncButtonPressedColor.<>c__DisplayClass11_1
{
    // Fields
    public UnityEngine.UI.Graphic graphic;
    public UnityEngine.Color fromColor;
    public UnityEngine.Color targetColor;
    
    // Methods
    public SyncButtonPressedColor.<>c__DisplayClass11_1()
    {
    
    }
    internal void <ChangeColor>b__2(float t)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.fromColor}, b:  new UnityEngine.Color() {r = this.targetColor}, t:  t);
        if(this.graphic == null)
        {
            
        }
    
    }

}
