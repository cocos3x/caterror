using UnityEngine;
public sealed class AvatarDialogManager : DialogManagerParent
{
    // Fields
    private static readonly int MaxNodeCount;
    private static readonly string DetailAvatarDataTag;
    private static readonly string CallbackTag;
    private float gachaTime;
    private UnityEngine.RectTransform pagePanelPrefab;
    private AvatarNode avatarNodePrefab;
    private AvatarDetail avatarDetailPrefab;
    private UnityEngine.Transform pageIconOnPrefab;
    private UnityEngine.Transform pageIconOffPrefab;
    private UnityEngine.UI.Text avatarNameText;
    private PageScrollRect listPageScrollRect;
    private UnityEngine.RectTransform listContent;
    private UnityEngine.RectTransform pageIconContent;
    private PageScrollRect detailPageScrollRect;
    private UnityEngine.RectTransform detailContent;
    private UnityEngine.UI.Text gachaCostText;
    private UnityEngine.UI.Button gachaButton;
    private AvatarDialogSideButton randomButton;
    private AvatarDialogSideButton randomCatButton;
    private AvatarDialogSideButton removeButton;
    private UnityEngine.GameObject selectedAvatarIcon;
    private UnityEngine.GameObject selectedCatIcon;
    private UnityEngine.GameObject selectedCatHeadgearIcon;
    private UnityEngine.GameObject selectedCatFaceItemIcon;
    private System.Collections.Generic.List<AvatarNode> nodeList;
    private int maxPage;
    private int lastPage;
    private AvatarData detailAvatarData;
    private AvatarCategory selectedCategory;
    private UnityEngine.GameObject selectedAvatarIconRed;
    private UnityEngine.GameObject selectedCatIconRed;
    private UnityEngine.GameObject selectedCatFaceItemIconRed;
    private UnityEngine.GameObject selectedCatHeadgearIconRed;
    
    // Methods
    private void Awake()
    {
        var val_16;
        var val_17;
        new System.Action() = new System.Action(object:  this, method:  typeof(AvatarDialogManager).__il2cppRuntimeField_170);
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action());
        val_16 = null;
        val_16 = null;
        if((LocalCacheManager.Exists(tag:  AvatarDialogManager.DetailAvatarDataTag)) == false)
        {
            goto label_7;
        }
        
        val_17 = null;
        val_17 = null;
        AvatarData val_4 = LocalCacheManager.Load<AvatarData>(tag:  AvatarDialogManager.DetailAvatarDataTag);
        bool val_5 = LocalCacheManager.Remove(tag:  AvatarDialogManager.DetailAvatarDataTag);
        int val_16 = val_4.category;
        val_16 = val_16 - 1;
        if(val_16 > 3)
        {
            goto label_16;
        }
        
