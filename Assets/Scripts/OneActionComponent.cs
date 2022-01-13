using UnityEngine;
public class OneActionComponent : MonoBehaviour
{
    // Fields
    private System.Action action;
    private bool hasAction;
    
    // Methods
    public void SetAction(System.Action action)
    {
        this.hasAction = true;
        this.action = action;
    }
    private void Update()
    {
        if(this.hasAction == false)
        {
                return;
        }
        
        this.action.Invoke();
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public OneActionComponent()
    {
    
    }

}
