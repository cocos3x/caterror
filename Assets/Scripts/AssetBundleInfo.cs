using UnityEngine;
[Serializable]
public class AssetBundleLoader.AssetBundleInfo
{
    // Fields
    public string assetBundlePath;
    public AssetBundleLoader.AssetBundleLoadPack[] loadPacks;
    public AssetBundleLoader.AssetBundlePrefabPack[] prefabPacks;
    
    // Methods
    public AssetBundleLoader.AssetBundleInfo()
    {
        this.loadPacks = new AssetBundleLoader.AssetBundleLoadPack[1];
        this.prefabPacks = new AssetBundleLoader.AssetBundlePrefabPack[0];
    }

}
