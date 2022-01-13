using UnityEngine;

namespace Light2D
{
    public class Light2DSpriteUpdater
    {
        // Fields
        private readonly Light2D.Light2DAngle m_LightAngle;
        private readonly Light2D.Light2DRadius m_LightRadius;
        private Light2D.Light2DOverlap m_LightOverlap;
        private Light2D.Light2DRaycast m_LightRaycast;
        private UnityEngine.Vector2[] m_Vertices;
        private ushort[] m_Triangles;
        
        // Properties
        public Light2D.Light2DAngle lightAngle { get; }
        public Light2D.Light2DRadius lightRadius { get; }
        public Light2D.Light2DOverlap lightOverlap { get; }
        public Light2D.Light2DRaycast lightRaycast { get; }
        
        // Methods
        public Light2D.Light2DAngle get_lightAngle()
        {
            return (Light2D.Light2DAngle)this.m_LightAngle;
        }
        public Light2D.Light2DRadius get_lightRadius()
        {
            return (Light2D.Light2DRadius)this.m_LightRadius;
        }
        public Light2D.Light2DOverlap get_lightOverlap()
        {
            return (Light2D.Light2DOverlap)this.m_LightOverlap;
        }
        public Light2D.Light2DRaycast get_lightRaycast()
        {
            return (Light2D.Light2DRaycast)this.m_LightRaycast;
        }
        public Light2DSpriteUpdater()
        {
            Light2D.Light2DAngle val_1 = null;
            .m_Angle = 360f;
            val_1 = new Light2D.Light2DAngle();
            this.m_LightAngle = val_1;
            this.m_LightRadius = new Light2D.Light2DRadius();
            this.m_LightOverlap = new Light2D.Light2DOverlap(capacity:  1024);
            this.m_LightRaycast = new Light2D.Light2DRaycast(capacity:  1024);
        }
        public void UpdateLightSprite(UnityEngine.Transform lightTransform, UnityEngine.Sprite sprite, Light2D.Light2DProperties properties)
        {
            Light2D.Light2DRadius val_8;
            Light2D.Light2DRadius val_9;
            Light2D.ScalableArray<UnityEngine.Collider2D> val_10;
            var val_11;
            if(properties.m_Resolution < 3)
            {
                    return;
            }
            
            UnityEngine.Physics2D.autoSyncTransforms = false;
            UnityEngine.Physics2D.SyncTransforms();
            this.m_LightAngle.angle = properties.m_Angle;
            this.m_LightAngle.m_Rotate = properties.m_Rotation;
            this.m_LightRadius.Init(transform:  lightTransform, sprite:  sprite, radius:  properties.m_Radius);
            UnityEngine.Vector3 val_2 = lightTransform.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_8 = this.m_LightRadius;
            this.m_LightRaycast.Init(lightTransform:  lightTransform, lightRadius:  val_8, lightAngle:  this.m_LightAngle, layerMask:  properties.m_LayerMask);
            this.m_LightRaycast.RaycastByResolution(resolution:  properties.m_Resolution);
            val_9 = this.m_LightRadius;
            this.m_LightOverlap.CircleOverlap(lightTransform:  lightTransform, radius:  this.m_LightRadius.m_WorldRadius, layerMask:  properties.m_LayerMask);
            val_10 = this.m_LightOverlap.m_Results;
            if(val_10.length < 1)
            {
                goto label_16;
            }
            
            val_8 = 1152921512178199808;
            val_11 = 0;
            goto label_17;
            label_23:
            val_9 = this.m_LightRaycast;
            val_9.RaycastCollider(collider:  this.m_LightOverlap.m_Results.Item[0]);
            val_11 = 1;
            label_17:
            if(val_11 < this.m_LightOverlap.m_Results.length)
            {
                goto label_23;
            }
            
            val_10 = this.m_LightRaycast;
            val_10.SortResults();
            label_16:
            UnityEngine.Physics2D.autoSyncTransforms = UnityEngine.Physics2D.autoSyncTransforms;
            this.DrawShadow(sprite:  sprite, lightTransform:  lightTransform, properties:  this.m_LightAngle);
        }
        private void DrawShadow(UnityEngine.Sprite sprite, UnityEngine.Transform lightTransform, Light2D.Light2DProperties properties)
        {
            float val_9;
            float val_10;
            Light2D.ScalableArray<Light2D.RaycastInfo> val_23;
            var val_24;
            UnityEngine.Vector2[] val_25;
            int val_26;
            var val_27;
            var val_28;
            UnityEngine.Vector3 val_1 = lightTransform.localScale;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Rect val_3 = sprite.rect;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_3.m_XMin, y = val_3.m_YMin}, d:  2f);
            val_23 = this.m_LightRaycast.m_Results;
            val_24 = 1152921512174184256;
            if(val_23.length < 1)
            {
                    return;
            }
            
            val_25 = this.m_Vertices;
            val_26 = val_23.length + 1;
            if(val_25 != null)
            {
                    if(val_26 == this.m_Vertices.Length)
            {
                goto label_10;
            }
            
            }
            
            val_25 = new UnityEngine.Vector2[0];
            this.m_Vertices = val_25;
            if(val_25 == null)
            {
                goto label_11;
            }
            
            label_10:
            val_25[0] = val_4;
            val_25[0] = val_4.y;
            val_27 = 1;
            goto label_13;
            label_24:
            Light2D.RaycastInfo val_8 = this.m_LightRaycast.m_Results.Item[-1017900784];
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, d:  sprite.pixelsPerUnit);
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            val_26 = 1;
            val_27 = 2;
            this.m_Vertices[val_26] = UnityEngine.Mathf.Clamp(value:  val_13.x, min:  0f, max:  val_3.m_XMin);
            this.m_Vertices[val_26] = UnityEngine.Mathf.Clamp(value:  val_13.y, min:  0f, max:  val_3.m_YMin);
            label_13:
            if(1 < val_23.length)
            {
                goto label_24;
            }
            
            val_23 = this.m_Triangles;
            int val_18 = val_26 - ((this.m_LightAngle.m_Angle < 360f) ? 2 : (0 + 1));
            if(val_23 == null)
            {
                goto label_26;
            }
            
            val_28 = val_18 + (val_18 << 1);
            if(val_28 != this.m_Triangles.Length)
            {
                goto label_27;
            }
            
            goto label_28;
            label_26:
            val_28 = val_18 + (val_18 << 1);
            label_27:
            val_23 = new ushort[0];
            this.m_Triangles = val_23;
            label_28:
            if(val_18 >= 1)
            {
                    val_18 = 0 - val_18;
                var val_25 = 2;
                do
            {
                val_23[(long)val_25 - 2] = 0;
                this.m_Triangles[(long)val_25 - 1] = 2 - 1;
                this.m_Triangles[2] = (2 < this.m_Vertices.Length) ? 2 : (0 + 1);
                val_23 = this.m_Triangles;
                val_26 = 2 + 1;
                val_25 = val_25 + 3;
            }
            while((val_18 + val_26) != 2);
            
            }
            
            sprite.OverrideGeometry(vertices:  this.m_Vertices, triangles:  val_23);
            return;
            label_11:
        }
    
    }

}
