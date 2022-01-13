using UnityEngine;
public sealed class DogActionTrigger : MonoBehaviour
{
    // Fields
    private float waitTime;
    private float sleepTime;
    private bool isReverse;
    private bool isUsed;
    
    // Properties
    public float WaitTime { get; }
    public float SleepTime { get; }
    public bool IsReverse { get; }
    public bool IdUsed { get; }
    
    // Methods
    public float get_WaitTime()
    {
        return (float)this.waitTime;
    }
    public float get_SleepTime()
    {
        return (float)this.sleepTime;
    }
    public bool get_IsReverse()
    {
        return (bool)this.isReverse;
    }
    public bool get_IdUsed()
    {
        return (bool)this.isUsed;
    }
    public void Use()
    {
        this.isUsed = true;
    }
    public DogActionTrigger()
    {
        this.waitTime = 3f;
    }

}
