using UnityEngine;
private sealed class GameManager.<>c__DisplayClass73_0
{
    // Fields
    public GameManager <>4__this;
    public float from;
    
    // Methods
    public GameManager.<>c__DisplayClass73_0()
    {
    
    }
    internal void <ShowAvatar>b__0(float t)
    {
        TransformExtensions.SetPositionY(t:  this.<>4__this.cameraPivot.transform, f:  UnityEngine.Mathf.Lerp(a:  this.from, b:  -4.5f, t:  FloatExtentions.EaseInOutSinusoidal(t:  t)));
    }

}
