using UnityEngine;
private sealed class LocalNotificationManager.<>c__DisplayClass19_0
{
    // Fields
    public int loginCount;
    public GameData gameData;
    
    // Methods
    public LocalNotificationManager.<>c__DisplayClass19_0()
    {
    
    }
    internal bool <SetNotification>b__0(AvatarData data)
    {
        var val_4;
        if((data.AcquisitionCondition == 3) && (data.value == this.loginCount))
        {
                val_4 = (this.gameData.HasAvatar(avatarData:  data)) ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 0;
        return (bool)val_4 & 1;
    }

}
