using UnityEngine;
private sealed class AvatarDialogManager.<>c__DisplayClass42_1
{
    // Fields
    public bool isAdded;
    public AvatarDialogManager.<>c__DisplayClass42_0 CS$<>8__locals1;
    
    // Methods
    public AvatarDialogManager.<>c__DisplayClass42_1()
    {
    
    }
    internal void <OpenAvatarDetail>b__4(bool result)
    {
        AvatarDialogManager.<>c__DisplayClass42_0 val_1;
        GameData val_2;
        int val_3;
        AvatarDialogManager.<>c__DisplayClass42_0 val_4;
        AvatarDialogManager.<>c__DisplayClass42_0 val_5;
        if(result == false)
        {
                return;
        }
        
        val_1 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_2;
        }
        
        val_1 = this.CS$<>8__locals1;
        if(val_1 == null)
        {
            goto label_15;
        }
        
        label_2:
        this.CS$<>8__locals1.gameData.AddAvatar(avatarData:  this.CS$<>8__locals1.avatarData);
        val_2 = this.CS$<>8__locals1.gameData;
        if(val_2 != null)
        {
                val_3 = this.CS$<>8__locals1.gameData.adCount;
        }
        else
        {
                val_2 = 44;
            val_3 = 0;
        }
        
        mem[44] = 1;
        val_4 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_8;
        }
        
        val_4 = this.CS$<>8__locals1;
        if(val_4 == null)
        {
            goto label_15;
        }
        
        label_8:
        this.CS$<>8__locals1.gameData.SetRandom(isRandom:  false, category:  this.CS$<>8__locals1.<>4__this.selectedCategory);
        GameDataManager.SaveGameData();
        this.isAdded = true;
        val_5 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_14;
        }
        
        val_5 = this.CS$<>8__locals1;
        if(val_5 == null)
        {
            goto label_15;
        }
        
        label_14:
        this.CS$<>8__locals1.<>4__this.ChangeAvatar(avatarData:  this.CS$<>8__locals1.avatarData, isGacha:  false, check:  false);
        0.OnCloseDetail();
        return;
        label_15:
    }

}
