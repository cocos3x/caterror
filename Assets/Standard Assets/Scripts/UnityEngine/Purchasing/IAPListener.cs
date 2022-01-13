using UnityEngine;

namespace UnityEngine.Purchasing
{
    public class IAPListener : MonoBehaviour
    {
        // Fields
        public bool consumePurchase;
        public bool dontDestroyOnLoad;
        public UnityEngine.Purchasing.IAPListener.OnPurchaseCompletedEvent onPurchaseComplete;
        public UnityEngine.Purchasing.IAPListener.OnPurchaseFailedEvent onPurchaseFailed;
        
        // Methods
        private void OnEnable()
        {
            if(this.dontDestroyOnLoad != false)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.AddListener(listener:  this);
        }
        private void OnDisable()
        {
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.RemoveListener(listener:  this);
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "IAPListener.ProcessPurchase(PurchaseEventArgs {0} - {1})", arg0:  e, arg1:  e.purchasedProduct.definition.id));
            this.onPurchaseComplete.Invoke(arg0:  e.purchasedProduct);
            bool val_7 = this.consumePurchase;
            val_7 = val_7 ^ 1;
            return (UnityEngine.Purchasing.PurchaseProcessingResult)val_7 & 255;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
        {
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "IAPListener.OnPurchaseFailed(Product {0}, PurchaseFailureReason {1})", arg0:  product, arg1:  reason));
            this.onPurchaseFailed.Invoke(arg0:  product, arg1:  reason);
        }
        public IAPListener()
        {
            this.consumePurchase = true;
            this.dontDestroyOnLoad = true;
        }
    
    }

}
