using UnityEngine;
public sealed class Purchaser : SingletonMonoBehaviour<Purchaser>, IStoreListener
{
    // Fields
    private static readonly int InitializeFailedTitleTextId;
    private static readonly int InitializeFailedTextId;
    private static readonly int RestoreTextId;
    private static readonly int RestoreSucceededTextId;
    private static readonly int RestoreFailedTextId;
    private static readonly int PurchaseFailedTitleTextId;
    private static readonly int ReceiptValidationFailedTextId;
    private static readonly int PurchaseCancelTextId;
    private static readonly int UserCancelledTextId;
    private static readonly int PurchasingUnavailableTextId;
    private static readonly int ExistingPurchasePendingTextId;
    private static readonly int ProductUnavailableTextId;
    private static readonly int PaymentDeclinedTextId;
    private static readonly int UnknownTextId;
    private static readonly int UnLinkTextId;
    private static readonly int PurchaseSucceedTextId;
    private static readonly int PurchaseSucceedTextFormatId;
    private UnityEngine.Events.UnityEvent onBeginInitializePurchaserEvent;
    private UnityEngine.Events.UnityEvent onInitializePurchaserSucceedEvent;
    private PurchaseInfomationEvent onInitializePurchaserFailedEvent;
    private UnityEngine.Events.UnityEvent onBeginPurchaseEvent;
    private PurchaseSucceedEvent onPurchaseSucceedEvent;
    private PurchaseInfomationEvent onPurchaseFailedEvent;
    private UnityEngine.Events.UnityEvent onBeginRestoreEvent;
    private PurchaseInfomationEvent onRestoreResultEvent;
    private UnityEngine.Purchasing.IStoreController storeController;
    private UnityEngine.Purchasing.IExtensionProvider storeExtensionProvider;
    private UnityEngine.Coroutine initializeCoroutine;
    
    // Properties
    public UnityEngine.Events.UnityEvent OnBeginInitializePurchaserEvent { get; }
    public UnityEngine.Events.UnityEvent OnInitializePurchaserSucceedEvent { get; }
    public PurchaseInfomationEvent OnInitializePurchaserFailedEvent { get; }
    public UnityEngine.Events.UnityEvent OnBeginPurchaseEvent { get; }
    public PurchaseSucceedEvent OnPurchaseSucceedEvent { get; }
    public PurchaseInfomationEvent OnPurchaseFailedEvent { get; }
    public UnityEngine.Events.UnityEvent OnBeginRestoreEvent { get; }
    public PurchaseInfomationEvent OnRestoreResultEvent { get; }
    public UnityEngine.Purchasing.IStoreController StoreController { get; }
    
