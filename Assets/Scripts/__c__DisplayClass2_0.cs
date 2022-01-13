using UnityEngine;
private sealed class PlaySE.<>c__DisplayClass2_0
{
    // Fields
    public SEInfo info;
    public PlaySE <>4__this;
    public System.Action<int> <>9__1;
    
    // Methods
    public PlaySE.<>c__DisplayClass2_0()
    {
    
    }
    internal void <OnEnable>b__0()
    {
        System.Action<System.Int32> val_9;
        if((this.<>4__this.isDestroyed) != false)
        {
                return;
        }
        
        if(this.info.Time > 0f)
        {
                val_9 = this.<>9__1;
            if(val_9 == null)
        {
                System.Action<System.Int32> val_4 = null;
            val_9 = val_4;
            val_4 = new System.Action<System.Int32>(object:  this, method:  System.Void PlaySE.<>c__DisplayClass2_0::<OnEnable>b__1(int count));
            this.<>9__1 = val_9;
        }
        
            UnityEngine.Coroutine val_5 = MonoBehaviourExtensions.CallTimer(monoBehaviour:  this.<>4__this, seconds:  this.info.Time, interval:  this.info.Interval, action:  val_4);
            return;
        }
        
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  this.info.Filename, maxCount:  this.info.MaxCount, volume:  1f, pitch:  1f);
    }
    internal void <OnEnable>b__1(int count)
    {
        SingletonMonoBehaviour<SoundManager>.Instance.PlaySE(filePath:  this.info.Filename, maxCount:  this.info.MaxCount, volume:  1f, pitch:  1f);
    }

}
