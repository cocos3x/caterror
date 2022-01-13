using UnityEngine;
public class JoypacIAP : MonoBehaviour
{
    // Fields
    private string removeAdsId;
    private static JoypacIAP instance;
    private static UnityEngine.Transform obj;
    
    // Properties
    public static JoypacIAP Instance { get; }
    
    // Methods
    public static JoypacIAP get_Instance()
    {
        JoypacIAP val_7;
        var val_8;
        val_7 = JoypacIAP.instance;
        if(val_7 != 0)
        {
                return (JoypacIAP)JoypacIAP.instance;
        }
        
        if(JoypacIAP.obj == 0)
        {
                val_8 = null;
            JoypacIAP.obj = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "Joypac/JoypacIAP"));
        }
        else
        {
                val_8 = null;
        }
        
        val_7 = JoypacIAP.obj.gameObject;
        JoypacIAP.instance = val_7.GetComponent<JoypacIAP>();
        return (JoypacIAP)JoypacIAP.instance;
    }
    public void Init()
    {
    
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnEnable()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void OnPurchaseComplete(UnityEngine.Purchasing.Product product)
    {
        UnityEngine.Debug.LogError(message:  product.definition.id);
        if((System.String.op_Equality(a:  product.definition.id, b:  this.removeAdsId)) != false)
        {
                JoypacUtils.SetRemoveAdBought();
        }
        
        PopLoadingView.Hide();
    }
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
    {
        PopLoadingView.Hide();
    }
    public JoypacIAP()
    {
        this.removeAdsId = "us.nigeneko.removeads";
    }

}
