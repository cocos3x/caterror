using UnityEngine;
public sealed class AdManager : SingletonMonoBehaviour<AdManager>
{
    // Fields
    private System.Action<bool> _rewardAdCallback;
    
    // Methods
    public void ShowRewardVideo(System.Action<bool> callback, string eventName, bool showPop)
    {
        this._rewardAdCallback = callback;
        Joypac.JoypacSingleMonoBehaviour<JPRewardAd>.Instance.ShowRV(position:  eventName, success:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdManager::<ShowRewardVideo>b__1_0()), not_success:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdManager::<ShowRewardVideo>b__1_1()), showPop:  showPop);
    }
    public AdManager()
    {
    
    }
    private void <ShowRewardVideo>b__1_0()
    {
        if(this._rewardAdCallback == null)
        {
                return;
        }
        
        this._rewardAdCallback.Invoke(obj:  true);
    }
    private void <ShowRewardVideo>b__1_1()
    {
        if(this._rewardAdCallback == null)
        {
                return;
        }
        
        this._rewardAdCallback.Invoke(obj:  false);
    }

}
