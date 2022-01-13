using UnityEngine;
private sealed class JoypacAdManager.<LoadAds>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public JoypacAdManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JoypacAdManager.<LoadAds>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        this.<>4__this.LoadBanner();
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        LogTool.DebugLog(log:  "Joypac:初始化激励视频", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadAds");
        this.<>4__this.LoadVideo();
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.ShowBanner();
        LogTool.DebugLog(log:  "Joypac:初始化插屏", color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/JoypacAdManager.cs", name:  "LoadAds");
        this.<>4__this.LoadInterstitial(interId:  "hidegpIV");
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = 2;
        val_3 = 1;
        return (bool)val_3;
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
