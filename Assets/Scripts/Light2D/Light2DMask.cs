using UnityEngine;

namespace Light2D
{
    public class Light2DMask : Light2DBase
    {
        // Fields
        private UnityEngine.SpriteMask m_SpriteMask;
        
        // Properties
        public UnityEngine.SpriteMask spriteMask { get; }
        
        // Methods
        public UnityEngine.SpriteMask get_spriteMask()
        {
            UnityEngine.SpriteMask val_3;
            if(this.m_SpriteMask == 0)
            {
                    this.m_SpriteMask = this.GetComponent<UnityEngine.SpriteMask>();
                return val_3;
            }
            
            val_3 = this.m_SpriteMask;
            return val_3;
        }
        public override UnityEngine.Sprite GetRendererSprite()
        {
            UnityEngine.SpriteMask val_1 = this.spriteMask;
            if(val_1 != null)
            {
                    return val_1.sprite;
            }
            
            return val_1.sprite;
        }
        public override void SetRendererSprite(UnityEngine.Sprite sprite)
        {
            this.spriteMask.sprite = sprite;
        }
        public Light2DMask()
        {
        
        }
    
    }

}
