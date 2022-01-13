using UnityEngine;
public class InterTipPopupView : MonoBehaviour
{
    // Fields
    private static UnityEngine.RectTransform s_interTipPopupView;
    private static System.Action s_closeCallback;
    
    // Methods
    private void Start()
    {
        UnityEngine.Debug.Log(message:  "InterTipPopupView Start .");
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  enumerator());
    }
    public static void Show(System.Action _closeCallback)
    {
        UnityEngine.Debug.Log(message:  "InterTipPopupView Show .");
        InterTipPopupView.s_closeCallback = _closeCallback;
        InterTipPopupView.s_interTipPopupView = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  "Joypac/InterTipPopupView"));
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        InterTipPopupView.s_interTipPopupView.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static void Hide()
    {
        if(InterTipPopupView.s_closeCallback != null)
        {
                InterTipPopupView.s_closeCallback.Invoke();
        }
        
        if(0 == InterTipPopupView.__il2cppRuntimeField_static_fields)
        {
                return;
        }
        
        InterTipPopupView.s_interTipPopupView.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  InterTipPopupView.s_interTipPopupView.gameObject);
    }
    private void OnDestroy()
    {
        InterTipPopupView.s_closeCallback = 0;
    }
    private System.Collections.IEnumerator enumerator()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new InterTipPopupView.<enumerator>d__6();
    }
    public InterTipPopupView()
    {
    
    }

}
