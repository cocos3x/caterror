using UnityEngine;
public class RemoveAdsPopupView : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button buyAdsBtn;
    private UnityEngine.UI.Button noBuyBtn;
    private UnityEngine.Canvas canvas;
    private static UnityEngine.RectTransform s_removeAdsPopupView;
    private static System.Action s_buyAdsClickCallback;
    private static System.Action s_noBuyAdsClickCallback;
    private static System.Action s_buyAdsSuccessCallback;
    
    // Methods
    private void Start()
    {
        UnityEngine.Debug.Log(message:  "RemoveAdsPopupView Start .");
    }
    public static void Show(System.Action _buyAdsClickCallback, System.Action _noBuyAdsClickCallback, System.Action _buyAdsSuccessCallback)
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "IAP", type:  "impression", position:  "NoAds2", onlyFirst:  false, extra:  "");
        UnityEngine.Debug.Log(message:  "RemoveAdsPopupView Show .");
        RemoveAdsPopupView.s_buyAdsClickCallback = _buyAdsClickCallback;
        RemoveAdsPopupView.s_noBuyAdsClickCallback = _noBuyAdsClickCallback;
        RemoveAdsPopupView.s_buyAdsSuccessCallback = _buyAdsSuccessCallback;
        if(RemoveAdsPopupView.s_removeAdsPopupView != 0)
        {
                UnityEngine.Object.Destroy(obj:  RemoveAdsPopupView.s_removeAdsPopupView);
        }
        
        RemoveAdsPopupView.s_removeAdsPopupView = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  "Joypac/RemoveAdsPopupView"));
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        RemoveAdsPopupView.s_removeAdsPopupView.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public static void Hide()
    {
        if(0 == RemoveAdsPopupView.s_removeAdsPopupView)
        {
                return;
        }
        
        RemoveAdsPopupView.s_removeAdsPopupView.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  RemoveAdsPopupView.s_removeAdsPopupView.gameObject);
    }
    public void OnBuyadsBtnClick()
    {
        UnityEngine.Debug.Log(message:  "On BuyadsBtn click");
        if(RemoveAdsPopupView.s_buyAdsClickCallback != null)
        {
                RemoveAdsPopupView.s_buyAdsClickCallback.Invoke();
        }
        
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "IAP", type:  "click", position:  "NoAds2", onlyFirst:  false, extra:  "");
    }
    public void OnNoAdsBtnClick()
    {
        UnityEngine.Debug.Log(message:  "on close click");
        if(RemoveAdsPopupView.s_noBuyAdsClickCallback != null)
        {
                RemoveAdsPopupView.s_noBuyAdsClickCallback.Invoke();
        }
        
        RemoveAdsPopupView.Hide();
    }
    private void OnDestroy()
    {
    
    }
    public void BuyAdsSuccessed()
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "IAP", type:  "success", position:  "NoAds2", onlyFirst:  false, extra:  "");
        RemoveAdsPopupView.Hide();
        if(RemoveAdsPopupView.s_buyAdsSuccessCallback == null)
        {
                return;
        }
        
        RemoveAdsPopupView.s_buyAdsSuccessCallback.Invoke();
    }
    public RemoveAdsPopupView()
    {
    
    }

}
