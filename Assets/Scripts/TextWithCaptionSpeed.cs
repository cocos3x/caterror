using UnityEngine;
public class TextWithCaptionSpeed : TextWithCaptionSpeedParent
{
    // Methods
    protected override void UpdateText(string currentText, int displayCharacterCount)
    {
        this.text = currentText.Substring(startIndex:  0, length:  displayCharacterCount);
    }
    public TextWithCaptionSpeed()
    {
    
    }

}
