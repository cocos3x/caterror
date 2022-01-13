using UnityEngine;
public sealed class GameData
{
    // Fields
    public long beginPlayTime;
    public string lastPlayedVersion;
    public long lastPlayTime;
    public int dailyLoginCount;
    public int adCount;
    public int stage;
    public int avatarId;
    public int coin;
    private int[] avatarIdArray;
    public System.Collections.Generic.List<int> avatarIdList;
    public int gachaCount;
    private int[] newAvatarIdArray;
    public System.Collections.Generic.List<int> newAvatarIdList;
    public bool isRandomAvatar;
    public int catId;
    public bool isRandomCat;
    public int catHeadgearId;
    public bool isRandomCatHeadgear;
    public int catFaceItemId;
    public bool isRandomCatFaceItem;
    public long[] lastAdRewardTimeArray;
    public System.Collections.Generic.List<long> lastAdRewardTimeList;
    public long lastDailyBonusTime;
    public bool isDeleteAd;
    
    // Properties
    public bool IsTodayFirstLogin { get; }
    public bool IsReceivableDailyBonus { get; }
    
    // Methods
    public bool CheckAdReward(AdRewardType type)
    {
        return (bool)((this.GetAdRewardRemainingTime(type:  type)) <= 0f) ? 1 : 0;
    }
    public float GetAdRewardRemainingTime(AdRewardType type)
    {
        ulong val_7;
        var val_8;
        val_7 = this;
        if(type != 1)
        {
                return -1f;
        }
        
        val_8 = null;
        val_8 = null;
        System.DateTime val_2 = System.DateTime.UtcNow;
        val_7 = val_2.dateData;
        System.DateTime val_4 = System.DateTime.FromBinary(dateData:  this.lastAdRewardTimeList.Item[1]);
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7}, d2:  new System.DateTime() {dateData = val_4.dateData});
        float val_7 = (float)val_5._ticks.TotalSeconds;
        val_7 = ((float)JoypacUtils.OnlineParametersIntByJoypacSDK(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.AdWaitTime, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_110})) - val_7;
        return -1f;
    }
    public void ShowedAdReward(AdRewardType type)
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.lastAdRewardTimeList.set_Item(index:  type, value:  null);
    }
    public bool get_IsTodayFirstLogin()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        System.DateTime val_2 = val_1.dateData.ToLocalTime();
        System.DateTime val_3 = val_2.dateData.Date;
        System.DateTime val_4 = System.DateTime.FromBinary(dateData:  this.lastPlayTime);
        System.DateTime val_5 = val_4.dateData.ToLocalTime();
        System.DateTime val_6 = val_5.dateData.Date;
        return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_3.dateData}, t2:  new System.DateTime() {dateData = val_6.dateData});
    }
    public bool get_IsReceivableDailyBonus()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        System.DateTime val_2 = val_1.dateData.ToLocalTime();
        System.DateTime val_3 = val_2.dateData.Date;
        System.DateTime val_4 = System.DateTime.FromBinary(dateData:  this.lastDailyBonusTime);
        System.DateTime val_5 = val_4.dateData.ToLocalTime();
        System.DateTime val_6 = val_5.dateData.Date;
        return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_3.dateData}, t2:  new System.DateTime() {dateData = val_6.dateData});
    }
    public void ChangeAvatar(AvatarData avatarData)
    {
        if((avatarData.Category - 1) <= 3)
        {
                var val_4 = 28871808 + ((val_1 - 1)) << 2;
            val_4 = val_4 + 28871808;
        }
        else
        {
                bool val_3 = this.newAvatarIdList.Remove(item:  avatarData.id);
        }
    
    }
    public void AddAvatar(AvatarData avatarData)
    {
        if((this.HasAvatar(avatarData:  avatarData)) != false)
        {
                return;
        }
        
        this.avatarIdList.Add(item:  avatarData.id);
        this.newAvatarIdList.Add(item:  avatarData.id);
    }
    public bool HasAvatar(AvatarData avatarData)
    {
        .avatarData = avatarData;
        if(this.avatarIdList != null)
        {
                return this.avatarIdList.Exists(match:  new System.Predicate<System.Int32>(object:  new GameData.<>c__DisplayClass33_0(), method:  System.Boolean GameData.<>c__DisplayClass33_0::<HasAvatar>b__0(int id)));
        }
        
        return this.avatarIdList.Exists(match:  new System.Predicate<System.Int32>(object:  new GameData.<>c__DisplayClass33_0(), method:  System.Boolean GameData.<>c__DisplayClass33_0::<HasAvatar>b__0(int id)));
    }
    public void SetRandom(bool isRandom, AvatarCategory category)
    {
        if((category - 1) > 3)
        {
                return;
        }
        
        var val_6 = 28871824 + ((category - 1)) << 2;
        val_6 = val_6 + 28871824;
        goto (28871824 + ((category - 1)) << 2 + 28871824);
    }
    public bool GetRandom(AvatarCategory category)
    {
        if((category - 1) > 3)
        {
                return false;
        }
        
        var val_3 = 28871840 + ((category - 1)) << 2;
        val_3 = val_3 + 28871840;
        goto (28871840 + ((category - 1)) << 2 + 28871840);
    }
    public void OnDeserialized()
    {
        var val_9;
        var val_10;
        var val_12;
        var val_13;
        var val_15;
        var val_16;
        System.Predicate<System.Int32> val_18;
        var val_19;
        var val_20;
        var val_21;
        this.PreDeserialize();
        if(this.avatarIdList.Count <= 0)
        {
                val_9 = null;
            val_9 = null;
            this.avatarIdList.Add(item:  Const.DefaultAvatarId);
        }
        
        val_10 = null;
        val_10 = null;
        if((GameData.<>c.<>9__36_0) == null)
        {
            goto label_8;
        }
        
        label_43:
        if((this.avatarIdList.Exists(match:  GameData.<>c.<>9__36_0)) != true)
        {
                val_12 = null;
            val_12 = null;
            this.avatarIdList.Add(item:  Const.DefaultCatId);
        }
        
        val_13 = null;
        val_13 = null;
        if((GameData.<>c.<>9__36_1) == null)
        {
            goto label_16;
        }
        
        label_47:
        if((this.avatarIdList.Exists(match:  GameData.<>c.<>9__36_1)) != true)
        {
                val_15 = null;
            val_15 = null;
            this.avatarIdList.Add(item:  Const.DefaultCatHeadgearId);
        }
        
        val_16 = null;
        val_16 = null;
        val_18 = GameData.<>c.<>9__36_2;
        if(val_18 == null)
        {
            goto label_24;
        }
        
        label_51:
        if((this.avatarIdList.Exists(match:  val_18)) != true)
        {
                val_19 = null;
            val_19 = null;
            val_18 = Const.DefaultCatFaceItemId;
            this.avatarIdList.Add(item:  val_18);
        }
        
        if(this.catHeadgearId == 0)
        {
                val_20 = null;
            val_20 = null;
            this.catHeadgearId = Const.DefaultCatHeadgearId;
        }
        
        if(this.catFaceItemId != 0)
        {
            goto label_36;
        }
        
        val_21 = null;
        val_21 = null;
        this.catFaceItemId = Const.DefaultCatFaceItemId;
        goto label_36;
        label_39:
        this.lastAdRewardTimeList.Add(item:  0);
        label_36:
        if(this.lastAdRewardTimeList.Count < 3)
        {
            goto label_39;
        }
        
        return;
        label_8:
        GameData.<>c.<>9__36_0 = new System.Predicate<System.Int32>(object:  GameData.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameData.<>c::<OnDeserialized>b__36_0(int id));
        if(this.avatarIdList != null)
        {
            goto label_43;
        }
        
        goto label_43;
        label_16:
        GameData.<>c.<>9__36_1 = new System.Predicate<System.Int32>(object:  GameData.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameData.<>c::<OnDeserialized>b__36_1(int id));
        if(this.avatarIdList != null)
        {
            goto label_47;
        }
        
        goto label_47;
        label_24:
        GameData.<>c.<>9__36_2 = new System.Predicate<System.Int32>(object:  GameData.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameData.<>c::<OnDeserialized>b__36_2(int id));
        if(this.avatarIdList != null)
        {
            goto label_51;
        }
        
        goto label_51;
    }
    public void PreDeserialize()
    {
        System.Collections.Generic.List<System.Int32> val_7;
        System.Collections.Generic.List<System.Int32> val_8;
        System.Collections.Generic.List<System.Int64> val_9;
        if(this.avatarIdArray != null)
        {
                val_7 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.avatarIdArray);
        }
        else
        {
                System.Collections.Generic.List<System.Int32> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Collections.Generic.List<System.Int32>();
        }
        
        this.avatarIdList = val_7;
        if(this.newAvatarIdArray != null)
        {
                val_8 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.newAvatarIdArray);
        }
        else
        {
                System.Collections.Generic.List<System.Int32> val_4 = null;
            val_8 = val_4;
            val_4 = new System.Collections.Generic.List<System.Int32>();
        }
        
        this.newAvatarIdList = val_8;
        if(this.lastAdRewardTimeArray != null)
        {
                val_9 = System.Linq.Enumerable.ToList<System.Int64>(source:  this.lastAdRewardTimeArray);
        }
        else
        {
                System.Collections.Generic.List<System.Int64> val_6 = null;
            val_9 = val_6;
            val_6 = new System.Collections.Generic.List<System.Int64>();
        }
        
        this.lastAdRewardTimeList = val_9;
    }
    private System.Collections.Generic.Dictionary<int, int> ArrayToDictionary(KeyValueOfintint[] array)
    {
        int val_2;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(array == null)
        {
                return val_1;
        }
        
        if(array.Length == 0)
        {
                return val_1;
        }
        
        if(array.Length < 1)
        {
                return val_1;
        }
        
        do
        {
            if(array[0] != null)
        {
                val_2 = array[0x0][0].Key;
        }
        else
        {
                val_2 = 11993091;
        }
        
            val_1.Add(key:  11993091, value:  array[0x0][0].Value);
        }
        while((0 + 1) < array.Length);
        
        return val_1;
    }
    public void PreSerialize()
    {
        this.avatarIdArray = this.avatarIdList.ToArray();
        this.newAvatarIdArray = this.newAvatarIdList.ToArray();
        this.lastAdRewardTimeArray = this.lastAdRewardTimeList.ToArray();
    }
    private KeyValueOfintint[] DictionaryToArray(System.Collections.Generic.Dictionary<int, int> dictionary)
    {
        var val_4;
        int val_1 = dictionary.Count;
        KeyValueOfintint[] val_2 = new KeyValueOfintint[0];
        Dictionary.Enumerator<TKey, TValue> val_3 = dictionary.GetEnumerator();
        goto label_3;
        label_8:
        new KeyValueOfintint() = new KeyValueOfintint(value:  new System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>() {Value = val_4.Id});
        val_2[0] = new KeyValueOfintint();
        label_3:
        if(((-1240096880) & 1) != 0)
        {
            goto label_8;
        }
        
        UniRx.Unit..cctor();
        return val_2;
    }
    public GameData()
    {
        var val_3;
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.beginPlayTime = val_1.dateData;
        val_3 = null;
        val_3 = null;
        this.lastPlayedVersion = Const.DefaultAppVersion;
        System.DateTime val_2 = System.DateTime.UtcNow;
        this.lastPlayTime = val_2.dateData;
        this.stage = 1;
        this.avatarId = Const.DefaultAvatarId;
        this.catId = Const.DefaultCatId;
        this.catHeadgearId = Const.DefaultCatHeadgearId;
        this.catFaceItemId = Const.DefaultCatFaceItemId;
        this.lastDailyBonusTime = System.DateTime.MinValue;
    }

}
