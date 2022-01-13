using UnityEngine;
public class JoypacAdManager : MonoBehaviour
{
    // Fields
    private static bool _noAdsAndNoRewardVideo;
    private bool boolShowRemoveAdPopFlg;
    private const int RETRY_TIMES_COUNT = 2;
    private int m_bannerRetryTimes;
    private int m_intersRetryTimes;
    private int m_videoRetryTimes;
    private int m_nativeRetryTimes;
    private int boolInterReady;
    private int boolInterReadyCheck;
    private bool m_noAds;
    private bool m_initialized;
    private IJoypacAdInterface joypacAds;
    private static JoypacAdManager s_instance;
    public static bool canShowBannerView;
    private int[] callbackFlg;
    
    // Properties
    public static bool noAdsAndNoRewardVideo { get; }
    private bool showInterTip { get; }
    private static int showInterCount { get; set; }
    private static int showPopCount { get; set; }
    private static int FirstShowPop { get; set; }
    private int IntersitialTimeCD { get; }
    private int IntersitialCountCD1 { get; }
    private int IntersitialCountCD2 { get; }
    private int IntersitialPatienceTime { get; }
    public static JoypacAdManager Instance { get; }
    public bool IsReadyBanner { get; }
    
    // Methods
    public static bool get_noAdsAndNoRewardVideo()
    {
        null = null;
        return (bool)JoypacAdManager.RETRY_TIMES_COUNT;
    }
    private bool get_showInterTip()
    {
        null = null;
        return JoypacUtils.On(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.InterTip, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_100});
    }
    private static int get_showInterCount()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  "showInterCount", defaultValue:  0);
    }
    private static void set_showInterCount(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "showInterCount", value:  value);
    }
    private static int get_showPopCount()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  "showPopCount", defaultValue:  0);
    }
    private static void set_showPopCount(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "showPopCount", value:  value);
    }
    private static int get_FirstShowPop()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  "FirstShowPop", defaultValue:  1);
    }
    private static void set_FirstShowPop(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "FirstShowPop", value:  value);
    }
    private int get_IntersitialTimeCD()
    {
        null = null;
        return JoypacUtils.OnlineParametersInt(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.Intersitial_CD, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_10});
    }
    private int get_IntersitialCountCD1()
    {
        null = null;
        return JoypacUtils.OnlineParametersInt(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.Intersitial_ClickCountCD_BeforeRate, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_20});
    }
    private int get_IntersitialCountCD2()
    {
        null = null;
        return JoypacUtils.OnlineParametersInt(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.Intersitial_ClickCountCD_AfterRate, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_30});
    }
    private int get_IntersitialPatienceTime()
    {
        null = null;
        return JoypacUtils.OnlineParametersInt(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.Intersitial_PatienceTime, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_40});
    }
    public static JoypacAdManager get_Instance()
    {
        var val_6;
        JoypacAdManager val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = JoypacAdManager.s_instance;
        if(val_7 == 0)
        {
                val_8 = null;
            val_7 = UnityEngine.Object.FindObjectOfType<JoypacAdManager>();
            val_8 = null;
            JoypacAdManager.s_instance = val_7;
            if(JoypacAdManager.s_instance == 0)
        {
                UnityEngine.GameObject val_4 = null;
            val_7 = val_4;
            val_4 = new UnityEngine.GameObject();
            val_9 = null;
            val_9 = null;
            JoypacAdManager.s_instance = val_4.AddComponent<JoypacAdManager>();
            UnityEngine.Object.DontDestroyOnLoad(target:  val_4);
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "A [JoypacAdManager] object already exists in this scene - you should never have more than one per scene!");
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        return (JoypacAdManager)JoypacAdManager.s_instance;
    }
    public void Init()
    {
        LogTool.DebugLog(log:  "!!!!init", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "Init");
        if(this.m_initialized == true)
        {
                return;
        }
        
        this.m_initialized = true;
        int val_1 = CryptoPrefs.GetInt(key:  "Joypac_LAUNCH_COUNT", defaultValue:  0);
        UnityEngine.Debug.Log(message:  "!!! launchCount = "("!!! launchCount = ") + val_1);
        if(val_1 <= 3)
        {
                CryptoPrefs.SetInt(key:  "Joypac_LAUNCH_COUNT", val:  val_1 + 1);
        }
        
        Check2DaysLogin();
        JoypacUtils.SaveFirstLoginTime();
        this.m_noAds = ((CryptoPrefs.GetInt(key:  "Joypac_REMOVE_ADS", defaultValue:  0)) != 0) ? 1 : 0;
        CryptoPrefs.Save();
        JoypacSDKAdapter val_6 = JoypacSDKAdapter.Instance;
        this.joypacAds = val_6;
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_6.Init();
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.LoadAds());
    }
    public void RefreshVIPStatus()
    {
        int val_1 = CryptoPrefs.GetInt(key:  "Joypac_REMOVE_ADS", defaultValue:  0);
        this.m_noAds = (val_1 != 0) ? 1 : 0;
        if(val_1 == 0)
        {
                return;
        }
        
        this.RemoveBanner();
    }
    private System.Collections.IEnumerator LoadAds()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new JoypacAdManager.<LoadAds>d__38();
    }
    public void HideSplashAd()
    {
    
    }
    public void ShowBanner()
    {
        var val_3;
        var val_4;
        string val_5;
        string val_6;
        var val_8;
        string val_10;
        val_3 = this;
        val_4 = 1152921504944599040;
        val_5 = "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs";
        val_6 = "ShowBanner";
        LogTool.DebugLog(log:  "ShowBanner()", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowBanner");
        if(this.m_noAds == false)
        {
            goto label_3;
        }
        
        LogTool.DebugLog(log:  "Joypac: VIP don\'t show banner", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowBanner");
        var val_4 = 0;
        val_4 = val_4 + 1;
        goto label_10;
        label_3:
        val_8 = null;
        val_8 = null;
        if(JoypacAdManager.canShowBannerView == false)
        {
            goto label_13;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        goto label_18;
        label_10:
        val_3 = ???;
        val_5 = ???;
        val_6 = ???;
        val_4 = ???;
        this.joypacAds.RemoveBanner();
        return;
        label_13:
        val_10 = "Joypac: this view cannot show banner";
        goto label_21;
        label_18:
        if(this.joypacAds.IsReadyBanner() == false)
        {
            goto label_22;
        }
        
        LogTool.DebugLog(log:  "Joypac: Show banner", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowBanner");
        var val_6 = 0;
        val_6 = val_6 + 1;
        goto label_10;
        label_22:
        this.LoadBanner();
        val_10 = "joypacAds.IsReadyBanner() = false ";
        label_21:
        LogTool.DebugLog(log:  val_10, color:  0, path:  val_5, name:  val_6);
    }
    public void HideBanner()
    {
        LogTool.DebugLog(log:  "HideBanner", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "HideBanner");
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.joypacAds.HideBanner();
    }
    public void RemoveBanner()
    {
        LogTool.DebugLog(log:  "RemoveBanner", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "RemoveBanner");
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.joypacAds.RemoveBanner();
    }
    public void ShowNative(float x, float y, float w, float h)
    {
    
    }
    public void HideNative(bool _clean)
    {
        LogTool.DebugLog(log:  "隐藏native", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "HideNative");
    }
    public void ShowInterstitial(System.Action<JoypacIntersitialStatus> callback, string interId)
    {
        string val_20;
        var val_21;
        var val_22;
        object val_23;
        var val_24;
        var val_25;
        val_20 = interId;
        JoypacAdManager.<>c__DisplayClass46_0 val_1 = new JoypacAdManager.<>c__DisplayClass46_0();
        if(val_1 != null)
        {
                val_21 = val_1;
            .interId = val_20;
            val_22 = 1152921511772900784;
            mem[1152921511772900768] = this;
            mem[1152921511772900776] = callback;
        }
        else
        {
                mem[16] = this;
            val_22 = 24;
            mem[24] = callback;
            val_21 = 32;
            mem[32] = val_20;
            val_20 = mem[32];
        }
        
        char[] val_2 = new char[1];
        val_2[0] = 'V';
        val_23 = val_20.Split(separator:  val_2);
        .eventstr = "";
        if(val_3.Length >= 2)
        {
                .eventstr = "_" + val_23[((-4294967296) + ((val_3.Length) << 32)) >> 29](val_23[((-4294967296) + ((val_3.Length) << 32)) >> 29]);
        }
        
        if(this.m_noAds != false)
        {
                LogTool.DebugLog(log:  "Joypac: VIP don\'t show interstitial", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterstitial");
            if(val_22 == 0)
        {
                return;
        }
        
            val_22.Invoke(obj:  1);
            return;
        }
        
        LogTool.DebugLog(log:  "Joypac: interId = "("Joypac: interId = ") + mem[32], color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterstitial");
        LogTool.DebugLog(log:  "Joypac: Show Interstitial interId="("Joypac: Show Interstitial interId=") + mem[32], color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterstitial");
        if((this.IsReadyIntersitial(interId:  mem[32])) == false)
        {
            goto label_15;
        }
        
        if(this.CheckBoolShowRemoveAdPop() == false)
        {
            goto label_16;
        }
        
        LogTool.DebugLog(log:  ":展示去广告弹窗", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterstitial");
        val_24 = null;
        int val_10 = JoypacAdManager.showPopCount;
        val_10 = val_10 + 1;
        JoypacAdManager.showPopCount = val_10;
        RemoveAdsPopupView.Show(_buyAdsClickCallback:  0, _noBuyAdsClickCallback:  new System.Action(object:  val_1, method:  System.Void JoypacAdManager.<>c__DisplayClass46_0::<ShowInterstitial>b__0()), _buyAdsSuccessCallback:  new System.Action(object:  val_1, method:  System.Void JoypacAdManager.<>c__DisplayClass46_0::<ShowInterstitial>b__1()));
        return;
        label_15:
        if(mem[24] != 0)
        {
                mem[24].Invoke(obj:  1);
        }
        
        if((this.boolInterReady != 0) && (this.boolInterReadyCheck != 0))
        {
                object[] val_13 = new object[4];
            val_13[0] = "插屏isready=false 没有重新加载 因为之前加载成功没有用过 boolInterReady=";
            val_21 = 1152921504620851200;
            val_13[1] = this.boolInterReady;
            val_13[2] = "ReadyCheck=";
            val_23 = this.boolInterReadyCheck;
            val_13[3] = val_23;
            LogTool.DebugLog(log:  +val_13, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterstitial");
            int val_21 = this.boolInterReadyCheck;
            val_21 = val_21 - 1;
            this.boolInterReadyCheck = val_21;
            return;
        }
        
        object[] val_15 = new object[4];
        val_15[0] = "插屏isready=false 重新加载 boolInterReady=";
        val_15[1] = this.boolInterReady;
        val_15[2] = "ReadyCheck=";
        val_23 = this.boolInterReadyCheck;
        val_15[3] = val_23;
        LogTool.DebugLog(log:  +val_15, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterstitial");
        this.boolInterReadyCheck = 2;
        this.LoadInterstitial(interId:  mem[32]);
        return;
        label_16:
        val_25 = null;
        int val_17 = JoypacAdManager.showInterCount;
        val_17 = val_17 + 1;
        JoypacAdManager.showInterCount = val_17;
        if(val_17.showInterTip != false)
        {
                InterTipPopupView.Show(_closeCallback:  new System.Action(object:  val_1, method:  System.Void JoypacAdManager.<>c__DisplayClass46_0::<ShowInterstitial>b__2()));
            return;
        }
        
        this.ShowInterOnly(callback:  mem[24], interId:  mem[32], eventstr:  "ShowInterstitial");
    }
    private void ShowInterOnly(System.Action<JoypacIntersitialStatus> callback, string interId, string eventstr)
    {
        string val_5;
        JoypacAdManager.<>c__DisplayClass47_0 val_1 = new JoypacAdManager.<>c__DisplayClass47_0();
        if(val_1 != null)
        {
                val_5 = val_1;
            .interId = interId;
            mem[1152921511773162592] = this;
            mem[1152921511773162600] = callback;
            this.boolInterReady = 0;
        }
        else
        {
                mem[16] = this;
            mem[24] = callback;
            val_5 = 32;
            mem[32] = interId;
            this.boolInterReady = 0;
        }
        
        LogTool.DebugLog(log:  "插屏可以播放isready=true interId="("插屏可以播放isready=true interId=") + val_5, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterOnly");
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.joypacAds.ShowIntersitial(_callback:  new System.Action<JoypacIntersitialStatus>(object:  val_1, method:  System.Void JoypacAdManager.<>c__DisplayClass47_0::<ShowInterOnly>b__0(JoypacIntersitialStatus status)), interId:  mem[32]);
    }
    public void ShowVideo(System.Action<JoypacVideoStatus> _callback, JoypacVideoPlace _videoPlace)
    {
        var val_7;
        var val_8;
        var val_11;
        JoypacVideoStatus val_12;
        JoypacAdManager.<>c__DisplayClass49_0 val_1 = new JoypacAdManager.<>c__DisplayClass49_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        ._callback = _callback;
        if(this.m_noAds != false)
        {
                val_7 = null;
            if(JoypacAdManager.noAdsAndNoRewardVideo != false)
        {
                if(((JoypacAdManager.<>c__DisplayClass49_0)[1152921511773442384]._callback) != null)
        {
                (JoypacAdManager.<>c__DisplayClass49_0)[1152921511773442384]._callback.Invoke(obj:  2);
        }
        
            LogTool.DebugLog(log:  "joypac: vip give success ", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowVideo");
            return;
        }
        
        }
        
        JoypacAnalyticsManager.DesignEvent(_logType:  48, sort:  "Ad", type:  "click", position:  _videoPlace.ClickPlace, onlyFirst:  false, extra:  "");
        val_8 = 0;
        goto label_12;
        label_18:
        this.callbackFlg[0] = 1;
        UnityEngine.Debug.Log(message:  "JoypacVideo:重置Flg");
        val_8 = 1;
        label_12:
        if(val_8 < this.callbackFlg.Length)
        {
            goto label_18;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        if(this.joypacAds.IsReadyVideo() == false)
        {
            goto label_24;
        }
        
        LogTool.DebugLog(log:  "joypacAds.IsReadyVideo ()", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowVideo");
        var val_9 = 0;
        val_9 = val_9 + 1;
        goto label_31;
        label_24:
        if(UnityEngine.Application.internetReachability == 0)
        {
            goto label_32;
        }
        
        LogTool.DebugLog(log:  "Joypac: Don\'t show Video for hasAdReady is NO", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowVideo");
        if(((JoypacAdManager.<>c__DisplayClass49_0)[1152921511773442384]._callback) == null)
        {
            goto label_41;
        }
        
        val_11 = 1152921511773263600;
        val_12 = 1;
        goto label_37;
        label_32:
        UnityEngine.Debug.Log(message:  "Joypac:  NetworkReachability.NotReachable");
        if(((JoypacAdManager.<>c__DisplayClass49_0)[1152921511773442384]._callback) == null)
        {
            goto label_41;
        }
        
        val_11 = 1152921511773263600;
        val_12 = 0;
        label_37:
        (JoypacAdManager.<>c__DisplayClass49_0)[1152921511773442384]._callback.Invoke(obj:  val_12);
        label_41:
        this.LoadVideo();
        return;
        label_31:
        this.joypacAds.ShowVideo(eventPosition:  _videoPlace.ShowPlace, _callback:  new System.Action<JoypacVideoStatus>(object:  val_1, method:  System.Void JoypacAdManager.<>c__DisplayClass49_0::<ShowVideo>b__0(JoypacVideoStatus status)));
    }
    public bool IsReadyIntersitial(string interId)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.joypacAds.IsReadyIntersitial(interId:  interId);
    }
    public bool get_IsReadyBanner()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.joypacAds.IsReadyBanner();
    }
    public void LoadBanner()
    {
        IntPtr val_4;
        LogTool.DebugLog(log:  "Joypac: LoadBanner", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadBanner");
        if(this.m_noAds == false)
        {
            goto label_3;
        }
        
        label_14:
        LogTool.DebugLog(log:  "Joypac: VIP don\'t load banner", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadBanner");
        return;
        label_3:
        if(UnityEngine.Application.internetReachability == 0)
        {
            goto label_14;
        }
        
        System.Action<System.Boolean> val_2 = null;
        val_4 = System.Void JoypacAdManager::<LoadBanner>b__53_0(bool success);
        val_2 = new System.Action<System.Boolean>(object:  this, method:  val_4);
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = 1;
        this.joypacAds.LoadBanner(_callback:  val_2);
    }
    public void LoadInterstitial(string interId)
    {
        JoypacAdManager.<>c__DisplayClass54_0 val_1 = new JoypacAdManager.<>c__DisplayClass54_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .interId = interId;
        if(this.m_noAds == false)
        {
            goto label_3;
        }
        
        label_14:
        LogTool.DebugLog(log:  "Joypac: VIP don\'t Load Interstitial ", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadInterstitial");
        return;
        label_3:
        if(UnityEngine.Application.internetReachability == 0)
        {
            goto label_14;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.joypacAds.LoadInterstitial(_callback:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void JoypacAdManager.<>c__DisplayClass54_0::<LoadInterstitial>b__0(bool success)), interId:  (JoypacAdManager.<>c__DisplayClass54_0)[1152921511774077904].interId);
    }
    private void LoadVideo()
    {
        var val_5;
        string val_6;
        IntPtr val_7;
        if(this.m_noAds == false)
        {
            goto label_4;
        }
        
        val_5 = null;
        if(JoypacAdManager.noAdsAndNoRewardVideo == false)
        {
            goto label_4;
        }
        
        val_6 = "Joypac: VIP don\'t Load Video ";
        goto label_7;
        label_4:
        if(UnityEngine.Application.internetReachability == 0)
        {
            goto label_8;
        }
        
        System.Action<System.Boolean> val_3 = null;
        val_7 = System.Void JoypacAdManager::<LoadVideo>b__55_0(bool success);
        val_3 = new System.Action<System.Boolean>(object:  this, method:  val_7);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_7 = 3;
        goto label_13;
        label_8:
        val_6 = "Joypac: Don\'t load video for NetworkReachability.NotReachable";
        label_7:
        LogTool.DebugLog(log:  val_6, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadVideo");
        return;
        label_13:
        this.joypacAds.LoadVideo(_callback:  val_3);
    }
    public void LoadNative(float width, float height)
    {
    
    }
    private void ReloadVideo()
    {
        LogTool.DebugLog(log:  "Joypac: ReLoadVideo, times : "("Joypac: ReLoadVideo, times : ") + this.m_videoRetryTimes, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ReloadVideo");
        int val_2 = this.m_videoRetryTimes;
        val_2 = val_2 - 1;
        if()
        {
                this.m_videoRetryTimes = val_2;
            this.LoadVideo();
            return;
        }
        
        this.m_videoRetryTimes = 2;
    }
    private void ReloadInterstitial(string interId)
    {
        LogTool.DebugLog(log:  "Joypac: ReLoadInterstitial, times:"("Joypac: ReLoadInterstitial, times:") + this.m_intersRetryTimes, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ReloadInterstitial");
        int val_2 = this.m_intersRetryTimes;
        val_2 = val_2 - 1;
        if()
        {
                this.m_intersRetryTimes = val_2;
            this.LoadInterstitial(interId:  interId);
            return;
        }
        
        this.m_intersRetryTimes = 2;
    }
    private bool IncreateVideoAndIntersitialShowCount(bool _video)
    {
        var val_11;
        string val_1 = (_video != true) ? "Joypac_VideoShowCount" : "Joypac_IntersitialShowCount";
        CryptoPrefs.SetInt(key:  val_1, val:  (CryptoPrefs.GetInt(key:  val_1, defaultValue:  0)) + 1);
        CryptoPrefs.Save();
        int val_11 = CryptoPrefs.GetInt(key:  "Joypac_IntersitialShowCount", defaultValue:  0);
        val_11 = null;
        val_11 = null;
        int val_6 = JoypacUtils.OnlineParametersInt(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.Advrecovery, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_50});
        object[] val_7 = new object[6];
        val_7[0] = "[";
        val_7[1] = this.GetType();
        val_7[2] = "]激励视频+插屏次数：";
        val_11 = val_11 + (CryptoPrefs.GetInt(key:  "Joypac_VideoShowCount", defaultValue:  0));
        val_7[3] = val_11;
        val_7[4] = ", onlineCount : ";
        val_7[5] = val_6;
        LogTool.DebugLog(log:  +val_7, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "IncreateVideoAndIntersitialShowCount");
        return (bool)(val_11 >= val_6) ? 1 : 0;
    }
    private bool CheckBoolShowRemoveAdPop()
    {
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = this;
        if(this.boolShowRemoveAdPopFlg == false)
        {
            goto label_1;
        }
        
        val_15 = null;
        if(JoypacAdManager.FirstShowPop != 1)
        {
            goto label_4;
        }
        
        JoypacAdManager.FirstShowPop = 0;
        label_35:
        LogTool.DebugLog(log:  ": 第一次弹出视频展示去广告弹窗！", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "CheckBoolShowRemoveAdPop");
        val_16 = 1;
        return (bool)val_16;
        label_4:
        int val_2 = JoypacAdManager.showInterCount;
        val_17 = null;
        val_17 = null;
        int val_3 = JoypacUtils.OnlineParametersIntByJoypacSDK(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.showInterPopN, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_F0});
        int val_4 = val_2 / val_3;
        val_4 = val_2 - (val_4 * val_3);
        if(val_4 != 0)
        {
            goto label_17;
        }
        
        val_18 = null;
        if(JoypacAdManager.showPopCount > 2)
        {
            goto label_17;
        }
        
        object[] val_6 = new object[4];
        val_6[0] = ": 次数对展示去广告弹窗！showInterCount=";
        val_19 = null;
        val_6[1] = JoypacAdManager.showInterCount;
        val_6[2] = " showPopCount=";
        val_6[3] = JoypacAdManager.showPopCount;
        string val_9 = +val_6;
        goto label_35;
        label_17:
        object[] val_10 = new object[4];
        val_10[0] = ": 次数不对！不展示去广告弹窗！showInterCount=";
        val_20 = null;
        val_10[1] = JoypacAdManager.showInterCount;
        val_10[2] = " showPopCount=";
        val_10[3] = JoypacAdManager.showPopCount;
        val_14 = +val_10;
        LogTool.DebugLog(log:  val_14, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "CheckBoolShowRemoveAdPop");
        label_1:
        val_16 = 0;
        return (bool)val_16;
    }
    private void Check2DaysLogin()
    {
        string val_16;
        int val_1 = CryptoPrefs.GetInt(key:  "Joypac_Login_Count", defaultValue:  0);
        System.DateTime val_2 = System.DateTime.Today;
        val_16 = val_2.dateData.DayOfYear.ToString();
        LogTool.DebugLog(log:  "todayKey : "("todayKey : ") + val_16, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "Check2DaysLogin");
        if((CryptoPrefs.GetInt(key:  val_16, defaultValue:  0)) != 0)
        {
                return;
        }
        
        LogTool.DebugLog(log:  "今天为首次登陆", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "Check2DaysLogin");
        JoypacUtils.CrossTodayPopFlg = 0;
        CryptoPrefs.SetInt(key:  val_16, val:  1);
        System.DateTime val_7 = System.DateTime.Today;
        val_16 = val_7.dateData.DayOfYear - 1.ToString();
        LogTool.DebugLog(log:  "lastDay : "("lastDay : ") + val_16, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "Check2DaysLogin");
        if(val_1 == 1)
        {
                if((CryptoPrefs.GetInt(key:  val_16, defaultValue:  0)) == 1)
        {
                LogTool.DebugLog(log:  "次日启动：之前没有上报过，符合条件。可以上报", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "Check2DaysLogin");
            JoypacAnalyticsManager val_13 = JoypacAnalyticsManager.Instance;
            JoypacAnalyticsManager.Instance.AdjustLogEventToken(_eventToken:  "b628o3");
        }
        
        }
        
        LogTool.DebugLog(log:  "本地保存登陆天数+1", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "Check2DaysLogin");
        CryptoPrefs.SetInt(key:  "Joypac_Login_Count", val:  val_1 + 1);
    }
    private void StopGame()
    {
        UnityEngine.AudioListener.pause = true;
    }
    private void ContinueGame()
    {
        UnityEngine.AudioListener.pause = false;
    }
    public JoypacAdManager()
    {
        this.m_bannerRetryTimes = 2;
        this.m_intersRetryTimes = 0;
        this.m_videoRetryTimes = 2;
        this.m_nativeRetryTimes = 0;
        this.boolInterReadyCheck = 2;
        int val_5 = (System.Linq.Enumerable.Max(source:  System.Linq.Enumerable.Cast<System.Int32>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))))) + 1;
        this.callbackFlg = new int[0];
    }
    private static JoypacAdManager()
    {
        JoypacAdManager.RETRY_TIMES_COUNT = 0;
        JoypacAdManager.canShowBannerView = true;
    }
    private void <LoadBanner>b__53_0(bool success)
    {
        if(success != false)
        {
                LogTool.DebugLog(log:  "in joypacAdManager, loadBanner. success", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadBanner");
            this.m_bannerRetryTimes = 2;
            return;
        }
        
        LogTool.DebugLog(log:  "已关闭重新加载", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadBanner");
    }
    private void <LoadVideo>b__55_0(bool success)
    {
        if(success != false)
        {
                this.m_videoRetryTimes = 2;
            return;
        }
        
        LogTool.DebugLog(log:  "已关闭重新加载", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadVideo");
    }

}
