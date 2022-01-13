using UnityEngine;
private sealed class JoypacAdManager.<>c__DisplayClass47_0
{
    // Fields
    public JoypacAdManager <>4__this;
    public System.Action<JoypacIntersitialStatus> callback;
    public string interId;
    
    // Methods
    public JoypacAdManager.<>c__DisplayClass47_0()
    {
    
    }
    internal void <ShowInterOnly>b__0(JoypacIntersitialStatus status)
    {
        if((status - 1) < 2)
        {
                UnityEngine.AudioListener.pause = false;
            if(this.callback != null)
        {
                this.callback.Invoke(obj:  status);
        }
        
            this.<>4__this.LoadInterstitial(interId:  this.interId);
            return;
        }
        
        if(status != 0)
        {
                return;
        }
        
        UnityEngine.AudioListener.pause = true;
        JoypacAnalyticsManager val_2 = JoypacAnalyticsManager.Instance;
        JoypacAnalyticsManager.Instance.AdjustLogEventToken(_eventToken:  "7nz1qt");
        if((JoypacUtils.GetPlayerPrefsIntByKey(_key:  "has_upload_seven_times", _defaultValue:  0)) != 0)
        {
                return;
        }
        
        this = this.<>4__this;
        if((this.IncreateVideoAndIntersitialShowCount(_video:  false)) == false)
        {
                return;
        }
        
        JoypacAnalyticsManager val_6 = JoypacAnalyticsManager.Instance;
        JoypacAnalyticsManager.Instance.AdjustLogEventToken(_eventToken:  "x15rxg");
        JoypacUtils.SavePlayerPrefsIntByKeyValue(_key:  "has_upload_seven_times", _newValue:  1);
    }

}
