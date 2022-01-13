using UnityEngine;
public static class OverwrapDialogManager
{
    // Fields
    private static bool isShowing;
    private static System.Collections.Generic.List<OverwrapDialogManager.ShowActionData> callbackList;
    
    // Properties
    public static bool ExistsDialog { get; }
    
    // Methods
    public static bool get_ExistsDialog()
    {
        null = null;
        return (bool)(OverwrapDialogManager.callbackList.Count > 0) ? 1 : 0;
    }
    public static void ShowDialog(System.Action showAction, OverwrapDialogCategory category = 0)
    {
        var val_2 = null;
        if(OverwrapDialogManager.isShowing != false)
        {
                .showAction = showAction;
            .category = category;
            OverwrapDialogManager.callbackList.Add(item:  new OverwrapDialogManager.ShowActionData());
            return;
        }
        
        OverwrapDialogManager.isShowing = true;
        showAction.Invoke();
    }
    public static void ShowDialogFastest(System.Action showAction, OverwrapDialogCategory category = 0)
    {
        var val_2 = null;
        if(OverwrapDialogManager.isShowing != false)
        {
                .showAction = showAction;
            .category = category;
            OverwrapDialogManager.callbackList.Insert(index:  0, item:  new OverwrapDialogManager.ShowActionData());
            return;
        }
        
        OverwrapDialogManager.isShowing = true;
        showAction.Invoke();
    }
    public static void HideDialog()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        if(OverwrapDialogManager.callbackList.Count >= 1)
        {
                val_5 = null;
            OverwrapDialogManager.callbackList.Item[0].DoShowAction();
            OverwrapDialogManager.callbackList.RemoveAt(index:  0);
            return;
        }
        
        val_6 = null;
        OverwrapDialogManager.isShowing = false;
    }
    public static void ResetAll()
    {
        OverwrapDialogManager.RemoveAllCallback();
        OverwrapDialogManager.isShowing = false;
    }
    public static void RemoveAllCallback()
    {
        null = null;
        OverwrapDialogManager.callbackList.Clear();
    }
    private static OverwrapDialogManager()
    {
        OverwrapDialogManager.isShowing = false;
        OverwrapDialogManager.callbackList = new System.Collections.Generic.List<ShowActionData>();
    }

}
