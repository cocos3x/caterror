using UnityEngine;
public class JoyPacAdverManager : MonoBehaviour
{
    // Fields
    private static System.Action<string> onSetBannerListener_onAdLoaded;
    private static System.Action<string> onSetBannerListener_onAdFailedToLoad;
    private static System.Action<string> onSetBannerListener_onAdOpened;
    private static System.Action<string> onSetBannerListener_onAdLeftApplication;
    private static System.Action<string> onSetBannerListener_onAdClosed;
    private static System.Action<string> onSetBannerListener_onClick;
    private static System.Action<string> onSetBannerListener_onReadyAd;
    private static System.Action<string> onSetBannerListener_onRequestAd;
    private static System.Action<string> onSetBannerListener_onShowFailed;
    private static System.Action<string> onSetBannerListener_onShowSuccess;
    private static System.Action<string> onSetInterstitialListener_onAdLoaded;
    private static System.Action<string> onSetInterstitialListener_onAdFailedToLoad;
    private static System.Action<string> onSetInterstitialListener_onAdOpened;
    private static System.Action<string> onSetInterstitialListener_onAdLeftApplication;
    private static System.Action<string> onSetInterstitialListener_onAdClosed;
    private static System.Action<string> onSetInterstitialListener_onClick;
    private static System.Action<string> onSetInterstitialListener_onRequestAd;
    private static System.Action<string> onSetInterstitialListener_onReadyAd;
    private static System.Action<string> onSetInterstitialListener_onShowFailed;
    private static System.Action<string> onSetInterstitialListener_onShowSuccess;
    private static System.Action<string> onSetNativeListener_onAdLoaded;
    private static System.Action<string> onSetNativeListener_onAdFailedToLoad;
    private static System.Action<string> onSetNativeListener_onAdOpened;
    private static System.Action<string> onSetNativeListener_onAdLeftApplication;
    private static System.Action<string> onSetNativeListener_onAdClosed;
    private static System.Action<string> onSetNativeListener_onClick;
    private static System.Action<string> onSetNativeListener_onRequestAd;
    private static System.Action<string> onSetNativeListener_onReadyAd;
    private static System.Action<string> onSetNativeListener_onShowFailed;
    private static System.Action<string> onSetNativeListener_onShowSuccess;
    private static System.Action<string> onSetRewardListener_onRewarded;
    private static System.Action<string> onSetRewardListener_onRewardedVideoAdLeftApplication;
    private static System.Action<string> onSetRewardListener_onRewardedVideoAdClosed;
    private static System.Action<string> onSetRewardListener_onRewardedVideoAdFailedToLoad;
    private static System.Action<string> onSetRewardListener_onRewardedVideoAdLoaded;
    private static System.Action<string> onSetRewardListener_onRewardedVideoAdOpened;
    private static System.Action<string> onSetRewardListener_onRewardedVideoStarted;
    private static System.Action<string> onSetRewardListener_onRewardedVideoCompleted;
    private static System.Action<string> onSetRewardListener_onRewardedVideoClickAd;
    private static System.Action<string> onSetRewardListener_onRewardedReadyAd;
    private static System.Action<string> onSetRewardListener_onRewardedVideoAdOpenFailed;
    private static System.Action<string> onReceiveSettingData;
    private static System.Action<string> onReceiveExtraData;
    
