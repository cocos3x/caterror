using UnityEngine;
public sealed class Clock : MonoBehaviour
{
    // Fields
    private UnityEngine.SpriteRenderer hourSpriteRenderer;
    private UnityEngine.SpriteRenderer minuteSpriteRenderer;
    private UnityEngine.SpriteRenderer secondSpriteRenderer;
    private int prevSecond;
    
    // Methods
    private void Update()
    {
        System.DateTime val_1 = System.DateTime.Now;
        int val_2 = val_1.dateData.Second;
        if(this.prevSecond == val_2)
        {
                return;
        }
        
        this.UpdateAngles(now:  new System.DateTime() {dateData = val_1.dateData});
        this.prevSecond = val_2;
    }
    private void UpdateAngles(System.DateTime now)
    {
        float val_14 = 12f;
        float val_12 = (float)-now.dateData.Hour;
        float val_18 = 60f;
        float val_13 = (float)now.dateData.Minute;
        val_12 = val_12 / val_14;
        val_13 = val_13 / val_18;
        val_13 = val_13 * 360f;
        val_12 = val_12 * 360f;
        val_13 = val_13 / val_14;
        val_14 = val_12 - val_13;
        float val_15 = (float)now.dateData.Second;
        float val_16 = (float)-now.dateData.Minute;
        val_15 = val_15 / val_18;
        val_16 = val_16 / val_18;
        val_15 = val_15 * 360f;
        float val_17 = (float)-now.dateData.Second;
        val_17 = val_17 / val_18;
        val_18 = (val_16 * 360f) - (val_15 / val_18);
        TransformExtensions.SetLocalEulerAnglesZ(t:  this.hourSpriteRenderer.transform, f:  val_14);
        TransformExtensions.SetLocalEulerAnglesZ(t:  this.minuteSpriteRenderer.transform, f:  val_18);
        TransformExtensions.SetLocalEulerAnglesZ(t:  this.secondSpriteRenderer.transform, f:  val_17 * 360f);
    }
    public Clock()
    {
        this.prevSecond = 0;
    }

}
