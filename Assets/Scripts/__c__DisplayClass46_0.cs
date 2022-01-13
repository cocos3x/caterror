using UnityEngine;
private sealed class JoypacAdManager.<>c__DisplayClass46_0
{
    // Fields
    public JoypacAdManager <>4__this;
    public System.Action<JoypacIntersitialStatus> callback;
    public string interId;
    public string eventstr;
    public System.Action <>9__3;
    
    // Methods
    public JoypacAdManager.<>c__DisplayClass46_0()
    {
    
    }
    internal void <ShowInterstitial>b__0()
    {
        var val_4;
        int val_5;
        System.Action val_6;
        LogTool.DebugLog(log:  ":没去掉广告，所以在回调里展示插屏", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "ShowInterstitial");
        val_4 = null;
        val_5 = JoypacAdManager.showInterCount + 1;
        JoypacAdManager.showInterCount = val_5;
        if((this.<>4__this) == null)
        {
                val_5 = 0;
        }
        
        if(val_5.showInterTip != false)
        {
                val_6 = this.<>9__3;
            if(val_6 == null)
        {
                System.Action val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action(object:  this, method:  System.Void JoypacAdManager.<>c__DisplayClass46_0::<ShowInterstitial>b__3());
            this.<>9__3 = val_6;
        }
        
            InterTipPopupView.Show(_closeCallback:  val_3);
            return;
        }
        
        this.<>4__this.ShowInterOnly(callback:  this.callback, interId:  this.interId, eventstr:  "ShowInterstitial");
    }
    internal void <ShowInterstitial>b__3()
    {
        this.<>4__this.ShowInterOnly(callback:  this.callback, interId:  this.interId, eventstr:  null);
    }
    internal void <ShowInterstitial>b__1()
    {
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(obj:  1);
    }
    internal void <ShowInterstitial>b__2()
    {
        this.<>4__this.ShowInterOnly(callback:  this.callback, interId:  this.interId, eventstr:  null);
    }

}
