using UnityEngine;
public sealed class ApplicationExitConfirmDialogManager : DialogManagerParent
{
    // Methods
    private void Awake()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(ApplicationExitConfirmDialogManager).__il2cppRuntimeField_170);
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action());
    }
    public void OnExit()
    {
        UnityEngine.Application.Quit();
    }
    public void OnHide()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction(isPressedBackButton:  false);
    }
    protected override void Hide()
    {
        this.Hide();
        this.OnHided();
    }
    public void OnHided()
    {
        var val_3;
        System.Action val_5;
        val_3 = null;
        val_3 = null;
        val_5 = ApplicationExitConfirmDialogManager.<>c.<>9__4_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  ApplicationExitConfirmDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ApplicationExitConfirmDialogManager.<>c::<OnHided>b__4_0());
            ApplicationExitConfirmDialogManager.<>c.<>9__4_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog()
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = ApplicationExitConfirmDialogManager.<>c.<>9__5_0;
        if(val_4 == null)
        {
                System.Action val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action(object:  ApplicationExitConfirmDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ApplicationExitConfirmDialogManager.<>c::<ShowDialog>b__5_0());
            ApplicationExitConfirmDialogManager.<>c.<>9__5_0 = val_4;
        }
        
        DialogManager.ShowDialog(showAction:  val_1, category:  0);
    }
    public ApplicationExitConfirmDialogManager()
    {
    
    }

}
