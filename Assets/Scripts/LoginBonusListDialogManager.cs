using UnityEngine;
public sealed class LoginBonusListDialogManager : DialogManagerParent
{
    // Fields
    private static readonly string OpenDetailActionTag;
    private static readonly string CallbackTag;
    private LoginBonusNode nodePrefab;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.RectTransform content;
    
    // Methods
    private void Awake()
    {
        var val_9;
        var val_24;
        var val_25;
        var val_27;
        var val_29;
        var val_30;
        var val_31;
        LoginBonusListDialogManager.<>c__DisplayClass5_0 val_1 = new LoginBonusListDialogManager.<>c__DisplayClass5_0();
        .<>4__this = this;
        .gameData = GameDataManager.GameData;
        val_24 = null;
        val_24 = null;
        System.Collections.Generic.List<T> val_4 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        val_25 = null;
        val_25 = null;
        if((LoginBonusListDialogManager.<>c.<>9__5_0) == null)
        {
            goto label_9;
        }
        
        label_31:
        System.Collections.Generic.List<T> val_5 = val_4.FindAll(match:  LoginBonusListDialogManager.<>c.<>9__5_0);
        val_27 = null;
        val_27 = null;
        if((LoginBonusListDialogManager.<>c.<>9__5_1) == null)
        {
            goto label_13;
        }
        
        label_35:
        val_5.Sort(comparison:  LoginBonusListDialogManager.<>c.<>9__5_1);
        val_29 = null;
        val_29 = null;
        .openDetailAction = LocalCacheManager.Load<System.Action<AvatarData, System.Action>>(tag:  LoginBonusListDialogManager.OpenDetailActionTag);
        List.Enumerator<T> val_7 = val_5.GetEnumerator();
        label_27:
        if(((-1319931024) & 1) == 0)
        {
            goto label_20;
        }
        
        new LoginBonusListDialogManager.<>c__DisplayClass5_1() = new System.Object();
        if((new LoginBonusListDialogManager.<>c__DisplayClass5_1()) != null)
        {
                val_30 = new LoginBonusListDialogManager.<>c__DisplayClass5_1();
            .CS$<>8__locals1 = val_1;
        }
        else
        {
                mem[24] = val_1;
            val_30 = 24;
        }
        
        .avatarData = val_9.Id;
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  new LoginBonusListDialogManager.<>c__DisplayClass5_1(), method:  System.Void LoginBonusListDialogManager.<>c__DisplayClass5_1::<Awake>b__3());
        UnityEngine.Object.Instantiate<LoginBonusNode>(original:  this.nodePrefab, parent:  this.content).Initialize(gameData:  .gameData, avatarData:  (LoginBonusListDialogManager.<>c__DisplayClass5_1)[1152921511876923344].avatarData, openDetailAction:  new UnityEngine.Events.UnityAction());
        goto label_27;
        label_9:
        LoginBonusListDialogManager.<>c.<>9__5_0 = new System.Predicate<AvatarData>(object:  LoginBonusListDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LoginBonusListDialogManager.<>c::<Awake>b__5_0(AvatarData data));
        if(val_4 != null)
        {
            goto label_31;
        }
        
        goto label_31;
        label_13:
        LoginBonusListDialogManager.<>c.<>9__5_1 = new System.Comparison<AvatarData>(object:  LoginBonusListDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LoginBonusListDialogManager.<>c::<Awake>b__5_1(AvatarData a, AvatarData b));
        if(val_5 != null)
        {
            goto label_35;
        }
        
        goto label_35;
        label_20:
        UniRx.Unit..cctor();
        System.Predicate<AvatarData> val_16 = new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean LoginBonusListDialogManager.<>c__DisplayClass5_0::<Awake>b__2(AvatarData data));
        if(val_5 != null)
        {
                val_31 = val_5.IndexOf(item:  val_5.Find(match:  val_16));
        }
        else
        {
                val_31 = 0.IndexOf(item:  0.Find(match:  val_16));
        }
        
        float val_24 = (float)val_31;
        val_24 = val_24 / (float)val_5.Count;
        this.scrollRect.verticalNormalizedPosition = val_24;
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  this, method:  typeof(LoginBonusListDialogManager).__il2cppRuntimeField_170));
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
        val_5 = LoginBonusListDialogManager.<>c.<>9__8_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  LoginBonusListDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoginBonusListDialogManager.<>c::<OnHided>b__8_0());
            LoginBonusListDialogManager.<>c.<>9__8_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog(System.Action<AvatarData, System.Action> openDetailAction, System.Action callback)
    {
        LoginBonusListDialogManager.<>c__DisplayClass9_0 val_1 = new LoginBonusListDialogManager.<>c__DisplayClass9_0();
        if(val_1 != null)
        {
                .openDetailAction = openDetailAction;
        }
        else
        {
                mem[16] = openDetailAction;
        }
        
        .callback = callback;
        DialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void LoginBonusListDialogManager.<>c__DisplayClass9_0::<ShowDialog>b__0()), category:  0);
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        var val_4;
        if(pauseStatus == false)
        {
                return;
        }
        
        SingletonMonoBehaviour<BackButtonManager>.Instance.DestroyOneAction();
        DialogManager.HideDialog();
        val_4 = null;
        val_4 = null;
        LocalCacheManager.Load<System.Action>(tag:  LoginBonusListDialogManager.CallbackTag).Invoke();
        SingletonMonoBehaviour<TransitionManager>.Instance.UnloadScene(scene:  7);
    }
    public LoginBonusListDialogManager()
    {
    
    }
    private static LoginBonusListDialogManager()
    {
        LoginBonusListDialogManager.OpenDetailActionTag = "LoginBonusListDialogOpenDetailAction";
        LoginBonusListDialogManager.CallbackTag = "LoginBonusListDialogCallback";
    }

}
