using UnityEngine;
public class AstroidManager : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject[] m_AstroidPrefabs;
    private float m_PerSecond;
    private float m_Time;
    
    // Methods
    private void Update()
    {
        float val_17;
        int val_18;
        val_17 = this.m_Time;
        float val_1 = UnityEngine.Time.deltaTime;
        float val_17 = this.m_PerSecond;
        val_1 = val_17 + val_1;
        this.m_Time = val_1;
        val_18 = (int)val_1 * val_17;
        if(val_18 < (1.401298E-45f))
        {
                return;
        }
        
        val_17 = (float)val_18 / val_17;
        val_1 = val_1 - val_17;
        this.m_Time = val_1;
        val_17 = 1.3f;
        do
        {
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.m_AstroidPrefabs[(long)UnityEngine.Random.Range(min:  0, max:  this.m_AstroidPrefabs.Length)]);
            int val_6 = UnityEngine.Random.Range(min:  0, max:  UnityEngine.Screen.width);
            int val_11 = UnityEngine.Random.Range(min:  UnityEngine.Screen.height + 10, max:  UnityEngine.Screen.height + 30);
            UnityEngine.Vector3 val_13 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_4.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            float val_15 = UnityEngine.Random.Range(min:  0.5f, max:  val_17);
            val_4.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_18 = val_18 - 1;
        }
        while(val_18 != 0);
    
    }
    public AstroidManager()
    {
        this.m_PerSecond = 0.5f;
    }

}
