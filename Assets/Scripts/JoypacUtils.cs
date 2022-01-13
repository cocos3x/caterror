using UnityEngine;
public static class JoypacUtils
{
    // Properties
    public static bool FirstPopReview { get; set; }
    public static string extraData { get; set; }
    public static int CrossTodayPopFlg { get; set; }
    public static System.DateTime CrossShowTimeValue { get; set; }
    public static bool isIpad { get; }
    public static bool IsCN { get; }
    
    // Methods
    public static bool get_FirstPopReview()
    {
        return (bool)((CryptoPrefs.GetInt(key:  "FirstPopReview", defaultValue:  1)) == 1) ? 1 : 0;
    }
    public static void set_FirstPopReview(bool value)
    {
        CryptoPrefs.SetInt(key:  "FirstPopReview", val:  value);
    }
    public static string get_extraData()
    {
        return CryptoPrefs.GetString(key:  "extraData", defaultValue:  "");
    }
    public static void set_extraData(string value)
    {
        CryptoPrefs.SetString(key:  "extraData", val:  value);
    }
    public static bool IsIphoneX()
    {
        int val_4;
        string val_5;
        var val_6;
        string[] val_2 = new string[6];
        val_2[0] = "iPhone10,3";
        val_2[1] = "iPhone10,6";
        val_2[2] = "iPhone11,8";
        val_2[3] = "iPhone11,2";
        val_2[4] = "iPhone11,6";
        val_4 = val_2.Length;
        val_5 = "iPhone11,4";
        if(val_4 <= 5)
        {
                val_4 = val_2.Length;
        }
        
        val_6 = 0;
        val_2[5] = val_5;
        if(val_4 >= 1)
        {
                do
        {
            val_5 = val_2[0];
            bool val_3 = UnityEngine.SystemInfo.deviceModel.Contains(value:  val_5);
            val_6 = val_6 | val_3;
        }
        while((0 + 1) < val_2.Length);
        
        }
        
        val_3 = val_6;
        return (bool)val_3;
    }
    public static int get_CrossTodayPopFlg()
    {
        return CryptoPrefs.GetInt(key:  "CrossTodayPopFlg", defaultValue:  0);
    }
    public static void set_CrossTodayPopFlg(int value)
    {
        CryptoPrefs.SetInt(key:  "CrossTodayPopFlg", val:  value);
    }
    public static System.DateTime get_CrossShowTimeValue()
    {
        var val_4;
        string val_1 = JoypacUtils.GetPlayerPrefsStringByKey(_key:  "CrossShowTimeValue", _defaultValue:  "");
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_4 = 0;
            return (System.DateTime)val_3.dateData;
        }
        
