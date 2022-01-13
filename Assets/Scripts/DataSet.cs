using UnityEngine;
[Serializable]
protected class UsayaStorageManager.DataSet
{
    // Fields
    public string tag;
    public string data;
    
    // Methods
    public static UsayaStorageManager.DataSet CreateInstance<T>(string tag, T value)
    {
        bool val_2 = value;
        return (DataSet)new UsayaStorageManager.DataSet();
    }
    public void Save<T>(string tag, T value)
    {
        this.tag = tag;
        bool val_1 = value;
        this.data = UnityEngine.JsonUtility.ToJson(obj:  __RuntimeMethodHiddenParam + 48 + 24);
    }
    public T Load<T>()
    {
        if(this.data == null)
        {
            
        }
    
    }
    public UsayaStorageManager.DataSet()
    {
    
    }

}
