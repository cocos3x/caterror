using UnityEngine;
private sealed class CustomFadeMaterial.<>c__DisplayClass7_1
{
    // Fields
    public float from;
    public CustomFadeMaterial.<>c__DisplayClass7_0 CS$<>8__locals1;
    
    // Methods
    public CustomFadeMaterial.<>c__DisplayClass7_1()
    {
    
    }
    internal void <Change>b__1(float lerp)
    {
        this.CS$<>8__locals1.<>4__this.material.SetFloat(nameID:  this.CS$<>8__locals1.<>4__this.material_TexLerp, value:  UnityEngine.Mathf.Lerp(a:  this.from, b:  1f, t:  lerp));
    }

}
