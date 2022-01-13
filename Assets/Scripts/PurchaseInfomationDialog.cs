using UnityEngine;
public sealed class PurchaseInfomationDialog : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text titleText;
    private UnityEngine.UI.Text explanationText;
    
    // Methods
    public void OnUpdateInfomation(string title, string explanation)
    {
        this.gameObject.SetActive(value:  true);
        if(this.explanationText == null)
        {
            
        }
    
    }
    public PurchaseInfomationDialog()
    {
    
    }

}
