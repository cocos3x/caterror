using UnityEngine;
public class ShaderResetter : MonoBehaviour
{
    // Fields
    private ShaderResetter.ResetTarget[] resetTargets;
    private bool reseted;
    
    // Methods
    private void Awake()
    {
        if(this.reseted != true)
        {
                this.Reset();
        }
        
        UnityEngine.Object.Destroy(obj:  this);
    }
    public void Reset()
    {
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        val_6 = 0;
        goto label_1;
        label_22:
        val_7 = 64;
        val_5 = 37160040;
        UnityEngine.Shader val_1 = UnityEngine.Shader.Find(name:  val_7);
        if(val_1 == 0)
        {
            goto label_5;
        }
        
        val_8 = 0;
        goto label_6;
        label_11:
        val_7 = 270.sharedMaterial;
        val_7.shader = val_1;
        val_8 = 1;
        label_6:
        if(val_8 < 0)
        {
            goto label_11;
        }
        
        val_5 = 0;
        goto label_12;
        label_17:
        val_7 = mem[15762873573703712];
        val_7.shader = val_1;
        val_5 = 1;
        label_12:
        if(val_5 < mem[15762873573703704])
        {
            goto label_17;
        }
        
        goto label_18;
        label_5:
        UnityEngine.Debug.LogWarning(message:  val_7 + " not exists shader.");
        label_18:
        val_6 = 1;
        label_1:
        if(val_6 < this.resetTargets.Length)
        {
            goto label_22;
        }
        
        mem[1152921512120734880] = 1;
    }
    public ShaderResetter()
    {
    
    }

}
