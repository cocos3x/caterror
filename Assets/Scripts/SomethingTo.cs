using UnityEngine;
public abstract class SomethingTo : MonoBehaviour
{
    // Fields
    private float lerp;
    private float speed;
    protected System.Action<float> update;
    protected System.Action callback;
    
    // Methods
    protected void Begin(System.Action<float> update, float interval, System.Action callback, EasingType easingType = 0)
    {
        this.SetUpdate(update:  update, easingType:  easingType);
        float val_1 = 1f;
        val_1 = val_1 / interval;
        this.callback = callback;
        this.speed = val_1;
        this.lerp = 0f;
    }
    private void SetUpdate(System.Action<float> update, EasingType easingType)
    {
        System.Action<System.Single> val_3 = update;
        .update = val_3;
        if(easingType == 1)
        {
                System.Action<System.Single> val_2 = null;
            val_3 = val_2;
            val_2 = new System.Action<System.Single>(object:  new SomethingTo.<>c__DisplayClass5_0(), method:  System.Void SomethingTo.<>c__DisplayClass5_0::<SetUpdate>b__0(float lerp));
        }
        
        this.update = val_3;
    }
    public void Stop()
    {
        this.lerp = 1f;
    }
    private void Update()
    {
        float val_2 = this.lerp;
        if(val_2 >= 0)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * this.speed;
        val_2 = val_2 + val_1;
        this.lerp = val_2;
        if(val_2 < 1f)
        {
                this.update.Invoke(obj:  val_2);
            return;
        }
        
        this.lerp = 1f;
        this.update.Invoke(obj:  1f);
        this.callback.Invoke();
    }
    protected SomethingTo()
    {
        var val_1;
        this.lerp = 1f;
        this.speed = 1f;
        val_1 = null;
        val_1 = null;
        this.update = ActionExtensions.EmptyActionFloat;
        this.callback = ActionExtensions.EmptyAction;
    }

}
