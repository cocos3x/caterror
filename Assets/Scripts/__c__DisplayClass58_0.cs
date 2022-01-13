using UnityEngine;
private sealed class Purchaser.<>c__DisplayClass58_0
{
    // Fields
    public Purchaser <>4__this;
    public UnityEngine.Purchasing.Product product;
    
    // Methods
    public Purchaser.<>c__DisplayClass58_0()
    {
    
    }
    internal void <PurchaseSuccess>b__0()
    {
        var val_5 = null;
        this.<>4__this.onPurchaseFailedEvent.Invoke(arg0:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.PurchaseFailedTitleTextId), arg1:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.UnLinkTextId));
    }
    internal bool <PurchaseSuccess>b__1(PurchaseItem pi)
    {
        return System.String.op_Equality(a:  pi.productId, b:  this.product.definition.id);
    }
    internal bool <PurchaseSuccess>b__3(string id)
    {
        return System.String.op_Equality(a:  id, b:  this.product.definition.id);
    }
    internal void <PurchaseSuccess>b__2()
    {
        var val_8 = null;
        this.<>4__this.onPurchaseSucceedEvent.Invoke(arg0:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.PurchaseSucceedTextId), arg1:  System.String.Format(format:  SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  Purchaser.PurchaseSucceedTextFormatId), arg0:  this.product.metadata.localizedTitle));
    }

}
