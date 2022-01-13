using UnityEngine;
public sealed class GaugeX : GaugeParent
{
    // Fields
    private UnityEngine.RectTransform gauge;
    private float gaugeSize;
    private UnityEngine.Vector3 localPosition;
    
    // Properties
    public float GaugeSize { get; }
    
    // Methods
    public float get_GaugeSize()
    {
        return (float)this.gaugeSize;
    }
    public override void Initialize(float percentage = 0)
    {
        if(this.gaugeSize < 0)
        {
                UnityEngine.Vector2 val_1 = this.gauge.sizeDelta;
            this.gaugeSize = val_1.x;
            UnityEngine.Vector3 val_2 = this.gauge.localPosition;
            this.localPosition = val_2;
            mem[1152921512097348968] = val_2.y;
            mem[1152921512097348972] = val_2.z;
        }
        
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  0);
        goto typeof(GaugeX).__il2cppRuntimeField_178;
    }
    public override void UpdateGauge(float percentage)
    {
        UnityEngine.Vector2 val_1 = this.gauge.sizeDelta;
        float val_3 = this.gaugeSize;
        val_3 = val_3 * (UnityEngine.Mathf.Clamp(value:  percentage, min:  0f, max:  1f));
        this.gauge.sizeDelta = new UnityEngine.Vector2() {x = val_3, y = val_1.y};
        mem[1152921512097481424] = percentage;
        this.gauge.localPosition = new UnityEngine.Vector3() {x = this.localPosition, y = val_3, z = V11.16B};
    }
    public GaugeX()
    {
        this.gaugeSize = -1f;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
