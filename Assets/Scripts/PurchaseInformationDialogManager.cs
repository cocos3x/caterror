using UnityEngine;
public sealed class PurchaseInformationDialogManager : DialogManagerParent
{
    // Fields
    private static readonly string TitleTag;
    private static readonly string ExplanationTag;
    private UnityEngine.UI.Text titleText;
    private UnityEngine.UI.Text explanationText;
    private UnityEngine.UI.Button backButton;
    
    // Methods
    private void Awake()
    {
        null = null;
        string val_1 = LocalCacheManager.Load<System.String>(tag:  PurchaseInformationDialogManager.TitleTag);
        string val_2 = LocalCacheManager.Load<System.String>(tag:  PurchaseInformationDialogManager.ExplanationTag);
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PurchaseInformationDialogManager::<Awake>b__5_0()));
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  this, method:  typeof(PurchaseInformationDialogManager).__il2cppRuntimeField_170));
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
        val_5 = PurchaseInformationDialogManager.<>c.<>9__7_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  PurchaseInformationDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PurchaseInformationDialogManager.<>c::<OnHided>b__7_0());
            PurchaseInformationDialogManager.<>c.<>9__7_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog(string title, string explanation)
    {
        PurchaseInformationDialogManager.<>c__DisplayClass8_0 val_1 = new PurchaseInformationDialogManager.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                .title = title;
        }
        else
        {
                mem[16] = title;
        }
        
        .explanation = explanation;
        OverwrapDialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void PurchaseInformationDialogManager.<>c__DisplayClass8_0::<ShowDialog>b__0()), category:  0);
    }
    public PurchaseInformationDialogManager()
    {
    
    }
    private static PurchaseInformationDialogManager()
    {
        PurchaseInformationDialogManager.TitleTag = "PurchaseInformationTitle";
        PurchaseInformationDialogManager.ExplanationTag = "PurchaseInformationExplanation";
    }
    private void <Awake>b__5_0()
    {
        if(true != 0)
        {
                return;
        }
        
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
    }

}
