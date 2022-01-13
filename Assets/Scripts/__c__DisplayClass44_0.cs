using UnityEngine;
private sealed class AvatarDialogManager.<>c__DisplayClass44_0
{
    // Fields
    public AvatarDialogManager <>4__this;
    public GameData gameData;
    public AvatarData avatarData;
    
    // Methods
    public AvatarDialogManager.<>c__DisplayClass44_0()
    {
    
    }
    internal bool <RandomChangeAvatar>b__0(AvatarData data)
    {
        var val_3;
        if(data.category == (this.<>4__this.selectedCategory))
        {
                if((this.gameData.HasAvatar(avatarData:  data)) != false)
        {
                var val_2 = (data.acquisitionCondition != 99) ? 1 : 0;
            return (bool)val_3;
        }
        
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal bool <RandomChangeAvatar>b__1(int id)
    {
        return (bool)(this.avatarData.id == id) ? 1 : 0;
    }

}
