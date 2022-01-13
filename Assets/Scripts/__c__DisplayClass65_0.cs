using UnityEngine;
private sealed class GameManager.<>c__DisplayClass65_0
{
    // Fields
    public bool isGetAvatar;
    public AvatarData avatarData;
    public GameManager <>4__this;
    public string event_str;
    public System.Action<bool> callback;
    public bool isNextTransition;
    
    // Methods
    public GameManager.<>c__DisplayClass65_0()
    {
    
    }
    internal void <GetAvatar>b__0(System.Action<bool> resultCallback)
    {
        GameManager.<>c__DisplayClass65_1 val_1 = new GameManager.<>c__DisplayClass65_1();
        if(val_1 != null)
        {
                .CS$<>8__locals1 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .resultCallback = resultCallback;
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardVideo(callback:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void GameManager.<>c__DisplayClass65_1::<GetAvatar>b__2(bool result)), eventName:  this.event_str, showPop:  true);
    }
    internal bool <GetAvatar>b__1()
    {
        this.callback.Invoke(obj:  (this.isGetAvatar == true) ? 1 : 0);
        return (bool)this.isNextTransition;
    }

}
