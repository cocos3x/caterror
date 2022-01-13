using UnityEngine;
public class SyncButtonPressedColor : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    // Fields
    private float fadeDuration;
    private System.Collections.Generic.List<UnityEngine.UI.Graphic> syncGraphics;
    private System.Collections.Generic.Dictionary<UnityEngine.UI.Graphic, UnityEngine.Color> graphic2DefaultColorMap;
    private bool isPressed;
    private UnityEngine.UI.Button button;
    private System.Collections.Generic.List<UnityEngine.Coroutine> coroutineList;
    
    // Methods
    private void Awake()
    {
        object val_8 = this;
        this.button = this.GetComponent<UnityEngine.UI.Button>();
        this.graphic2DefaultColorMap = new System.Collections.Generic.Dictionary<UnityEngine.UI.Graphic, UnityEngine.Color>();
        this.isPressed = false;
        bool val_5 = TransformExtensions.FindAllChildrensComponent<UnityEngine.UI.Graphic>(t:  this.transform, func:  new System.Action<UnityEngine.UI.Graphic>(object:  this, method:  System.Void SyncButtonPressedColor::<Awake>b__6_0(UnityEngine.UI.Graphic graphic)));
        List.Enumerator<T> val_6 = this.syncGraphics.GetEnumerator();
        label_5:
        if(((-1122154248) & 1) == 0)
        {
            goto label_2;
        }
        
        this.graphic2DefaultColorMap.Add(key:  0.Id, value:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B});
        goto label_5;
        label_2:
        UniRx.Unit..cctor();
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        UnityEngine.UI.ColorBlock val_1 = this.button.colors;
        UnityEngine.Color val_2 = highlightedColor;
        this.isPressed = true;
        this.ChangeColor(graphics:  this.syncGraphics, syncedColor:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
    }
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.isPressed = false;
        this.ToDefaultColor(graphics:  this.syncGraphics);
    }
    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(this.isPressed == false)
        {
                return;
        }
        
        UnityEngine.UI.ColorBlock val_1 = this.button.colors;
        UnityEngine.Color val_2 = highlightedColor;
        this.ChangeColor(graphics:  this.syncGraphics, syncedColor:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
    }
    public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(this.isPressed == false)
        {
                return;
        }
        
        this.ToDefaultColor(graphics:  this.syncGraphics);
    }
    private void ChangeColor(System.Collections.Generic.List<UnityEngine.UI.Graphic> graphics, UnityEngine.Color syncedColor)
    {
        SyncButtonPressedColor.<>c__DisplayClass11_0 val_1 = new SyncButtonPressedColor.<>c__DisplayClass11_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .syncedColor = syncedColor;
        mem[1152921512075406828] = syncedColor.g;
        mem[1152921512075406832] = syncedColor.b;
        mem[1152921512075406836] = syncedColor.a;
        if(this.coroutineList.Count >= 1)
        {
                this.coroutineList.ForEach(action:  new System.Action<UnityEngine.Coroutine>(object:  val_1, method:  System.Void SyncButtonPressedColor.<>c__DisplayClass11_0::<ChangeColor>b__0(UnityEngine.Coroutine coroutine)));
            this.coroutineList.Clear();
        }
        
        graphics.ForEach(action:  new System.Action<UnityEngine.UI.Graphic>(object:  val_1, method:  System.Void SyncButtonPressedColor.<>c__DisplayClass11_0::<ChangeColor>b__1(UnityEngine.UI.Graphic graphic)));
        new System.Action() = new System.Action(object:  this.coroutineList, method:  typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_290);
        UnityEngine.Coroutine val_6 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  this.fadeDuration, act:  new System.Action());
    }
    private void ToDefaultColor(System.Collections.Generic.List<UnityEngine.UI.Graphic> graphics)
    {
        if(this.coroutineList.Count > 0)
        {
                this.coroutineList.ForEach(action:  new System.Action<UnityEngine.Coroutine>(object:  this, method:  System.Void SyncButtonPressedColor::<ToDefaultColor>b__12_0(UnityEngine.Coroutine coroutine)));
            this.coroutineList.Clear();
        }
        
        graphics.ForEach(action:  new System.Action<UnityEngine.UI.Graphic>(object:  this, method:  System.Void SyncButtonPressedColor::<ToDefaultColor>b__12_1(UnityEngine.UI.Graphic graphic)));
        new System.Action() = new System.Action(object:  this.coroutineList, method:  typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_290);
        UnityEngine.Coroutine val_5 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  this.fadeDuration, act:  new System.Action());
    }
    public SyncButtonPressedColor()
    {
        System.Collections.Generic.List<UnityEngine.UI.Graphic> val_1 = 21252;
        this.fadeDuration = 0.1f;
        val_1 = new System.Collections.Generic.List<UnityEngine.UI.Graphic>();
        this.syncGraphics = val_1;
        this.coroutineList = new System.Collections.Generic.List<UnityEngine.Coroutine>();
    }
    private void <Awake>b__6_0(UnityEngine.UI.Graphic graphic)
    {
        this.syncGraphics.Add(item:  graphic);
    }
    private void <ToDefaultColor>b__12_0(UnityEngine.Coroutine coroutine)
    {
        this.StopCoroutine(routine:  coroutine);
    }
    private void <ToDefaultColor>b__12_1(UnityEngine.UI.Graphic graphic)
    {
        SyncButtonPressedColor.<>c__DisplayClass12_0 val_1 = new SyncButtonPressedColor.<>c__DisplayClass12_0();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .graphic = graphic;
        if(graphic != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        .fromColor = V0.16B;
        mem[1152921512076145004] = V1.16B;
        mem[1152921512076145008] = V2.16B;
        mem[1152921512076145012] = V3.16B;
        UnityEngine.Color val_2 = this.graphic2DefaultColorMap.Item[.graphic];
        .targetColor = val_2;
        mem[1152921512076145020] = val_2.g;
        mem[1152921512076145024] = val_2.b;
        mem[1152921512076145028] = val_2.a;
        this.coroutineList.Add(item:  MonoBehaviourExtensions.CallLerpSmooth(monoBehaviour:  this, duration:  this.fadeDuration, act:  new System.Action<System.Single>(object:  val_1, method:  System.Void SyncButtonPressedColor.<>c__DisplayClass12_0::<ToDefaultColor>b__2(float t))));
        return;
        label_1:
        mem[16] = graphic;
        if(mem[16] != 0)
        {
            goto label_8;
        }
        
        goto label_9;
    }

}
