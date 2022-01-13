using UnityEngine;

namespace UnityEngine.Purchasing
{
    public class CodelessIAPStoreListener : IStoreListener
    {
        // Fields
        private static UnityEngine.Purchasing.CodelessIAPStoreListener instance;
        private System.Collections.Generic.List<UnityEngine.Purchasing.IAPButton> activeButtons;
        private System.Collections.Generic.List<UnityEngine.Purchasing.IAPListener> activeListeners;
        private static bool unityPurchasingInitialized;
        protected UnityEngine.Purchasing.IStoreController controller;
        protected UnityEngine.Purchasing.IExtensionProvider extensions;
        protected UnityEngine.Purchasing.ProductCatalog catalog;
        public static bool initializationComplete;
        
        // Properties
        public static UnityEngine.Purchasing.CodelessIAPStoreListener Instance { get; }
        public UnityEngine.Purchasing.IStoreController StoreController { get; }
        public UnityEngine.Purchasing.IExtensionProvider ExtensionProvider { get; }
        
        // Methods
        private static void InitializeCodelessPurchasingOnLoad()
        {
            if(val_1.enableCodelessAutoInitialization == false)
            {
                    return;
            }
            
            if(UnityEngine.Purchasing.ProductCatalog.LoadDefaultCatalog().IsEmpty() == true)
            {
                    return;
            }
            
            if(UnityEngine.Purchasing.CodelessIAPStoreListener.instance != null)
            {
                    return;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.CreateCodelessIAPStoreListenerInstance();
        }
        private static void InitializePurchasing()
        {
            UnityEngine.Purchasing.StandardPurchasingModule val_1 = UnityEngine.Purchasing.StandardPurchasingModule.Instance();
            val_1.useFakeStoreUIMode = 1;
            UnityEngine.Purchasing.ConfigurationBuilder val_3 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  val_1, rest:  System.Array.Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>());
            UnityEngine.Purchasing.IAPConfigurationHelper.PopulateConfigurationBuilder(builder: ref  val_3, catalog:  UnityEngine.Purchasing.CodelessIAPStoreListener.instance.catalog);
            UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  UnityEngine.Purchasing.CodelessIAPStoreListener.instance, builder:  val_3);
            UnityEngine.Purchasing.CodelessIAPStoreListener.unityPurchasingInitialized = true;
        }
        private CodelessIAPStoreListener()
        {
            this.activeButtons = new System.Collections.Generic.List<UnityEngine.Purchasing.IAPButton>();
            this.activeListeners = new System.Collections.Generic.List<UnityEngine.Purchasing.IAPListener>();
            this.catalog = UnityEngine.Purchasing.ProductCatalog.LoadDefaultCatalog();
        }
        public static UnityEngine.Purchasing.CodelessIAPStoreListener get_Instance()
        {
            UnityEngine.Purchasing.CodelessIAPStoreListener val_1 = UnityEngine.Purchasing.CodelessIAPStoreListener.instance;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            UnityEngine.Purchasing.CodelessIAPStoreListener.CreateCodelessIAPStoreListenerInstance();
            val_1 = UnityEngine.Purchasing.CodelessIAPStoreListener.instance;
            return val_1;
        }
        private static void CreateCodelessIAPStoreListenerInstance()
        {
            UnityEngine.Purchasing.CodelessIAPStoreListener.instance = new UnityEngine.Purchasing.CodelessIAPStoreListener();
            if(UnityEngine.Purchasing.CodelessIAPStoreListener.unityPurchasingInitialized != false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "Initializing UnityPurchasing via Codeless IAP");
            UnityEngine.Purchasing.CodelessIAPStoreListener.InitializePurchasing();
        }
        public UnityEngine.Purchasing.IStoreController get_StoreController()
        {
            return (UnityEngine.Purchasing.IStoreController)this.controller;
        }
        public UnityEngine.Purchasing.IExtensionProvider get_ExtensionProvider()
        {
            return (UnityEngine.Purchasing.IExtensionProvider)this.extensions;
        }
        public bool HasProductInCatalog(string productID)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_10 = 0;
            val_10 = val_10 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = this.catalog.allProducts.GetEnumerator();
            label_19:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            T val_7 = val_3.Current;
            if((System.String.op_Equality(a:  val_7 + 16, b:  productID)) == false)
            {
                goto label_19;
            }
            
            val_10 = 0;
            val_11 = 0;
            val_12 = 1;
            if(val_3 != null)
            {
                goto label_22;
            }
            
            goto label_28;
            label_12:
            val_10 = 0;
            val_11 = 0;
            val_12 = 0;
            if(val_3 != null)
            {
                goto label_22;
            }
            
            goto label_28;
            label_22:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_3.Dispose();
            label_28:
            if( == 1)
            {
                goto label_33;
            }
            
            if(62 == 64)
            {
                    return (bool)val_12;
            }
            
            val_12 = 0;
            if( == false)
            {
                    return (bool)val_12;
            }
            
            if(62 != 62)
            {
                goto label_36;
            }
            
            return (bool)val_12;
            label_33:
            if( == false)
            {
                goto label_38;
            }
            
