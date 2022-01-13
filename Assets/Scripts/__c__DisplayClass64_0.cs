using UnityEngine;
private sealed class GameManager.<>c__DisplayClass64_0
{
    // Fields
    public GameManager <>4__this;
    public AvatarData avatarData;
    public System.Action<bool> <>9__1;
    
    // Methods
    public GameManager.<>c__DisplayClass64_0()
    {
    
    }
    internal void <ResultReward>b__0()
    {
        System.Action<System.Boolean> val_4;
        this.<>4__this.resultAdRewardEffect = 0;
        this.<>4__this.resultRewardEffect = 0;
        if(this.avatarData != null)
        {
                val_4 = this.<>9__1;
            if(val_4 == null)
        {
                System.Action<System.Boolean> val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action<System.Boolean>(object:  this, method:  System.Void GameManager.<>c__DisplayClass64_0::<ResultReward>b__1(bool isAcquiredAvatar));
            this.<>9__1 = val_4;
        }
        
            this.<>4__this.GetAvatar(avatarData:  this.avatarData, isNextTransition:  ((this.<>4__this.isOwnPresentBox) != true) ? 1 : 0, callback:  val_1, event_str:  "Present");
            return;
        }
        
        this.<>4__this.CheckPresentBox(isNextTransition:  true, callback:  new System.Action<System.Boolean>(object:  this.<>4__this, method:  System.Void GameManager::TransitionToMain(bool isAcquiredAvatar)));
    }
    internal void <ResultReward>b__1(bool isAcquiredAvatar)
    {
        GameManager.<>c__DisplayClass64_1 val_1 = new GameManager.<>c__DisplayClass64_1();
        if(val_1 != null)
        {
                .CS$<>8__locals1 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .isAcquiredAvatar = isAcquiredAvatar;
        this.<>4__this.CheckPresentBox(isNextTransition:  true, callback:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass64_1::<ResultReward>b__2(bool isAcquiredPresent)));
    }

}