        var val_17 = 28872344 + ((val_4.category - 1)) << 2;
        val_17 = val_17 + 28872344;
        goto (28872344 + ((val_4.category - 1)) << 2 + 28872344);
        label_7:
        this.OnAvatar();
        return;
        label_16:
        System.Action val_7 = ???;
        val_7 = new System.Action(object:  ???, method:  System.Void AvatarDialogManager::<Awake>b__29_0());
        SingletonMonoBehaviour<VibrationManager>.Instance.SetAction(action:  val_7);
        ???.OpenAvatarDetail(avatarData:  ???);
    }
    private void Start()
    {
        this.UpdateRed();
    }
    public void OnAvatar()
    {
        if(this.selectedCategory == 1)
        {
                return;
        }
        
        this.selectedCategory = 1;
        this.selectedAvatarIcon.SetActive(value:  true);
        this.selectedCatIcon.SetActive(value:  false);
        this.selectedCatHeadgearIcon.SetActive(value:  false);
        this.selectedCatFaceItemIcon.SetActive(value:  false);
        this.randomButton.gameObject.SetActive(value:  true);
        this.randomCatButton.gameObject.SetActive(value:  false);
        this.removeButton.gameObject.SetActive(value:  false);
        this.lastPage = 0;
        this.InstantiateNodes();
        SingletonMonoBehaviour<GameManager>.Instance.ShowAvatar();
    }
    public void OnCat()
    {
        if(this.selectedCategory == 2)
        {
                return;
        }
        
        this.selectedCategory = 2;
        this.selectedAvatarIcon.SetActive(value:  false);
        this.selectedCatIcon.SetActive(value:  true);
        this.selectedCatHeadgearIcon.SetActive(value:  false);
        this.selectedCatFaceItemIcon.SetActive(value:  false);
        this.randomButton.gameObject.SetActive(value:  false);
        this.randomCatButton.gameObject.SetActive(value:  true);
        this.removeButton.gameObject.SetActive(value:  false);
        this.lastPage = 0;
        this.InstantiateNodes();
        SingletonMonoBehaviour<GameManager>.Instance.ShowCat();
    }
    public void OnCatHeadgear()
    {
        if(this.selectedCategory == 3)
        {
                return;
        }
        
        this.selectedCategory = 3;
        this.selectedAvatarIcon.SetActive(value:  false);
        this.selectedCatIcon.SetActive(value:  false);
        this.selectedCatHeadgearIcon.SetActive(value:  true);
        this.selectedCatFaceItemIcon.SetActive(value:  false);
        this.randomButton.gameObject.SetActive(value:  false);
        this.randomCatButton.gameObject.SetActive(value:  true);
        this.removeButton.gameObject.SetActive(value:  true);
        this.lastPage = 0;
        this.InstantiateNodes();
        SingletonMonoBehaviour<GameManager>.Instance.ShowCat();
    }
    public void OnCatFaceItem()
    {
        if(this.selectedCategory == 4)
        {
                return;
        }
        
        this.selectedCategory = 4;
        this.selectedAvatarIcon.SetActive(value:  false);
        this.selectedCatIcon.SetActive(value:  false);
        this.selectedCatHeadgearIcon.SetActive(value:  false);
        this.selectedCatFaceItemIcon.SetActive(value:  true);
        this.randomButton.gameObject.SetActive(value:  false);
        this.randomCatButton.gameObject.SetActive(value:  true);
        this.removeButton.gameObject.SetActive(value:  true);
        this.lastPage = 0;
        this.InstantiateNodes();
        SingletonMonoBehaviour<GameManager>.Instance.ShowCat();
    }
    public void RemoveCatAccessory()
    {
        var val_9;
        var val_10;
        System.Predicate<AvatarData> val_12;
        var val_13;
        System.Collections.Generic.List<AvatarNode> val_15;
        GameData val_1 = GameDataManager.GameData;
        val_9 = null;
        val_9 = null;
        System.Collections.Generic.List<T> val_3 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        if(this.selectedCategory == 4)
        {
            goto label_6;
        }
        
        if(this.selectedCategory != 3)
        {
            goto label_7;
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = AvatarDialogManager.<>c.<>9__35_0;
        if(val_12 != null)
        {
            goto label_10;
        }
        
        System.Predicate<AvatarData> val_4 = null;
        val_12 = val_4;
        val_4 = new System.Predicate<AvatarData>(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AvatarDialogManager.<>c::<RemoveCatAccessory>b__35_0(AvatarData data));
        AvatarDialogManager.<>c.<>9__35_0 = val_12;
        if(val_3 != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_6:
        val_13 = null;
        val_13 = null;
        val_12 = AvatarDialogManager.<>c.<>9__35_1;
        if(val_12 == null)
        {
            goto label_17;
        }
        
        label_10:
        if(val_3 != null)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        this.SelectAvatar(avatarData:  val_3.Find(match:  val_12), isGacha:  false);
        label_7:
        val_15 = this.nodeList;
        List.Enumerator<T> val_6 = val_15.GetEnumerator();
        label_22:
        if(((-1346799688) & 1) == 0)
        {
            goto label_20;
        }
        
        0.Id.UnSelected();
        goto label_22;
        label_20:
        UniRx.Unit..cctor();
        return;
        label_17:
        AvatarDialogManager.<>c.<>9__35_1 = new System.Predicate<AvatarData>(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AvatarDialogManager.<>c::<RemoveCatAccessory>b__35_1(AvatarData data));
        if(val_3 != null)
        {
            goto label_26;
        }
        
        goto label_27;
    }
    private System.Collections.Generic.List<AvatarData> GetSortedAvatarDataList()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        System.Collections.Generic.List<T> val_4 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).FindAll(match:  new System.Predicate<AvatarData>(object:  this, method:  System.Boolean AvatarDialogManager::<GetSortedAvatarDataList>b__36_0(AvatarData data)));
        val_7 = null;
        val_7 = null;
        if((AvatarDialogManager.<>c.<>9__36_1) == null)
        {
            goto label_7;
        }
        
        label_12:
        val_4.Sort(comparison:  AvatarDialogManager.<>c.<>9__36_1);
        return (System.Collections.Generic.List<AvatarData>)val_4;
        label_7:
        AvatarDialogManager.<>c.<>9__36_1 = new System.Comparison<AvatarData>(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AvatarDialogManager.<>c::<GetSortedAvatarDataList>b__36_1(AvatarData a, AvatarData b));
        if(val_4 != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    private void InstantiateNodes()
    {
        var val_40;
        var val_41;
        var val_42;
        UnityEngine.UI.Text val_43;
        IntPtr val_45;
        var val_46;
        var val_47;
        var val_48;
        System.Predicate<T> val_49;
        var val_50;
        var val_51;
        var val_52;
        int val_53;
        var val_54;
        AvatarData val_55;
        var val_56;
        AvatarDialogManager.<>c__DisplayClass37_0 val_1 = new AvatarDialogManager.<>c__DisplayClass37_0();
        .<>4__this = this;
        this.nodeList.Clear();
        TransformExtensions.DestroyAllChildrens(t:  this.listContent);
        GameData val_38 = GameDataManager.GameData;
        .gameData = val_38;
        bool val_3 = val_38.GetRandom(category:  this.selectedCategory);
        if((val_3 != false) && ((this.lastPage & 2147483648) != 0))
        {
                this.lastPage = 0;
        }
        
        val_38 = val_3;
        this.randomButton.Initialize(onClick:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AvatarDialogManager::RandomChangeAvatar()), isSelect:  val_38);
        this.randomCatButton.Initialize(onClick:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AvatarDialogManager::RandomChangeAvatar()), isSelect:  val_38);
        val_40 = this.GetSortedAvatarDataList();
        if(this.selectedCategory == 4)
        {
            goto label_10;
        }
        
        if(this.selectedCategory != 3)
        {
            goto label_28;
        }
        
        int val_40 = (AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.catHeadgearId;
        val_41 = null;
        val_41 = null;
        bool val_39 = val_3;
        val_39 = val_39 ^ 1;
        val_40 = ((val_40 == Const.DefaultCatHeadgearId) ? 1 : 0) & val_39;
        this.removeButton.Initialize(onClick:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AvatarDialogManager::RemoveCatAccessory()), isSelect:  val_40);
        val_42 = null;
        val_42 = null;
        if(((AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.catHeadgearId) != Const.DefaultCatHeadgearId)
        {
            goto label_28;
        }
        
        val_43 = this.avatarNameText;
        val_45 = 1152921511850353712;
        goto label_20;
        label_10:
        int val_42 = (AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.catFaceItemId;
        val_46 = null;
        val_46 = null;
        bool val_41 = val_3;
        val_41 = val_41 ^ 1;
        val_42 = ((val_42 == Const.DefaultCatFaceItemId) ? 1 : 0) & val_41;
        this.removeButton.Initialize(onClick:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AvatarDialogManager::RemoveCatAccessory()), isSelect:  val_42);
        val_47 = null;
        val_47 = null;
        if(((AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.catFaceItemId) != Const.DefaultCatFaceItemId)
        {
            goto label_28;
        }
        
        val_43 = this.avatarNameText;
        System.Predicate<AvatarData> val_11 = null;
        val_45 = 1152921511850379312;
        label_20:
        val_11 = new System.Predicate<AvatarData>(object:  val_1, method:  val_45);
        string val_13 = val_40.Find(match:  val_11).Name;
        if((this.lastPage & 2147483648) != 0)
        {
            goto label_32;
        }
        
        label_28:
        if(val_40 != null)
        {
            goto label_96;
        }
        
        label_97:
        label_96:
        val_48 = 1152921504945344512;
        val_49 = val_40.Count;
        val_50 = null;
        val_50 = null;
        int val_43 = AvatarDialogManager.MaxNodeCount;
        val_43 = val_49 / val_43;
        val_43 = val_43 + 1;
        this.maxPage = val_43;
        if(val_43 < 1)
        {
            goto label_79;
        }
        
        val_51 = 0;
        label_78:
        val_52 = null;
        if(0 != 0)
        {
                val_52 = null;
            val_53 = AvatarDialogManager.MaxNodeCount * 0;
        }
        else
        {
                val_53 = 0;
        }
        
        val_52 = null;
        val_49 = 0 + 1;
        AvatarCategory val_44 = this.selectedCategory;
        val_54 = UnityEngine.Mathf.Min(a:  AvatarDialogManager.MaxNodeCount * val_49, b:  val_40.Count);
        val_44 = val_44 - 3;
        if(val_44 <= 1)
        {
                val_53 = val_53 + 1;
            val_54 = UnityEngine.Mathf.Min(a:  val_54 + 1, b:  val_40.Count);
        }
        
        if(val_53 >= val_54)
        {
            goto label_52;
        }
        
        goto label_77;
        label_61:
        val_51 = val_40.CheckGetAvatar(gameData:  (AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData);
        if(val_1 != null)
        {
            goto label_57;
        }
        
        goto label_57;
        label_77:
        val_49 = val_40;
        AvatarData val_23 = val_40.Item[val_53];
        AvatarNode val_24 = UnityEngine.Object.Instantiate<AvatarNode>(original:  this.avatarNodePrefab, parent:  UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.pagePanelPrefab, parent:  this.listContent));
        if(val_51 == 0)
        {
            goto label_61;
        }
        
        label_57:
        this.InitializeNode(node:  val_24, gameData:  (AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData, avatarData:  val_23);
        if(((val_23.id != ((AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.avatarId)) && (val_23.id != ((AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.catId))) && (val_23.id != ((AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.catHeadgearId)))
        {
                if(val_23.id != ((AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.catFaceItemId))
        {
            goto label_75;
        }
        
        }
        
        string val_25 = val_23.Name;
        if(val_3 != true)
        {
                val_24.Selected();
            if((this.lastPage & 2147483648) != 0)
        {
                this.lastPage = 0;
        }
        
        }
        
        label_75:
        this.nodeList.Add(item:  val_24);
        val_53 = val_53 + 1;
        val_40 = val_49;
        if(val_54 != val_53)
        {
            goto label_77;
        }
        
        label_52:
        val_48 = 1152921504945344512;
        if(val_49 < this.maxPage)
        {
            goto label_78;
        }
        
        if(val_51 >= 1)
        {
                JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Ad", type:  "impression", position:  "Shop", onlyFirst:  false, extra:  "");
        }
        
        label_79:
        if(((AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.newAvatarIdList.Count) >= 1)
        {
                .id = ListExtensions.Back<System.Int32>(list:  (AvatarDialogManager.<>c__DisplayClass37_0)[1152921511850581824].gameData.newAvatarIdList);
            System.Predicate<AvatarData> val_29 = null;
            val_49 = val_29;
            val_29 = new System.Predicate<AvatarData>(object:  new AvatarDialogManager.<>c__DisplayClass37_1(), method:  System.Boolean AvatarDialogManager.<>c__DisplayClass37_1::<InstantiateNodes>b__4(AvatarData data));
            if(val_40 != null)
        {
                val_55 = val_40.Find(match:  val_29);
        }
        else
        {
                val_55 = val_40.Find(match:  val_29);
        }
        
            val_56 = null;
            int val_45 = AvatarDialogManager.MaxNodeCount;
            val_45 = (val_40.IndexOf(item:  val_55)) / val_45;
            this.lastPage = val_45;
        }
        
        this.listPageScrollRect.OnPageChanged.RemoveAllListeners();
        this.listPageScrollRect.OnPageChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass37_0::<InstantiateNodes>b__2(int page)));
        UnityEngine.Coroutine val_37 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  new System.Action(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass37_0::<InstantiateNodes>b__3()));
        this.UpdatePageIcon(page:  this.lastPage);
        return;
        label_32:
        this.lastPage = 0;
        if(val_40 != null)
        {
            goto label_96;
        }
        
        goto label_97;
    }
    private void UpdatePageIcon(int page)
    {
        UnityEngine.Transform val_3;
        TransformExtensions.DestroyAllChildrens(t:  this.pageIconContent);
        if(this.maxPage < 2)
        {
                return;
        }
        
        var val_3 = 0;
        do
        {
            val_3 = mem[page == 0 ? this.pageIconOnPrefab : this.pageIconOffPrefab];
            val_3 = (page == val_3) ? this.pageIconOnPrefab : this.pageIconOffPrefab;
            UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_3, parent:  this.pageIconContent);
            val_3 = val_3 + 1;
        }
        while(val_3 < this.maxPage);
    
    }
    private void InitializeNode(AvatarNode node, GameData gameData, AvatarData avatarData)
    {
        GameData val_14;
        UnityEngine.Events.UnityAction val_15;
        bool val_16;
        var val_17;
        AvatarData val_18;
        AvatarData val_19;
        AvatarDialogManager.<>c__DisplayClass39_0 val_1 = new AvatarDialogManager.<>c__DisplayClass39_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .gameData = gameData;
        mem[1152921511851117136] = avatarData;
        mem[1152921511851117144] = this;
        if(gameData != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        bool val_3 = gameData.newAvatarIdList.Exists(match:  new System.Predicate<System.Int32>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass39_0::<InitializeNode>b__0(int id)));
        if(val_1 == null)
        {
            goto label_4;
        }
        
        val_14 = .gameData;
        goto label_5;
        label_1:
        mem[16] = avatarData;
        mem[24] = this;
        mem[32] = gameData;
        if(mem[32] != 0)
        {
            goto label_6;
        }
        
        goto label_7;
        label_4:
        val_14 = .gameData;
        label_5:
        if((val_14.HasAvatar(avatarData:  mem[1152921511851117136])) == false)
        {
            goto label_9;
        }
        
        UnityEngine.Events.UnityAction val_5 = null;
        val_15 = val_5;
        val_5 = new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass39_0::<InitializeNode>b__1());
        val_16 = val_3;
        val_17 = 1;
        val_18 = mem[1152921511851117136];
        goto label_12;
        label_9:
        SingletonMonoBehaviour<GAEventManager>.Instance.AdImpressionSkin();
        if(val_1 != null)
        {
                val_19 = mem[1152921511851117136];
        }
        else
        {
                val_19 = mem[1152921511851117136];
        }
        
        val_15 = new UnityEngine.Events.UnityAction();
        if((val_19.CheckGetAvatar(gameData:  .gameData)) == false)
        {
            goto label_18;
        }
        
        val_15 = new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass39_0::<InitializeNode>b__2());
        if(node == null)
        {
            goto label_19;
        }
        
        node.Initialize(avatarData:  mem[1152921511851117136], isOwned:  true, isNew:  val_3, callback:  new UnityEngine.Events.UnityAction());
        goto label_20;
        label_18:
        val_15 = new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass39_0::<InitializeNode>b__3());
        val_16 = val_3;
        val_18 = mem[1152921511851117136];
        val_17 = 0;
        label_12:
        node.Initialize(avatarData:  val_18, isOwned:  false, isNew:  val_16, callback:  new UnityEngine.Events.UnityAction());
        return;
        label_19:
        0.Initialize(avatarData:  mem[1152921511851117136], isOwned:  true, isNew:  val_3, callback:  new UnityEngine.Events.UnityAction());
        label_20:
        node.ShowAdIcon();
    }
    private void SelectAvatar(AvatarData avatarData, bool isGacha = False)
    {
        GameDataManager.GameData.SetRandom(isRandom:  false, category:  this.selectedCategory);
        this.randomButton.UnSelect();
        this.randomCatButton.UnSelect();
        this.removeButton.UnSelect();
        this.ChangeAvatar(avatarData:  avatarData, isGacha:  isGacha, check:  false);
    }
    private void ChangeAvatar(AvatarData avatarData, bool isGacha = False, bool check = False)
    {
        var val_6;
        var val_9;
        AvatarCategory val_10;
        val_9 = GameDataManager.GameData;
        isGacha = isGacha;
        SingletonMonoBehaviour<GameManager>.Instance.ChangeAvatar(avatarData:  avatarData, isGacha:  isGacha);
        if(val_9 != null)
        {
                val_9.ChangeAvatar(avatarData:  avatarData);
            val_10 = this.selectedCategory;
        }
        else
        {
                0.ChangeAvatar(avatarData:  avatarData);
            val_10 = this.selectedCategory;
        }
        
        List.Enumerator<T> val_4 = this.nodeList.GetEnumerator();
        label_21:
        if(((-1345373968) & 1) == 0)
        {
            goto label_7;
        }
        
        string val_7 = val_6.Id;
        if((((X26 + 20) != val_1.avatarId) && ((X26 + 20 + 20) != val_1.catId)) && ((X26 + 20 + 20) != val_1.catHeadgearId))
        {
                if((X26 + 20 + 20) != val_1.catFaceItemId)
        {
            goto label_17;
        }
        
        }
        
        if((val_9.GetRandom(category:  val_10)) == false)
        {
            goto label_18;
        }
        
        val_7.UnSelected();
        goto label_21;
        label_18:
        val_7.Selected();
        goto label_21;
        label_17:
        val_7.UnSelected();
        goto label_21;
        label_7:
        UniRx.Unit..cctor();
        this.UpdateRed();
        string val_8 = avatarData.Name;
        if(this.avatarNameText != null)
        {
                return;
        }
    
    }
    private void OpenAvatarDetail(AvatarData avatarData)
    {
        AvatarData val_24;
        var val_25;
        UnityEngine.Events.UnityAction val_27;
        AvatarData val_28;
        System.Collections.Generic.List<AvatarData> val_29;
        AvatarDialogManager.<>c__DisplayClass42_0 val_1 = new AvatarDialogManager.<>c__DisplayClass42_0();
        if(val_1 != null)
        {
                val_24 = val_1;
            .avatarData = avatarData;
            mem[1152921511851769568] = this;
        }
        else
        {
                val_24 = 24;
            mem[24] = avatarData;
            mem[32] = this;
        }
        
        this.detailAvatarData = val_24;
        .gameData = GameDataManager.GameData;
        this.listPageScrollRect.gameObject.SetActive(value:  false);
        this.detailPageScrollRect.gameObject.SetActive(value:  true);
        System.Collections.Generic.List<T> val_7 = this.GetSortedAvatarDataList().FindAll(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass42_0::<OpenAvatarDetail>b__0(AvatarData data)));
        .detailDataList = val_7;
        .index = val_7.IndexOf(item:  this.detailAvatarData);
        val_25 = null;
        val_25 = null;
        val_27 = AvatarDialogManager.<>c.<>9__42_1;
        if(val_27 == null)
        {
                UnityEngine.Events.UnityAction val_9 = null;
            val_27 = val_9;
            val_9 = new UnityEngine.Events.UnityAction(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AvatarDialogManager.<>c::<OpenAvatarDetail>b__42_1());
            AvatarDialogManager.<>c.<>9__42_1 = val_27;
        }
        
        UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass42_0::<OpenAvatarDetail>b__2());
        TransformExtensions.DestroyAllChildrens(t:  this.detailContent);
        .page = 0;
        if(((AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].index) > 0)
        {
                .page = 1;
            UnityEngine.Object.Instantiate<AvatarDetail>(original:  this.avatarDetailPrefab, parent:  this.detailContent).Initialize(gameData:  (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].gameData, avatarData:  (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].detailDataList.Item[((AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].index) - 1], transitionToGacha:  val_9, onClickAd:  val_10, currentShow:  false);
        }
        
        val_28 = (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].detailDataList.Item[(AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].index];
        UnityEngine.Object.Instantiate<AvatarDetail>(original:  this.avatarDetailPrefab, parent:  this.detailContent).Initialize(gameData:  (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].gameData, avatarData:  val_28, transitionToGacha:  val_9, onClickAd:  val_10, currentShow:  true);
        val_29 = (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].detailDataList;
        if(((AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].index) < (val_29.Count - 1))
        {
                val_29 = (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].gameData;
            val_28 = (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].detailDataList.Item[((AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].index) + 1];
            UnityEngine.Object.Instantiate<AvatarDetail>(original:  this.avatarDetailPrefab, parent:  this.detailContent).Initialize(gameData:  val_29, avatarData:  val_28, transitionToGacha:  val_9, onClickAd:  val_10, currentShow:  false);
        }
        
        this.detailPageScrollRect.OnPageChanged.RemoveAllListeners();
        this.detailPageScrollRect.OnPageChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass42_0::<OpenAvatarDetail>b__3(int p)));
        this.detailPageScrollRect.ImmediateChangePage(pageIndex:  (AvatarDialogManager.<>c__DisplayClass42_0)[1152921511851769536].page);
    }
    public void OnCloseDetail()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction(isPressedBackButton:  false);
    }
    private void RandomChangeAvatar()
    {
        var val_10;
        AvatarDialogManager.<>c__DisplayClass44_0 val_1 = new AvatarDialogManager.<>c__DisplayClass44_0();
        .<>4__this = this;
        .gameData = GameDataManager.GameData;
        val_10 = null;
        val_10 = null;
        (AvatarDialogManager.<>c__DisplayClass44_0)[1152921511852213696].gameData.SetRandom(isRandom:  true, category:  this.selectedCategory);
        AvatarData val_7 = ListExtensions.RandomChoose<AvatarData>(list:  SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).FindAll(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass44_0::<RandomChangeAvatar>b__0(AvatarData data))));
        .avatarData = val_7;
        bool val_9 = (AvatarDialogManager.<>c__DisplayClass44_0)[1152921511852213696].gameData.newAvatarIdList.Exists(match:  new System.Predicate<System.Int32>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass44_0::<RandomChangeAvatar>b__1(int id)));
        this.ChangeAvatar(avatarData:  val_7, isGacha:  false, check:  false);
        this.removeButton.UnSelect();
    }
    public void OnHide()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction(isPressedBackButton:  false);
    }
    protected override void Hide()
    {
        this.Hide();
        this.OnHided();
    }
    public void OnHided()
    {
        var val_3;
        System.Action val_5;
        val_3 = null;
        val_3 = null;
        val_5 = AvatarDialogManager.<>c.<>9__47_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AvatarDialogManager.<>c::<OnHided>b__47_0());
            AvatarDialogManager.<>c.<>9__47_0 = val_5;
        }
        
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_1);
    }
    public static void ShowDialog(System.Action callback)
    {
        .callback = callback;
        DialogManager.ShowDialog(showAction:  new System.Action(object:  new AvatarDialogManager.<>c__DisplayClass48_0(), method:  System.Void AvatarDialogManager.<>c__DisplayClass48_0::<ShowDialog>b__0()), category:  0);
    }
    public static void ShowDetailDialog(AvatarData avatarData, System.Action callback)
    {
        AvatarDialogManager.<>c__DisplayClass49_0 val_1 = new AvatarDialogManager.<>c__DisplayClass49_0();
        if(val_1 != null)
        {
                .avatarData = avatarData;
        }
        else
        {
                mem[16] = avatarData;
        }
        
        .callback = callback;
        DialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass49_0::<ShowDetailDialog>b__0()), category:  0);
    }
    public void UpdateRed()
    {
        var val_31;
        var val_32;
        var val_34;
        var val_35;
        var val_37;
        var val_38;
        var val_40;
        var val_41;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        AvatarDialogManager.<>c__DisplayClass54_0 val_1 = new AvatarDialogManager.<>c__DisplayClass54_0();
        val_31 = null;
        val_31 = null;
        System.Collections.Generic.List<T> val_3 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        val_32 = null;
        val_32 = null;
        if((AvatarDialogManager.<>c.<>9__54_0) == null)
        {
            goto label_6;
        }
        
        label_52:
        .gameData = GameDataManager.GameData;
        this.selectedAvatarIconRed.SetActive(value:  val_3.FindAll(match:  AvatarDialogManager.<>c.<>9__54_0).Exists(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_0::<UpdateRed>b__1(AvatarData data))));
        val_34 = null;
        val_34 = null;
        System.Collections.Generic.List<T> val_10 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        val_35 = null;
        val_35 = null;
        if((AvatarDialogManager.<>c.<>9__54_2) == null)
        {
            goto label_18;
        }
        
        label_55:
        this.selectedCatIconRed.SetActive(value:  val_10.FindAll(match:  AvatarDialogManager.<>c.<>9__54_2).Exists(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_0::<UpdateRed>b__3(AvatarData data))));
        val_37 = null;
        val_37 = null;
        System.Collections.Generic.List<T> val_16 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        val_38 = null;
        val_38 = null;
        if((AvatarDialogManager.<>c.<>9__54_4) == null)
        {
            goto label_27;
        }
        
        label_58:
        this.selectedCatFaceItemIconRed.SetActive(value:  val_16.FindAll(match:  AvatarDialogManager.<>c.<>9__54_4).Exists(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_0::<UpdateRed>b__5(AvatarData data))));
        val_40 = null;
        val_40 = null;
        System.Collections.Generic.List<T> val_22 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        val_41 = null;
        val_41 = null;
        if((AvatarDialogManager.<>c.<>9__54_6) == null)
        {
            goto label_36;
        }
        
        label_49:
        this.selectedCatHeadgearIconRed.SetActive(value:  val_22.FindAll(match:  AvatarDialogManager.<>c.<>9__54_6).Exists(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_0::<UpdateRed>b__7(AvatarData data))));
        return;
        label_6:
        val_43 = 1152921511849922864;
        goto label_50;
        label_18:
        val_44 = this;
        val_45 = 1152921511849922864;
        goto label_53;
        label_27:
        val_46 = this;
        val_47 = 1152921511849922864;
        goto label_56;
        label_36:
        AvatarDialogManager.<>c.<>9__54_6 = new System.Predicate<AvatarData>(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AvatarDialogManager.<>c::<UpdateRed>b__54_6(AvatarData data));
        if(val_22 != null)
        {
            goto label_49;
        }
        
        goto label_49;
        label_50:
        AvatarDialogManager.<>c.<>9__54_0 = new System.Predicate<AvatarData>(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AvatarDialogManager.<>c::<UpdateRed>b__54_0(AvatarData data));
        if(val_3 != null)
        {
            goto label_52;
        }
        
        goto label_52;
        label_53:
        AvatarDialogManager.<>c.<>9__54_2 = new System.Predicate<AvatarData>(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AvatarDialogManager.<>c::<UpdateRed>b__54_2(AvatarData data));
        if(val_10 != null)
        {
            goto label_55;
        }
        
        goto label_55;
        label_56:
        AvatarDialogManager.<>c.<>9__54_4 = new System.Predicate<AvatarData>(object:  AvatarDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AvatarDialogManager.<>c::<UpdateRed>b__54_4(AvatarData data));
        if(val_16 != null)
        {
            goto label_58;
        }
        
        goto label_58;
    }
    public AvatarDialogManager()
    {
        this.gachaTime = 3f;
        this.nodeList = new System.Collections.Generic.List<AvatarNode>();
    }
    private static AvatarDialogManager()
    {
        AvatarDialogManager.MaxNodeCount = 9;
        AvatarDialogManager.DetailAvatarDataTag = "AvatarDialogDetailAvatarData";
        AvatarDialogManager.CallbackTag = "AvatarDialogCallback";
    }
    private void <Awake>b__29_0()
    {
        var val_5 = null;
        int val_5 = AvatarDialogManager.MaxNodeCount;
        val_5 = (this.GetSortedAvatarDataList().IndexOf(item:  this.detailAvatarData)) / val_5;
        this.lastPage = val_5;
        this.InstantiateNodes();
        this.detailPageScrollRect.gameObject.SetActive(value:  false);
        this.listPageScrollRect.gameObject.SetActive(value:  true);
    }
    private bool <GetSortedAvatarDataList>b__36_0(AvatarData data)
    {
        return (bool)(data.category == this.selectedCategory) ? 1 : 0;
    }

}
