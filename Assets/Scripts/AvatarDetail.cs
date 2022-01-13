using UnityEngine;
public class AvatarDetail : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text nameText;
    private UnityEngine.UI.Text acquisitionConditionText;
    private UnityEngine.UI.Text progressText;
    private GaugeX progressGauge;
    private UnityEngine.UI.Button transitionToGachaButton;
    private UnityEngine.UI.Button adButton;
    private UnityEngine.RectTransform avatarIconPivot;
    private UnityEngine.UI.Image silhouetteIcon;
    
    // Methods
    public void Initialize(GameData gameData, AvatarData avatarData, UnityEngine.Events.UnityAction transitionToGacha, UnityEngine.Events.UnityAction onClickAd, bool currentShow = False)
    {
        bool val_22;
        UnityEngine.RectTransform val_23;
        var val_24;
        var val_26;
        var val_27;
        this.transitionToGachaButton.onClick.AddListener(call:  transitionToGacha);
        this.adButton.onClick.AddListener(call:  onClickAd);
        if(avatarData.silhouette == false)
        {
            goto label_7;
        }
        
        if(this.nameText != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        TransformExtensions.DestroyAllChildrens(t:  this.avatarIconPivot);
        string val_3 = avatarData.AcquisitionConditionText;
        string val_4 = avatarData.GetAcquisitionConditionProgressText(gameData:  gameData);
        val_22 = avatarData.CheckGetAvatar(gameData:  gameData);
        var val_7 = ((avatarData.GetAcquisitionConditionProgress(gameData:  gameData)) < 0f) ? 1 : 0;
        val_7 = val_22 | val_7;
        UnityEngine.GameObject val_8 = this.progressGauge.gameObject;
        if(val_8 == null)
        {
            goto label_12;
        }
        
        if(val_7 == false)
        {
            goto label_13;
        }
        
        label_17:
        val_8.SetActive(value:  false);
        goto label_14;
        label_7:
        string val_9 = avatarData.Name;
        if(this.nameText != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_12:
        if(val_7 == true)
        {
            goto label_17;
        }
        
        label_13:
        val_8.SetActive(value:  true);
        label_14:
        this.transitionToGachaButton.gameObject.SetActive(value:  (avatarData.acquisitionCondition == 4) ? 1 : 0);
        this.adButton.gameObject.SetActive(value:  val_22);
        if((val_22 & currentShow) != false)
        {
                JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Ad", type:  "impression", position:  "DetailsPage", onlyFirst:  false, extra:  "");
        }
        
        val_23 = this.avatarIconPivot;
        if(avatarData.silhouette != false)
        {
                val_22 = 1152921504945291264;
            val_24 = null;
            val_24 = null;
            val_23 = AvatarDetail.<>c.<>9__8_0;
            if(val_23 == null)
        {
                System.Action<UnityEngine.UI.Image> val_18 = null;
            val_23 = val_18;
            val_18 = new System.Action<UnityEngine.UI.Image>(object:  AvatarDetail.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AvatarDetail.<>c::<Initialize>b__8_0(UnityEngine.UI.Image image));
            AvatarDetail.<>c.<>9__8_0 = val_23;
        }
        
            bool val_19 = TransformExtensions.FindAllChildrensComponent<UnityEngine.UI.Image>(t:  UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  avatarData.GetIconPrefab(), parent:  val_23).transform, func:  val_18);
            val_26 = this.silhouetteIcon.gameObject;
            val_27 = 1;
        }
        else
        {
                val_26 = this.silhouetteIcon.gameObject;
            val_27 = 0;
        }
        
        val_26.SetActive(value:  false);
    }
    public AvatarDetail()
    {
    
    }

}
