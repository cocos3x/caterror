using UnityEngine;
[Serializable]
public class AssetBundleLoader.AssetBundleLoadPack
{
    // Fields
    public string assetName;
    public UnityEngine.GameObject[] targetObjects;
    public AssetBundleLoader.TargetAssetType targetAssetType;
    
    // Methods
    public AssetBundleLoader.AssetBundleLoadPack()
    {
        this.targetObjects = new UnityEngine.GameObject[1];
    }

}
