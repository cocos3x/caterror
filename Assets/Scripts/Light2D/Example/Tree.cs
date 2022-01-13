using UnityEngine;

namespace Light2D.Example
{
    public class Tree : MonoBehaviour
    {
        // Fields
        private UnityEngine.Sprite[] m_SpriteSequence;
        private bool m_IsInLight;
        private float m_ExposedTime;
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
        private void Update()
        {
            float val_5 = this.m_ExposedTime;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = (this.m_IsInLight == true) ? (val_1) : (-val_1);
            val_5 = val_5 + (val_1 * 5f);
            this.m_ExposedTime = val_5;
            int val_6 = this.m_SpriteSequence.Length;
            val_6 = val_6 - 1;
            float val_3 = UnityEngine.Mathf.Clamp(value:  val_5, min:  0f, max:  (float)val_6);
            this.m_ExposedTime = val_3;
            this.spriteRenderer.sprite = this.m_SpriteSequence[(long)(int)val_3];
        }
        private void OnEnterLight2D(Light2D.Light2DBase light)
        {
            this.m_IsInLight = true;
            this.m_ExposedTime = 0f;
        }
        private void OnExitLight2D(Light2D.Light2DBase light)
        {
            this.m_IsInLight = false;
        }
        public Tree()
        {
        
        }
    
    }

}
