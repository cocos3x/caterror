using UnityEngine;
public class ButtonEventReceiver : MonoBehaviour
{
    // Fields
    public string onClickPlaySEFilename;
    private string[] randomPlaySEFilenames;
    private string[] randomPlayVoiceFilenames;
    private VibrationType vibrationType;
    
    // Methods
    private void Awake()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ButtonEventReceiver::<Awake>b__4_0()));
    }
    public ButtonEventReceiver()
    {
    
    }
    private void <Awake>b__4_0()
    {
        if(this.randomPlaySEFilenames.Length != 0)
        {
                SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  ArrayExtensions.RandomChoose<System.String>(array:  this.randomPlaySEFilenames)), maxCount:  0, volume:  1f, pitch:  1f);
        }
        
        if(this.randomPlayVoiceFilenames.Length != 0)
        {
                SingletonMonoBehaviour<SoundManager>.Instance.PlayVoice(filePath:  System.String.Format(format:  "Sounds/VOICE/{0}", arg0:  ArrayExtensions.RandomChoose<System.String>(array:  this.randomPlayVoiceFilenames)), maxCount:  0, volume:  1f, pitch:  1f);
        }
        
        if(this.onClickPlaySEFilename.Length >= 1)
        {
                SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  this.onClickPlaySEFilename), maxCount:  0, volume:  1f, pitch:  1f);
        }
        
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibration(vibrationType:  this.vibrationType);
    }

}
