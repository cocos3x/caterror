using UnityEngine;
public sealed class ShopManager : MonoBehaviour
{
    // Fields
    private static readonly int PurchasedTextId;
    private UnityEngine.CanvasGroup canvasGroup;
    private ProductUISet[] productUISets;
    private UnityEngine.UI.Button restoreButton;
    private UnityEngine.Events.UnityEvent onBeginInitializePurchaserEvent;
    private UnityEngine.Events.UnityEvent onInitializePurchaserSucceedEvent;
    private PurchaseInfomationEvent onInitializePurchaserFailedEvent;
    private UnityEngine.Events.UnityEvent onBeginPurchaseEvent;
    private UnityEngine.Events.UnityEvent onPurchaseSucceedEvent;
    private PurchaseInfomationEvent onPurchaseFailedEvent;
    private PurchaseInfomationEvent onRestoreResultEvent;
    
    // Methods
    private void Awake()
    {
        val_1.onBeginInitializePurchaserEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this.onBeginInitializePurchaserEvent, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
        val_1.onInitializePurchaserSucceedEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this.onInitializePurchaserSucceedEvent, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
        val_1.onInitializePurchaserSucceedEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopManager::InitializeUI()));
        val_1.onInitializePurchaserFailedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this.onInitializePurchaserFailedEvent, method:  public System.Void UnityEngine.Events.UnityEvent<System.String, System.String>::Invoke(System.String arg0, System.String arg1)));
        val_1.onBeginPurchaseEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this.onBeginPurchaseEvent, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
        val_1.onPurchaseSucceedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this, method:  System.Void ShopManager::PurchaseSucceed(string s1, string s2)));
        val_1.onPurchaseFailedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this.onPurchaseFailedEvent, method:  public System.Void UnityEngine.Events.UnityEvent<System.String, System.String>::Invoke(System.String arg0, System.String arg1)));
        val_1.onPurchaseFailedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this, method:  System.Void ShopManager::EnableCanvasGroupInteractable(string s1, string s2)));
        val_1.onBeginRestoreEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopManager::DisableCanvasGroupInteractable()));
        val_1.onRestoreResultEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this.onRestoreResultEvent, method:  public System.Void UnityEngine.Events.UnityEvent<System.String, System.String>::Invoke(System.String arg0, System.String arg1)));
        val_1.onRestoreResultEvent.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this, method:  System.Void ShopManager::EnableCanvasGroupInteractable(string s1, string s2)));
        if((val_1.storeController != null) && (val_1.storeExtensionProvider != null))
        {
                this.onInitializePurchaserSucceedEvent.Invoke();
            this.InitializeUI();
        }
        else
        {
                if(val_1.initializeCoroutine == null)
        {
                SingletonMonoBehaviour<Purchaser>.Instance.InitializePurchasing();
        }
        
        }
        
        this.restoreButton.gameObject.SetActive(value:  false);
    }
    private void PurchaseSucceed(string s1, string s2)
    {
        this.onPurchaseSucceedEvent.Invoke();
        this.InitializeUI();
    }
    private void EnableCanvasGroupInteractable(string s1, string s2)
    {
        this.SetCanvasGroupInteractable(interactable:  true);
    }
    private void DisableCanvasGroupInteractable()
    {
        this.SetCanvasGroupInteractable(interactable:  false);
    }
    private void InitializeUI()
    {
        UnityEngine.Purchasing.Product[] val_25;
        var val_26;
        UnityEngine.Purchasing.Product val_27;
        ProductUISet val_28;
        NigenekoPurchasing.ProductType val_29;
        System.Collections.Generic.List<System.String> val_30;
        var val_31;
        var val_32;
        this.SetCanvasGroupInteractable(interactable:  true);
        System.Collections.Generic.List<System.String> val_2 = SingletonMonoBehaviour<Purchaser>.Instance.LoadPurchasedNonConsumableItemIdList();
        Purchaser val_3 = SingletonMonoBehaviour<Purchaser>.Instance;
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_25 = val_3.storeController.products.all;
        val_26 = 0;
        goto label_9;
        label_79:
        val_27 = val_25[0];
        val_28 = 0;
        label_21:
        if(val_28 >= this.productUISets.Length)
        {
            goto label_51;
        }
        
        ShopManager.<>c__DisplayClass15_0 val_7 = new ShopManager.<>c__DisplayClass15_0();
        .<>4__this = this;
        .component = this.productUISets[0];
        val_29 = (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.itemId;
        UniRx.Unit..cctor();
        mem2[0] = null;
        val_28 = val_28 + 1;
        if((val_27.definition.id.Contains(value:  val_29.ToString())) == false)
        {
            goto label_21;
        }
        
        (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.button.onClick.RemoveAllListeners();
        val_30 = val_2;
        if(val_30 == 0)
        {
                val_30 = val_2;
        }
        
        if((val_30.Exists(match:  new System.Predicate<System.String>(object:  val_7, method:  System.Boolean ShopManager.<>c__DisplayClass15_0::<InitializeUI>b__0(string id)))) == false)
        {
            goto label_26;
        }
        
        if(((ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.priceText) != 0)
        {
                val_31 = null;
            val_31 = null;
            val_29 = ShopManager.PurchasedTextId;
            string val_17 = SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  val_29);
        }
        
        (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.button.interactable = false;
        val_32 = 0;
        goto label_39;
        label_43:
        (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.itemObjects[0].SetActive(value:  false);
        val_32 = 1;
        label_39:
        if(val_32 < ((ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.itemObjects.Length))
        {
            goto label_43;
        }
        
        val_28 = (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component;
        val_27 = (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.soldOutObject;
        if(val_27 == 0)
        {
            goto label_51;
        }
        
        val_28 = (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component;
        (ShopManager.<>c__DisplayClass15_0)[1152921511945633776].component.soldOutObject.SetActive(value:  true);
        goto label_51;
        label_26:
        ShopManager.<>c__DisplayClass15_1 val_19 = new ShopManager.<>c__DisplayClass15_1();
        if(val_19 != null)
        {
                val_29 = val_19;
            .CS$<>8__locals1 = val_7;
        }
        else
        {
                mem[24] = val_7;
            val_29 = 24;
        }
        
        if(this.productUISets[0x0][0].priceText != 0)
        {
                string val_22 = val_27.metadata.localizedPriceString;
        }
        
        if(val_19 != null)
        {
                .itemId = this.productUISets[0x0][0].itemId;
        }
        else
        {
                mem[16] = this.productUISets[0x0][0].itemId;
        }
        
        this.productUISets[0x0][0].button.interactable = true;
        val_28 = .component;
        UnityEngine.Events.UnityAction val_24 = null;
        val_27 = val_24;
        val_24 = new UnityEngine.Events.UnityAction(object:  val_19, method:  System.Void ShopManager.<>c__DisplayClass15_1::<InitializeUI>b__1());
        this.productUISets[0x0][0].button.onClick.AddListener(call:  val_24);
        label_51:
        val_25 = val_25;
        val_26 = val_26 + 1;
        label_9:
        if(val_26 < (val_6 + 24))
        {
            goto label_79;
        }
    
    }
    public void SetCanvasGroupInteractable(bool interactable)
    {
        interactable = interactable;
        this.canvasGroup.interactable = interactable;
    }
    private void OnDestroy()
    {
        Purchaser val_1 = SingletonMonoBehaviour<Purchaser>.Instance;
        val_1.onBeginInitializePurchaserEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this.onBeginInitializePurchaserEvent, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
        val_1.onInitializePurchaserSucceedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this.onInitializePurchaserSucceedEvent, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
        val_1.onInitializePurchaserSucceedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopManager::InitializeUI()));
        val_1.onInitializePurchaserFailedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this.onInitializePurchaserFailedEvent, method:  public System.Void UnityEngine.Events.UnityEvent<System.String, System.String>::Invoke(System.String arg0, System.String arg1)));
        val_1.onBeginPurchaseEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this.onBeginPurchaseEvent, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
        val_1.onPurchaseSucceedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this, method:  System.Void ShopManager::PurchaseSucceed(string s1, string s2)));
        val_1.onPurchaseFailedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this.onPurchaseFailedEvent, method:  public System.Void UnityEngine.Events.UnityEvent<System.String, System.String>::Invoke(System.String arg0, System.String arg1)));
        val_1.onPurchaseFailedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this, method:  System.Void ShopManager::EnableCanvasGroupInteractable(string s1, string s2)));
        val_1.onBeginRestoreEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopManager::DisableCanvasGroupInteractable()));
        val_1.onRestoreResultEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this.onRestoreResultEvent, method:  public System.Void UnityEngine.Events.UnityEvent<System.String, System.String>::Invoke(System.String arg0, System.String arg1)));
        val_1.onRestoreResultEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String>(object:  this, method:  System.Void ShopManager::EnableCanvasGroupInteractable(string s1, string s2)));
    }
    public ShopManager()
    {
    
    }
    private static ShopManager()
    {
        ShopManager.PurchasedTextId = 10001;
    }

}
