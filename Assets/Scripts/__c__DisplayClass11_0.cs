using UnityEngine;
private sealed class SyncButtonPressedColor.<>c__DisplayClass11_0
{
    // Fields
    public SyncButtonPressedColor <>4__this;
    public UnityEngine.Color syncedColor;
    
    // Methods
    public SyncButtonPressedColor.<>c__DisplayClass11_0()
    {
    
    }
    internal void <ChangeColor>b__0(UnityEngine.Coroutine coroutine)
    {
        this.<>4__this.StopCoroutine(routine:  coroutine);
    }
    internal void <ChangeColor>b__1(UnityEngine.UI.Graphic graphic)
    {
        UnityEngine.Color val_5;
        float val_6;
        float val_7;
        float val_8;
        SyncButtonPressedColor.<>c__DisplayClass11_1 val_1 = new SyncButtonPressedColor.<>c__DisplayClass11_1();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .graphic = graphic;
        if(graphic != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        val_5 = V0.16B;
        val_6 = V1.16B;
        val_7 = V2.16B;
        val_8 = V3.16B;
        .fromColor = val_5;
        mem[1152921512076551660] = val_6;
        mem[1152921512076551664] = val_7;
        mem[1152921512076551668] = val_8;
        if(val_1 == null)
        {
                val_5 = (SyncButtonPressedColor.<>c__DisplayClass11_1)[1152921512076551632].fromColor;
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = val_5, g = val_6, b = val_7, a = val_8}, b:  new UnityEngine.Color() {r = this.syncedColor});
        .targetColor = val_2;
        mem[1152921512076551676] = val_2.g;
        mem[1152921512076551680] = val_2.b;
        mem[1152921512076551684] = val_2.a;
        this.<>4__this.coroutineList.Add(item:  MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this.<>4__this, duration:  this.<>4__this.fadeDuration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void SyncButtonPressedColor.<>c__DisplayClass11_1::<ChangeColor>b__2(float t))));
        return;
        label_1:
        mem[16] = graphic;
        if(mem[16] != 0)
        {
            goto label_9;
        }
        
        goto label_10;
    }

}
