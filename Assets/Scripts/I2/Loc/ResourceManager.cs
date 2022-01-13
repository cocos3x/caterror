using UnityEngine;

namespace I2.Loc
{
    public class ResourceManager : MonoBehaviour
    {
        // Fields
        private static I2.Loc.ResourceManager mInstance;
        public System.Collections.Generic.List<I2.Loc.IResourceManager_Bundles> mBundleManagers;
        public UnityEngine.Object[] Assets;
        private readonly System.Collections.Generic.Dictionary<string, UnityEngine.Object> mResourcesCache;
        
        // Properties
        public static I2.Loc.ResourceManager pInstance { get; }
        
        // Methods
        public static I2.Loc.ResourceManager get_pInstance()
        {
            UnityEngine.Object val_19;
            I2.Loc.ResourceManager val_20;
            val_19 = UnityEngine.Object.op_Equality(x:  I2.Loc.ResourceManager.mInstance, y:  0);
            if(I2.Loc.ResourceManager.mInstance == 0)
            {
                    if((UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null)
            {
                    val_20 = 0;
            }
            
                I2.Loc.ResourceManager.mInstance = val_20;
            }
            
            if(I2.Loc.ResourceManager.mInstance == 0)
            {
                    System.Type[] val_8 = new System.Type[1];
                val_8[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                UnityEngine.GameObject val_10 = new UnityEngine.GameObject(name:  "I2ResourceManager", components:  val_8);
                if(val_10 != null)
            {
                    val_10.hideFlags = val_10.hideFlags | 61;
            }
            else
            {
                    0.hideFlags = 0.hideFlags | 61;
            }
            
                I2.Loc.ResourceManager.mInstance = val_10.GetComponent<I2.Loc.ResourceManager>();
                UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  0, method:  public static System.Void I2.Loc.ResourceManager::MyOnLevelWasLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
            }
            
            if(val_19 == false)
            {
                    return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
            }
            
            val_19 = I2.Loc.ResourceManager.mInstance.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_19);
            return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
        }
        public static void MyOnLevelWasLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            I2.Loc.ResourceManager.pInstance.CleanResourceCache();
            bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
        }
        public T GetAsset<T>(string Name)
        {
            UnityEngine.Object val_4;
            UnityEngine.Object val_1 = this.FindAsset(Name:  Name);
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_4 = val_1;
            if(val_4 != null)
            {
                goto label_5;
            }
            
            label_4:
            val_4 = 0;
            label_5:
            if(val_4 != 0)
            {
                    return (I2.Loc.LanguageSourceAsset)val_4;
            }
            
            val_4 = this;
            return (I2.Loc.LanguageSourceAsset)val_4;
        }
        private UnityEngine.Object FindAsset(string Name)
        {
            UnityEngine.Object[] val_4;
            var val_5;
            UnityEngine.Object[] val_6;
            UnityEngine.Object val_7;
            val_4 = this.Assets;
            if((val_4 == null) || (this.Assets.Length < 1))
            {
                    return 0;
            }
            
            val_5 = 4;
            goto label_3;
            label_13:
            val_6 = this.Assets;
            val_5 = 5;
            label_3:
            val_7 = val_6[1];
            if(val_7 == 0)
            {
                goto label_8;
            }
            
            val_7 = this.Assets[1];
            if((System.String.op_Equality(a:  val_7.name, b:  Name)) == true)
            {
                goto label_12;
            }
            
            label_8:
            if((val_5 - 3) < (long)this.Assets.Length)
            {
                goto label_13;
            }
            
            return 0;
            label_12:
            UnityEngine.Object val_5 = this.Assets[1];
            return 0;
        }
        public bool HasAsset(UnityEngine.Object Obj)
        {
            UnityEngine.Object[] val_3 = this.Assets;
            if(val_3 == null)
            {
                    return (bool)val_3;
            }
            
            val_3 = ((System.Array.IndexOf<UnityEngine.Object>(array:  val_3 = this.Assets, value:  Obj)) >> 31) ^ 1;
            return (bool)val_3;
        }
        public T LoadFromResources<T>(string Path)
        {
            string val_24;
            var val_25;
            var val_26;
            var val_27;
            UnityEngine.Object val_28;
            val_24 = Path;
            UnityEngine.Object val_2 = 0;
            if((System.String.IsNullOrEmpty(value:  val_24)) != false)
            {
                    return 0;
            }
            
            if((this.mResourcesCache.TryGetValue(key:  val_24, value: out  val_2)) != false)
            {
                    if(val_2 != 0)
            {
                    if(val_2 == 0)
            {
                    return 0;
            }
            
                if(val_2 != 0)
            {
                    return 0;
            }
            
                return 0;
            }
            
            }
            
            if((val_24.EndsWith(value:  "]", comparisonType:  5)) == false)
            {
                goto label_13;
            }
            
            int val_7 = val_24.LastIndexOf(value:  "[", comparisonType:  5);
            var val_23 = -2;
            val_23 = val_23 - val_7;
            string val_12 = val_24.Substring(startIndex:  0, length:  val_7);
            if((__RuntimeMethodHiddenParam + 48 + 8) < 1)
            {
                goto label_21;
            }
            
            val_25 = (__RuntimeMethodHiddenParam + 48 + 8) & 4294967295;
            val_26 = 0;
            val_27 = val_12 + 32;
            goto label_20;
            label_25:
            val_26 = 1;
            if(val_26 >= (long)val_25)
            {
                goto label_21;
            }
            
            val_27 = val_27 + 8;
            label_20:
            if((1152921504623247360.name.Equals(value:  val_24.Substring(startIndex:  val_7 + 1, length:  val_23 + val_24.Length))) == false)
            {
                goto label_25;
            }
            
            if(val_26 < val_25)
            {
                goto label_27;
            }
            
            goto label_27;
            label_13:
            UnityEngine.Object val_16 = UnityEngine.Resources.Load(path:  val_24, systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}));
            if(val_16 == null)
            {
                goto label_32;
            }
            
