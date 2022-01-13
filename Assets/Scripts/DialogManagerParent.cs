using UnityEngine;
public abstract class DialogManagerParent : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator dialogAnimator;
    protected bool isHiding;
    
    // Methods
    protected virtual void Hide()
    {
        this.isHiding = true;
        if((UnityEngine.Object.op_Implicit(exists:  this.dialogAnimator)) == false)
        {
                return;
        }
        
        this.dialogAnimator.SetTrigger(name:  "Hide");
    }
    protected DialogManagerParent()
    {
    
    }

}
