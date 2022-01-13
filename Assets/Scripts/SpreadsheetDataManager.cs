using UnityEngine;
public sealed class SpreadsheetDataManager : SingletonMonoBehaviour<SpreadsheetDataManager>
{
    // Fields
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<object>> dataDictionary;
    private string downloadDate;
    
    // Properties
    public string DownloadDateString { get; }
    
    // Methods
    public string get_DownloadDateString()
    {
        return (string)this.downloadDate;
    }
    private void Awake()
    {
        bool val_1 = this.CheckInstance();
        if(val_1 == true)
        {
                return;
        }
        
        this.downloadDate = val_1.LoadData(assetName:  "DownloadDate");
    }
    public bool LoadAndCache<T>(string worksheetName)
    {
        this.dataDictionary.set_Item(key:  worksheetName, value:  System.Linq.Enumerable.ToList<System.Object>(source:  JsonHelper.GetJsonArray(json:  this.LoadData(assetName:  worksheetName), typeName:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}))));
        if(this.dataDictionary != null)
        {
                return this.dataDictionary.ContainsKey(key:  worksheetName);
        }
        
        return this.dataDictionary.ContainsKey(key:  worksheetName);
    }
    public bool ExistsDataList(string worksheetName)
    {
        if(this.dataDictionary != null)
        {
                return this.dataDictionary.ContainsKey(key:  worksheetName);
        }
        
        return this.dataDictionary.ContainsKey(key:  worksheetName);
    }
    public System.Collections.Generic.List<T> GetBaseDataList<T>(string worksheetName)
    {
        bool val_1 = this.ExistsDataList(worksheetName:  worksheetName);
        System.Collections.Generic.List<System.Object> val_2 = this.dataDictionary.Item[worksheetName];
        goto __RuntimeMethodHiddenParam + 48 + 16;
    }
    private string LoadData(string assetName)
    {
        return AvoEx.AesEncryptor.DecryptString(encrypted:  UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "Data/"("Data/") + assetName).text);
    }
    private string LoadDecryptData(string assetName)
    {
        return AvoEx.AesEncryptor.Encrypt(unencrypted:  UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "DecryptData/"("DecryptData/") + assetName).text);
    }
    public SpreadsheetDataManager()
    {
        this.dataDictionary = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Object>>();
    }

}
