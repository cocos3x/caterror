using UnityEngine;
public class ImageScroller : MonoBehaviour
{
    // Fields
    private float speedX;
    private float speedY;
    private bool isStretchWidth;
    private UnityEngine.UI.RawImage rawImage;
    private UnityEngine.Rect rect;
    
    // Methods
    private void Awake()
    {
        UnityEngine.UI.RawImage val_1 = this.GetComponent<UnityEngine.UI.RawImage>();
        this.rawImage = val_1;
        UnityEngine.Rect val_2 = val_1.uvRect;
        this.rect = val_2;
        mem[1152921512067948628] = val_2.m_YMin;
        mem[1152921512067948632] = val_2.m_Width;
        mem[1152921512067948636] = val_2.m_Height;
        if(this.isStretchWidth == false)
        {
                return;
        }
        
        float val_10 = (float)UnityEngine.Screen.width;
        this = ???;
        val_10 = val_10 / (float)UnityEngine.Screen.height;
        val_10 = val_2.m_XMin * val_10;
        val_10 = val_10 / 0.5625f;
    }
    private void LateUpdate()
    {
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.speedX * val_2;
        val_2 = this.rect.x + val_2;
        this.rect.x = val_2;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.speedY * val_3;
        val_3 = val_2 + val_3;
        this.rawImage.uvRect = new UnityEngine.Rect() {m_XMin = this.rect, m_YMin = this.speedY, m_Width = V10.16B, m_Height = V11.16B};
    }
    public ImageScroller()
    {
    
    }

}
