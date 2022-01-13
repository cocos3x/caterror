using UnityEngine;
public class RaycastMask : MonoBehaviour, ICanvasRaycastFilter
{
    // Fields
    private UnityEngine.UI.Image _image;
    private UnityEngine.Sprite _sprite;
    
    // Methods
    private void Start()
    {
        this._image = this.GetComponent<UnityEngine.UI.Image>();
    }
    public bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
    {
        UnityEngine.RectTransform val_38;
        float val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_44;
        int val_45;
        float val_46;
        float val_47;
        this._sprite = this._image.sprite;
        val_38 = this.transform;
        if((val_38 != null) && (null != null))
        {
                val_38 = 0;
        }
        
        bool val_4 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  val_38, screenPoint:  new UnityEngine.Vector2() {x = sp.x, y = sp.y}, cam:  eventCamera, localPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
        if(val_38 != 0)
        {
                UnityEngine.Vector2 val_5 = val_38.pivot;
            val_39 = val_5.x;
        }
        else
        {
                UnityEngine.Vector2 val_6 = val_38.pivot;
            val_39 = val_6.x;
        }
        
        UnityEngine.Rect val_7 = val_38.rect;
        val_40 = 0f;
        if(val_38 != 0)
        {
                UnityEngine.Vector2 val_8 = val_38.pivot;
            val_41 = val_8.y;
        }
        else
        {
                UnityEngine.Vector2 val_9 = val_38.pivot;
            val_41 = val_9.y;
        }
        
        UnityEngine.Rect val_10 = val_38.rect;
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  0f + (val_39 * val_7.m_XMin), y:  val_40 + (val_41 * val_10.m_XMin));
        UnityEngine.Rect val_16 = this._sprite.textureRect;
        UnityEngine.Rect val_17 = val_38.rect;
        if(this._image.type != 1)
        {
            goto label_13;
        }
        
        UnityEngine.Vector4 val_19 = this._sprite.border;
        float val_37 = val_19.x;
        val_42 = val_19.y;
        val_40 = val_19.z;
        if(val_15.x >= 0)
        {
            goto label_15;
        }
        
        val_44 = (val_16.m_XMin.System.IConvertible.ToSingle(provider:  0)) + val_15.x;
        goto label_25;
        label_13:
        float val_21 = val_16.m_XMin.System.IConvertible.ToSingle(provider:  0);
        val_21 = val_21 * val_15.x;
        val_21 = val_21 / val_21;
        val_21 = val_21 + val_21;
        val_45 = UnityEngine.Mathf.FloorToInt(f:  val_21);
        val_42 = val_21;
        val_46 = val_15.y;
        val_21 = (val_21 * val_46) / val_21;
        val_21 = val_42 + val_21;
        goto label_35;
        label_15:
        float val_25 = val_16.m_XMin.System.IConvertible.ToSingle(provider:  0);
        if(val_15.x > (val_19.x - val_40))
        {
                val_40 = val_25;
            val_25 = val_25 + val_25;
            val_44 = val_25 - (val_40 - val_15.x);
        }
        else
        {
                float val_27 = val_25 - val_37;
            float val_28 = val_15.x - val_37;
            val_47 = val_25 - val_37;
            val_27 = val_27 - val_40;
            val_28 = val_28 / val_27;
            float val_29 = val_47 - val_40;
            val_25 = val_37 + val_25;
            val_28 = val_28 * val_29;
            val_44 = val_25 + val_28;
        }
        
        label_25:
        val_46 = val_15.y;
        val_45 = UnityEngine.Mathf.FloorToInt(f:  val_44);
        if(val_46 < 0)
        {
                val_42 = val_44;
            val_44 = val_42 + val_15.y;
        }
        else
        {
                val_37 = val_44 - val_19.w;
            val_46 = val_44;
            if(val_46 > val_37)
        {
                val_42 = val_44;
            val_44 = val_46 + val_42;
            val_28 = val_44 - val_15.y;
            val_44 = val_44 - val_28;
        }
        else
        {
                val_40 = val_44;
            val_29 = val_44 - val_42;
            float val_31 = val_15.y - val_42;
            val_47 = val_40 - val_42;
            val_29 = val_29 - val_19.w;
            val_31 = val_31 / val_29;
            val_44 = val_42 + val_46;
            val_31 = val_31 * (val_47 - val_19.w);
            val_44 = val_44 + val_31;
        }
        
        }
        
        label_35:
        UnityEngine.Color val_35 = this._sprite.texture.GetPixel(x:  val_45, y:  UnityEngine.Mathf.FloorToInt(f:  val_44));
        return (bool)(val_35.a > 0f) ? 1 : 0;
    }
    public RaycastMask()
    {
    
    }

}
