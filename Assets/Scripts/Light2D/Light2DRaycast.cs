using UnityEngine;

namespace Light2D
{
    public class Light2DRaycast
    {
        // Fields
        private const float kAngleDelta = 0.01;
        private static readonly UnityEngine.Quaternion kLeftRotation;
        private static readonly UnityEngine.Quaternion kRightRotation;
        private readonly Light2D.RaycastInfoComparer m_RaycastSortComparer;
        private Light2D.ScalableArray<Light2D.RaycastInfo> m_Results;
        private UnityEngine.Transform m_LightTransform;
        private UnityEngine.Vector2 m_LightPosition;
        private Light2D.Light2DAngle m_LightAngle;
        private Light2D.Light2DRadius m_LightRadius;
        private int m_LayerMask;
        private Light2D.Collider2DRaycaster boxColliderRaycaster;
        private Light2D.Collider2DRaycaster circleColliderRaycaster;
        private Light2D.Collider2DRaycaster polygonColliderRaycaster;
        private Light2D.Collider2DRaycaster edgeColliderRaycaster;
        
        // Properties
        public Light2D.ScalableArray<Light2D.RaycastInfo> results { get; }
        
        // Methods
        public Light2D.ScalableArray<Light2D.RaycastInfo> get_results()
        {
            return (Light2D.ScalableArray<Light2D.RaycastInfo>)this.m_Results;
        }
        public Light2DRaycast(int capacity)
        {
            this.m_RaycastSortComparer = new Light2D.RaycastInfoComparer();
            this.m_Results = new Light2D.ScalableArray<Light2D.RaycastInfo>(defaultCapacity:  capacity);
            this.boxColliderRaycaster = new Light2D.BoxCollider2DRaycaster(raycaster:  this);
            this.circleColliderRaycaster = new Light2D.CircleCollider2DRaycaster(raycaster:  this);
            this.polygonColliderRaycaster = new Light2D.PolygonCollider2DRaycaster(raycaster:  this);
            this.edgeColliderRaycaster = new Light2D.EdgeCollider2DRaycaster(raycaster:  this);
        }
        public void Init(UnityEngine.Transform lightTransform, Light2D.Light2DRadius lightRadius, Light2D.Light2DAngle lightAngle, int layerMask)
        {
            this.m_LightTransform = lightTransform;
            UnityEngine.Vector3 val_1 = lightTransform.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.m_LightPosition = val_2;
            mem[1152921512183008652] = val_2.y;
            this.m_LightAngle = lightAngle;
            this.m_LightRadius = lightRadius;
            this.m_LayerMask = layerMask;
            this.m_Results.Clear();
        }
        public void RaycastByResolution(int resolution)
        {
            Light2D.Light2DAngle val_4;
            float val_5;
            float val_6;
            val_4 = this.m_LightAngle;
            if(val_4 == null)
            {
                goto label_0;
            }
            
            val_5 = this.m_LightAngle.m_Angle;
            val_6 = (float)resolution;
            goto label_1;
            label_0:
            if(this.m_LightAngle == null)
            {
                goto label_2;
            }
            
            val_5 = this.m_LightAngle.m_Angle;
            val_6 = (float)resolution;
            val_4 = this.m_LightAngle;
            label_1:
            var val_2 = (this.m_LightAngle.m_Angle < 360f) ? 1 : 0;
            val_2 = val_2 + resolution;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_5 = 1;
            do
            {
                float val_4 = this.m_LightAngle.m_Angle;
                float val_3 = (val_5 / val_6) * 0f;
                val_3 = val_3 + 180f;
                val_4 = val_4 * (-0.5f);
                val_4 = val_3 + val_4;
                this.RaycastAngle(localAngle:  val_4);
                val_5 = val_5 + 1;
            }
            while(1f < 0);
            
            return;
            label_2:
        }
        public void RaycastCollider(UnityEngine.Collider2D collider)
        {
            Light2D.Collider2DRaycaster val_1;
            if(collider == null)
            {
                    return;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                    return;
            }
            
            if(null == null)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                goto label_6;
            }
            
