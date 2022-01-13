using UnityEngine;
public sealed class GachaGirl : MonoBehaviour
{
    // Fields
    private float girlMoveDistance;
    private float girlMoveSpeed;
    private UnityEngine.Transform avatarPivot;
    private bool isRunning;
    
    // Methods
    private void Awake()
    {
        var val_14;
        GachaGirl.<>c__DisplayClass4_0 val_1 = new GachaGirl.<>c__DisplayClass4_0();
        .<>4__this = this;
        .gameData = GameDataManager.GameData;
        val_14 = null;
        val_14 = null;
        UnityEngine.Animator val_8 = UnityEngine.Object.Instantiate<UnityEngine.Animator>(original:  SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).Find(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean GachaGirl.<>c__DisplayClass4_0::<Awake>b__0(AvatarData data))).GetPrefab(), parent:  this.avatarPivot);
        .animator = val_8;
        val_8.SetBool(name:  "IsRunning", value:  true);
        .transform = (GachaGirl.<>c__DisplayClass4_0)[1152921511865378384].animator.transform;
        this.isRunning = true;
        UnityEngine.Coroutine val_13 = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  this.girlMoveSpeed / this.girlMoveDistance, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void GachaGirl.<>c__DisplayClass4_0::<Awake>b__1(float t)), callback:  new System.Action(object:  val_1, method:  System.Void GachaGirl.<>c__DisplayClass4_0::<Awake>b__2()));
    }
    private void Update()
    {
        var val_8;
        string val_9;
        val_8 = this;
        if(this.isRunning == false)
        {
                return;
        }
        
        val_8 = this.avatarPivot.gameObject;
        if(val_8.activeInHierarchy == false)
        {
                return;
        }
        
        if(UnityEngine.Time.timeScale <= 0f)
        {
                return;
        }
        
        if((UnityEngine.Time.frameCount & 15) == 0)
        {
            goto label_6;
        }
        
        int val_6 = UnityEngine.Time.frameCount;
        if((val_6 & 7) == 0)
        {
            goto label_7;
        }
        
        return;
        label_6:
        val_9 = "b";
        goto label_8;
        label_7:
        val_9 = "a";
        label_8:
        val_6.PlayRunSE(suffix:  val_9);
    }
    private void PlayRunSE(string suffix)
    {
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationOnceWeak();
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  "se_n_run_" + suffix, maxCount:  0, volume:  1f, pitch:  1f);
    }
    public GachaGirl()
    {
        this.girlMoveDistance = 3f;
        this.girlMoveSpeed = 5f;
    }

}