    // Methods
    public UnityEngine.Events.UnityEvent get_OnBeginInitializePurchaserEvent()
    {
        return (UnityEngine.Events.UnityEvent)this.onBeginInitializePurchaserEvent;
    }
    public UnityEngine.Events.UnityEvent get_OnInitializePurchaserSucceedEvent()
    {
        return (UnityEngine.Events.UnityEvent)this.onInitializePurchaserSucceedEvent;
    }
    public PurchaseInfomationEvent get_OnInitializePurchaserFailedEvent()
    {
        return (PurchaseInfomationEvent)this.onInitializePurchaserFailedEvent;
    }
    public UnityEngine.Events.UnityEvent get_OnBeginPurchaseEvent()
    {
        return (UnityEngine.Events.UnityEvent)this.onBeginPurchaseEvent;
    }
    public PurchaseSucceedEvent get_OnPurchaseSucceedEvent()
    {
        return (PurchaseSucceedEvent)this.onPurchaseSucceedEvent;
    }
    public PurchaseInfomationEvent get_OnPurchaseFailedEvent()
    {
        return (PurchaseInfomationEvent)this.onPurchaseFailedEvent;
    }
    public UnityEngine.Events.UnityEvent get_OnBeginRestoreEvent()
    {
        return (UnityEngine.Events.UnityEvent)this.onBeginRestoreEvent;
    }
    public PurchaseInfomationEvent get_OnRestoreResultEvent()
    {
        return (PurchaseInfomationEvent)this.onRestoreResultEvent;
    }
    public UnityEngine.Purchasing.IStoreController get_StoreController()
    {
        return (UnityEngine.Purchasing.IStoreController)this.storeController;
    }
    private void Awake()
    {
        this.onInitializePurchaserFailedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  0, method:  public static System.Void PurchaseInformationDialogManager::ShowDialog(string title, string explanation)));
        this.onPurchaseSucceedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  0, method:  public static System.Void PurchaseInformationDialogManager::ShowDialog(string title, string explanation)));
        this.onPurchaseFailedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  0, method:  public static System.Void PurchaseInformationDialogManager::ShowDialog(string title, string explanation)));
        this.onRestoreResultEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  0, method:  public static System.Void PurchaseInformationDialogManager::ShowDialog(string title, string explanation)));
    }
    public void InitializePurchasing()
    {
        object val_15;
        var val_16;
        var val_17;
        var val_18;
        string val_19;
        var val_20;
        var val_21;
        val_15 = this;
        if(this.storeController != null)
        {
                if(this.storeExtensionProvider != null)
        {
                return;
        }
        
        }
        
        if(this.initializeCoroutine != null)
        {
                return;
        }
        
        this.onBeginInitializePurchaserEvent.Invoke();
        this.initializeCoroutine = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  20f, act:  new System.Action(object:  this, method:  System.Void Purchaser::<InitializePurchasing>b__47_0()));
        UnityEngine.Purchasing.StandardPurchasingModule.Instance().useFakeStoreUIMode = 1;
        UnityEngine.Purchasing.ConfigurationBuilder val_6 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  UnityEngine.Purchasing.StandardPurchasingModule.Instance(), rest:  System.Array.Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>());
        val_16 = null;
        val_16 = null;
        val_17 = 0;
        val_18 = 1152921504989482960;
        goto label_10;
        label_26:
        val_15 = mem[PurchaseConst.PendingProductDictionaryTag + 16];
        val_15 = PurchaseConst.PendingProductDictionaryTag.m_stringLength;
        UnityEngine.Purchasing.IDs val_7 = new UnityEngine.Purchasing.IDs();
        string[] val_8 = new string[1];
        val_8[0] = "AppleAppStore";
        val_7.Add(id:  PurchaseConst.PendingProductDictionaryTag + 24, stores:  val_8);
        val_19 = mem[PurchaseConst.PendingProductDictionaryTag + 32];
        val_19 = PurchaseConst.PendingProductDictionaryTag + 32;
        val_18 = 1152921504989482960;
        string[] val_9 = new string[1];
        val_9[0] = "GooglePlay";
        val_7.Add(id:  val_19, stores:  val_9);
        UnityEngine.Purchasing.ConfigurationBuilder val_10 = val_6.AddProduct(id:  val_15, type:  0, storeIDs:  val_7);
        val_17 = 1;
        label_10:
        if(val_17 < PurchaseConst.ConsumableItems.Length)
        {
            goto label_26;
        }
        
        val_20 = null;
        val_20 = null;
        val_21 = 0;
        goto label_29;
        label_45:
        val_15 = mem[PurchaseConst.PendingProductDictionaryTag + 16];
        val_15 = PurchaseConst.PendingProductDictionaryTag.m_stringLength;
        UnityEngine.Purchasing.IDs val_11 = new UnityEngine.Purchasing.IDs();
        string[] val_12 = new string[1];
        val_12[0] = "AppleAppStore";
        val_11.Add(id:  PurchaseConst.PendingProductDictionaryTag + 24, stores:  val_12);
        val_19 = mem[PurchaseConst.PendingProductDictionaryTag + 32];
        val_19 = PurchaseConst.PendingProductDictionaryTag + 32;
        val_18 = 1152921504989482960;
        string[] val_13 = new string[1];
        val_13[0] = "GooglePlay";
        val_11.Add(id:  val_19, stores:  val_13);
        UnityEngine.Purchasing.ConfigurationBuilder val_14 = val_6.AddProduct(id:  val_15, type:  1, storeIDs:  val_11);
        val_21 = 1;
        label_29:
        if(val_21 < PurchaseConst.NonConsumableItems.Length)
        {
            goto label_45;
        }
        
        UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  this, builder:  val_6);
    }
    public bool IsInitialized()
    {
        if(this.storeController == null)
        {
                return false;
        }
        
        return (bool)(this.storeExtensionProvider != 0) ? 1 : 0;
    }
    public bool IsInitializing()
    {
        return (bool)(this.initializeCoroutine != 0) ? 1 : 0;
    }
    public void BuyConsumable(NigenekoPurchasing.ProductType purchaseItemId)
    {
        UniRx.Unit..cctor();
        this.BuyProductID(productId:  purchaseItemId.ToString());
    }
    public void BuyNonConsumable(NigenekoPurchasing.ProductType purchaseItemId)
    {
        UniRx.Unit..cctor();
        this.BuyProductID(productId:  purchaseItemId.ToString());
    }
    public void BuyProduct(NigenekoPurchasing.ProductType productType)
    {
        UniRx.Unit..cctor();
        this.BuyProductID(productId:  productType.ToString());
    }
    public void BuyProductID(string productId)
    {
        UnityEngine.Events.UnityEvent val_5;
        UnityEngine.Purchasing.IStoreController val_6;
        var val_8;
        val_5 = this;
        val_6 = this.storeController;
        if(val_6 == null)
        {
                return;
        }
        
        if(this.storeExtensionProvider == null)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_6 = val_6.products;
        val_8 = 0;
        UnityEngine.Purchasing.Product val_3 = val_6.WithID(id:  productId);
        if(val_3 == null)
        {
                return;
        }
        
        if(val_3.availableToPurchase == false)
        {
                return;
        }
        
        val_6 = this.storeController;
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_8 = 2;
        val_6.InitiatePurchase(product:  val_3);
        val_5 = this.onBeginPurchaseEvent;
        val_5.Invoke();
    }
    public void RestorePurchases()
    {
    
    }
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
    {
        this.storeController = controller;
        this.storeExtensionProvider = extensions;
        this.onInitializePurchaserSucceedEvent.Invoke();
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.initializeCoroutine);
        this.initializeCoroutine = 0;
    }
    public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
    {
        var val_5 = null;
        this.onInitializePurchaserFailedEvent.Invoke(arg0:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.InitializeFailedTitleTextId), arg1:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.InitializeFailedTextId));
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.initializeCoroutine);
        this.initializeCoroutine = 0;
    }
    public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs args)
    {
        var val_9;
        var val_10;
        var val_11;
        .<>4__this = this;
        UnityEngine.Purchasing.Product val_2 = args.purchasedProduct;
        .product = val_2;
        val_9 = val_2.definition;
        if(val_9.id == null)
        {
            goto label_5;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = System.Linq.Enumerable.ToList<PurchaseItem>(source:  PurchaseConst.NonConsumableItems);
        if((val_9.Exists(match:  new System.Predicate<PurchaseItem>(object:  new Purchaser.<>c__DisplayClass57_0(), method:  System.Boolean Purchaser.<>c__DisplayClass57_0::<ProcessPurchase>b__0(PurchaseItem pi)))) == false)
        {
            goto label_9;
        }
        
        val_11 = (~(this.PurchaseSuccess(product:  (Purchaser.<>c__DisplayClass57_0)[1152921511968232832].product))) & 1;
        return (UnityEngine.Purchasing.PurchaseProcessingResult)val_11;
        label_5:
        val_11 = 1;
        return (UnityEngine.Purchasing.PurchaseProcessingResult)val_11;
        label_9:
        val_11 = 0;
        return (UnityEngine.Purchasing.PurchaseProcessingResult)val_11;
    }
    private bool PurchaseSuccess(UnityEngine.Purchasing.Product product)
    {
        UnityEngine.Purchasing.Product val_26;
        Purchaser val_27;
        var val_28;
        var val_29;
        val_26 = product;
        val_27 = this;
        Purchaser.<>c__DisplayClass58_0 val_1 = new Purchaser.<>c__DisplayClass58_0();
        if(val_1 != null)
        {
                .<>4__this = val_27;
        }
        else
        {
                mem[16] = val_27;
        }
        
        .product = val_26;
        if((this.storeController == null) || (this.storeExtensionProvider == null))
        {
            goto label_4;
        }
        
        UniRx.Unit..cctor();
        if((System.String.Equals(a:  val_26.definition.id, b:  0.ToString(), comparisonType:  4)) == false)
        {
            goto label_8;
        }
        
        GameData val_6 = GameDataManager.GameData;
        val_6.isDeleteAd = true;
        GameDataManager.SaveGameData();
        JoypacUtils.SetRemoveAdBought();
        val_28 = null;
        val_28 = null;
        bool val_9 = System.Linq.Enumerable.ToList<PurchaseItem>(source:  PurchaseConst.NonConsumableItems).Exists(match:  new System.Predicate<PurchaseItem>(object:  val_1, method:  System.Boolean Purchaser.<>c__DisplayClass58_0::<PurchaseSuccess>b__1(PurchaseItem pi)));
        if(val_9 == false)
        {
            goto label_15;
        }
        
        System.Collections.Generic.List<System.String> val_10 = val_9.LoadPurchasedNonConsumableItemIdList();
        if((val_10.Exists(match:  new System.Predicate<System.String>(object:  val_1, method:  System.Boolean Purchaser.<>c__DisplayClass58_0::<PurchaseSuccess>b__3(string id)))) == true)
        {
            goto label_21;
        }
        
        val_10.Add(item:  (Purchaser.<>c__DisplayClass58_0)[1152921511968496384].product.definition.id);
        val_10.SavePurchasedNonConsumableItemIdList(list:  val_10);
        goto label_21;
        label_4:
        System.Action val_15 = null;
        val_27 = val_15;
        val_15 = new System.Action(object:  val_1, method:  System.Void Purchaser.<>c__DisplayClass58_0::<PurchaseSuccess>b__0());
        val_15.WaitOneFrame(callback:  val_15);
        return false;
        label_8:
        val_29 = null;
        val_29 = null;
        val_26 = SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.PurchaseFailedTitleTextId);
        this.onPurchaseFailedEvent.Invoke(arg0:  val_26, arg1:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.ProductUnavailableTextId));
        return false;
        label_15:
        bool val_20 = this.ConfirmPendingPurchase(product:  (Purchaser.<>c__DisplayClass58_0)[1152921511968496384].product);
        label_21:
        System.Action val_21 = new System.Action(object:  val_1, method:  System.Void Purchaser.<>c__DisplayClass58_0::<PurchaseSuccess>b__2());
        val_21.WaitOneFrame(callback:  val_21);
        return false;
    }
    public bool ConfirmPendingPurchase(UnityEngine.Purchasing.Product product)
    {
        var val_3;
        if((this.storeController != null) && (this.storeExtensionProvider != null))
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
        }
        else
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        this.storeController.ConfirmPendingPurchase(product:  product);
        val_3 = 1;
        return (bool)val_3;
    }
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
    {
        var val_10;
        var val_12;
        int val_13;
        var val_16;
        .<>4__this = this;
        val_10 = null;
        val_10 = null;
        .failedTitle = SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.PurchaseFailedTitleTextId);
        if(failureReason <= 5)
        {
                var val_10 = 28871320 + (failureReason) << 2;
            val_10 = val_10 + 28871320;
        }
        else
        {
                val_16 = null;
            val_12 = SingletonMonoBehaviour<LanguageManager>.Instance;
            val_16 = null;
            val_13 = Purchaser.UnknownTextId;
            .failedExplanation = val_12.GetWordUI(id:  val_13);
            System.Action val_9 = new System.Action(object:  new Purchaser.<>c__DisplayClass60_0(), method:  System.Void Purchaser.<>c__DisplayClass60_0::<OnPurchaseFailed>b__0());
            val_9.WaitOneFrame(callback:  val_9);
        }
    
    }
    private bool HasNetworkConnection()
    {
        return (bool)(UnityEngine.Application.internetReachability != 0) ? 1 : 0;
    }
    public System.Collections.Generic.List<string> LoadPurchasedNonConsumableItemIdList()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if((UsayaStorageManager.Exists(filename:  3, tag:  PurchaseConst.PurchasedNonConsumableItemIdListTag)) != false)
        {
                val_7 = null;
            val_7 = null;
            val_8 = UnityEngine.JsonUtility.FromJson<Serialization<System.String>>(json:  UsayaStorageManager.Load<System.String>(filename:  3, tag:  PurchaseConst.PurchasedNonConsumableItemIdListTag)).ToList();
            return (System.Collections.Generic.List<System.String>)val_8;
        }
        
        System.Collections.Generic.List<System.String> val_5 = null;
        val_8 = val_5;
        val_5 = new System.Collections.Generic.List<System.String>();
        return (System.Collections.Generic.List<System.String>)val_8;
    }
    private void SavePurchasedNonConsumableItemIdList(System.Collections.Generic.List<string> list)
    {
        var val_3 = null;
        UsayaStorageManager.Save<System.String>(filename:  3, tag:  PurchaseConst.PurchasedNonConsumableItemIdListTag, value:  UnityEngine.JsonUtility.ToJson(obj:  new Serialization<System.String>(target:  list)));
    }
    private System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> LoadPendingProductDictionary()
    {
        return (System.Collections.Generic.Dictionary<System.String, UnityEngine.Purchasing.Product>)new System.Collections.Generic.Dictionary<System.String, UnityEngine.Purchasing.Product>();
    }
    private void SavePendingProductDictionary(System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> dictionary)
    {
    
    }
    private void WaitOneFrame(System.Action callback)
    {
        .callback = callback;
        new UnityEngine.GameObject().AddComponent<OneActionComponent>().SetAction(action:  new System.Action(object:  new Purchaser.<>c__DisplayClass66_0(), method:  System.Void Purchaser.<>c__DisplayClass66_0::<WaitOneFrame>b__0()));
    }
    public Purchaser()
    {
        this.onBeginInitializePurchaserEvent = new UnityEngine.Events.UnityEvent();
        this.onInitializePurchaserSucceedEvent = new UnityEngine.Events.UnityEvent();
        this.onInitializePurchaserFailedEvent = new PurchaseInfomationEvent();
        this.onBeginPurchaseEvent = new UnityEngine.Events.UnityEvent();
        this.onPurchaseSucceedEvent = new PurchaseSucceedEvent();
        this.onPurchaseFailedEvent = new PurchaseInfomationEvent();
        this.onBeginRestoreEvent = new UnityEngine.Events.UnityEvent();
        this.onRestoreResultEvent = new PurchaseInfomationEvent();
    }
    private static Purchaser()
    {
        Purchaser.InitializeFailedTitleTextId = 20000;
        Purchaser.InitializeFailedTextId = 20001;
        Purchaser.RestoreTextId = 20002;
        Purchaser.RestoreSucceededTextId = 20003;
        Purchaser.RestoreFailedTextId = 20004;
        Purchaser.PurchaseFailedTitleTextId = 20005;
        Purchaser.ReceiptValidationFailedTextId = 20006;
        Purchaser.PurchaseCancelTextId = 20007;
        Purchaser.UserCancelledTextId = 20008;
        Purchaser.PurchasingUnavailableTextId = 20009;
        Purchaser.ExistingPurchasePendingTextId = 20010;
        Purchaser.ProductUnavailableTextId = 20011;
        Purchaser.PaymentDeclinedTextId = 20012;
        Purchaser.UnknownTextId = 20013;
        Purchaser.UnLinkTextId = 20014;
        Purchaser.PurchaseSucceedTextId = 20015;
        Purchaser.PurchaseSucceedTextFormatId = 20016;
    }
    private void <InitializePurchasing>b__47_0()
    {
        var val_5 = null;
        this.onInitializePurchaserFailedEvent.Invoke(arg0:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.InitializeFailedTitleTextId), arg1:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.InitializeFailedTextId));
        this.initializeCoroutine = 0;
    }

}
