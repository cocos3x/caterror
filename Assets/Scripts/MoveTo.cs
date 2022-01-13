using UnityEngine;
public class MoveTo : SomethingTo
{
    // Fields
    private UnityEngine.Vector3 fromPosition;
    private UnityEngine.Vector3 targetPosition;
    private UnityEngine.Vector3 initializePosition;
    
    // Properties
    public UnityEngine.Vector3 InitializePosition { get; }
    
    // Methods
    public UnityEngine.Vector3 get_InitializePosition()
    {
        return new UnityEngine.Vector3() {x = this.initializePosition};
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.initializePosition = val_2;
        mem[1152921512061491644] = val_2.y;
        mem[1152921512061491648] = val_2.z;
    }
    private void Lerp(float lerp)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.fromPosition, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.targetPosition, y = V11.16B, z = V9.16B}, t:  lerp);
        this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public void ChangePosition(UnityEngine.Vector3 targetPosition, float interval, EasingType easingType = 0)
    {
        var val_3;
        UnityEngine.Vector3 val_2 = this.transform.position;
        val_3 = null;
        val_3 = null;
        this.ChangePosition(fromPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, targetPosition:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, interval:  interval, callback:  ActionExtensions.EmptyAction, easingType:  easingType);
    }
    public void ChangePosition(UnityEngine.Vector3 fromPosition, UnityEngine.Vector3 targetPosition, float interval, EasingType easingType = 0)
    {
        null = null;
        this.ChangePosition(fromPosition:  new UnityEngine.Vector3() {x = fromPosition.x, y = fromPosition.y, z = fromPosition.z}, targetPosition:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, interval:  interval, callback:  ActionExtensions.EmptyAction, easingType:  easingType);
    }
    public void ChangePosition(UnityEngine.Vector3 targetPosition, float interval, System.Action callback, EasingType easingType = 0)
    {
        var val_3;
        UnityEngine.Vector3 val_2 = this.transform.position;
        val_3 = null;
        val_3 = null;
        this.ChangePosition(fromPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, targetPosition:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, interval:  interval, callback:  ActionExtensions.EmptyAction, easingType:  easingType);
    }
    public void ChangePosition(UnityEngine.Vector3 fromPosition, UnityEngine.Vector3 targetPosition, float interval, System.Action callback, EasingType easingType = 0)
    {
        mem[1152921512062126376] = fromPosition.z;
        this.targetPosition = targetPosition;
        mem[1152921512062126384] = targetPosition.y;
        mem[1152921512062126388] = targetPosition.z;
        this.fromPosition = fromPosition;
        mem[1152921512062126372] = fromPosition.y;
        this.Begin(update:  new System.Action<System.Single>(object:  this, method:  System.Void MoveTo::Lerp(float lerp)), interval:  interval, callback:  callback, easingType:  easingType);
    }
    public MoveTo()
    {
    
    }

}
