using UnityEngine;
public class JoypacManager : MonoBehaviour
{
    // Fields
    private bool showFps;
    private bool logFlg;
    
    // Methods
    private void Awake()
    {
        bool val_12;
        UnityEngine.Debug.Log(message:  "joypac manager init");
        val_12 = true;
        this.logFlg = val_12;
        if(this.showFps != false)
        {
                Joypac.JoypacSingleMonoBehaviour<FpsManager>.Instance.Init();
            val_12 = this.logFlg;
        }
        
        LogTool.Init(_logFlg:  (val_12 == true) ? 1 : 0);
        JoypacAnalyticsManager.Instance.Init();
        JoypacAdManager.Instance.Init();
        JoypacAnalyticsManager.DesignEvent(_logType:  48, sort:  "Basic", type:  "pre_start", position:  "pre_start", onlyFirst:  false, extra:  "");
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        if((SingletonMonoBehaviour<LanguageManager>.Instance.GetDeviceLanguageDataType()) > 3)
        {
                return;
        }
        
        var val_12 = 28872728 + (val_7) << 2;
        val_12 = val_12 + 28872728;
        goto (28872728 + (val_7) << 2 + 28872728);
    }
    private System.Collections.IEnumerator CrossEnumerator()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new JoypacManager.<CrossEnumerator>d__3();
    }
    public JoypacManager()
    {
    
    }

}
