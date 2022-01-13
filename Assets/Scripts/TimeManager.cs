using UnityEngine;
public sealed class TimeManager : JoypacSingleMonoBehaviour<TimeManager>
{
    // Fields
    private float defaultTimeScale;
    private float defaultFixedDeltaTime;
    
    // Methods
    private void Awake()
    {
        this.defaultTimeScale = UnityEngine.Time.timeScale;
        this.defaultFixedDeltaTime = UnityEngine.Time.fixedDeltaTime;
    }
    public void ChangeTimeScale(float timeScale)
    {
        UnityEngine.Time.timeScale = timeScale;
        float val_1 = this.defaultFixedDeltaTime;
        val_1 = val_1 * timeScale;
        UnityEngine.Time.fixedDeltaTime = val_1;
    }
    public void Reset()
    {
        UnityEngine.Debug.Log(message:  "Time:Reset to "("Time:Reset to ") + this.defaultFixedDeltaTime);
        UnityEngine.Time.fixedDeltaTime = this.defaultFixedDeltaTime;
        UnityEngine.Time.timeScale = this.defaultTimeScale;
    }
    public void Stop()
    {
        UnityEngine.Debug.Log(message:  "Time:stop");
        UnityEngine.Time.timeScale = 0f;
    }
    public TimeManager()
    {
    
    }

}
