using UnityEngine;
public class SliderEventReceiver : MonoBehaviour
{
    // Fields
    public string onClickPlaySEFilename;
    
    // Methods
    private void Awake()
    {
        this.GetComponent<UnityEngine.UI.Slider>().onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SliderEventReceiver::<Awake>b__1_0(float value)));
    }
    public SliderEventReceiver()
    {
    
    }
    private void <Awake>b__1_0(float value)
    {
        SoundManager val_1 = SingletonMonoBehaviour<SoundManager>.Instance;
        val_1.PlaySE(clip:  val_1.LoadAudioClip(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  this.onClickPlaySEFilename), soundType:  1), maxCount:  0, volume:  1f, pitch:  1f);
    }

}
