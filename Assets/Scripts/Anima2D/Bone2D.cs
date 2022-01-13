using UnityEngine;

namespace Anima2D
{
    public class Bone2D : MonoBehaviour
    {
        // Fields
        private UnityEngine.Color m_Color;
        private float m_Length;
        private UnityEngine.Transform m_ChildTransform;
        private Anima2D.Ik2D m_AttachedIK;
        private Anima2D.Bone2D m_CachedChild;
        private Anima2D.Bone2D m_ParentBone;
        
        // Properties
        public Anima2D.Ik2D attachedIK { get; set; }
        public UnityEngine.Color color { get; set; }
        public Anima2D.Bone2D child { get; set; }
        public UnityEngine.Vector3 localEndPosition { get; }
        public UnityEngine.Vector3 endPosition { get; }
        public float localLength { get; set; }
        public float length { get; }
        public Anima2D.Bone2D parentBone { get; }
        public Anima2D.Bone2D linkedParentBone { get; }
        public Anima2D.Bone2D root { get; }
        public Anima2D.Bone2D chainRoot { get; }
        public int chainLength { get; }
        
        // Methods
        public Anima2D.Ik2D get_attachedIK()
        {
            return (Anima2D.Ik2D)this.m_AttachedIK;
        }
        public void set_attachedIK(Anima2D.Ik2D value)
        {
            this.m_AttachedIK = value;
        }
        public UnityEngine.Color get_color()
        {
            return new UnityEngine.Color() {r = this.m_Color};
        }
        public void set_color(UnityEngine.Color value)
        {
            this.m_Color = value;
            mem[1152921512401692940] = value.g;
            mem[1152921512401692944] = value.b;
            mem[1152921512401692948] = value.a;
        }
        public Anima2D.Bone2D get_child()
        {
            UnityEngine.Object val_14;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedChild)) != false)
            {
                    val_14 = this.m_CachedChild.transform;
                if(this.m_ChildTransform != val_14)
            {
                    this.m_CachedChild = 0;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_ChildTransform)) != false)
            {
                    val_14 = this.transform;
                if(this.m_ChildTransform.parent != val_14)
            {
                    this.m_CachedChild = 0;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedChild)) == true)
            {
                    return (Anima2D.Bone2D)this.m_CachedChild;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_ChildTransform)) == false)
            {
                    return (Anima2D.Bone2D)this.m_CachedChild;
            }
            
            val_14 = this.transform;
            if(this.m_ChildTransform.parent != val_14)
            {
                    return (Anima2D.Bone2D)this.m_CachedChild;
            }
            
            this.m_CachedChild = this.m_ChildTransform.GetComponent<Anima2D.Bone2D>();
            return (Anima2D.Bone2D)this.m_CachedChild;
        }
        public void set_child(Anima2D.Bone2D value)
        {
            this.m_CachedChild = value;
            this.m_ChildTransform = value.transform;
        }
        public UnityEngine.Vector3 get_localEndPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.right;
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.localLength);
        }
        public UnityEngine.Vector3 get_endPosition()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = this.localEndPosition;
            if(val_1 != null)
            {
                    return val_1.TransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            }
            
            return val_1.TransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public float get_localLength()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.child)) == false)
            {
                    return (float)this.m_Length;
            }
            
            UnityEngine.Vector3 val_6 = this.child.transform.position;
            UnityEngine.Vector3 val_7 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.m_Length = UnityEngine.Mathf.Clamp(value:  val_7.x, min:  0f, max:  val_7.x);
            return (float)this.m_Length;
        }
        public void set_localLength(float value)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.child)) == true)
            {
                    return;
            }
            
            this.m_Length = value;
        }
        public float get_length()
        {
            UnityEngine.Vector3 val_2 = this.localEndPosition;
            UnityEngine.Vector3 val_3 = this.transform.TransformVector(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return (float)val_3.x;
        }
        public Anima2D.Bone2D get_parentBone()
        {
            Anima2D.Bone2D val_9;
            UnityEngine.Transform val_2 = this.transform.parent;
            val_9 = this.m_ParentBone;
            if((UnityEngine.Object.op_Implicit(exists:  val_9)) == false)
            {
                goto label_4;
            }
            
            val_9 = this.m_ParentBone.transform;
            if(val_2 == val_9)
            {
                    return (Anima2D.Bone2D)this.m_ParentBone;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) == true)
            {
                goto label_11;
            }
            
            this.m_ParentBone = 0;
            return (Anima2D.Bone2D)this.m_ParentBone;
            label_4:
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
            {
                    return (Anima2D.Bone2D)this.m_ParentBone;
            }
            
            label_11:
            this.m_ParentBone = val_2.GetComponent<Anima2D.Bone2D>();
            return (Anima2D.Bone2D)this.m_ParentBone;
        }
        public Anima2D.Bone2D get_linkedParentBone()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.parentBone)) == false)
            {
                    return 0;
            }
            
            if(this.parentBone.child != this)
            {
                    return 0;
            }
            
            return this.parentBone;
        }
        public Anima2D.Bone2D get_root()
        {
            goto label_1;
            label_6:
            this = this.parentBone;
            label_1:
            if((UnityEngine.Object.op_Implicit(exists:  this.parentBone)) == true)
            {
                goto label_6;
            }
            
            return (Anima2D.Bone2D)this;
        }
        public Anima2D.Bone2D get_chainRoot()
        {
            goto label_1;
            label_11:
            if(this.parentBone.child != this)
            {
                    return (Anima2D.Bone2D)this;
            }
            
            this = this.parentBone;
            label_1:
            if((UnityEngine.Object.op_Implicit(exists:  this.parentBone)) == true)
            {
                goto label_11;
            }
            
            return (Anima2D.Bone2D)this;
        }
        public int get_chainLength()
        {
            UnityEngine.Object val_7;
            var val_8;
            UnityEngine.Object val_9;
            val_7 = this;
            val_8 = 1;
            goto label_1;
            label_11:
            val_9 = this.parentBone.child;
            if(val_9 != this)
            {
                    return (int)val_8;
            }
            
            val_8 = 2;
            val_7 = this.parentBone;
            label_1:
            val_9 = val_7.parentBone;
            if((UnityEngine.Object.op_Implicit(exists:  val_9)) == true)
            {
                goto label_11;
            }
            
            return (int)val_8;
        }
        public static Anima2D.Bone2D GetChainBoneByIndex(Anima2D.Bone2D chainTip, int index)
        {
            var val_7;
            if((UnityEngine.Object.op_Implicit(exists:  chainTip)) == false)
            {
                    return (Anima2D.Bone2D)0;
            }
            
            val_7 = chainTip.chainLength;
            if(val_7 < 1)
            {
                goto label_13;
            }
            
            var val_7 = 0;
            label_15:
            if((UnityEngine.Object.op_Implicit(exists:  chainTip)) == false)
            {
                goto label_13;
            }
            
            if(index == val_7)
            {
                    return (Anima2D.Bone2D)0;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  chainTip.linkedParentBone)) == false)
            {
                goto label_13;
            }
            
            Anima2D.Bone2D val_6 = chainTip.parentBone;
            val_7 = val_7 + 1;
            if(val_7 < val_7)
            {
                goto label_15;
            }
            
            label_13:
            0 = 0;
            return (Anima2D.Bone2D)0;
        }
        private void OnDrawGizmos()
        {
        
        }
        public Bone2D()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.m_Color = val_1;
            mem[1152921512403767180] = val_1.g;
            mem[1152921512403767184] = val_1.b;
            mem[1152921512403767188] = val_1.a;
            this.m_Length = 1f;
        }
    
    }

}
