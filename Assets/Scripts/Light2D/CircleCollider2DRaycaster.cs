using UnityEngine;

namespace Light2D
{
    public class CircleCollider2DRaycaster : Collider2DRaycaster
    {
        // Methods
        public CircleCollider2DRaycaster(Light2D.Light2DRaycast raycaster)
        {
            this = new System.Object();
            mem[1152921512181025392] = raycaster;
        }
        public override void Raycast(UnityEngine.Transform lightTransform, Light2D.Light2DRadius lightRadius, UnityEngine.Collider2D collider)
        {
            float val_7;
            float val_11;
            var val_26;
            var val_27;
            val_26 = collider;
            val_27 = this;
            if(val_26 != null)
            {
                    UnityEngine.Object val_1 = (null == null) ? (val_26) : 0;
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = lightTransform.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Bounds val_5 = val_1.bounds;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_4.y, z = val_3.z});
            UnityEngine.Bounds val_9 = val_1.bounds;
            float val_12 = val_11 * 0.5f;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            float val_25 = val_8.x;
            float val_14 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_25, y = val_8.y});
            val_14 = val_12 / val_14;
            float val_26 = val_14;
            float val_15 = val_13.y - val_26;
            val_25 = val_12 * val_15;
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_25, y:  -(val_12 * val_15));
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            val_26 = val_26 + val_13.y;
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  -(val_12 * val_26), y:  val_12 * val_26);
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y})) >= 0)
            {
                    return;
            }
            
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y})) >= 0)
            {
                    return;
            }
            
            lightRadius.RaycastColliderSurfacePoint(worldPosition:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            this.RaycastColliderSurfacePoint(worldPosition:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        }
    
    }

}
