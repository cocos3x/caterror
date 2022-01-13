using UnityEngine;
public sealed class LoginBonusDetailDialogManager : DialogManagerParent
{
    // Fields
    private static readonly string AvatarDataTag;
    private static readonly string CallbackTag;
    private float progressPrevWaitTime;
    private float progressLerpTime;
    private float progressNextWaitTime;
    private UnityEngine.RectTransform avatarIconPivot;
    private UnityEngine.UI.Text nameText;
    private UnityEngine.UI.Text progressText;
    private GaugeParent gauge;
    private UnityEngine.Animator animator;
    private UnityEngine.UI.Image silhouetteIcon;
    
    // Methods
    private void Awake()
    {
        var val_18;
        var val_19;
        System.Action<UnityEngine.UI.Image> val_21;
        .<>4__this = this;
        val_18 = null;
        val_18 = null;
        .avatarData = LocalCacheManager.Load<AvatarData>(tag:  LoginBonusDetailDialogManager.AvatarDataTag);
        if(val_2.silhouette == false)
        {
            goto label_7;
        }
        
        if(this.nameText != null)
        {
            goto label_32;
        }
        
        label_33:
        label_32:
        .icon = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  (LoginBonusDetailDialogManager.<>c__DisplayClass11_0)[1152921511874131440].avatarData.GetIconPrefab(), parent:  this.avatarIconPivot);
        if(((LoginBonusDetailDialogManager.<>c__DisplayClass11_0)[1152921511874131440].avatarData.silhouette) != false)
        {
                val_19 = null;
            val_19 = null;
            val_21 = LoginBonusDetailDialogManager.<>c.<>9__11_0;
            if(val_21 == null)
        {
                System.Action<UnityEngine.UI.Image> val_6 = null;
            val_21 = val_6;
            val_6 = new System.Action<UnityEngine.UI.Image>(object:  LoginBonusDetailDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoginBonusDetailDialogManager.<>c::<Awake>b__11_0(UnityEngine.UI.Image image));
            LoginBonusDetailDialogManager.<>c.<>9__11_0 = val_21;
        }
        
            bool val_7 = TransformExtensions.FindAllChildrensComponent<UnityEngine.UI.Image>(t:  (LoginBonusDetailDialogManager.<>c__DisplayClass11_0)[1152921511874131440].icon.transform, func:  val_6);
            this.silhouetteIcon.gameObject.SetActive(value:  true);
        }
        
        .gameData = GameDataManager.GameData;
        int val_18 = val_9.dailyLoginCount;
        val_18 = val_18 - 1;
        string val_10 = System.String.Format(format:  "{0} / {1} Day", arg0:  val_18, arg1:  (LoginBonusDetailDialogManager.<>c__DisplayClass11_0)[1152921511874131440].avatarData.value);
        .from = ((float)((LoginBonusDetailDialogManager.<>c__DisplayClass11_0)[1152921511874131440].gameData.dailyLoginCount) - 1) / ((float)(LoginBonusDetailDialogManager.<>c__DisplayClass11_0)[1152921511874131440].avatarData.value);
        UnityEngine.Coroutine val_14 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  this.progressPrevWaitTime, act:  new System.Action(object:  new LoginBonusDetailDialogManager.<>c__DisplayClass11_0(), method:  System.Void LoginBonusDetailDialogManager.<>c__DisplayClass11_0::<Awake>b__1()));
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  this, method:  typeof(LoginBonusDetailDialogManager).__il2cppRuntimeField_170));
        return;
        label_7:
        string val_17 = (LoginBonusDetailDialogManager.<>c__DisplayClass11_0)[1152921511874131440].avatarData.Name;
        if(this.nameText != null)
        {
            goto label_32;
        }
        
        goto label_33;
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
        val_5 = LoginBonusDetailDialogManager.<>c.<>9__14_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  LoginBonusDetailDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoginBonusDetailDialogManager.<>c::<OnHided>b__14_0());
            LoginBonusDetailDialogManager.<>c.<>9__14_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog(AvatarData avatarData, System.Action callback)
    {
        LoginBonusDetailDialogManager.<>c__DisplayClass15_0 val_1 = new LoginBonusDetailDialogManager.<>c__DisplayClass15_0();
        if(val_1 != null)
        {
                .avatarData = avatarData;
        }
        else
        {
                mem[16] = avatarData;
        }
        
        .callback = callback;
        DialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void LoginBonusDetailDialogManager.<>c__DisplayClass15_0::<ShowDialog>b__0()), category:  0);
    }
    public LoginBonusDetailDialogManager()
    {
        this.progressPrevWaitTime = 1f;
        this.progressLerpTime = 1f;
        this.progressNextWaitTime = 1f;
    }
    private static LoginBonusDetailDialogManager()
    {
        LoginBonusDetailDialogManager.AvatarDataTag = "LoginBonusDetailDialogAvatarData";
        LoginBonusDetailDialogManager.CallbackTag = "LoginBonusDetailDialogCallback";
    }

}
