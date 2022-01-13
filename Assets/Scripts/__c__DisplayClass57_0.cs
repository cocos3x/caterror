using UnityEngine;
private sealed class Purchaser.<>c__DisplayClass57_0
{
    // Fields
    public UnityEngine.Purchasing.Product product;
    public Purchaser <>4__this;
    
    // Methods
    public Purchaser.<>c__DisplayClass57_0()
    {
    
    }
    internal bool <ProcessPurchase>b__0(PurchaseItem pi)
    {
        return System.String.op_Equality(a:  pi.productId, b:  this.product.definition.id);
    }
    internal void <ProcessPurchase>b__1()
    {
        var val_5 = null;
        this.<>4__this.onPurchaseFailedEvent.Invoke(arg0:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.PurchaseFailedTitleTextId), arg1:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.ReceiptValidationFailedTextId));
    }

}
