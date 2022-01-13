using UnityEngine;
public sealed class ParticleDisabler : MonoBehaviour
{
    // Fields
    private float interval;
    
    // Methods
    private void Awake()
    {
        bool val_3 = TransformExtensions.FindComponent<UnityEngine.ParticleSystem>(t:  this.transform, func:  new System.Action<UnityEngine.ParticleSystem>(object:  this, method:  System.Void ParticleDisabler::<Awake>b__1_0(UnityEngine.ParticleSystem ps)));
        bool val_6 = TransformExtensions.FindAllChildrensComponent<UnityEngine.ParticleSystem>(t:  this.transform, func:  new System.Action<UnityEngine.ParticleSystem>(object:  this, method:  System.Void ParticleDisabler::<Awake>b__1_1(UnityEngine.ParticleSystem ps)));
    }
    private void UpdateInterval(UnityEngine.ParticleSystem ps)
    {
        UnityEngine.AnimationCurve val_4;
        float val_46;
        float val_48;
        val_46 = 0;
        MainModule val_1 = ps.main;
        MinMaxCurve val_2 = val_1.m_ParticleSystem.startLifetime;
        if(val_4.glyphIndex > 3)
        {
            goto label_2;
        }
        
        var val_46 = 28872044 + (val_5) << 2;
        val_46 = val_46 + 28872044;
        goto (28872044 + (val_5) << 2 + 28872044);
        label_2:
        val_48 = 0f;
        TrailModule val_26 = ps.trails;
        if(val_26.m_ParticleSystem.enabled == false)
        {
            goto label_20;
        }
        
        TrailModule val_28 = ps.trails;
        if(val_4.glyphIndex > 3)
        {
            goto label_22;
        }
        
        var val_47 = 28872060 + (val_29) << 2;
        val_47 = val_47 + 28872060;
        goto (28872060 + (val_29) << 2 + 28872060);
        label_22:
        val_46 = 0f;
        val_48 =  + ;
        label_20:
        MainModule val_43 = ps.main;
        float val_44 = val_43.m_ParticleSystem.duration;
        val_44 = val_48 + val_44;
        this.interval = UnityEngine.Mathf.Max(a:  val_44, b:  this.interval);
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  this.interval, act:  new System.Action(object:  this, method:  System.Void ParticleDisabler::<OnEnable>b__3_0()));
    }
    public ParticleDisabler()
    {
    
    }
    private void <Awake>b__1_0(UnityEngine.ParticleSystem ps)
    {
        this.UpdateInterval(ps:  ps);
    }
    private void <Awake>b__1_1(UnityEngine.ParticleSystem ps)
    {
        this.UpdateInterval(ps:  ps);
    }
    private void <OnEnable>b__3_0()
    {
        this.gameObject.SetActive(value:  false);
    }

}
