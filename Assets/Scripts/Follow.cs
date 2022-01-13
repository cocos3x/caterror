using UnityEngine;
public class Follow : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform m_Target;
    
    // Methods
    private void Update()
    {
        if(this.m_Target == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.position;
        UnityEngine.Vector3 val_4 = this.m_Target.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public Follow()
    {
    
    }

}
