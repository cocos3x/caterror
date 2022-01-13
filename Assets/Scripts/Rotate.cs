using UnityEngine;
public class Rotate : MonoBehaviour
{
    // Fields
    public int speed;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.back;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  (float)this.speed);
        this.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
    }
    public Rotate()
    {
        this.speed = 2;
    }

}
