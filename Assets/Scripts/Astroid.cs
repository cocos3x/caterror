using UnityEngine;
public class Astroid : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 torque;
    
    // Methods
    private void Awake()
    {
        int val_1 = UnityEngine.Random.Range(min:  99, max:  100);
        this.torque = 0;
        mem[1152921511845483552] = 0;
    }
    private void Update()
    {
        float val_7;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.torque, y = V9.16B, z = V10.16B}, d:  UnityEngine.Time.deltaTime);
        this.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Bounds val_5 = this.GetComponent<UnityEngine.SpriteRenderer>().bounds;
        UnityEngine.Vector3 val_9 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_7, y = val_3.y, z = val_3.z});
        if(val_9.y >= 0)
        {
                return;
        }
        
        this = this.gameObject;
        UnityEngine.Object.Destroy(obj:  this);
    }
    public Astroid()
    {
    
    }

}
