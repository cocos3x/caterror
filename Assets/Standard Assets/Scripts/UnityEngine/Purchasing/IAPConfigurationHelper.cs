using UnityEngine;

namespace UnityEngine.Purchasing
{
    public static class IAPConfigurationHelper
    {
        // Methods
        public static void PopulateConfigurationBuilder(ref UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.Purchasing.ProductCatalog catalog)
        {
            var val_29;
            var val_31;
            UnityEngine.Purchasing.IDs val_32;
            var val_33;
            var val_34;
            UnityEngine.Purchasing.ProductType val_37;
            UnityEngine.Purchasing.IDs val_39;
            var val_40;
            var val_46;
            System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> val_48;
            var val_52;
            string val_55;
            var val_56;
            var val_57;
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_31 = 1152921504683896832;
            val_32 = catalog.allValidProducts.GetEnumerator();
            val_33 = 0;
            val_34 = 0;
            label_112:
            var val_40 = 0;
            val_40 = val_40 + 1;
            if(val_32.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_37 = val_32.Current;
            var val_42 = 0;
            val_42 = val_42 + 1;
            if(val_37.allStoreIDs.Count < 1)
            {
                goto label_24;
            }
            
            val_39 = new UnityEngine.Purchasing.IDs();
            val_40 = 1152921504683896832;
            val_39 = new UnityEngine.Purchasing.IDs();
            var val_43 = 0;
            val_43 = val_43 + 1;
            goto label_30;
            label_24:
            val_40 = 1152921504683896832;
            val_39 = 0;
            goto label_65;
            label_30:
            System.Collections.Generic.IEnumerator<T> val_14 = val_37.allStoreIDs.GetEnumerator();
            label_49:
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_14.MoveNext() == false)
            {
                goto label_37;
            }
            
            var val_45 = 0;
            val_45 = val_45 + 1;
            T val_18 = val_14.Current;
            string[] val_19 = new string[1];
            val_19[0] = val_18 + 16;
            new UnityEngine.Purchasing.IDs().Add(id:  val_18 + 24, stores:  val_19);
            goto label_49;
            label_37:
            val_34 = val_34 + 1;
            mem2[0] = 122;
            if(val_14 == null)
            {
                
            }
            else
            {
                    var val_46 = 0;
                val_46 = val_46 + 1;
                val_14.Dispose();
            }
            
            if((val_34 != 1) && ((-1433565024 + ((val_34 + 1)) << 2) == 122))
            {
                    var val_47 = 0;
                val_47 = val_47 ^ (val_34 >> 31);
                val_34 = val_34 + val_47;
            }
            else
            {
                    if( != false)
            {
                    val_46 = 0;
            }
            
            }
            
            label_65:
            val_48 = null;
            val_48 = new System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition>();
            var val_48 = 0;
            val_48 = val_48 + 1;
            System.Collections.Generic.IEnumerator<T> val_24 = val_37.Payouts.GetEnumerator();
            label_88:
            var val_49 = 0;
            val_49 = val_49 + 1;
            if(val_24.MoveNext() == false)
            {
                goto label_77;
            }
            
            var val_50 = 0;
            val_50 = val_50 + 1;
            T val_28 = val_24.Current;
            new UnityEngine.Purchasing.PayoutDefinition() = new UnityEngine.Purchasing.PayoutDefinition(typeString:  val_28.typeString, subtype:  val_28.subtype, quantity:  val_28.quantity, data:  val_28.data);
            null.Add(item:  new UnityEngine.Purchasing.PayoutDefinition());
            goto label_88;
            label_77:
            val_52 = val_34 + 1;
            mem2[0] = 214;
            if(val_24 == null)
            {
                
            }
            else
            {
                    var val_51 = 0;
                val_51 = val_51 + 1;
                val_24.Dispose();
            }
            
            if(( != 1) && (mem[1152921511912317376] == 214))
            {
                    var val_52 = 0;
                val_52 = val_52 ^ 0;
                 =  + val_52;
            }
            
            if( != null)
            {
                
            }
            else
            {
                    val_55 = 11993091;
            }
            
            UnityEngine.Purchasing.ConfigurationBuilder val_36 = builder.AddProduct(id:  val_55, type:  null, storeIDs:  null, payouts:  null.ToArray());
            goto label_112;
            label_12:
            val_56 = val_34 + 1;
            mem2[0] = 264;
            if(val_32 == null)
            {
                
            }
            else
            {
                    var val_53 = 0;
                val_53 = val_53 + 1;
            }
            
            if(val_56 == 1)
            {
                goto label_139;
            }
            
            if(( == false) || ((-1433565024 + ((val_34 + 1)) << 2) == 264))
            {
                goto label_141;
            }
            
            label_142:
            val_29 = ???;
            val_32 = ???;
            val_57 = ???;
            val_31 = ???;
            label_139:
            if(val_57 != 0)
            {
                goto label_142;
            }
            
            label_141:
            var val_38 = val_29 - 96;
        }
    
    }

}
