using UnityEngine;

namespace Light2D
{
    public class Light2DSource : Light2DBase
    {
        // Fields
        private UnityEngine.SpriteRenderer m_SpriteRenderer;
        
        // Properties
        public UnityEngine.SpriteRenderer spriteRenderer { get; }
        public UnityEngine.Sprite sprite { get; set; }
        public UnityEngine.Color color { get; set; }
        
        // Methods
        public UnityEngine.SpriteRenderer get_spriteRenderer()
        {
            UnityEngine.SpriteRenderer val_3;
            if(this.m_SpriteRenderer == 0)
            {
                    this.m_SpriteRenderer = this.GetComponent<UnityEngine.SpriteRenderer>();
                return val_3;
            }
            
            val_3 = this.m_SpriteRenderer;
            return val_3;
        }
        public UnityEngine.Sprite get_sprite()
        {
            UnityEngine.SpriteRenderer val_1 = this.spriteRenderer;
            if(val_1 != null)
            {
                    return val_1.sprite;
            }
            
            return val_1.sprite;
        }
        public void set_sprite(UnityEngine.Sprite value)
        {
            this.spriteRenderer.sprite = value;
        }
        public UnityEngine.Color get_color()
        {
            UnityEngine.SpriteRenderer val_1 = this.spriteRenderer;
            if(val_1 != null)
            {
                    return val_1.color;
            }
            
            return val_1.color;
        }
        public void set_color(UnityEngine.Color value)
        {
            this.spriteRenderer.color = new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a};
        }
        public override UnityEngine.Sprite GetRendererSprite()
        {
            UnityEngine.SpriteRenderer val_1 = this.spriteRenderer;
            if(val_1 != null)
            {
                    return val_1.sprite;
            }
            
            return val_1.sprite;
        }
        public override void SetRendererSprite(UnityEngine.Sprite sprite)
        {
            this.spriteRenderer.sprite = sprite;
        }
        public Light2DSource()
        {
        
        }
    
    }

}
