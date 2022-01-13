using UnityEngine;
public sealed class AvatarDialogSideButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Image selectObject;
    
    // Methods
    public void Initialize(UnityEngine.Events.UnityAction onClick, bool isSelect)
    {
        this.button.onClick.RemoveAllListeners();
        this.button.onClick.AddListener(call:  onClick);
        this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AvatarDialogSideButton::<Initialize>b__2_0()));
        this.selectObject.gameObject.SetActive(value:  isSelect);
    }
    public void UnSelect()
    {
        this.selectObject.gameObject.SetActive(value:  false);
    }
    public AvatarDialogSideButton()
    {
    
    }
    private void <Initialize>b__2_0()
    {
        this.selectObject.gameObject.SetActive(value:  true);
    }

}
