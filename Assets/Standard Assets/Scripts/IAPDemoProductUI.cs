using UnityEngine;
public class IAPDemoProductUI : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Button purchaseButton;
    public UnityEngine.UI.Button receiptButton;
    public UnityEngine.UI.Text titleText;
    public UnityEngine.UI.Text descriptionText;
    public UnityEngine.UI.Text priceText;
    public UnityEngine.UI.Text statusText;
    private string m_ProductID;
    private System.Action<string> m_PurchaseCallback;
    private string m_Receipt;
    
    // Methods
    public void SetProduct(UnityEngine.Purchasing.Product p, System.Action<string> purchaseCallback)
    {
        string val_2 = p.metadata.localizedTitle;
        string val_4 = p.metadata.localizedDescription;
        string val_6 = p.metadata.localizedPriceString;
        this.receiptButton.interactable = p.hasReceipt;
        if(p != null)
        {
                this.m_Receipt = p.receipt;
        }
        else
        {
                this.m_Receipt = 0.receipt;
        }
        
        this.m_ProductID = p.definition.id;
        this.m_PurchaseCallback = purchaseCallback;
        var val_14 = (p.availableToPurchase != true) ? "Available" : "Unavailable";
        if(this.statusText == null)
        {
            
        }
    
    }
    public void SetPendingTime(int secondsRemaining)
    {
        string val_2 = "Pending " + secondsRemaining.ToString();
        if(this.statusText != null)
        {
                return;
        }
    
    }
    public void PurchaseButtonClick()
    {
        if(this.m_PurchaseCallback == null)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.m_ProductID)) != false)
        {
                return;
        }
        
        this.m_PurchaseCallback.Invoke(obj:  this.m_ProductID);
    }
    public void ReceiptButtonClick()
    {
        if((System.String.IsNullOrEmpty(value:  this.m_Receipt)) != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Receipt for " + this.m_ProductID + ": "(": ") + this.m_Receipt);
    }
    public IAPDemoProductUI()
    {
    
    }

}
