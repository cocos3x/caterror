using UnityEngine;
public abstract class SwitchGimmickShelter : Shelter
{
    // Fields
    protected bool isSwitchGimmick;
    
    // Properties
    set; }
    
    // Methods
    public void set_IsSwitchGimmick(bool value)
    {
        this.isSwitchGimmick = value;
    }
    public abstract void PushSwitch(); // 0
    protected SwitchGimmickShelter()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
