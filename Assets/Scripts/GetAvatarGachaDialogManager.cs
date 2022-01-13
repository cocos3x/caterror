using UnityEngine;
public sealed class GetAvatarGachaDialogManager : DialogManagerParent
{
    // Fields
    private static readonly string AvatarDataTag;
    private static readonly string CallbackTag;
    private UnityEngine.RectTransform[] avatarIconPivotArray;
    private UnityEngine.UI.Text[] nameTextArray;
    
    // Methods
    private void Awake()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = null;
        val_9 = null;
        AvatarData val_1 = LocalCacheManager.Load<AvatarData>(tag:  GetAvatarGachaDialogManager.AvatarDataTag);
        val_10 = 0;
        goto label_5;
        label_10:
        UnityEngine.UI.Text val_9 = this.nameTextArray[0];
        string val_2 = val_1.Name;
        val_10 = 1;
        label_5:
        if(val_10 < this.nameTextArray.Length)
        {
            goto label_10;
        }
        
        val_11 = 0;
        goto label_12;
        label_19:
        UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  val_1.GetIconPrefab(), parent:  this.avatarIconPivotArray[0]).gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "OverwrapDialog");
        val_11 = 1;
        label_12:
        if(val_11 < this.avatarIconPivotArray.Length)
        {
            goto label_19;
        }
        
        new System.Action() = new System.Action(object:  this, method:  typeof(GetAvatarGachaDialogManager).__il2cppRuntimeField_170);
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action());
    }
    public void OnHide()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
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
        val_5 = GetAvatarGachaDialogManager.<>c.<>9__7_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  GetAvatarGachaDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GetAvatarGachaDialogManager.<>c::<OnHided>b__7_0());
            GetAvatarGachaDialogManager.<>c.<>9__7_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog(AvatarData avatarData, System.Action callback)
    {
        GetAvatarGachaDialogManager.<>c__DisplayClass8_0 val_1 = new GetAvatarGachaDialogManager.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                .avatarData = avatarData;
        }
        else
        {
                mem[16] = avatarData;
        }
        
        .callback = callback;
        OverwrapDialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void GetAvatarGachaDialogManager.<>c__DisplayClass8_0::<ShowDialog>b__0()), category:  0);
    }
    public GetAvatarGachaDialogManager()
    {
    
    }
    private static GetAvatarGachaDialogManager()
    {
        GetAvatarGachaDialogManager.AvatarDataTag = "GetAvatarGachaDialogAvatarData";
        GetAvatarGachaDialogManager.CallbackTag = "GetAvatarGachaDialogCallback";
    }

}
