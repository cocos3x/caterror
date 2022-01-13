using UnityEngine;
public class IAPDemo : MonoBehaviour, IStoreListener
{
    // Fields
    private UnityEngine.Purchasing.IStoreController m_Controller;
    private UnityEngine.Purchasing.IAppleExtensions m_AppleExtensions;
    private UnityEngine.Purchasing.IMoolahExtension m_MoolahExtensions;
    private UnityEngine.Purchasing.ISamsungAppsExtensions m_SamsungExtensions;
    private UnityEngine.Purchasing.IMicrosoftExtensions m_MicrosoftExtensions;
    private UnityEngine.Purchasing.IUnityChannelExtensions m_UnityChannelExtensions;
    private UnityEngine.Purchasing.ITransactionHistoryExtensions m_TransactionHistoryExtensions;
    private UnityEngine.Purchasing.IGooglePlayStoreExtensions m_GooglePlayStoreExtensions;
    private bool m_IsGooglePlayStoreSelected;
    private bool m_IsSamsungAppsStoreSelected;
    private bool m_IsCloudMoolahStoreSelected;
    private bool m_IsUnityChannelSelected;
    private string m_LastTransactionID;
    private bool m_IsLoggedIn;
    private IAPDemo.UnityChannelLoginHandler unityChannelLoginHandler;
    private bool m_FetchReceiptPayloadOnPurchase;
    private bool m_PurchaseInProgress;
    private System.Collections.Generic.Dictionary<string, IAPDemoProductUI> m_ProductUIs;
    public UnityEngine.GameObject productUITemplate;
    public UnityEngine.RectTransform contentRect;
    public UnityEngine.UI.Button restoreButton;
    public UnityEngine.UI.Button loginButton;
    public UnityEngine.UI.Button validateButton;
    public UnityEngine.UI.Text versionText;
    
