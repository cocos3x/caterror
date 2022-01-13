using UnityEngine;
public class AssetBundleManager : SingletonMonoBehaviour<AssetBundleManager>
{
    // Methods
    private void Awake()
    {
        bool val_1 = this.CheckInstance();
    }
    public void LoadAsset(string assetBundleName, System.Action<AssetLoader> action)
    {
        .assetBundleName = assetBundleName;
        action.Invoke(obj:  new AssetLoader());
    }
    public AssetBundleManager()
    {
    
    }

}
