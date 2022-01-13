using UnityEngine;
public sealed class CanvasFitter : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.CanvasScaler canvasScaler;
    
    // Methods
    private void Awake()
    {
        if(ScreenExtensions.IsNarrowScreen() == false)
        {
                return;
        }
        
        this.canvasScaler.matchWidthOrHeight = 0f;
    }
    public CanvasFitter()
    {
    
    }

}
