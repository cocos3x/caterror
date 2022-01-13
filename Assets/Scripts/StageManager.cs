using UnityEngine;
public sealed class StageManager : MonoBehaviour
{
    // Fields
    private float middleMoveSpeedMagnification;
    private float backMoveSpeedMagnification;
    private UnityEngine.GameObject presentPrefab;
    private UnityEngine.Transform backgroundParent;
    private Stage stage;
    private Background background;
    private float girlPosition;
    
    // Properties
    public float StageProgress { get; }
    public float GirlPosition { get; }
    
    // Methods
    public float get_StageProgress()
    {
        if(this.stage != null)
        {
                return this.stage.StageProgress;
        }
        
        return this.stage.StageProgress;
    }
    public float get_GirlPosition()
    {
        return (float)this.girlPosition;
    }
    public void Initialize(StageData stageData, int stage, bool isContinue)
    {
        object val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        StageManager.<>c__DisplayClass11_0 val_1 = null;
        val_25 = val_1;
        val_1 = new StageManager.<>c__DisplayClass11_0();
        this.stage = UnityEngine.Object.Instantiate<Stage>(original:  stageData.GetPrefab(), parent:  this.transform);
        val_26 = null;
        val_26 = null;
        System.Collections.Generic.List<T> val_6 = SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<BackgroundData>(worksheetName:  Const.BackgroundDataSheet);
        if(val_6 != null)
        {
                val_27 = val_6.Count;
        }
        else
        {
                val_27 = 0.Count;
        }
        
        int val_9 = stage - 1;
        val_9 = val_9 / Const.AreaCount;
        BackgroundData val_12 = val_6.Item[val_9 - ((val_9 / val_27) * val_27)];
        this.stage.Initialize(backgroundData:  val_12, stage:  stage, middleMagnification:  this.middleMoveSpeedMagnification);
        Background val_14 = UnityEngine.Object.Instantiate<Background>(original:  val_12.GetPrefab(), parent:  this.backgroundParent);
        this.background = val_14;
        val_14.Initialize(backgroundData:  val_12);
        .gameData = GameDataManager.GameData;
        val_28 = null;
        val_28 = null;
        if(isContinue == true)
        {
                return;
        }
        
        if(this.stage.IsSetablePresentBox == false)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        if((SingletonMonoBehaviour<SpreadsheetDataManager>.Instance.GetBaseDataList<AvatarData>(worksheetName:  Const.AvatarDataSheet).Exists(match:  new System.Predicate<AvatarData>(object:  val_1, method:  System.Boolean StageManager.<>c__DisplayClass11_0::<Initialize>b__0(AvatarData data)))) == false)
        {
                return;
        }
        
        System.Random val_23 = null;
        val_25 = val_23;
        val_23 = new System.Random(Seed:  stage);
        if((((float)JoypacUtils.OnlineParametersIntByJoypacSDK(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.PresentBoxRatio, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_120})) / 100f) < (float)100f)
        {
                return;
        }
        
