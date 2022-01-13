using UnityEngine;
private sealed class GetAvatarDialogManager.<>c__DisplayClass17_0
{
    // Fields
    public AvatarData avatarData;
    public System.Func<bool> callback;
    
    // Methods
    public GetAvatarDialogManager.<>c__DisplayClass17_0()
    {
    
    }
    internal void <ShowGetDialog>b__0()
    {
        null = null;
        LocalCacheManager.Save(tag:  GetAvatarDialogManager.IsGetTag, value:  true);
        LocalCacheManager.Save(tag:  GetAvatarDialogManager.AvatarDataTag, value:  this.avatarData);
        LocalCacheManager.Save(tag:  GetAvatarDialogManager.CallbackTag, value:  this.callback);
        SingletonMonoBehaviour<TransitionManager>.Instance.LoadSceneAdditive(scene:  5, sceneType:  0);
    }

}
