using UnityEngine;
public class ParticleDestroyer : MonoBehaviour
{
    // Fields
    private System.Action callback;
    
    // Methods
    private void Start()
    {
        ParticleDestroyer.<>c__DisplayClass1_0 val_1 = new ParticleDestroyer.<>c__DisplayClass1_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .lifetime = 0f;
        bool val_4 = TransformExtensions.FindComponent<UnityEngine.ParticleSystem>(t:  this.transform, func:  new System.Action<UnityEngine.ParticleSystem>(object:  val_1, method:  System.Void ParticleDestroyer.<>c__DisplayClass1_0::<Start>b__0(UnityEngine.ParticleSystem ps)));
        bool val_7 = TransformExtensions.FindAllChildrensComponent<UnityEngine.ParticleSystem>(t:  this.transform, func:  new System.Action<UnityEngine.ParticleSystem>(object:  val_1, method:  System.Void ParticleDestroyer.<>c__DisplayClass1_0::<Start>b__1(UnityEngine.ParticleSystem ps)));
        UnityEngine.Coroutine val_9 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  (ParticleDestroyer.<>c__DisplayClass1_0)[1152921512108400320].lifetime, act:  new System.Action(object:  val_1, method:  System.Void ParticleDestroyer.<>c__DisplayClass1_0::<Start>b__2()));
    }
    private float GetLifeTime(UnityEngine.ParticleSystem ps)
    {
        UnityEngine.AnimationCurve val_3;
        UnityEngine.AnimationCurve val_55;
        float val_56;
        float val_58;
        float val_60;
        val_56 = 0;
        MainModule val_1 = ps.main;
        MinMaxCurve val_2 = val_1.m_ParticleSystem.startLifetime;
        if(val_3.glyphIndex > 3)
        {
            goto label_2;
        }
        
        var val_55 = 28872012 + (val_5) << 2;
        val_55 = val_55 + 28872012;
        goto (28872012 + (val_5) << 2 + 28872012);
        label_2:
        val_58 = 0f;
        TrailModule val_26 = ps.trails;
        if(val_26.m_ParticleSystem.enabled == false)
        {
            goto label_20;
        }
        
        TrailModule val_28 = ps.trails;
        if(val_3.glyphIndex > 3)
        {
            goto label_22;
        }
        
        var val_56 = 28872028 + (val_29) << 2;
        val_56 = val_56 + 28872028;
        goto (28872028 + (val_29) << 2 + 28872028);
        label_22:
        val_56 = 0f;
        val_58 =  + ;
        label_20:
        MainModule val_43 = ps.main;
        float val_44 = val_43.m_ParticleSystem.duration;
        val_60 = val_58 + val_44;
        SubEmittersModule val_45 = ps.subEmitters;
        if(val_45.m_ParticleSystem.enabled == false)
        {
                return (float)val_60;
        }
        
        val_55 = 0;
        goto label_41;
        label_53:
        SubEmittersModule val_47 = ps.subEmitters;
        if((-1088157920) == 2)
        {
            goto label_43;
        }
        
        if(val_47.m_ParticleSystem != 0)
        {
            goto label_49;
        }
        
        SubEmittersModule val_48 = ps.subEmitters;
        UnityEngine.ParticleSystem val_49 = val_48.m_ParticleSystem.GetSubEmitterSystem(index:  0);
        val_60 = UnityEngine.Mathf.Max(a:  val_44, b:  val_60);
        goto label_49;
        label_43:
        SubEmittersModule val_51 = ps.subEmitters;
        UnityEngine.ParticleSystem val_52 = val_51.m_ParticleSystem.GetSubEmitterSystem(index:  0);
        val_60 = val_60 + val_44;
        label_49:
        val_55 = 1;
        label_41:
        SubEmittersModule val_53 = ps.subEmitters;
        if(val_55 < val_53.m_ParticleSystem.subEmittersCount)
        {
            goto label_53;
        }
        
        return (float)val_60;
    }
    public void SetCallback(System.Action callback)
    {
        this.callback = callback;
    }
    public ParticleDestroyer()
    {
        null = null;
        this.callback = ActionExtensions.EmptyAction;
    }

}
