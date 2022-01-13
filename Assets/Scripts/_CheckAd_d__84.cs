using UnityEngine;
private sealed class GameManager.<CheckAd>d__84 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameManager.<CheckAd>d__84(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_6;
        object val_7;
        int val_8;
        val_6 = this;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_7 = GameDataManager.GameData;
        val_8 = 1;
        if((val_7.CheckAdReward(type:  1)) == false)
        {
            goto label_5;
        }
        
        val_6 = this.<>4__this.adBadgeObject;
        AdRewardType val_6 = 1;
        val_6 = GameDataManager.GameData.CheckAdReward(type:  val_6);
        val_6.SetActive(value:  val_6);
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_5:
        UnityEngine.WaitForSeconds val_5 = null;
        val_7 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>2__current = val_7;
        this.<>1__state = val_8;
        return (bool)val_8;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