        System.DateTime val_3 = System.Convert.ToDateTime(value:  val_1);
        return (System.DateTime)val_3.dateData;
    }
    public static void set_CrossShowTimeValue(System.DateTime value)
    {
        JoypacUtils.SavePlayerPrefsStringByKeyValue(_key:  "CrossShowTimeValue", _newValue:  value.dateData);
    }
    public static bool get_isIpad()
    {
        string val_3 = UnityEngine.SystemInfo.deviceModel.ToLower().Trim();
        if(val_3 != null)
        {
                return val_3.StartsWith(value:  "ipad");
        }
        
        return val_3.StartsWith(value:  "ipad");
    }
    public static bool On(string onlineSwich)
    {
        UniRx.Unit..cctor();
        return (bool)System.String.op_Equality(a:  onlineSwich, b:  0.ToString());
    }
    public static bool On(JoypacOnlineParam _param)
    {
        return JoypacUtils.On(onlineSwich:  JoypacUtils.JoypacOnlineParameters(_param:  new JoypacOnlineParam() {Key = _param.Key, DefaultValue = _param.DefaultValue}));
    }
    public static void Share()
    {
        string val_2 = UnityEngine.Application.persistentDataPath + "/share.png"("/share.png");
        if((System.IO.File.Exists(path:  val_2)) != false)
        {
                return;
        }
        
        System.Byte[] val_5 = UnityEngine.ImageConversion.EncodeToPNG(tex:  UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "Joypac/share"));
        System.IO.FileStream val_6 = System.IO.File.Open(path:  val_2, mode:  2);
        System.IO.BinaryWriter val_7 = new System.IO.BinaryWriter(output:  val_6);
        val_6.Close();
    }
    public static void OpenPrivacyURL()
    {
        UnityEngine.Application.OpenURL(url:  "https://www.lovejpgames.com/privacy-policy/");
    }
    public static void OpenServiceURL()
    {
        UnityEngine.Application.OpenURL(url:  "https://joypacgames.com/terms");
    }
    public static bool FirstShowReview()
    {
        return (bool)((CryptoPrefs.GetInt(key:  "Joypac_REVIEWED", defaultValue:  0)) == 0) ? 1 : 0;
    }
    public static void AddReviewLog()
    {
        var val_4;
        UnityEngine.Debug.Log(message:  "[JoypacUtils] adjust 评价打点");
        if((CryptoPrefs.GetInt(key:  "Joypac_REVIEWED", defaultValue:  0)) == 0)
        {
                JoypacAnalyticsManager.Instance.ReyunLogEventToken(_eventToken:  "event_3");
            val_4 = JoypacAnalyticsManager.Instance;
            val_4.AdjustLogEventToken(_eventToken:  "do66gk");
        }
        
        JoypacUtils.SavePlayerPrefsIntByKeyValue(_key:  "Joypac_REVIEWED", _newValue:  1);
    }
    public static bool IfRemoveAds()
    {
        return (bool)((CryptoPrefs.GetInt(key:  "Joypac_REMOVE_ADS", defaultValue:  0)) == 1) ? 1 : 0;
    }
    public static bool NoAdsAndNoRewardVideo()
    {
        return JoypacAdManager.noAdsAndNoRewardVideo;
    }
    public static void SetRemoveAdBought()
    {
        UnityEngine.Debug.Log(message:  "购买成功，关闭banner和开屏");
        CryptoPrefs.SetInt(key:  "Joypac_REMOVE_ADS", val:  1);
        CryptoPrefs.Save();
        JoypacAdManager.Instance.RefreshVIPStatus();
        JoypacAdManager.Instance.HideSplashAd();
    }
    public static void ResetRemoveAdBought()
    {
        CryptoPrefs.SetInt(key:  "Joypac_REMOVE_ADS", val:  0);
        CryptoPrefs.Save();
        JoypacAdManager.Instance.RefreshVIPStatus();
    }
    public static void OpenJoypacURL()
    {
        UnityEngine.Application.OpenURL(url:  "https://joypacgames.com");
    }
    public static string OnlineStringParam(string _key, string defaultValue)
    {
        JoyPacUmengBridge val_1 = JoyPacUmengBridge.getInstance();
        if(val_1 != null)
        {
                return val_1.getConfigParamsJson(key:  _key);
        }
        
        return val_1.getConfigParamsJson(key:  _key);
    }
    public static int OnlineParametersInt(JoypacOnlineParam _param)
    {
        string val_10;
        object val_11;
        string val_1 = JoypacUtils.OnlineStringParam(_key:  _param.Key, defaultValue:  _param.DefaultValue);
        val_10 = val_1;
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                UnityEngine.Debug.Log(message:  "Joypac: online value is null, use default:"("Joypac: online value is null, use default:") + _param.DefaultValue + ", key : "(", key : ") + _param.Key);
            val_10 = _param.DefaultValue;
        }
        
        int val_4 = 0;
        if((System.Int32.TryParse(s:  val_10, result: out  val_4)) != false)
        {
                val_11 = val_4;
        }
        else
        {
                object[] val_6 = new object[4];
            val_6[0] = "Joypac: OnlineParametersInt TryParse error use default:";
            val_6[1] = 0;
            val_6[2] = ", key : ";
            val_6[3] = _param.Key;
            UnityEngine.Debug.Log(message:  +val_6);
            val_11 = 0;
        }
        
        object[] val_8 = new object[4];
        val_8[0] = "Joypac: OnlineParametersInt :";
        val_8[1] = val_11;
        val_8[2] = ", key : ";
        val_8[3] = _param.Key;
        UnityEngine.Debug.Log(message:  +val_8);
        return (int)val_11;
    }
    public static string OnlineParametersStringByJoypacSDK(JoypacOnlineParam _param)
    {
        return JoypacUtils.JoypacOnlineParameters(_param:  new JoypacOnlineParam() {Key = _param.Key, DefaultValue = _param.DefaultValue});
    }
    public static int OnlineParametersIntByJoypacSDK(JoypacOnlineParam _param)
    {
        string val_6;
        var val_7;
        val_6 = _param.Key;
        int val_2 = 0;
        if((System.Int32.TryParse(s:  JoypacUtils.JoypacOnlineParameters(_param:  new JoypacOnlineParam() {Key = val_6, DefaultValue = _param.DefaultValue}), result: out  val_2)) != false)
        {
                val_7 = val_2;
            return (int)val_7;
        }
        
        object[] val_4 = new object[4];
        val_4[0] = "Joypac: OnlineParametersInt TryParse error use default:";
        val_4[1] = 0;
        val_4[2] = ", key : ";
        val_4[3] = val_6;
        val_6 = +val_4;
        UnityEngine.Debug.Log(message:  val_6);
        val_7 = 0;
        return (int)val_7;
    }
    private static string JoypacOnlineParameters(JoypacOnlineParam _param)
    {
        if((JoypacUtils.extraData.Contains(value:  _param.Key)) == false)
        {
                return (string)_param.DefaultValue;
        }
        
        _param.DefaultValue = Newtonsoft.Json.Linq.JObject.Parse(json:  JoypacUtils.extraData).Item[_param.Key];
        return (string)_param.DefaultValue;
    }
    public static string OnlineParametersString(JoypacOnlineParam _param)
    {
        string val_5;
        string val_1 = JoypacUtils.OnlineStringParam(_key:  _param.Key, defaultValue:  _param.DefaultValue);
        val_5 = val_1;
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                UnityEngine.Debug.Log(message:  "Joypac: online value is null, use default:"("Joypac: online value is null, use default:") + _param.DefaultValue + ", key : "(", key : ") + _param.Key);
            val_5 = _param.DefaultValue;
        }
        
        UnityEngine.Debug.Log(message:  "Joypac: OnlineParametersString:"("Joypac: OnlineParametersString:") + val_5 + ", key : "(", key : ") + _param.Key);
        return val_5;
    }
    public static void OpenReviewURL()
    {
        UnityEngine.Application.OpenURL(url:  "market://details?id="("market://details?id=") + UnityEngine.Application.identifier);
    }
    public static bool IfFirstCheckPlayerPrefs(string _key)
    {
        CryptoPrefs.SetInt(key:  _key, val:  1);
        CryptoPrefs.Save();
        return (bool)((CryptoPrefs.GetInt(key:  _key, defaultValue:  0)) == 0) ? 1 : 0;
    }
    public static bool get_IsCN()
    {
        return true;
    }
    public static void FitsIphoneXByPosIsTop(UnityEngine.GameObject _go, bool _isUpper, int _value)
    {
        var val_16;
        var val_17;
        var val_21;
        val_16 = _go;
        if(JoypacUtils.IsIphoneX() == false)
        {
                return;
        }
        
        if(val_16 != null)
        {
                val_17 = val_16.transform;
        }
        else
        {
                val_17 = 0.transform;
        }
        
        UnityEngine.Vector3 val_5 = val_16.transform.localPosition;
        if(_isUpper != false)
        {
                UnityEngine.Vector3 val_7 = val_16.transform.localPosition;
            val_16 = val_16.transform;
            UnityEngine.Vector3 val_9 = val_16.localPosition;
            val_21 = val_7.y - (float)_value;
        }
        else
        {
                UnityEngine.Vector3 val_11 = val_16.transform.localPosition;
            val_16 = val_16.transform;
            UnityEngine.Vector3 val_13 = val_16.localPosition;
            val_21 = val_11.y + (float)_value;
        }
        
        val_17.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static void FitsIPadByPosIsTop(UnityEngine.GameObject _go, bool _isPlus, int _value)
    {
        var val_16;
        var val_17;
        var val_21;
        val_16 = _go;
        if(JoypacUtils.isIpad == false)
        {
                return;
        }
        
        if(val_16 != null)
        {
                val_17 = val_16.transform;
        }
        else
        {
                val_17 = 0.transform;
        }
        
        UnityEngine.Vector3 val_5 = val_16.transform.localPosition;
        if(_isPlus != false)
        {
                UnityEngine.Vector3 val_7 = val_16.transform.localPosition;
            val_16 = val_16.transform;
            UnityEngine.Vector3 val_9 = val_16.localPosition;
            val_21 = val_7.y - (float)_value;
        }
        else
        {
                UnityEngine.Vector3 val_11 = val_16.transform.localPosition;
            val_16 = val_16.transform;
            UnityEngine.Vector3 val_13 = val_16.localPosition;
            val_21 = val_11.y + (float)_value;
        }
        
        val_17.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static int GetPlayerPrefsIntByKey(string _key, int _defaultValue = 0)
    {
        return CryptoPrefs.GetInt(key:  _key, defaultValue:  _defaultValue);
    }
    public static void SavePlayerPrefsIntByKeyValue(string _key, int _newValue)
    {
        CryptoPrefs.SetInt(key:  _key, val:  _newValue);
        CryptoPrefs.Save();
    }
    public static string GetPlayerPrefsStringByKey(string _key, string _defaultValue = "")
    {
        return CryptoPrefs.GetString(key:  _key, defaultValue:  _defaultValue);
    }
    public static void SavePlayerPrefsStringByKeyValue(string _key, string _newValue)
    {
        CryptoPrefs.SetString(key:  _key, val:  _newValue);
        CryptoPrefs.Save();
    }
    public static void SaveFirstLoginTime()
    {
        if((JoypacUtils.IfFirstCheckPlayerPrefs(_key:  "Joypac_First_RUN_FLAG")) == false)
        {
                return;
        }
        
        JoypacUtils.SaveCurrTime2PlayerPrefs(_key:  "Joypac_Fist_Time_Value");
    }
    public static void SaveCurrTime2PlayerPrefs(string _key)
    {
        System.DateTime val_1 = System.DateTime.Now;
        JoypacUtils.SavePlayerPrefsStringByKeyValue(_key:  _key, _newValue:  val_1.dateData);
    }
    public static System.DateTime GetDateTimeFromPlayerPrefs(string _key)
    {
        var val_4;
        string val_1 = JoypacUtils.GetPlayerPrefsStringByKey(_key:  _key, _defaultValue:  "");
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_4 = 0;
            return (System.DateTime)val_3.dateData;
        }
        
        System.DateTime val_3 = System.Convert.ToDateTime(value:  val_1);
        return (System.DateTime)val_3.dateData;
    }
    public static bool isNewUser()
    {
        Color val_10;
        string val_11;
        string val_12;
        string val_13;
        string val_14;
        var val_15;
        System.DateTime val_1 = System.DateTime.Now;
        string val_2 = JoypacUtils.GetPlayerPrefsStringByKey(_key:  "Joypac_Fist_Time_Value", _defaultValue:  "");
        val_10 = 0;
        val_11 = val_2;
        if((System.String.IsNullOrEmpty(value:  val_2)) == false)
        {
            goto label_3;
        }
        
        val_12 = "存的值为空，为新用户";
        val_13 = "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Tool/JoypacUtils.cs";
        val_14 = "isNewUser";
        goto label_6;
        label_3:
        LogTool.DebugLog(log:  "读取出来的值： " + val_11 + " ， 现在的时间值：" + val_1.dateData, color:  val_11, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Tool/JoypacUtils.cs", name:  "isNewUser");
        System.DateTime val_5 = System.Convert.ToDateTime(value:  val_11);
        val_11 = val_5.dateData;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = val_11});
        double val_7 = val_6._ticks.TotalMinutes;
        LogTool.DebugLog(log:  "timeSpan.Seconds : "("timeSpan.Seconds : ") + val_7, color:  val_7, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Tool/JoypacUtils.cs", name:  "isNewUser");
        val_10 = 0;
        if(val_6._ticks.TotalMinutes >= 1440)
        {
            goto label_13;
        }
        
        val_13 = "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Tool/JoypacUtils.cs";
        val_14 = "isNewUser";
        val_12 = "是新用户";
        label_6:
        LogTool.DebugLog(log:  val_12, color:  val_10, path:  val_13, name:  val_14);
        val_15 = 1;
        return (bool)val_15;
        label_13:
        LogTool.DebugLog(log:  "不是新用户了", color:  val_10, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Tool/JoypacUtils.cs", name:  "isNewUser");
        val_15 = 0;
        return (bool)val_15;
    }
    public static bool FirstLauch()
    {
        return (bool)((CryptoPrefs.GetInt(key:  "Joypac_LAUNCH_COUNT", defaultValue:  0)) < 2) ? 1 : 0;
    }
    public static bool equalDouble(double a, double b)
    {
        a = a - b;
        return (bool)((a > (-1E-06)) ? 1 : 0) & ((a < 0) ? 1 : 0);
    }
    public static void SendAdjustURL(string url, string position)
    {
    
    }
    public static void SendGroup2Server(string _groupContent)
    {
        UnityEngine.Debug.Log(message:  "[JoypacUtils] SendGroup2Server, groupContent : "("[JoypacUtils] SendGroup2Server, groupContent : ") + _groupContent);
        UnityEngine.Debug.Log(message:  "调用安卓上报的方法");
        new JoyPacCurrentcyAdSingle().ReceiveGameGroupId(cGroupId:  _groupContent);
    }
    public static string GetDeviceId()
    {
        UnityEngine.Debug.Log(message:  "[JoypacUtils] GetDeviceId");
        UnityEngine.Debug.Log(message:  "调用安卓获取 GetDeviceID 的方法");
        string val_2 = new JoyPacCurrentcyAdSingle().GetDeviceID();
        return (string)((System.String.IsNullOrEmpty(value:  val_2)) != true) ? "" : (val_2);
    }
    public static string CountDownTimeString(System.DateTime dateTime)
    {
        var val_16;
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = dateTime.dateData}, d2:  new System.DateTime() {dateData = val_1.dateData});
        val_16 = 0;
        if(val_2._ticks.TotalSeconds <= 0f)
        {
                return (string)System.String.Format(format:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Days", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0), arg0:  (int)val_5._ticks.TotalDays)(System.String.Format(format:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Days", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0), arg0:  (int)val_5._ticks.TotalDays)) + "  " + System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_13)(System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_13));
        }
        
        System.DateTime val_4 = System.DateTime.Now;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = dateTime.dateData}, d2:  new System.DateTime() {dateData = val_4.dateData});
        if((int)val_5._ticks.TotalDays < (9.88131291682493E-324))
        {
                System.DateTime val_7 = System.DateTime.Now;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = dateTime.dateData}, d2:  new System.DateTime() {dateData = val_7.dateData});
            string val_9 = System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_8);
            return (string)System.String.Format(format:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Days", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0), arg0:  (int)val_5._ticks.TotalDays)(System.String.Format(format:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Days", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0), arg0:  (int)val_5._ticks.TotalDays)) + "  " + System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_13)(System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_13));
        }
        
        System.DateTime val_12 = System.DateTime.Now;
        System.TimeSpan val_13 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = dateTime.dateData}, d2:  new System.DateTime() {dateData = val_12.dateData});
        return (string)System.String.Format(format:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Days", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0), arg0:  (int)val_5._ticks.TotalDays)(System.String.Format(format:  I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Days", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0), arg0:  (int)val_5._ticks.TotalDays)) + "  " + System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_13)(System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_13));
    }
    public static string CountDownTimeShortString(System.DateTime dateTime)
    {
        ulong val_13;
        var val_14;
        val_13 = dateTime.dateData;
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_13}, d2:  new System.DateTime() {dateData = val_1.dateData});
        val_14 = 0;
        if(val_2._ticks.TotalSeconds <= 0f)
        {
                return (string)(val_11 == null) ? "" : (val_11);
        }
        
        System.DateTime val_4 = System.DateTime.Now;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_13}, d2:  new System.DateTime() {dateData = val_4.dateData});
        if((int)val_5._ticks.TotalDays < (9.88131291682493E-324))
        {
                System.DateTime val_7 = System.DateTime.Now;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_13}, d2:  new System.DateTime() {dateData = val_7.dateData});
            string val_9 = System.String.Format(format:  "{0:hh\\:mm\\:ss}", arg0:  val_8);
            return (string)(val_11 == null) ? "" : (val_11);
        }
        
        val_13 = I2.Loc.LocalizationManager.GetTermTranslation(Term:  "Days", FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0);
        string val_11 = System.String.Format(format:  val_13, arg0:  (int)val_5._ticks.TotalDays);
        return (string)(val_11 == null) ? "" : (val_11);
    }

}
