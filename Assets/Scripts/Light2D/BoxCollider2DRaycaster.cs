using UnityEngine;

namespace Light2D
{
    public class BoxCollider2DRaycaster : Collider2DRaycaster
    {
        // Methods
        public BoxCollider2DRaycaster(Light2D.Light2DRaycast raycaster)
        {
            this = new System.Object();
            mem[1152921512180735856] = raycaster;
        }
        public override void Raycast(UnityEngine.Transform lightTransform, Light2D.Light2DRadius lightRadius, UnityEngine.Collider2D collider)
        {
            var val_37;
            UnityEngine.Object val_38;
            float val_39;
            float val_40;
            val_37 = lightRadius;
            if(collider != null)
            {
                    var val_1 = (null == null) ? collider : 0;
            }
            else
            {
                    val_38 = 0;
            }
            
            if(val_38 == 0)
            {
                    return;
            }
            
            if(val_38 != 0)
            {
                    UnityEngine.Vector2 val_3 = val_38.offset;
                val_39 = val_3.x;
                val_40 = val_3.y;
            }
            else
            {
                    UnityEngine.Vector2 val_4 = 0.offset;
                val_39 = val_4.x;
                val_40 = val_4.y;
            }
            
            UnityEngine.Vector2 val_5 = val_38.size;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, d:  2f);
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  -val_6.x, y:  val_6.y);
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_39, y = val_40});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            UnityEngine.Vector3 val_11 = collider.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_6.x, y:  val_6.y);
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_39, y = val_40});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            UnityEngine.Vector3 val_17 = collider.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_38 = collider.transform;
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_6.x, y:  -val_6.y);
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y}, b:  new UnityEngine.Vector2() {x = val_39, y = val_40});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            UnityEngine.Vector3 val_23 = val_38.TransformPoint(position:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  -val_6.x, y:  -val_6.y);
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_39, y = val_40});
            UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            UnityEngine.Vector3 val_29 = collider.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            UnityEngine.Vector3 val_31 = lightTransform.position;
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y})) <= lightRadius.m_WorldRadius)
            {
                    val_37.RaycastColliderSurfacePoint(worldPosition:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            }
            
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y})) <= lightRadius.m_WorldRadius)
            {
                    val_37.RaycastColliderSurfacePoint(worldPosition:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            }
            
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, b:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y})) <= lightRadius.m_WorldRadius)
            {
                    val_37.RaycastColliderSurfacePoint(worldPosition:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            }
            
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, b:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y})) <= lightRadius.m_WorldRadius)
            {
                    val_37.RaycastColliderSurfacePoint(worldPosition:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y});
            }
            
            this.RaycastIntersectionPointsOfLine(lightTransform:  lightTransform, worldRadius:  lightRadius.m_WorldRadius, pointA:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, pointB:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            this.RaycastIntersectionPointsOfLine(lightTransform:  lightTransform, worldRadius:  lightRadius.m_WorldRadius, pointA:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, pointB:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            this.RaycastIntersectionPointsOfLine(lightTransform:  lightTransform, worldRadius:  lightRadius.m_WorldRadius, pointA:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y}, pointB:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y});
            this.RaycastIntersectionPointsOfLine(lightTransform:  lightTransform, worldRadius:  lightRadius.m_WorldRadius, pointA:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y}, pointB:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        }
    
    }

}
