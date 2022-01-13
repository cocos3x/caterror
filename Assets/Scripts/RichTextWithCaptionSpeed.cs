using UnityEngine;
public class RichTextWithCaptionSpeed : TextWithCaptionSpeedParent
{
    // Methods
    protected override void UpdateText(string currentText, int displayCharacterCount)
    {
        this.text = currentText.Insert(startIndex:  displayCharacterCount, value:  "<color=#ffffff00>")(currentText.Insert(startIndex:  displayCharacterCount, value:  "<color=#ffffff00>")) + "</color>"("</color>");
    }
    public RichTextWithCaptionSpeed()
    {
    
    }

}
