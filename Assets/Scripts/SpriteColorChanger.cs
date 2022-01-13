using UnityEngine;
public class SpriteColorChanger : MonoBehaviour
{
    // Fields
    private UnityEngine.Coroutine coroutine;
    
    // Methods
    public void ChangeColor(UnityEngine.Color color)
    {
        .color = color;
        mem[1152921512122399092] = color.g;
        mem[1152921512122399096] = color.b;
        mem[1152921512122399100] = color.a;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        bool val_4 = TransformExtensions.FindAllChildrensComponent<UnityEngine.SpriteRenderer>(t:  this.transform, func:  new System.Action<UnityEngine.SpriteRenderer>(object:  new SpriteColorChanger.<>c__DisplayClass1_0(), method:  System.Void SpriteColorChanger.<>c__DisplayClass1_0::<ChangeColor>b__0(UnityEngine.SpriteRenderer spriteRenderer)));
    }
    public void ChangeColorFade(UnityEngine.Color color, float duration)
    {
        null = null;
        this.ChangeColorFade(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, duration:  duration, callback:  ActionExtensions.EmptyAction);
    }
    public void ChangeColorFade(UnityEngine.Color color, float duration, System.Action callback)
    {
        SpriteColorChanger.<>c__DisplayClass3_0 val_1 = new SpriteColorChanger.<>c__DisplayClass3_0();
        .color = color;
        mem[1152921512122679420] = color.g;
        mem[1152921512122679424] = color.b;
        mem[1152921512122679428] = color.a;
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.coroutine);
        .list = new System.Collections.Generic.List<System.ValueTuple<UnityEngine.SpriteRenderer, UnityEngine.Color>>();
        bool val_5 = TransformExtensions.FindAllChildrensComponent<UnityEngine.SpriteRenderer>(t:  this.transform, func:  new System.Action<UnityEngine.SpriteRenderer>(object:  val_1, method:  System.Void SpriteColorChanger.<>c__DisplayClass3_0::<ChangeColorFade>b__0(UnityEngine.SpriteRenderer spriteRenderer)));
        this.coroutine = MonoBehaviourExtensions.CallLerp(monoBehaviour:  this, duration:  duration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void SpriteColorChanger.<>c__DisplayClass3_0::<ChangeColorFade>b__1(float t)), callback:  callback);
    }
    public SpriteColorChanger()
    {
    
    }

}
