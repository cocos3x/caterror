using UnityEngine;
public class RotateTo : SomethingTo
{
    // Fields
    private UnityEngine.Quaternion fromQuaternion;
    private UnityEngine.Quaternion targetQuaternion;
    
    // Methods
    private void Lerp(float lerp)
    {
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.fromQuaternion, y = V10.16B, z = V8.16B, w = V15.16B}, b:  new UnityEngine.Quaternion() {x = this.targetQuaternion, y = V12.16B, z = V13.16B, w = V11.16B}, t:  lerp);
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
    }
    public void ChangeRotation(UnityEngine.Quaternion targetQuaternion, float interval, EasingType easingType = 0)
    {
        null = null;
        this.ChangeRotation(targetQuaternion:  new UnityEngine.Quaternion() {x = targetQuaternion.x, y = targetQuaternion.y, z = targetQuaternion.z, w = targetQuaternion.w}, interval:  interval, callback:  ActionExtensions.EmptyAction, easingType:  easingType);
    }
    public void ChangeRotation(UnityEngine.Quaternion targetQuaternion, float interval, System.Action callback, EasingType easingType = 0)
    {
        this.targetQuaternion = targetQuaternion;
        mem[1152921512062620468] = targetQuaternion.y;
        mem[1152921512062620472] = targetQuaternion.z;
        mem[1152921512062620476] = targetQuaternion.w;
        UnityEngine.Quaternion val_2 = this.transform.rotation;
        this.fromQuaternion = val_2;
        mem[1152921512062620452] = val_2.y;
        mem[1152921512062620456] = val_2.z;
        mem[1152921512062620460] = val_2.w;
        this.SetUpdate(update:  new System.Action<System.Single>(object:  this, method:  System.Void RotateTo::Lerp(float lerp)), easingType:  easingType);
        float val_4 = 1f;
        val_4 = val_4 / interval;
        mem[1152921512062620440] = callback;
        mem[1152921512062620428] = val_4;
        mem[1152921512062620424] = 0;
    }
    public RotateTo()
    {
    
    }

}
