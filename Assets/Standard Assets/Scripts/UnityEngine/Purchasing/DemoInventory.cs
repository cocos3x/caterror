using UnityEngine;

namespace UnityEngine.Purchasing
{
    public class DemoInventory : MonoBehaviour
    {
        // Methods
        public void Fulfill(string productId)
        {
            string val_3;
            object val_4;
            val_3 = productId;
            if((System.String.op_Equality(a:  val_3, b:  "100.gold.coins")) != false)
            {
                    val_4 = "You Got Money!";
            }
            else
            {
                    val_3 = System.String.Format(format:  "Unrecognized productId \"{0}\"", arg0:  val_3);
                val_4 = val_3;
            }
            
            UnityEngine.Debug.Log(message:  val_4);
        }
        public DemoInventory()
        {
        
        }
    
    }

}
