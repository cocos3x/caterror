using UnityEngine;

namespace Light2D
{
    public abstract class Light2DBase : MonoBehaviour
    {
        // Fields
        private Light2D.Light2DProperties m_Properties;
        private UnityEngine.Sprite m_AppliedSprite;
        private UnityEngine.Sprite m_SourceSprite;
        public bool autoUpdate;
        public bool sendEventMessage;
        public bool executeInEditMode;
        private int m_LastUpdateFrame;
        private readonly Light2D.Light2DSpriteUpdater m_LightUpdater;
        private readonly Light2D.Light2DEventManager m_EventManager;
        private bool m_IsEnabled;
        
        // Properties
        public Light2D.Light2DProperties properties { get; set; }
        public UnityEngine.Sprite sprite { get; set; }
        protected UnityEngine.Sprite rendererSprite { get; set; }
        public float radius { get; set; }
        public float angle { get; set; }
        public float rotation { get; set; }
        public int resolution { get; set; }
        public int layerMask { get; set; }
        
        // Methods
        public Light2D.Light2DProperties get_properties()
        {
            return (Light2D.Light2DProperties)this.m_Properties;
        }
        public void set_properties(Light2D.Light2DProperties value)
        {
            this.m_Properties = value;
        }
        public UnityEngine.Sprite get_sprite()
        {
            return (UnityEngine.Sprite)this.m_SourceSprite;
        }
        public void set_sprite(UnityEngine.Sprite value)
        {
            this.m_SourceSprite = value;
        }
        protected UnityEngine.Sprite get_rendererSprite()
        {
            goto typeof(Light2D.Light2DBase).__il2cppRuntimeField_168;
        }
        protected void set_rendererSprite(UnityEngine.Sprite value)
        {
            goto typeof(Light2D.Light2DBase).__il2cppRuntimeField_178;
        }
        public float get_radius()
        {
            if(this.m_Properties != null)
            {
                    return (float)this.m_Properties.m_Radius;
            }
            
            return (float)this.m_Properties.m_Radius;
        }
        public void set_radius(float value)
        {
            float val_1 = value;
            val_1 = val_1 + 360f;
            this.m_Properties.m_Radius = val_1;
        }
        public float get_angle()
        {
            if(this.m_Properties != null)
            {
                    return (float)this.m_Properties.m_Angle;
            }
            
            return (float)this.m_Properties.m_Angle;
        }
        public void set_angle(float value)
        {
            float val_1 = value;
            val_1 = val_1 + 360f;
            this.m_Properties.m_Angle = val_1;
        }
        public float get_rotation()
        {
            if(this.m_Properties != null)
            {
                    return (float)this.m_Properties.m_Rotation;
            }
            
            return (float)this.m_Properties.m_Rotation;
        }
        public void set_rotation(float value)
        {
            float val_1 = value;
            val_1 = val_1 + 360f;
            this.m_Properties.m_Rotation = val_1;
        }
        public int get_resolution()
        {
            if(this.m_Properties != null)
            {
                    return (int)this.m_Properties.m_Resolution;
            }
            
            return (int)this.m_Properties.m_Resolution;
        }
        public void set_resolution(int value)
        {
            this.m_Properties.resolution = value;
        }
        public int get_layerMask()
        {
            if(this.m_Properties != null)
            {
                    return (int)this.m_Properties.m_LayerMask;
            }
            
            return (int)this.m_Properties.m_LayerMask;
        }
        public void set_layerMask(int value)
        {
            this.m_Properties.m_LayerMask = value;
        }
        private void OnEnable()
        {
            this.m_IsEnabled = true;
        }
        private void OnDisable()
        {
            goto typeof(Light2D.Light2DBase).__il2cppRuntimeField_178;
        }
        public void UpdateGeometry()
        {
            UnityEngine.Sprite val_7;
            UnityEngine.Sprite val_8;
            UnityEngine.Object val_9;
            if(this.m_LastUpdateFrame >= UnityEngine.Time.frameCount)
            {
                    return;
            }
            
            if(this.m_Properties != null)
            {
                    if(this.m_LightUpdater != null)
            {
                    if(this.m_IsEnabled != false)
            {
                    if(this.m_SourceSprite != 0)
            {
                    val_7 = this.m_SourceSprite;
            }
            else
            {
                    val_7 = this;
            }
            
                this.SetSprite(sourceSprite:  this);
                this.m_IsEnabled = false;
            }
            
                val_8 = this.m_SourceSprite;
                val_9 = this.m_AppliedSprite;
                if(val_8 != val_9)
            {
                    val_9 = this.m_SourceSprite;
                this.SetSprite(sourceSprite:  val_9);
            }
            
                if(this != 0)
            {
                    this.UpdateLightScale(sprite:  this);
                val_8 = this.m_LightUpdater;
                val_8.UpdateLightSprite(lightTransform:  this.transform, sprite:  this, properties:  this.m_Properties);
            }
            
            }
            
                if(this.sendEventMessage != false)
            {
                    this.SendEvetMessage();
            }
            
            }
            
            this.m_LastUpdateFrame = UnityEngine.Time.frameCount;
        }
        public void SetSprite(UnityEngine.Sprite sourceSprite)
        {
            this.m_SourceSprite = sourceSprite;
            if(sourceSprite != 0)
            {
                    UnityEngine.Sprite val_2 = UnityEngine.Object.Instantiate<UnityEngine.Sprite>(original:  this.m_SourceSprite);
            }
            
            this.m_AppliedSprite = sourceSprite;
        }
        private void LateUpdate()
        {
            if(this.autoUpdate == false)
            {
                    return;
            }
            
            this.UpdateGeometry();
        }
        private void SendEvetMessage()
        {
            UnityEngine.Object val_2;
            goto label_3;
            label_11:
            Light2D.RaycastInfo val_1 = this.m_LightUpdater.m_LightRaycast.m_Results.Item[0];
            if(val_2 != 0)
            {
                    this.m_EventManager.Add(go:  val_2.gameObject);
            }
            
            0 = 1;
            label_3:
            if(0 < this.m_LightUpdater.m_LightRaycast.m_Results.length)
            {
                goto label_11;
            }
            
            this.m_EventManager.SendEnterMessage(light:  this);
            this.m_EventManager.SendExitMessage(light:  this);
            this.m_EventManager.Complete();
        }
        private void UpdateLightScale(UnityEngine.Sprite sprite)
        {
            float val_3;
            float val_22;
            float val_23;
            float val_24;
            UnityEngine.Bounds val_1 = sprite.bounds;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B});
            float val_19 = UnityEngine.Mathf.Min(a:  val_4.x, b:  val_4.y);
            val_19 = val_19 * 0.5f;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.m_Properties.m_Radius);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_19);
            val_22 = val_8.x;
            val_23 = val_8.y;
            val_24 = val_8.z;
            if(this.transform.parent != 0)
            {
                    UnityEngine.Vector3 val_14 = this.transform.parent.lossyScale;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  Light2D.Tools.GetScaleBase(lossyScale:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}));
                if(((val_16.z != 0f) && (val_16.x != 0f)) && (val_16.y != 0f))
            {
                    val_22 = val_22 / val_16.x;
                val_23 = val_23 / val_16.y;
                val_24 = val_24 / val_16.z;
            }
            else
            {
                    UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
                val_22 = val_17.x;
                val_23 = val_17.y;
                val_24 = val_17.z;
            }
            
            }
            
            this.transform.localScale = new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24};
        }
        public abstract UnityEngine.Sprite GetRendererSprite(); // 0
        public abstract void SetRendererSprite(UnityEngine.Sprite sprite); // 0
        private void OnDrawGizmosSelected()
        {
            float val_7;
            float val_8;
            Light2D.Light2DSpriteUpdater val_15;
            Light2D.Light2DRaycast val_16;
            float val_17;
            val_15 = this.m_LightUpdater;
            if(val_15 == null)
            {
                    return;
            }
            
            if(this.m_LightUpdater.m_LightRadius != null)
            {
                goto label_2;
            }
            
            val_15 = this.m_LightUpdater;
            if(val_15 == null)
            {
                goto label_3;
            }
            
            label_2:
            val_16 = this.m_LightUpdater.m_LightRaycast;
            val_17 = this.m_LightUpdater.m_LightRadius.m_WorldRadius;
            if(this.m_LightUpdater.m_LightRaycast.m_Results == null)
            {
                    return;
            }
            
            UnityEngine.Color val_1 = UnityEngine.Color.yellow;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            val_16 = this.transform;
            UnityEngine.Vector3 val_3 = val_16.position;
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, radius:  val_17);
            UnityEngine.Color val_4 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            if(this.m_LightUpdater.m_LightRaycast.m_Results.length < 1)
            {
                    return;
            }
            
            do
            {
                Light2D.RaycastInfo val_6 = this.m_LightUpdater.m_LightRaycast.m_Results.Item[0];
                UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7, y = val_8});
                UnityEngine.Vector3 val_11 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_17 = val_11.x;
                UnityEngine.Vector3 val_13 = this.transform.position;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, to:  new UnityEngine.Vector3() {x = val_17, y = val_11.y, z = val_11.z});
                val_16 = 0 + 1;
            }
            while(val_16 < this.m_LightUpdater.m_LightRaycast.m_Results.length);
            
            return;
            label_3:
        }
        protected Light2DBase()
        {
            Light2D.Light2DProperties val_1 = null;
            .m_Radius = 10f;
            .m_Angle = 360f;
            .m_Resolution = 65525;
            .m_LayerMask = 0;
            val_1 = new Light2D.Light2DProperties();
            this.m_Properties = val_1;
            this.autoUpdate = true;
            this.m_LastUpdateFrame = 0;
            this.m_LightUpdater = new Light2D.Light2DSpriteUpdater();
            this.m_EventManager = new Light2D.Light2DEventManager();
        }
    
    }

}
