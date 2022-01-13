using UnityEngine;
public class ImageColorTo : SomethingTo
{
    // Fields
    private UnityEngine.Color fromColor;
    private UnityEngine.Color targetColor;
    private UnityEngine.UI.Image image;
    
    // Methods
    private void Awake()
    {
        this.image = this.GetComponent<UnityEngine.UI.Image>();
    }
    private void Lerp(float lerp)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.fromColor}, b:  new UnityEngine.Color() {r = this.targetColor}, t:  lerp);
        this.image.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    public void ChangeColor(UnityEngine.Color targetColor)
    {
        this.image.color = new UnityEngine.Color() {r = targetColor.r, g = targetColor.g, b = targetColor.b, a = targetColor.a};
    }
    public void ChangeColor(UnityEngine.Color targetColor, float interval)
    {
        null = null;
        this.ChangeColor(targetColor:  new UnityEngine.Color() {r = targetColor.r, g = targetColor.g, b = targetColor.b, a = targetColor.a}, interval:  interval, callback:  ActionExtensions.EmptyAction);
    }
    public void ChangeColor(UnityEngine.Color targetColor, float interval, System.Action callback)
    {
        this.targetColor = targetColor;
        mem[1152921512060152116] = targetColor.g;
        mem[1152921512060152120] = targetColor.b;
        mem[1152921512060152124] = targetColor.a;
        UnityEngine.Color val_1 = this.image.color;
        this.fromColor = val_1;
        mem[1152921512060152100] = val_1.g;
        mem[1152921512060152104] = val_1.b;
        mem[1152921512060152108] = val_1.a;
        this.Begin(update:  new System.Action<System.Single>(object:  this, method:  System.Void ImageColorTo::Lerp(float lerp)), interval:  interval, callback:  callback, easingType:  0);
    }
    public void ChangeColor(UnityEngine.Color fromColor, UnityEngine.Color targetColor, float interval)
    {
        float val_1;
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        var val_6;
        val_1 = interval;
        val_2 = targetColor.b;
        val_3 = targetColor.r;
        val_4 = fromColor.b;
        val_5 = fromColor.r;
        val_1 = val_1;
        val_6 = null;
        val_2 = val_2;
        val_3 = val_3;
        val_4 = val_4;
        val_5 = val_5;
        val_1 = val_1;
        val_6 = null;
        this.ChangeColor(fromColor:  new UnityEngine.Color() {r = val_5, g = fromColor.g, b = val_4, a = fromColor.a}, targetColor:  new UnityEngine.Color() {r = val_3, g = targetColor.g, b = val_2, a = targetColor.a}, interval:  val_1, callback:  ActionExtensions.EmptyAction);
    }
    public void ChangeColor(UnityEngine.Color fromColor, UnityEngine.Color targetColor, float interval, System.Action callback)
    {
        this.image.color = new UnityEngine.Color() {r = fromColor.r, g = fromColor.g, b = fromColor.b, a = fromColor.a};
        this.ChangeColor(targetColor:  new UnityEngine.Color() {r = targetColor.r, g = targetColor.g, b = targetColor.b, a = targetColor.a}, interval:  interval, callback:  callback);
    }
    public ImageColorTo()
    {
    
    }

}
