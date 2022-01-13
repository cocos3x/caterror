using UnityEngine;
public sealed class Cat : SingletonMonoBehaviour<Cat>
{
    // Fields
    private float lightSEIntervalMin;
    private float lightSEIntervalMax;
    private float handsSwitchPositionY;
    private float hidePositionY;
    private float searchPositionY;
    private float lightMaskDistance;
    private float moveEyeLimit;
    private float moveEyeLimitAngle;
    private float lightAngleMagnification;
    private UnityEngine.GameObject hideObject;
    private UnityEngine.GameObject searchObject;
    private UnityEngine.GameObject questionObject;
    private UnityEngine.GameObject foundObject;
    private UnityEngine.Animator handsAnimator;
    private UnityEngine.Transform catBody;
    private Light2D.Light2DBase light2DBase;
    private Light2D.Light2DBase eventLight2DBase;
    private UnityEngine.Transform lightMask;
    private UnityEngine.Transform lightUnder;
    private UnityEngine.Animator tailAnimator;
    private UnityEngine.Transform[] headgearPivotArray;
    private UnityEngine.Transform[] faceItemPivotArray;
    private UnityEngine.Transform blackEyes;
    private UnityEngine.Transform lightMaskLeft;
    private UnityEngine.Transform lightMaskRight;
    private CatState catState;
    private UnityEngine.Coroutine coroutine;
    private bool isEnableLight;
    private float lightSETimer;
    private float lightSEInterval;
    private System.Action notFoundAction;
    private float tempHidePositionY;
    private float tempPositionY;
    private bool isFirstHide;
    private float findAngle;
    private System.Action cancelAction;
    private float defaultLightMaskAngle;
    
    // Properties
    public bool IsSearching { get; }
    public float FindAngle { get; set; }
    
