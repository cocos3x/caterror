using UnityEngine;
private sealed class GameManager.<>c__DisplayClass81_0
{
    // Fields
    public GameData gameData;
    public GameManager <>4__this;
    public System.Action<bool> <>9__3;
    
    // Methods
    public GameManager.<>c__DisplayClass81_0()
    {
    
    }
    internal bool <CheckLoginBonus>b__1(AvatarData data)
    {
        AvatarData val_4;
        var val_5;
        val_4 = data;
        if(val_4.AcquisitionCondition == 3)
        {
                if((this.gameData.HasAvatar(avatarData:  val_4)) == false)
        {
            goto label_3;
        }
        
        }
        
        val_5 = 0;
        return (bool)(val_4 >= this.gameData.dailyLoginCount) ? 1 : 0;
        label_3:
        val_4 = data.value;
        return (bool)(val_4 >= this.gameData.dailyLoginCount) ? 1 : 0;
    }
    internal void <CheckLoginBonus>b__3(bool isAcquiredAvatar)
    {
        this.<>4__this.canvas.gameObject.SetActive(value:  true);
    }

}