            return;
            label_2:
            val_1 = this.boxColliderRaycaster;
            goto label_9;
            label_3:
            val_1 = this.circleColliderRaycaster;
            goto label_9;
            label_5:
            val_1 = this.edgeColliderRaycaster;
            goto label_9;
            label_6:
            val_1 = this.polygonColliderRaycaster;
            label_9:
            if(val_1 == null)
            {
                
            }
        
        }
        public void SortResults()
        {
            System.Array.Sort<Light2D.RaycastInfo>(array:  this.m_Results.array, index:  0, length:  this.m_Results.length, comparer:  this.m_RaycastSortComparer);
        }
        public void RaycastAngle(float localAngle)
        {
            UnityEngine.Object val_15;
            float val_23;
            float val_26;
            float val_27;
            float val_28;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  this.m_LightAngle.m_Rotate + localAngle);
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector3 val_8 = this.m_LightTransform.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_23 = val_9.x;
            UnityEngine.Vector3 val_10 = this.m_LightTransform.position;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_26 = val_11.x;
            val_27 = val_11.y;
            val_28 = val_23;
            UnityEngine.RaycastHit2D val_12 = this.Raycast(origin:  new UnityEngine.Vector2() {x = val_26, y = val_27}, direction:  new UnityEngine.Vector2() {x = val_28, y = val_9.y}, distance:  this.m_LightRadius.m_WorldRadius);
            if(val_15 != 0)
            {
                
            }
            else
            {
                    UnityEngine.Vector2 val_17 = val_23.normalized;
                val_23 = val_17.x;
                UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_23, y = val_17.y}, d:  this.m_LightRadius.m_WorldRadius);
                val_28 = val_18.x;
                val_26 = val_11.x;
                val_27 = val_11.y;
                UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_26, y = val_27}, b:  new UnityEngine.Vector2() {x = val_28, y = val_18.y});
            }
            
            UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            UnityEngine.Vector3 val_21 = this.m_LightTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            this.AddRaycastResult(collider:  val_15, localPosition:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, angle:  localAngle);
        }
        private UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance)
        {
            return UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = origin.x, y = origin.y}, direction:  new UnityEngine.Vector2() {x = direction.x, y = direction.y}, distance:  distance, layerMask:  this.m_LayerMask);
        }
        public void WorldRaycast(UnityEngine.Transform lightTransform, UnityEngine.Vector2 worldPosition)
        {
            float val_11;
            UnityEngine.Object val_12;
            float val_18;
            Light2D.Light2DAngle val_19;
            float val_20;
            float val_21;
            float val_22;
            UnityEngine.Vector3 val_1 = lightTransform.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_18 = worldPosition.x;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y}, b:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Vector3 val_5 = lightTransform.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            float val_7 = this.m_LightAngle.ToAngle(direction:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_19 = this.m_LightAngle;
            val_20 = worldPosition.y;
            float val_19 = this.m_LightAngle.m_Angle;
            if(val_19 < 360f)
            {
                    float val_18 = 180f;
                float val_17 = -0.5f;
                val_17 = val_19 * val_17;
                val_18 = val_17 + val_18;
                if(val_18 > val_7)
            {
                    return;
            }
            
                val_19 = val_19 + val_18;
                if(val_19 < val_7)
            {
                    return;
            }
            
            }
            
            UnityEngine.RaycastHit2D val_9 = this.Raycast(origin:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, direction:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, distance:  UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_18, y = val_20}));
            val_19;
            if(val_12 != 0)
            {
                    val_18 = val_11;
                val_21 = val_12;
            }
            
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18, y = val_21});
            UnityEngine.Vector3 val_15 = lightTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_22 = val_16.x;
            this.AddRaycastResult(collider:  val_12, localPosition:  new UnityEngine.Vector2() {x = val_22, y = val_16.y}, angle:  val_7);
        }
        public void WorldRaycast(UnityEngine.Transform lightTransform, UnityEngine.Vector2 worldDirection, float worldDistance)
        {
            UnityEngine.Object val_10;
            float val_19;
            float val_20;
            float val_21;
            Light2D.Light2DAngle val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_29;
            val_19 = worldDirection.y;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = worldDirection.x, y = val_19});
            val_20 = val_1.z;
            UnityEngine.Vector3 val_2 = lightTransform.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_20});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_21 = val_3.y;
            float val_4 = this.m_LightAngle.ToAngle(direction:  new UnityEngine.Vector2() {x = val_3.x, y = val_21});
            val_22 = this.m_LightAngle;
            val_23 = this.m_LightAngle.m_Angle;
            val_24 = 360f;
            if(val_23 < val_24)
            {
                    val_20 = val_23 * (-0.5f);
                val_24 = val_20 + 180f;
                if(val_24 > val_4)
            {
                    return;
            }
            
                val_23 = val_23 + val_24;
                if(val_23 < val_4)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_5 = lightTransform.position;
            val_25 = val_5.x;
            val_26 = val_5.y;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_25, y = val_26, z = val_5.z});
            val_29 = worldDirection.x;
            val_21 = val_6.x;
            UnityEngine.RaycastHit2D val_7 = this.Raycast(origin:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, direction:  new UnityEngine.Vector2() {x = val_29, y = val_19}, distance:  worldDistance);
            val_22;
            if(val_10 != 0)
            {
                
            }
            else
            {
                    UnityEngine.Vector2 val_12 = worldDirection.x.normalized;
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, d:  worldDistance);
                val_29 = val_13.x;
                val_25 = val_21;
                val_26 = val_6.y;
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_25, y = val_26}, b:  new UnityEngine.Vector2() {x = val_29, y = val_13.y});
            }
            
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            UnityEngine.Vector3 val_16 = lightTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_19 = val_17.y;
            this.AddRaycastResult(collider:  val_10, localPosition:  new UnityEngine.Vector2() {x = val_17.x, y = val_19}, angle:  val_4);
        }
        public void RaycastColliderSurfacePoint(UnityEngine.Vector2 worldPosition)
        {
            var val_8;
            this.WorldRaycast(lightTransform:  this.m_LightTransform, worldPosition:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y});
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y}, b:  new UnityEngine.Vector2() {x = this.m_LightPosition, y = V10.16B});
            val_8 = null;
            val_8 = null;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = Light2D.Light2DRaycast.kLeftRotation, y = Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_4, z = Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_8, w = Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_C}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.WorldRaycast(lightTransform:  this.m_LightTransform, worldDirection:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, worldDistance:  this.m_LightRadius.m_WorldRadius);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector3 val_6 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = Light2D.Light2DRaycast.kRightRotation, y = Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_14, z = Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_18, w = Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_1C}, point:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.WorldRaycast(lightTransform:  this.m_LightTransform, worldDirection:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, worldDistance:  this.m_LightRadius.m_WorldRadius);
        }
        public void AddRaycastResult(UnityEngine.Collider2D collider, UnityEngine.Vector2 localPosition, float angle)
        {
            this.m_Results.Add(item:  new Light2D.RaycastInfo() {collider = collider, localAngle = angle, localPosition = new UnityEngine.Vector2() {x = localPosition.x, y = localPosition.y}});
        }
        private static Light2DRaycast()
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  -0.01f);
            Light2D.Light2DRaycast.kLeftRotation = val_1.x;
            Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_4 = val_1.y;
            Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_8 = val_1.z;
            Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_C = val_1.w;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0.01f);
            Light2D.Light2DRaycast.kRightRotation = val_2.x;
            Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_14 = val_2.y;
            Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_18 = val_2.z;
            Light2D.Light2DRaycast.kLeftRotation.__il2cppRuntimeField_1C = val_2.w;
        }
    
    }

}
