using UnityEngine;

namespace Light2D
{
    public class Light2DRadius
    {
        // Fields
        private float m_LocalRadius;
        private float m_WorldRadius;
        private float m_SpriteRadius;
        
        // Properties
        public float localRadius { get; }
        public float worldRadius { get; }
        public float spriteRadius { get; }
        
        // Methods
        public float get_localRadius()
        {
            return (float)this.m_LocalRadius;
        }
        public float get_worldRadius()
        {
            return (float)this.m_WorldRadius;
        }
        public float get_spriteRadius()
        {
            return (float)this.m_SpriteRadius;
        }
        public void Init(UnityEngine.Transform transform, UnityEngine.Sprite sprite, float radius)
        {
            float val_3;
            UnityEngine.Bounds val_1 = sprite.bounds;
            UnityEngine.Bounds val_4 = sprite.bounds;
            float val_7 = UnityEngine.Mathf.Min(a:  val_3, b:  V1.16B);
            val_7 = val_7 * 0.5f;
            this.m_SpriteRadius = val_7;
            UnityEngine.Rect val_8 = sprite.rect;
            UnityEngine.Rect val_9 = sprite.rect;
            this.m_LocalRadius = UnityEngine.Mathf.Min(a:  val_8.m_XMin, b:  val_9.m_YMin);
            this.m_WorldRadius = Light2D.Light2DRadius.GetWorldRadius(transform:  transform, radius:  radius);
        }
        public static float GetWorldRadius(UnityEngine.Transform transform, float radius)
        {
            float val_6;
            var val_7;
            val_6 = radius;
            val_7 = transform;
            if(val_7.parent == 0)
            {
                    return (float)System.Math.Abs(val_6 = (Light2D.Tools.GetScaleBase(lossyScale:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) * val_6);
            }
            
            val_7 = val_7.parent;
            UnityEngine.Vector3 val_4 = val_7.lossyScale;
            return (float)System.Math.Abs(val_6);
        }
        public Light2DRadius()
        {
        
        }
    
    }

}
