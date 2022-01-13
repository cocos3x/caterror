using UnityEngine;
public sealed class SinMoveShelter : Shelter
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
        float val_4;
        var val_5;
        if(this.isMove == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * this.speed;
        val_1 = val_1 + this.totalTime;
        float val_4 = val_1;
        val_4 = val_4 - this.totalTime;
        float val_5 = this.distance;
        val_5 = val_4 * val_5;
        val_5 = val_5 * 0.5f;
        TransformExtensions.AddPositionX(t:  this.transform, f:  val_5);
        val_4 = -90f;
        val_5 = 0;
        val_4 = val_4 * val_4;
        goto label_4;
        label_7:
        val_4 = val_4 * this.distance;
        TransformExtensions.AddEulerAnglesZ(t:  this.tireArray[0], f:  val_4);
        val_5 = 1;
        label_4:
        if(val_5 < this.tireArray.Length)
        {
            goto label_7;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_3 * this.speed;
        val_3 = this.totalTime + val_3;
        this.totalTime = val_3;
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
    public SinMoveShelter()
    {
        this.speed = 1f;
        this.distance = 1f;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
