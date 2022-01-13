using UnityEngine;
public class UVScroller : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector2 scrollSpeed;
    private UnityEngine.Vector2 defaultOffset;
    private UnityEngine.Renderer _renderer;
    private UnityEngine.Vector2 uv;
    
    // Methods
    private void Awake()
    {
        this.uv = this.defaultOffset;
        mem[1152921512132470852] = ???;
    }
    private void Update()
    {
        float val_6;
        float val_7;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = this.scrollSpeed, y = V11.16B}, d:  UnityEngine.Time.smoothDeltaTime);
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.uv, y = V9.16B}, b:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        val_6 = 1f;
        val_7 = -1f;
        this.uv = val_3;
        mem[1152921512132591044] = val_3.y;
        if(val_3.x >= val_6)
        {
            goto label_3;
        }
        
        if(val_3.x > val_7)
        {
            goto label_4;
        }
        
        val_7 = 1f;
        label_3:
        val_3.x = val_3.x + val_7;
        this.uv = val_3.x;
        label_4:
        if(val_3.y >= val_6)
        {
            goto label_5;
        }
        
        if(val_3.y <= (-1f))
        {
            goto label_6;
        }
        
        goto label_7;
        label_5:
        val_6 = -1f;
        label_6:
        mem[1152921512132591044] = val_3.y + val_6;
        label_7:
        this._renderer.material.SetTextureOffset(name:  "_MainTex", value:  new UnityEngine.Vector2() {x = this.uv, y = V9.16B});
    }
    public UVScroller()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.scrollSpeed = val_1;
        mem[1152921512132711212] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.defaultOffset = val_2;
        mem[1152921512132711220] = val_2.y;
    }

}
