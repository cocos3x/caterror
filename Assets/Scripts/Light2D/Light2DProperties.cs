using UnityEngine;

namespace Light2D
{
    [Serializable]
    public class Light2DProperties
    {
        // Fields
        private float m_Radius;
        private float m_Angle;
        private float m_Rotation;
        private int m_Resolution;
        private int m_LayerMask;
        
        // Properties
        public float radius { get; set; }
        public float angle { get; set; }
        public float rotation { get; set; }
        public int resolution { get; set; }
        public int layerMask { get; set; }
        
        // Methods
        public float get_radius()
        {
            return (float)this.m_Radius;
        }
        public void set_radius(float value)
        {
            value = value + 360f;
            this.m_Radius = value;
        }
        public float get_angle()
        {
            return (float)this.m_Angle;
        }
        public void set_angle(float value)
        {
            value = value + 360f;
            this.m_Angle = value;
        }
        public float get_rotation()
        {
            return (float)this.m_Rotation;
        }
        public void set_rotation(float value)
        {
            value = value + 360f;
            this.m_Rotation = value;
        }
        public int get_resolution()
        {
            return (int)this.m_Resolution;
        }
        public void set_resolution(int value)
        {
            this.m_Resolution = UnityEngine.Mathf.Max(a:  value, b:  3);
        }
        public int get_layerMask()
        {
            return (int)this.m_LayerMask;
        }
        public void set_layerMask(int value)
        {
            this.m_LayerMask = value;
        }
        public Light2DProperties()
        {
            this.m_Radius = 10f;
            this.m_Angle = 360f;
            this.m_Resolution = 65525;
            this.m_LayerMask = 0;
        }
    
    }

}
