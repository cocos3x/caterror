using UnityEngine;
[Serializable]
public sealed class ProductUISet
{
    // Fields
    public NigenekoPurchasing.ProductType itemId;
    public UnityEngine.GameObject[] itemObjects;
    public UnityEngine.GameObject soldOutObject;
    public UnityEngine.UI.Button button;
    public UnityEngine.UI.Text priceText;
    public UnityEngine.UI.Text ownCountText;
    
    // Methods
    public ProductUISet()
    {
    
    }

}
