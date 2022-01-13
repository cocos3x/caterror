using UnityEngine;
private sealed class Cat.<>c__DisplayClass45_0
{
    // Fields
    public Cat <>4__this;
    public System.Action callback;
    
    // Methods
    public Cat.<>c__DisplayClass45_0()
    {
    
    }
    internal void <FirstHide>b__0(float t)
    {
        Cat val_3;
        UnityEngine.Transform val_4;
        Cat val_5;
        val_3 = this.<>4__this;
        if(val_3 == null)
        {
            goto label_1;
        }
        
        val_4 = this.<>4__this.catBody;
        val_5 = val_3;
        goto label_4;
        label_1:
        val_5 = this.<>4__this;
        val_4 = this.<>4__this.catBody;
        if(val_5 == null)
        {
            goto label_3;
        }
        
        val_3 = val_5;
        goto label_4;
        label_3:
        val_3 = this.<>4__this;
        if(val_3 == null)
        {
            goto label_5;
        }
        
        label_4:
        TransformExtensions.SetPositionY(t:  val_4, f:  UnityEngine.Mathf.Lerp(a:  this.<>4__this.searchPositionY, b:  this.<>4__this.hidePositionY, t:  FloatExtentions.EaseInOutCubic(t:  t)));
        return;
        label_5:
    }
    internal void <FirstHide>b__1()
    {
        this.<>4__this.isFirstHide = false;
        this.callback.Invoke();
    }

}
