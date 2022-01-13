using UnityEngine;
public abstract class SwitchFloor : FloorGimmick, IContinueInitializer
{
    // Fields
    private UnityEngine.Animator switchAnimator;
    private bool isPushed;
    
    // Properties
    public bool IsPushed { get; }
    
    // Methods
    public bool get_IsPushed()
    {
        return (bool)this.isPushed;
    }
    public void Push()
    {
        if(this.isPushed != false)
        {
                return;
        }
        
        this.isPushed = true;
        this.switchAnimator.SetTrigger(name:  "On");
        goto typeof(SwitchFloor).__il2cppRuntimeField_178;
    }
    protected abstract void PushSwitch(); // 0
    public void Continue()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        if(val_2.x >= 0)
        {
                return;
        }
        
        this.Push();
    }
    protected SwitchFloor()
    {
    
    }

}
