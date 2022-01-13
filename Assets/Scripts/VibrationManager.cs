using UnityEngine;
public class VibrationManager : SingletonMonoBehaviour<VibrationManager>
{
    // Fields
    private bool isEnable;
    
    // Properties
    public bool IsEnable { get; }
    
    // Methods
    public bool get_IsEnable()
    {
        return (bool)this.isEnable;
    }
    private void Awake()
    {
        var val_4;
        if(this.CheckInstance() == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        this.isEnable = UsayaStorageManager.LoadOrDefault<System.Boolean>(filename:  1, tag:  Const.VibrationTag, defaultValue:  true);
    }
    public void SaveEnable(bool enable)
    {
        null = null;
        bool val_1 = enable;
        UsayaStorageManager.Save<System.Boolean>(filename:  1, tag:  Const.VibrationTag, value:  val_1);
        this.isEnable = val_1;
    }
    public void PlayVibrationOnce()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        NativeUtils.PlayVibrationOnce();
    }
    public void PlayVibrationOnceStrong()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        NativeUtils.PlayVibrationOnceStrong();
    }
    public void PlayVibrationOnceWeak()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        NativeUtils.PlayVibrationOnceWeak();
    }
    public void PlayVibrationDoubleStrong()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        NativeUtils.PlayVibrationDoubleStrong();
    }
    public void PlayVibrationDoubleWeak()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        NativeUtils.PlayVibrationDoubleWeak();
    }
    public void PlayVibrationTriple()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        NativeUtils.PlayVibrationTriple();
    }
    public void PlayVibration(VibrationType vibrationType)
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        NativeUtils.PlayVibration(vibrationType:  vibrationType);
    }
    public VibrationManager()
    {
        this.isEnable = true;
    }

}
