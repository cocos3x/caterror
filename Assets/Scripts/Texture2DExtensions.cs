using UnityEngine;
public static class Texture2DExtensions
{
    // Methods
    public static UnityEngine.Sprite ToSprite(UnityEngine.Texture2D tex)
    {
        int val_1 = tex.width;
        int val_2 = tex.height;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        return (UnityEngine.Sprite)UnityEngine.Sprite.Create(texture:  tex, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
    }

}
