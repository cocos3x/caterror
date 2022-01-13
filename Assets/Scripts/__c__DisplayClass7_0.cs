using UnityEngine;
private sealed class CustomFadeMaterial.<>c__DisplayClass7_0
{
    // Fields
    public CustomFadeMaterial <>4__this;
    public UnityEngine.Sprite sprite;
    public System.Action callback;
    
    // Methods
    public CustomFadeMaterial.<>c__DisplayClass7_0()
    {
    
    }
    internal void <Change>b__0()
    {
        var val_3;
        CustomFadeMaterial val_4;
        val_3 = null;
        val_3 = null;
        this.<>4__this.changeCallback = ActionExtensions.EmptyAction;
        this.<>4__this.material.SetTexture(name:  "_MainTex", value:  this.sprite.texture);
        val_4 = this.<>4__this;
        if((this.<>4__this) != null)
        {
            goto label_7;
        }
        
        val_4 = this.<>4__this;
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_7:
        this.<>4__this.material.SetFloat(nameID:  this.<>4__this.material_TexLerp, value:  0f);
        if((this.<>4__this.spriteRenderer) != 0)
        {
                this.<>4__this.spriteRenderer.sprite = this.sprite;
        }
        
        this.callback.Invoke();
        return;
        label_8:
    }

}
