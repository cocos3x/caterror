using UnityEngine;
public class SyncButtonColor : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Selectable selectable;
    private float fadeDuration;
    private System.Collections.Generic.Dictionary<UnityEngine.UI.Graphic, UnityEngine.Color> graphicDefaultColorMap;
    private System.Collections.Generic.List<UnityEngine.Coroutine> coroutineList;
    
    // Methods
    private void Awake()
    {
        UnityEngine.UI.Selectable val_1 = this.GetComponent<UnityEngine.UI.Selectable>();
        this.selectable = val_1;
        if(val_1.transition != 1)
        {
                return;
        }
        
        UnityEngine.UI.ColorBlock val_3 = this.selectable.colors;
        this.fadeDuration = superscriptSize;
        bool val_7 = TransformExtensions.FindAllChildrensComponent<UnityEngine.UI.Graphic>(t:  this.transform, func:  new System.Action<UnityEngine.UI.Graphic>(object:  this, method:  System.Void SyncButtonColor::<Awake>b__4_0(UnityEngine.UI.Graphic graphic)));
        System.IDisposable val_14 = UniRx.ObservableExtensions.Subscribe<System.Boolean>(source:  UniRx.Observable.Skip<System.Boolean>(source:  UniRx.Observable.DistinctUntilChanged<System.Boolean>(source:  UniRx.Observable.Select<UniRx.Unit, System.Boolean>(source:  UniRx.Triggers.ObservableTriggerExtensions.LateUpdateAsObservable(component:  this), selector:  new System.Func<UniRx.Unit, System.Boolean>(object:  this, method:  System.Boolean SyncButtonColor::<Awake>b__4_1(UniRx.Unit _)))), count:  1), onNext:  new System.Action<System.Boolean>(object:  this, method:  System.Void SyncButtonColor::ChangeInteractable(bool interactable)));
    }
    private void Start()
    {
        this.OnEnable();
    }
    private void OnEnable()
    {
        if(this.selectable.transition != 1)
        {
                return;
        }
        
        if(this.selectable.interactable != false)
        {
                return;
        }
        
        this.ImmediateChangeDisabledColor();
    }
    private void ChangeInteractable(bool interactable)
    {
        List.Enumerator<T> val_1 = this.coroutineList.GetEnumerator();
        label_3:
        if(((-1124060376) & 1) == 0)
        {
            goto label_2;
        }
        
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  0.Id);
        goto label_3;
        label_2:
        UniRx.Unit..cctor();
        this.coroutineList.Clear();
        if(interactable != false)
        {
                this.ChangeDefaultColor();
            return;
        }
        
        this.ChangeDisabledColor();
    }
    private void ImmediateChangeDisabledColor()
    {
        float val_5;
        System.Collections.Generic.Dictionary<UnityEngine.UI.Graphic, UnityEngine.Color> val_8;
        UnityEngine.UI.ColorBlock val_1 = this.selectable.colors;
        UnityEngine.Color val_2 = pressedColor;
        val_8 = this.graphicDefaultColorMap;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_8.GetEnumerator();
        label_5:
        if(((-1123913672) & 1) == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Color val_7 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = val_5, g = val_2.g, b = val_2.b, a = val_2.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        if(val_5.Id != null)
        {
            goto label_5;
        }
        
        goto label_5;
        label_3:
        UniRx.Unit..cctor();
    }
    private void ChangeDisabledColor()
    {
        float val_5;
        var val_8;
        System.Collections.Generic.KeyValuePair<UnityEngine.UI.Graphic, UnityEngine.Color> val_9;
        UnityEngine.MonoBehaviour val_15;
        var val_16;
        UnityEngine.Color val_17;
        float val_18;
        float val_19;
        float val_20;
        val_15 = this;
        UnityEngine.UI.ColorBlock val_1 = this.selectable.colors;
        UnityEngine.Color val_2 = pressedColor;
        Dictionary.Enumerator<TKey, TValue> val_3 = this.graphicDefaultColorMap.GetEnumerator();
        label_12:
        if(((-1123747312) & 1) == 0)
        {
            goto label_3;
        }
        
        new SyncButtonColor.<>c__DisplayClass9_0() = new System.Object();
        mem[1152921512073090928] = val_8;
        .kvp = val_9;
        new SyncButtonColor.<>c__DisplayClass9_1() = new System.Object();
        if((new SyncButtonColor.<>c__DisplayClass9_1()) != null)
        {
                val_16 = new SyncButtonColor.<>c__DisplayClass9_1();
            .CS$<>8__locals1 = new SyncButtonColor.<>c__DisplayClass9_0();
        }
        else
        {
                mem[48] = new SyncButtonColor.<>c__DisplayClass9_0();
            val_16 = 48;
        }
        
        string val_12 = val_16 + 16.Id;
        val_17 = val_9;
        val_18 = val_5;
        val_19 = val_2.b;
        val_20 = val_2.a;
        .fromColor = val_17;
        mem[1152921512073095012] = val_18;
        mem[1152921512073095016] = val_19;
        mem[1152921512073095020] = val_20;
        if((new SyncButtonColor.<>c__DisplayClass9_1()) == null)
        {
                val_17 = (SyncButtonColor.<>c__DisplayClass9_1)[1152921512073094992].fromColor;
        }
        
        UnityEngine.Color val_13 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = val_17, g = val_18, b = val_19, a = val_20}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        .targetColor = val_13;
        mem[1152921512073095028] = val_13.g;
        mem[1152921512073095032] = val_13.b;
        mem[1152921512073095036] = val_13.a;
        System.Action<System.Single> val_14 = new System.Action<System.Single>(object:  new SyncButtonColor.<>c__DisplayClass9_1(), method:  System.Void SyncButtonColor.<>c__DisplayClass9_1::<ChangeDisabledColor>b__0(float t));
        this.coroutineList.Add(item:  MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  this.fadeDuration, act:  null));
        goto label_12;
        label_3:
        UniRx.Unit..cctor();
    }
    private void ChangeDefaultColor()
    {
        var val_4;
        System.Collections.Generic.KeyValuePair<UnityEngine.UI.Graphic, UnityEngine.Color> val_6;
        object val_12;
        var val_13;
        val_12 = this;
        if(this.coroutineList.Count >= 1)
        {
                this.coroutineList.ForEach(action:  new System.Action<UnityEngine.Coroutine>(object:  this, method:  System.Void SyncButtonColor::<ChangeDefaultColor>b__10_0(UnityEngine.Coroutine coroutine)));
            this.coroutineList.Clear();
        }
        
        Dictionary.Enumerator<TKey, TValue> val_3 = this.graphicDefaultColorMap.GetEnumerator();
        label_17:
        if(((-1123549120) & 1) == 0)
        {
            goto label_6;
        }
        
        new SyncButtonColor.<>c__DisplayClass10_0() = new System.Object();
        mem[1152921512073297136] = val_4;
        .kvp = val_6;
        new SyncButtonColor.<>c__DisplayClass10_1() = new System.Object();
        if((new SyncButtonColor.<>c__DisplayClass10_1()) != null)
        {
                val_13 = new SyncButtonColor.<>c__DisplayClass10_1();
            .CS$<>8__locals1 = new SyncButtonColor.<>c__DisplayClass10_0();
        }
        else
        {
                mem[48] = new SyncButtonColor.<>c__DisplayClass10_0();
            val_13 = 48;
        }
        
        string val_10 = val_13 + 16.Id;
        .fromColor = val_6;
        mem[1152921512073301220] = val_4;
        mem[1152921512073301224] = V2.16B;
        mem[1152921512073301228] = V3.16B;
        SyncButtonColor.<>c__DisplayClass10_0 val_11 = mem[48] + 16;
        .targetColor = val_6;
        mem[1152921512073301236] = val_4;
        mem[1152921512073301240] = V2.16B;
        mem[1152921512073301244] = V3.16B;
        System.Action<System.Single> val_12 = new System.Action<System.Single>(object:  new SyncButtonColor.<>c__DisplayClass10_1(), method:  System.Void SyncButtonColor.<>c__DisplayClass10_1::<ChangeDefaultColor>b__1(float t));
        this.coroutineList.Add(item:  MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  this.fadeDuration, act:  null));
        goto label_17;
        label_6:
        UniRx.Unit..cctor();
    }
    public SyncButtonColor()
    {
        this.graphicDefaultColorMap = new System.Collections.Generic.Dictionary<UnityEngine.UI.Graphic, UnityEngine.Color>();
        this.coroutineList = new System.Collections.Generic.List<UnityEngine.Coroutine>();
    }
    private void <Awake>b__4_0(UnityEngine.UI.Graphic graphic)
    {
        this.graphicDefaultColorMap.Add(key:  graphic, value:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B});
    }
    private bool <Awake>b__4_1(UniRx.Unit _)
    {
        if(this.selectable != null)
        {
                return this.selectable.interactable;
        }
        
        return this.selectable.interactable;
    }
    private void <ChangeDefaultColor>b__10_0(UnityEngine.Coroutine coroutine)
    {
        this.StopCoroutine(routine:  coroutine);
    }

}
