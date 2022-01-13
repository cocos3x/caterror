using UnityEngine;
public class Coin : MonoBehaviour, IContinueInitializer
{
    // Methods
    public void Continue()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        if(val_2.x >= 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public Coin()
    {
    
    }

}
