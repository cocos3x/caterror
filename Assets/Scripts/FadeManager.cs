using UnityEngine;
public class FadeManager : SingletonMonoBehaviour<FadeManager>
{
    // Fields
    private bool isAutoFadeIn;
    public UnityEngine.Color fadeColor;
    public UnityEngine.Events.UnityEvent onFadeInEnd;
    public UnityEngine.Events.UnityEvent onFadeOutEnd;
    private UnityEngine.Texture2D texture;
    private float fadeAlpha;
    private bool isFading;
    private float timer;
    private System.Action<float> fadeFunc;
    
    // Properties
    public bool IsFading { get; }
    
    // Methods
    public bool get_IsFading()
    {
        return (bool)this.isFading;
    }
    private void Awake()
    {
        if(this.CheckInstance() != false)
        {
                return;
        }
        
        if(this.isAutoFadeIn != false)
        {
                this.isFading = true;
            this.fadeAlpha = 1f;
            UnityEngine.Coroutine val_3 = MonoBehaviourExtensions.CallWaitForFrame(monoBehaviour:  this, frameCount:  2, act:  new System.Action(object:  this, method:  System.Void FadeManager::<Awake>b__11_0()));
        }
        
        UnityEngine.Texture2D val_4 = new UnityEngine.Texture2D(width:  2, height:  2, textureFormat:  5, mipChain:  false);
        this.texture = val_4;
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        val_4.SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.texture.SetPixel(x:  0, y:  1, color:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        UnityEngine.Color val_7 = UnityEngine.Color.white;
        this.texture.SetPixel(x:  1, y:  0, color:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
        UnityEngine.Color val_8 = UnityEngine.Color.white;
        this.texture.SetPixel(x:  1, y:  1, color:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
        this.texture.Apply();
    }
    private void OnGUI()
    {
        float val_2;
        if(this.isFading != false)
        {
                float val_2 = this.timer;
            val_2 = val_2 + UnityEngine.Time.unscaledDeltaTime;
            this.timer = val_2;
            this.fadeFunc.Invoke(obj:  val_2);
            val_2 = this.fadeAlpha;
            mem[1152921512035655608] = this.fadeAlpha;
        }
        else
        {
                val_2 = this.fadeAlpha;
        }
        
        if(val_2 <= 0f)
        {
                return;
        }
        
        this.DrawTexture(color:  new UnityEngine.Color() {r = this.fadeColor});
    }
    public void FadeIn(float interval = 1)
    {
        null = null;
        this.FadeIn(interval:  interval, callback:  ActionExtensions.EmptyAction);
    }
    public void FadeIn(float interval, System.Action callback)
    {
        FadeManager.<>c__DisplayClass14_0 val_1 = new FadeManager.<>c__DisplayClass14_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .interval = interval;
        }
        else
        {
                mem[16] = this;
            mem[24] = interval;
        }
        
        .callback = callback;
        this.timer = 0f;
        this.isFading = true;
        this.fadeFunc = new System.Action<System.Single>(object:  val_1, method:  System.Void FadeManager.<>c__DisplayClass14_0::<FadeIn>b__0(float t));
    }
    public void FadeOut(float interval, System.Action callback)
    {
        this.FadeOut(interval:  interval, callback:  callback, color:  new UnityEngine.Color() {r = this.fadeColor});
    }
    public void FadeOut(float interval, System.Action callback, UnityEngine.Color color)
    {
        FadeManager.<>c__DisplayClass16_0 val_1 = new FadeManager.<>c__DisplayClass16_0();
        if(val_1 != null)
        {
                .<>4__this = this;
            .interval = interval;
        }
        else
        {
                mem[16] = this;
            mem[24] = interval;
        }
        
        .callback = callback;
        this.fadeColor = color;
        mem[1152921512036154800] = color.g;
        mem[1152921512036154804] = color.b;
        mem[1152921512036154808] = color.a;
        this.timer = 0f;
        this.isFading = true;
        this.fadeFunc = new System.Action<System.Single>(object:  val_1, method:  System.Void FadeManager.<>c__DisplayClass16_0::<FadeOut>b__0(float t));
    }
    private void DrawTexture(UnityEngine.Color color)
    {
        UnityEngine.GUI.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  this.texture);
    }
    public void FadeOutToTransition(float interval, string sceneName)
    {
        .sceneName = sceneName;
        this.FadeOut(interval:  interval, callback:  new System.Action(object:  new FadeManager.<>c__DisplayClass18_0(), method:  System.Void FadeManager.<>c__DisplayClass18_0::<FadeOutToTransition>b__0()), color:  new UnityEngine.Color() {r = this.fadeColor});
    }
    public void Show()
    {
        this.fadeAlpha = 1f;
    }
    public void Hide()
    {
        this.fadeAlpha = 0f;
    }
    public FadeManager()
    {
        var val_2;
        this.isAutoFadeIn = true;
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        this.fadeColor = val_1;
        mem[1152921512036761904] = val_1.g;
        mem[1152921512036761908] = val_1.b;
        mem[1152921512036761912] = val_1.a;
        val_2 = null;
        val_2 = null;
        this.fadeFunc = ActionExtensions.EmptyActionFloat;
    }
    private void <Awake>b__11_0()
    {
        this.FadeIn(interval:  0.5f);
    }

}
