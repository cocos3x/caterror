using UnityEngine;
public abstract class TextWithCaptionSpeedParent : Text
{
    // Fields
    public UnityEngine.Events.UnityEvent onEndChangingCaption;
    public float intervalForCharacterDisplay;
    private bool isChangingCaption;
    private float timeUntilDisplay;
    protected string currentText;
    protected float timeElapsed;
    protected int lastUpdateCharacter;
    protected int textLength;
    
    // Properties
    public bool IsChangingCaption { get; }
    public float TimeUnitlDisplay { get; }
    
    // Methods
    public bool get_IsChangingCaption()
    {
        return (bool)this.isChangingCaption;
    }
    public float get_TimeUnitlDisplay()
    {
        return (float)this.timeUntilDisplay;
    }
    private void Update()
    {
        if(this.isChangingCaption == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.timeElapsed;
        val_1 = val_1 / this.timeUntilDisplay;
        float val_2 = UnityEngine.Mathf.Clamp01(value:  val_1);
        val_2 = val_2 * (float)this.textLength;
        if(this.lastUpdateCharacter == (int)val_2)
        {
                return;
        }
        
        this.lastUpdateCharacter = (int)val_2;
        if(this.currentText.Length != (int)val_2)
        {
                return;
        }
        
        this.ImmidiateEnd();
    }
    protected abstract void UpdateText(string currentText, int displayCharacterCount); // 0
    public void BeginChangingCaption(string text, float intervalForCharacterDisplay)
    {
        null = null;
        this.intervalForCharacterDisplay = intervalForCharacterDisplay;
        this.BeginChangingCaption(text:  text, callback:  ActionExtensions.EmptyAction);
    }
    public void BeginChangingCaption(string text, float intervalForCharacterDisplay, System.Action callback)
    {
        this.intervalForCharacterDisplay = intervalForCharacterDisplay;
        this.BeginChangingCaption(text:  text, callback:  callback);
    }
    public void BeginChangingCaption(float intervalForCharacterDisplay)
    {
        null = null;
        this.intervalForCharacterDisplay = intervalForCharacterDisplay;
        this.BeginChangingCaption(text:  this.text, callback:  ActionExtensions.EmptyAction);
    }
    public void BeginChangingCaption(float intervalForCharacterDisplay, System.Action callback)
    {
        this.intervalForCharacterDisplay = intervalForCharacterDisplay;
        this.BeginChangingCaption(text:  this.text, callback:  callback);
    }
    public void BeginChangingCaption(string text)
    {
        null = null;
        this.BeginChangingCaption(text:  text, callback:  ActionExtensions.EmptyAction);
    }
    public void BeginChangingCaption()
    {
        var val_2 = null;
        this.BeginChangingCaption(text:  this.text, callback:  ActionExtensions.EmptyAction);
    }
    public void BeginChangingCaption(System.Action callback)
    {
        this.BeginChangingCaption(text:  this.text, callback:  callback);
    }
    public void BeginChangingCaption(string text, System.Action callback)
    {
        .callback = callback;
        this.currentText = text;
        this.isChangingCaption = true;
        this.onEndChangingCaption.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new TextWithCaptionSpeedParent.<>c__DisplayClass21_0(), method:  System.Void TextWithCaptionSpeedParent.<>c__DisplayClass21_0::<BeginChangingCaption>b__0()));
        float val_6 = this.intervalForCharacterDisplay;
        val_6 = val_6 * (float)this.currentText.Length;
        this.timeUntilDisplay = val_6;
        this.textLength = this.currentText.Length;
        this.timeElapsed = UnityEngine.Time.realtimeSinceStartup;
        this.lastUpdateCharacter = 0;
    }
    public void ImmidiateEnd()
    {
        this.isChangingCaption = false;
        this.onEndChangingCaption.Invoke();
        this.text = this.currentText;
    }
    protected TextWithCaptionSpeedParent()
    {
        this.intervalForCharacterDisplay = 0.05f;
        this.currentText = System.String.alignConst;
        this.timeElapsed = 1.007812f;
        this.lastUpdateCharacter = 0;
    }

}
