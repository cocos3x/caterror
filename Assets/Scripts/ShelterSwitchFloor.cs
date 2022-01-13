using UnityEngine;
public sealed class ShelterSwitchFloor : SwitchFloor
{
    // Fields
    private SwitchGimmickShelter shelter;
    
    // Methods
    protected override void PushSwitch()
    {
        if(this.shelter == null)
        {
            
        }
    
    }
    private void OnValidate()
    {
        this.shelter.isSwitchGimmick = true;
    }
    public ShelterSwitchFloor()
    {
        val_1 = new FloorGimmick();
    }

}
