using UnityEngine;

namespace Anima2D
{
    public abstract class Ik2D : MonoBehaviour
    {
        // Fields
        private bool m_Record;
        private UnityEngine.Transform m_TargetTransform;
        private int m_NumBones;
        private float m_Weight;
        private bool m_RestoreDefaultPose;
        private bool m_OrientChild;
        private Anima2D.Bone2D m_CachedTarget;
        
        // Properties
        public Anima2D.IkSolver2D solver { get; }
        public bool record { get; }
        public Anima2D.Bone2D target { get; set; }
        public int numBones { get; set; }
        public float weight { get; set; }
        public bool restoreDefaultPose { get; set; }
        public bool orientChild { get; set; }
        
        // Methods
        public Anima2D.IkSolver2D get_solver()
        {
            goto typeof(Anima2D.Ik2D).__il2cppRuntimeField_1C8;
        }
        public bool get_record()
        {
            return (bool)this.m_Record;
        }
        public Anima2D.Bone2D get_target()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedTarget)) != false)
            {
                    if(this.m_TargetTransform != this.m_CachedTarget.transform)
            {
                    this.m_CachedTarget = 0;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedTarget)) == true)
            {
                    return (Anima2D.Bone2D)this.m_CachedTarget;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_TargetTransform)) == false)
            {
                    return (Anima2D.Bone2D)this.m_CachedTarget;
            }
            
            this.m_CachedTarget = this.m_TargetTransform.GetComponent<Anima2D.Bone2D>();
            return (Anima2D.Bone2D)this.m_CachedTarget;
        }
        public void set_target(Anima2D.Bone2D value)
        {
            this.m_CachedTarget = value;
            this.m_TargetTransform = value.transform;
            this.InitializeSolver();
        }
        public int get_numBones()
        {
            goto typeof(Anima2D.Ik2D).__il2cppRuntimeField_178;
        }
        public void set_numBones(int value)
        {
            if(this == this.m_NumBones)
            {
                    return;
            }
            
            this.m_NumBones = this;
            this.InitializeSolver();
        }
        public float get_weight()
        {
            return (float)this.m_Weight;
        }
        public void set_weight(float value)
        {
            this.m_Weight = value;
        }
        public bool get_restoreDefaultPose()
        {
            return (bool)this.m_RestoreDefaultPose;
        }
        public void set_restoreDefaultPose(bool value)
        {
            this.m_RestoreDefaultPose = value;
        }
        public bool get_orientChild()
        {
            return (bool)this.m_OrientChild;
        }
        public void set_orientChild(bool value)
        {
            this.m_OrientChild = value;
        }
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            var val_14;
            string val_18;
            UnityEngine.Matrix4x4 val_2 = this.transform.localToWorldMatrix;
            UnityEngine.Gizmos.matrix = new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_3, m12 = val_3, m22 = val_3, m32 = val_3, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4};
            if((this.enabled != false) && (((UnityEngine.Object.op_Implicit(exists:  this.target)) != false) && (this >= 1)))
            {
                    val_14 = this.transform;
                UnityEngine.Vector3 val_11 = val_14.position;
                val_18 = "ikGoal";
            }
            else
            {
                    val_14 = this.transform;
                UnityEngine.Vector3 val_13 = val_14.position;
                val_18 = "ikGoalDisabled";
            }
            
            UnityEngine.Gizmos.DrawIcon(center:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, name:  val_18);
        }
        private void OnValidate()
        {
            goto typeof(Anima2D.Ik2D).__il2cppRuntimeField_188;
        }
        private void Start()
        {
            goto typeof(Anima2D.Ik2D).__il2cppRuntimeField_198;
        }
        private void Update()
        {
            this.SetAttachedIK(ik2D:  this);
            goto typeof(Anima2D.Ik2D).__il2cppRuntimeField_1A8;
        }
        private void LateUpdate()
        {
            this.UpdateIK();
        }
        private void SetAttachedIK(Anima2D.Ik2D ik2D)
        {
            goto label_1;
            label_12:
            SolverPose val_1 = this.m_Record.Item[0];
            if((UnityEngine.Object.op_Implicit(exists:  val_1.bone)) != false)
            {
                    Anima2D.Bone2D val_4 = val_1.bone;
                val_4.m_AttachedIK = ik2D;
            }
            
            0 = 1;
            label_1:
            if(0 < this.m_Record.Count)
            {
                goto label_12;
            }
        
        }
        public void UpdateIK()
        {
            this.Update();
            if(this.m_OrientChild == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.target.child)) == false)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_8 = this.transform.rotation;
            this.target.child.transform.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        }
        protected virtual void OnIkUpdate()
        {
            this.weight = this.m_Weight;
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.m_RestoreDefaultPose = val_2.x;
            mem[1152921512407062452] = val_2.y;
            this.m_CachedTarget = val_2.z;
            mem[1152921512407062436] = this.m_RestoreDefaultPose;
        }
        private void InitializeSolver()
        {
            this.SetAttachedIK(ik2D:  0);
            this.Initialize(_rootBone:  Anima2D.Bone2D.GetChainBoneByIndex(chainTip:  this.target, index:  -789594881), numChilds:  -789594880);
        }
        protected virtual int ValidateNumBones(int numBones)
        {
            return (int)numBones;
        }
        protected virtual void Validate()
        {
        
        }
        protected virtual void OnStart()
        {
        
        }
        protected virtual void OnUpdate()
        {
        
        }
        protected virtual void OnLateUpdate()
        {
        
        }
        protected abstract Anima2D.IkSolver2D GetSolver(); // 0
        protected Ik2D()
        {
            this.m_Weight = 1f;
            this.m_RestoreDefaultPose = true;
            this.m_OrientChild = true;
        }
    
    }

}
