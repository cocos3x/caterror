using UnityEngine;
public sealed class CatCancelTrigger : MonoBehaviour
{
    // Fields
    private bool isUsed;
    
    // Properties
    public bool IdUsed { get; }
    
    // Methods
    public bool get_IdUsed()
    {
        return (bool)this.isUsed;
    }
    public void Use()
    {
        this.isUsed = true;
    }
    public CatCancelTrigger()
    {
    
    }

}
