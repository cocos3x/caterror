using UnityEngine;
public class PurchaseView : MonoBehaviour
{
    // Fields
    private static UnityEngine.RectTransform s_purchaseView;
    private static System.Action m_buyNoAdsFunc;
    
    // Methods
    private void Start()
    {
    
    }
    public static void Show(System.Action buyNoAdsFunc)
    {
        PurchaseView.m_buyNoAdsFunc = buyNoAdsFunc;
        PurchaseView.s_purchaseView = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  "Joypac/PurchaseView"));
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        PurchaseView.s_purchaseView.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static void Hide()
    {
        PurchaseView.s_purchaseView.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  PurchaseView.s_purchaseView.gameObject);
    }
    public void RemoveAdsClick()
    {
        PurchaseView.Hide();
        UnityEngine.Debug.Log(message:  "去广告按钮点击了");
        if(PurchaseView.m_buyNoAdsFunc != null)
        {
                PurchaseView.m_buyNoAdsFunc.Invoke();
            return;
        }
        
        PopLoadingView.Hide();
    }
    public void CloseBtnClick()
    {
        PurchaseView.Hide();
    }
    public PurchaseView()
    {
    
    }

}
