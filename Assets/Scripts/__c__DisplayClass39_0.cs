using UnityEngine;
private sealed class AvatarDialogManager.<>c__DisplayClass39_0
{
    // Fields
    public AvatarData avatarData;
    public AvatarDialogManager <>4__this;
    public GameData gameData;
    public System.Action <>9__5;
    
    // Methods
    public AvatarDialogManager.<>c__DisplayClass39_0()
    {
    
    }
    internal bool <InitializeNode>b__0(int id)
    {
        return (bool)(this.avatarData.id == id) ? 1 : 0;
    }
    internal void <InitializeNode>b__1()
    {
        this.<>4__this.SelectAvatar(avatarData:  this.avatarData, isGacha:  false);
    }
    internal void <InitializeNode>b__2()
    {
        AvatarDialogManager.<>c__DisplayClass39_1 val_1 = new AvatarDialogManager.<>c__DisplayClass39_1();
        if(val_1 != null)
        {
                .CS$<>8__locals1 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .isAdded = false;
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardVideo(callback:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void AvatarDialogManager.<>c__DisplayClass39_1::<InitializeNode>b__4(bool result)), eventName:  "Shop", showPop:  true);
    }
    internal void <InitializeNode>b__3()
    {
        BackButtonManager val_1 = SingletonMonoBehaviour<BackButtonManager>.Instance;
        if((this.<>9__5) == null)
        {
            goto label_1;
        }
        
        label_5:
        val_1.SetAction(action:  this.<>9__5);
        this.<>4__this.OpenAvatarDetail(avatarData:  this.avatarData);
        return;
        label_1:
        this.<>9__5 = new System.Action(object:  this, method:  System.Void AvatarDialogManager.<>c__DisplayClass39_0::<InitializeNode>b__5());
        if(val_1 != null)
        {
            goto label_5;
        }
        
        goto label_5;
    }
    internal void <InitializeNode>b__5()
    {
        AvatarDialogManager val_7;
        var val_8;
        int val_8 = this.<>4__this.GetSortedAvatarDataList().IndexOf(item:  this.<>4__this.detailAvatarData);
        val_7 = this.<>4__this;
        if((this.<>4__this) == null)
        {
                val_7 = this.<>4__this;
        }
        
        AvatarCategory val_7 = this.<>4__this.selectedCategory;
        val_8 = null;
        val_7 = val_7 - 3;
        val_8 = null;
        val_8 = val_8 - ((val_7 < 2) ? 1 : 0);
        this.<>4__this.lastPage = val_8 / AvatarDialogManager.MaxNodeCount;
        this.<>4__this.InstantiateNodes();
        this.<>4__this.detailPageScrollRect.gameObject.SetActive(value:  false);
        this.<>4__this.listPageScrollRect.gameObject.SetActive(value:  true);
    }

}
