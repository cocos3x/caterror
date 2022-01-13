using UnityEngine;

namespace Light2D
{
    public class PolygonCollider2DRaycaster : Collider2DRaycaster
    {
        // Methods
        public PolygonCollider2DRaycaster(Light2D.Light2DRaycast raycaster)
        {
            this = new System.Object();
            mem[1152921512184881040] = raycaster;
        }
        public override void Raycast(UnityEngine.Transform lightTransform, Light2D.Light2DRadius lightRadius, UnityEngine.Collider2D collider)
        {
            UnityEngine.Object val_6;
            var val_7;
            if(collider != null)
            {
                    var val_1 = (null == null) ? collider : 0;
            }
            else
            {
                    val_6 = 0;
            }
            
            if(val_6 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = lightTransform.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_7 = null;
            val_7 = null;
            this.RaycastPoints(lightTransform:  lightTransform, collider:  collider, lightRadius:  lightRadius, points:  Light2D.Collider2DRaycaster.m_PointsPool.Get(collider:  val_6), isClosedPolygon:  true);
        }
    
    }

}
