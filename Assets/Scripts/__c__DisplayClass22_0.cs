using UnityEngine;
private sealed class SettingsDialogManager.<>c__DisplayClass22_0
{
    // Fields
    public System.Action callback;
    
    // Methods
    public SettingsDialogManager.<>c__DisplayClass22_0()
    {
    
    }
    internal void <ShowDialog>b__0()
    {
        null = null;
        LocalCacheManager.Save(tag:  SettingsDialogManager.CallbackTag, value:  this.callback);
        SingletonMonoBehaviour<TransitionManager>.Instance.LoadSceneAdditive(scene:  11, sceneType:  0);
    }

}
