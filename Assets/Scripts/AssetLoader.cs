using UnityEngine;
public class AssetLoader
{
    // Fields
    private string assetBundleName;
    
    // Methods
    public AssetLoader(string assetBundleName)
    {
        this.assetBundleName = assetBundleName;
    }
    public T LoadAsset<T>(string assetName)
    {
        string val_1 = System.String.Format(format:  "AssetBundle/{0}/{1}", arg0:  this.assetBundleName, arg1:  assetName);
        goto __RuntimeMethodHiddenParam + 48;
    }

}
