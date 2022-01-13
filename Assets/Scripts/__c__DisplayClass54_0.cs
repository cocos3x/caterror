using UnityEngine;
private sealed class AvatarDialogManager.<>c__DisplayClass54_0
{
    // Fields
    public GameData gameData;
    
    // Methods
    public AvatarDialogManager.<>c__DisplayClass54_0()
    {
    
    }
    internal bool <UpdateRed>b__1(AvatarData data)
    {
        GameData val_7;
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        val_7 = this;
        .data = data;
        val_8 = this.gameData.newAvatarIdList;
        if((val_8.Exists(match:  new System.Predicate<System.Int32>(object:  new AvatarDialogManager.<>c__DisplayClass54_1(), method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_1::<UpdateRed>b__8(int id)))) != false)
        {
                val_9 = 1;
            return (bool)val_9 & 1;
        }
        
        val_8 = (AvatarDialogManager.<>c__DisplayClass54_1)[1152921511859292976].data;
        if((val_8.CheckGetAvatar(gameData:  this.gameData)) != false)
        {
                val_7 = this.gameData;
            val_9 = (val_7.HasAvatar(avatarData:  (AvatarDialogManager.<>c__DisplayClass54_1)[1152921511859292976].data)) ^ 1;
            return (bool)val_9 & 1;
        }
        
        val_9 = 0;
        return (bool)val_9 & 1;
    }
    internal bool <UpdateRed>b__3(AvatarData data)
    {
        GameData val_7;
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        val_7 = this;
        .data = data;
        val_8 = this.gameData.newAvatarIdList;
        if((val_8.Exists(match:  new System.Predicate<System.Int32>(object:  new AvatarDialogManager.<>c__DisplayClass54_2(), method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_2::<UpdateRed>b__9(int id)))) != false)
        {
                val_9 = 1;
            return (bool)val_9 & 1;
        }
        
        val_8 = (AvatarDialogManager.<>c__DisplayClass54_2)[1152921511859479728].data;
        if((val_8.CheckGetAvatar(gameData:  this.gameData)) != false)
        {
                val_7 = this.gameData;
            val_9 = (val_7.HasAvatar(avatarData:  (AvatarDialogManager.<>c__DisplayClass54_2)[1152921511859479728].data)) ^ 1;
            return (bool)val_9 & 1;
        }
        
        val_9 = 0;
        return (bool)val_9 & 1;
    }
    internal bool <UpdateRed>b__5(AvatarData data)
    {
        GameData val_7;
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        val_7 = this;
        .data = data;
        val_8 = this.gameData.newAvatarIdList;
        if((val_8.Exists(match:  new System.Predicate<System.Int32>(object:  new AvatarDialogManager.<>c__DisplayClass54_3(), method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_3::<UpdateRed>b__10(int id)))) != false)
        {
                val_9 = 1;
            return (bool)val_9 & 1;
        }
        
        val_8 = (AvatarDialogManager.<>c__DisplayClass54_3)[1152921511859666480].data;
        if((val_8.CheckGetAvatar(gameData:  this.gameData)) != false)
        {
                val_7 = this.gameData;
            val_9 = (val_7.HasAvatar(avatarData:  (AvatarDialogManager.<>c__DisplayClass54_3)[1152921511859666480].data)) ^ 1;
            return (bool)val_9 & 1;
        }
        
        val_9 = 0;
        return (bool)val_9 & 1;
    }
    internal bool <UpdateRed>b__7(AvatarData data)
    {
        GameData val_7;
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        val_7 = this;
        .data = data;
        val_8 = this.gameData.newAvatarIdList;
        if((val_8.Exists(match:  new System.Predicate<System.Int32>(object:  new AvatarDialogManager.<>c__DisplayClass54_4(), method:  System.Boolean AvatarDialogManager.<>c__DisplayClass54_4::<UpdateRed>b__11(int id)))) != false)
        {
                val_9 = 1;
            return (bool)val_9 & 1;
        }
        
        val_8 = (AvatarDialogManager.<>c__DisplayClass54_4)[1152921511859853232].data;
        if((val_8.CheckGetAvatar(gameData:  this.gameData)) != false)
        {
                val_7 = this.gameData;
            val_9 = (val_7.HasAvatar(avatarData:  (AvatarDialogManager.<>c__DisplayClass54_4)[1152921511859853232].data)) ^ 1;
            return (bool)val_9 & 1;
        }
        
        val_9 = 0;
        return (bool)val_9 & 1;
    }

}
