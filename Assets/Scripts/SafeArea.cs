using UnityEngine;
public sealed class SafeArea : MonoBehaviour
{
    // Methods
    private void Start()
    {
        var val_11 = this.transform;
        UnityEngine.Rect val_2 = UnityEngine.Screen.safeArea;
        UnityEngine.Vector2 val_3 = val_2.m_XMin.position;
        UnityEngine.Vector2 val_4 = val_2.m_XMin.position;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        float val_11 = val_5.x;
        float val_12 = val_5.y;
        val_11 = val_11 / (float)UnityEngine.Screen.width;
        val_12 = val_12 / (float)UnityEngine.Screen.height;
        if(val_11 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        0.anchorMax = new UnityEngine.Vector2() {x = val_11, y = val_12};
        val_11 = 0;
        goto label_5;
        label_4:
        val_11.anchorMax = new UnityEngine.Vector2() {x = val_11, y = val_12};
        label_5:
        float val_13 = (float)UnityEngine.Screen.width;
        float val_14 = (float)UnityEngine.Screen.height;
        val_13 = val_3.x / val_13;
        val_14 = val_3.y / val_14;
        val_11.anchorMin = new UnityEngine.Vector2() {x = val_13, y = val_14};
    }
    public SafeArea()
    {
    
    }

}
