using UnityEngine;

namespace Light2D
{
    public class Light2DAngle
    {
        // Fields
        private float m_Angle;
        private float m_Rotate;
        
        // Properties
        public float angle { get; set; }
        public float halfAngle { get; }
        public bool isFullAngle { get; }
        public float rotate { get; }
        
        // Methods
        public float get_angle()
        {
            return (float)this.m_Angle;
        }
        public void set_angle(float value)
        {
            this.m_Angle = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  360f);
        }
        public float get_halfAngle()
        {
            float val_1 = this.m_Angle;
            val_1 = val_1 * 0.5f;
            return (float)val_1;
        }
        public bool get_isFullAngle()
        {
            return (bool)(this.m_Angle >= 360f) ? 1 : 0;
        }
        public float get_rotate()
        {
            return (float)this.m_Rotate;
        }
        public void Init(float angle, float rotate)
        {
            this.angle = angle;
            this.m_Rotate = rotate;
        }
        public bool IsOnAngle(float localAngle)
        {
            float val_6 = this.m_Angle;
            if(val_6 >= 360f)
            {
                    return true;
            }
            
            float val_5 = 180f;
            float val_4 = -0.5f;
            val_4 = val_6 * val_4;
            val_5 = val_4 + val_5;
            val_6 = val_6 + val_5;
            return (bool)((val_5 <= localAngle) ? 1 : 0) & ((val_6 >= localAngle) ? 1 : 0);
        }
        public float ToAngle(UnityEngine.Vector2 direction)
        {
            float val_1 = direction.y;
            val_1 = val_1 * 57.29578f;
            val_1 = val_1 - this.m_Rotate;
            val_1 = val_1 + 360f;
        }
        public static float Clamp360(float angle)
        {
            angle = angle + 360f;
        }
        public Light2DAngle()
        {
            this.m_Angle = 360f;
        }
    
    }

}
