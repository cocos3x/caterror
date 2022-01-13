using UnityEngine;
public sealed class GAEventManager : SingletonMonoBehaviour<GAEventManager>
{
    // Properties
    private int FinishNum { get; set; }
    private bool UpPlay10 { get; set; }
    
    // Methods
    private int get_FinishNum()
    {
        return CryptoPrefs.GetInt(key:  "FinishNum", defaultValue:  0);
    }
    private void set_FinishNum(int value)
    {
        CryptoPrefs.SetInt(key:  "FinishNum", val:  value);
    }
    private bool get_UpPlay10()
    {
        return (bool)((CryptoPrefs.GetInt(key:  "Play10", defaultValue:  0)) != 0) ? 1 : 0;
    }
    private void set_UpPlay10(bool value)
    {
        CryptoPrefs.SetInt(key:  "Play10", val:  value);
    }
    private void Awake()
    {
    
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnApplicationPause(bool isPaused)
    {
    
    }
    public void BasicPreStart()
    {
    
    }
    public void BasicStartClick()
    {
    
    }
    public void StageFinish(int stage)
    {
        UnityEngine.Debug.LogError(message:  "finish");
    }
    public void StageEnter(int stage, bool isContinue)
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Stage", type:  "enter", position:  stage.ToString(), onlyFirst:  false, extra:  "");
    }
    public void StageFail(int stage)
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Stage", type:  "fail", position:  stage.ToString(), onlyFirst:  false, extra:  "");
        this.finish(stage:  stage);
    }
    public void StageSuccess(int stage)
    {
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Stage", type:  "success", position:  stage.ToString(), onlyFirst:  false, extra:  "");
        this.finish(stage:  stage);
    }
    private void finish(int stage)
    {
        var val_8;
        JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Stage", type:  "finish", position:  stage.ToString(), onlyFirst:  false, extra:  "");
        val_8 = JoypacAnalyticsManager.Instance;
        val_8.AdjustLogEventToken(_eventToken:  "w8pdci");
        int val_3 = val_8.FinishNum;
        val_3.FinishNum = val_3 + 1;
        int val_5 = val_3.FinishNum;
        if(val_5 < 10)
        {
                return;
        }
        
        bool val_6 = val_5.UpPlay10;
        if(val_6 == true)
        {
                return;
        }
        
        val_6.UpPlay10 = true;
        val_8 = JoypacAnalyticsManager.Instance;
        val_8.AdjustLogEventToken(_eventToken:  "8ipxp4");
    }
    public void UserClickSkinList()
    {
    
    }
    public void UserClickUnlock()
    {
    
    }
    public void AdClickGold()
    {
    
    }
    public void AdImpressionSkin()
    {
    
    }
    public void AdClickSkin()
    {
    
    }
    public void AdClickSkinUnlock()
    {
    
    }
    public GAEventManager()
    {
    
    }

}
