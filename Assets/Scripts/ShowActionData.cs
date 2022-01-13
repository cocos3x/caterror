using UnityEngine;
protected sealed class OverwrapDialogManager.ShowActionData
{
    // Fields
    private System.Action showAction;
    private OverwrapDialogCategory category;
    
    // Methods
    public OverwrapDialogManager.ShowActionData(System.Action showAction, OverwrapDialogCategory category)
    {
        this.showAction = showAction;
        this.category = category;
    }
    public void DoShowAction()
    {
        this.showAction.Invoke();
    }

}
