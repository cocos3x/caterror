using UnityEngine;
public sealed class BeltConveyorFloor : FloorGimmick
{
    // Fields
    private float moveSpeed;
    
    // Properties
    public float MoveSpeed { get; }
    
    // Methods
    public float get_MoveSpeed()
    {
        return (float)this.moveSpeed;
    }
    public BeltConveyorFloor()
    {
        this.moveSpeed = 1f;
    }

}
