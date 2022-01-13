using UnityEngine;

namespace UnityEngine.Purchasing
{
    public class IAPButton : MonoBehaviour
    {
        // Fields
        public string productId;
        public UnityEngine.Purchasing.IAPButton.ButtonType buttonType;
        public bool consumePurchase;
        public UnityEngine.Purchasing.IAPButton.OnPurchaseCompletedEvent onPurchaseComplete;
        public UnityEngine.Purchasing.IAPButton.OnPurchaseFailedEvent onPurchaseFailed;
        public UnityEngine.Purchasing.IAPButton.OnRestoreCompletedEvent onRestoreComplete;
        public UnityEngine.Purchasing.IAPButton.OnRestoreFailedEvent onRestoreFailed;
        public UnityEngine.UI.Text titleText;
        public UnityEngine.UI.Text descriptionText;
        public UnityEngine.UI.Text priceText;
        
        // Methods
        private void Start()
        {
            UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
            if(this.buttonType != 1)
            {
                    if(this.buttonType != 0)
            {
                    return;
            }
            
                if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
            {
                    val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.Purchasing.IAPButton::PurchaseProduct()));
            }
            
                if((System.String.IsNullOrEmpty(value:  this.productId)) != false)
            {
                    UnityEngine.Debug.LogError(message:  "IAPButton productId is empty");
            }
            
                if((UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.HasProductInCatalog(productID:  this.productId)) == true)
            {
                    return;
            }
            
                UnityEngine.Debug.LogWarning(message:  "The product catalog has no product with the ID \"" + this.productId + "\"");
                return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
            {
                    return;
            }
            
            val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.Purchasing.IAPButton::Restore()));
        }
        private void OnEnable()
        {
            if(this.buttonType != 0)
            {
                    return;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.AddButton(button:  this);
            if(UnityEngine.Purchasing.CodelessIAPStoreListener.initializationComplete == false)
            {
                    return;
            }
            
            this.UpdateText();
        }
        private void OnDisable()
        {
            if(this.buttonType != 0)
            {
                    return;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.RemoveButton(button:  this);
        }
        private void PurchaseProduct()
        {
            if(this.buttonType != 0)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "IAPButton.PurchaseProduct() with product ID: "("IAPButton.PurchaseProduct() with product ID: ") + this.productId);
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.InitiatePurchase(productID:  this.productId);
        }
        private void Restore()
        {
            object val_29;
            var val_33;
            System.Action<System.Boolean> val_34;
            IntPtr val_35;
            var val_37;
            val_29 = this;
            if(this.buttonType != 1)
            {
                    return;
            }
            
            if(UnityEngine.Application.platform != 18)
            {
                    if(UnityEngine.Application.platform != 19)
            {
                    if(UnityEngine.Application.platform != 20)
            {
                goto label_4;
            }
            
            }
            
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_4 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_29 = val_4.extensions;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_29.RestoreTransactions();
            return;
            label_4:
            if(UnityEngine.Application.platform != 8)
            {
                    if(UnityEngine.Application.platform != 1)
            {
                    if(UnityEngine.Application.platform != 31)
            {
                goto label_18;
            }
            
            }
            
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_10 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_33 = val_10.extensions;
            System.Action<System.Boolean> val_12 = null;
            val_34 = val_12;
            val_35 = System.Void UnityEngine.Purchasing.IAPButton::OnTransactionsRestored(bool success);
            val_12 = new System.Action<System.Boolean>(object:  this, method:  val_35);
            var val_32 = 0;
            val_37 = 1152921504851505160;
            val_32 = val_32 + 1;
            label_66:
            val_35 = 0;
            goto label_29;
            label_18:
            if((UnityEngine.Application.platform != 11) || (UnityEngine.Purchasing.StandardPurchasingModule.Instance().appStore != 4))
            {
                goto label_34;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_16 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_33 = 0;
            val_33 = val_33 + 1;
            goto label_40;
            label_34:
            if((UnityEngine.Application.platform != 11) || (UnityEngine.Purchasing.StandardPurchasingModule.Instance().appStore != 3))
            {
                goto label_45;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener val_20 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            var val_34 = 0;
            val_34 = val_34 + 1;
            goto label_51;
            label_45:
            UniRx.Unit..cctor();
            UnityEngine.Debug.LogWarning(message:  UnityEngine.Application.platform.ToString() + " is not a supported platform for the Codeless IAP restore button");
            return;
            label_40:
            val_33 = val_16.extensions;
            System.Action<System.Boolean> val_25 = null;
            val_34 = val_25;
            val_35 = System.Void UnityEngine.Purchasing.IAPButton::OnTransactionsRestored(bool success);
            val_25 = new System.Action<System.Boolean>(object:  this, method:  val_35);
            var val_35 = 0;
            val_37 = 1152921504851505160;
            val_35 = val_35 + 1;
            goto label_66;
            label_51:
            val_33 = val_20.extensions;
            System.Action<UnityEngine.Purchasing.RestoreTransactionIDState> val_27 = null;
            val_34 = val_27;
            val_35 = System.Void UnityEngine.Purchasing.IAPButton::<Restore>b__19_0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState);
            val_27 = new System.Action<UnityEngine.Purchasing.RestoreTransactionIDState>(object:  this, method:  val_35);
            var val_36 = 0;
            val_37 = 1152921504851505160;
            val_36 = val_36 + 1;
            goto label_66;
            label_29:
            val_33.RestoreTransactions(callback:  val_12);
        }
        private void OnTransactionsRestored(bool success)
        {
            bool val_1 = success;
            UnityEngine.Debug.Log(message:  "Transactions restored: "("Transactions restored: ") + val_1.ToString());
            if(val_1 == false)
            {
                goto label_3;
            }
            
            if(this.onRestoreComplete != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.onRestoreComplete.Invoke();
            return;
            label_3:
            if(this.onRestoreFailed != null)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "IAPButton.ProcessPurchase(PurchaseEventArgs {0} - {1})", arg0:  e, arg1:  e.purchasedProduct.definition.id));
            this.onPurchaseComplete.Invoke(arg0:  e.purchasedProduct);
            bool val_7 = this.consumePurchase;
            val_7 = val_7 ^ 1;
            return (UnityEngine.Purchasing.PurchaseProcessingResult)val_7 & 255;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
        {
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "IAPButton.OnPurchaseFailed(Product {0}, PurchaseFailureReason {1})", arg0:  product, arg1:  reason));
            this.onPurchaseFailed.Invoke(arg0:  product, arg1:  reason);
        }
        internal void UpdateText()
        {
            var val_19;
            UnityEngine.UI.Text val_20;
            val_19 = this;
            val_20 = UnityEngine.Purchasing.CodelessIAPStoreListener.Instance;
            UnityEngine.Purchasing.Product val_2 = val_20.GetProduct(productID:  this.productId);
            if(val_2 == null)
            {
                    return;
            }
            
            if(this.titleText != 0)
            {
                    string val_5 = val_2.metadata.localizedTitle;
            }
            
            if(this.descriptionText != 0)
            {
                    string val_8 = val_2.metadata.localizedDescription;
            }
            
            val_20 = this.priceText;
            if(val_20 == 0)
            {
                    return;
            }
            
            string val_11 = val_2.metadata.localizedPriceString;
            val_19 = ???;
            val_20 = ???;
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
        }
        public IAPButton()
        {
            this.consumePurchase = true;
        }
        private void <Restore>b__19_0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState)
        {
            this.OnTransactionsRestored(success:  ((restoreTransactionIDState & 4294967294) != 2) ? 1 : 0);
        }
    
    }

}