            val_28 = val_16;
            if(val_28 != null)
            {
                goto label_34;
            }
            
            label_32:
            val_28 = 0;
            goto label_34;
            label_21:
            val_28 = 0;
            label_27:
            val_24 = val_12;
            label_34:
            if(val_28 == 0)
            {
                    val_28 = this;
            }
            
            if(this == 0)
            {
                    return 0;
            }
            
            this.mResourcesCache.set_Item(key:  val_24, value:  this);
            return 0;
        }
        public T LoadFromBundle<T>(string path)
        {
            var val_8;
            UnityEngine.Object val_10;
            int val_1 = this.mBundleManagers.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_8 = 0;
            label_20:
            if(this.mBundleManagers.Item[0] == null)
            {
                goto label_4;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            UnityEngine.Object val_6 = this.mBundleManagers.Item[0].LoadFromBundle(path:  path, assetType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
            if(val_6 == null)
            {
                goto label_15;
            }
            
            val_10 = val_6;
            if(val_10 != null)
            {
                goto label_16;
            }
            
            label_15:
            val_10 = 0;
            label_16:
            if(val_10 != 0)
            {
                    return (object)val_10;
            }
            
            label_4:
            val_8 = val_8 + 1;
            if(val_8 < val_1)
            {
                goto label_20;
            }
            
            label_2:
            val_10 = 0;
            return (object)val_10;
        }
        public void CleanResourceCache()
        {
            this.mResourcesCache.Clear();
            UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
            this.CancelInvoke();
        }
        public ResourceManager()
        {
            this.mBundleManagers = new System.Collections.Generic.List<I2.Loc.IResourceManager_Bundles>();
            this.mResourcesCache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer.Ordinal);
        }
    
    }

}
