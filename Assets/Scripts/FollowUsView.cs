using UnityEngine;
public class FollowUsView : MonoBehaviour
{
    // Fields
    private static UnityEngine.RectTransform s_popup;
    
    // Methods
    public static void Show()
    {
        FollowUsView.s_popup = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  "Joypac/FollowUsView"));
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        FollowUsView.s_popup.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public void OpenJoypacURL()
    {
        JoypacUtils.OpenJoypacURL();
    }
    public void OnOK()
    {
        this.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  FollowUsView.s_popup.gameObject);
    }
    public FollowUsView()
    {
    
    }

}
