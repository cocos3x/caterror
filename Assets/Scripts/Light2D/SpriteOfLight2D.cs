using UnityEngine;

namespace Light2D
{
    public class SpriteOfLight2D : MonoBehaviour
    {
        // Fields
        public Light2D.Light2DBase source;
        private UnityEngine.SpriteRenderer m_SpriteRenderer;
        
        // Properties
        public UnityEngine.SpriteRenderer spriteRenderer { get; }
        
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
        private void LateUpdate()
        {
            if(this.source == 0)
            {
                    return;
            }
            
            this.source.UpdateGeometry();
            if(this.spriteRenderer.sprite == this.source)
            {
                    return;
            }
            
            this.spriteRenderer.sprite = this.source;
        }
        public SpriteOfLight2D()
        {
        
        }
    
    }

}
