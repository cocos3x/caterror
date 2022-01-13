using UnityEngine;
public class RotateToZ : SomethingTo
{
    // Fields
    private UnityEngine.Quaternion fromQuaternion;
    private float targetAngle;
    
    // Methods
    private void Lerp(float lerp)
    {
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Mathf.Lerp(a:  0f, b:  this.targetAngle, t:  lerp), axis:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this.fromQuaternion, y = V10.16B, z = V9.16B, w = V8.16B}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
    }
    public void ChangeRotation(float targetAngle, float interval, EasingType easingType = 0)
    {
        null = null;
        this.ChangeRotation(targetAngle:  targetAngle, interval:  interval, callback:  ActionExtensions.EmptyAction, easingType:  easingType);
    }
    public void ChangeRotation(float targetAngle, float interval, System.Action callback, EasingType easingType = 0)
    {
        this.targetAngle = targetAngle;
        UnityEngine.Quaternion val_2 = this.transform.rotation;
        this.fromQuaternion = val_2;
        mem[1152921512063118628] = val_2.y;
        mem[1152921512063118632] = val_2.z;
        mem[1152921512063118636] = val_2.w;
        this.SetUpdate(update:  new System.Action<System.Single>(object:  this, method:  System.Void RotateToZ::Lerp(float lerp)), easingType:  easingType);
        float val_4 = 1f;
        val_4 = val_4 / interval;
        mem[1152921512063118616] = callback;
        mem[1152921512063118604] = val_4;
        mem[1152921512063118600] = 0;
    }
    public RotateToZ()
    {
    
    }

}
