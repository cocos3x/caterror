using UnityEngine;

namespace I2.Loc
{
    public class RegisterBundlesManager : MonoBehaviour, IResourceManager_Bundles
    {
        // Methods
        public void OnEnable()
        {
            I2.Loc.ResourceManager val_1 = I2.Loc.ResourceManager.pInstance;
            if((val_1.mBundleManagers.Contains(item:  this)) != false)
            {
                    return;
            }
            
            I2.Loc.ResourceManager val_3 = I2.Loc.ResourceManager.pInstance;
            val_3.mBundleManagers.Add(item:  this);
        }
        public void OnDisable()
        {
            I2.Loc.ResourceManager val_1 = I2.Loc.ResourceManager.pInstance;
            bool val_2 = val_1.mBundleManagers.Remove(item:  this);
        }
        public virtual UnityEngine.Object LoadFromBundle(string path, System.Type assetType)
        {
            return 0;
        }
        public RegisterBundlesManager()
        {
        
        }
    
    }

}
