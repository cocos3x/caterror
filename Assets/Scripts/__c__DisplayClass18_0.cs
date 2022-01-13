using UnityEngine;
private sealed class FadeManager.<>c__DisplayClass18_0
{
    // Fields
    public string sceneName;
    
    // Methods
    public FadeManager.<>c__DisplayClass18_0()
    {
    
    }
    internal void <FadeOutToTransition>b__0()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.sceneName);
    }

}
