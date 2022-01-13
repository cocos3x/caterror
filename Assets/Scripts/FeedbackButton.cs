using UnityEngine;
public class FeedbackButton : JPButton
{
    // Methods
    public override void OnClick()
    {
        JoypacUtils.OpenReviewURL();
    }
    private void OnEnable()
    {
    
    }
    public FeedbackButton()
    {
    
    }

}