    // Methods
    public static void add_onSetBannerListener_onAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onAdLoaded, b:  value);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void remove_onSetBannerListener_onAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onAdLoaded, value:  value);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void add_onSetBannerListener_onAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onAdFailedToLoad, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdFailedToLoad != 1152921504943112200);
    
    }
    public static void remove_onSetBannerListener_onAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onAdFailedToLoad, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdFailedToLoad != 1152921504943112200);
    
    }
    public static void add_onSetBannerListener_onAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onAdOpened, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdOpened != 1152921504943112208);
    
    }
    public static void remove_onSetBannerListener_onAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onAdOpened, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdOpened != 1152921504943112208);
    
    }
    public static void add_onSetBannerListener_onAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onAdLeftApplication, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdLeftApplication != 1152921504943112216);
    
    }
    public static void remove_onSetBannerListener_onAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onAdLeftApplication, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdLeftApplication != 1152921504943112216);
    
    }
    public static void add_onSetBannerListener_onAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onAdClosed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdClosed != 1152921504943112224);
    
    }
    public static void remove_onSetBannerListener_onAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onAdClosed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onAdClosed != 1152921504943112224);
    
    }
    public static void add_onSetBannerListener_onClick(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onClick, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onClick != 1152921504943112232);
    
    }
    public static void remove_onSetBannerListener_onClick(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onClick, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onClick != 1152921504943112232);
    
    }
    public static void add_onSetBannerListener_onReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onReadyAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onReadyAd != 1152921504943112240);
    
    }
    public static void remove_onSetBannerListener_onReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onReadyAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onReadyAd != 1152921504943112240);
    
    }
    public static void add_onSetBannerListener_onRequestAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onRequestAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onRequestAd != 1152921504943112248);
    
    }
    public static void remove_onSetBannerListener_onRequestAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onRequestAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onRequestAd != 1152921504943112248);
    
    }
    public static void add_onSetBannerListener_onShowFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onShowFailed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onShowFailed != 1152921504943112256);
    
    }
    public static void remove_onSetBannerListener_onShowFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onShowFailed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onShowFailed != 1152921504943112256);
    
    }
    public static void add_onSetBannerListener_onShowSuccess(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetBannerListener_onShowSuccess, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onShowSuccess != 1152921504943112264);
    
    }
    public static void remove_onSetBannerListener_onShowSuccess(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetBannerListener_onShowSuccess, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetBannerListener_onShowSuccess != 1152921504943112264);
    
    }
    public static void add_onSetInterstitialListener_onAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onAdLoaded, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdLoaded != 1152921504943112272);
    
    }
    public static void remove_onSetInterstitialListener_onAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onAdLoaded, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdLoaded != 1152921504943112272);
    
    }
    public static void add_onSetInterstitialListener_onAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onAdFailedToLoad, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdFailedToLoad != 1152921504943112280);
    
    }
    public static void remove_onSetInterstitialListener_onAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onAdFailedToLoad, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdFailedToLoad != 1152921504943112280);
    
    }
    public static void add_onSetInterstitialListener_onAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onAdOpened, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdOpened != 1152921504943112288);
    
    }
    public static void remove_onSetInterstitialListener_onAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onAdOpened, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdOpened != 1152921504943112288);
    
    }
    public static void add_onSetInterstitialListener_onAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onAdLeftApplication, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdLeftApplication != 1152921504943112296);
    
    }
    public static void remove_onSetInterstitialListener_onAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onAdLeftApplication, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdLeftApplication != 1152921504943112296);
    
    }
    public static void add_onSetInterstitialListener_onAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onAdClosed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdClosed != 1152921504943112304);
    
    }
    public static void remove_onSetInterstitialListener_onAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onAdClosed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onAdClosed != 1152921504943112304);
    
    }
    public static void add_onSetInterstitialListener_onClick(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onClick, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onClick != 1152921504943112312);
    
    }
    public static void remove_onSetInterstitialListener_onClick(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onClick, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onClick != 1152921504943112312);
    
    }
    public static void add_onSetInterstitialListener_onRequestAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onRequestAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onRequestAd != 1152921504943112320);
    
    }
    public static void remove_onSetInterstitialListener_onRequestAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onRequestAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onRequestAd != 1152921504943112320);
    
    }
    public static void add_onSetInterstitialListener_onReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onReadyAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onReadyAd != 1152921504943112328);
    
    }
    public static void remove_onSetInterstitialListener_onReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onReadyAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onReadyAd != 1152921504943112328);
    
    }
    public static void add_onSetInterstitialListener_onShowFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onShowFailed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onShowFailed != 1152921504943112336);
    
    }
    public static void remove_onSetInterstitialListener_onShowFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onShowFailed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onShowFailed != 1152921504943112336);
    
    }
    public static void add_onSetInterstitialListener_onShowSuccess(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetInterstitialListener_onShowSuccess, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onShowSuccess != 1152921504943112344);
    
    }
    public static void remove_onSetInterstitialListener_onShowSuccess(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetInterstitialListener_onShowSuccess, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetInterstitialListener_onShowSuccess != 1152921504943112344);
    
    }
    public static void add_onSetNativeListener_onAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onAdLoaded, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdLoaded != 1152921504943112352);
    
    }
    public static void remove_onSetNativeListener_onAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onAdLoaded, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdLoaded != 1152921504943112352);
    
    }
    public static void add_onSetNativeListener_onAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onAdFailedToLoad, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdFailedToLoad != 1152921504943112360);
    
    }
    public static void remove_onSetNativeListener_onAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onAdFailedToLoad, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdFailedToLoad != 1152921504943112360);
    
    }
    public static void add_onSetNativeListener_onAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onAdOpened, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdOpened != 1152921504943112368);
    
    }
    public static void remove_onSetNativeListener_onAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onAdOpened, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdOpened != 1152921504943112368);
    
    }
    public static void add_onSetNativeListener_onAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onAdLeftApplication, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdLeftApplication != 1152921504943112376);
    
    }
    public static void remove_onSetNativeListener_onAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onAdLeftApplication, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdLeftApplication != 1152921504943112376);
    
    }
    public static void add_onSetNativeListener_onAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onAdClosed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdClosed != 1152921504943112384);
    
    }
    public static void remove_onSetNativeListener_onAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onAdClosed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onAdClosed != 1152921504943112384);
    
    }
    public static void add_onSetNativeListener_onClick(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onClick, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onClick != 1152921504943112392);
    
    }
    public static void remove_onSetNativeListener_onClick(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onClick, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onClick != 1152921504943112392);
    
    }
    public static void add_onSetNativeListener_onRequestAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onRequestAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onRequestAd != 1152921504943112400);
    
    }
    public static void remove_onSetNativeListener_onRequestAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onRequestAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onRequestAd != 1152921504943112400);
    
    }
    public static void add_onSetNativeListener_onReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onReadyAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onReadyAd != 1152921504943112408);
    
    }
    public static void remove_onSetNativeListener_onReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onReadyAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onReadyAd != 1152921504943112408);
    
    }
    public static void add_onSetNativeListener_onShowFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onShowFailed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onShowFailed != 1152921504943112416);
    
    }
    public static void remove_onSetNativeListener_onShowFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onShowFailed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onShowFailed != 1152921504943112416);
    
    }
    public static void add_onSetNativeListener_onShowSuccess(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetNativeListener_onShowSuccess, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onShowSuccess != 1152921504943112424);
    
    }
    public static void remove_onSetNativeListener_onShowSuccess(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetNativeListener_onShowSuccess, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetNativeListener_onShowSuccess != 1152921504943112424);
    
    }
    public static void add_onSetRewardListener_onRewarded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewarded, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewarded != 1152921504943112432);
    
    }
    public static void remove_onSetRewardListener_onRewarded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewarded, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewarded != 1152921504943112432);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLeftApplication, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLeftApplication != 1152921504943112440);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoAdLeftApplication(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLeftApplication, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLeftApplication != 1152921504943112440);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdClosed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdClosed != 1152921504943112448);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoAdClosed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdClosed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdClosed != 1152921504943112448);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdFailedToLoad, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdFailedToLoad != 1152921504943112456);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoAdFailedToLoad(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdFailedToLoad, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdFailedToLoad != 1152921504943112456);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLoaded, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLoaded != 1152921504943112464);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoAdLoaded(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLoaded, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLoaded != 1152921504943112464);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpened, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpened != 1152921504943112472);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoAdOpened(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpened, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpened != 1152921504943112472);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoStarted(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoStarted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoStarted != 1152921504943112480);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoStarted(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoStarted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoStarted != 1152921504943112480);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoCompleted(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoCompleted != 1152921504943112488);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoCompleted(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoCompleted != 1152921504943112488);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoClickAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoClickAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoClickAd != 1152921504943112496);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoClickAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoClickAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoClickAd != 1152921504943112496);
    
    }
    public static void add_onSetRewardListener_onRewardedReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedReadyAd, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedReadyAd != 1152921504943112504);
    
    }
    public static void remove_onSetRewardListener_onRewardedReadyAd(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedReadyAd, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedReadyAd != 1152921504943112504);
    
    }
    public static void add_onSetRewardListener_onRewardedVideoAdOpenFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpenFailed, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpenFailed != 1152921504943112512);
    
    }
    public static void remove_onSetRewardListener_onRewardedVideoAdOpenFailed(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpenFailed, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpenFailed != 1152921504943112512);
    
    }
    public static void add_onReceiveSettingData(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onReceiveSettingData, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onReceiveSettingData != 1152921504943112520);
    
    }
    public static void remove_onReceiveSettingData(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onReceiveSettingData, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onReceiveSettingData != 1152921504943112520);
    
    }
    public static void add_onReceiveExtraData(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  JoyPacAdverManager.onReceiveExtraData, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onReceiveExtraData != 1152921504943112528);
    
    }
    public static void remove_onReceiveExtraData(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  JoyPacAdverManager.onReceiveExtraData, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(JoyPacAdverManager.onReceiveExtraData != 1152921504943112528);
    
    }
    private static JoyPacAdverManager()
    {
        var val_7;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        if((UnityEngine.Object.FindObjectOfType(type:  val_1)) != null)
        {
                val_7 = 0;
        }
        
        if( != 0)
        {
                return;
        }
        
        new UnityEngine.GameObject() = new UnityEngine.GameObject(name:  val_1);
        UnityEngine.Component val_6 = new UnityEngine.GameObject().AddComponent(componentType:  val_1);
        UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
    }
    private void setBannerListener_onAdLoaded(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onAdLoaded msg:"("unity JoyPacAdverManager setBannerListener_onAdLoaded msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdLoaded;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdLoaded;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onAdFailedToLoad(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onAdFailedToLoad msg:"("unity JoyPacAdverManager setBannerListener_onAdFailedToLoad msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdFailedToLoad;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdFailedToLoad;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onAdOpened(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onAdOpened msg:"("unity JoyPacAdverManager setBannerListener_onAdOpened msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdOpened;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdOpened;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onAdLeftApplication(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onAdLeftApplication msg:"("unity JoyPacAdverManager setBannerListener_onAdLeftApplication msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdLeftApplication;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdLeftApplication;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onAdClosed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onAdClosed msg:"("unity JoyPacAdverManager setBannerListener_onAdClosed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdClosed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onAdClosed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onClick(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onClick msg:"("unity JoyPacAdverManager setBannerListener_onClick msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onClick;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onClick;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onRequestAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onRequestAd msg:"("unity JoyPacAdverManager setBannerListener_onRequestAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onRequestAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onRequestAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onReadyAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onReadyAd msg:"("unity JoyPacAdverManager setBannerListener_onReadyAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onReadyAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onReadyAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onShowFailed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onShowFailed msg:"("unity JoyPacAdverManager setBannerListener_onShowFailed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onShowFailed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onShowFailed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setBannerListener_onShowSuccess(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setBannerListener_onShowSuccess msg:"("unity JoyPacAdverManager setBannerListener_onShowSuccess msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetBannerListener_onShowSuccess;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetBannerListener_onShowSuccess;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onAdLoaded(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onAdLoaded msg:"("unity JoyPacAdverManager setInterstitialListener_onAdLoaded msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdLoaded;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdLoaded;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onAdFailedToLoad(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onAdFailedToLoad msg:"("unity JoyPacAdverManager setInterstitialListener_onAdFailedToLoad msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdFailedToLoad;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdFailedToLoad;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onAdOpened(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onAdOpened msg:"("unity JoyPacAdverManager setInterstitialListener_onAdOpened msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdOpened;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdOpened;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onAdLeftApplication(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onAdLeftApplication msg:"("unity JoyPacAdverManager setInterstitialListener_onAdLeftApplication msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdLeftApplication;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdLeftApplication;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onAdClosed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onAdClosed msg:"("unity JoyPacAdverManager setInterstitialListener_onAdClosed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdClosed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onAdClosed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onClick(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onClick msg:"("unity JoyPacAdverManager setInterstitialListener_onClick msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onClick;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onClick;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onRequestAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onRequestAd msg:"("unity JoyPacAdverManager setInterstitialListener_onRequestAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onRequestAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onRequestAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onReadyAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onReadyAd msg:"("unity JoyPacAdverManager setInterstitialListener_onReadyAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onReadyAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onReadyAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onShowFailed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onShowFailed msg:"("unity JoyPacAdverManager setInterstitialListener_onShowFailed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onShowFailed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onShowFailed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setInterstitialListener_onShowSuccess(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setInterstitialListener_onShowSuccess msg:"("unity JoyPacAdverManager setInterstitialListener_onShowSuccess msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onShowSuccess;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetInterstitialListener_onShowSuccess;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onAdLoaded(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onAdLoaded msg:"("unity JoyPacAdverManager setNativeListener_onAdLoaded msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdLoaded;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdLoaded;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onAdFailedToLoad(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onAdFailedToLoad msg:"("unity JoyPacAdverManager setNativeListener_onAdFailedToLoad msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdFailedToLoad;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdFailedToLoad;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onAdOpened(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onAdOpened msg:"("unity JoyPacAdverManager setNativeListener_onAdOpened msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdOpened;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdOpened;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onAdLeftApplication(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onAdLeftApplication msg:"("unity JoyPacAdverManager setNativeListener_onAdLeftApplication msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdLeftApplication;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdLeftApplication;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onAdClosed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onAdClosed msg:"("unity JoyPacAdverManager setNativeListener_onAdClosed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdClosed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onAdClosed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onClick(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onClick msg:"("unity JoyPacAdverManager setNativeListener_onClick msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onClick;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onClick;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onRequestAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onRequestAd msg:"("unity JoyPacAdverManager setNativeListener_onRequestAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onRequestAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onRequestAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onReadyAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onReadyAd msg:"("unity JoyPacAdverManager setNativeListener_onReadyAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onReadyAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onReadyAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onShowFailed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onShowFailed msg:"("unity JoyPacAdverManager setNativeListener_onShowFailed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onShowFailed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onShowFailed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setNativeListener_onShowSuccess(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setNativeListener_onShowSuccess msg:"("unity JoyPacAdverManager setNativeListener_onShowSuccess msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetNativeListener_onShowSuccess;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetNativeListener_onShowSuccess;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewarded(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewarded msg:"("unity JoyPacAdverManager setRewardListener_onRewarded msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewarded;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewarded;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoAdLeftApplication(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoAdLeftApplication msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoAdLeftApplication msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLeftApplication;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLeftApplication;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoAdClosed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoAdClosed msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoAdClosed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdClosed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdClosed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoAdFailedToLoad(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoAdFailedToLoad msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoAdFailedToLoad msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdFailedToLoad;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdFailedToLoad;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoAdLoaded(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoAdLoaded msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoAdLoaded msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLoaded;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdLoaded;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoAdOpened(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoAdOpened msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoAdOpened msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpened;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpened;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoStarted(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoStarted msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoStarted msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoStarted;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoStarted;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoCompleted(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoCompleted msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoCompleted msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoCompleted;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoCompleted;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoClickAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoClickAd msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoClickAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoClickAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoClickAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedReadyAd(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedReadyAd msg:"("unity JoyPacAdverManager setRewardListener_onRewardedReadyAd msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedReadyAd;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedReadyAd;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void setRewardListener_onRewardedVideoAdOpenFailed(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager setRewardListener_onRewardedVideoAdOpenFailed msg:"("unity JoyPacAdverManager setRewardListener_onRewardedVideoAdOpenFailed msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpenFailed;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onSetRewardListener_onRewardedVideoAdOpenFailed;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void ReceiveSettingData(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager ReceiveSettingData msg:"("unity JoyPacAdverManager ReceiveSettingData msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onReceiveSettingData;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onReceiveSettingData;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    private void ReceiveExtraData(string json)
    {
        var val_2;
        System.Action<System.String> val_3;
        UnityEngine.Debug.Log(message:  "unity JoyPacAdverManager ReceiveExtraData msg:"("unity JoyPacAdverManager ReceiveExtraData msg:") + json);
        val_2 = null;
        val_2 = null;
        val_3 = JoyPacAdverManager.onReceiveExtraData;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = JoyPacAdverManager.onReceiveExtraData;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  json);
    }
    public JoyPacAdverManager()
    {
    
    }

}
