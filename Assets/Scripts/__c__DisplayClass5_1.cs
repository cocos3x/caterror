using UnityEngine;
private sealed class LoginBonusListDialogManager.<>c__DisplayClass5_1
{
    // Fields
    public AvatarData avatarData;
    public LoginBonusListDialogManager.<>c__DisplayClass5_0 CS$<>8__locals1;
    
    // Methods
    public LoginBonusListDialogManager.<>c__DisplayClass5_1()
    {
    
    }
    internal void <Awake>b__3()
    {
        if((this.CS$<>8__locals1) != null)
        {
            goto label_1;
        }
        
        this.CS$<>8__locals1 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) == null)
        {
            goto label_2;
        }
        
        label_1:
        if((this.CS$<>8__locals1.<>9__4) == null)
        {
            goto label_3;
        }
        
        label_7:
        this.CS$<>8__locals1.openDetailAction.Invoke(arg1:  this.avatarData, arg2:  this.CS$<>8__locals1.<>9__4);
        return;
        label_3:
        this.CS$<>8__locals1.<>9__4 = new System.Action(object:  this.CS$<>8__locals1, method:  System.Void LoginBonusListDialogManager.<>c__DisplayClass5_0::<Awake>b__4());
        if((this.CS$<>8__locals1.openDetailAction) != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
    }

}
