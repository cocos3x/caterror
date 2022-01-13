using UnityEngine;
public class LocalScaleTo : SomethingTo
{
    // Fields
    private UnityEngine.Vector3 fromLocalScale;
    private UnityEngine.Vector3 targetLocalScale;
    
    // Methods
    private void Lerp(float lerp)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.fromLocalScale, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.targetLocalScale, y = V11.16B, z = V9.16B}, t:  lerp);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public void ChangeLocalScale(UnityEngine.Vector3 targetLocalScale, float interval, EasingType easingType = 0)
    {
        null = null;
        this.ChangeLocalScale(targetLocalScale:  new UnityEngine.Vector3() {x = targetLocalScale.x, y = targetLocalScale.y, z = targetLocalScale.z}, interval:  interval, callback:  ActionExtensions.EmptyAction, easingType:  easingType);
    }
    public void ChangeLocalScale(UnityEngine.Vector3 targetLocalScale, float interval, System.Action callback, EasingType easingType = 0)
    {
        UnityEngine.Vector3 val_2 = this.transform.localScale;
        this.ChangeLocalScale(fromLocalScale:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, targetLocalScale:  new UnityEngine.Vector3() {x = targetLocalScale.x, y = targetLocalScale.y, z = targetLocalScale.z}, interval:  interval, callback:  callback, easingType:  easingType);
    }
    public void ChangeLocalScale(UnityEngine.Vector3 fromLocalScale, UnityEngine.Vector3 targetLocalScale, float interval, EasingType easingType = 0)
    {
        null = null;
        this.ChangeLocalScale(fromLocalScale:  new UnityEngine.Vector3() {x = fromLocalScale.x, y = fromLocalScale.y, z = fromLocalScale.z}, targetLocalScale:  new UnityEngine.Vector3() {x = targetLocalScale.x, y = targetLocalScale.y, z = targetLocalScale.z}, interval:  interval, callback:  ActionExtensions.EmptyAction, easingType:  easingType);
    }
    public void ChangeLocalScale(UnityEngine.Vector3 fromLocalScale, UnityEngine.Vector3 targetLocalScale, float interval, System.Action callback, EasingType easingType = 0)
    {
        mem[1152921512061139240] = fromLocalScale.z;
        this.targetLocalScale = targetLocalScale;
        mem[1152921512061139248] = targetLocalScale.y;
        mem[1152921512061139252] = targetLocalScale.z;
        this.fromLocalScale = fromLocalScale;
        mem[1152921512061139236] = fromLocalScale.y;
        this.Begin(update:  new System.Action<System.Single>(object:  this, method:  System.Void LocalScaleTo::Lerp(float lerp)), interval:  interval, callback:  callback, easingType:  easingType);
    }
    public LocalScaleTo()
    {
    
    }

}
