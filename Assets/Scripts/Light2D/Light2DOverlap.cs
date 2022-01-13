using UnityEngine;

namespace Light2D
{
    public class Light2DOverlap
    {
        // Fields
        private Light2D.ScalableArray<UnityEngine.Collider2D> m_Results;
        
        // Properties
        public Light2D.ScalableArray<UnityEngine.Collider2D> results { get; }
        
        // Methods
        public Light2D.ScalableArray<UnityEngine.Collider2D> get_results()
        {
            return (Light2D.ScalableArray<UnityEngine.Collider2D>)this.m_Results;
        }
        public Light2DOverlap(int capacity)
        {
            this.m_Results = new Light2D.ScalableArray<UnityEngine.Collider2D>(defaultCapacity:  capacity);
        }
        public void CircleOverlap(UnityEngine.Transform lightTransform, float radius, int layerMask)
        {
            var val_9;
            UnityEngine.Vector3 val_1 = lightTransform.position;
            goto label_2;
            label_11:
            if(lightTransform != null)
            {
                    val_9 = lightTransform.capacity;
            }
            else
            {
                    val_9 = 0.capacity;
            }
            
            lightTransform.Rescale(capacity:  val_9 << 1, copyOriginals:  false);
            label_2:
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            int val_7 = UnityEngine.Physics2D.OverlapCircleNonAlloc(point:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, radius:  radius, results:  this.m_Results.array, layerMask:  layerMask);
            if(val_7 >= this.m_Results.capacity)
            {
                goto label_11;
            }
            
            this.m_Results.SetLength(length:  val_7);
        }
    
    }

}
