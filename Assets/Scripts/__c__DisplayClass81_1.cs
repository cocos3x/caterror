using UnityEngine;
private sealed class GameManager.<>c__DisplayClass81_1
{
    // Fields
    public AvatarData avatarData;
    public GameManager.<>c__DisplayClass81_0 CS$<>8__locals1;
    
    // Methods
    public GameManager.<>c__DisplayClass81_1()
    {
    
    }
    internal void <CheckLoginBonus>b__2()
    {
        if(this.avatarData.value > (this.CS$<>8__locals1.gameData.dailyLoginCount))
        {
                this.CS$<>8__locals1.<>4__this.canvas.gameObject.SetActive(value:  true);
            return;
        }
        
        if((this.CS$<>8__locals1.<>9__3) == null)
        {
            goto label_10;
        }
        
        if((this.CS$<>8__locals1.<>4__this) != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this.CS$<>8__locals1.<>4__this.GetAvatar(avatarData:  this.avatarData, isNextTransition:  false, callback:  this.CS$<>8__locals1.<>9__3, event_str:  "SignInReward");
        return;
        label_10:
        this.CS$<>8__locals1.<>9__3 = new System.Action<System.Boolean>(object:  this.CS$<>8__locals1, method:  System.Void GameManager.<>c__DisplayClass81_0::<CheckLoginBonus>b__3(bool isAcquiredAvatar));
        if((this.CS$<>8__locals1.<>4__this) != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }

}
