using UnityEngine;
public sealed class GaugeY : GaugeParent
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
    public override void Initialize(float percentage)
    {
        if(this.gaugeSize < 0)
        {
                UnityEngine.Vector2 val_1 = this.gauge.sizeDelta;
            this.gaugeSize = val_1.y;
            UnityEngine.Vector3 val_2 = this.gauge.localPosition;
            this.localPosition = val_2;
            mem[1152921512097837928] = val_2.y;
            mem[1152921512097837932] = val_2.z;
        }
        
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  0);
        goto typeof(GaugeY).__il2cppRuntimeField_178;
    }
    public override void UpdateGauge(float percentage)
    {
        UnityEngine.Vector2 val_1 = this.gauge.sizeDelta;
        float val_3 = this.gaugeSize;
        val_3 = val_3 * (UnityEngine.Mathf.Min(a:  1f, b:  percentage));
        this.gauge.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_3};
        mem[1152921512097970384] = percentage;
        this.gauge.localPosition = new UnityEngine.Vector3() {x = this.localPosition, y = val_3, z = V11.16B};
    }
    public GaugeY()
    {
        this.gaugeSize = -1f;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
