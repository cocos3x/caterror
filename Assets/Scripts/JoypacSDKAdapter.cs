using UnityEngine;
public class JoypacSDKAdapter : IJoypacAdInterface
{
    // Fields
    private bool m_nativeShowed;
    private bool m_bannerHasShowed;
    private bool m_bannerLoaded;
    private System.Action<bool> m_bannerLoadCallback;
    private System.Action<bool> m_intersitialLoadCallback;
    private System.Action<bool> m_videoLoadCallback;
    private System.Action<JoypacVideoStatus> m_videoShowCallback;
    private System.Action<JoypacIntersitialStatus> m_intersitialShowCallback;
    private System.Action<bool> m_nativeLoadCallback;
    private JoyPacCurrentcyAdSingle _currAdSigle;
    private JoyPacCurrentcyAdSingle _currAdSigle2;
    private static JoypacSDKAdapter s_instance;
    
    // Properties
    public static JoypacSDKAdapter Instance { get; }
    
    // Methods
    public static JoypacSDKAdapter get_Instance()
    {
        JoypacSDKAdapter val_2;
        JoypacSDKAdapter val_3 = JoypacSDKAdapter.s_instance;
        if(val_3 != null)
        {
                return val_3;
        }
        
        JoypacSDKAdapter val_1 = null;
        val_2 = val_1;
        val_1 = new JoypacSDKAdapter();
        JoypacSDKAdapter.s_instance = val_2;
        val_3 = JoypacSDKAdapter.s_instance;
        return val_3;
    }
    public void Init()
    {
        this.joypacAndroidInit();
    }
    public void joypacEventLog(string event_sort, string event_type, string event_position, string event_extra)
    {
        if(this._currAdSigle != null)
        {
                this._currAdSigle.joypacEventLog(eventSort:  event_sort, eventType:  event_type, eventPosition:  event_position, eventExtra:  event_extra);
            return;
        }
        
        UnityEngine.Debug.Log(message:  "Error:_currAdSigle==null 无法上报打点");
    }
    public void ReceiveAdJustData(string json)
    {
        if(this._currAdSigle != null)
        {
                this._currAdSigle.ReceiveAdJustData(adJustJson:  json);
            return;
        }
        
        UnityEngine.Debug.Log(message:  "Error:_currAdSigle==null 无法ReceiveAdJustData");
    }
    private void joypacAndroidInit()
    {
        UnityEngine.Debug.LogError(message:  "android init");
        this._currAdSigle = new JoyPacCurrentcyAdSingle();
        JoyPacAdverManager.add_onSetBannerListener_onAdLoaded(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetBannerListener_onAdLoaded(string info)));
        JoyPacAdverManager.add_onSetBannerListener_onAdFailedToLoad(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetBannerListener_onAdFailedToLoad(string info)));
        JoyPacAdverManager.add_onSetInterstitialListener_onAdLoaded(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetInterstitialListener_onAdLoaded(string info)));
        JoyPacAdverManager.add_onSetInterstitialListener_onAdClosed(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetInterstitialListener_onAdClosed(string info)));
        JoyPacAdverManager.add_onSetInterstitialListener_onAdOpened(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetInterstitialListener_onAdOpened(string info)));
        JoyPacAdverManager.add_onSetInterstitialListener_onAdFailedToLoad(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetInterstitialListener_onAdFailedToLoad(string info)));
        JoyPacAdverManager.add_onSetRewardListener_onRewardedVideoAdLoaded(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetRewardListener_onRewardedVideoAdLoaded(string info)));
        JoyPacAdverManager.add_onSetRewardListener_onRewarded(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetRewardListener_onRewarded(string info)));
        JoyPacAdverManager.add_onSetRewardListener_onRewardedVideoAdClosed(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetRewardListener_onRewardedVideoAdClosed(string info)));
        JoyPacAdverManager.add_onSetRewardListener_onRewardedVideoAdFailedToLoad(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetRewardListener_onRewardedVideoAdFailedToLoad(string info)));
        JoyPacAdverManager.add_onSetNativeListener_onAdLoaded(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetNativeListener_onNativeAdLoaded(string info)));
        JoyPacAdverManager.add_onSetNativeListener_onAdFailedToLoad(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetNativeListener_onNativeLoadFailed(string info)));
        JoyPacAdverManager.add_onSetNativeListener_onShowSuccess(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onSetNativeListener_onNativeonShowSuccess(string info)));
        JoyPacAdverManager.add_onReceiveExtraData(value:  new System.Action<System.String>(object:  this, method:  System.Void JoypacSDKAdapter::onReceiveExtraData(string json)));
        this._currAdSigle.init(joypacAppID:  "4f6e3e1460", userType:  "0", joypacUnitName:  "");
        this.initBanner();
        this.initInterstitial();
        this.initReward();
        this.initNative();
        UnityEngine.Debug.LogError(message:  "android end");
    }
    private void initBanner()
    {
        this._currAdSigle.initBanner(joypacUnitName:  "hidegpBN", position:  0);
        this._currAdSigle.setBannerListener(joypacUnitName:  "hidegpBN");
    }
    private void initInterstitial()
    {
        this._currAdSigle.initInterstitial(joypacUnitName:  "hidegpIV");
        this._currAdSigle.setInterstitialListener(joypacUnitName:  "hidegpIV");
    }
    private void initReward()
    {
        this._currAdSigle.initReward(joypacUnitName:  "hidegpRV");
        this._currAdSigle.setRewardListener(joypacUnitName:  "hidegpRV");
    }
    private void initNative()
    {
        this._currAdSigle.initNative(joypacUnitName:  "hidegpNA");
        this._currAdSigle.setNativeListener(joypacUnitName:  "hidegpNA");
    }
    public bool IsReadyBanner()
    {
        return (bool)this.m_bannerLoaded;
    }
    public void LoadBanner(System.Action<bool> _callback)
    {
        this.m_bannerLoadCallback = _callback;
        this._currAdSigle.loadBanner(direction:  0, joypacUnitName:  "hidegpBN", postion:  "0");
    }
    public void ShowBanner()
    {
        LogTool.DebugLog(log:  "in joypacUparpuAdapter, showBanner.", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "ShowBanner");
        this._currAdSigle.showBanner(joypacUnitName:  "hidegpBN");
        this.m_bannerHasShowed = true;
    }
    public void HideBanner()
    {
        this._currAdSigle.hideBanner();
        this.m_bannerHasShowed = false;
    }
    public void RemoveBanner()
    {
        this._currAdSigle.hideBanner();
        this.m_bannerHasShowed = false;
    }
    public bool IsReadyIntersitial(string interId)
    {
        if(this._currAdSigle != null)
        {
                return this._currAdSigle.isReadyInterstitial(joypacUnitName:  interId);
        }
        
        return this._currAdSigle.isReadyInterstitial(joypacUnitName:  interId);
    }
    public void LoadInterstitial(System.Action<bool> _callback, string interId)
    {
        this.m_intersitialLoadCallback = _callback;
        UnityEngine.Debug.Log(message:  "joypac load Interstitial");
        this._currAdSigle.loadInterstitial(joypacUnitName:  "hidegpIV");
    }
    public void ShowIntersitial(System.Action<JoypacIntersitialStatus> _callback, string interId)
    {
        this.m_intersitialShowCallback = _callback;
        this._currAdSigle.showInterstitial(joypacUnitName:  interId);
    }
    public void ShowVideo(string eventPosition, System.Action<JoypacVideoStatus> _callback)
    {
        this.m_videoShowCallback = _callback;
        UnityEngine.Debug.Log(message:  "joypac showReward");
        this._currAdSigle.showReward(joypacUnitName:  "hidegpRV", eventPosition:  "");
    }
    public bool IsReadyVideo()
    {
        UnityEngine.Debug.Log(message:  "uparpu isReady");
        if(this._currAdSigle != null)
        {
                return this._currAdSigle.isReady(joypacUnitName:  "hidegpRV");
        }
        
        return this._currAdSigle.isReady(joypacUnitName:  "hidegpRV");
    }
    public void LoadVideo(System.Action<bool> _callback)
    {
        this.m_videoLoadCallback = _callback;
        UnityEngine.Debug.Log(message:  "joypac load rewardvideo");
        this._currAdSigle.loadReward(joypacUnitName:  "hidegpRV");
    }
    public void LoadNative(System.Action<bool> _callback, float width, float height)
    {
        this._currAdSigle.loadNative(joypacUnitName:  "hidegpNA");
    }
    public void ShowNative(float x, float y, float w, float h)
    {
        object[] val_1 = new object[8];
        val_1[0] = "shownative  x=";
        val_1[1] = x;
        val_1[2] = " y=";
        val_1[3] = y;
        val_1[4] = " w=";
        val_1[5] = w;
        val_1[6] = " h=";
        val_1[7] = h;
        LogTool.DebugLog(log:  +val_1, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "ShowNative");
        this._currAdSigle.showNative(joypacUnitName:  "hidegpNA", left:  x, top:  y, width:  w, height:  h);
    }
    public void RemoveNative(bool _clean)
    {
        this.m_nativeShowed = false;
        this._currAdSigle.hideNative();
    }
    public bool IsReadyNative()
    {
        if(this._currAdSigle != null)
        {
                return this._currAdSigle.isReadyNative(joypacUnitName:  "hidegpNA");
        }
        
        return this._currAdSigle.isReadyNative(joypacUnitName:  "hidegpNA");
    }
    private void onSetBannerListener_onAdLoaded(string info)
    {
        this.m_bannerLoadCallback.Invoke(obj:  true);
        this.m_bannerLoaded = true;
        UnityEngine.Debug.Log(message:  "onSetBannerListener_onAdLoaded: "("onSetBannerListener_onAdLoaded: ") + info);
    }
    private void onSetBannerListener_onAdFailedToLoad(string info)
    {
        UnityEngine.Debug.Log(message:  "joypac intersitial onSetBannerListener_onAdFailedToLoad: "("joypac intersitial onSetBannerListener_onAdFailedToLoad: ") + info);
        this.m_bannerLoadCallback.Invoke(obj:  false);
    }
    private void onSetInterstitialListener_onAdLoaded(string info)
    {
        UnityEngine.Debug.Log(message:  "joypac intersitial onInterstitialAdLoad");
        if(this.m_intersitialLoadCallback == null)
        {
                return;
        }
        
        this.m_intersitialLoadCallback.Invoke(obj:  true);
    }
    private void onSetInterstitialListener_onAdOpened(string info)
    {
        UnityEngine.Debug.Log(message:  "joypac intersitial  callback onInterstitialAdShow :");
        if(this.m_intersitialShowCallback == null)
        {
                return;
        }
        
        this.m_intersitialShowCallback.Invoke(obj:  0);
    }
    private void onSetInterstitialListener_onAdClosed(string info)
    {
        UnityEngine.Debug.Log(message:  "joypac intersitial onInterstitialAdClose :");
        if(this.m_intersitialShowCallback == null)
        {
                return;
        }
        
        this.m_intersitialShowCallback.Invoke(obj:  2);
    }
    private void onSetInterstitialListener_onAdFailedToLoad(string info)
    {
        UnityEngine.Debug.Log(message:  "joypac intersitial onInterstitialAdLoadFail " + info);
        if(this.m_intersitialLoadCallback == null)
        {
                return;
        }
        
        this.m_intersitialLoadCallback.Invoke(obj:  false);
    }
    private void onSetRewardListener_onRewardedVideoAdLoaded(string info)
    {
        UnityEngine.Debug.Log(message:  "joypac rewardvideo onRewardedVideoAdLoaded------");
        if(this.m_videoLoadCallback == null)
        {
                return;
        }
        
        this.m_videoLoadCallback.Invoke(obj:  true);
    }
    private void onSetRewardListener_onRewarded(string info)
    {
    
    }
    private void onSetRewardListener_onRewardedVideoAdClosed(string info)
    {
        var val_2;
        JoypacVideoStatus val_3;
        UnityEngine.Debug.Log(message:  "joypac rewardvideo onRewardedVideoAdPlayClosed------");
        if(this.m_videoShowCallback != null)
        {
                this.m_videoShowCallback.Invoke(obj:  6);
        }
        
        if((System.String.op_Equality(a:  info, b:  "1")) != false)
        {
                UnityEngine.Debug.Log(message:  "joypac rewardvideo onRewardedVideoAdLoaded success ------");
            if(this.m_videoShowCallback == null)
        {
                return;
        }
        
            val_2 = 1152921511773263600;
            val_3 = 2;
        }
        else
        {
                UnityEngine.Debug.Log(message:  "joypac rewardvideo onRewardedVideoAdLoaded cancel ------");
            if(this.m_videoShowCallback == null)
        {
                return;
        }
        
            val_2 = 1152921511773263600;
            val_3 = 4;
        }
        
        this.m_videoShowCallback.Invoke(obj:  val_3);
    }
    private void onSetRewardListener_onRewardedVideoAdFailedToLoad(string info)
    {
        UnityEngine.Debug.Log(message:  "joypac rewardvideo onRewardedVideoAdLoadFail------"("joypac rewardvideo onRewardedVideoAdLoadFail------") + info);
        if(this.m_videoLoadCallback == null)
        {
                return;
        }
        
        this.m_videoLoadCallback.Invoke(obj:  false);
    }
    private void onSetNativeListener_onNativeAdLoaded(string info)
    {
        LogTool.DebugLog(log:  "joypac native  load succ!", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onSetNativeListener_onNativeAdLoaded");
    }
    private void onSetNativeListener_onNativeLoadFailed(string info)
    {
        LogTool.DebugLog(log:  "joypac native  load failed!", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onSetNativeListener_onNativeLoadFailed");
    }
    private void onSetNativeListener_onNativeonShowSuccess(string info)
    {
        this.m_nativeShowed = true;
    }
    private void onReceiveExtraData(string json)
    {
        JoypacUtils.extraData = json;
    }
    public void initSuccess()
    {
        LogTool.DebugLog(log:  "Joypac: joypac sdk init Success", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "initSuccess");
    }
    public void initFail()
    {
        LogTool.DebugLog(log:  "Joypac: joypac sdk init Fail: ", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "initFail");
    }
    public void onAdAutoRefresh()
    {
    
    }
    public void onAdAutoRefreshFail()
    {
    
    }
    public void onAdClick()
    {
    
    }
    public void onAdClose()
    {
    
    }
    public void onAdImpress()
    {
    
    }
    public void onAdLoad()
    {
        LogTool.DebugLog(log:  "joypac banner load succ", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onAdLoad");
        if(this.m_bannerLoadCallback != null)
        {
                this.m_bannerLoadCallback.Invoke(obj:  true);
        }
        
        this.m_bannerLoaded = true;
    }
    public void onAdLoadFail()
    {
        LogTool.DebugLog(log:  "joypac banner load failed", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onAdLoadFail");
        if(this.m_bannerLoadCallback == null)
        {
                return;
        }
        
        this.m_bannerLoadCallback.Invoke(obj:  false);
    }
    public void onNativeBannerAdLoaded()
    {
        LogTool.DebugLog(log:  "joypac native banner load succ!", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onNativeBannerAdLoaded");
        if(this.m_bannerLoadCallback != null)
        {
                this.m_bannerLoadCallback.Invoke(obj:  true);
        }
        
        this.m_bannerLoaded = true;
    }
    public void onNativeBannerAdLoadFail()
    {
        LogTool.DebugLog(log:  "joypac native banner load failed!", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onNativeBannerAdLoadFail");
        if(this.m_bannerLoadCallback == null)
        {
                return;
        }
        
        this.m_bannerLoadCallback.Invoke(obj:  false);
    }
    public void onNativeBannerAdImpressed()
    {
    
    }
    public void onNativeBannerAdClicked()
    {
    
    }
    public void onNativeBannerAdAutoRefresh()
    {
    
    }
    public void onNativeBannerAdAutoRefreshFailure()
    {
    
    }
    public void onNativeBannerAdCloseButtonClicked()
    {
    
    }
    public void onInterstitialAdClick()
    {
    
    }
    public void onInterstitialAdClose()
    {
        if(this.m_intersitialShowCallback == null)
        {
                return;
        }
        
        this.m_intersitialShowCallback.Invoke(obj:  2);
    }
    public void onInterstitialAdEndPlayingVideo()
    {
    
    }
    public void onInterstitialAdFailedToPlayVideo()
    {
    
    }
    public void onInterstitialAdLoad()
    {
        if(this.m_intersitialLoadCallback == null)
        {
                return;
        }
        
        this.m_intersitialLoadCallback.Invoke(obj:  true);
    }
    public void onInterstitialAdLoadFail()
    {
        if(this.m_intersitialLoadCallback == null)
        {
                return;
        }
        
        this.m_intersitialLoadCallback.Invoke(obj:  false);
    }
    public void onInterstitialAdShow()
    {
        if(this.m_intersitialShowCallback == null)
        {
                return;
        }
        
        this.m_intersitialShowCallback.Invoke(obj:  0);
    }
    public void onInterstitialAdStartPlayingVideo()
    {
    
    }
    public void onInterstitialAdFailedToShow()
    {
        if(this.m_intersitialShowCallback == null)
        {
                return;
        }
        
        this.m_intersitialShowCallback.Invoke(obj:  1);
    }
    public void onRewardedVideoAdLoaded()
    {
        if(this.m_videoLoadCallback == null)
        {
                return;
        }
        
        this.m_videoLoadCallback.Invoke(obj:  true);
    }
    public void onRewardedVideoAdLoadFail()
    {
        if(this.m_videoLoadCallback == null)
        {
                return;
        }
        
        this.m_videoLoadCallback.Invoke(obj:  false);
    }
    public void onRewardedVideoAdPlayStart()
    {
        if(this.m_videoShowCallback == null)
        {
                return;
        }
        
        this.m_videoShowCallback.Invoke(obj:  5);
    }
    public void onRewardedVideoAdPlayEnd()
    {
    
    }
    public void onRewardedVideoAdPlayFail()
    {
        if(this.m_videoShowCallback == null)
        {
                return;
        }
        
        this.m_videoShowCallback.Invoke(obj:  3);
    }
    public void onRewardedVideoAdPlayClosed(bool isReward)
    {
        if(this.m_videoShowCallback == null)
        {
                return;
        }
        
        this.m_videoShowCallback.Invoke(obj:  6);
        if(this.m_videoShowCallback == null)
        {
                return;
        }
        
        this.m_videoShowCallback.Invoke(obj:  (isReward != true) ? 2 : 4);
    }
    public void onRewardedVideoAdPlayReward()
    {
    
    }
    public void onRewardedVideoAdPlayClicked()
    {
    
    }
    public void onNativeAdLoaded()
    {
        LogTool.DebugLog(log:  "joypac native  load succ!", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onNativeAdLoaded");
    }
    public void onNativeAdLoadFail()
    {
        LogTool.DebugLog(log:  "joypac native  load failed!", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/JPSDK/internal/JoypacSDKAdapter.cs", name:  "onNativeAdLoadFail");
    }
    public void onNativeAdImpressed()
    {
        this.m_nativeShowed = true;
        JoypacAnalyticsManager.Instance.AdjustLogEventToken(_eventToken:  "31x51w");
    }
    public void onNativeAdClicked()
    {
    
    }
    public void onNativeAdAutoRefresh()
    {
    
    }
    public void onNativeAdAutoRefreshFailure()
    {
    
    }
    public void onNativeAdCloseButtonClicked()
    {
    
    }
    public void ShowCrossPromotion(string _url, System.Action _callback)
    {
    
    }
    public JoypacSDKAdapter()
    {
    
    }

}