        UnityEngine.GameObject val_24 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.presentPrefab, parent:  this.stage.presentPivot);
    }
    public void ContinueInitialize(float girlPositionX)
    {
        this.Move(speed:  girlPositionX);
        this.stage.ContinueInitialize();
    }
    public void Move(float speed)
    {
        UnityEngine.Transform val_28;
        var val_29;
        var val_30;
        UnityEngine.Transform val_36;
        var val_37;
        Background val_40;
        UnityEngine.Transform val_43;
        float val_40 = speed;
        float val_32 = this.girlPosition;
        val_32 = val_32 + val_40;
        float val_1 = this.middleMoveSpeedMagnification * val_40;
        this.girlPosition = val_32;
        this.stage.Move(frontMoveLength:  val_40, middleMoveLength:  val_1);
        System.Collections.IEnumerator val_3 = this.background.FrontTableParent.GetEnumerator();
        label_19:
        var val_33 = 0;
        val_33 = val_33 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        val_28 = val_3.Current;
        if(val_28 != null)
        {
                val_28 = 0;
        }
        
        TransformExtensions.AddPositionX(t:  val_28, f:  -val_40);
        label_20:
        UnityEngine.Vector3 val_10 = val_28.position;
        if(val_10.x > (-10f))
        {
            goto label_19;
        }
        
        TransformExtensions.AddPositionX(t:  val_28, f:  18f);
        goto label_20;
        label_9:
        val_29 = 0;
        val_30 = 0;
        if(val_3 != null)
        {
                var val_35 = 0;
            val_35 = val_35 + 1;
            val_3.Dispose();
        }
        
        if(( != 1) && (142 == 142))
        {
                val_29 = 0;
        }
        else
        {
                if( != false)
        {
                val_30 = 0;
        }
        
        }
        
        System.Collections.IEnumerator val_13 = this.background.MiddleTableParent.GetEnumerator();
        label_56:
        var val_36 = 0;
        val_36 = val_36 + 1;
        if(val_13.MoveNext() == false)
        {
            goto label_46;
        }
        
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_36 = val_13.Current;
        if(val_36 != null)
        {
                val_36 = 0;
        }
        
        TransformExtensions.AddPositionX(t:  val_36, f:  -val_1);
        label_57:
        UnityEngine.Vector3 val_20 = val_36.position;
        if(val_20.x > (-10f))
        {
            goto label_56;
        }
        
        TransformExtensions.AddPositionX(t:  val_36, f:  18f);
        goto label_57;
        label_46:
        val_37 = 0 + 1;
        mem2[0] = 246;
        if(val_13 != null)
        {
                var val_38 = 0;
            val_38 = val_38 + 1;
            val_13.Dispose();
        }
        
        if((val_37 != 1) && ((1152921511937800640 + ((0 + 1)) << 2) == 246))
        {
                var val_39 = 0;
            val_39 = val_39 ^ (val_37 >> 31);
            val_37 = val_37 + val_39;
        }
        else
        {
                if( != false)
        {
                val_30 = 0;
        }
        
        }
        
        val_40 = this.background;
        val_40 = this.backMoveSpeedMagnification * val_40;
        System.Collections.IEnumerator val_23 = val_40.BackTableParent.GetEnumerator();
        label_93:
        var val_41 = 0;
        val_41 = val_41 + 1;
        if(val_23.MoveNext() == false)
        {
            goto label_83;
        }
        
        var val_42 = 0;
        val_42 = val_42 + 1;
        val_43 = val_23.Current;
        if(val_43 != null)
        {
                val_43 = 0;
        }
        
        TransformExtensions.AddPositionX(t:  val_43, f:  -val_40);
        label_94:
        UnityEngine.Vector3 val_30 = val_43.position;
        if(val_30.x > (-10f))
        {
            goto label_93;
        }
        
        TransformExtensions.AddPositionX(t:  val_43, f:  18f);
        goto label_94;
        label_83:
        val_37 = val_37 + 1;
        mem2[0] = 359;
        if(val_23 != null)
        {
                var val_43 = 0;
            val_43 = val_43 + 1;
            val_23.Dispose();
        }
        
        if(val_37 != 1)
        {
                if( == false)
        {
                return;
        }
        
            if((1152921511937800640 + (((0 + 1) + 1)) << 2) == 359)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    public bool CheckTutorialHide()
    {
        if(this.stage != null)
        {
                return this.stage.CheckTutorialHide();
        }
        
        return this.stage.CheckTutorialHide();
    }
    public bool CheckGoal()
    {
        if(this.stage != null)
        {
                return this.stage.CheckGoal();
        }
        
        return this.stage.CheckGoal();
    }
    public StageManager()
    {
        this.middleMoveSpeedMagnification = 0.35f;
        this.backMoveSpeedMagnification = 8.081428E-41f;
    }

}
