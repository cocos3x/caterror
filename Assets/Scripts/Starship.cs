using UnityEngine;
public class Starship : MonoBehaviour
{
    // Fields
    private float m_Speed;
    
    // Methods
    private void Update()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.m_Speed);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  UnityEngine.Time.deltaTime);
        this.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    public Starship()
    {
        this.m_Speed = 1f;
    }

}
