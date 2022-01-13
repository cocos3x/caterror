using UnityEngine;
public sealed class CameraPivot : MonoBehaviour
{
    // Fields
    private float size;
    private UnityEngine.Camera mainCamera;
    private float sizeMagnification;
    
    // Properties
    public float Size { get; }
    public UnityEngine.Camera Camera { get; }
    public float SizeMagnification { get; }
    
    // Methods
    public float get_Size()
    {
        return (float)this.size;
    }
    public UnityEngine.Camera get_Camera()
    {
        return (UnityEngine.Camera)this.mainCamera;
    }
    public float get_SizeMagnification()
    {
        return (float)this.sizeMagnification;
    }
    private void Awake()
    {
        this.sizeMagnification = 1.217391f;
        if(this.mainCamera == 0)
        {
                return;
        }
        
        UnityEngine.AudioListener val_2 = UnityEngine.Object.FindObjectOfType<UnityEngine.AudioListener>();
        if(val_2 == 0)
        {
                UnityEngine.AudioListener val_5 = this.gameObject.AddComponent<UnityEngine.AudioListener>();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  val_2.gameObject.name);
    }
    private void LateUpdate()
    {
        this.mainCamera.orthographicSize = this.size * this.sizeMagnification;
    }
    public void ChangeSize(float size)
    {
        this.size = size;
    }
    public CameraPivot()
    {
        this.size = 5f;
        this.sizeMagnification = 1f;
    }

}
