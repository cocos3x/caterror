using UnityEngine;
public class UmengAndroidLifeCycleCallBack : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.transform.gameObject);
    }
    private void OnApplicationPause(bool isPause)
    {
        if(isPause != false)
        {
                Umeng.Analytics.onPause();
            return;
        }
        
        Umeng.Analytics.onResume();
    }
    private void OnApplicationQuit()
    {
        Umeng.Analytics.onKillProcess();
    }
    public UmengAndroidLifeCycleCallBack()
    {
    
    }

}
