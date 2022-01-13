using UnityEngine;
private sealed class GameManager.<>c__DisplayClass62_0
{
    // Fields
    public GameManager <>4__this;
    public float fromY;
    public float fromSize;
    public float prevDistance;
    
    // Methods
    public GameManager.<>c__DisplayClass62_0()
    {
    
    }
    internal void <Goal>b__0(float t)
    {
        float val_1 = FloatExtentions.EaseOutQuadratic(t:  t);
        UnityEngine.Vector3 val_4 = this.<>4__this.girl.transform.position;
        val_4.y = val_4.y + 1f;
        TransformExtensions.SetPositionY(t:  this.<>4__this.cameraPivot.transform, f:  UnityEngine.Mathf.Lerp(a:  this.fromY, b:  val_4.y, t:  val_1));
        this.<>4__this.cameraPivot.ChangeSize(size:  UnityEngine.Mathf.Lerp(a:  this.fromSize, b:  3.5f, t:  val_1));
        float val_7 = UnityEngine.Mathf.Lerp(a:  0f, b:  1.5f, t:  val_1);
        val_7 = val_7 - this.prevDistance;
        this.<>4__this.stageManager.Move(speed:  val_7);
        this.prevDistance = val_7;
    }

}
