using UnityEngine;
private sealed class GameManager.<>c__DisplayClass71_0
{
    // Fields
    public AvatarData avatarData;
    public GameManager <>4__this;
    public System.Action<bool> callback;
    
    // Methods
    public GameManager.<>c__DisplayClass71_0()
    {
    
    }
    internal void <GetAvatar>b__0(bool result)
    {
        AvatarData val_3;
        AvatarData val_4;
        var val_5;
        System.Func<System.Boolean> val_7;
        if(result == false)
        {
                return;
        }
        
        GameData val_1 = GameDataManager.GameData;
        if(val_1 != null)
        {
                val_1.AddAvatar(avatarData:  this.avatarData);
            val_3 = this.avatarData;
        }
        else
        {
                0.AddAvatar(avatarData:  this.avatarData);
            val_3 = this.avatarData;
        }
        
        val_1.ChangeAvatar(avatarData:  val_3);
        GameDataManager.SaveGameData();
        val_4 = this.avatarData;
        this.<>4__this.ChangeAvatar(avatarData:  val_4, isGacha:  false);
        this.<>4__this.UpdateBadge();
        if(this.callback != null)
        {
                this.callback.Invoke(obj:  true);
        }
        
        val_5 = null;
        val_5 = null;
        val_7 = GameManager.<>c.<>9__71_1;
        if(val_7 == null)
        {
                System.Func<System.Boolean> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Func<System.Boolean>(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameManager.<>c::<GetAvatar>b__71_1());
            GameManager.<>c.<>9__71_1 = val_7;
        }
        
        GetAvatarDialogManager.ShowGetDialog(avatarData:  this.avatarData, callback:  val_2);
    }

}
