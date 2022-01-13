using UnityEngine;
private sealed class GameManager.<>c__DisplayClass86_0
{
    // Fields
    public GameData gameData;
    
    // Methods
    public GameManager.<>c__DisplayClass86_0()
    {
    
    }
    internal bool <Red>b__0(AvatarData data)
    {
        GameData val_7;
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        val_7 = this;
        .data = data;
        val_8 = this.gameData.newAvatarIdList;
        if((val_8.Exists(match:  new System.Predicate<System.Int32>(object:  new GameManager.<>c__DisplayClass86_1(), method:  System.Boolean GameManager.<>c__DisplayClass86_1::<Red>b__1(int id)))) != false)
        {
                val_9 = 1;
            return (bool)val_9 & 1;
        }
        
        val_8 = (GameManager.<>c__DisplayClass86_1)[1152921511923505664].data;
        if((val_8.CheckGetAvatar(gameData:  this.gameData)) != false)
        {
                val_7 = this.gameData;
            val_9 = (val_7.HasAvatar(avatarData:  (GameManager.<>c__DisplayClass86_1)[1152921511923505664].data)) ^ 1;
            return (bool)val_9 & 1;
        }
        
        val_9 = 0;
        return (bool)val_9 & 1;
    }

}
