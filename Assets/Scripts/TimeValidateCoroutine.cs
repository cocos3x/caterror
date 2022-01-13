using UnityEngine;
public class TimeValidateCoroutine
{
    // Fields
    private System.Action removeAction;
    
    // Methods
    public TimeValidateCoroutine(System.Action removeAction)
    {
        this.removeAction = removeAction;
    }
    public void Remove()
    {
        var val_1;
        this.removeAction.Invoke();
        val_1 = null;
        val_1 = null;
        this.removeAction = ActionExtensions.EmptyAction;
    }

}
