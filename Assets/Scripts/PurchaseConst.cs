using UnityEngine;
public static class PurchaseConst
{
    // Fields
    public static readonly PurchaseItem[] ConsumableItems;
    public static readonly PurchaseItem[] NonConsumableItems;
    public static readonly string PurchasedDataTag;
    public static readonly string PurchasedNonConsumableItemIdListTag;
    public static readonly string PendingProductDictionaryTag;
    
    // Methods
    private static PurchaseConst()
    {
        PurchaseConst.ConsumableItems = new PurchaseItem[0];
        PurchaseItem[] val_2 = new PurchaseItem[1];
        UniRx.Unit..cctor();
        PurchaseItem val_4 = new PurchaseItem(productId:  0.ToString(), productNameWithApple:  "jp.usaya.nigeneko.ad_remove", productNameWithGooglePlay:  "nigeneko_ad_remove");
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_4 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_4 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = val_4;
        PurchaseConst.NonConsumableItems = val_2;
        PurchaseConst.PurchasedDataTag = "PurchasedData";
        PurchaseConst.PurchasedNonConsumableItemIdListTag = "PurchasedNonConsumableItemIdList";
        PurchaseConst.PendingProductDictionaryTag = "PendingProductDictionary";
    }

}
