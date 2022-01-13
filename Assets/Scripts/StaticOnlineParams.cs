using UnityEngine;
public static class StaticOnlineParams
{
    // Fields
    private static bool hasInterLimitFlag;
    private static bool hasInterPatienceLimitFlag;
    private static bool nativeAdSwitchOnFlag;
    public static bool UseJoypacSdk;
    public static bool firebaseOnlineParamsSuccess;
    public static JoypacOnlineParam Intersitial_CD;
    public static JoypacOnlineParam Intersitial_ClickCountCD_BeforeRate;
    public static JoypacOnlineParam Intersitial_ClickCountCD_AfterRate;
    public static JoypacOnlineParam Intersitial_PatienceTime;
    public static JoypacOnlineParam Advrecovery;
    public static JoypacOnlineParam InersitialAdSwitch;
    public static JoypacOnlineParam NativeAdSwitch;
    public static JoypacOnlineParam GET_MOREGAMES;
    public static JoypacOnlineParam cross_launch_switch;
    public static JoypacOnlineParam cross_main_switch;
    public static JoypacOnlineParam cross_video_switch;
    public static JoypacOnlineParam cross_video_url;
    public static JoypacOnlineParam cross_launch_url;
    public static JoypacOnlineParam cross_switch_clear;
    public static JoypacOnlineParam showInterPopN;
    public static JoypacOnlineParam InterTip;
    public static JoypacOnlineParam AdWaitTime;
    public static JoypacOnlineParam PresentBoxRatio;
    
    // Methods
    private static string getIntersitial_CD_DefaultValue()
    {
        null = null;
        return (string)(StaticOnlineParams.hasInterLimitFlag == true) ? "180" : "0";
    }
    private static string getInterPatienceLimit_DefaultValue()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(StaticOnlineParams.hasInterPatienceLimitFlag == false)
        {
                return (string)2147483647.ToString();
        }
        
        val_3 = "180";
        return (string)2147483647.ToString();
    }
    public static string getNativeAdSwitch_DefaultValue()
    {
        null = null;
        return (string)(StaticOnlineParams.nativeAdSwitchOnFlag == true) ? "on" : "off";
    }
    public static void Init()
    {
        UnityEngine.Debug.Log(message:  "Static Online Params");
    }
    private static StaticOnlineParams()
    {
        StaticOnlineParams.hasInterLimitFlag = false;
        StaticOnlineParams.hasInterPatienceLimitFlag = false;
        StaticOnlineParams.nativeAdSwitchOnFlag = true;
        StaticOnlineParams.UseJoypacSdk = true;
        StaticOnlineParams.firebaseOnlineParamsSuccess = false;
        UniRx.Pair<System.Object> val_2 = new UniRx.Pair<System.Object>(previous:  "ads_inter_limit", current:  StaticOnlineParams.getIntersitial_CD_DefaultValue());
        StaticOnlineParams.Intersitial_CD = val_2.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_10 = 0;
        UniRx.Pair<System.Object> val_3 = new UniRx.Pair<System.Object>(previous:  "inters_ad_order", current:  "2");
        StaticOnlineParams.Intersitial_ClickCountCD_BeforeRate = val_3.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_20 = 0;
        UniRx.Pair<System.Object> val_4 = new UniRx.Pair<System.Object>(previous:  "ads_inter_count_step2", current:  "2");
        StaticOnlineParams.Intersitial_ClickCountCD_AfterRate = val_4.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_30 = 0;
        UniRx.Pair<System.Object> val_6 = new UniRx.Pair<System.Object>(previous:  "ads_inter_time", current:  StaticOnlineParams.getInterPatienceLimit_DefaultValue());
        StaticOnlineParams.Intersitial_PatienceTime = val_6.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_40 = 0;
        UniRx.Pair<System.Object> val_7 = new UniRx.Pair<System.Object>(previous:  "Advrecovery", current:  "7");
        StaticOnlineParams.Advrecovery = val_7.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_50 = 0;
        UniRx.Pair<System.Object> val_8 = new UniRx.Pair<System.Object>(previous:  "inersitialAdSwitch", current:  "on");
        StaticOnlineParams.InersitialAdSwitch = val_8.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_60 = 0;
        UniRx.Pair<System.Object> val_10 = new UniRx.Pair<System.Object>(previous:  "NativeAdSwitch", current:  StaticOnlineParams.getNativeAdSwitch_DefaultValue());
        StaticOnlineParams.NativeAdSwitch = val_10.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_70 = 0;
        UniRx.Pair<System.Object> val_11 = new UniRx.Pair<System.Object>(previous:  "getmoregames", current:  "0");
        StaticOnlineParams.GET_MOREGAMES = val_11.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_80 = 0;
        UniRx.Pair<System.Object> val_12 = new UniRx.Pair<System.Object>(previous:  "cross_launch_switch", current:  "off");
        StaticOnlineParams.cross_launch_switch = val_12.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_90 = 0;
        UniRx.Pair<System.Object> val_13 = new UniRx.Pair<System.Object>(previous:  "cross_main_switch", current:  "off");
        StaticOnlineParams.cross_main_switch = val_13.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_A0 = 0;
        UniRx.Pair<System.Object> val_14 = new UniRx.Pair<System.Object>(previous:  "cross_video_switch", current:  "off");
        StaticOnlineParams.cross_video_switch = val_14.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_B0 = 0;
        UniRx.Pair<System.Object> val_15 = new UniRx.Pair<System.Object>(previous:  "cross_video_url", current:  "");
        StaticOnlineParams.cross_video_url = val_15.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_C0 = 0;
        UniRx.Pair<System.Object> val_16 = new UniRx.Pair<System.Object>(previous:  "cross_launch_url", current:  "");
        StaticOnlineParams.cross_launch_url = val_16.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_D0 = 0;
        UniRx.Pair<System.Object> val_17 = new UniRx.Pair<System.Object>(previous:  "cross_switch_clear", current:  "off");
        StaticOnlineParams.cross_switch_clear = val_17.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_E0 = 0;
        UniRx.Pair<System.Object> val_18 = new UniRx.Pair<System.Object>(previous:  "showInterPopN", current:  "3");
        StaticOnlineParams.showInterPopN = val_18.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_F0 = 0;
        UniRx.Pair<System.Object> val_19 = new UniRx.Pair<System.Object>(previous:  "InterTip", current:  "off");
        StaticOnlineParams.InterTip = val_19.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_100 = 0;
        UniRx.Pair<System.Object> val_20 = new UniRx.Pair<System.Object>(previous:  "AdWaitTime", current:  "300");
        UniRx.Pair<System.Object> val_21;
        StaticOnlineParams.AdWaitTime = val_20.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_110 = 0;
        val_21 = new UniRx.Pair<System.Object>(previous:  "PresentBoxRatio", current:  "40");
        StaticOnlineParams.PresentBoxRatio = val_21.current;
        StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_120 = 0;
    }

}
