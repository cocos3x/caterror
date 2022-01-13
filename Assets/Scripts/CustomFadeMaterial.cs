using UnityEngine;
public class CustomFadeMaterial : MonoBehaviour
{
    // Fields
    private int material_TexLerp;
    private UnityEngine.Material material;
    private UnityEngine.Coroutine coroutine;
    private UnityEngine.SpriteRenderer spriteRenderer;
    private System.Action changeCallback;
    
    // Methods
    private void Awake()
    {
        this.material_TexLerp = UnityEngine.Shader.PropertyToID(name:  "_TexLerp");
        bool val_4 = TransformExtensions.FindComponent<UnityEngine.UI.Image>(t:  this.transform, func:  new System.Action<UnityEngine.UI.Image>(object:  this, method:  System.Void CustomFadeMaterial::<Awake>b__5_0(UnityEngine.UI.Image image)));
        bool val_7 = TransformExtensions.FindComponent<UnityEngine.SpriteRenderer>(t:  this.transform, func:  new System.Action<UnityEngine.SpriteRenderer>(object:  this, method:  System.Void CustomFadeMaterial::<Awake>b__5_1(UnityEngine.SpriteRenderer sr)));
    }
    public void Change(UnityEngine.Sprite sprite, float duration)
    {
        null = null;
        this.Change(sprite:  sprite, duration:  duration, callback:  ActionExtensions.EmptyAction);
    }
    public void Change(UnityEngine.Sprite sprite, float duration, System.Action callback)
    {
        UnityEngine.Sprite val_10;
        var val_11;
        UnityEngine.Material val_12;
        CustomFadeMaterial.<>c__DisplayClass7_0 val_1 = new CustomFadeMaterial.<>c__DisplayClass7_0();
        if(val_1 != null)
        {
                val_10 = val_1;
            .sprite = sprite;
            mem[1152921512092587072] = this;
        }
        else
        {
                mem[16] = this;
            val_10 = 24;
            mem[24] = sprite;
        }
        
        .callback = callback;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        if(this.gameObject.activeInHierarchy == false)
        {
            goto label_4;
        }
        
        CustomFadeMaterial.<>c__DisplayClass7_1 val_4 = new CustomFadeMaterial.<>c__DisplayClass7_1();
        if(val_4 == null)
        {
            goto label_5;
        }
        
        val_11 = val_4;
        .CS$<>8__locals1 = val_1;
        val_12 = this.material;
        goto label_6;
        label_4:
        this.Change(sprite:  val_10);
        (CustomFadeMaterial.<>c__DisplayClass7_0)[1152921512092587056].callback.Invoke();
        return;
        label_5:
        val_11 = 24;
        mem[24] = val_1;
        val_12 = this.material;
        label_6:
        val_12.SetTexture(name:  "_SubTex", value:  .sprite.texture);
        float val_6 = this.material.GetFloat(nameID:  this.material_TexLerp);
        if(val_4 != null)
        {
                .from = val_6;
        }
        else
        {
                mem[16] = val_6;
        }
        
        this.changeCallback = new System.Action(object:  val_1, method:  System.Void CustomFadeMaterial.<>c__DisplayClass7_0::<Change>b__0());
        this.coroutine = MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_4, method:  System.Void CustomFadeMaterial.<>c__DisplayClass7_1::<Change>b__1(float lerp)), callback:  this.changeCallback);
    }
    public void ChangeImmidiate(UnityEngine.Sprite sprite)
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.Change(sprite:  sprite);
    }
    private void Change(UnityEngine.Sprite sprite)
    {
        this.material.SetTexture(name:  "_SubTex", value:  sprite.texture);
        this.material.SetTexture(name:  "_MainTex", value:  sprite.texture);
        if(this.spriteRenderer == 0)
        {
                return;
        }
        
        this.spriteRenderer.sprite = sprite;
    }
    private void OnDisable()
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.changeCallback.Invoke();
    }
    public CustomFadeMaterial()
    {
        null = null;
        this.changeCallback = ActionExtensions.EmptyAction;
    }
    private void <Awake>b__5_0(UnityEngine.UI.Image image)
    {
        this.material = image;
    }
    private void <Awake>b__5_1(UnityEngine.SpriteRenderer sr)
    {
        this.spriteRenderer = sr;
        this.material = sr.material;
    }

}
