using UnityEngine;
public class FpsManager : JoypacSingleMonoBehaviour<FpsManager>
{
    // Fields
    public float fpsMeasuringDelta;
    private float timePassed;
    private int m_FrameCount;
    private float m_FPS;
    
    // Methods
    public void Init()
    {
    
    }
    private void Start()
    {
        this.timePassed = 0f;
    }
    private void Update()
    {
        int val_2 = this.m_FrameCount;
        val_2 = val_2 + 1;
        this.m_FrameCount = val_2;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.timePassed + val_1;
        this.timePassed = val_1;
        if(val_1 <= this.fpsMeasuringDelta)
        {
                return;
        }
        
        this.timePassed = 0f;
        this.m_FrameCount = 0;
        val_1 = (float)this.m_FrameCount / val_1;
        this.m_FPS = val_1;
    }
    private void OnGUI()
    {
        UnityEngine.GUIStyle val_1 = new UnityEngine.GUIStyle();
        val_1.normal.background = 0;
        val_1.normal.textColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_1.fontSize = 40;
        int val_4 = UnityEngine.Screen.width;
        var val_5 = (val_4 < 0) ? (val_4 + 1) : (val_4);
        val_5 = val_5 >> 1;
        val_5 = val_5 - 40;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "FPS: "("FPS: ") + this.m_FPS, style:  val_1);
    }
    public FpsManager()
    {
        this.fpsMeasuringDelta = 2f;
    }

}
