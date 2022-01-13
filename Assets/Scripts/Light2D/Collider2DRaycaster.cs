using UnityEngine;

namespace Light2D
{
    public abstract class Collider2DRaycaster
    {
        // Fields
        protected Light2D.Light2DRaycast m_Raycaster;
        protected static readonly Light2D.ColliderPointsPool m_PointsPool;
        
        // Methods
        public Collider2DRaycaster(Light2D.Light2DRaycast raycaster)
        {
            this.m_Raycaster = raycaster;
        }
        public abstract void Raycast(UnityEngine.Transform lightTransform, Light2D.Light2DRadius lightRadius, UnityEngine.Collider2D collider); // 0
        protected void RaycastIntersectionPointsOfLine(UnityEngine.Transform lightTransform, float worldRadius, UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB)
        {
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            val_33 = pointB.y;
            val_34 = pointA.y;
            val_35 = worldRadius;
            UnityEngine.Vector3 val_1 = lightTransform.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_36 = val_2.y;
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = pointA.x, y = val_34})) <= val_35)
            {
                    if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_36}, b:  new UnityEngine.Vector2() {x = pointB.x, y = val_33})) <= val_35)
            {
                    return;
            }
            
            }
            
            val_37 = val_33;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = pointB.x, y = val_37}, b:  new UnityEngine.Vector2() {x = pointA.x, y = val_34});
            val_38 = val_5.x;
            val_5.x = val_38 * val_38;
            float val_7 = val_5.x + (val_5.y * val_5.y);
            val_38 = val_38;
            val_37 = val_5.y;
            if(System.Math.Abs(val_7) < 0)
            {
                    return;
            }
            
            float val_8 = val_2.x * val_2.x;
            float val_10 = pointA.x * pointA.x;
            val_8 = val_8 + (val_36 * val_36);
            val_10 = val_10 + (val_34 * val_34);
            val_8 = val_10 + val_8;
            float val_21 = ((pointA.x - val_2.x) * val_38) + ((val_34 - val_36) * val_37);
            val_8 = val_8 - (((pointA.x * val_2.x) + (val_34 * val_36)) + ((pointA.x * val_2.x) + (val_34 * val_36)));
            val_36 = val_21 + val_21;
            val_8 = val_8 - (val_35 * val_35);
            float val_23 = val_36 * val_36;
            val_8 = val_8 * (val_7 * (-4f));
            val_35 = val_23 + val_8;
            if(val_35 < 0)
            {
                    return;
            }
            
            if(val_35 != 0f)
            {
                goto label_12;
            }
            
            val_33 = val_37;
            val_39 = val_38;
            val_40 = val_33;
            if(val_8 >= _TYPE_MAX_)
            {
                    val_41 = val_35;
                val_33 = val_40;
                val_39 = val_39;
                val_40 = val_33;
            }
            
            val_41 = val_41 - val_36;
            float val_24 = val_7 + val_7;
            val_41 = val_41 / val_24;
            val_21 = val_39 * val_41;
            val_24 = val_40 * val_41;
            val_41 = pointA.x + val_21;
            val_40 = val_34 + val_24;
            UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  val_41, y:  val_40);
            val_34 = val_25.x;
            if(this.m_Raycaster != null)
            {
                goto label_32;
            }
            
            label_33:
            label_32:
            this.m_Raycaster.WorldRaycast(lightTransform:  lightTransform, worldPosition:  new UnityEngine.Vector2() {x = val_34, y = val_25.y});
            return;
            label_12:
            val_42 = val_37;
            val_43 = val_38;
            if(val_8 >= _TYPE_MAX_)
            {
                    val_44 = val_35;
                val_42 = val_37;
                val_43 = val_43;
            }
            
            val_44 = val_44 - val_36;
            val_45 = val_7 + val_7;
            val_44 = val_44 / val_45;
            val_21 = val_43 * val_44;
            val_23 = val_42 * val_44;
            val_44 = pointA.x + val_21;
            val_42 = val_34 + val_23;
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_44, y:  val_42);
            float val_33 = val_26.x;
            float val_34 = val_26.y;
            val_46 = pointA.x - pointB.x;
            float val_27 = val_34 - val_33;
            val_33 = val_33 - pointB.x;
            val_34 = val_34 - val_33;
            val_33 = val_33 / val_46;
            val_34 = val_34 / val_27;
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_33, y:  val_34);
            if(val_28.x >= 0f)
            {
                    if(val_28.x <= 1f)
            {
                goto label_21;
            }
            
            }
            
            if((val_28.y >= 0f) && (val_28.y <= 1f))
            {
                    label_21:
                this.m_Raycaster.WorldRaycast(lightTransform:  lightTransform, worldPosition:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
                val_46 = val_46;
                val_45 = val_45;
            }
            
            val_48 = val_43;
            val_47 = val_37;
            val_48 = val_43;
            val_47 = val_37;
            if(val_26.x >= _TYPE_MAX_)
            {
                    val_49 = val_35;
                val_48 = val_43;
                val_47 = val_37;
            }
            
            val_49 = (-val_36) - val_49;
            val_49 = val_49 / val_45;
            val_48 = val_48 * val_49;
            val_47 = val_47 * val_49;
            val_49 = pointA.x + val_48;
            UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  val_49, y:  val_34 + val_47);
            float val_35 = val_30.x;
            float val_36 = val_30.y;
            val_35 = val_35 - pointB.x;
            val_36 = val_36 - val_33;
            val_35 = val_35 / val_46;
            val_36 = val_36 / val_27;
            UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  val_35, y:  val_36);
            if(val_31.x >= 0f)
            {
                    if(val_31.x <= 1f)
            {
                goto label_29;
            }
            
            }
            
            if(val_31.y < 0f)
            {
                    return;
            }
            
            if(val_31.y > 1f)
            {
                    return;
            }
            
            label_29:
            if(this.m_Raycaster != null)
            {
                goto label_32;
            }
            
            goto label_33;
        }
        protected void RaycastPoints(UnityEngine.Transform lightTransform, UnityEngine.Collider2D collider, Light2D.Light2DRadius lightRadius, UnityEngine.Vector2[] points, bool isClosedPolygon)
        {
            float val_19;
            int val_20;
            var val_21;
            float val_22;
            UnityEngine.Vector3 val_1 = lightTransform.position;
            val_19 = val_1.z;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_19});
            val_20 = points.Length;
            bool val_3 = isClosedPolygon;
            if((val_20 + val_3) < 1)
            {
                    return;
            }
            
            val_3 = val_3 + val_20;
            val_21 = 0;
            goto label_6;
            label_20:
            val_20 = points.Length;
            val_21 = W28;
            label_6:
            int val_6 = val_21 / val_20;
            val_6 = val_21 - (val_6 * val_20);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = points[(long)val_6], y = points[(long)val_6]});
            UnityEngine.Vector3 val_9 = collider.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            var val_11 = val_21 + 1;
            val_19 = val_10.x;
            int val_12 = val_11 / points.Length;
            val_12 = val_11 - (val_12 * points.Length);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = points[(long)val_12], y = points[(long)val_12]});
            UnityEngine.Vector3 val_15 = collider.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            float val_17 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_19, y = val_10.y});
            val_22 = lightRadius.m_WorldRadius;
            if(val_17 <= val_22)
            {
                    this.m_Raycaster.RaycastColliderSurfacePoint(worldPosition:  new UnityEngine.Vector2() {x = val_19, y = val_10.y});
                val_22 = lightRadius.m_WorldRadius;
            }
            
            if(val_17 <= val_22)
            {
                    if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y})) <= val_22)
            {
                goto label_19;
            }
            
            }
            
            this.RaycastIntersectionPointsOfLine(lightTransform:  lightTransform, worldRadius:  val_22, pointA:  new UnityEngine.Vector2() {x = val_19, y = val_10.y}, pointB:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            label_19:
            if((val_3 - 1) != val_21)
            {
                goto label_20;
            }
        
        }
        private static Collider2DRaycaster()
        {
            Light2D.Collider2DRaycaster.m_PointsPool = new Light2D.ColliderPointsPool();
        }
    
    }

}
