using UnityEngine;
public sealed class GameManager : SingletonMonoBehaviour<GameManager>
{
    // Fields
    private readonly string ContinueTag;
    private readonly string FirstPlayTag;
    private float girlMoveSpeed;
    private float slipTime;
    private float presentMoveBeginTime;
    private float presentMoveTime;
    private Dog dogPrefab;
    private Dog reverseDogPrefab;
    private UnityEngine.RectTransform presentPrefab;
    private UnityEngine.Canvas canvas;
    private UnityEngine.RectTransform presentIcon;
    private TMPro.TextMeshProUGUI stageText;
    private TMPro.TextMeshProUGUI nextStageText;
    private UnityEngine.UI.Slider stageProgressSlider;
    private UnityEngine.GameObject[] titleUIArray;
    private UnityEngine.GameObject[] runningUIArray;
    private UnityEngine.GameObject tapEffect;
    private UnityEngine.GameObject tutorialEffect;
    private UnityEngine.GameObject resultRewardPanel;
    private UnityEngine.UI.Text resultRewardText;
    private UnityEngine.UI.Text resultAdRewardText;
    private UnityEngine.UI.Button resultRewardYesButton;
    private UnityEngine.UI.Button resultRewardNoButton;
    private ParticleDestroyer resultAdRewardEffect;
    private ParticleDestroyer resultRewardEffect;
    private UnityEngine.UI.Button dailyLoginListButton;
    private UnityEngine.GameObject loginBonusBadgeObject;
    private UnityEngine.GameObject newAvatarBadgeObject;
    private UnityEngine.UI.Image[] titleImageArray;
    private CameraPivot cameraPivot;
    private UnityEngine.Camera uiCamera;
    private Girl girl;
    private StageManager stageManager;
    private UnityEngine.GameObject[] startEffectArray;
    private UnityEngine.GameObject[] foundEffectArray;
    private UnityEngine.GameObject[] clearEffectArray;
    private AvatarProgress avatarProgress;
    private Cat cat;
    private System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults;
    private bool isTapping;
    private GameState gameState;
    private System.Action updateAction;
    private TutorialState tutorialState;
    private UnityEngine.Coroutine slipCoroutine;
    private float slipSpeed;
    private UnityEngine.Coroutine cameraPivotMoveCoroutine;
    private bool isOwnPresentBox;
    private static readonly string FirstClickEventTag;
    private bool isPause;
    private UnityEngine.Coroutine checkAdCoroutine;
    private UnityEngine.GameObject adBadgeObject;
    
    // Methods
    private void Awake()
    {
        var val_16;
        StageData val_17;
        var val_18;
        GameManager.<>c__DisplayClass48_0 val_1 = new GameManager.<>c__DisplayClass48_0();
        GameData val_2 = GameDataManager.GameData;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .gameData = val_2;
        if(val_2 != null)
        {
            goto label_34;
        }
        
        label_35:
        label_34:
        if((val_2.stage >= 2) && (val_2.dailyLoginCount >= 1))
        {
                SingletonMonoBehaviour<LocalNotificationManager>.Instance.RegisterNotification();
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<StageData>(worksheetName:  Const.StageDataSheet).Find(match:  new System.Predicate<StageData>(object:  val_1, method:  System.Boolean GameManager.<>c__DisplayClass48_0::<Awake>b__0(StageData data)));
        if(val_17 == null)
        {
                val_18 = null;
            val_18 = null;
            val_17 = ListExtensions.RandomChoose<StageData>(list:  SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<StageData>(worksheetName:  Const.RandomStageDataSheet), rand:  new System.Random(Seed:  val_2.stage));
        }
        
        this.stageManager.Initialize(stageData:  val_17, stage:  val_2.stage, isContinue:  LocalCacheManager.Exists(tag:  this.ContinueTag));
        this.stageText.text = val_2.stage.ToString();
        int val_16 = val_2.stage;
        val_16 = val_16 + 1;
        this.nextStageText.text = val_16.ToString();
        if(val_2.stage != 1)
        {
                return;
        }
        
        this.tutorialState = val_2.stage;
        return;
        label_3:
        mem[16] = val_2;
        if(mem[16] != 0)
        {
            goto label_34;
        }
        
        goto label_35;
    }
    private void Start()
    {
        var val_24;
        var val_25;
        GameState val_26;
        var val_27;
        var val_28;
        var val_29;
        GameManager.<>c__DisplayClass49_0 val_1 = new GameManager.<>c__DisplayClass49_0();
        GameData val_2 = GameDataManager.GameData;
        if(val_2.stage == 4)
        {
                if(JoypacUtils.FirstPopReview != false)
        {
                JoypacUtils.FirstPopReview = false;
            ReviewView.Show(_callback:  0);
        }
        
        }
        
        GameData val_4 = GameDataManager.GameData;
        if(val_1 == null)
        {
            goto label_8;
        }
        
        .gameData = val_4;
        if(val_4 != null)
        {
            goto label_49;
        }
        
        label_50:
        label_49:
        this.girl.Initialize(gameManager:  this, stage:  val_4.stage);
        this.girl.ChangeAvatar();
        val_24 = null;
        val_24 = null;
        val_25 = null;
        if(val_4.catId < Const.DefaultCatId)
        {
                if(val_1 == null)
        {
                val_25 = null;
        }
        
            val_25 = null;
            catId = Const.DefaultCatId;
        }
        
        this.ChangeAvatar(avatarData:  SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).Find(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean GameManager.<>c__DisplayClass49_0::<Start>b__0(AvatarData data))), isGacha:  false);
        SingletonMonoBehaviour<CoinManager>.Instance.ChangeCoin(coin:  val_4.coin);
        this.dailyLoginListButton.gameObject.SetActive(value:  (val_4.stage > 1) ? 1 : 0);
        if((LocalCacheManager.Exists(tag:  this.ContinueTag)) != false)
        {
                val_26 = 2;
        }
        else
        {
                val_26 = 1;
        }
        
