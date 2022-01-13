using UnityEngine;
public sealed class LocalNotificationManager : SingletonMonoBehaviour<LocalNotificationManager>
{
    // Fields
    private static readonly int NotificationTitleStringId;
    private static readonly int NotificationMessageStringId;
    private static readonly int[] NotificationRecall1StringIdArray;
    private static readonly int NotificationComebackBonusStringId;
    private static readonly string ChannelId;
    private static readonly int OneDayInterval;
    private static readonly int Delay;
    private System.DateTime beginTime;
    private bool isEnable;
    private bool isPause;
    
    // Properties
    private int FirstDayInterval { get; }
    
    // Methods
    private int get_FirstDayInterval()
    {
        null = null;
        System.DateTime val_1 = System.DateTime.UtcNow;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.beginTime});
        int val_5 = (int)val_2._ticks.TotalSeconds;
        val_5 = LocalNotificationManager.OneDayInterval - val_5;
        return (int)val_5 - LocalNotificationManager.Delay;
    }
    private void Awake()
    {
        null = null;
        0.Id = LocalNotificationManager.ChannelId;
        0.LogType = 4;
        0.Id = "USAYA Tofu Channel notifications";
        Unity.Notifications.Android.AndroidNotificationCenter.RegisterNotificationChannel(channel:  new Unity.Notifications.Android.AndroidNotificationChannel() {<CanBypassDnd>k__BackingField = false, <CanShowBadge>k__BackingField = false, <EnableLights>k__BackingField = false, <EnableVibration>k__BackingField = false});
    }
    public void RegisterNotification()
    {
        this.isEnable = true;
    }
    public void Enable()
    {
        this.isEnable = true;
        this.CancelAllNotifications();
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if(GameDataManager.ExistsGameData() == false)
        {
                return;
        }
        
        if(pauseStatus != false)
        {
                this.isPause = true;
            this.SetNotification();
            return;
        }
        
        if(this.isPause == false)
        {
                return;
        }
        
        this.isPause = false;
        System.DateTime val_2 = System.DateTime.UtcNow;
        this.beginTime = val_2;
        this.CancelAllNotifications();
    }
    private void SendLocalNotification(int triggerInSeconds, string title, string message, int id)
    {
        var val_4;
        Id = title;
        Id = "icon_small";
        Description = "icon_large";
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_2 = val_1.dateData.AddSeconds(value:  (double)triggerInSeconds);
        Name = val_2.dateData;
        val_4 = null;
        val_4 = null;
        int val_3 = Unity.Notifications.Android.AndroidNotificationCenter.SendNotification(notification:  new Unity.Notifications.Android.AndroidNotification() {<FireTime>k__BackingField = new System.DateTime(), <ShouldAutoCancel>k__BackingField = false, <UsesStopwatch>k__BackingField = false, <GroupSummary>k__BackingField = false, <ShowTimestamp>k__BackingField = false, <ShowCustomTimestamp>k__BackingField = false, m_Color = new UnityEngine.Color(), m_RepeatInterval = new System.TimeSpan(), m_CustomTimestamp = new System.DateTime()}, channelId:  LocalNotificationManager.ChannelId);
    }
    private void CancelAllNotifications()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        Unity.Notifications.Android.AndroidNotificationCenter.CancelAllNotifications();
    }
    private void SetNotification()
    {
        string val_19;
        var val_20;
        var val_21;
        var val_22;
        System.Predicate<T> val_23;
        var val_24;
        var val_25;
        var val_27;
        LocalNotificationManager.<>c__DisplayClass19_0 val_1 = new LocalNotificationManager.<>c__DisplayClass19_0();
        if(this.isEnable == false)
        {
                return;
        }
        
        if(GameDataManager.IsLoaded == false)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        val_19 = Const.LocalNotificationTag;
        if((UsayaStorageManager.LoadOrDefault<System.Boolean>(filename:  1, tag:  val_19, defaultValue:  true)) == false)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        GameData val_7 = GameDataManager.GameData;
        if(val_1 == null)
        {
            goto label_15;
        }
        
        .gameData = val_7;
        if(val_7 != null)
        {
            goto label_27;
        }
        
        label_28:
        label_27:
        .loginCount = val_7.dailyLoginCount + 1;
        val_22 = null;
        val_22 = null;
        System.Predicate<AvatarData> val_11 = null;
        val_23 = val_11;
        val_11 = new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean LocalNotificationManager.<>c__DisplayClass19_0::<SetNotification>b__0(AvatarData data));
        AvatarData val_12 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).Find(match:  val_11);
        LanguageManager val_13 = SingletonMonoBehaviour<LanguageManager>.Instance;
        val_24 = null;
        if(val_12 == null)
        {
            goto label_22;
        }
        
        val_25 = null;
        val_23 = LocalNotificationManager.NotificationComebackBonusStringId;
        string val_16 = System.String.Format(format:  val_13.GetWordUI(id:  val_23), arg0:  val_12.Name);
        goto label_26;
        label_15:
        mem[24] = val_7;
        if(mem[24] != 0)
        {
            goto label_27;
        }
        
        goto label_28;
        label_22:
        val_27 = null;
        string val_18 = val_13.GetWordUI(id:  ArrayExtensions.RandomChoose<System.Int32>(array:  LocalNotificationManager.NotificationRecall1StringIdArray));
        label_26:
        val_18.SendLocalNotification(triggerInSeconds:  this.FirstDayInterval, title:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  LocalNotificationManager.NotificationTitleStringId), message:  val_18, id:  0);
    }
    public LocalNotificationManager()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.beginTime = val_1;
    }
    private static LocalNotificationManager()
    {
        LocalNotificationManager.NotificationTitleStringId = 1000;
        LocalNotificationManager.NotificationRecall1StringIdArray = new int[8] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008};
        LocalNotificationManager.NotificationComebackBonusStringId = 1009;
        LocalNotificationManager.ChannelId = "usaya-nigeneko-notification";
        LocalNotificationManager.OneDayInterval = 86400;
        LocalNotificationManager.Delay = 5;
    }

}
