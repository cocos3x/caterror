using UnityEngine;
public class CaptchaRenderTexture : MonoBehaviour
{
    // Fields
    private UnityEngine.Camera cam;
    
    // Methods
    private void Awake()
    {
        this.cam = this.GetComponent<UnityEngine.Camera>();
    }
    public UnityEngine.Texture2D CaptchaToTexture2D(int width, int height, int depth, bool linear = False, bool mipmap = False, UnityEngine.TextureFormat format = 5)
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  width, height:  height, depth:  depth);
        bool val_2 = val_1.Create();
        this.cam.targetTexture = val_1;
        this.cam.Render();
        UnityEngine.Texture2D val_5 = new UnityEngine.Texture2D(width:  -1104780944, height:  -1104780944, textureFormat:  format, mipChain:  mipmap, linear:  linear);
        UnityEngine.RenderTexture.active = val_1;
        val_5.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0, recalculateMipMaps:  mipmap);
        val_5.Apply();
        this.cam.targetTexture = 0;
        UnityEngine.RenderTexture.active = 0;
        return val_5;
    }
    public CaptchaRenderTexture()
    {
    
    }

}
