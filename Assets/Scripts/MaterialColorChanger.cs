using UnityEngine;
public sealed class MaterialColorChanger : MonoBehaviour
{
    // Fields
    private UnityEngine.Color color1;
    private UnityEngine.Color color2;
    private UnityEngine.Color color3;
    private UnityEngine.Renderer _renderer;
    private UnityEngine.Color prevColor1;
    private UnityEngine.Color prevColor2;
    private UnityEngine.Color prevColor3;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Color val_10;
        UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
        this._renderer = val_1;
        UnityEngine.Color val_3 = val_1.materials[0].color;
        this.prevColor1 = val_3;
        mem[1152921512107037588] = val_3.g;
        mem[1152921512107037592] = val_3.b;
        mem[1152921512107037596] = val_3.a;
        UnityEngine.Material[] val_4 = this._renderer.materials;
        if(val_4.Length >= 2)
        {
                UnityEngine.Color val_6 = this._renderer.materials[1].color;
        }
        else
        {
                val_10 = this.color2;
        }
        
        this.prevColor2 = val_10;
        mem[1152921512107037604] = val_3.g;
        mem[1152921512107037608] = val_3.b;
        mem[1152921512107037612] = val_3.a;
        UnityEngine.Material[] val_7 = this._renderer.materials;
        if(val_7.Length >= 3)
        {
                UnityEngine.Color val_9 = this._renderer.materials[2].color;
        }
        else
        {
                val_10 = this.color3;
        }
        
        this.prevColor3 = val_10;
        mem[1152921512107037620] = val_3.g;
        mem[1152921512107037624] = val_3.b;
        mem[1152921512107037628] = val_3.a;
    }
    private void LateUpdate()
    {
        var val_7;
        float val_8;
        float val_9;
        UnityEngine.Color val_11;
        float val_14;
        float val_15;
        val_7 = this;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.color1}, rhs:  new UnityEngine.Color() {r = this.prevColor1})) != false)
        {
                val_11 = this.color1;
            val_8 = V9.16B;
            val_9 = V11.16B;
            this._renderer.materials[0].color = new UnityEngine.Color() {r = val_11, g = val_8, b = V10.16B, a = val_9};
            this.prevColor1 = this.color1;
        }
        
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.color2, g = val_8, b = V10.16B, a = val_9}, rhs:  new UnityEngine.Color() {r = this.prevColor2})) != false)
        {
                val_11 = this.color2;
            val_14 = V9.16B;
            val_15 = V11.16B;
            this._renderer.materials[1].color = new UnityEngine.Color() {r = val_11, g = val_14, b = V10.16B, a = val_15};
            this.prevColor2 = this.color2;
        }
        
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.color3, g = val_14, b = V10.16B, a = val_15}, rhs:  new UnityEngine.Color() {r = this.prevColor3})) == false)
        {
                return;
        }
        
        val_11 = this.color3;
        this._renderer.materials[2].color = new UnityEngine.Color() {r = val_11, g = V9.16B, b = V10.16B, a = V11.16B};
        this.prevColor3 = this.color3;
    }
    public MaterialColorChanger()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color1 = val_1;
        mem[1152921512107748956] = val_1.g;
        mem[1152921512107748960] = val_1.b;
        mem[1152921512107748964] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.color2 = val_2;
        mem[1152921512107748972] = val_2.g;
        mem[1152921512107748976] = val_2.b;
        mem[1152921512107748980] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.color3 = val_3;
        mem[1152921512107748988] = val_3.g;
        mem[1152921512107748992] = val_3.b;
        mem[1152921512107748996] = val_3.a;
    }

}
