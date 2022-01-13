using UnityEngine;
public static class GameDataManager
{
    // Fields
    private static GameData dataCache;
    
    // Properties
    public static GameData GameData { get; }
    public static bool IsLoaded { get; }
    
    // Methods
    public static GameData get_GameData()
    {
        var val_2;
        GameData val_3;
        val_2 = null;
        val_2 = null;
        val_3 = GameDataManager.dataCache;
        if(val_3 != null)
        {
                return val_3;
        }
        
        val_3 = GameDataManager.LoadGameData();
        GameDataManager.dataCache = val_3;
        return val_3;
    }
    public static bool get_IsLoaded()
    {
        null = null;
        return (bool)(GameDataManager.dataCache != 0) ? 1 : 0;
    }
    public static bool ExistsGameData()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UsayaStorageManager.Exists(filename:  0, tag:  Const.GameDataTag)) != false)
        {
                return true;
        }
        
        val_3 = null;
        val_3 = null;
        return UsayaStorageManager.ExistsBackup(filename:  0, tag:  Const.GameDataTag);
    }
    private static GameData LoadGameData()
    {
        var val_8;
        var val_9;
        var val_10;
        LoadState val_11;
        val_8 = null;
        val_8 = null;
        if((UsayaStorageManager.Exists(filename:  0, tag:  Const.GameDataTag)) != false)
        {
                val_9 = null;
            val_9 = null;
            val_10 = GameDataManager.StringToGameData(str:  UsayaStorageManager.Load<System.String>(filename:  0, tag:  Const.GameDataTag));
            val_11 = 4;
        }
        else
        {
                val_11 = 0;
            val_10 = 0;
        }
        
        if(val_11 == 4)
        {
                if(0 >= val_4.stage)
        {
            goto label_18;
        }
        
        }
        
        val_10 = GameDataManager.LoadGameDataBackup(mainLoadState:  val_11);
        label_18:
        if(0 == 1)
        {
            goto label_19;
        }
        
        if((0 == 0) || (79 == 79))
        {
            goto label_26;
        }
        
        label_25:
        label_26:
        val_10.OnDeserialized();
        if((StringExtensions.CompareVersion(a:  UnityEngine.Application.version, b:  val_4.lastPlayedVersion)) == 0)
        {
                return (GameData)val_10;
        }
        
        val_4.lastPlayedVersion = UnityEngine.Application.version;
        return (GameData)val_10;
        label_19:
        if(0 != 0)
        {
            goto label_25;
        }
        
        goto label_26;
    }
    private static GameData LoadGameDataBackup(GameDataManager.LoadState mainLoadState)
    {
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if((UsayaStorageManager.ExistsBackup(filename:  0, tag:  Const.GameDataTag)) != false)
        {
                val_6 = null;
            val_6 = null;
            val_7 = UsayaStorageManager.LoadBackup(filename:  0, tag:  Const.GameDataTag);
            val_8 = GameDataManager.StringToGameData(str:  val_7);
            return (GameData)val_8;
        }
        
        val_7 = 0;
        val_8 = GameDataManager.CreateData();
        if(0 != 1)
        {
                return (GameData)val_8;
        }
        
        if(val_7 == 0)
        {
                return (GameData)val_8;
        }
        
        return (GameData)val_8;
    }
    private static GameData CreateData()
    {
        .lastPlayedVersion = UnityEngine.Application.version;
        return (GameData)new GameData();
    }
    public static bool OverWriteGameData(string dataString)
    {
        GameDataManager.dataCache = GameDataManager.StringToGameData(str:  dataString);
        return true;
    }
    public static void SaveGameData()
    {
        var val_4;
        string val_5;
        var val_6;
        var val_7;
        var val_8;
        string val_9;
        val_5 = GameDataManager.GameDataToString(data:  GameDataManager.GameData);
        val_6 = null;
        val_6 = null;
        UsayaStorageManager.Save<System.String>(filename:  0, tag:  Const.GameDataTag, value:  val_5);
        val_7 = 0;
        val_8 = null;
        val_8 = null;
        val_9 = Const.GameDataTag;
        UsayaStorageManager.SaveBackup(filename:  0, tag:  val_9, value:  val_5);
        if(0 == 1)
        {
            goto label_11;
        }
        
        if((val_7 == 0) || (66 == 66))
        {
            goto label_13;
        }
        
        label_14:
        val_4 = ???;
        val_7 = ???;
        val_5 = ???;
        val_9 = ???;
        label_11:
        if(val_7 != 0)
        {
            goto label_14;
        }
        
        label_13:
        var val_3 = val_4 - 48;
    }
    public static string GetGameDataString()
    {
        return GameDataManager.GameDataToString(data:  GameDataManager.GameData);
    }
    private static string GameDataToString(GameData data)
    {
        data.PreSerialize();
        return AvoEx.AesEncryptor.Encrypt(unencrypted:  StringExtensions.DataToXML<GameData>(data:  data, isShorten:  true).Replace(oldValue:  "KeyValueOfintint", newValue:  "KVOii").Replace(oldValue:  "KeyValueOfintlong", newValue:  "KVOil").Replace(oldValue:  "KeyValueOfintInfiniteFloat", newValue:  "KVOiIF"));
    }
    private static GameData StringToGameData(string str)
    {
        return StringExtensions.XMLToData<GameData>(xml:  AvoEx.AesEncryptor.DecryptString(encrypted:  str).Replace(oldValue:  "KVOii", newValue:  "KeyValueOfintint").Replace(oldValue:  "KVOil", newValue:  "KeyValueOfintlong").Replace(oldValue:  "KVOiIF", newValue:  "KeyValueOfintInfiniteFloat"));
    }
    private static GameDataManager()
    {
    
    }

}
