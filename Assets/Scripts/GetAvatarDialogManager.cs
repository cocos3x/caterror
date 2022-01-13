using UnityEngine;
public sealed class GetAvatarDialogManager : DialogManagerParent
{
    // Fields
    private static readonly string AvatarDataTag;
    private static readonly string IsGetTag;
    private static readonly string YesCallbackTag;
    private static readonly string CallbackTag;
    private UnityEngine.Sprite[] presentBoxSpriteArray;
    private UnityEngine.RectTransform[] avatarIconPivotArray;
    private UnityEngine.UI.Text[] nameTextArray;
    private UnityEngine.UI.Image presentBox;
    private UnityEngine.Animator animator;
    
    // Methods
    private void Awake()
    {
        var val_13;
        UnityEngine.UI.Text[] val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = null;
        val_13 = null;
        AvatarData val_1 = LocalCacheManager.Load<AvatarData>(tag:  GetAvatarDialogManager.AvatarDataTag);
        val_14 = this.nameTextArray;
        val_15 = 0;
        goto label_5;
        label_10:
        UnityEngine.UI.Text val_13 = val_14[0];
        string val_2 = val_1.Name;
        val_15 = 1;
        label_5:
        if(val_15 < this.nameTextArray.Length)
        {
            goto label_10;
        }
        
        val_16 = 0;
        goto label_12;
        label_19:
        val_14 = UnityEngine.LayerMask.NameToLayer(layerName:  "OverwrapDialog");
        UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  val_1.GetIconPrefab(), parent:  this.avatarIconPivotArray[0]).gameObject.layer = val_14;
        val_16 = 1;
        label_12:
        if(val_16 < this.avatarIconPivotArray.Length)
        {
            goto label_19;
        }
        
        if(val_1.AcquisitionCondition != 3)
        {
            goto label_21;
        }
        
        if(this.presentBox != null)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        this.presentBox.sprite = this.presentBoxSpriteArray[1];
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  this, method:  typeof(GetAvatarDialogManager).__il2cppRuntimeField_170));
        val_17 = null;
        val_17 = null;
        if((LocalCacheManager.Load<System.Boolean>(tag:  GetAvatarDialogManager.IsGetTag)) == false)
        {
                return;
        }
        
        mem[1152921511869581760] = 1;
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetDisable();
        this.animator.SetTrigger(name:  "Get");
        return;
        label_21:
        if(val_1.AcquisitionCondition != 5)
        {
            goto label_35;
        }
        
        UnityEngine.Sprite val_16 = this.presentBoxSpriteArray[2];
        if(this.presentBox != null)
        {
            goto label_40;
        }
        
        goto label_41;
        label_35:
        UnityEngine.Sprite val_17 = this.presentBoxSpriteArray[0];
        if(this.presentBox != null)
        {
            goto label_40;
        }
        
        goto label_41;
    }
    public void OnYes()
    {
        var val_3;
        if(true != 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        LocalCacheManager.Load<System.Action<System.Action<System.Boolean>>>(tag:  GetAvatarDialogManager.YesCallbackTag).Invoke(obj:  new System.Action<System.Boolean>(object:  this, method:  System.Void GetAvatarDialogManager::<OnYes>b__10_0(bool adResult)));
    }
    public void OnEnd()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetEnable();
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
    }
    public void OnNo()
    {
        if(true != 0)
        {
                return;
        }
        
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
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
        val_5 = GetAvatarDialogManager.<>c.<>9__15_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  GetAvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GetAvatarDialogManager.<>c::<OnHided>b__15_0());
            GetAvatarDialogManager.<>c.<>9__15_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog(AvatarData avatarData, System.Action<System.Action<bool>> yesCallback, System.Func<bool> callback)
    {
        GetAvatarDialogManager.<>c__DisplayClass16_0 val_1 = new GetAvatarDialogManager.<>c__DisplayClass16_0();
        if(val_1 != null)
        {
                .avatarData = avatarData;
            .yesCallback = yesCallback;
        }
        else
        {
                mem[16] = avatarData;
            mem[24] = yesCallback;
        }
        
        .callback = callback;
        OverwrapDialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void GetAvatarDialogManager.<>c__DisplayClass16_0::<ShowDialog>b__0()), category:  0);
    }
    public static void ShowGetDialog(AvatarData avatarData, System.Func<bool> callback)
    {
        GetAvatarDialogManager.<>c__DisplayClass17_0 val_1 = new GetAvatarDialogManager.<>c__DisplayClass17_0();
        if(val_1 != null)
        {
                .avatarData = avatarData;
        }
        else
        {
                mem[16] = avatarData;
        }
        
        .callback = callback;
        OverwrapDialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void GetAvatarDialogManager.<>c__DisplayClass17_0::<ShowGetDialog>b__0()), category:  0);
    }
    public GetAvatarDialogManager()
    {
    
    }
    private static GetAvatarDialogManager()
    {
        GetAvatarDialogManager.AvatarDataTag = "GetAvatarDialogAvatarData";
        GetAvatarDialogManager.IsGetTag = "GetAvatarDialogIsGet";
        GetAvatarDialogManager.YesCallbackTag = "GetAvatarDialogYesCallback";
        GetAvatarDialogManager.CallbackTag = "GetAvatarDialogCallback";
    }
    private void <OnYes>b__10_0(bool adResult)
    {
        if(adResult == false)
        {
                return;
        }
        
        mem[1152921511871189040] = 1;
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetDisable();
        this.animator.SetTrigger(name:  "Get");
    }

}