            label_36:
            label_38:
            val_12 = 0;
            return (bool)val_12;
        }
        public UnityEngine.Purchasing.Product GetProduct(string productID)
        {
            if(this.controller != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                if(this.controller.products != null)
            {
                    if((System.String.IsNullOrEmpty(value:  productID)) == false)
            {
                goto label_7;
            }
            
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  "CodelessIAPStoreListener attempted to get unknown product " + productID);
            return 0;
            label_7:
            var val_8 = 0;
            val_8 = val_8 + 1;
            UnityEngine.Purchasing.ProductCollection val_6 = this.controller.products;
            if(val_6 != null)
            {
                    return val_6.WithID(id:  productID);
            }
            
            return val_6.WithID(id:  productID);
        }
        public void AddButton(UnityEngine.Purchasing.IAPButton button)
        {
            this.activeButtons.Add(item:  button);
        }
        public void RemoveButton(UnityEngine.Purchasing.IAPButton button)
        {
            bool val_1 = this.activeButtons.Remove(item:  button);
        }
        public void AddListener(UnityEngine.Purchasing.IAPListener listener)
        {
            this.activeListeners.Add(item:  listener);
        }
        public void RemoveListener(UnityEngine.Purchasing.IAPListener listener)
        {
            bool val_1 = this.activeListeners.Remove(item:  listener);
        }
        public void InitiatePurchase(string productID)
        {
            string val_5;
            var val_6;
            val_5 = productID;
            val_6 = this;
            if(this.controller == null)
            {
                goto label_1;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_5;
            label_1:
            UnityEngine.Debug.LogError(message:  "Purchase failed because Purchasing was not initialized correctly");
            List.Enumerator<T> val_1 = this.activeButtons.GetEnumerator();
            val_6 = 1152921511759626912;
            label_12:
            if(((-1437135560) & 1) == 0)
            {
                goto label_9;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_5)) == false)
            {
                goto label_12;
            }
            
            0.Id.OnPurchaseFailed(product:  0, reason:  0);
            goto label_12;
            label_5:
            this.controller.InitiatePurchase(productId:  val_5);
            return;
            label_9:
            UniRx.Unit..cctor();
        }
        public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
        {
            UnityEngine.Purchasing.CodelessIAPStoreListener.initializationComplete = true;
            this.controller = controller;
            this.extensions = extensions;
            List.Enumerator<T> val_1 = this.activeButtons.GetEnumerator();
            label_4:
            if(((-1436990776) & 1) == 0)
            {
                goto label_2;
            }
            
            0.Id.UpdateText();
            goto label_4;
            label_2:
            UniRx.Unit..cctor();
        }
        public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
        {
            UniRx.Unit..cctor();
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Purchasing failed to initialize. Reason: {0}", arg0:  error.ToString()));
        }
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            UnityEngine.Purchasing.PurchaseEventArgs val_19;
            var val_20;
            var val_21;
            var val_22;
            val_19 = e;
            val_20 = 0;
            val_21 = 0;
            val_22 = 0;
            goto label_1;
            label_11:
            UnityEngine.Purchasing.IAPButton val_1 = this.activeButtons.Item[0];
            if((System.String.op_Equality(a:  val_1.productId, b:  val_19.purchasedProduct.definition.id)) != false)
            {
                    val_22 = val_22 | (((this.activeButtons.Item[0].ProcessPurchase(e:  val_19)) == 0) ? 1 : 0);
                val_21 = 1;
            }
            
            val_20 = 1;
            label_1:
            if(val_20 < this.activeButtons.Count)
            {
                goto label_11;
            }
            
            List.Enumerator<T> val_10 = this.activeListeners.GetEnumerator();
            goto label_13;
            label_15:
            val_22 = val_22 | (((0.Id.ProcessPurchase(e:  val_19)) == 0) ? 1 : 0);
            val_21 = 1;
            label_13:
            if(((-1436637160) & 1) != 0)
            {
                goto label_15;
            }
            
            UniRx.Unit..cctor();
            if((val_21 & 1) != 0)
            {
                    return (UnityEngine.Purchasing.PurchaseProcessingResult)(~val_22) & 1;
            }
            
            val_19 = "Purchase not correctly processed for product \"" + val_19.purchasedProduct.definition.id + "\". Add an active IAPButton to process this purchase, or add an IAPListener to receive any unhandled purchase events.";
            UnityEngine.Debug.LogError(message:  val_19);
            return (UnityEngine.Purchasing.PurchaseProcessingResult)(~val_22) & 1;
        }
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
        {
            var val_3;
            UnityEngine.Purchasing.Product val_13 = product;
            List.Enumerator<T> val_1 = this.activeButtons.GetEnumerator();
            label_7:
            label_6:
            if(((-1436405904) & 1) == 0)
            {
                goto label_2;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_13.definition.id)) == false)
            {
                goto label_6;
            }
            
            val_3.Id.OnPurchaseFailed(product:  val_13 = product, reason:  reason);
            goto label_7;
            label_2:
            UniRx.Unit..cctor();
            List.Enumerator<T> val_8 = this.activeListeners.GetEnumerator();
            label_19:
            if(((-1436405928) & 1) == 0)
            {
                goto label_17;
            }
            
            0.Id.OnPurchaseFailed(product:  val_13, reason:  reason);
            goto label_19;
            label_17:
            UniRx.Unit..cctor();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            val_13 = "Failed purchase not correctly handled for product \"" + val_13.definition.id + "\". Add an active IAPButton to handle this failure, or add an IAPListener to receive any unhandled purchase failures.";
            UnityEngine.Debug.LogError(message:  val_13);
        }
    
    }

}
