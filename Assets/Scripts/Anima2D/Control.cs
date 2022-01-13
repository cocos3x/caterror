using UnityEngine;

namespace Anima2D
{
    public class Control : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform m_BoneTransform;
        private Anima2D.Bone2D m_CachedBone;
        
        // Properties
        public UnityEngine.Color color { get; }
        public Anima2D.Bone2D bone { get; set; }
        
        // Methods
        public UnityEngine.Color get_color()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedBone)) != false)
            {
                    this = this.m_CachedBone;
                if(this != null)
            {
                    return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            }
            
                return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        public Anima2D.Bone2D get_bone()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedBone)) != false)
            {
                    if(this.m_BoneTransform != this.m_CachedBone.transform)
            {
                    this.m_CachedBone = 0;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedBone)) == true)
            {
                    return (Anima2D.Bone2D)this.m_CachedBone;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_BoneTransform)) == false)
            {
                    return (Anima2D.Bone2D)this.m_CachedBone;
            }
            
            this.m_CachedBone = this.m_BoneTransform.GetComponent<Anima2D.Bone2D>();
            return (Anima2D.Bone2D)this.m_CachedBone;
        }
        public void set_bone(Anima2D.Bone2D value)
        {
            this.m_BoneTransform = value.transform;
        }
        private void Start()
        {
        
        }
        private void LateUpdate()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.bone)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = this.bone.transform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Quaternion val_10 = this.bone.transform.rotation;
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        }
        public Control()
        {
        
        }
    
    }

}
