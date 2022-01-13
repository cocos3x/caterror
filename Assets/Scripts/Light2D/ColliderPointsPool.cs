using UnityEngine;

namespace Light2D
{
    public class ColliderPointsPool
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<int, UnityEngine.Vector2[]> m_Pool;
        
        // Methods
        public ColliderPointsPool()
        {
            this.m_Pool = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Vector2[]>();
        }
        public UnityEngine.Vector2[] Get(UnityEngine.EdgeCollider2D collider)
        {
            UnityEngine.EdgeCollider2D val_4 = collider;
            int val_1 = val_4.GetInstanceID();
            if((this.m_Pool.ContainsKey(key:  val_1)) != true)
            {
                    val_4 = val_4.points;
                this.m_Pool.set_Item(key:  val_1, value:  val_4);
            }
            
            if(this.m_Pool != null)
            {
                    return this.m_Pool.Item[val_1];
            }
            
            return this.m_Pool.Item[val_1];
        }
        public UnityEngine.Vector2[] Get(UnityEngine.PolygonCollider2D collider)
        {
            UnityEngine.PolygonCollider2D val_4 = collider;
            int val_1 = val_4.GetInstanceID();
            if((this.m_Pool.ContainsKey(key:  val_1)) != true)
            {
                    val_4 = val_4.points;
                this.m_Pool.set_Item(key:  val_1, value:  val_4);
            }
            
            if(this.m_Pool != null)
            {
                    return this.m_Pool.Item[val_1];
            }
            
            return this.m_Pool.Item[val_1];
        }
    
    }

}
