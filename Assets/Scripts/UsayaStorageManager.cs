using UnityEngine;
public class UsayaStorageManager
{
    // Fields
    private const string FileExtension = ".usaya";
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UsayaStorageManager.DataSet>> dataSetDictionary;
    
    // Methods
    private static string ToPath(UsayaStorageFilename filename)
    {
        UniRx.Unit..cctor();
        return (string)UnityEngine.Application.persistentDataPath + "/"("/") + filename.ToString() + ".usaya";
    }
    public static void Reset()
    {
        null = null;
        UsayaStorageManager.dataSetDictionary.Clear();
    }
    private static System.Collections.Generic.List<UsayaStorageManager.DataSet> GetDataSetList(UsayaStorageFilename filename)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<DataSet>> val_7;
        var val_8;
        var val_9;
        System.Collections.Generic.List<DataSet> val_10;
        var val_11;
        string val_1 = filename.ToString();
        UniRx.Unit..cctor();
        val_7 = 1152921504960946176;
        val_8 = null;
        val_8 = null;
        if((UsayaStorageManager.dataSetDictionary.ContainsKey(key:  val_1)) != false)
        {
                val_9 = null;
            val_9 = null;
            val_10 = UsayaStorageManager.dataSetDictionary.Item[val_1];
            return val_10;
        }
        
        if((UsayaStorageManager.Exists(filename:  null)) != false)
        {
                val_10 = UsayaStorageManager.LoadList(filename:  null);
        }
        else
        {
                val_10 = null;
            val_10 = new System.Collections.Generic.List<DataSet>();
        }
        
