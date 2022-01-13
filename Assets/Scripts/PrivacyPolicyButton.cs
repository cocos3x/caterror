using UnityEngine;
public class PrivacyPolicyButton : JPButton
{
    // Methods
    public override void OnClick()
    {
        UnityEngine.Debug.Log(message:  "Privacy button clicked");
        JoypacUtils.OpenPrivacyURL();
    }
    public PrivacyPolicyButton()
    {
    
    }

}