    // Methods
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
    {
        UnityEngine.Purchasing.IAppleExtensions val_40;
        IntPtr val_41;
        var val_44;
        this.m_Controller = controller;
        var val_35 = 0;
        val_35 = val_35 + 1;
        this.m_AppleExtensions = extensions;
        var val_36 = 0;
        val_36 = val_36 + 1;
        this.m_SamsungExtensions = extensions;
        var val_37 = 0;
        val_37 = val_37 + 1;
        this.m_MoolahExtensions = extensions;
        var val_38 = 0;
        val_38 = val_38 + 1;
        this.m_MicrosoftExtensions = extensions;
        var val_39 = 0;
        val_39 = val_39 + 1;
        this.m_UnityChannelExtensions = extensions;
        var val_40 = 0;
        val_40 = val_40 + 1;
        this.m_TransactionHistoryExtensions = extensions;
        var val_41 = 0;
        val_41 = val_41 + 1;
        this.m_GooglePlayStoreExtensions = extensions;
        var val_42 = 0;
        val_42 = val_42 + 1;
        UnityEngine.Purchasing.Product[] val_10 = controller.products.all;
        this.InitUI(items:  0);
        val_40 = this.m_AppleExtensions;
        System.Action<UnityEngine.Purchasing.Product> val_11 = null;
        val_41 = System.Void IAPDemo::OnDeferred(UnityEngine.Purchasing.Product item);
        val_11 = new System.Action<UnityEngine.Purchasing.Product>(object:  this, method:  val_41);
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_41 = 1;
        val_40.RegisterPurchaseDeferredListener(callback:  val_11);
        UnityEngine.Debug.Log(message:  "Available items:");
        var val_44 = 0;
        val_44 = val_44 + 1;
        val_44 = 0;
        goto label_55;
        label_98:
        val_40 = 0;
        UnityEngine.Purchasing.Product val_45 = controller.products.all[val_40];
        if(val_45.availableToPurchase == false)
        {
            goto label_58;
        }
        
        string[] val_17 = new string[7];
        string val_19 = val_45.metadata.localizedTitle;
        if(val_17 == null)
        {
            goto label_61;
        }
        
        if(val_19 != null)
        {
            goto label_62;
        }
        
        goto label_65;
        label_61:
        if(val_19 == null)
        {
            goto label_65;
        }
        
        label_62:
        label_65:
        val_17[0] = val_19;
        val_17[1] = val_45.metadata.localizedDescription;
        val_17[2] = val_45.metadata.isoCurrencyCode;
        decimal val_25 = val_45.metadata.localizedPrice;
        val_17[3] = val_25.flags.ToString();
        val_17[4] = val_45.metadata.localizedPriceString;
        val_17[5] = val_45.transactionID;
        val_17[6] = val_45.receipt;
        val_40 = System.String.Join(separator:  " - ", value:  val_17);
        UnityEngine.Debug.Log(message:  val_40);
        label_58:
        val_44 = 1;
        label_55:
        if(val_44 < val_15.Length)
        {
            goto label_98;
        }
        
        var val_46 = 0;
        val_46 = val_46 + 1;
        this.AddProductUIs(products:  this.m_Controller.products.all);
        this.LogProductDefinitions();
    }
    public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
    {
        System.Object[] val_17;
        UnityEngine.Debug.Log(message:  "Purchase OK: "("Purchase OK: ") + e.purchasedProduct.definition.id);
        UnityEngine.Debug.Log(message:  "Receipt: "("Receipt: ") + e.purchasedProduct.receipt);
        val_17 = e.purchasedProduct;
        this.m_LastTransactionID = val_17.transactionID;
        this.m_PurchaseInProgress = false;
        if(this.m_IsUnityChannelSelected != false)
        {
                val_17 = UnityEngine.JsonUtility.FromJson<UnityEngine.Purchasing.UnifiedReceipt>(json:  e.purchasedProduct.receipt);
            if(val_17 != null)
        {
                if((System.String.IsNullOrEmpty(value:  val_12.Payload)) != true)
        {
                UnityEngine.Purchasing.UnityChannelPurchaseReceipt val_14 = UnityEngine.JsonUtility.FromJson<UnityEngine.Purchasing.UnityChannelPurchaseReceipt>(json:  val_12.Payload);
            object[] val_15 = new object[3];
            val_17 = val_15;
            val_17[0] = val_14.storeSpecificId;
            val_17[1] = val_14.transactionId;
            val_17[2] = val_14.orderQueryToken;
            UnityEngine.Debug.LogFormat(format:  "UnityChannel receipt: storeSpecificId = {0}, transactionId = {1}, orderQueryToken = {2}", args:  val_15);
        }
        
        }
        
        }
        
        this.UpdateProductUI(p:  e.purchasedProduct);
        return 0;
    }
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product item, UnityEngine.Purchasing.PurchaseFailureReason r)
    {
        UnityEngine.Purchasing.ITransactionHistoryExtensions val_14;
        UnityEngine.Debug.Log(message:  "Purchase failed: "("Purchase failed: ") + item.definition.id);
        UnityEngine.Debug.Log(message:  r);
        var val_17 = 0;
        val_17 = val_17 + 1;
        UnityEngine.Debug.Log(message:  "Store specific error code: "("Store specific error code: ") + this.m_TransactionHistoryExtensions.GetLastStoreSpecificPurchaseErrorCode());
        val_14 = this.m_TransactionHistoryExtensions;
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_14.GetLastPurchaseFailureDescription() != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_14 = "Purchase failure description message: "("Purchase failure description message: ") + this.m_TransactionHistoryExtensions.GetLastPurchaseFailureDescription().message;
            UnityEngine.Debug.Log(message:  val_14);
        }
        
        if(this.m_IsUnityChannelSelected != false)
        {
                val_14 = this.m_UnityChannelExtensions;
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(((UnityEngine.JsonUtility.FromJson<UnityChannelPurchaseError>(json:  val_14.GetLastPurchaseError())) != null) && (val_15.purchaseInfo != null))
        {
                object[] val_16 = new object[3];
            val_14 = val_16;
            val_14[0] = val_15.purchaseInfo.productCode;
            val_14[1] = val_15.purchaseInfo.gameOrderId;
            val_14[2] = val_15.purchaseInfo.orderQueryToken;
            UnityEngine.Debug.LogFormat(format:  "UnityChannel purchaseInfo: productCode = {0}, gameOrderId = {1}, orderQueryToken = {2}", args:  val_16);
        }
        
            if(r == 6)
        {
                UnityEngine.Debug.Log(message:  "Duplicate transaction detected, unlock this item");
        }
        
        }
        
        this.m_PurchaseInProgress = false;
    }
    public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
    {
        object val_1;
        UnityEngine.Debug.Log(message:  "Billing failed to initialize!");
        if(error == 0)
        {
            goto label_3;
        }
        
        if(error == 1)
        {
            goto label_4;
        }
        
        if(error != 2)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "Is your App correctly uploaded on the relevant publisher console?");
        return;
        label_3:
        val_1 = "Billing disabled!";
        goto label_10;
        label_4:
        val_1 = "No products available for purchase!";
        label_10:
        UnityEngine.Debug.Log(message:  val_1);
    }
    public void Awake()
    {
        var val_47;
        var val_75;
        var val_77;
        var val_78;
        var val_80;
        var val_82;
        var val_84;
        bool val_85;
        bool val_86;
        var val_89;
        var val_90;
        string val_94;
        var val_96;
        var val_97;
        var val_100;
        string val_108;
        var val_109;
        UnityEngine.Purchasing.ProductType val_112;
        var val_114;
        var val_115;
        var val_117;
        IAPDemo.<>c__DisplayClass30_0 val_1 = new IAPDemo.<>c__DisplayClass30_0();
        .<>4__this = this;
        UnityEngine.Purchasing.StandardPurchasingModule val_2 = UnityEngine.Purchasing.StandardPurchasingModule.Instance();
        val_2.useFakeStoreUIMode = 1;
        val_75 = 0;
        UnityEngine.Purchasing.ConfigurationBuilder val_4 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  val_2, rest:  System.Array.Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>());
        .builder = val_4;
        var val_81 = 0;
        val_81 = val_81 + 1;
        val_75 = 0;
        val_77 = public System.Void UnityEngine.Purchasing.IMicrosoftConfiguration::set_useMockBillingSystem(bool value);
        val_4.Configure<UnityEngine.Purchasing.IMicrosoftConfiguration>().useMockBillingSystem = false;
        val_78 = 0;
        this.m_IsGooglePlayStoreSelected = (val_2.appStore == 1) ? 1 : 0;
        var val_82 = 0;
        val_82 = val_82 + 1;
        val_77 = 0;
        val_80 = public System.Void UnityEngine.Purchasing.IMoolahConfiguration::set_appKey(string value);
        (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.Configure<UnityEngine.Purchasing.IMoolahConfiguration>().appKey = "d93f4564c41d463ed3d3cd207594ee1b";
        var val_83 = 0;
        val_83 = val_83 + 1;
        val_80 = 1;
        val_82 = public System.Void UnityEngine.Purchasing.IMoolahConfiguration::set_hashKey(string value);
        (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.Configure<UnityEngine.Purchasing.IMoolahConfiguration>().hashKey = "cc";
        var val_84 = 0;
        val_84 = val_84 + 1;
        val_82 = 2;
        val_84 = public System.Void UnityEngine.Purchasing.IMoolahConfiguration::SetMode(UnityEngine.Purchasing.CloudMoolahMode mode);
        (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.Configure<UnityEngine.Purchasing.IMoolahConfiguration>().SetMode(mode:  1);
        if(UnityEngine.Application.platform != 11)
        {
            goto label_35;
        }
        
        var val_18 = (val_2.appStore == 3) ? 1 : 0;
        if(this != null)
        {
            goto label_39;
        }
        
        goto label_38;
        label_35:
        val_85 = false;
        if(this != null)
        {
            goto label_39;
        }
        
        label_38:
        label_39:
        this.m_IsCloudMoolahStoreSelected = val_85;
        if(UnityEngine.Application.platform == 11)
        {
                var val_21 = (val_2.appStore == 5) ? 1 : 0;
        }
        else
        {
                val_86 = false;
        }
        
        this.m_IsUnityChannelSelected = val_86;
        var val_85 = 0;
        val_85 = val_85 + 1;
        val_84 = 0;
        (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.Configure<UnityEngine.Purchasing.IUnityChannelConfiguration>().fetchReceiptPayloadOnPurchase = (this.m_FetchReceiptPayloadOnPurchase == true) ? 1 : 0;
        var val_86 = 0;
        val_86 = val_86 + 1;
        System.Collections.Generic.IEnumerator<T> val_28 = UnityEngine.Purchasing.ProductCatalog.LoadDefaultCatalog().allValidProducts.GetEnumerator();
        val_89 = 1152921504620478464;
        val_90 = 0;
        label_124:
        var val_87 = 0;
        val_87 = val_87 + 1;
        if(val_28.MoveNext() == false)
        {
            goto label_61;
        }
        
        var val_88 = 0;
        val_88 = val_88 + 1;
        T val_32 = val_28.Current;
        var val_89 = 0;
        val_89 = val_89 + 1;
        if(val_32.allStoreIDs.Count >= 1)
        {
            goto label_73;
        }
        
        if(val_32 != 0)
        {
                val_94 = mem[val_32 + 16];
            val_94 = val_32 + 16;
        }
        else
        {
                val_94 = 11993091;
        }
        
        UnityEngine.Purchasing.ConfigurationBuilder val_36 = (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.AddProduct(id:  val_94, type:  val_32 + 24);
        goto label_124;
        label_73:
        new UnityEngine.Purchasing.IDs() = new UnityEngine.Purchasing.IDs();
        var val_90 = 0;
        val_90 = val_90 + 1;
        System.Collections.Generic.IEnumerator<T> val_40 = val_32.allStoreIDs.GetEnumerator();
        label_102:
        val_96 = -1445242288;
        val_97 = val_89;
        var val_91 = 0;
        val_91 = val_91 + 1;
        if(val_40.MoveNext() == false)
        {
            goto label_90;
        }
        
        var val_92 = 0;
        val_92 = val_92 + 1;
        T val_44 = val_40.Current;
        string[] val_45 = new string[1];
        val_45[0] = val_44 + 16;
        new UnityEngine.Purchasing.IDs().Add(id:  val_44 + 24, stores:  val_45);
        goto label_102;
        label_90:
        val_100 = 0 + 1;
        mem2[0] = 348;
        if(val_40 == null)
        {
            
        }
        else
        {
                var val_93 = 0;
            val_93 = val_93 + 1;
        }
        
        if(( == 1) || (val_47 != 348))
        {
            goto label_116;
        }
        
        var val_94 = 0;
        val_94 = val_94 ^ 0;
         =  + val_94;
        if(val_1 != null)
        {
            goto label_120;
        }
        
        goto label_118;
        label_116:
        if(val_1 != null)
        {
            goto label_120;
        }
        
        label_118:
        label_120:
        if(val_32 != 0)
        {
                val_108 = mem[val_32 + 16];
            val_108 = val_32 + 16;
        }
        else
        {
                val_108 = 11993091;
        }
        
        UnityEngine.Purchasing.ConfigurationBuilder val_48 = (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.AddProduct(id:  val_108, type:  val_32 + 24, storeIDs:  new UnityEngine.Purchasing.IDs());
        goto label_124;
        label_61:
        val_109 = 0 + 1;
        mem2[0] = 423;
        if(val_28 == null)
        {
            
        }
        else
        {
                var val_95 = 0;
            val_95 = val_95 + 1;
            val_28.Dispose();
        }
        
        if(val_109 == 1)
        {
            goto label_150;
        }
        
        if(( == false) || ((1152921511751539280 + ((0 + 1)) << 2) == 423))
        {
            goto label_211;
        }
        
        label_210:
        label_211:
        UnityEngine.Purchasing.IDs val_50 = new UnityEngine.Purchasing.IDs();
        string[] val_51 = new string[1];
        val_51[0] = "MacAppStore";
        val_50.Add(id:  "com.unity3d.unityiap.unityiapdemo.100goldcoins.7", stores:  val_51);
        string[] val_52 = new string[1];
        val_52[0] = "TizenStore";
        val_50.Add(id:  "000000596586", stores:  val_52);
        string[] val_53 = new string[1];
        val_53[0] = "MoolahAppStore";
        val_50.Add(id:  "com.ff", stores:  val_53);
        string[] val_54 = new string[1];
        val_54[0] = "AmazonApps";
        val_50.Add(id:  "100.gold.coins", stores:  val_54);
        string[] val_55 = new string[1];
        val_55[0] = "AppleAppStore";
        val_50.Add(id:  "100.gold.coins", stores:  val_55);
        UnityEngine.Purchasing.ConfigurationBuilder val_56 = (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.AddProduct(id:  "100.gold.coins", type:  0, storeIDs:  val_50);
        UnityEngine.Purchasing.IDs val_57 = new UnityEngine.Purchasing.IDs();
        string[] val_58 = new string[1];
        val_58[0] = "MacAppStore";
        val_57.Add(id:  "com.unity3d.unityiap.unityiapdemo.500goldcoins.7", stores:  val_58);
        string[] val_59 = new string[1];
        val_59[0] = "TizenStore";
        val_57.Add(id:  "000000596581", stores:  val_59);
        string[] val_60 = new string[1];
        val_60[0] = "MoolahAppStore";
        val_57.Add(id:  "com.ee", stores:  val_60);
        string[] val_61 = new string[1];
        val_61[0] = "AmazonApps";
        val_57.Add(id:  "500.gold.coins", stores:  val_61);
        UnityEngine.Purchasing.ConfigurationBuilder val_62 = (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.AddProduct(id:  "500.gold.coins", type:  0, storeIDs:  val_57);
        UnityEngine.Purchasing.ConfigurationBuilder val_64 = (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.AddProduct(id:  "300.gold.coins", type:  0, storeIDs:  new UnityEngine.Purchasing.IDs());
        UnityEngine.Purchasing.ConfigurationBuilder val_66 = (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.AddProduct(id:  "sub1", type:  2, storeIDs:  new UnityEngine.Purchasing.IDs());
        val_112 = 2;
        UnityEngine.Purchasing.ConfigurationBuilder val_68 = (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.AddProduct(id:  "sub2", type:  val_112, storeIDs:  new UnityEngine.Purchasing.IDs());
        var val_96 = 0;
        val_96 = val_96 + 1;
        val_112 = 0;
        goto label_209;
        label_150:
        if( == true)
        {
            goto label_210;
        }
        
        goto label_211;
        label_209:
        val_114 = public System.Void UnityEngine.Purchasing.ISamsungAppsConfiguration::SetMode(UnityEngine.Purchasing.SamsungAppsMode mode);
        (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.Configure<UnityEngine.Purchasing.ISamsungAppsConfiguration>().SetMode(mode:  1);
        if(UnityEngine.Application.platform != 11)
        {
            goto label_212;
        }
        
        var val_73 = (val_2.appStore == 4) ? 1 : 0;
        if(this != null)
        {
            goto label_216;
        }
        
        goto label_215;
        label_212:
        val_115 = 0;
        if(this != null)
        {
            goto label_216;
        }
        
        label_215:
        label_216:
        mem[1152921511751551529] = val_115;
        var val_97 = 0;
        val_97 = val_97 + 1;
        val_114 = 0;
        (IAPDemo.<>c__DisplayClass30_0)[1152921511751583440].builder.Configure<UnityEngine.Purchasing.ITizenStoreConfiguration>().SetGroupId(group:  "100000085616");
        System.Action val_76 = new System.Action(object:  val_1, method:  System.Void IAPDemo.<>c__DisplayClass30_0::<Awake>b__0());
        .initializeUnityIap = val_76;
        if(this.m_IsUnityChannelSelected == false)
        {
            goto label_225;
        }
        
        UnityEngine.Store.AppInfo val_77 = new UnityEngine.Store.AppInfo();
        if(val_77 == null)
        {
            goto label_226;
        }
        
        val_77.appId = "abc123appId";
        val_77.appKey = "efg456appKey";
        val_77.clientId = "hij789clientId";
        val_77.clientKey = "klm012clientKey";
        goto label_227;
        label_225:
        val_76.Invoke();
        return;
        label_226:
        val_77.appId = "abc123appId";
        val_77.appKey = "efg456appKey";
        val_77.clientId = "hij789clientId";
        val_77.clientKey = "klm012clientKey";
        label_227:
        val_77.debug = false;
        IAPDemo.UnityChannelLoginHandler val_78 = new IAPDemo.UnityChannelLoginHandler();
        mem[1152921511751551552] = val_78;
        val_117 = null;
        val_117 = null;
        if((IAPDemo.<>c.<>9__30_1) == null)
        {
            goto label_231;
        }
        
        label_239:
        .initializeFailedAction = IAPDemo.<>c.<>9__30_1;
        mem[1152921511751874672] = new System.Action(object:  val_1, method:  System.Void IAPDemo.<>c__DisplayClass30_0::<Awake>b__2());
        UnityEngine.Store.StoreService.Initialize(appInfo:  val_77, listener:  val_78);
        return;
        label_231:
        IAPDemo.<>c.<>9__30_1 = new System.Action<System.String>(object:  IAPDemo.<>c.__il2cppRuntimeField_static_fields, method:  System.Void IAPDemo.<>c::<Awake>b__30_1(string message));
        if(val_78 != null)
        {
            goto label_239;
        }
        
        goto label_239;
    }
    private void OnTransactionsRestored(bool success)
    {
        UnityEngine.Debug.Log(message:  "Transactions restored." + success.ToString());
    }
    private void OnDeferred(UnityEngine.Purchasing.Product item)
    {
        UnityEngine.Debug.Log(message:  "Purchase deferred: "("Purchase deferred: ") + item.definition.id);
    }
    private void InitUI(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> items)
    {
        this.restoreButton.gameObject.SetActive(value:  true);
        this.loginButton.gameObject.SetActive(value:  (this.m_IsUnityChannelSelected == true) ? 1 : 0);
        this.validateButton.gameObject.SetActive(value:  (this.m_IsUnityChannelSelected == true) ? 1 : 0);
        this.ClearProductUIs();
        this.restoreButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void IAPDemo::RestoreButtonClick()));
        this.loginButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void IAPDemo::LoginButtonClick()));
        this.validateButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void IAPDemo::ValidateButtonClick()));
        string val_13 = "Unity version: "("Unity version: ") + UnityEngine.Application.unityVersion + "\nIAP version: 1.22.0"("\nIAP version: 1.22.0");
        if(this.versionText == null)
        {
            
        }
    
    }
    public void PurchaseButtonClick(string productID)
    {
        string val_7;
        object val_9;
        val_7 = productID;
        if(this.m_PurchaseInProgress != false)
        {
                UnityEngine.Debug.Log(message:  "Please wait, purchase in progress");
            return;
        }
        
        if(this.m_Controller == null)
        {
            goto label_4;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        goto label_8;
        label_4:
        val_9 = "Purchasing is not initialized";
        goto label_11;
        label_8:
        if((this.m_Controller.products.WithID(id:  val_7)) == null)
        {
            goto label_13;
        }
        
        if((this.m_IsUnityChannelSelected != false) && (this.m_IsLoggedIn != true))
        {
                UnityEngine.Debug.LogWarning(message:  "Purchase notifications will not be forwarded server-to-server. Login incomplete.");
        }
        
        this.m_PurchaseInProgress = true;
        var val_10 = 0;
        val_10 = val_10 + 1;
        goto label_22;
        label_13:
        val_7 = "No product has id " + val_7;
        val_9 = val_7;
        label_11:
        UnityEngine.Debug.LogError(message:  val_9);
        return;
        label_22:
        var val_11 = 0;
        val_11 = val_11 + 1;
        this.m_Controller.InitiatePurchase(product:  this.m_Controller.products.WithID(id:  val_7), payload:  "developerPayload");
    }
    public void RestoreButtonClick()
    {
        object val_10;
        UnityEngine.Purchasing.IMoolahExtension val_11;
        System.Action<System.Boolean> val_12;
        IntPtr val_13;
        var val_15;
        var val_16;
        val_10 = this;
        if(this.m_IsCloudMoolahStoreSelected == false)
        {
            goto label_1;
        }
        
        if(this.m_IsLoggedIn == false)
        {
            goto label_2;
        }
        
        val_11 = this.m_MoolahExtensions;
        System.Action<UnityEngine.Purchasing.RestoreTransactionIDState> val_1 = null;
        val_12 = val_1;
        val_13 = System.Void IAPDemo::<RestoreButtonClick>b__36_0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState);
        val_1 = new System.Action<UnityEngine.Purchasing.RestoreTransactionIDState>(object:  this, method:  val_13);
        val_15 = null;
        var val_10 = 0;
        val_16 = 1152921504865083400;
        val_10 = val_10 + 1;
        goto label_34;
        label_1:
        if(this.m_IsSamsungAppsStoreSelected == false)
        {
            goto label_8;
        }
        
        val_11 = this.m_SamsungExtensions;
        System.Action<System.Boolean> val_2 = null;
        val_12 = val_2;
        val_13 = System.Void IAPDemo::OnTransactionsRestored(bool success);
        val_2 = new System.Action<System.Boolean>(object:  this, method:  val_13);
        val_15 = null;
        var val_11 = 0;
        val_16 = 1152921504866095112;
        val_11 = val_11 + 1;
        label_34:
        val_13 = 0;
        goto label_13;
        label_2:
        UnityEngine.Debug.LogError(message:  "CloudMoolah purchase restoration aborted. Login incomplete.");
        return;
        label_8:
        if(UnityEngine.Application.platform != 18)
        {
                if(UnityEngine.Application.platform != 19)
        {
                if(UnityEngine.Application.platform != 20)
        {
            goto label_18;
        }
        
        }
        
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_10 = ???;
        this.m_MicrosoftExtensions.RestoreTransactions();
        return;
        label_18:
        if(this.m_IsGooglePlayStoreSelected == false)
        {
            goto label_24;
        }
        
        val_11 = this.m_GooglePlayStoreExtensions;
        System.Action<System.Boolean> val_7 = null;
        val_12 = val_7;
        val_13 = System.Void IAPDemo::OnTransactionsRestored(bool success);
        val_7 = new System.Action<System.Boolean>(object:  this, method:  val_13);
        var val_13 = 0;
        val_16 = 1152921504865882120;
        val_13 = val_13 + 1;
        goto label_34;
        label_24:
        val_11 = this.m_AppleExtensions;
        System.Action<System.Boolean> val_8 = null;
        val_12 = val_8;
        val_13 = System.Void IAPDemo::OnTransactionsRestored(bool success);
        val_8 = new System.Action<System.Boolean>(object:  this, method:  val_13);
        var val_14 = 0;
        val_16 = 1152921504867799048;
        val_14 = val_14 + 1;
        goto label_34;
        label_13:
        val_11.RestoreTransactions(callback:  val_1);
    }
    public void LoginButtonClick()
    {
        if(this.m_IsUnityChannelSelected != false)
        {
                this.unityChannelLoginHandler.loginSucceededAction = new System.Action<UnityEngine.Store.UserInfo>(object:  this, method:  System.Void IAPDemo::<LoginButtonClick>b__37_0(UnityEngine.Store.UserInfo userInfo));
            this.unityChannelLoginHandler.loginFailedAction = new System.Action<System.String>(object:  this, method:  System.Void IAPDemo::<LoginButtonClick>b__37_1(string message));
            UnityEngine.Store.StoreService.Login(listener:  this.unityChannelLoginHandler);
            return;
        }
        
        UnityEngine.Debug.Log(message:  "Login is only required for the Xiaomi store");
    }
    public void ValidateButtonClick()
    {
        string val_4;
        UnityEngine.Purchasing.IUnityChannelExtensions val_5;
        IAPDemo.<>c__DisplayClass38_0 val_1 = new IAPDemo.<>c__DisplayClass38_0();
        if(this.m_IsUnityChannelSelected == false)
        {
            goto label_1;
        }
        
        if(val_1 == null)
        {
            goto label_2;
        }
        
        val_4 = val_1;
        .txId = this.m_LastTransactionID;
        val_5 = this.m_UnityChannelExtensions;
        goto label_3;
        label_1:
        UnityEngine.Debug.Log(message:  "Remote purchase validation is only supported for the Xiaomi store");
        return;
        label_2:
        val_4 = 16;
        mem[16] = this.m_LastTransactionID;
        val_5 = this.m_UnityChannelExtensions;
        label_3:
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_5.ValidateReceipt(transactionId:  val_4, callback:  new System.Action<System.Boolean, System.String, System.String>(object:  val_1, method:  System.Void IAPDemo.<>c__DisplayClass38_0::<ValidateButtonClick>b__0(bool success, string signData, string signature)));
    }
    private void ClearProductUIs()
    {
        Dictionary.Enumerator<TKey, TValue> val_1 = this.m_ProductUIs.GetEnumerator();
        label_6:
        if(((-1443573960) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Collections.Generic.KeyValuePair<TKey, TValue> val_2 = 0.Current;
        UnityEngine.Object.Destroy(obj:  val_2.Value.gameObject);
        goto label_6;
        label_2:
        UniRx.Unit..cctor();
        this.m_ProductUIs.Clear();
    }
    private void AddProductUIs(UnityEngine.Purchasing.Product[] products)
    {
        UnityEngine.RectTransform val_17;
        float val_18;
        this.ClearProductUIs();
        UnityEngine.RectTransform val_1 = this.productUITemplate.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_2 = val_1.rect;
        UnityEngine.Vector3 val_3 = val_1.localPosition;
        val_17 = this.contentRect;
        val_18 = val_3.y;
        if(products == null)
        {
            goto label_4;
        }
        
        label_27:
        float val_18 = (float)products.Length;
        val_18 = val_2.m_XMin * val_18;
        val_17.SetSizeWithCurrentAnchors(axis:  1, size:  val_18);
        if(products.Length < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Purchasing.Product val_19 = products[0];
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.productUITemplate.gameObject);
            val_5.transform.SetParent(parent:  this.productUITemplate.transform.parent, worldPositionStays:  false);
            val_5.GetComponent<UnityEngine.RectTransform>().localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_18, z = val_3.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_2.m_XMin);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_18, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_18 = val_12.y;
            if(val_5 != null)
        {
                val_5.SetActive(value:  true);
        }
        else
        {
                val_5.SetActive(value:  true);
        }
        
            IAPDemoProductUI val_13 = val_5.GetComponent<IAPDemoProductUI>();
            val_13.SetProduct(p:  val_19, purchaseCallback:  new System.Action<System.String>(object:  this, method:  public System.Void IAPDemo::PurchaseButtonClick(string productID)));
            val_17 = val_19.definition.id;
            this.m_ProductUIs.set_Item(key:  val_17, value:  val_13);
        }
        while((0 + 1) < products.Length);
        
        return;
        label_4:
        if(val_17 != null)
        {
            goto label_27;
        }
        
        goto label_27;
    }
    private void UpdateProductUI(UnityEngine.Purchasing.Product p)
    {
        if((this.m_ProductUIs.ContainsKey(key:  p.definition.id)) == false)
        {
                return;
        }
        
        this.m_ProductUIs.Item[p.definition.id].SetProduct(p:  p, purchaseCallback:  new System.Action<System.String>(object:  this, method:  public System.Void IAPDemo::PurchaseButtonClick(string productID)));
    }
    private void UpdateProductPendingUI(UnityEngine.Purchasing.Product p, int secondsRemaining)
    {
        if((this.m_ProductUIs.ContainsKey(key:  p.definition.id)) == false)
        {
                return;
        }
        
        this.m_ProductUIs.Item[p.definition.id].SetPendingTime(secondsRemaining:  secondsRemaining);
    }
    private bool NeedRestoreButton()
    {
        var val_8;
        if(UnityEngine.Application.platform != 8)
        {
            goto label_0;
        }
        
        label_7:
        val_8 = 1;
        return (bool)val_2;
        label_0:
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(val_2 == 1)
        {
                return (bool)val_2;
        }
        
        if((((UnityEngine.Application.platform == 31) || (UnityEngine.Application.platform == 18)) || (UnityEngine.Application.platform == 19)) || ((UnityEngine.Application.platform == 20) || (this.m_IsSamsungAppsStoreSelected == true)))
        {
            goto label_7;
        }
        
        var val_7 = (this.m_IsCloudMoolahStoreSelected == true) ? 1 : 0;
        return (bool)val_2;
    }
    private bool NeedLoginButton()
    {
        return (bool)this.m_IsUnityChannelSelected;
    }
    private bool NeedValidateButton()
    {
        return (bool)this.m_IsUnityChannelSelected;
    }
    private void LogProductDefinitions()
    {
        var val_16;
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_16 = 0;
        goto label_7;
        label_37:
        UnityEngine.Purchasing.Product val_17 = this.m_Controller.products.all[0];
        object[] val_4 = new object[4];
        string val_6 = val_17.definition.id;
        if(val_4 == null)
        {
            goto label_11;
        }
        
        if(val_6 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_6 == null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        val_4[0] = val_6;
        val_4[1] = val_17.definition.storeSpecificId;
        UniRx.Unit..cctor();
        val_4[2] = val_17.definition.type.ToString();
        val_4[3] = (val_17.definition.enabled != true) ? "enabled" : "disabled";
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "id: {0}\nstore-specific id: {1}\ntype: {2}\nenabled: {3}\n", args:  val_4));
        val_16 = 1;
        label_7:
        if(val_16 < val_3.Length)
        {
            goto label_37;
        }
    
    }
    public IAPDemo()
    {
        this.m_ProductUIs = new System.Collections.Generic.Dictionary<System.String, IAPDemoProductUI>();
    }
    private void <RestoreButtonClick>b__36_0(UnityEngine.Purchasing.RestoreTransactionIDState restoreTransactionIDState)
    {
        UniRx.Unit..cctor();
        string val_2 = "restoreTransactionIDState = "("restoreTransactionIDState = ") + restoreTransactionIDState.ToString();
        UnityEngine.Debug.Log(message:  val_2);
        val_2.OnTransactionsRestored(success:  (258093056 != 2) ? 1 : 0);
    }
    private void <LoginButtonClick>b__37_0(UnityEngine.Store.UserInfo userInfo)
    {
        this.m_IsLoggedIn = true;
        object[] val_1 = new object[3];
        string val_2 = userInfo.channel;
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(val_2 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_2 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = val_2;
        val_1[1] = userInfo.userId;
        val_1[2] = userInfo.userLoginToken;
        UnityEngine.Debug.LogFormat(format:  "Succeeded logging into UnityChannel. channel {0}, userId {1}, userLoginToken {2} ", args:  val_1);
    }
    private void <LoginButtonClick>b__37_1(string message)
    {
        this.m_IsLoggedIn = false;
        UnityEngine.Debug.LogError(message:  "Failed logging into UnityChannel. " + message);
    }

}
