using UnityEngine;
public sealed class UnableWatchVideoDialogManager : DialogManagerParent
{
    // Methods
    private void Awake()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(UnableWatchVideoDialogManager).__il2cppRuntimeField_170);
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action());
    }
    public void OnHide()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
    }
    public void OnHided()
    {
        var val_3;
        System.Action val_5;
        val_3 = null;
        val_3 = null;
        val_5 = UnableWatchVideoDialogManager.<>c.<>9__2_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  UnableWatchVideoDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UnableWatchVideoDialogManager.<>c::<OnHided>b__2_0());
            UnableWatchVideoDialogManager.<>c.<>9__2_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog()
    {
        TransitionManager val_1 = SingletonMonoBehaviour<TransitionManager>.Instance;
        UnityEngine.Coroutine val_3 = val_1.StartCoroutine(routine:  val_1._LoadSceneAdditive(scene:  10, sceneType:  1));
    }
    public UnableWatchVideoDialogManager()
    {
    
    }

}
