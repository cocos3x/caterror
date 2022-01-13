using UnityEngine;
private sealed class GameManager.<>c__DisplayClass65_1
{
    // Fields
    public System.Action<bool> resultCallback;
    public GameManager.<>c__DisplayClass65_0 CS$<>8__locals1;
    
    // Methods
    public GameManager.<>c__DisplayClass65_1()
    {
    
    }
    internal void <GetAvatar>b__2(bool result)
    {
        GameManager.<>c__DisplayClass65_0 val_2;
        if(result == false)
        {
                return;
        }
        
        this.CS$<>8__locals1.isGetAvatar = true;
        GameData val_1 = GameDataManager.GameData;
        val_1.AddAvatar(avatarData:  this.CS$<>8__locals1.avatarData);
        val_1.ChangeAvatar(avatarData:  this.CS$<>8__locals1.avatarData);
        GameDataManager.SaveGameData();
        val_2 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_9;
        }
        
        val_2 = this.CS$<>8__locals1;
        if(val_2 == null)
        {
            goto label_10;
        }
        
        label_9:
        this.CS$<>8__locals1.<>4__this.ChangeAvatar(avatarData:  this.CS$<>8__locals1.avatarData, isGacha:  false);
        this.CS$<>8__locals1.<>4__this.UpdateBadge();
        this.resultCallback.Invoke(obj:  true);
        return;
        label_10:
    }

}
