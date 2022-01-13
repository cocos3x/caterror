using UnityEngine;
public sealed class PingPongMoveShelter : Shelter
{
    // Fields
    private float speed;
    private float distance;
    private UnityEngine.Transform[] tireArray;
    private bool isMove;
    private float totalTime;
    
    // Methods
    private void Update()
    {
        float val_6;
        var val_7;
        if(this.isMove == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * this.speed;
        val_1 = val_1 + this.totalTime;
        float val_6 = UnityEngine.Mathf.PingPong(t:  val_1, length:  this.distance);
        val_6 = val_6 - (UnityEngine.Mathf.PingPong(t:  this.totalTime, length:  this.distance));
        TransformExtensions.AddPositionX(t:  this.transform, f:  val_6);
        val_6 = -90f;
        val_7 = 0;
        val_6 = val_6 * val_6;
        goto label_4;
        label_7:
        val_6 = val_6 * this.distance;
        TransformExtensions.AddEulerAnglesZ(t:  this.tireArray[0], f:  val_6);
        val_7 = 1;
        label_4:
        if(val_7 < this.tireArray.Length)
        {
            goto label_7;
        }
        
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_5 * this.speed;
        val_5 = this.totalTime + val_5;
        this.totalTime = val_5;
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
    public PingPongMoveShelter()
    {
        this.speed = 1f;
        this.distance = 1f;
        this.totalTime = 0.5f;
    }

}
