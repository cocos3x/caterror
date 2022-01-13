using UnityEngine;
public sealed class Girl : MonoBehaviour
{
    // Fields
    private ParticleDestroyer getCoinEffectPrefab;
    private ParticleDestroyer getAvatarEffectPrefab;
    private ParticleDestroyer presentEffectPrefab;
    private UnityEngine.Transform avatarPivot;
    private UnityEngine.ParticleSystem dashEffect;
    private UnityEngine.ParticleSystem defaultRunningEffect;
    private UnityEngine.ParticleSystem slowRunningEffect;
    private UnityEngine.ParticleSystem slipRunningEffect;
    private GameManager gameManager;
    private UnityEngine.Animator animator;
    private bool isBeganRun;
    private bool isBeFounding;
    private int stage;
    private UnityEngine.Rect rect;
    private bool isRunning;
    private float floorMoveSpeed;
    private bool isSlipping;
    private float moveSpeedMagnification;
    private bool isFound;
    private UnityEngine.Coroutine dashCoroutine;
    private SwitchFloor switchFloor;
    private GirlEffectState effectState;
    
    // Properties
    public bool IsBeFounding { get; }
    public bool IsRunning { get; }
    public float FloorMoveSpeed { get; }
    public bool IsSlipping { get; }
    public float MoveSpeedMagnification { get; }
    public bool IsDash { get; }
    private GirlEffectState GirlEffectState { get; }
    
