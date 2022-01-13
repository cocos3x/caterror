using UnityEngine;
public class RemoveAdButton : JoypacIAPButton
{
    // Methods
    private void OnEnable()
    {
        if(JoypacUtils.IfRemoveAds() != false)
        {
                this.gameObject.SetActive(value:  false);
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public override void OnSuccessed(UnityEngine.Purchasing.Product product)
    {
        this.OnSuccessed(product:  product);
        this.gameObject.GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    public RemoveAdButton()
    {
    
    }

}
