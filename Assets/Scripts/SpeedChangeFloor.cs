using UnityEngine;
public sealed class SpeedChangeFloor : FloorGimmick
{
    // Fields
    private float speedMagnification;
    
    // Properties
    public float SpeedMagnification { get; }
    
    // Methods
    public float get_SpeedMagnification()
    {
        return (float)this.speedMagnification;
    }
    public SpeedChangeFloor()
    {
        this.speedMagnification = 0.5f;
    }

}
