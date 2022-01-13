using UnityEngine;
public sealed class AvatarNode : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    private UnityEngine.GameObject lockObject;
    private UnityEngine.Transform iconPivot;
    private UnityEngine.GameObject newObject;
    private UnityEngine.GameObject selectObject;
    private UnityEngine.UI.Image silhouetteIcon;
    private UnityEngine.Animator animator;
    private UnityEngine.GameObject adIcon;
    private AvatarData avatarData;
    
    // Properties
    public AvatarData AvatarData { get; }
    public int Id { get; }
    
    // Methods
    public AvatarData get_AvatarData()
    {
        return (AvatarData)this.avatarData;
    }
    public int get_Id()
    {
        if(this.avatarData != null)
        {
                return (int)this.avatarData.id;
        }
        
        return (int)this.avatarData.id;
    }
    public void Initialize(AvatarData avatarData, bool isOwned, bool isNew, UnityEngine.Events.UnityAction callback)
    {
        UnityEngine.RectTransform val_10;
        var val_11;
        System.Action<UnityEngine.UI.Image> val_13;
        this.avatarData = avatarData;
        val_10 = avatarData.GetIconPrefab();
        if((avatarData.silhouette != false) && (isOwned != true))
        {
                val_11 = null;
            val_11 = null;
            val_13 = AvatarNode.<>c.<>9__13_0;
            if(val_13 == null)
        {
                System.Action<UnityEngine.UI.Image> val_4 = null;
            val_13 = val_4;
            val_4 = new System.Action<UnityEngine.UI.Image>(object:  AvatarNode.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AvatarNode.<>c::<Initialize>b__13_0(UnityEngine.UI.Image image));
            AvatarNode.<>c.<>9__13_0 = val_13;
        }
        
            bool val_5 = TransformExtensions.FindAllChildrensComponent<UnityEngine.UI.Image>(t:  UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  val_10, parent:  this.iconPivot).transform, func:  val_4);
            this.silhouetteIcon.gameObject.SetActive(value:  true);
        }
        
        this.button.onClick.AddListener(call:  callback);
        this.lockObject.SetActive(value:  (~isOwned) & 1);
        this.newObject.SetActive(value:  isNew);
    }
    public void ShowAdIcon()
    {
        this.adIcon.SetActive(value:  true);
    }
    public void Selected()
    {
        this.newObject.SetActive(value:  false);
        this.selectObject.SetActive(value:  true);
    }
    public void UnSelected()
    {
        this.selectObject.SetActive(value:  false);
    }
    public void LightUp(bool isLightUp)
    {
        bool val_1 = isLightUp;
        this.animator.SetBool(name:  "IsLightUp", value:  val_1);
        this.selectObject.SetActive(value:  val_1);
    }
    public void Release()
    {
        UnityEngine.RectTransform val_2 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.avatarData.GetIconPrefab(), parent:  this.iconPivot);
        this.lockObject.SetActive(value:  false);
        this.button.interactable = true;
        this.animator.SetTrigger(name:  "Release");
        this.animator.SetBool(name:  "IsLightUp", value:  false);
    }
    public AvatarNode()
    {
    
    }

}
