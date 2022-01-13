using UnityEngine;
public sealed class AnimationEventReceiver : MonoBehaviour
{
    // Fields
    private int randomIntMin;
    private int randomIntMax;
    private AnimationEventReceiver.FilenameArray[] randomPlaySEFilenames;
    private AnimationEventReceiver.FilenameArray[] randomPlayVoiceFilenames;
    public UnityEngine.Events.UnityEvent onEvent1;
    public UnityEngine.Events.UnityEvent onEvent2;
    public UnityEngine.Events.UnityEvent onEvent3;
    private UnityEngine.Events.UnityEvent[] eventArray;
    private UnityEngine.Animator animator;
    private int randomIntHash;
    
    // Methods
    private void Awake()
    {
        this.animator = this.GetComponent<UnityEngine.Animator>();
    }
    public void OnEvent1()
    {
        this.onEvent1.Invoke();
    }
    public void OnEvent2()
    {
        this.onEvent2.Invoke();
    }
    public void OnEvent3()
    {
        this.onEvent3.Invoke();
    }
    public void OnEventArray(int index)
    {
        this.eventArray[(long)index].Invoke();
    }
    public void OnRandomInt()
    {
        this.animator.SetInteger(id:  this.randomIntHash, value:  UnityEngine.Random.Range(min:  this.randomIntMin, max:  this.randomIntMax));
    }
    public void OnPlaySE(string filename)
    {
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  filename), maxCount:  0, volume:  1f, pitch:  1f);
    }
    public void OnPlaySEMaxCount(UnityEngine.AnimationEvent animationEvent)
    {
        object val_6;
        if(animationEvent != null)
        {
                val_6 = animationEvent.stringParameter;
        }
        else
        {
                val_6 = 0.stringParameter;
        }
        
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  val_6), maxCount:  animationEvent.intParameter, volume:  1f, pitch:  1f);
    }
    public void OnPlaySEVolume(UnityEngine.AnimationEvent animationEvent)
    {
        object val_6;
        if(animationEvent != null)
        {
                val_6 = animationEvent.stringParameter;
        }
        else
        {
                val_6 = 0.stringParameter;
        }
        
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  val_6), maxCount:  0, volume:  animationEvent.floatParameter, pitch:  1f);
    }
    public void OnPlayRandomSE(int index)
    {
        if(this.randomPlaySEFilenames.Length <= index)
        {
                return;
        }
        
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  System.String.Format(format:  "Sounds/SE/{0}", arg0:  this.randomPlaySEFilenames[(long)index].GetRandom()), maxCount:  0, volume:  1f, pitch:  1f);
    }
    public void OnPlayVoice(string filename)
    {
        SingletonMonoBehaviour<SoundManager>.Instance.PlayVoice(filePath:  System.String.Format(format:  "Sounds/VOICE/{0}", arg0:  filename), maxCount:  0, volume:  1f, pitch:  1f);
    }
    public void OnPlayVoiceMaxCount(UnityEngine.AnimationEvent animationEvent)
    {
        object val_6;
        if(animationEvent != null)
        {
                val_6 = animationEvent.stringParameter;
        }
        else
        {
                val_6 = 0.stringParameter;
        }
        
        SingletonMonoBehaviour<SoundManager>.Instance.PlayVoice(filePath:  System.String.Format(format:  "Sounds/VOICE/{0}", arg0:  val_6), maxCount:  animationEvent.intParameter, volume:  1f, pitch:  1f);
    }
    public void OnPlayVoiceVolume(UnityEngine.AnimationEvent animationEvent)
    {
        object val_6;
        if(animationEvent != null)
        {
                val_6 = animationEvent.stringParameter;
        }
        else
        {
                val_6 = 0.stringParameter;
        }
        
        SingletonMonoBehaviour<SoundManager>.Instance.PlayVoice(filePath:  System.String.Format(format:  "Sounds/VOICE/{0}", arg0:  val_6), maxCount:  0, volume:  animationEvent.floatParameter, pitch:  1f);
    }
    public void OnPlayRandomVoice(int index)
    {
        if(this.randomPlayVoiceFilenames.Length <= index)
        {
                return;
        }
        
        SingletonMonoBehaviour<SoundManager>.Instance.PlayVoice(filePath:  System.String.Format(format:  "Sounds/VOICE/{0}", arg0:  this.randomPlayVoiceFilenames[(long)index].GetRandom()), maxCount:  0, volume:  1f, pitch:  1f);
    }
    public void OnPlayVibrationOnce()
    {
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationOnce();
    }
    public void OnPlayVibrationOnceStrong()
    {
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationOnceStrong();
    }
    public void OnPlayVibrationOnceWeak()
    {
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationOnceWeak();
    }
    public void OnPlayVibrationDoubleStrong()
    {
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationDoubleStrong();
    }
    public void OnPlayVibrationDoubleWeak()
    {
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationDoubleWeak();
    }
    public void OnPlayVibrationTriple()
    {
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationTriple();
    }
    public void DestroyObject()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void DisableObject()
    {
        this.gameObject.SetActive(value:  false);
    }
    public AnimationEventReceiver()
    {
        this.randomIntHash = UnityEngine.Animator.StringToHash(name:  "RandomInt");
    }

}
