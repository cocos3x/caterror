using UnityEngine;
public sealed class InitializeUnitySettings : MonoBehaviour
{
    // Methods
    private static void Initialize()
    {
        AnalyticsManager.Initialize();
        UnityEngine.Object.DontDestroyOnLoad(target:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "DontDestroyObject")));
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetGenericAction(action:  new System.Action(object:  0, method:  public static System.Void ApplicationExitConfirmDialogManager::ShowDialog()));
        UnityEngine.Application.targetFrameRate = 60;
    }
    public InitializeUnitySettings()
    {
    
    }

}
