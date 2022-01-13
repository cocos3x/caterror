using UnityEngine;
public class Background : MonoBehaviour
{
    // Fields
    private UnityEngine.SpriteRenderer[] backSpriteRendererArray;
    private UnityEngine.SpriteRenderer[] spriteRenderer1Array;
    private UnityEngine.SpriteRenderer[] spriteRenderer2Array;
    private UnityEngine.SpriteRenderer[] spriteRenderer3Array;
    private UnityEngine.Transform frontTableParent;
    private UnityEngine.Transform middleTableParent;
    private UnityEngine.Transform backTableParent;
    
    // Properties
    public UnityEngine.Transform FrontTableParent { get; }
    public UnityEngine.Transform MiddleTableParent { get; }
    public UnityEngine.Transform BackTableParent { get; }
    
    // Methods
    public UnityEngine.Transform get_FrontTableParent()
    {
        return (UnityEngine.Transform)this.frontTableParent;
    }
    public UnityEngine.Transform get_MiddleTableParent()
    {
        return (UnityEngine.Transform)this.middleTableParent;
    }
    public UnityEngine.Transform get_BackTableParent()
    {
        return (UnityEngine.Transform)this.backTableParent;
    }
    public void Initialize(BackgroundData backgroundData)
    {
        var val_5;
        float val_6;
        float val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = 0;
        goto label_0;
        label_5:
        UnityEngine.Color val_1 = 0.StringToColor(str:  backgroundData.backColor);
        val_6 = val_1.r;
        val_7 = val_1.b;
        this.backSpriteRendererArray[0].color = new UnityEngine.Color() {r = val_6, g = val_1.g, b = val_7, a = val_1.a};
        val_5 = 1;
        label_0:
        if(val_5 < this.backSpriteRendererArray.Length)
        {
            goto label_5;
        }
        
        val_8 = 0;
        goto label_6;
        label_11:
        UnityEngine.Color val_2 = 0.StringToColor(str:  backgroundData.spriteColor1);
        val_6 = val_2.r;
        val_7 = val_2.b;
        this.spriteRenderer1Array[0].color = new UnityEngine.Color() {r = val_6, g = val_2.g, b = val_7, a = val_2.a};
        val_8 = 1;
        label_6:
        if(val_8 < this.spriteRenderer1Array.Length)
        {
            goto label_11;
        }
        
        val_9 = 0;
        goto label_12;
        label_17:
        UnityEngine.Color val_3 = 0.StringToColor(str:  backgroundData.spriteColor2);
        val_6 = val_3.r;
        val_7 = val_3.b;
        this.spriteRenderer2Array[0].color = new UnityEngine.Color() {r = val_6, g = val_3.g, b = val_7, a = val_3.a};
        val_9 = 1;
        label_12:
        if(val_9 < this.spriteRenderer2Array.Length)
        {
            goto label_17;
        }
        
        val_10 = 0;
        goto label_18;
        label_23:
        UnityEngine.Color val_4 = 0.StringToColor(str:  backgroundData.spriteColor3);
        val_6 = val_4.r;
        val_7 = val_4.b;
        this.spriteRenderer3Array[0].color = new UnityEngine.Color() {r = val_6, g = val_4.g, b = val_7, a = val_4.a};
        val_10 = 1;
        label_18:
        if(val_10 < this.spriteRenderer3Array.Length)
        {
            goto label_23;
        }
    
    }
    public Background()
    {
    
    }

}
