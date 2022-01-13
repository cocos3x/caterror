using UnityEngine;

namespace Light2D.Example
{
    public class LightRotation : MonoBehaviour
    {
        // Fields
        private Light2D.Light2DBase m_Light;
        
        // Properties
        public Light2D.Light2DBase light2d { get; }
        
        // Methods
        public Light2D.Light2DBase get_light2d()
        {
            Light2D.Light2DBase val_3;
            if(this.m_Light == 0)
            {
                    this.m_Light = this.GetComponent<Light2D.Light2DBase>();
                return val_3;
            }
            
            val_3 = this.m_Light;
            return val_3;
        }
        public void OnChangeRotation(float rotation)
        {
            this.light2d.rotation = rotation;
        }
        public LightRotation()
        {
        
        }
    
    }

}
