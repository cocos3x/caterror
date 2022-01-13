using UnityEngine;
private sealed class GameManager.<>c__DisplayClass75_0
{
    // Fields
    public GameData gameData;
    
    // Methods
    public GameManager.<>c__DisplayClass75_0()
    {
    
    }
    internal bool <TransitionToMain>b__0(AvatarData data)
    {
        int val_1 = data.id;
        if(val_1 == this.gameData.avatarId)
        {
                return false;
        }
        
        val_1 = data.id;
        if(val_1 == this.gameData.catId)
        {
                return false;
        }
        
        val_1 = data.id;
        if(val_1 == this.gameData.catHeadgearId)
        {
                return false;
        }
        
        val_1 = data.id;
        if(val_1 == this.gameData.catFaceItemId)
        {
                return false;
        }
        
        if(this.gameData != null)
        {
                return this.gameData.HasAvatar(avatarData:  data);
        }
        
        return this.gameData.HasAvatar(avatarData:  data);
    }

}
