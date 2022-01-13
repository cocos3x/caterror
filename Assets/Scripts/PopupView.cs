using UnityEngine;
public class PopupView : MonoBehaviour
{
    // Fields
    public static PopupView instance;
    protected static UnityEngine.RectTransform s_popup;
    protected static System.Action s_callback;
    protected UnityEngine.GameObject closeButton;
    protected UnityEngine.UI.Text descriptionText;
    
    // Methods
    protected virtual void Awake()
    {
        PopupView.instance = this;
    }
    public virtual void OnClose()
    {
        PopupView.s_popup.gameObject.SetActive(value:  false);
        UnityEngine.Object.Destroy(obj:  PopupView.s_popup.gameObject);
    }
    public virtual void OnOK()
    {
        if(PopupView.s_callback == null)
        {
                return;
        }
        
        PopupView.s_callback.Invoke();
    }
    protected virtual void OnDestroy()
    {
        PopupView.instance = 0;
        PopupView.s_callback = 0;
        if(this.descriptionText == null)
        {
            
        }
    
    }
    private bool Method<T>(bool parameter)
    {
        return (bool)parameter;
    }
    public static PopupView Show(System.Action _callback, bool _withCloseButton, string _descriptionStr)
    {
        PopupView.s_callback = _callback;
        if(PopupView.instance == 0)
        {
                PopupView.s_popup = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  "Joypac/PopupView"));
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            PopupView.s_popup.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        
        val_5.closeButton.SetActive(value:  _withCloseButton);
        if(val_5.descriptionText != null)
        {
                return (PopupView)PopupView.s_popup.GetComponent<PopupView>();
        }
        
        return (PopupView)PopupView.s_popup.GetComponent<PopupView>();
    }
    public PopupView()
    {
    
    }

}
