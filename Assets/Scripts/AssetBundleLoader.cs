using UnityEngine;
public class AssetBundleLoader : MonoBehaviour
{
    // Fields
    public AssetBundleLoader.AssetBundleInfo[] assetBundleInfos;
    
    // Methods
    private void Awake()
    {
        object val_4;
        var val_5;
        val_4 = this;
        val_5 = 0;
        goto label_1;
        label_8:
        AssetBundleLoader.<>c__DisplayClass7_0 val_1 = null;
        val_4 = val_1;
        val_1 = new AssetBundleLoader.<>c__DisplayClass7_0();
        .info = this.assetBundleInfos[0];
        AssetBundleManager val_2 = SingletonMonoBehaviour<AssetBundleManager>.Instance;
        0.LoadAsset(assetBundleName:  (AssetBundleLoader.<>c__DisplayClass7_0)[1152921512088632880].info.assetBundlePath, action:  new System.Action<AssetLoader>(object:  val_1, method:  System.Void AssetBundleLoader.<>c__DisplayClass7_0::<Awake>b__0(AssetLoader assetLoader)));
        val_5 = 1;
        label_1:
        if(val_5 < this.assetBundleInfos.Length)
        {
            goto label_8;
        }
    
    }
    public AssetBundleLoader()
    {
        this.assetBundleInfos = new AssetBundleInfo[1];
    }

}