        this.ChangeState(nextState:  val_26);
        this.UpdateBadge();
        if((LocalCacheManager.Exists(tag:  this.FirstPlayTag)) != false)
        {
                return;
        }
        
        LanguageDataType val_15 = SingletonMonoBehaviour<LanguageManager>.Instance.GetDeviceLanguageDataType();
        if(val_15 == 1)
        {
            goto label_38;
        }
        
        if(val_15 != 0)
        {
            goto label_39;
        }
        
        this.titleImageArray[0].gameObject.SetActive(value:  true);
        UnityEngine.GameObject val_17 = this.titleImageArray[1].gameObject;
        val_27 = 0;
        goto label_48;
        label_8:
        mem[16] = val_4;
        if(mem[16] != 0)
        {
            goto label_49;
        }
        
        goto label_50;
        label_38:
        this.titleImageArray[0].gameObject.SetActive(value:  false);
        val_27 = 1;
        label_48:
        this.titleImageArray[1].gameObject.SetActive(value:  true);
        val_28 = this.titleImageArray[2].gameObject;
        val_29 = 0;
        goto label_63;
        label_39:
        this.titleImageArray[0].gameObject.SetActive(value:  false);
        this.titleImageArray[1].gameObject.SetActive(value:  false);
        val_28 = this.titleImageArray[2].gameObject;
        val_29 = 1;
        label_63:
        val_28.SetActive(value:  true);
    }
    private void ChangeState(GameState nextState)
    {
        if(this.gameState == nextState)
        {
                return;
        }
        
        this.gameState = nextState;
        if((nextState - 1) > 4)
        {
                return;
        }
        
        var val_2 = 28871872 + ((nextState - 1)) << 2;
        val_2 = val_2 + 28871872;
        goto (28871872 + ((nextState - 1)) << 2 + 28871872);
    }
    private void Update()
    {
        this.updateAction.Invoke();
    }
    public void OnStart()
    {
        object val_4;
        var val_5;
        var val_6;
        val_4 = 1152921504950562816;
        val_5 = null;
        val_5 = null;
        if((LocalCacheManager.Exists(tag:  GameManager.FirstClickEventTag)) != true)
        {
                GAEventManager val_2 = SingletonMonoBehaviour<GAEventManager>.Instance;
            val_6 = null;
            val_6 = null;
            val_4 = true;
            LocalCacheManager.Save(tag:  GameManager.FirstClickEventTag, value:  true);
        }
        
        if((LocalCacheManager.Exists(tag:  this.FirstPlayTag)) != true)
        {
                val_4 = true;
            LocalCacheManager.Save(tag:  this.FirstPlayTag, value:  true);
        }
        
        this.ChangeState(nextState:  3);
    }
    private void BeginStage(bool isContinue = False)
    {
        var val_13;
        float val_14;
        GameManager.<>c__DisplayClass53_0 val_1 = new GameManager.<>c__DisplayClass53_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .isContinue = isContinue;
        val_13 = 0;
        goto label_3;
        label_7:
        this.startEffectArray[0].SetActive(value:  true);
        val_13 = 1;
        label_3:
        if(val_13 < this.startEffectArray.Length)
        {
            goto label_7;
        }
        
        if(((GameManager.<>c__DisplayClass53_0)[1152921511906383232].isContinue) == false)
        {
            goto label_9;
        }
        
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_18;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
        val_14 = val_4.x;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14, y = val_4.y, z = val_4.z});
        if((this.CheckTap(position:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y})) == false)
        {
            goto label_18;
        }
        
        this.isTapping = true;
        this.girl.Hide();
        if(this.girl.IsSlipping != false)
        {
                val_14 = this.slipTime;
            this.slipCoroutine = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  val_14, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass53_0::<BeginStage>b__0(float t)));
        }
        
        this.isTapping = false;
        this.girl.BeginRun();
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.slipCoroutine);
        this.slipSpeed = 0f;
        goto label_18;
        label_9:
        this.girl.BeginRun();
        label_18:
        this.updateAction = new System.Action(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass53_0::<BeginStage>b__1());
        AnalyticsManager.StageBegin(gameData:  GameDataManager.GameData, stage:  val_11.stage);
        SingletonMonoBehaviour<GAEventManager>.Instance.StageEnter(stage:  val_11.stage, isContinue:  false);
    }
    private bool CheckTap(UnityEngine.Vector2 position)
    {
        UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
        UnityEngine.EventSystems.PointerEventData val_2 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  val_1);
        val_2.position = new UnityEngine.Vector2() {x = position.x, y = position.y};
        this.raycastResults.Clear();
        val_1.RaycastAll(eventData:  val_2, raycastResults:  this.raycastResults);
        return (bool)(this.raycastResults.Count == 0) ? 1 : 0;
    }
    public void BeginCatAction(CatActionTrigger catActionTrigger)
    {
        GameState val_1 = this.gameState;
        val_1 = val_1 & 4294967294;
        if(val_1 != 2)
        {
                return;
        }
        
        this.cat.BeginAction(catActionTrigger:  catActionTrigger);
    }
    public void CancelCatAction(CatCancelTrigger catCancelTrigger)
    {
        GameState val_1 = this.gameState;
        val_1 = val_1 & 4294967294;
        if(val_1 != 2)
        {
                return;
        }
        
        this.cat.CancelAction(catCancelTrigger:  catCancelTrigger);
    }
    public void ShowDog(DogActionTrigger dogActionTrigger)
    {
        if(dogActionTrigger.isUsed != false)
        {
                return;
        }
        
        dogActionTrigger.isUsed = true;
        UnityEngine.Object.Instantiate<Dog>(original:  (dogActionTrigger.isReverse == true) ? this.reverseDogPrefab : this.dogPrefab, parent:  this.transform).Show(dogActionTrigger:  dogActionTrigger);
    }
    public void GetPresentBox(UnityEngine.Vector3 position)
    {
        .<>4__this = this;
        if(this.isOwnPresentBox != false)
        {
                return;
        }
        
        this.isOwnPresentBox = true;
        UnityEngine.Vector3 val_3 = this.cameraPivot.Camera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        UnityEngine.Vector3 val_4 = this.uiCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = Vector3Extensions.SetZ(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, f:  0f);
        .fromPosition = val_5;
        mem[1152921511907193124] = val_5.y;
        mem[1152921511907193128] = val_5.z;
        UnityEngine.Vector3 val_6 = this.presentIcon.position;
        .toPosition = val_6;
        mem[1152921511907193136] = val_6.y;
        mem[1152921511907193140] = val_6.z;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        .effect = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.presentPrefab, position:  new UnityEngine.Vector3() {x = (GameManager.<>c__DisplayClass58_0)[1152921511907193088].fromPosition, y = val_4.x, z = val_4.y}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, parent:  this.canvas.transform);
        UnityEngine.Coroutine val_11 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  this.presentMoveBeginTime, act:  new System.Action(object:  new GameManager.<>c__DisplayClass58_0(), method:  System.Void GameManager.<>c__DisplayClass58_0::<GetPresentBox>b__0()));
    }
    private void UpdateStageProgress()
    {
        float val_1 = this.stageManager.StageProgress;
        if(this.stageProgressSlider == null)
        {
            
        }
    
    }
    private void Failed(bool isContinue)
    {
        var val_12;
        var val_13;
        GameManager.<>c__DisplayClass60_0 val_1 = new GameManager.<>c__DisplayClass60_0();
        if(val_1 != null)
        {
                .isContinue = isContinue;
        }
        else
        {
                mem[16] = isContinue;
        }
        
        .<>4__this = this;
        UnityEngine.Coroutine val_5 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  1f, act:  new System.Action(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass60_0::<Failed>b__0()));
        val_12 = 0;
        goto label_3;
        label_7:
        this.foundEffectArray[0].SetActive(value:  true);
        val_12 = 1;
        label_3:
        if(val_12 < this.foundEffectArray.Length)
        {
            goto label_7;
        }
        
        this.girl.Found();
        this.cat.Found();
        GameData val_6 = GameDataManager.GameData;
        val_6.coin = SingletonMonoBehaviour<CoinManager>.Instance.OwnCoin;
        GameDataManager.SaveGameData();
        val_13 = null;
        val_13 = null;
        this.updateAction = ActionExtensions.EmptyAction;
        SingletonMonoBehaviour<GAEventManager>.Instance.StageFail(stage:  val_6.stage);
        UnityEngine.Coroutine val_11 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  3f, act:  new System.Action(object:  this, method:  public System.Void GameManager::OnEndFailed()));
    }
    public void OnEndFailed()
    {
        JoypacAdManager.Instance.ShowInterstitial(callback:  new System.Action<JoypacIntersitialStatus>(object:  this, method:  System.Void GameManager::<OnEndFailed>b__61_0(JoypacIntersitialStatus status)), interId:  "hidegpIV");
    }
    private void Goal()
    {
        var val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        .<>4__this = this;
        this.girl.Goal();
        this.cat.Goal();
        GameData val_2 = GameDataManager.GameData;
        if(val_2 != null)
        {
                val_11 = val_2;
            val_12 = val_2.stage;
        }
        else
        {
                val_11 = 48;
            val_12 = 0;
        }
        
        mem[48] = 1;
        val_2.coin = SingletonMonoBehaviour<CoinManager>.Instance.OwnCoin;
        GameDataManager.SaveGameData();
        val_13 = 0;
        goto label_10;
        label_14:
        this.runningUIArray[0].SetActive(value:  false);
        val_13 = 1;
        label_10:
        if(val_13 < this.runningUIArray.Length)
        {
            goto label_14;
        }
        
        val_14 = 0;
        goto label_15;
        label_19:
        this.clearEffectArray[0].SetActive(value:  true);
        val_14 = 1;
        label_15:
        if(val_14 < this.clearEffectArray.Length)
        {
            goto label_19;
        }
        
        UnityEngine.Vector3 val_6 = this.cameraPivot.transform.position;
        .fromY = val_6.y;
        .fromSize = this.cameraPivot.Size;
        .prevDistance = 0f;
        UnityEngine.Coroutine val_9 = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  60f, act:  new System.Action<System.Single>(object:  new GameManager.<>c__DisplayClass62_0(), method:  System.Void GameManager.<>c__DisplayClass62_0::<Goal>b__0(float t)));
        val_15 = null;
        val_15 = null;
        this.updateAction = ActionExtensions.EmptyAction;
        this.Result();
        GAEventManager val_10 = SingletonMonoBehaviour<GAEventManager>.Instance;
        0.StageSuccess(stage:  mem[48] - 1);
    }
    private void Result()
    {
        var val_24;
        System.Action val_25;
        var val_26;
        var val_28;
        var val_29;
        var val_31;
        GameManager.<>c__DisplayClass63_0 val_1 = new GameManager.<>c__DisplayClass63_0();
        .<>4__this = this;
        GameData val_2 = GameDataManager.GameData;
        int val_24 = val_2.stage;
        val_24 = val_24 - 1;
        .stage = val_24;
        val_24 = null;
        val_24 = null;
        System.Collections.Generic.List<T> val_4 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        val_25 = 1152921504950882304;
        val_26 = null;
        val_26 = null;
        if((GameManager.<>c.<>9__63_0) == null)
        {
            goto label_10;
        }
        
        label_45:
        System.Collections.Generic.List<T> val_5 = val_4.FindAll(match:  GameManager.<>c.<>9__63_0);
        val_28 = 0;
        goto label_12;
        label_17:
        AvatarData val_6 = val_5.Item[0];
        if(val_6.value >= ((GameManager.<>c__DisplayClass63_0)[1152921511908368592].stage))
        {
            goto label_15;
        }
        
        val_28 = 1;
        label_12:
        if(val_28 < val_5.Count)
        {
            goto label_17;
        }
        
        .avatarData = 0;
        goto label_30;
        label_15:
        .avatarData = 0;
        if((val_28 & 2147483648) != 0)
        {
            goto label_30;
        }
        
        if(val_28 == 0)
        {
            goto label_20;
        }
        
        AvatarData val_8 = val_5.Item[-1];
        if(val_5 != null)
        {
            goto label_46;
        }
        
        label_47:
        label_46:
        val_29 = null;
        val_29 = null;
        val_25 = GameManager.<>c.<>9__63_1;
        if(val_25 == null)
        {
            goto label_26;
        }
        
        label_51:
        this.avatarProgress.Show(prev:  val_8.value, stage:  (GameManager.<>c__DisplayClass63_0)[1152921511908368592].stage, avatarData:  val_5.Item[0], callback:  val_25);
        AvatarData val_10 = val_5.Item[0];
        if(val_10.value == ((GameManager.<>c__DisplayClass63_0)[1152921511908368592].stage))
        {
                .avatarData = val_5.Item[0];
        }
        
        label_30:
        UnityEngine.Coroutine val_13 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  3f, act:  new System.Action(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass63_0::<Result>b__2()));
        val_31 = null;
        val_31 = null;
        int val_25 = Const.ResultAdRewardMagnification;
        val_25 = val_25 * (GameLogic.CalcResultCoin(stage:  (GameManager.<>c__DisplayClass63_0)[1152921511908368592].stage));
        string val_15 = "+"("+") + val_25;
        string val_17 = "+"("+") + GameLogic.CalcResultCoin(stage:  (GameManager.<>c__DisplayClass63_0)[1152921511908368592].stage)(GameLogic.CalcResultCoin(stage:  (GameManager.<>c__DisplayClass63_0)[1152921511908368592].stage));
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Ad", type:  "impression", position:  "Gold", onlyFirst:  false, extra:  "");
        this.resultRewardYesButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass63_0::<Result>b__3()));
        this.resultRewardNoButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass63_0::<Result>b__4()));
        return;
        label_10:
        GameManager.<>c.<>9__63_0 = new System.Predicate<AvatarData>(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameManager.<>c::<Result>b__63_0(AvatarData data));
        if(val_4 != null)
        {
            goto label_45;
        }
        
        goto label_45;
        label_20:
        if(val_5 != null)
        {
            goto label_46;
        }
        
        goto label_47;
        label_26:
        GameManager.<>c.<>9__63_1 = new System.Action(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameManager.<>c::<Result>b__63_1());
        if(this.avatarProgress != null)
        {
            goto label_51;
        }
        
        goto label_51;
    }
    private void ResultReward(int stage, int magnification, AvatarData avatarData)
    {
        ParticleDestroyer val_11;
        GameManager.<>c__DisplayClass64_0 val_1 = new GameManager.<>c__DisplayClass64_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .avatarData = avatarData;
        SingletonMonoBehaviour<CoinManager>.Instance.AddCoin(coin:  (GameLogic.CalcResultCoin(stage:  stage)) * magnification);
        GameData val_5 = GameDataManager.GameData;
        val_5.coin = SingletonMonoBehaviour<CoinManager>.Instance.OwnCoin;
        GameDataManager.SaveGameData();
        this.resultRewardPanel.SetActive(value:  false);
        if(magnification >= 2)
        {
            goto label_9;
        }
        
        this.resultRewardEffect.gameObject.SetActive(value:  true);
        val_11 = this.resultRewardEffect;
        if(val_11 != null)
        {
            goto label_16;
        }
        
        goto label_13;
        label_9:
        this.resultAdRewardEffect.gameObject.SetActive(value:  true);
        val_11 = this.resultAdRewardEffect;
        if(val_11 != null)
        {
            goto label_16;
        }
        
        label_13:
        label_16:
        val_11.SetCallback(callback:  new System.Action(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass64_0::<ResultReward>b__0()));
    }
    private void GetAvatar(AvatarData avatarData, bool isNextTransition, System.Action<bool> callback, string event_str)
    {
        string val_6;
        GameManager val_7;
        AvatarData val_8;
        val_6 = event_str;
        val_7 = this;
        GameManager.<>c__DisplayClass65_0 val_1 = new GameManager.<>c__DisplayClass65_0();
        if(val_1 != null)
        {
                val_8 = val_1;
            .avatarData = avatarData;
            mem[1152921511908851696] = val_7;
            mem[1152921511908851704] = val_6;
            mem[1152921511908851712] = callback;
            mem[1152921511908851720] = isNextTransition;
            mem[1152921511908851680] = 0;
        }
        else
        {
                val_8 = 24;
            mem[24] = avatarData;
            mem[32] = val_7;
            val_7 = 40;
            mem[40] = val_6;
            mem[48] = callback;
            mem[56] = isNextTransition;
            mem[16] = 0;
            val_6 = mem[40];
        }
        
        JoypacAnalyticsManager.DesignEvent(_logType:  mem[32], sort:  "Ad", type:  "impression", position:  val_6, onlyFirst:  false, extra:  "");
        GetAvatarDialogManager.ShowDialog(avatarData:  val_8, yesCallback:  new System.Action<System.Action<System.Boolean>>(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass65_0::<GetAvatar>b__0(System.Action<bool> resultCallback)), callback:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean GameManager.<>c__DisplayClass65_0::<GetAvatar>b__1()));
    }
    private void CheckPresentBox(bool isNextTransition, System.Action<bool> callback)
    {
        var val_9;
        if(this.isOwnPresentBox != false)
        {
                .gameData = GameDataManager.GameData;
            val_9 = null;
            val_9 = null;
            this.GetAvatar(avatarData:  ListExtensions.RandomChooseRatio<AvatarData>(list:  SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).FindAll(match:  new System.Predicate<AvatarData>(object:  new GameManager.<>c__DisplayClass66_0(), method:  System.Boolean GameManager.<>c__DisplayClass66_0::<CheckPresentBox>b__0(AvatarData data)))), isNextTransition:  isNextTransition, callback:  callback, event_str:  "PresentBox");
            return;
        }
        
        callback.Invoke(obj:  false);
    }
    public void ChangeAvatar(AvatarData avatarData, bool isGacha = False)
    {
        GameManager.<>c__DisplayClass67_0 val_1 = new GameManager.<>c__DisplayClass67_0();
        if((avatarData.Category - 1) > 3)
        {
                return;
        }
        
        var val_4 = 28871856 + ((val_2 - 1)) << 2;
        val_4 = val_4 + 28871856;
        goto (28871856 + ((val_2 - 1)) << 2 + 28871856);
    }
    public void OnTransitionGacha()
    {
        SingletonMonoBehaviour<TransitionManager>.Instance.LoadScene(scene:  2);
    }
    public void OnOpenSettings()
    {
        this.canvas.gameObject.SetActive(value:  false);
        SettingsDialogManager.ShowDialog(callback:  new System.Action(object:  this, method:  System.Void GameManager::<OnOpenSettings>b__69_0()));
    }
    public void OnOpenLoginBonusList()
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Ad", type:  "impression", position:  "SignInReward", onlyFirst:  false, extra:  "");
        this.canvas.gameObject.SetActive(value:  false);
        LoginBonusListDialogManager.ShowDialog(openDetailAction:  new System.Action<AvatarData, System.Action>(object:  this, method:  System.Void GameManager::<OnOpenLoginBonusList>b__70_0(AvatarData avatarData, System.Action hideAction)), callback:  new System.Action(object:  this, method:  System.Void GameManager::<OnOpenLoginBonusList>b__70_1()));
    }
    private void GetAvatar(AvatarData avatarData, System.Action<bool> callback, string event_str)
    {
        GameManager.<>c__DisplayClass71_0 val_1 = new GameManager.<>c__DisplayClass71_0();
        if(val_1 != null)
        {
                .avatarData = avatarData;
            .<>4__this = this;
        }
        else
        {
                mem[16] = avatarData;
            mem[24] = this;
        }
        
        .callback = callback;
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardVideo(callback:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass71_0::<GetAvatar>b__0(bool result)), eventName:  event_str, showPop:  true);
    }
    public void OnOpenAvatarDialog()
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Behavior", type:  "click", position:  "SkinShop", onlyFirst:  false, extra:  "");
        this.canvas.gameObject.SetActive(value:  false);
        TransformExtensions.SetPositionY(t:  this.cameraPivot.transform, f:  -4.5f);
        AvatarDialogManager.ShowDialog(callback:  new System.Action(object:  this, method:  System.Void GameManager::<OnOpenAvatarDialog>b__72_0()));
        if((SingletonMonoBehaviour<GAEventManager>.Instance) != null)
        {
                return;
        }
    
    }
    public void ShowAvatar()
    {
        .<>4__this = this;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.cameraPivotMoveCoroutine);
        UnityEngine.Vector3 val_3 = this.cameraPivot.transform.position;
        .from = val_3.y;
        this.cameraPivotMoveCoroutine = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  0.5f, act:  new System.Action<System.Single>(object:  new GameManager.<>c__DisplayClass73_0(), method:  System.Void GameManager.<>c__DisplayClass73_0::<ShowAvatar>b__0(float t)));
    }
    public void ShowCat()
    {
        .<>4__this = this;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.cameraPivotMoveCoroutine);
        UnityEngine.Vector3 val_3 = this.cameraPivot.transform.position;
        .from = val_3.y;
        this.cameraPivotMoveCoroutine = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  0.5f, act:  new System.Action<System.Single>(object:  new GameManager.<>c__DisplayClass74_0(), method:  System.Void GameManager.<>c__DisplayClass74_0::<ShowCat>b__0(float t)));
    }
    private void TransitionToMain(bool isAcquiredAvatar = False)
    {
        var val_25;
        var val_26;
        var val_28;
        var val_30;
        GameData val_32;
        var val_33;
        .gameData = GameDataManager.GameData;
        val_25 = null;
        val_25 = null;
        System.Collections.Generic.List<T> val_6 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).FindAll(match:  new System.Predicate<AvatarData>(object:  new GameManager.<>c__DisplayClass75_0(), method:  System.Boolean GameManager.<>c__DisplayClass75_0::<TransitionToMain>b__0(AvatarData data)));
        if(((GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.isRandomAvatar) == false)
        {
            goto label_15;
        }
        
        val_26 = null;
        val_26 = null;
        if((GameManager.<>c.<>9__75_1) == null)
        {
            goto label_12;
        }
        
        label_51:
        System.Collections.Generic.List<T> val_7 = val_6.FindAll(match:  GameManager.<>c.<>9__75_1);
        if(val_7.Count >= 1)
        {
                (GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.ChangeAvatar(avatarData:  ListExtensions.RandomChoose<AvatarData>(list:  val_7));
        }
        
        label_15:
        if(((GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.isRandomCat) == false)
        {
            goto label_24;
        }
        
        val_28 = null;
        val_28 = null;
        if((GameManager.<>c.<>9__75_2) == null)
        {
            goto label_21;
        }
        
        label_55:
        System.Collections.Generic.List<T> val_10 = val_6.FindAll(match:  GameManager.<>c.<>9__75_2);
        if(val_10.Count >= 1)
        {
                (GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.ChangeAvatar(avatarData:  ListExtensions.RandomChoose<AvatarData>(list:  val_10));
        }
        
        label_24:
        if(((GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.isRandomCatHeadgear) == false)
        {
            goto label_33;
        }
        
        val_30 = null;
        val_30 = null;
        if((GameManager.<>c.<>9__75_3) == null)
        {
            goto label_30;
        }
        
        label_59:
        System.Collections.Generic.List<T> val_13 = val_6.FindAll(match:  GameManager.<>c.<>9__75_3);
        if(val_13.Count >= 1)
        {
                (GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.ChangeAvatar(avatarData:  ListExtensions.RandomChoose<AvatarData>(list:  val_13));
        }
        
        label_33:
        val_32 = (GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData;
        if(((GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.isRandomCatFaceItem) == false)
        {
            goto label_42;
        }
        
        val_33 = null;
        val_33 = null;
        val_32 = GameManager.<>c.<>9__75_4;
        if(val_32 == null)
        {
            goto label_39;
        }
        
        label_63:
        System.Collections.Generic.List<T> val_16 = val_6.FindAll(match:  val_32);
        if(val_16.Count >= 1)
        {
                (GameManager.<>c__DisplayClass75_0)[1152921511910473712].gameData.ChangeAvatar(avatarData:  ListExtensions.RandomChoose<AvatarData>(list:  val_16));
        }
        
        label_42:
        JoypacAdManager.Instance.ShowBanner();
        SingletonMonoBehaviour<TransitionManager>.Instance.LoadScene(scene:  1);
        return;
        label_12:
        GameManager.<>c.<>9__75_1 = new System.Predicate<AvatarData>(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameManager.<>c::<TransitionToMain>b__75_1(AvatarData data));
        if(val_6 != null)
        {
            goto label_51;
        }
        
        goto label_51;
        label_21:
        GameManager.<>c.<>9__75_2 = new System.Predicate<AvatarData>(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameManager.<>c::<TransitionToMain>b__75_2(AvatarData data));
        if(val_6 != null)
        {
            goto label_55;
        }
        
        goto label_55;
        label_30:
        GameManager.<>c.<>9__75_3 = new System.Predicate<AvatarData>(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameManager.<>c::<TransitionToMain>b__75_3(AvatarData data));
        if(val_6 != null)
        {
            goto label_59;
        }
        
        goto label_59;
        label_39:
        GameManager.<>c.<>9__75_4 = new System.Predicate<AvatarData>(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameManager.<>c::<TransitionToMain>b__75_4(AvatarData data));
        if(val_6 != null)
        {
            goto label_63;
        }
        
        goto label_63;
    }
    private void ContinueReload()
    {
        GameData val_1 = GameDataManager.GameData;
        val_1.coin = SingletonMonoBehaviour<CoinManager>.Instance.OwnCoin;
        float val_4 = this.stageManager.GirlPosition;
        LocalCacheManager.Save(tag:  this.ContinueTag, value:  0);
        SingletonMonoBehaviour<TransitionManager>.Instance.LoadScene(scene:  1);
    }
    private void _showInterstitial()
    {
    
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if((pauseStatus != false) && (this.gameState == 1))
        {
                this.isPause = this.gameState;
            return;
        }
        
        if(this.isPause == false)
        {
                return;
        }
        
        this.isPause = false;
        this.CheckLoginBonus();
    }
    public void SaveData()
    {
        GameData val_1 = GameDataManager.GameData;
        System.DateTime val_2 = System.DateTime.UtcNow;
        val_1.lastPlayTime = ;
        GameDataManager.SaveGameData();
    }
    private void CheckLoginBonus()
    {
        GameManager.<>c__DisplayClass81_0 val_14;
        GameData val_15;
        var val_16;
        var val_17;
        GameData val_19;
        int val_20;
        GameManager.<>c__DisplayClass81_0 val_1 = null;
        val_14 = val_1;
        val_1 = new GameManager.<>c__DisplayClass81_0();
        .<>4__this = this;
        val_15 = GameDataManager.GameData;
        .gameData = val_15;
        if(val_2.stage < 2)
        {
                return;
        }
        
        val_15 = (GameManager.<>c__DisplayClass81_0)[1152921511911316336].gameData;
        if(val_15.IsReceivableDailyBonus == false)
        {
                return;
        }
        
        GameManager.<>c__DisplayClass81_1 val_4 = null;
        val_15 = val_4;
        val_4 = new GameManager.<>c__DisplayClass81_1();
        .CS$<>8__locals1 = val_14;
        val_16 = null;
        val_16 = null;
        val_14 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        val_17 = null;
        val_17 = null;
        if((GameManager.<>c.<>9__81_0) == null)
        {
            goto label_14;
        }
        
        label_22:
        val_14.Sort(comparison:  GameManager.<>c.<>9__81_0);
        val_19 = (GameManager.<>c__DisplayClass81_1)[1152921511911328624].CS$<>8__locals1.gameData;
        if(val_19 == null)
        {
            goto label_17;
        }
        
        val_20 = (GameManager.<>c__DisplayClass81_1)[1152921511911328624].CS$<>8__locals1.gameData.dailyLoginCount;
        goto label_18;
        label_14:
        GameManager.<>c.<>9__81_0 = new System.Comparison<AvatarData>(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GameManager.<>c::<CheckLoginBonus>b__81_0(AvatarData a, AvatarData b));
        if(val_14 != null)
        {
            goto label_22;
        }
        
        goto label_22;
        label_17:
        val_19 = 40;
        val_20 = 37160040;
        label_18:
        mem[40] = 37160041;
        System.DateTime val_8 = System.DateTime.UtcNow;
        (GameManager.<>c__DisplayClass81_1)[1152921511911328624].CS$<>8__locals1.gameData.lastDailyBonusTime = ;
        .avatarData = val_14.Find(match:  new System.Predicate<AvatarData>(object:  (GameManager.<>c__DisplayClass81_1)[1152921511911328624].CS$<>8__locals1, method:  System.Boolean GameManager.<>c__DisplayClass81_0::<CheckLoginBonus>b__1(AvatarData data)));
        GameDataManager.SaveGameData();
        if(((GameManager.<>c__DisplayClass81_1)[1152921511911328624].avatarData) != null)
        {
                this.canvas.gameObject.SetActive(value:  false);
            System.Action val_12 = null;
            val_14 = val_12;
            val_12 = new System.Action(object:  val_4, method:  System.Void GameManager.<>c__DisplayClass81_1::<CheckLoginBonus>b__2());
            LoginBonusDetailDialogManager.ShowDialog(avatarData:  (GameManager.<>c__DisplayClass81_1)[1152921511911328624].avatarData, callback:  val_12);
        }
        
        if(((GameManager.<>c__DisplayClass81_1)[1152921511911328624].CS$<>8__locals1.gameData.stage) != 2)
        {
                return;
        }
        
        val_15 = (GameManager.<>c__DisplayClass81_1)[1152921511911328624].CS$<>8__locals1.gameData;
        if(((GameManager.<>c__DisplayClass81_1)[1152921511911328624].CS$<>8__locals1.gameData.dailyLoginCount) != 1)
        {
                return;
        }
        
        val_15 = SingletonMonoBehaviour<LocalNotificationManager>.Instance;
        val_15.RegisterNotification();
    }
    private void UpdateBadge()
    {
        var val_18;
        GameData val_19;
        .gameData = GameDataManager.GameData;
        val_18 = null;
        val_18 = null;
        this.loginBonusBadgeObject.SetActive(value:  SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).Exists(match:  new System.Predicate<AvatarData>(object:  new GameManager.<>c__DisplayClass82_0(), method:  System.Boolean GameManager.<>c__DisplayClass82_0::<UpdateBadge>b__0(AvatarData data))));
        this.newAvatarBadgeObject.SetActive(value:  this.loginBonusBadgeObject.Red());
        AdRewardType val_18 = 1;
        float val_10 = (GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData.GetAdRewardRemainingTime(type:  val_18);
        val_19 = (GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData;
        if(((GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData) == null)
        {
                val_19 = (GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData;
        }
        
        int val_11 = ((GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData.gachaCount) * ((GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData.gachaCount);
        val_11 = 30 + (val_11 * ((((GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData.gachaCount) > 4) ? 40 : 30));
        val_18 = ((val_10 <= 0f) ? 1 : 0) | ((((GameManager.<>c__DisplayClass82_0)[1152921511911589104].gameData.coin) >= val_11) ? 1 : 0);
        this.adBadgeObject.SetActive(value:  val_18);
        if(this.adBadgeObject.activeSelf == true)
        {
                return;
        }
        
        if(this.checkAdCoroutine != null)
        {
                MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.checkAdCoroutine);
        }
        
        if(val_10 <= 0f)
        {
                return;
        }
        
        this.checkAdCoroutine = this.StartCoroutine(routine:  this.CheckAd());
    }
    private System.Collections.IEnumerator CheckAd()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new GameManager.<CheckAd>d__84(<>1__state:  0);
    }
    public bool Red()
    {
        var val_6 = null;
        System.Collections.Generic.List<T> val_3 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        .gameData = GameDataManager.GameData;
        if(val_3 != null)
        {
                return val_3.Exists(match:  new System.Predicate<AvatarData>(object:  new GameManager.<>c__DisplayClass86_0(), method:  System.Boolean GameManager.<>c__DisplayClass86_0::<Red>b__0(AvatarData data)));
        }
        
        return val_3.Exists(match:  new System.Predicate<AvatarData>(object:  new GameManager.<>c__DisplayClass86_0(), method:  System.Boolean GameManager.<>c__DisplayClass86_0::<Red>b__0(AvatarData data)));
    }
    public GameManager()
    {
        var val_2;
        this.ContinueTag = "Continue";
        this.girlMoveSpeed = ;
        this.slipTime = ;
        this.presentMoveBeginTime = 1f;
        this.presentMoveTime = 0.5f;
        this.FirstPlayTag = "FirstPlay";
        this.raycastResults = new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>();
        val_2 = null;
        val_2 = null;
        this.updateAction = ActionExtensions.EmptyAction;
    }
    private static GameManager()
    {
        GameManager.FirstClickEventTag = "FirstClickEvent";
    }
    private void <ChangeState>b__50_0()
    {
        if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if((this.CheckTap(position:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})) != false)
        {
                this.BeginStage(isContinue:  true);
        }
        
        }
        
        float val_7 = this.girl.FloorMoveSpeed + this.slipSpeed;
        val_7 = val_7 * UnityEngine.Time.deltaTime;
        this.stageManager.Move(speed:  val_7);
    }
    private void <ChangeState>b__50_1()
    {
        TutorialState val_1 = this.tutorialState;
        val_1 = val_1 - 1;
        if(val_1 > 1)
        {
                return;
        }
        
        this.tutorialState = 0;
        UnityEngine.Time.timeScale = 1f;
        this.tutorialEffect.SetActive(value:  false);
    }
    private void <ChangeState>b__50_2()
    {
        this.BeginStage(isContinue:  false);
    }
    private void <OnEndFailed>b__61_0(JoypacIntersitialStatus status)
    {
        if(status == 0)
        {
                return;
        }
        
        this.CheckPresentBox(isNextTransition:  true, callback:  new System.Action<System.Boolean>(object:  this, method:  System.Void GameManager::TransitionToMain(bool isAcquiredAvatar)));
    }
    private void <OnOpenSettings>b__69_0()
    {
        this.canvas.gameObject.SetActive(value:  true);
    }
    private void <OnOpenLoginBonusList>b__70_0(AvatarData avatarData, System.Action hideAction)
    {
        GameManager.<>c__DisplayClass70_0 val_1 = new GameManager.<>c__DisplayClass70_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .hideAction = hideAction;
        this.GetAvatar(avatarData:  avatarData, callback:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass70_0::<OnOpenLoginBonusList>b__2(bool isAcquiredAvatar)), event_str:  "SignInReward");
    }
    private void <OnOpenLoginBonusList>b__70_1()
    {
        this.canvas.gameObject.SetActive(value:  true);
    }
    private void <OnOpenAvatarDialog>b__72_0()
    {
        this.canvas.gameObject.SetActive(value:  true);
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.cameraPivotMoveCoroutine);
        TransformExtensions.SetPositionY(t:  this.cameraPivot.transform, f:  0f);
        this.UpdateBadge();
    }

}