    // Methods
    public bool get_IsBeFounding()
    {
        return (bool)this.isBeFounding;
    }
    public bool get_IsRunning()
    {
        return (bool)this.isRunning;
    }
    public float get_FloorMoveSpeed()
    {
        return (float)this.floorMoveSpeed;
    }
    public bool get_IsSlipping()
    {
        return (bool)this.isSlipping;
    }
    public float get_MoveSpeedMagnification()
    {
        return (float)this.moveSpeedMagnification;
    }
    public bool get_IsDash()
    {
        return (bool)(this.dashCoroutine != 0) ? 1 : 0;
    }
    private GirlEffectState get_GirlEffectState()
    {
        if(this.isSlipping != false)
        {
                return 1;
        }
        
        if(this.moveSpeedMagnification < 0)
        {
                return 2;
        }
        
        if(this.moveSpeedMagnification <= 1f)
        {
                return (GirlEffectState)((this.dashCoroutine != 0) ? 1 : 0) << 2;
        }
        
        return 3;
    }
    public void Initialize(GameManager gameManager, int stage)
    {
        this.gameManager = gameManager;
        this.stage = stage;
    }
    public void ChangeAvatar()
    {
        var val_7;
        .gameData = GameDataManager.GameData;
        val_7 = null;
        val_7 = null;
        this.ChangeAvatar(avatarData:  SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).Find(match:  new System.Predicate<AvatarData>(object:  new Girl.<>c__DisplayClass37_0(), method:  System.Boolean Girl.<>c__DisplayClass37_0::<ChangeAvatar>b__0(AvatarData data))), isGacha:  false);
    }
    public void ChangeAvatar(AvatarData avatarData, bool isGacha = False)
    {
        UnityEngine.Animator val_11;
        TransformExtensions.DestroyAllChildrens(t:  this.avatarPivot);
        val_11 = UnityEngine.Object.Instantiate<UnityEngine.Animator>(original:  avatarData.GetPrefab(), parent:  this.avatarPivot);
        this.animator = val_11;
        if(this.avatarPivot.childCount != 0)
        {
                val_11.SetTrigger(name:  "ChangeAvatar");
            val_11 = this.animator;
        }
        
        AnimationEventReceiver val_5 = val_11.transform.GetComponent<AnimationEventReceiver>();
        val_5.onEvent1.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void Girl::OnEndBeFound()));
        if(isGacha == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.avatarPivot.position;
        UnityEngine.Vector3 val_8 = Vector3Extensions.AddY(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, f:  0.5f);
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        ParticleDestroyer val_10 = UnityEngine.Object.Instantiate<ParticleDestroyer>(original:  this.getAvatarEffectPrefab, position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
    }
    private void Update()
    {
        string val_7;
        if(this.isRunning == false)
        {
                return;
        }
        
        if(UnityEngine.Time.timeScale <= 0f)
        {
                return;
        }
        
        int val_2 = UnityEngine.Time.frameCount;
        var val_7 = 16;
        var val_3 = (this.dashCoroutine != 0) ? 8 : (val_7);
        val_7 = val_2 / val_3;
        val_3 = val_2 - (val_7 * val_3);
        if(val_3 == 0)
        {
            goto label_3;
        }
        
        int val_4 = UnityEngine.Time.frameCount;
        var val_5 = (this.dashCoroutine != 0) ? 4 : 8;
        val_5 = val_4 - ((val_4 / val_5) * val_5);
        if(val_5 == 0)
        {
            goto label_4;
        }
        
        return;
        label_3:
        val_7 = "b";
        goto label_5;
        label_4:
        val_7 = "a";
        label_5:
        this.PlayRunSE(suffix:  val_7);
    }
    private void PlayRunSE(string suffix)
    {
        var val_5;
        var val_6;
        string val_7;
        SingletonMonoBehaviour<VibrationManager>.Instance.PlayVibrationOnceWeak();
        if(this.isSlipping != false)
        {
                val_5 = SingletonMonoBehaviour<SoundManager>.Instance;
            val_6 = "se_slip_";
        }
        else
        {
                val_5 = SingletonMonoBehaviour<SoundManager>.Instance;
            if(this.moveSpeedMagnification < 0)
        {
                val_7 = "se_honey_";
        }
        else
        {
                val_7 = "se_n_run_";
        }
        
        }
        
        val_5.PlaySE(filePath:  val_7 + suffix, maxCount:  0, volume:  1f, pitch:  1f);
    }
    public void Continue()
    {
        this.animator.SetTrigger(name:  "ChangeAvatar");
    }
    public void BeginRun()
    {
        this.animator.SetBool(name:  "IsRunning", value:  true);
        this.isBeganRun = true;
        this.isRunning = true;
        this.ShowRunningEffect();
    }
    public void ShowRunningEffect()
    {
        if(this.isRunning == false)
        {
                return;
        }
        
        if(this.isSlipping == false)
        {
            goto label_1;
        }
        
        if(this.slipRunningEffect != null)
        {
            goto label_7;
        }
        
        label_8:
        label_7:
        this.slipRunningEffect.gameObject.SetActive(value:  true);
        return;
        label_1:
        if(this.moveSpeedMagnification >= 0)
        {
            goto label_4;
        }
        
        if(this.slowRunningEffect != null)
        {
            goto label_7;
        }
        
        goto label_8;
        label_4:
        if(this.defaultRunningEffect != null)
        {
            goto label_7;
        }
        
        goto label_8;
    }
    private void HideRunningEffect()
    {
        this.slipRunningEffect.gameObject.SetActive(value:  false);
        this.slowRunningEffect.gameObject.SetActive(value:  false);
        this.defaultRunningEffect.gameObject.SetActive(value:  false);
    }
    public void Hide()
    {
        this.animator.SetBool(name:  "IsRunning", value:  false);
        this.isRunning = false;
        if(this.switchFloor != 0)
        {
                this.switchFloor.Push();
            this.switchFloor = 0;
        }
        
        this.HideRunningEffect();
    }
    public void Found()
    {
        this.isFound = true;
        this.animator.SetTrigger(name:  "BeFound");
        this.isRunning = false;
        this.ResetAllFloorGimmick();
        this.HideRunningEffect();
    }
    public void Goal()
    {
        this.animator.SetTrigger(name:  "Goal");
        this.isRunning = false;
        this.HideRunningEffect();
    }
    public void OnEndBeFound()
    {
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  "se_escape", maxCount:  0, volume:  1f, pitch:  1f);
        UnityEngine.Vector3 val_4 = this.transform.localScale;
        TransformExtensions.SetLocalScaleX(t:  this.transform, f:  -val_4.x);
        UnityEngine.Coroutine val_6 = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  1f, act:  new System.Action<System.Single>(object:  this, method:  System.Void Girl::<OnEndBeFound>b__48_0(float t)));
        this.ShowRunningEffect();
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collider)
    {
        float val_43;
        var val_45;
        System.Action<Coin> val_47;
        var val_48;
        System.Action<Coin> val_50;
        if(this.isFound != false)
        {
                return;
        }
        
        FloorGimmick val_2 = collider.transform.GetComponent<FloorGimmick>();
        if(((val_2 != null) && (val_2 != 0)) && (null == null))
        {
                this.floorMoveSpeed = val_2.MoveSpeed;
        }
        
        if(this.isBeganRun == false)
        {
                return;
        }
        
        if(val_2 == 0)
        {
            goto label_33;
        }
        
        if(val_2 == null)
        {
            goto label_16;
        }
        
        if(null == null)
        {
            goto label_14;
        }
        
        if((val_2 != null) && (this.isSlipping != true))
        {
                if(null == null)
        {
            goto label_17;
        }
        
        }
        
        label_16:
        val_43 = this.moveSpeedMagnification;
        if(val_43 != 1f)
        {
            goto label_18;
        }
        
        if(val_2 == null)
        {
            goto label_33;
        }
        
        if(null != null)
        {
            goto label_20;
        }
        
        this.moveSpeedMagnification = val_2.DashSpeedMagnification;
        this.animator.speed = 2f;
        if(this.dashEffect.gameObject.activeInHierarchy == false)
        {
            goto label_25;
        }
        
        this.dashEffect.Play(withChildren:  true);
        goto label_26;
        label_18:
        if(val_2 == null)
        {
            goto label_33;
        }
        
        label_20:
        if(val_2.IsPushed == false)
        {
            goto label_30;
        }
        
        val_43 = this.moveSpeedMagnification;
        if(((val_2 == null) || (val_43 != 1f)) || (null != null))
        {
            goto label_33;
        }
        
        this.moveSpeedMagnification = val_2.SpeedMagnification;
        goto label_34;
        label_14:
        this.floorMoveSpeed = val_2.MoveSpeed;
        label_33:
        if(collider != null)
        {
            goto label_86;
        }
        
        label_87:
        label_86:
        if((collider.gameObject.name.Contains(value:  "Coin")) != false)
        {
                UnityEngine.Vector3 val_16 = this.transform.position;
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<ParticleDestroyer>(original:  this.getCoinEffectPrefab, position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, rotation:  new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w}).SetCallback(callback:  new System.Action(object:  this, method:  System.Void Girl::<OnTriggerStay2D>b__49_1()));
            val_45 = null;
            val_45 = null;
            val_47 = Girl.<>c.<>9__49_2;
            if(val_47 == null)
        {
                System.Action<Coin> val_21 = null;
            val_47 = val_21;
            val_21 = new System.Action<Coin>(object:  Girl.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Girl.<>c::<OnTriggerStay2D>b__49_2(Coin coin));
            Girl.<>c.<>9__49_2 = val_47;
        }
        
            if((TransformExtensions.FindComponent<Coin>(t:  collider.transform, func:  val_21)) == true)
        {
                return;
        }
        
            val_48 = null;
            val_48 = null;
            val_50 = Girl.<>c.<>9__49_3;
            if(val_50 == null)
        {
                System.Action<Coin> val_24 = null;
            val_50 = val_24;
            val_24 = new System.Action<Coin>(object:  Girl.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Girl.<>c::<OnTriggerStay2D>b__49_3(Coin coin));
            Girl.<>c.<>9__49_3 = val_50;
        }
        
            bool val_25 = TransformExtensions.FindParentsComponent<Coin>(t:  collider.transform, func:  val_24);
            return;
        }
        
        if((collider.gameObject.name.Contains(value:  "Present")) != false)
        {
                this.GetPresentBox(present:  collider.transform);
        }
        
        CatActionTrigger val_31 = collider.gameObject.GetComponent<CatActionTrigger>();
        if(val_31 != 0)
        {
                this.gameManager.BeginCatAction(catActionTrigger:  val_31);
            return;
        }
        
        CatCancelTrigger val_34 = collider.gameObject.GetComponent<CatCancelTrigger>();
        if(val_34 != 0)
        {
                this.gameManager.CancelCatAction(catCancelTrigger:  val_34);
            return;
        }
        
        DogActionTrigger val_37 = collider.gameObject.GetComponent<DogActionTrigger>();
        if(val_37 == 0)
        {
                return;
        }
        
        this.gameManager.ShowDog(dogActionTrigger:  val_37);
        return;
        label_17:
        this.isSlipping = true;
        label_34:
        this.HideRunningEffect();
        this.ShowRunningEffect();
        if(collider != null)
        {
            goto label_86;
        }
        
        goto label_87;
        label_25:
        this.dashEffect.gameObject.SetActive(value:  true);
        label_26:
        this.dashCoroutine = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  val_2.DashTime, act:  new System.Action(object:  this, method:  System.Void Girl::<OnTriggerStay2D>b__49_0()));
        if(collider != null)
        {
            goto label_86;
        }
        
        goto label_87;
        label_30:
        this.switchFloor = val_2;
        if(collider != null)
        {
            goto label_86;
        }
        
        goto label_87;
    }
    private void GetPresentBox(UnityEngine.Transform present)
    {
        UnityEngine.Vector3 val_1 = present.position;
        this.gameManager.GetPresentBox(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_2 = present.position;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        ParticleDestroyer val_4 = UnityEngine.Object.Instantiate<ParticleDestroyer>(original:  this.presentEffectPrefab, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        UnityEngine.Object.Destroy(obj:  present.gameObject);
    }
    private void OnTriggerExit2D(UnityEngine.Collider2D collider)
    {
        if(this.isFound != false)
        {
                return;
        }
        
        FloorGimmick val_2 = collider.transform.GetComponent<FloorGimmick>();
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        if(null == null)
        {
            goto label_8;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        if(null != null)
        {
                return;
        }
        
        this.moveSpeedMagnification = 1f;
        goto label_13;
        label_8:
        this.floorMoveSpeed = 0f;
        return;
        label_9:
        this.isSlipping = false;
        label_13:
        this.HideRunningEffect();
        this.ShowRunningEffect();
    }
    private void ResetAllFloorGimmick()
    {
        this.floorMoveSpeed = 0f;
        this.isSlipping = false;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.dashCoroutine);
        this.dashCoroutine = 0;
        this.moveSpeedMagnification = 1f;
        this.animator.speed = 1f;
        this.dashEffect.Stop(withChildren:  true, stopBehavior:  1);
        this.switchFloor = 0;
    }
    private void OnEnterLight2D(Light2D.Light2DBase light)
    {
        this.isBeFounding = true;
    }
    private void OnExitLight2D(Light2D.Light2DBase light)
    {
        this.isBeFounding = false;
    }
    public Girl()
    {
        this.rect = 0;
        mem[1152921511927574388] = 0;
        mem[1152921511927574396] = 0;
        this.moveSpeedMagnification = 1f;
    }
    private void <OnEndBeFound>b__48_0(float t)
    {
        TransformExtensions.SetPositionX(t:  this.transform, f:  UnityEngine.Mathf.Lerp(a:  0f, b:  -20f, t:  t));
    }
    private void <OnTriggerStay2D>b__49_0()
    {
        this.dashCoroutine = 0;
        this.moveSpeedMagnification = 1f;
        this.animator.speed = 1f;
        this.dashEffect.Stop(withChildren:  true, stopBehavior:  1);
    }
    private void <OnTriggerStay2D>b__49_1()
    {
        int val_1 = GameLogic.CalcStageCoin(stage:  this.stage);
        CoinManager val_2 = SingletonMonoBehaviour<CoinManager>.Instance;
        if(val_1 == 1)
        {
                val_2.AddCoin();
            return;
        }
        
        val_2.AddCoin(coin:  val_1);
    }

}
