using UnityEngine;
public sealed class GachaCameraPivot : MonoBehaviour
{
    // Fields
    private float size;
    private UnityEngine.Camera targetCamera;
    private float sizeMagnification;
    
    // Properties
    public float Size { get; }
    
    // Methods
    public float get_Size()
    {
        return (float)this.size;
    }
    private void Awake()
    {
        if(ScreenExtensions.IsNarrowScreen() == false)
        {
                return;
        }
        
        float val_5 = 1.778667f;
        float val_4 = (float)UnityEngine.Screen.height;
        val_4 = val_4 / (float)UnityEngine.Screen.width;
        val_5 = val_4 / val_5;
        this.sizeMagnification = val_5;
    }
    private void LateUpdate()
    {
        if(ScreenExtensions.IsNarrowScreen() != false)
        {
                float val_2 = this.size * this.sizeMagnification;
        }
        
        this.targetCamera.orthographicSize = this.size;
    }
    public GachaCameraPivot()
    {
        this.size = 6.67f;
        this.sizeMagnification = 1f;
    }

}
