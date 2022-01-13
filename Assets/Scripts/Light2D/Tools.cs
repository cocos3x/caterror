using UnityEngine;

namespace Light2D
{
    public class Tools
    {
        // Methods
        public static float GetScaleBase(UnityEngine.Vector3 lossyScale)
        {
            if((lossyScale.x < 0) || (lossyScale.y < 0))
            {
                    return UnityEngine.Mathf.Min(a:  lossyScale.x, b:  lossyScale.y);
            }
            
            return UnityEngine.Mathf.Max(a:  lossyScale.x, b:  lossyScale.y);
        }
        public Tools()
        {
        
        }
    
    }

}
