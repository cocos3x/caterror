using UnityEngine;
private sealed class GachaManager.<>c__DisplayClass20_0
{
    // Fields
    public float remainingTime;
    public GachaManager <>4__this;
    
    // Methods
    public GachaManager.<>c__DisplayClass20_0()
    {
    
    }
    internal void <UpdateAdRewardButton>b__0(float t)
    {
        float val_3 = 1f;
        float val_1 = val_3 - t;
        val_1 = val_1 * this.remainingTime;
        val_3 = val_1 + val_3;
        string val_2 = FloatExtentions.ToTimerString(f:  val_3);
        if((this.<>4__this.adRewardRemainingTimeText) == null)
        {
            
        }
    
    }

}
