using UnityEngine;
public class JoypacIAPButton : MonoBehaviour
{
    // Fields
    private UnityEngine.Purchasing.IAPButton m_iapButton;
    
    // Properties
    public UnityEngine.Purchasing.IAPButton iAPButton { get; }
    
    // Methods
    public UnityEngine.Purchasing.IAPButton get_iAPButton()
    {
        if(this.m_iapButton != 0)
        {
                return (UnityEngine.Purchasing.IAPButton)this.m_iapButton;
        }
        
        if(this.gameObject != 0)
        {
                if((this.gameObject.GetComponent<UnityEngine.Purchasing.IAPButton>()) != 0)
        {
                this.m_iapButton = this.gameObject.GetComponent<UnityEngine.Purchasing.IAPButton>();
            return (UnityEngine.Purchasing.IAPButton)this.m_iapButton;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "this.gameObject != null && this.gameObject.GetComponent<IAPButton>() != null");
        return (UnityEngine.Purchasing.IAPButton)this.m_iapButton;
    }
    public virtual void Start()
    {
        if((this.gameObject.GetComponent<UnityEngine.UI.Button>()) != 0)
        {
                1152921509534201120 = new UnityEngine.Events.UnityAction();
            1152921509534201120 = new UnityEngine.Events.UnityAction(object:  this, method:  typeof(JoypacIAPButton).__il2cppRuntimeField_180);
            this.gameObject.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction());
        }
        
        if(this.iAPButton == 0)
        {
                return;
        }
        
        UnityEngine.Purchasing.IAPButton val_10 = this.iAPButton;
        UnityEngine.Events.UnityAction<UnityEngine.Purchasing.Product> val_11 = new UnityEngine.Events.UnityAction<UnityEngine.Purchasing.Product>(object:  this, method:  typeof(JoypacIAPButton).__il2cppRuntimeField_190);
        val_10.onPurchaseComplete.AddListener(call:  null);
        UnityEngine.Purchasing.IAPButton val_12 = this.iAPButton;
        val_12.onPurchaseFailed.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>(object:  this, method:  typeof(JoypacIAPButton).__il2cppRuntimeField_1A0));
    }
    public virtual void OnClick()
    {
        if(this.iAPButton != 0)
        {
                UnityEngine.Purchasing.IAPButton val_4 = this.iAPButton;
            if((UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.GetProduct(productID:  val_4.productId)) != null)
        {
                PopLoadingView.Show();
            this.gameObject.GetComponent<UnityEngine.UI.Button>().interactable = false;
            return;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "还未初始化 或者 productid 出错");
    }
    public virtual void OnSuccessed(UnityEngine.Purchasing.Product product)
    {
        PopLoadingView.Hide();
    }
    public virtual void OnFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason purchaseFailureReason)
    {
        PopLoadingView.Hide();
        this.gameObject.GetComponent<UnityEngine.UI.Button>().interactable = true;
    }
    public JoypacIAPButton()
    {
    
    }

}
