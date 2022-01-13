using UnityEngine;
public sealed class DashFloor : FloorGimmick
{
    // Fields
    private float dashSpeedMagnification;
    private float dashTime;
    
    // Properties
    public float DashSpeedMagnification { get; }
    public float DashTime { get; }
    
    // Methods
    public float get_DashSpeedMagnification()
    {
        return (float)this.dashSpeedMagnification;
    }
    public float get_DashTime()
    {
        return (float)this.dashTime;
    }
    public DashFloor()
    {
        this.dashSpeedMagnification = Infinityf;
        this.dashTime = 1f;
    }

}
