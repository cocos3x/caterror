using UnityEngine;
public sealed class GaugeImage : GaugeParent
{
    // Fields
    private UnityEngine.UI.Image gauge;
    
    // Methods
    public override void UpdateGauge(float percentage)
    {
        this.gauge.fillAmount = percentage;
        mem[1152921512096028880] = percentage;
    }
    public GaugeImage()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
