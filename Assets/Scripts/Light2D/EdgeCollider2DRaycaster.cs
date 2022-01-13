using UnityEngine;

namespace Light2D
{
    public class EdgeCollider2DRaycaster : Collider2DRaycaster
    {
        // Methods
        public EdgeCollider2DRaycaster(Light2D.Light2DRaycast raycaster)
        {
            this = new System.Object();
            mem[1152921512181918448] = raycaster;
        }
        public override void Raycast(UnityEngine.Transform lightTransform, Light2D.Light2DRadius lightRadius, UnityEngine.Collider2D collider)
        {
            UnityEngine.Object val_4;
            var val_5;
            if(collider != null)
            {
                    var val_1 = (null == null) ? collider : 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            this.RaycastPoints(lightTransform:  lightTransform, collider:  collider, lightRadius:  lightRadius, points:  Light2D.Collider2DRaycaster.m_PointsPool.Get(collider:  val_4), isClosedPolygon:  false);
        }
    
    }

}