    // Methods
    public bool get_IsSearching()
    {
        return (bool)(this.catState == 2) ? 1 : 0;
    }
    public float get_FindAngle()
    {
        return (float)this.findAngle;
    }
    public void set_FindAngle(float value)
    {
        this.findAngle = value;
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_3 = this.light2DBase.transform.position;
        this.eventLight2DBase.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_5 = this.lightMaskRight.GetChild(index:  0).eulerAngles;
        this.defaultLightMaskAngle = val_5.z;
    }
    public void ChangeHeadgear(AvatarData avatarData)
    {
        UnityEngine.Transform val_3;
        goto label_1;
        label_7:
        UnityEngine.Transform val_3 = this.headgearPivotArray[0];
        TransformExtensions.DestroyAllChildrens(t:  val_3);
        val_3 = avatarData.GetCatHeadgearPrefab();
        UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_3, parent:  val_3);
        0 = 1;
        label_1:
        if(0 < this.headgearPivotArray.Length)
        {
            goto label_7;
        }
    
    }
    public void ChangeFaceItem(AvatarData avatarData)
    {
        UnityEngine.Transform val_3;
        goto label_1;
        label_7:
        UnityEngine.Transform val_3 = this.faceItemPivotArray[0];
        TransformExtensions.DestroyAllChildrens(t:  val_3);
        val_3 = avatarData.GetCatFaceItemPrefab();
        UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_3, parent:  val_3);
        0 = 1;
        label_1:
        if(0 < this.faceItemPivotArray.Length)
        {
            goto label_7;
        }
    
    }
    public void FirstHide(System.Action notFoundAction, System.Action callback)
    {
        Cat.<>c__DisplayClass45_0 val_1 = new Cat.<>c__DisplayClass45_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        this.notFoundAction = notFoundAction;
        this.coroutine = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  0.5f, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void Cat.<>c__DisplayClass45_0::<FirstHide>b__0(float t)), callback:  new System.Action(object:  val_1, method:  System.Void Cat.<>c__DisplayClass45_0::<FirstHide>b__1()));
    }
    public void ImmediateHide()
    {
        TransformExtensions.SetPositionY(t:  this.catBody, f:  this.hidePositionY);
        this.isFirstHide = false;
    }
    private void Update()
    {
        TransformExtensions.SetEulerAnglesZ(t:  this.lightMaskLeft, f:  -this.findAngle);
        TransformExtensions.SetEulerAnglesZ(t:  this.lightMaskRight, f:  -this.findAngle);
        float val_13 = System.Math.Abs(this.findAngle);
        val_13 = 90f - val_13;
        float val_2 = UnityEngine.Mathf.Lerp(a:  0f, b:  this.defaultLightMaskAngle, t:  val_13 / 90f);
        float val_3 = this.findAngle * 0.01745329f;
        TransformExtensions.SetLocalEulerAnglesZ(t:  this.lightMaskLeft.GetChild(index:  0), f:  -val_2);
        TransformExtensions.SetLocalEulerAnglesZ(t:  this.lightMaskRight.GetChild(index:  0), f:  val_2);
        float val_14 = val_3;
        val_14 = this.lightMaskDistance * val_14;
        TransformExtensions.SetPositionX(t:  this.lightMask, f:  val_14);
        TransformExtensions.SetEulerAnglesZ(t:  this.lightMask, f:  -this.findAngle);
        float val_15 = System.Math.Abs(this.findAngle);
        val_15 = val_15 * (-0.6f);
        val_15 = val_15 + 90f;
        val_15 = val_15 * 0.15f;
        val_15 = val_15 / 90f;
        TransformExtensions.SetLocalScaleX(t:  this.lightMask, f:  val_15);
        float val_16 = val_3;
        val_16 = val_16 + val_16;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_16, y:  2f);
        val_16 = val_16 * (-0.62f);
        val_16 = val_16 * 0.5f;
        TransformExtensions.SetLocalScaleY(t:  this.lightMask, f:  val_16);
        float val_17 = -this.findAngle;
        val_17 = val_17 / this.moveEyeLimitAngle;
        val_17 = val_17 * this.moveEyeLimit;
        TransformExtensions.SetLocalPositionX(t:  this.blackEyes, f:  val_17);
        if(this.handsAnimator.gameObject.activeInHierarchy != false)
        {
                UnityEngine.Vector3 val_9 = this.catBody.position;
            this.handsAnimator.SetBool(name:  "IsShow", value:  (val_9.y >= this.handsSwitchPositionY) ? 1 : 0);
        }
        
        float val_11 = UnityEngine.Time.deltaTime;
        val_11 = this.lightSETimer + val_11;
        this.lightSETimer = val_11;
        if(this.isEnableLight == false)
        {
                return;
        }
        
        if(val_11 < this.lightSEInterval)
        {
                return;
        }
        
        this.lightSETimer = 0f;
        this = SingletonMonoBehaviour<SoundManager>.Instance;
        this.PlaySE(filePath:  "Sounds/SE/se_n_pi_b", maxCount:  0, volume:  1f, pitch:  1f);
    }
    public void BeginAction(CatActionTrigger catActionTrigger)
    {
        Cat.<>c__DisplayClass48_0 val_1 = new Cat.<>c__DisplayClass48_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .catActionTrigger = catActionTrigger;
        if(this.isFirstHide == true)
        {
                return;
        }
        
        if(catActionTrigger.isUsed != false)
        {
                return;
        }
        
        CatState val_10 = this.catState;
        if(val_10 > 4)
        {
                return;
        }
        
        val_10 = 1 << val_10;
        val_10 = val_10 & 25;
        if(val_10 == 0)
        {
                return;
        }
        
        (Cat.<>c__DisplayClass48_0)[1152921511884543056].catActionTrigger.isUsed = true;
        this.catState = true;
        this.hideObject.SetActive(value:  true);
        this.searchObject.SetActive(value:  false);
        this.questionObject.SetActive(value:  false);
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        UnityEngine.Vector3 val_2 = this.catBody.position;
        this.tempHidePositionY = val_2.y;
        UnityEngine.Vector3 val_3 = this.catBody.position;
        System.Action<UnityEngine.Coroutine> val_4 = new System.Action<UnityEngine.Coroutine>(object:  val_1, method:  System.Void Cat.<>c__DisplayClass48_0::<BeginAction>b__0(UnityEngine.Coroutine coroutine));
        System.Action<System.Single> val_5 = new System.Action<System.Single>(object:  this, method:  System.Void Cat::LerpShowBody(float value));
        System.Action val_6 = new System.Action(object:  val_1, method:  System.Void Cat.<>c__DisplayClass48_0::<BeginAction>b__1());
        System.Action val_7 = new System.Action(object:  this, method:  System.Void Cat::EndCatAction());
        float val_8 = val_3.y - this.hidePositionY;
        val_8 = val_8 / (this.searchPositionY - this.hidePositionY);
        goto typeof(CatActionTrigger).__il2cppRuntimeField_168;
    }
    private void BeginSearchCat(CatActionTrigger catActionTrigger)
    {
        UnityEngine.Coroutine val_3;
        Cat.<>c__DisplayClass49_0 val_1 = new Cat.<>c__DisplayClass49_0();
        if(val_1 != null)
        {
                val_3 = val_1;
            .catActionTrigger = catActionTrigger;
            mem[1152921511884729824] = this;
            this.Search();
        }
        else
        {
                mem[16] = this;
            val_3 = 24;
            mem[24] = catActionTrigger;
            this.Search();
        }
        
        System.Action val_2 = new System.Action(object:  val_1, method:  System.Void Cat.<>c__DisplayClass49_0::<BeginSearchCat>b__0());
        this.coroutine = val_3;
    }
    private void SearchCat(CatActionTrigger catActionTrigger)
    {
        Cat.<>c__DisplayClass50_0 val_1 = new Cat.<>c__DisplayClass50_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .catActionTrigger = catActionTrigger;
        this.catState = 2;
        this.cancelAction = new System.Action(object:  val_1, method:  System.Void Cat.<>c__DisplayClass50_0::<SearchCat>b__0());
        System.Action<UnityEngine.Coroutine> val_3 = new System.Action<UnityEngine.Coroutine>(object:  val_1, method:  System.Void Cat.<>c__DisplayClass50_0::<SearchCat>b__1(UnityEngine.Coroutine coroutine));
        System.Action val_4 = new System.Action(object:  val_1, method:  System.Void Cat.<>c__DisplayClass50_0::<SearchCat>b__2());
        this.coroutine = (Cat.<>c__DisplayClass50_0)[1152921511884881744].catActionTrigger;
    }
    private void EndCatAction()
    {
        this.findAngle = 0f;
        this.catState = 0;
    }
    public void CancelAction(CatCancelTrigger catCancelTrigger)
    {
        if(this.catState != 2)
        {
                return;
        }
        
        catCancelTrigger.isUsed = true;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.cancelAction.Invoke();
    }
    private void LerpShowBody(float value)
    {
        TransformExtensions.SetPositionY(t:  this.catBody, f:  UnityEngine.Mathf.Lerp(a:  this.tempHidePositionY, b:  this.searchPositionY, t:  value));
    }
    public void LerpHideBody(float value)
    {
        TransformExtensions.SetPositionY(t:  this.catBody, f:  UnityEngine.Mathf.Lerp(a:  this.searchPositionY, b:  this.hidePositionY, t:  value));
    }
    public void SavePositionY()
    {
        UnityEngine.Vector3 val_1 = this.catBody.position;
        this.tempPositionY = val_1.y;
    }
    public void LerpOnTheWayHideBody(float value)
    {
        TransformExtensions.SetPositionY(t:  this.catBody, f:  UnityEngine.Mathf.Lerp(a:  this.tempPositionY, b:  this.hidePositionY, t:  value));
    }
    public void LerpSearchLight(float value)
    {
        TransformExtensions.SetLocalScaleY(t:  this.lightUnder, f:  UnityEngine.Mathf.Lerp(a:  1410f, b:  540f, t:  value));
        if(value >= 0.02f)
        {
                this.isEnableLight = true;
        }
        
        this.lightSEInterval = UnityEngine.Mathf.Lerp(a:  this.lightSEIntervalMin, b:  this.lightSEIntervalMax, t:  value);
    }
    private void Search()
    {
        this.lightSETimer = -1.175494E-38f;
        this.searchObject.SetActive(value:  true);
        this.hideObject.SetActive(value:  false);
    }
    private void NotFound()
    {
        this.catState = 3;
        this.isEnableLight = false;
        this.questionObject.SetActive(value:  true);
        this.searchObject.SetActive(value:  false);
        if(this.notFoundAction == null)
        {
                return;
        }
        
        this.notFoundAction.Invoke();
    }
    private void Hide()
    {
        this.catState = 4;
        this.hideObject.SetActive(value:  true);
        this.questionObject.SetActive(value:  false);
    }
    public void Found()
    {
        this.catState = 5;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.isEnableLight = false;
        this.foundObject.SetActive(value:  true);
        this.searchObject.SetActive(value:  false);
        this.handsAnimator.gameObject.SetActive(value:  false);
        this.tailAnimator.SetTrigger(name:  "Found");
    }
    public void Goal()
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        this.isEnableLight = false;
    }
    public Cat()
    {
        this.lightSETimer = -1.175494E-38f;
        this.isFirstHide = true;
        this.lightSEIntervalMin = ;
        this.lightSEIntervalMax = ;
        this.handsSwitchPositionY = -0.4f;
        this.hidePositionY = -1f;
        this.searchPositionY = ;
        this.lightMaskDistance = ;
        this.moveEyeLimit = 0.6f;
        this.moveEyeLimitAngle = 80f;
    }

}
