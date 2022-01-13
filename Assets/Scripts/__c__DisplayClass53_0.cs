using UnityEngine;
private sealed class GameManager.<>c__DisplayClass53_0
{
    // Fields
    public GameManager <>4__this;
    public bool isContinue;
    public System.Action<float> <>9__2;
    
    // Methods
    public GameManager.<>c__DisplayClass53_0()
    {
    
    }
    internal void <BeginStage>b__0(float t)
    {
        t = t * t;
        t = 1f - t;
        t = t * (this.<>4__this.girlMoveSpeed);
        this.<>4__this.slipSpeed = t;
    }
    internal void <BeginStage>b__1()
    {
        float val_24;
        var val_25;
        System.Action<System.Single> val_26;
        GameManager val_27;
        GameManager val_28;
        StageManager val_29;
        GameManager val_30;
        if((this.<>4__this.tutorialState) == 2)
        {
            goto label_2;
        }
        
        if((this.<>4__this.tutorialState) != 1)
        {
            goto label_13;
        }
        
        GameData val_1 = GameDataManager.GameData;
        if(((val_1.stage != 1) || (this.isContinue == true)) || ((this.<>4__this.stageManager.CheckTutorialHide()) == false))
        {
            goto label_13;
        }
        
        this.<>4__this.tutorialState = 2;
        goto label_13;
        label_2:
        if((this.<>4__this.girl.IsRunning) != false)
        {
                val_24 = 0f;
            UnityEngine.Time.timeScale = val_24;
            val_25 = 1;
        }
        else
        {
                val_24 = 1f;
            UnityEngine.Time.timeScale = val_24;
            val_25 = 0;
        }
        
        this.<>4__this.tutorialEffect.SetActive(value:  false);
        label_13:
        if((((this.<>4__this.isTapping) != true) && ((this.<>4__this.girl.IsDash) != true)) && ((UnityEngine.Input.GetMouseButton(button:  0)) != false))
        {
                UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_24 = val_7.x;
            if((this.<>4__this.CheckTap(position:  new UnityEngine.Vector2() {x = val_24, y = val_7.y})) != false)
        {
                this.<>4__this.isTapping = true;
            this.<>4__this.girl.Hide();
            if((this.<>4__this.girl.IsSlipping) != false)
        {
                val_26 = this.<>9__2;
            if(val_26 == null)
        {
                System.Action<System.Single> val_10 = null;
            val_26 = val_10;
            val_10 = new System.Action<System.Single>(object:  this, method:  System.Void GameManager.<>c__DisplayClass53_0::<BeginStage>b__2(float t));
            this.<>9__2 = val_26;
        }
        
            val_24 = this.<>4__this.slipTime;
            this.<>4__this.slipCoroutine = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this.<>4__this, duration:  val_24, act:  val_10);
        }
        
        }
        
        }
        
        if((this.<>4__this.isTapping) != true)
        {
                if((this.<>4__this.tutorialState) != 2)
        {
            goto label_43;
        }
        
        }
        
        val_27 = this.<>4__this;
        if((this.<>4__this) != null)
        {
            goto label_44;
        }
        
        val_27 = this.<>4__this;
        if(val_27 == null)
        {
            goto label_74;
        }
        
        label_44:
        float val_14 = (this.<>4__this.girl.FloorMoveSpeed) + (this.<>4__this.slipSpeed);
        val_14 = val_14 * UnityEngine.Time.deltaTime;
        this.<>4__this.stageManager.Move(speed:  val_14);
        if((this.<>4__this.girl.IsSlipping) != true)
        {
                MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this.<>4__this, c:  this.<>4__this.slipCoroutine);
            this.<>4__this.slipSpeed = 0f;
        }
        
        label_83:
        if(((UnityEngine.Input.GetMouseButtonUp(button:  0)) != false) && ((this.<>4__this.isTapping) != false))
        {
                this.<>4__this.isTapping = false;
            this.<>4__this.girl.BeginRun();
            MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this.<>4__this, c:  this.<>4__this.slipCoroutine);
            this.<>4__this.slipSpeed = 0f;
        }
        
        if((this.<>4__this.cat.IsSearching) != false)
        {
                if((this.<>4__this.girl.IsBeFounding) != false)
        {
                this.<>4__this.ChangeState(nextState:  4);
        }
        
        }
        
        this.<>4__this.UpdateStageProgress();
        return;
        label_43:
        val_28 = this.<>4__this;
        if(val_28 == null)
        {
            goto label_70;
        }
        
        val_29 = this.<>4__this.stageManager;
        val_30 = val_28;
        goto label_73;
        label_70:
        val_30 = this.<>4__this;
        val_29 = this.<>4__this.stageManager;
        if(val_30 == null)
        {
            goto label_72;
        }
        
        val_28 = val_30;
        goto label_73;
        label_72:
        val_28 = this.<>4__this;
        if(val_28 == null)
        {
            goto label_74;
        }
        
        label_73:
        float val_22 = (this.<>4__this.girlMoveSpeed) * (this.<>4__this.girl.MoveSpeedMagnification);
        val_22 = val_22 + (this.<>4__this.girl.FloorMoveSpeed);
        val_22 = val_22 * UnityEngine.Time.deltaTime;
        val_29.Move(speed:  val_22);
        if((this.<>4__this.stageManager.CheckGoal()) == false)
        {
            goto label_83;
        }
        
        this.<>4__this.ChangeState(nextState:  5);
        goto label_83;
        label_74:
    }
    internal void <BeginStage>b__2(float t)
    {
        t = t * t;
        t = 1f - t;
        t = t * (this.<>4__this.girlMoveSpeed);
        this.<>4__this.slipSpeed = t;
    }

}
