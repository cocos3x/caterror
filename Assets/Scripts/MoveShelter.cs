using UnityEngine;
public sealed class MoveShelter : SwitchGimmickShelter
{
    // Fields
    private float speed;
    private UnityEngine.Transform[] tireArray;
    private bool isMove;
    private UnityEngine.Transform goal;
    
    // Methods
    private void Awake()
    {
        bool val_3 = TransformExtensions.FindParentsComponent<Stage>(t:  this.transform, func:  new System.Action<Stage>(object:  this, method:  System.Void MoveShelter::<Awake>b__4_0(Stage stage)));
    }
    private void Update()
    {
        float val_8;
        var val_9;
        if(this.isMove == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.position;
        val_8 = val_2.x;
        UnityEngine.Vector3 val_3 = this.goal.position;
        val_3.x = val_3.x + (-2.2f);
        if(val_8 >= 0)
        {
                return;
        }
        
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = this.speed * val_5;
        TransformExtensions.AddPositionX(t:  this.transform, f:  val_5);
        val_8 = -360f;
        val_9 = 0;
        goto label_4;
        label_7:
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = (this.speed * val_8) * val_6;
        TransformExtensions.AddEulerAnglesZ(t:  this.tireArray[0], f:  val_6);
        val_9 = 1;
        label_4:
        if(val_9 < this.tireArray.Length)
        {
            goto label_7;
        }
    
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collider)
    {
        if(true != 0)
        {
                return;
        }
        
        if(this.isMove == true)
        {
                return;
        }
        
        if((collider.gameObject.name.Contains(value:  "Girl")) == false)
        {
                return;
        }
        
        this.isMove = true;
    }
    public override void PushSwitch()
    {
        this.isMove = true;
    }
    public MoveShelter()
    {
    
    }
    private void <Awake>b__4_0(Stage stage)
    {
        this.goal = stage.Goal;
    }

}
