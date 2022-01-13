using UnityEngine;
public sealed class LoginBonusNode : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text nameText;
    private UnityEngine.UI.Text progressText;
    private GaugeParent gauge;
    private UnityEngine.RectTransform avatarIconPivot;
    private UnityEngine.UI.Button detailButton;
    private UnityEngine.GameObject checkMark;
    private UnityEngine.UI.Image silhouetteIcon;
    
    // Methods
    public void Initialize(GameData gameData, AvatarData avatarData, UnityEngine.Events.UnityAction openDetailAction)
    {
        var val_20;
        System.Action<UnityEngine.UI.Image> val_21;
        UnityEngine.Transform val_22;
        var val_23;
        System.Action<UnityEngine.UI.Image> val_25;
        var val_26;
        var val_28;
        val_20 = gameData;
        val_21 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  avatarData.GetIconPrefab(), parent:  this.avatarIconPivot);
        string val_4 = System.String.Format(format:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "LoginDay", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0), arg0:  gameData.dailyLoginCount, arg1:  avatarData.value);
        float val_20 = (float)gameData.dailyLoginCount;
        val_20 = val_20 / (float)avatarData.value;
        if((val_20.HasAvatar(avatarData:  avatarData)) != false)
        {
                string val_6 = avatarData.Name;
            this.checkMark.SetActive(value:  true);
            this.gauge.gameObject.SetActive(value:  false);
            val_22 = val_21.transform;
            val_23 = null;
            val_23 = null;
            val_25 = LoginBonusNode.<>c.<>9__7_0;
            if(val_25 == null)
        {
                System.Action<UnityEngine.UI.Image> val_9 = 1152921504657326080;
            val_25 = val_9;
            val_9 = new System.Action<UnityEngine.UI.Image>(object:  LoginBonusNode.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoginBonusNode.<>c::<Initialize>b__7_0(UnityEngine.UI.Image image));
            LoginBonusNode.<>c.<>9__7_0 = val_25;
        }
        
            bool val_10 = TransformExtensions.FindAllChildrensComponent<UnityEngine.UI.Image>(t:  val_22, func:  val_25);
            return;
        }
        
        if(avatarData.value <= gameData.dailyLoginCount)
        {
            goto label_22;
        }
        
        if(avatarData.silhouette == false)
        {
            goto label_23;
        }
        
        val_20 = 1152921504947793920;
        val_26 = null;
        val_26 = null;
        val_21 = LoginBonusNode.<>c.<>9__7_1;
        if(val_21 == null)
        {
                System.Action<UnityEngine.UI.Image> val_12 = null;
            val_21 = val_12;
            val_12 = new System.Action<UnityEngine.UI.Image>(object:  LoginBonusNode.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoginBonusNode.<>c::<Initialize>b__7_1(UnityEngine.UI.Image image));
            LoginBonusNode.<>c.<>9__7_1 = val_21;
        }
        
        bool val_13 = TransformExtensions.FindAllChildrensComponent<UnityEngine.UI.Image>(t:  val_21.transform, func:  val_12);
        val_22 = this.silhouetteIcon.gameObject;
        val_28 = 1;
        goto label_33;
        label_22:
        string val_15 = avatarData.Name;
        this.detailButton.gameObject.SetActive(value:  true);
        val_21 = this.detailButton.onClick;
        val_21.AddListener(call:  openDetailAction);
        val_22 = this.gauge.gameObject;
        val_28 = 0;
        label_33:
        val_22.SetActive(value:  false);
        return;
        label_23:
        string val_19 = avatarData.Name;
        if(this.nameText != null)
        {
                return;
        }
    
    }
    public LoginBonusNode()
    {
    
    }

}
