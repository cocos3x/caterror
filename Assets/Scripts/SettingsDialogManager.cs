using UnityEngine;
public sealed class SettingsDialogManager : DialogManagerParent
{
    // Fields
    private static readonly string CallbackTag;
    private UnityEngine.UI.Slider sliderSE;
    private UnityEngine.UI.Toggle vibrationToggle;
    private UnityEngine.GameObject settingsPanel;
    private UnityEngine.GameObject languagePanel;
    private UnityEngine.UI.Button[] languageButtonArray;
    private UnityEngine.GameObject[] selectedLanguageIconArray;
    private UnityEngine.GameObject officialPanel;
    private UnityEngine.UI.Button lineButton;
    private UnityEngine.UI.Button twitterButton;
    private bool isShopping;
    
    // Methods
    private void Awake()
    {
        LanguageDataType val_16;
        var val_17;
        SettingsDialogManager.<>c__DisplayClass11_0 val_1 = new SettingsDialogManager.<>c__DisplayClass11_0();
        .<>4__this = this;
        this.InitializeVolumeSlider(soundType:  1, slider:  this.sliderSE);
        this.vibrationToggle.isOn = SingletonMonoBehaviour<VibrationManager>.Instance.IsEnable;
        this.vibrationToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SettingsDialogManager::ChangedVibrationToggle(bool value)));
        .selectedLanguageDataType = SingletonMonoBehaviour<LanguageManager>.Instance.GetDeviceLanguageDataType();
        val_16 = 0;
        goto label_7;
        label_19:
        SettingsDialogManager.<>c__DisplayClass11_1 val_8 = new SettingsDialogManager.<>c__DisplayClass11_1();
        if(val_8 != null)
        {
                val_17 = val_8;
            .CS$<>8__locals1 = val_1;
        }
        else
        {
                mem[24] = val_1;
            val_17 = 24;
        }
        
        .languageDataType = val_16;
        this.languageButtonArray[0].onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_8, method:  System.Void SettingsDialogManager.<>c__DisplayClass11_1::<Awake>b__1()));
        this.selectedLanguageIconArray[0].SetActive(value:  (((SettingsDialogManager.<>c__DisplayClass11_1)[1152921511940622816].languageDataType) == .selectedLanguageDataType) ? 1 : 0);
        val_16 = 1;
        label_7:
        if(val_16 < this.languageButtonArray.Length)
        {
            goto label_19;
        }
        
        this.officialPanel.SetActive(value:  false);
        this.lineButton.gameObject.SetActive(value:  false);
        this.twitterButton.gameObject.SetActive(value:  false);
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  val_1, method:  System.Void SettingsDialogManager.<>c__DisplayClass11_0::<Awake>b__0()));
    }
    private void InitializeVolumeSlider(SoundType soundType, UnityEngine.UI.Slider slider)
    {
        UnityEngine.UI.Slider val_8;
        var val_9;
        float val_10;
        SettingsDialogManager.<>c__DisplayClass12_0 val_1 = new SettingsDialogManager.<>c__DisplayClass12_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .soundType = soundType;
        mem[1152921511940942712] = slider;
        if(slider != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        slider.onValueChanged.RemoveAllListeners();
        if(val_1 == null)
        {
            goto label_4;
        }
        
        val_8 = mem[1152921511940942712];
        val_9 = SingletonMonoBehaviour<SoundManager>.Instance;
        goto label_5;
        label_1:
        mem[16] = soundType;
        mem[24] = slider;
        if(mem[24] != 0)
        {
            goto label_6;
        }
        
        goto label_7;
        label_4:
        val_8 = mem[1152921511940942712];
        val_9 = SingletonMonoBehaviour<SoundManager>.Instance;
        label_5:
        if(.soundType == 2)
        {
            goto label_9;
        }
        
        if(.soundType != 0)
        {
            goto label_10;
        }
        
        val_10 = val_4.bgmVolume;
        goto label_12;
        label_9:
        val_10 = val_4.voiceVolume;
        goto label_12;
        label_10:
        val_10 = val_4.seVolume;
        label_12:
        float val_5 = mem[1152921511940942712].maxValue;
        val_5 = val_10 * val_5;
        mem[1152921511940942712].onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  val_1, method:  System.Void SettingsDialogManager.<>c__DisplayClass12_0::<InitializeVolumeSlider>b__0(float volume)));
    }
    private void ChangedVibrationToggle(bool value)
    {
        if(value == false)
        {
                return;
        }
        
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationOnce();
    }
    public void OnOpenLanguage()
    {
        this.settingsPanel.SetActive(value:  false);
        this.languagePanel.SetActive(value:  true);
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  this, method:  System.Void SettingsDialogManager::<OnOpenLanguage>b__14_0()));
    }
    public void OnCloseLanguage()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
    }
    public void OnOpenTwitter()
    {
    
    }
    public void OnOpenLine()
    {
    
    }
    public void OnOpenFacebook()
    {
    
    }
    public void OnHide()
    {
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction();
    }
    protected override void Hide()
    {
        this.Hide();
        this.OnHided();
    }
    public void OnHided()
    {
        bool val_8;
        var val_9;
        System.Action val_11;
        SingletonMonoBehaviour<SoundManager>.Instance.SaveVolumeBGM(volume:  val_1.bgmVolume);
        SingletonMonoBehaviour<SoundManager>.Instance.SaveVolumeSE(volume:  val_2.seVolume);
        val_8 = this.vibrationToggle.isOn;
        SingletonMonoBehaviour<VibrationManager>.Instance.SaveEnable(enable:  val_8);
        val_9 = null;
        val_9 = null;
        val_11 = SettingsDialogManager.<>c.<>9__21_0;
        if(val_11 == null)
        {
                System.Action val_6 = null;
            val_11 = val_6;
            val_6 = new System.Action(object:  SettingsDialogManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SettingsDialogManager.<>c::<OnHided>b__21_0());
            SettingsDialogManager.<>c.<>9__21_0 = val_11;
        }
        
        UnityEngine.Coroutine val_7 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  val_6);
    }
    public static void ShowDialog(System.Action callback)
    {
        .callback = callback;
        DialogManager.ShowDialog(showAction:  new System.Action(object:  new SettingsDialogManager.<>c__DisplayClass22_0(), method:  System.Void SettingsDialogManager.<>c__DisplayClass22_0::<ShowDialog>b__0()), category:  0);
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        var val_4;
        if(pauseStatus == false)
        {
                return;
        }
        
        if(this.isShopping != false)
        {
                return;
        }
        
        SingletonMonoBehaviour<BackButtonManager>.Instance.DestroyOneAction();
        DialogManager.HideDialog();
        val_4 = null;
        val_4 = null;
        LocalCacheManager.Load<System.Action>(tag:  SettingsDialogManager.CallbackTag).Invoke();
        SingletonMonoBehaviour<TransitionManager>.Instance.UnloadScene(scene:  11);
    }
    public void OnBeginShopping()
    {
        this.isShopping = true;
    }
    public void OnEndShopping()
    {
        this.isShopping = false;
    }
    public SettingsDialogManager()
    {
    
    }
    private static SettingsDialogManager()
    {
        SettingsDialogManager.CallbackTag = "SettingsDialogCallback";
    }
    private void <OnOpenLanguage>b__14_0()
    {
        this.settingsPanel.SetActive(value:  true);
        this.languagePanel.SetActive(value:  false);
    }

}
