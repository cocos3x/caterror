using UnityEngine;
public class ResolutionAdjustment : MonoBehaviour
{
    // Fields
    public bool isLoadOnly;
    public float offsetTime;
    public int measurementFrameCount;
    private static readonly string SavedRateTag;
    private static readonly string DefaultScreenHalfHeightTag;
    private static readonly string DefaultScreenHalfWidthTag;
    private static bool isLoadedRate;
    private bool downResolution;
    
    // Methods
    private void Start()
    {
        var val_10;
        var val_11;
        object val_12;
        var val_13;
        val_10 = null;
        val_10 = null;
        if((LocalCacheManager.Exists(tag:  ResolutionAdjustment.DefaultScreenHalfHeightTag)) != true)
        {
                val_11 = null;
            val_11 = null;
            int val_3 = UnityEngine.Screen.height >> 1;
            val_12 = val_3;
            LocalCacheManager.Save(tag:  ResolutionAdjustment.DefaultScreenHalfHeightTag, value:  val_3);
            LocalCacheManager.Save(tag:  ResolutionAdjustment.DefaultScreenHalfWidthTag, value:  UnityEngine.Screen.width >> 1);
        }
        
        if(this.isLoadOnly == true)
        {
                return;
        }
        
        this.LoadAndChangeResolution();
        val_13 = null;
        val_13 = null;
        val_12 = ResolutionAdjustment.DefaultScreenHalfHeightTag;
        if(UnityEngine.Screen.height <= (LocalCacheManager.Load<System.Int32>(tag:  val_12)))
        {
                return;
        }
        
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.Measurement());
    }
    private void LoadAndChangeResolution()
    {
        string val_3;
        var val_4;
        var val_6;
        val_4 = null;
        val_4 = null;
        if(ResolutionAdjustment.isLoadedRate == true)
        {
                return;
        }
        
        if((UsayaStorageManager.Exists(filename:  1, tag:  ResolutionAdjustment.__il2cppRuntimeField_static_fields)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_3 = ResolutionAdjustment.SavedRateTag;
        this.ChangeResolution(rate:  UsayaStorageManager.Load<System.Single>(filename:  1, tag:  val_3));
        ResolutionAdjustment.isLoadedRate = true;
    }
    private System.Collections.IEnumerator Measurement()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new ResolutionAdjustment.<Measurement>d__10();
    }
    private void ChangeResolution(float rate)
    {
        var val_7 = null;
        float val_7 = (float)UnityEngine.Screen.height;
        val_7 = val_7 * rate;
        float val_8 = (float)UnityEngine.Screen.width;
        val_8 = val_8 * rate;
        UnityEngine.Screen.SetResolution(width:  UnityEngine.Mathf.Max(a:  (int)val_8, b:  LocalCacheManager.Load<System.Int32>(tag:  ResolutionAdjustment.DefaultScreenHalfWidthTag)), height:  UnityEngine.Mathf.Max(a:  (int)val_7, b:  LocalCacheManager.Load<System.Int32>(tag:  ResolutionAdjustment.DefaultScreenHalfHeightTag)), fullscreen:  false);
    }
    private void OnDestroy()
    {
        var val_2;
        if(this.isLoadOnly != false)
        {
                this.LoadAndChangeResolution();
            return;
        }
        
        if(this.downResolution == false)
        {
                return;
        }
        
        this.ChangeResolution(rate:  0.8f);
        val_2 = null;
        val_2 = null;
        float val_1 = UsayaStorageManager.LoadOrDefault<System.Single>(filename:  1, tag:  ResolutionAdjustment.SavedRateTag, defaultValue:  1f);
        val_1 = val_1 * 0.8f;
        UsayaStorageManager.Save<System.Single>(filename:  1, tag:  ResolutionAdjustment.SavedRateTag, value:  val_1);
    }
    public ResolutionAdjustment()
    {
        this.offsetTime = 2f;
        this.measurementFrameCount = 90;
    }
    private static ResolutionAdjustment()
    {
        ResolutionAdjustment.SavedRateTag = "SavedRate";
        ResolutionAdjustment.DefaultScreenHalfHeightTag = "DefaultScreenHalfHeight";
        ResolutionAdjustment.DefaultScreenHalfWidthTag = "DefaultScreenHalfWidth";
        ResolutionAdjustment.isLoadedRate = false;
    }

}
