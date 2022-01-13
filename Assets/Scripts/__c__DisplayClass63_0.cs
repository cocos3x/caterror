using UnityEngine;
private sealed class GameManager.<>c__DisplayClass63_0
{
    // Fields
    public GameManager <>4__this;
    public int stage;
    public AvatarData avatarData;
    public System.Action<bool> <>9__5;
    public System.Action<JoypacIntersitialStatus> <>9__6;
    
    // Methods
    public GameManager.<>c__DisplayClass63_0()
    {
    
    }
    internal void <Result>b__2()
    {
        this.<>4__this.resultRewardPanel.SetActive(value:  true);
    }
    internal void <Result>b__3()
    {
        SingletonMonoBehaviour<GAEventManager>.Instance.AdClickGold();
        AdManager val_2 = SingletonMonoBehaviour<AdManager>.Instance;
        if((this.<>9__5) == null)
        {
            goto label_2;
        }
        
        label_5:
        val_2.ShowRewardVideo(callback:  this.<>9__5, eventName:  "Gold", showPop:  false);
        return;
        label_2:
        this.<>9__5 = new System.Action<System.Boolean>(object:  this, method:  System.Void GameManager.<>c__DisplayClass63_0::<Result>b__5(bool result));
        if(val_2 != null)
        {
            goto label_5;
        }
        
        goto label_5;
    }
    internal void <Result>b__5(bool result)
    {
        var val_1;
        AvatarData val_2;
        int val_3;
        var val_4;
        if(result != false)
        {
                val_1 = null;
            val_1 = null;
            val_2 = this.avatarData;
            val_3 = this.stage;
            val_4 = Const.ResultAdRewardMagnification;
        }
        else
        {
                val_2 = this.avatarData;
            val_4 = 1;
            val_3 = this.stage;
        }
        
        this.<>4__this.ResultReward(stage:  val_3, magnification:  1, avatarData:  val_2);
    }
    internal void <Result>b__4()
    {
        JoypacAdManager val_1 = JoypacAdManager.Instance;
        if((this.<>9__6) == null)
        {
            goto label_3;
        }
        
        label_6:
        val_1.ShowInterstitial(callback:  this.<>9__6, interId:  "hidegpIV");
        return;
        label_3:
        this.<>9__6 = new System.Action<JoypacIntersitialStatus>(object:  this, method:  System.Void GameManager.<>c__DisplayClass63_0::<Result>b__6(JoypacIntersitialStatus status));
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_6;
    }
    internal void <Result>b__6(JoypacIntersitialStatus status)
    {
        if(status == 0)
        {
                return;
        }
        
        this.<>4__this.ResultReward(stage:  this.stage, magnification:  1, avatarData:  this.avatarData);
    }

}
