using UnityEngine;
public class PopLoadingView : MonoBehaviour
{
    // Fields
    public static PopLoadingView instance;
    protected static UnityEngine.RectTransform s_popup;
    
    // Methods
    private void Awake()
    {
        PopLoadingView.instance = this;
    }
    private void OnDestroy()
    {
        PopLoadingView.instance = 0;
    }
    public static void Show()
    {
        if(PopLoadingView.instance == 0)
        {
                PopLoadingView.s_popup = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  "Joypac/PopLoadingView"));
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            PopLoadingView.s_popup.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        
        PopLoadingView.instance = PopLoadingView.s_popup.gameObject.GetComponent<PopLoadingView>();
        PopLoadingView.s_popup.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        if(PopLoadingView.instance == 0)
        {
                return;
        }
        
        PopLoadingView.instance.gameObject.SetActive(value:  false);
    }
    public PopLoadingView()
    {
    
    }

}
