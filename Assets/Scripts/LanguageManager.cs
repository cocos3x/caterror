using UnityEngine;
public sealed class LanguageManager : SingletonMonoBehaviour<LanguageManager>
{
    // Fields
    private static readonly int SecondsSuffixStringId;
    private static readonly int MinutesSuffixStringId;
    private static readonly int HoursSuffixStringId;
    private static readonly int DaysSuffixStringId;
    private static readonly int[] LanguageStringIdArray;
    private System.Collections.Generic.List<LanguageData> LangDatalist;
    private System.Collections.Generic.List<LanguageData> UILangDatalist;
    private bool isChineseCharacters;
    private string secondsSuffix;
    private string minutesSuffix;
    private string hoursSuffix;
    private string daysSuffix;
    private UnityEngine.Font font;
    private string[] LanguageDataTypeSheetList;
    private string[] UILanguageDataTypeSheetList;
    
    // Properties
    public bool IsChineseCharacters { get; }
    public UnityEngine.Font Font { get; }
    
    // Methods
    public bool get_IsChineseCharacters()
    {
        return (bool)this.isChineseCharacters;
    }
    public UnityEngine.Font get_Font()
    {
        return (UnityEngine.Font)this.font;
    }
    private void Awake()
    {
        LanguageDataType val_1 = this.UpdateLang();
    }
    public LanguageDataType UpdateLang()
    {
        var val_16;
        var val_17;
        LanguageDataType val_1 = this.GetDeviceLanguageDataType();
        val_16 = null;
        val_16 = null;
        System.String[] val_2 = Const.LanguageFontArray + (((long)(int)(val_1)) << 3);
        this.font = UnityEngine.Resources.Load<UnityEngine.Font>(path:  "Fonts/"("Fonts/") + (Const.LanguageFontArray + ((long)(int)(val_1)) << 3) + 32((Const.LanguageFontArray + ((long)(int)(val_1)) << 3) + 32));
        this.LangDatalist = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<LanguageData>(worksheetName:  this.LanguageDataTypeSheetList[(long)val_1]);
        this.UILangDatalist = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<LanguageData>(worksheetName:  this.UILanguageDataTypeSheetList[(long)val_1]);
        val_17 = null;
        val_17 = null;
        this.secondsSuffix = this.GetWordUI(id:  LanguageManager.SecondsSuffixStringId);
        this.minutesSuffix = this.GetWordUI(id:  LanguageManager.MinutesSuffixStringId);
        this.hoursSuffix = this.GetWordUI(id:  LanguageManager.HoursSuffixStringId);
        bool val_15 = ((val_1 & 4294967294) == 2) ? 1 : 0;
        val_15 = ((val_1 == 0) ? 1 : 0) | val_15;
        this.daysSuffix = this.GetWordUI(id:  LanguageManager.DaysSuffixStringId);
        this.isChineseCharacters = val_15;
        return val_1;
    }
    public LanguageDataType GetDeviceLanguageDataType()
    {
        var val_12;
        string val_13;
        var val_14;
        string val_15;
        UsayaStorageFilename val_16;
        val_12 = null;
        val_12 = null;
        val_13 = 1152921504960946176;
        if((UsayaStorageManager.Exists(filename:  1, tag:  Const.LanguageDataTypeTag)) != false)
        {
                val_14 = null;
            val_14 = null;
            val_15 = Const.LanguageDataTypeTag;
            val_16 = 1;
            int val_2 = UsayaStorageManager.Load<System.Int32>(filename:  val_16, tag:  val_15);
            return (LanguageDataType)((System.String.op_Equality(a:  val_15 = UnityEngine.Application.systemLanguage.ToString(), b:  val_13 = 41.ToString())) != true) ? 3 : (0 + 1);
        }
        
        UniRx.Unit..cctor();
        val_13 = 22.ToString();
        UniRx.Unit..cctor();
        if((System.String.op_Equality(a:  val_15, b:  val_13)) != false)
        {
                val_16 = 0;
            return (LanguageDataType)((System.String.op_Equality(a:  val_15, b:  val_13)) != true) ? 3 : (0 + 1);
        }
        
        val_13 = 40.ToString();
        UniRx.Unit..cctor();
        if((System.String.op_Equality(a:  val_15, b:  val_13)) != false)
        {
                val_16 = 2;
            return (LanguageDataType)((System.String.op_Equality(a:  val_15, b:  val_13)) != true) ? 3 : (0 + 1);
        }
        
        UniRx.Unit..cctor();
        return (LanguageDataType)((System.String.op_Equality(a:  val_15, b:  val_13)) != true) ? 3 : (0 + 1);
    }
    public string ToLanguageName(LanguageDataType languageDataType)
    {
        null = null;
        System.Int32[] val_1 = LanguageManager.LanguageStringIdArray + (((long)(int)(languageDataType)) << 2);
        return this.GetWordUI(id:  (LanguageManager.LanguageStringIdArray + ((long)(int)(languageDataType)) << 2) + 32);
    }
    public string getWord(int id)
    {
        var val_4;
        List.Enumerator<T> val_1 = this.LangDatalist.GetEnumerator();
        label_4:
        if(((-1235611016) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.Id;
        if(val_2.m_stringLength != id)
        {
            goto label_4;
        }
        
        UniRx.Unit..cctor();
        return (string)val_4;
        label_2:
        UniRx.Unit..cctor();
        UnityEngine.Debug.LogError(message:  "ID:"("ID:") + id + "の言語データが参照できません");
        val_4 = " ";
        return (string)val_4;
    }
    public string GetWordUI(int id)
    {
        var val_4;
        List.Enumerator<T> val_1 = this.UILangDatalist.GetEnumerator();
        label_4:
        if(((-1235466136) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.Id;
        if(val_2.m_stringLength != id)
        {
            goto label_4;
        }
        
        UniRx.Unit..cctor();
        return (string)val_4;
        label_2:
        UniRx.Unit..cctor();
        UnityEngine.Debug.LogError(message:  "ID:"("ID:") + id + "のUI言語データが参照できません");
        val_4 = " ";
        return (string)val_4;
    }
    public string ToLocalizedTimeString(float value, bool useSeconds = True, bool useMinutes = True, bool useHours = True, bool useDays = True, bool isFull = False)
    {
        return FloatExtentions.ToTimeString(f:  value, secondsStr:  (useSeconds != true) ? this.secondsSuffix : "", minutesStr:  (useMinutes != true) ? this.minutesSuffix : "", hoursStr:  (useHours != true) ? this.hoursSuffix : "", daysStr:  (useDays != true) ? this.daysSuffix : "", isFull:  isFull);
    }
    public string ToLocalizedTimerString(float value, bool isFull = True)
    {
        return FloatExtentions.ToTimerString(f:  value, secondsStr:  this.secondsSuffix, minutesStr:  this.minutesSuffix, hoursStr:  this.hoursSuffix, daysStr:  this.daysSuffix, isFull:  isFull);
    }
    public string ToLocalizeInt(InfiniteFloat value)
    {
        var val_1;
        if(this.isChineseCharacters != false)
        {
                val_1;
            return (string)val_1;
        }
        
        val_1;
        return (string)val_1;
    }
    public LanguageManager()
    {
        var val_3;
        string[] val_1 = new string[4];
        val_3 = null;
        val_3 = null;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(Const.LangJapanDataSheet != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(Const.LangJapanDataSheet == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = Const.LangJapanDataSheet;
        val_1[1] = Const.LangEnglishDataSheet;
        val_1[2] = Const.LangChineseSimplifiedDataSheet;
        val_1[3] = Const.LangChineseTraditionaldDataSheet;
        this.LanguageDataTypeSheetList = val_1;
        string[] val_2 = new string[4];
        if(val_2 == null)
        {
            goto label_18;
        }
        
        if(Const.UILangJapanDataSheet != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(Const.UILangJapanDataSheet == null)
        {
            goto label_22;
        }
        
        label_19:
        label_22:
        val_2[0] = Const.UILangJapanDataSheet;
        val_2[1] = Const.UILangEnglishDataSheet;
        val_2[2] = Const.UILangChineseSimplifiedDataSheet;
        val_2[3] = Const.UILangChineseTraditionaldDataSheet;
        this.UILanguageDataTypeSheetList = val_2;
    }
    private static LanguageManager()
    {
        LanguageManager.SecondsSuffixStringId = 1;
        LanguageManager.MinutesSuffixStringId = 2;
        LanguageManager.HoursSuffixStringId = 3;
        LanguageManager.DaysSuffixStringId = 4;
        LanguageManager.LanguageStringIdArray = new int[3] {101, 102, 103};
    }

}
