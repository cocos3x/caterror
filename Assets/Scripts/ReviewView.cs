using UnityEngine;
public class ReviewView : MonoBehaviour
{
    // Fields
    private static UnityEngine.RectTransform s_popup;
    protected static System.Action s_callback;
    
    // Methods
    public static void Show(System.Action _callback)
    {
        ReviewView.s_callback = _callback;
        ReviewView.s_popup = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  "Joypac/ReviewView"));
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        ReviewView.s_popup.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        JoypacUtils.AddReviewLog();
    }
    public void OnGoReivew()
    {
        JoypacUtils.OpenReviewURL();
        this.OnCancel();
    }
    public void OnCancel()
    {
        this.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  ReviewView.s_popup.gameObject);
        if(ReviewView.s_callback != null)
        {
                ReviewView.s_callback.Invoke();
        }
        
        ReviewView.s_callback = 0;
    }
    public ReviewView()
    {
    
    }

}
