using UnityEngine;
private sealed class ShopManager.<>c__DisplayClass15_1
{
    // Fields
    public NigenekoPurchasing.ProductType itemId;
    public ShopManager.<>c__DisplayClass15_0 CS$<>8__locals1;
    
    // Methods
    public ShopManager.<>c__DisplayClass15_1()
    {
    
    }
    internal void <InitializeUI>b__1()
    {
        SingletonMonoBehaviour<Purchaser>.Instance.BuyProduct(productType:  this.itemId);
        this.CS$<>8__locals1.<>4__this.SetCanvasGroupInteractable(interactable:  false);
    }

}
