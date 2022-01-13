using UnityEngine;
public static class Const
{
    // Fields
    public static readonly string UnityVersion;
    public static readonly string DefaultAppVersion;
    public static readonly int DefaultAvatarId;
    public static readonly int DefaultCatId;
    public static readonly int DefaultCatHeadgearId;
    public static readonly int DefaultCatFaceItemId;
    public static readonly int AreaCount;
    public static readonly int ResultAdRewardMagnification;
    public static readonly float ContinuableTime;
    public static readonly string GameDataTag;
    public static readonly string VibrationTag;
    public static readonly string LanguageDataTypeTag;
    public static readonly string LocalNotificationTag;
    public static readonly string LineURL;
    public static readonly string FacebookURL;
    public static readonly string TwitterURL;
    public static readonly string AvatarDataSheet;
    public static readonly string StageDataSheet;
    public static readonly string RandomStageDataSheet;
    public static readonly string BackgroundDataSheet;
    public static readonly string[] LanguageFontArray;
    public static readonly string LangJapanDataSheet;
    public static readonly string LangEnglishDataSheet;
    public static readonly string LangChineseTraditionaldDataSheet;
    public static readonly string LangChineseSimplifiedDataSheet;
    public static readonly string UILangJapanDataSheet;
    public static readonly string UILangEnglishDataSheet;
    public static readonly string UILangChineseTraditionaldDataSheet;
    public static readonly string UILangChineseSimplifiedDataSheet;
    public static readonly Const.SheetData[] BaseSheetNameList;
    public static readonly Const.SheetData[] LanguageSheetNameList;
    
    // Methods
    private static Const()
    {
        Const.UnityVersion = "2018.4.17f1";
        Const.DefaultAppVersion = "0.1.0";
        Const.DefaultAvatarId = 1;
        Const.DefaultCatId = 1001;
        Const.DefaultCatHeadgearId = 2001;
        Const.DefaultCatFaceItemId = 3001;
        Const.AreaCount = 5;
        Const.ResultAdRewardMagnification = 6;
        Const.ContinuableTime = 7f;
        Const.GameDataTag = "GameData";
        Const.VibrationTag = "Vibration";
        Const.LanguageDataTypeTag = "LanguageDataType";
        Const.LocalNotificationTag = "LocalNotification";
        Const.LineURL = "http://nav.cx/aVZ8nEK";
        Const.FacebookURL = "https://www.facebook.com/usayaApp/";
        Const.TwitterURL = "https://twitter.com/usayaApp";
        Const.AvatarDataSheet = "AvatarData";
        Const.StageDataSheet = "StageData";
        Const.RandomStageDataSheet = "RandomStageData";
        Const.BackgroundDataSheet = "BackgroundData";
        string[] val_1 = new string[4];
        val_1[0] = "natumemozi";
        val_1[1] = "natumemozi";
        val_1[2] = "DFPYuanW7-GB";
        val_1[3] = "DFPGHaoTaiWangBeiW4";
        Const.LanguageFontArray = val_1;
        Const.LangJapanDataSheet = "LangJapanData";
        Const.LangEnglishDataSheet = "LangEnglishData";
        Const.LangChineseTraditionaldDataSheet = "LangChineseTraditionaldData";
        Const.LangChineseSimplifiedDataSheet = "LangChineseSimplifiedData";
        Const.UILangJapanDataSheet = "UILangJapanData";
        Const.UILangEnglishDataSheet = "UILangEnglishData";
        Const.UILangChineseTraditionaldDataSheet = "UILangChineseTraditionaldData";
        Const.UILangChineseSimplifiedDataSheet = "UILangChineseSimplifiedData";
        SheetData[] val_2 = new SheetData[4];
        Const.SheetData val_3 = new Const.SheetData();
        .name = Const.AvatarDataSheet;
        .className = Const.AvatarDataSheet;
        if(val_2 == null)
        {
            goto label_14;
        }
        
        if(val_3 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_3 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_2[0] = val_3;
        .name = Const.StageDataSheet;
        .className = Const.StageDataSheet;
        val_2[1] = new Const.SheetData();
        .name = Const.RandomStageDataSheet;
        .className = "StageData";
        val_2[2] = new Const.SheetData();
        .name = Const.BackgroundDataSheet;
        .className = Const.BackgroundDataSheet;
        val_2[3] = new Const.SheetData();
        Const.BaseSheetNameList = val_2;
        SheetData[] val_7 = new SheetData[8];
        Const.SheetData val_8 = new Const.SheetData();
        .name = Const.LangJapanDataSheet;
        .className = "LanguageData";
        if(val_7 == null)
        {
            goto label_29;
        }
        
        if(val_8 != null)
        {
            goto label_30;
        }
        
        goto label_33;
        label_29:
        if(val_8 == null)
        {
            goto label_33;
        }
        
        label_30:
        label_33:
        val_7[0] = val_8;
        .name = Const.LangEnglishDataSheet;
        .className = "LanguageData";
        val_7[1] = new Const.SheetData();
        .name = Const.LangChineseTraditionaldDataSheet;
        .className = "LanguageData";
        val_7[2] = new Const.SheetData();
        .name = Const.LangChineseSimplifiedDataSheet;
        .className = "LanguageData";
        val_7[3] = new Const.SheetData();
        .name = Const.UILangJapanDataSheet;
        .className = "LanguageData";
        val_7[4] = new Const.SheetData();
        .name = Const.UILangEnglishDataSheet;
        .className = "LanguageData";
        val_7[5] = new Const.SheetData();
        .name = Const.UILangChineseTraditionaldDataSheet;
        .className = "LanguageData";
        val_7[6] = new Const.SheetData();
        .name = Const.UILangChineseSimplifiedDataSheet;
        .className = "LanguageData";
        val_7[7] = new Const.SheetData();
        Const.LanguageSheetNameList = val_7;
    }

}
