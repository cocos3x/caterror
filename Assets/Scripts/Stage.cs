using UnityEngine;
public sealed class Stage : MonoBehaviour
{
    // Fields
    private float objectDestroyPositionX;
    private UnityEngine.Transform goal;
    private UnityEngine.Transform frontObjectParent;
    private UnityEngine.Transform middleObjectParent;
    private UnityEngine.Transform presentPivot;
    private float stageLength;
    
    // Properties
    public UnityEngine.Transform Goal { get; }
    public float StageProgress { get; }
    public UnityEngine.Transform PresentPivot { get; }
    public bool IsSetablePresentBox { get; }
    
    // Methods
    public UnityEngine.Transform get_Goal()
    {
        return (UnityEngine.Transform)this.goal;
    }
    public float get_StageProgress()
    {
        UnityEngine.Vector3 val_1 = this.goal.position;
        val_1.x = this.stageLength - val_1.x;
        val_1.x = val_1.x / this.stageLength;
        return (float)val_1.x;
    }
    public UnityEngine.Transform get_PresentPivot()
    {
        return (UnityEngine.Transform)this.presentPivot;
    }
    public bool get_IsSetablePresentBox()
    {
        UnityEngine.Vector3 val_1 = this.presentPivot.localPosition;
        return (bool)(val_1.x > 0f) ? 1 : 0;
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_1 = this.goal.position;
        this.stageLength = val_1.x;
    }
    public void Initialize(BackgroundData backgroundData, int stage, float middleMagnification)
    {
        var val_16;
        int val_18;
        float val_19;
        float val_20;
        .stage = stage;
        UnityEngine.Transform val_3 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  backgroundData.GetStartObjectPrefab(), parent:  this.middleObjectParent);
        val_16 = null;
        val_16 = null;
        if((SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).Exists(match:  new System.Predicate<AvatarData>(object:  new Stage.<>c__DisplayClass15_0(), method:  System.Boolean Stage.<>c__DisplayClass15_0::<Initialize>b__0(AvatarData data)))) != false)
        {
                UnityEngine.Transform val_8 = UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "GoalObjects/Room_presentBox");
        }
        
        UnityEngine.Transform val_10 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  backgroundData.GetGoalObjectPrefab(), parent:  this.goal);
        UnityEngine.Transform[] val_11 = backgroundData.GetMiddleObjectPrefabArray();
        val_18 = (Stage.<>c__DisplayClass15_0)[1152921511935674960].stage;
        val_19 = backgroundData.firstMiddleObjectPosition;
        val_20 = this.stageLength * middleMagnification;
        goto label_23;
        label_26:
        if(val_11 == null)
        {
            goto label_17;
        }
        
        label_25:
        val_18 = val_11[-1261024688];
        TransformExtensions.AddPositionX(t:  UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_18, parent:  this.middleObjectParent), f:  val_19);
        float val_15 = (float)val_19;
        val_15 = (backgroundData.middleObjectIntervalMax - backgroundData.middleObjectIntervalMin) * val_15;
        val_15 = backgroundData.middleObjectIntervalMin + val_15;
        val_19 = val_19 + val_15;
        val_20 = this.stageLength * middleMagnification;
        goto label_23;
        label_17:
        if((new System.Random(Seed:  val_18)) != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_23:
        if(val_19 < 0)
        {
            goto label_26;
        }
    
    }
    public void ContinueInitialize()
    {
        var val_3;
        System.Action<IContinueInitializer> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = Stage.<>c.<>9__16_0;
        if(val_5 == null)
        {
                System.Action<IContinueInitializer> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action<IContinueInitializer>(object:  Stage.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Stage.<>c::<ContinueInitialize>b__16_0(IContinueInitializer continueInitializer));
            Stage.<>c.<>9__16_0 = val_5;
        }
        
        bool val_2 = TransformExtensions.FindAllChildrensComponent<IContinueInitializer>(t:  this.frontObjectParent, func:  val_1);
    }
    public void Move(float frontMoveLength, float middleMoveLength)
    {
        float val_7;
        UnityEngine.Transform val_8;
        val_7 = middleMoveLength;
        UnityEngine.Transform val_7 = this.frontObjectParent;
        val_7 = val_7.childCount - 1;
        if((val_7 & 2147483648) == 0)
        {
                do
        {
            val_8 = this.frontObjectParent;
            TransformExtensions.AddPositionX(t:  val_8.GetChild(index:  val_7), f:  -frontMoveLength);
            val_7 = val_7 - 1;
        }
        while((val_7 & 2147483648) == 0);
        
        }
        
        UnityEngine.Transform val_8 = this.middleObjectParent;
        val_8 = val_8.childCount - 1;
        if((val_8 & 2147483648) != 0)
        {
                return;
        }
        
        val_7 = -val_7;
        do
        {
            UnityEngine.Transform val_4 = this.middleObjectParent.GetChild(index:  val_8);
            val_8 = val_4;
            TransformExtensions.AddPositionX(t:  val_4, f:  val_7);
            UnityEngine.Vector3 val_5 = val_8.position;
            if(val_5.x <= this.objectDestroyPositionX)
        {
                val_8 = val_8.gameObject;
            UnityEngine.Object.Destroy(obj:  val_8);
        }
        
            val_8 = val_8 - 1;
        }
        while((val_8 & 2147483648) == 0);
    
    }
    public bool CheckTutorialHide()
    {
        var val_12;
        var val_13;
        var val_14;
        System.Collections.IEnumerator val_1 = this.frontObjectParent.GetEnumerator();
        goto label_14;
        label_22:
        var val_12 = 0;
        val_12 = val_12 + 1;
        object val_3 = val_1.Current;
        UnityEngine.Vector3 val_6 = 0.position;
        if((val_6.x > 0f) || ((0.name.Contains(value:  "HideTutorialObject")) == false))
        {
            goto label_14;
        }
        
        goto label_15;
        label_14:
        var val_13 = 0;
        val_13 = val_13 + 1;
        if(val_1.MoveNext() == true)
        {
            goto label_22;
        }
        
        val_12 = 0;
        val_13 = 0;
        val_14 = 0;
        goto label_24;
        label_15:
        val_12 = 0;
        val_13 = 0;
        val_14 = 1;
        label_24:
        if(val_1 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_1.Dispose();
        }
        
        if( == 1)
        {
            goto label_38;
        }
        
        if(95 == 95)
        {
                return (bool)val_14;
        }
        
        val_14 = 0;
        if( == false)
        {
                return (bool)val_14;
        }
        
        if(95 != 93)
        {
            goto label_41;
        }
        
        return (bool)val_14;
        label_38:
        if( == false)
        {
            goto label_43;
        }
        
        label_41:
        label_43:
        val_14 = 0;
        return (bool)val_14;
    }
    public bool CheckGoal()
    {
        UnityEngine.Vector3 val_1 = this.goal.position;
        return (bool)(val_1.x <= 0f) ? 1 : 0;
    }
    public Stage()
    {
        this.objectDestroyPositionX = -10f;
    }

}