        val_11 = null;
        val_11 = null;
        val_7 = UsayaStorageManager.dataSetDictionary;
        val_7.set_Item(key:  val_1, value:  null);
        return val_10;
    }
    private static System.Collections.Generic.List<UsayaStorageManager.DataSet> SaveDataSet<T>(UsayaStorageFilename filename, string tag, T value)
    {
        var val_3;
        var val_4;
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = tag;
        System.Collections.Generic.List<DataSet> val_1 = UsayaStorageManager.GetDataSetList(filename:  filename);
        List.Enumerator<T> val_2 = val_1.GetEnumerator();
        label_6:
        if(((-1142177792) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_5 = val_4.Id;
        if((System.String.op_Equality(a:  val_5.m_stringLength, b:  val_10)) == false)
        {
            goto label_6;
        }
        
        bool val_7 = value;
        val_11 = 0;
        val_12 = 0;
        val_13 = 12;
        goto label_8;
        label_4:
        val_11 = 0;
        val_12 = 0;
        val_13 = 0;
        label_8:
        val_3 = val_4;
        val_4 = null;
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_4.Dispose();
        if( == 1)
        {
            goto label_17;
        }
        
        if(( == 0) || (77 == 77))
        {
            goto label_23;
        }
        
        label_22:
        label_23:
        if(( & 15) != 0)
        {
                return val_1;
        }
        
        bool val_9 = value;
        val_10 = val_10;
        val_1.Add(item:  val_10);
        return val_1;
        label_17:
        if( != 0)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    private static UsayaStorageManager.DataSet LoadDataSet(UsayaStorageFilename filename, string tag)
    {
        string val_5;
        var val_6;
        val_5 = tag;
        List.Enumerator<T> val_2 = UsayaStorageManager.GetDataSetList(filename:  filename).GetEnumerator();
        label_6:
        if(((-1142031928) & 1) == 0)
        {
            goto label_4;
        }
        
        val_6 = 0.Id;
        if((System.String.op_Equality(a:  val_3.m_stringLength, b:  val_5)) == false)
        {
            goto label_6;
        }
        
        goto label_7;
        label_4:
        val_6 = 0;
        label_7:
        UniRx.Unit..cctor();
        return (DataSet);
    }
    private static bool ExistsDataSet(UsayaStorageFilename filename, string tag)
    {
        var val_5;
        List.Enumerator<T> val_2 = UsayaStorageManager.GetDataSetList(filename:  filename).GetEnumerator();
        label_6:
        if(((-1141887160) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_3 = 0.Id;
        if((System.String.op_Equality(a:  val_3.m_stringLength, b:  tag)) == false)
        {
            goto label_6;
        }
        
        val_5 = 1;
        goto label_7;
        label_4:
        val_5 = 0;
        label_7:
        UniRx.Unit..cctor();
        return (bool);
    }
    public static void Save<T>(UsayaStorageFilename filename, string tag, T value)
    {
        value = value;
        UsayaStorageManager.SaveList(filename:  filename, list:  filename);
    }
    private static void SaveList(UsayaStorageFilename filename, System.Collections.Generic.List<UsayaStorageManager.DataSet> list)
    {
        var val_6;
        string val_3 = UnityEngine.JsonUtility.ToJson(obj:  new Serialization<DataSet>(target:  list));
        val_6 = 0;
        var val_6 = 0;
        val_6 = val_6 + 1;
        new System.IO.StreamWriter(path:  UsayaStorageManager.ToPath(filename:  filename), append:  false).Dispose();
        if(0 != 1)
        {
                return;
        }
        
        if(val_6 == 0)
        {
                return;
        }
    
    }
    public static T LoadOrDefault<T>(UsayaStorageFilename filename, string tag, T defaultValue)
    {
        var val_10;
        string val_11;
        UsayaStorageFilename val_12;
        val_10 = defaultValue;
        val_11 = tag;
        val_12 = filename;
        if((UsayaStorageManager.Exists(filename:  val_12, tag:  val_11)) == false)
        {
                return (bool)val_10 & 1;
        }
        
        val_11 = ???;
        val_10 = ???;
        val_12 = ???;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T Load<T>(UsayaStorageFilename filename, string tag)
    {
        if((UsayaStorageManager.LoadDataSet(filename:  filename, tag:  tag)) == null)
        {
            
        }
    
    }
    private static System.Collections.Generic.List<UsayaStorageManager.DataSet> LoadList(UsayaStorageFilename filename)
    {
        return UsayaStorageManager.SerializationToList<DataSet>(serialization:  UsayaStorageManager.Deserialize<Serialization<DataSet>>(json:  UsayaStorageManager.LoadJson(fileInfo:  new System.IO.FileInfo(fileName:  UsayaStorageManager.ToPath(filename:  filename)))));
    }
    private static string LoadJson(System.IO.FileInfo fileInfo)
    {
        var val_6;
        var val_7;
        System.IO.FileStream val_1 = fileInfo.OpenRead();
        new System.IO.StreamReader() = new System.IO.StreamReader(stream:  val_1, encoding:  System.Text.Encoding.UTF8);
        val_6 = 0;
        val_7 = 0;
        var val_6 = 0;
        val_6 = val_6 + 1;
        new System.IO.StreamReader().Dispose();
        if(val_7 == 1)
        {
                if(val_6 != 0)
        {
                val_6 = 0;
        }
        
            val_7 = 0;
        }
        
        if(val_1 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_1.Dispose();
        }
        
        if(val_7 != 1)
        {
                return (string)new System.IO.StreamReader();
        }
        
        if(val_6 == 0)
        {
                return (string)new System.IO.StreamReader();
        }
        
        return (string)new System.IO.StreamReader();
    }
    private static T Deserialize<T>(string json)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    private static System.Collections.Generic.List<T> SerializationToList<T>(Serialization<T> serialization)
    {
        if(serialization == null)
        {
            
        }
    
    }
    public static bool Exists(UsayaStorageFilename filename, string tag)
    {
        return UsayaStorageManager.ExistsDataSet(filename:  filename, tag:  tag);
    }
    public static bool Exists(UsayaStorageFilename filename)
    {
        return System.IO.File.Exists(path:  UsayaStorageManager.ToPath(filename:  filename));
    }
    public static void Remove(UsayaStorageFilename filename, string tag)
    {
        System.Collections.Generic.List<DataSet> val_1 = UsayaStorageManager.GetDataSetList(filename:  filename = filename);
        List.Enumerator<T> val_2 = val_1.GetEnumerator();
        label_6:
        if(((-1140388856) & 1) == 0)
        {
            goto label_4;
        }
        
        if((System.String.op_Equality(a:  val_3.m_stringLength, b:  tag)) == false)
        {
            goto label_6;
        }
        
        UniRx.Unit..cctor();
        bool val_5 = val_1.Remove(item:  0.Id);
        UsayaStorageManager.SaveList(filename:  filename, list:  val_1);
        return;
        label_4:
        UniRx.Unit..cctor();
    }
    public static void SaveAndBackup(UsayaStorageFilename filename, string tag, string value)
    {
        var val_2;
        string val_3;
        UsayaStorageFilename val_4;
        var val_5;
        var val_6;
        val_3 = value;
        val_4 = filename;
        UsayaStorageManager.Save<System.String>(filename:  val_4, tag:  tag, value:  val_3);
        val_6 = 0;
        UsayaStorageManager.SaveBackup(filename:  val_4, tag:  tag, value:  val_3);
        if(0 == 1)
        {
            goto label_5;
        }
        
        if((val_6 == 0) || (22 == 22))
        {
            goto label_7;
        }
        
        label_8:
        val_2 = ???;
        val_3 = ???;
        val_6 = ???;
        val_4 = ???;
        val_5 = ???;
        label_5:
        if(val_6 != 0)
        {
            goto label_8;
        }
        
        label_7:
        var val_1 = val_2 - 64;
    }
    public static void SaveBackup(UsayaStorageFilename filename, string tag, string value)
    {
        UniRx.Unit..cctor();
        UnityEngine.PlayerPrefs.SetString(key:  System.String.Format(format:  "{0}?tag={1}", arg0:  filename.ToString(), arg1:  tag), value:  value);
        UnityEngine.PlayerPrefs.Save();
    }
    public static bool ExistsBackup(UsayaStorageFilename filename, string tag)
    {
        UniRx.Unit..cctor();
        return (bool)UnityEngine.PlayerPrefs.HasKey(key:  System.String.Format(format:  "{0}?tag={1}", arg0:  filename.ToString(), arg1:  tag));
    }
    public static string LoadBackup(UsayaStorageFilename filename, string tag)
    {
        UniRx.Unit..cctor();
        return (string)UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "{0}?tag={1}", arg0:  filename.ToString(), arg1:  tag));
    }
    public static void IsDiskFull(System.Exception ex, System.Func<string> getDiskFullMessage)
    {
        int val_2 = (System.Runtime.InteropServices.Marshal.GetHRForException(e:  ex)) & 65535;
        if(val_2 != 112)
        {
                if(val_2 != 39)
        {
            goto label_4;
        }
        
        }
        
        NativeUtils.ShowAlert(title:  ex, message:  getDiskFullMessage.Invoke());
        return;
        label_4:
    }
    public static string LoadRawString(UsayaStorageFilename filename)
    {
        System.IO.StreamReader val_5 = new System.IO.StreamReader(stream:  new System.IO.FileInfo(fileName:  UsayaStorageManager.ToPath(filename:  filename)).OpenRead(), encoding:  System.Text.Encoding.UTF8);
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_5.Dispose();
        if(0 != 1)
        {
                return (string)val_5;
        }
        
        if(0 == 0)
        {
                return (string)val_5;
        }
        
        return (string)val_5;
    }
    public static void SaveRawString(UsayaStorageFilename filename, string str)
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        new System.IO.StreamWriter(path:  UsayaStorageManager.ToPath(filename:  filename), append:  false).Dispose();
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public UsayaStorageManager()
    {
    
    }
    private static UsayaStorageManager()
    {
        UsayaStorageManager.dataSetDictionary = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<DataSet>>();
    }

}
