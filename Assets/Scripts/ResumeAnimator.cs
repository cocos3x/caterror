using UnityEngine;
public class ResumeAnimator : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator anim;
    private ResumeAnimator.LayerInfo[] layerInfo;
    private object[] parameters;
    private AnimatorParameter parameter;
    
    // Methods
    private void Awake()
    {
        LayerInfo[] val_4;
        var val_5;
        UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
        this.anim = val_1;
        int val_2 = val_1.layerCount;
        val_4 = new LayerInfo[0];
        val_5 = 0;
        this.layerInfo = val_4;
        goto label_2;
        label_6:
        this.layerInfo[0] = 0;
        val_4 = this.layerInfo;
        val_5 = 1;
        label_2:
        if(val_5 < this.layerInfo.Length)
        {
            goto label_6;
        }
    
    }
    private void OnEnable()
    {
        this.Restore();
    }
    public void Restore()
    {
        var val_3;
        UnityEngine.Animator val_4;
        var val_5;
        val_3 = 0;
        goto label_1;
        label_6:
        this.anim.Play(stateNameHash:  this.layerInfo[0], layer:  0, normalizedTime:  this.layerInfo[0]);
        val_3 = 1;
        label_1:
        val_4 = this.anim;
        if(val_3 < val_4.layerCount)
        {
            goto label_6;
        }
        
        if(this.parameter == 0)
        {
                return;
        }
        
        if(this.parameters == null)
        {
                return;
        }
        
        val_5 = 0;
        goto label_11;
        label_32:
        if(this.parameters[0] == null)
        {
            goto label_26;
        }
        
        val_4 = this.parameter.parameterInfos[0];
        this.parameter.parameterInfos[0] = val_4 - 1;
        if(this.parameter.parameterInfos[0] > 3)
        {
            goto label_26;
        }
        
        var val_6 = 28871376 + ((this.parameter.parameterInfos[0x0][0] - 1)) << 2;
        val_6 = val_6 + 28871376;
        goto (28871376 + ((this.parameter.parameterInfos[0x0][0] - 1)) << 2 + 28871376);
        label_26:
        val_5 = 1;
        label_11:
        if(val_5 < this.parameter.parameterInfos.Length)
        {
            goto label_32;
        }
    
    }
    public void Save()
    {
        LayerInfo val_8;
        var val_18;
        LayerInfo[] val_19;
        UnityEngine.Animator val_20;
        var val_21;
        val_18 = 0;
        goto label_1;
        label_9:
        UnityEngine.AnimatorStateInfo val_1 = this.anim.GetCurrentAnimatorStateInfo(layerIndex:  0);
        this.layerInfo[0] = ;
        val_19 = this.layerInfo;
        UnityEngine.AnimatorStateInfo val_5 = this.anim.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_18 = 1;
        val_19[0] = val_8;
        label_1:
        val_20 = this.anim;
        if(val_18 < val_20.layerCount)
        {
            goto label_9;
        }
        
        if(this.parameter == 0)
        {
                return;
        }
        
        if(this.parameters == null)
        {
                this.parameters = new object[0];
        }
        
        val_21 = 0;
        val_19 = 28871392;
        goto label_16;
        label_34:
        if((this.parameter.parameterInfos[0] - 1) > 3)
        {
            goto label_20;
        }
        
        var val_18 = val_19 + ((this.parameter.parameterInfos[0x0][0] - 1)) << 2;
        val_18 = val_18 + val_19;
        goto (val_19 + ((this.parameter.parameterInfos[0x0][0] - 1)) << 2 + val_19);
        label_20:
        val_21 = 1;
        label_16:
        if(val_21 < this.parameter.parameterInfos.Length)
        {
            goto label_34;
        }
    
    }
    public static void RestoreAnimator(UnityEngine.GameObject target)
    {
        goto label_2;
        label_6:
        target.GetComponentsInChildren<ResumeAnimator>()[0].Save();
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_6;
        }
    
    }
    public ResumeAnimator()
    {
    
    }

}
