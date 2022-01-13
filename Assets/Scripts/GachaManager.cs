using UnityEngine;
public sealed class GachaManager : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button gachaButton;
    private UnityEngine.UI.Button backButton;
    private UnityEngine.UI.Button adRewardButton;
    private UnityEngine.UI.Text adRewardText;
    private TMPro.TextMeshProUGUI adRewardResultText;
    private UnityEngine.UI.Text adRewardRemainingTimeText;
    private UnityEngine.GameObject[] adRewardResultEffect;
    private UnityEngine.UI.Text costText;
    private UnityEngine.Animator ratAnimator;
    private UnityEngine.GameObject shopOpen;
    private UnityEngine.GameObject shopClose;
    private UnityEngine.Transform avatarPivot;
    private UnityEngine.Coroutine coroutine;
    private AvatarData avatarData;
    private bool isPause;
    private UnityEngine.GameObject red;
    
    // Methods
    private void Awake()
    {
        this.gachaButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GachaManager::Gacha()));
        this.adRewardButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GachaManager::ShowAd()));
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GachaManager::OnTransitionMain()));
        this.UpdateUI();
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  this, method:  System.Void GachaManager::TransitionToMain()));
    }
    private void Start()
    {
        GameData val_1 = GameDataManager.GameData;
        SingletonMonoBehaviour<CoinManager>.Instance.ChangeCoin(coin:  val_1.coin);
    }
    private void Gacha()
    {
        int val_4 = 30 + ((val_1.gachaCount * val_1.gachaCount) * ((val_1.gachaCount > 4) ? 40 : 30));
        if(val_1.coin < val_4)
        {
                return;
        }
        
        System.Collections.Generic.List<AvatarData> val_5 = this.GetChooseableDataList();
        if(val_5.Count < 1)
        {
                return;
        }
        
        this.gachaButton.gameObject.SetActive(value:  false);
        this.backButton.gameObject.SetActive(value:  false);
        this.adRewardButton.gameObject.SetActive(value:  false);
        AvatarData val_10 = ListExtensions.RandomChooseRatio<AvatarData>(list:  val_5);
        this.avatarData = val_10;
        GameDataManager.GameData.AddAvatar(avatarData:  val_10);
        int val_12 = val_1.gachaCount;
        int val_13 = val_1.coin;
        val_12 = val_12 + 1;
        val_13 = val_13 - val_4;
        val_1.gachaCount = val_12;
        val_1.coin = val_13;
        GameDataManager.SaveGameData();
        SingletonMonoBehaviour<CoinManager>.Instance.SubCoin(coin:  val_4);
        this.ratAnimator.SetTrigger(name:  "Gacha");
        this.UpdateAdRewardButton();
    }
    public void OnEndGacha()
    {
        GetAvatarGachaDialogManager.ShowDialog(avatarData:  this.avatarData, callback:  new System.Action(object:  this, method:  System.Void GachaManager::<OnEndGacha>b__17_0()));
    }
    private System.Collections.Generic.List<AvatarData> GetChooseableDataList()
    {
        var val_6;
        .gameData = GameDataManager.GameData;
        val_6 = null;
        val_6 = null;
        System.Collections.Generic.List<T> val_4 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet);
        if(val_4 != null)
        {
                return val_4.FindAll(match:  new System.Predicate<AvatarData>(object:  new GachaManager.<>c__DisplayClass18_0(), method:  System.Boolean GachaManager.<>c__DisplayClass18_0::<GetChooseableDataList>b__0(AvatarData data)));
        }
        
        return val_4.FindAll(match:  new System.Predicate<AvatarData>(object:  new GachaManager.<>c__DisplayClass18_0(), method:  System.Boolean GachaManager.<>c__DisplayClass18_0::<GetChooseableDataList>b__0(AvatarData data)));
    }
    private void UpdateUI()
    {
        UnityEngine.GameObject val_1 = this.backButton.gameObject;
        val_1.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.gachaButton.gameObject;
        if(val_1.GetChooseableDataList().Count >= 1)
        {
                val_4.SetActive(value:  true);
            this.adRewardButton.gameObject.SetActive(value:  true);
            GameData val_6 = GameDataManager.GameData;
            int val_9 = 30 + ((val_6.gachaCount * val_6.gachaCount) * ((val_6.gachaCount > 4) ? 40 : 30));
            this.gachaButton.interactable = (val_6.coin >= val_9) ? 1 : 0;
            string val_11 = System.String.Format(format:  "{0:N0}", arg0:  val_9);
            this.UpdateAdRewardButton();
            return;
        }
        
        val_4.SetActive(value:  false);
        this.adRewardButton.gameObject.SetActive(value:  false);
        this.avatarPivot.gameObject.SetActive(value:  false);
        this.shopOpen.SetActive(value:  false);
        this.shopClose.SetActive(value:  true);
    }
    private void UpdateAdRewardButton()
    {
        UnityEngine.MonoBehaviour val_12;
        UnityEngine.UI.Text val_13;
        int val_14;
        val_12 = this;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        GameData val_1 = GameDataManager.GameData;
        val_13 = this.adRewardText;
        if(val_1 != null)
        {
                val_14 = val_1.adCount;
        }
        else
        {
                val_14 = 0;
        }
        
        string val_3 = System.String.Format(format:  "+{0:N0}", arg0:  GameLogic.GachaAdReward(adCount:  0, gachaCount:  val_1.gachaCount));
        if((val_1.GetAdRewardRemainingTime(type:  1)) > 0f)
        {
                .<>4__this = val_12;
            this.adRewardRemainingTimeText.gameObject.SetActive(value:  true);
            this.adRewardButton.interactable = false;
            this.red.SetActive(value:  false);
            float val_7 = val_1.GetAdRewardRemainingTime(type:  1);
            .remainingTime = val_7;
            System.Action val_9 = null;
            val_13 = val_9;
            val_9 = new System.Action(object:  this, method:  System.Void GachaManager::UpdateAdRewardButton());
            this.coroutine = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  val_7, act:  new System.Action<System.Single>(object:  new GachaManager.<>c__DisplayClass20_0(), method:  System.Void GachaManager.<>c__DisplayClass20_0::<UpdateAdRewardButton>b__0(float t)), callback:  val_9);
            return;
        }
        
        this.adRewardButton.interactable = true;
        this.red.SetActive(value:  true);
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Ad", type:  "impression", position:  "SweetShopGoldCoin", onlyFirst:  false, extra:  "");
        val_12 = this.adRewardRemainingTimeText.gameObject;
        val_12.SetActive(value:  false);
    }
    private void ShowAd()
    {
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardVideo(callback:  new System.Action<System.Boolean>(object:  this, method:  System.Void GachaManager::<ShowAd>b__21_0(bool result)), eventName:  "SweetShopGoldCoin", showPop:  true);
    }
    public void ShowAdSuccess()
    {
        UnityEngine.GameObject val_7;
        var val_8;
        int val_9;
        var val_10;
        val_7 = this;
        GameData val_1 = GameDataManager.GameData;
        if(val_1 != null)
        {
                val_8 = val_1;
            val_9 = val_1.adCount;
        }
        else
        {
                val_8 = 44;
            val_9 = 0;
        }
        
        int val_2 = GameLogic.GachaAdReward(adCount:  0, gachaCount:  val_1.gachaCount);
        this.adRewardResultText.text = "+"("+") + val_2;
        SingletonMonoBehaviour<CoinManager>.Instance.AddCoin(coin:  val_2);
        val_1.coin = SingletonMonoBehaviour<CoinManager>.Instance.OwnCoin;
        mem[44] = 1;
        val_1.ShowedAdReward(type:  1);
        GameDataManager.SaveGameData();
        this.UpdateUI();
        val_10 = 0;
        goto label_8;
        label_13:
        val_7 = this.adRewardResultEffect[0];
        if(val_7 != null)
        {
                val_7.SetActive(value:  false);
        }
        else
        {
                0.SetActive(value:  false);
        }
        
        val_7.SetActive(value:  true);
        val_10 = 1;
        label_8:
        if(val_10 < this.adRewardResultEffect.Length)
        {
            goto label_13;
        }
    
    }
    public void OnTransitionMain()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
    }
    private void TransitionToMain()
    {
        SingletonMonoBehaviour<TransitionManager>.Instance.LoadScene(scene:  1);
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus != false)
        {
                this.isPause = true;
            return;
        }
        
        if(this.isPause == false)
        {
                return;
        }
        
        this.isPause = false;
        this.UpdateAdRewardButton();
    }
    public GachaManager()
    {
    
    }
    private void <OnEndGacha>b__17_0()
    {
        this.ratAnimator.SetTrigger(name:  "EndGacha");
        this.UpdateUI();
    }
    private void <ShowAd>b__21_0(bool result)
    {
        if(result == false)
        {
                return;
        }
        
        this.ShowAdSuccess();
    }

}
