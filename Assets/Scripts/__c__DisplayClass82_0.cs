using UnityEngine;
private sealed class GameManager.<>c__DisplayClass82_0
{
    // Fields
    public GameData gameData;
    
    // Methods
    public GameManager.<>c__DisplayClass82_0()
    {
    
    }
    internal bool <UpdateBadge>b__0(AvatarData data)
    {
        var val_4;
        if(data.AcquisitionCondition == 3)
        {
                if(data.value <= this.gameData.dailyLoginCount)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        goto label_5;
        label_4:
        bool val_2 = this.gameData.HasAvatar(avatarData:  data);
        val_4 = val_2 ^ 1;
        label_5:
        val_2 = val_4;
        return (bool)val_2;
    }

}
