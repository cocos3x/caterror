using UnityEngine;
public sealed class ObjectFallSwitchFloor : SwitchFloor
{
    // Fields
    private float fallTime;
    private float fallDelay;
    private UnityEngine.Transform[] shelterArray;
    private UnityEngine.Animator[] shelterAnimatorArray;
    private UnityEngine.GameObject shadow;
    
    // Methods
    protected override void PushSwitch()
    {
        float val_10;
        int val_11;
        this.shadow.SetActive(value:  true);
        UnityEngine.Vector3 val_1 = this.shelterArray[1].localPosition;
        val_10 = val_1.y;
        UnityEngine.Vector3 val_2 = this.shelterArray[0].localPosition;
        val_11 = 0;
        goto label_8;
        label_22:
        ObjectFallSwitchFloor.<>c__DisplayClass5_0 val_4 = new ObjectFallSwitchFloor.<>c__DisplayClass5_0();
        if(val_4 == null)
        {
            goto label_9;
        }
        
        .index = val_11;
        mem[1152921511902475648] = this;
        if(this.shelterArray != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        UnityEngine.Vector3 val_5 = this.shelterArray[0].localPosition;
        if(val_4 == null)
        {
            goto label_13;
        }
        
        .from = val_5;
        mem[1152921511902475624] = val_5.y;
        mem[1152921511902475628] = val_5.z;
        goto label_14;
        label_9:
        mem[48] = this;
        mem[16] = val_11;
        if(this.shelterArray != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_13:
        .from = val_5;
        mem[24] = val_5.y;
        mem[1152921511902475628] = val_5.z;
        label_14:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        float val_13 = 0f;
        val_13 = (val_10 - val_2.y) * val_13;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  val_13, a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        if(val_4 != null)
        {
                .to = val_7;
            mem[1152921511902475636] = val_7.y;
            mem[1152921511902475640] = val_7.z;
        }
        else
        {
                mem[32] = val_7.x;
            mem[1152921511902475636] = val_7.y;
            mem[40] = val_7.z;
        }
        
        val_10 = this.fallDelay;
        float val_14 = 0f;
        val_14 = val_10 * val_14;
        UnityEngine.Coroutine val_9 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  val_14, act:  new System.Action(object:  val_4, method:  System.Void ObjectFallSwitchFloor.<>c__DisplayClass5_0::<PushSwitch>b__0()));
        val_11 = 1;
        label_8:
        if(val_11 < this.shelterArray.Length)
        {
            goto label_22;
        }
    
    }
    public ObjectFallSwitchFloor()
    {
        this.fallTime = 1f;
        this.fallDelay = 7.346868E-41f;
    }

}
