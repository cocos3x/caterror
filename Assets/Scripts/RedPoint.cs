using UnityEngine;
public class RedPoint : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject red;
    
    // Methods
    public void SetRedActive(bool show)
    {
        if(this.red == 0)
        {
                return;
        }
        
        this.red.SetActive(value:  show);
    }
    public RedPoint()
    {
    
    }

}
