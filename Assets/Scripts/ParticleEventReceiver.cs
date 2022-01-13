using UnityEngine;
public class ParticleEventReceiver : MonoBehaviour
{
    // Fields
    private UnityEngine.Events.UnityEvent onEnd;
    private float interval;
    private UnityEngine.Coroutine coroutine;
    
    // Properties
    public UnityEngine.Events.UnityEvent OnEnd { get; }
    public float Interval { get; }
    
    // Methods
    public UnityEngine.Events.UnityEvent get_OnEnd()
    {
        return (UnityEngine.Events.UnityEvent)this.onEnd;
    }
    public float get_Interval()
    {
        return (float)this.interval;
    }
    private void Awake()
    {
        bool val_3 = TransformExtensions.FindComponent<UnityEngine.ParticleSystem>(t:  this.transform, func:  new System.Action<UnityEngine.ParticleSystem>(object:  this, method:  System.Void ParticleEventReceiver::UpdateInterval(UnityEngine.ParticleSystem ps)));
        bool val_6 = TransformExtensions.FindAllChildrensComponent<UnityEngine.ParticleSystem>(t:  this.transform, func:  new System.Action<UnityEngine.ParticleSystem>(object:  this, method:  System.Void ParticleEventReceiver::UpdateInterval(UnityEngine.ParticleSystem ps)));
    }
    private void UpdateInterval(UnityEngine.ParticleSystem ps)
    {
        UnityEngine.AnimationCurve val_3;
        MainModule val_1 = ps.main;
        MinMaxCurve val_2 = val_1.m_ParticleSystem.startLifetime;
        if(val_3.glyphIndex > 3)
        {
                return;
        }
        
        var val_31 = 28872076 + (val_5) << 2;
        val_31 = val_31 + 28872076;
        goto (28872076 + (val_5) << 2 + 28872076);
    }
    private void OnEnable()
    {
        this.coroutine = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  this.interval, act:  new System.Action(object:  this.onEnd, method:  public System.Void UnityEngine.Events.UnityEvent::Invoke()));
    }
    private void OnDisable()
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
    }
    public ParticleEventReceiver()
    {
    
    }

}
