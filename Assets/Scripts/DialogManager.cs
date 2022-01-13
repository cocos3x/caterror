using UnityEngine;
public static class DialogManager
{
    // Fields
    private static bool isShowing;
    private static System.Collections.Generic.List<DialogManager.ShowActionData> callbackList;
    
    // Properties
    public static bool ExistsDialog { get; }
    
    // Methods
    public static bool get_ExistsDialog()
    {
        null = null;
        return (bool)(DialogManager.callbackList.Count > 0) ? 1 : 0;
    }
    public static void ShowDialog(System.Action showAction, DialogCategory category = 0)
    {
        var val_2 = null;
        if(DialogManager.isShowing != false)
        {
                DialogManager.callbackList.Add(item:  new DialogManager.ShowActionData(showAction:  showAction, category:  category));
            return;
        }
        
        DialogManager.isShowing = true;
        showAction.Invoke();
    }
    public static void ShowDialogFastest(System.Action showAction, DialogCategory category = 0)
    {
        var val_2 = null;
        if(DialogManager.isShowing != false)
        {
                DialogManager.callbackList.Insert(index:  0, item:  new DialogManager.ShowActionData(showAction:  showAction, category:  category));
            return;
        }
        
        DialogManager.isShowing = true;
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
        if(DialogManager.callbackList.Count >= 1)
        {
                val_5 = null;
            DialogManager.callbackList.Item[0].DoShowAction();
            DialogManager.callbackList.RemoveAt(index:  0);
            return;
        }
        
        val_6 = null;
        DialogManager.isShowing = false;
    }
    public static void ResetAll()
    {
        DialogManager.RemoveAllCallback();
        DialogManager.isShowing = false;
    }
    public static void RemoveAllCallback()
    {
        null = null;
        DialogManager.callbackList.Clear();
    }
    private static DialogManager()
    {
        DialogManager.isShowing = false;
        DialogManager.callbackList = new System.Collections.Generic.List<ShowActionData>();
    }

}
