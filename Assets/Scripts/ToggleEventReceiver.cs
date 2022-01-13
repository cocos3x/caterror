using UnityEngine;
public class ToggleEventReceiver : MonoBehaviour
{
    // Fields
    public string onClickPlaySEFilename;
    private VibrationType vibrationType;
    
    // Methods
    private void Awake()
    {
        UnityEngine.UI.Toggle val_1 = this.GetComponent<UnityEngine.UI.Toggle>();
        val_1.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void ToggleEventReceiver::<Awake>b__2_0(bool result)));
    }
    public ToggleEventReceiver()
    {
    
    }
    private void <Awake>b__2_0(bool result)
    {
        if(result == false)
        {
                return;
        }
        
        SoundManager val_1 = SingletonMonoBehaviour<SoundManager>.Instance;
        val_1.PlaySE(clip:  val_1.LoadAudioClip(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  this.onClickPlaySEFilename), soundType:  1), maxCount:  0, volume:  1f, pitch:  1f);
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibration(vibrationType:  this.vibrationType);
    }

}
