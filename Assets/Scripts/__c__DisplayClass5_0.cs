using UnityEngine;
private sealed class SomethingTo.<>c__DisplayClass5_0
{
    // Fields
    public System.Action<float> update;
    
    // Methods
    public SomethingTo.<>c__DisplayClass5_0()
    {
    
    }
    internal void <SetUpdate>b__0(float lerp)
    {
        null = null;
        this.update.Invoke(obj:  AnimationCurveExtensions.Smooth01.Evaluate(time:  lerp));
    }

}
