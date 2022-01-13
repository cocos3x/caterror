using UnityEngine;
public class LookAtTarget : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform targetTransform;
    
    // Properties
    public UnityEngine.Transform Target { get; set; }
    
    // Methods
    public UnityEngine.Transform get_Target()
    {
        return (UnityEngine.Transform)this.targetTransform;
    }
    public void set_Target(UnityEngine.Transform value)
    {
        this.targetTransform = value;
    }
    private void LateUpdate()
    {
        this.transform.LookAt(target:  this.targetTransform);
    }
    public LookAtTarget()
    {
    
    }

}
