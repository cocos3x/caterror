using UnityEngine;
public sealed class MoveCoin : Coin
{
    // Fields
    private float moveCycle;
    private float radius;
    private float defaultAngle;
    private UnityEngine.Transform coinTransform;
    private bool isMove;
    private float defaultPositionY;
    private float angle;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_1 = this.coinTransform.position;
        this.defaultPositionY = val_1.y;
        this.angle = this.defaultAngle;
        float val_2 = 3.141593f;
        val_2 = this.defaultAngle * val_2;
        val_2 = val_2 + val_2;
        val_2 = val_2 * this.radius;
        val_2 = val_1.y + val_2;
        val_2 = this.radius + val_2;
        TransformExtensions.SetPositionY(t:  this.coinTransform, f:  val_2);
    }
    private void Update()
    {
        if(this.isMove == false)
        {
                return;
        }
        
        float val_2 = 3.141593f;
        val_2 = this.angle * val_2;
        val_2 = val_2 + val_2;
        val_2 = val_2 * this.radius;
        val_2 = this.defaultPositionY + val_2;
        val_2 = this.radius + val_2;
        TransformExtensions.SetPositionY(t:  this.coinTransform, f:  val_2);
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 / this.moveCycle;
        val_1 = this.angle + val_1;
        this.angle = val_1;
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collider)
    {
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
    public MoveCoin()
    {
        this.moveCycle = 0f;
        this.radius = 1f;
        this.defaultAngle = 0.5f;
        this.angle = 0.5f;
    }

}
