using UnityEngine;

namespace Anima2D
{
    [Serializable]
    public abstract class IkSolver2D
    {
        // Fields
        private UnityEngine.Transform m_RootBoneTransform;
        private System.Collections.Generic.List<Anima2D.IkSolver2D.SolverPose> m_SolverPoses;
        private float m_Weight;
        private bool m_RestoreDefaultPose;
        private Anima2D.Bone2D m_CachedRootBone;
        public UnityEngine.Vector3 targetPosition;
        
        // Properties
        public Anima2D.Bone2D rootBone { get; set; }
        public System.Collections.Generic.List<Anima2D.IkSolver2D.SolverPose> solverPoses { get; }
        public float weight { get; set; }
        public bool restoreDefaultPose { get; set; }
        
        // Methods
        public Anima2D.Bone2D get_rootBone()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedRootBone)) != false)
            {
                    if(this.m_RootBoneTransform != this.m_CachedRootBone.transform)
            {
                    this.m_CachedRootBone = 0;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CachedRootBone)) == true)
            {
                    return (Anima2D.Bone2D)this.m_CachedRootBone;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_RootBoneTransform)) == false)
            {
                    return (Anima2D.Bone2D)this.m_CachedRootBone;
            }
            
            this.m_CachedRootBone = this.m_RootBoneTransform.GetComponent<Anima2D.Bone2D>();
            return (Anima2D.Bone2D)this.m_CachedRootBone;
        }
        private void set_rootBone(Anima2D.Bone2D value)
        {
            this.m_CachedRootBone = value;
            this.m_RootBoneTransform = 0;
            if((UnityEngine.Object.op_Implicit(exists:  value)) == false)
            {
                    return;
            }
            
            this.m_RootBoneTransform = value.transform;
        }
        public System.Collections.Generic.List<Anima2D.IkSolver2D.SolverPose> get_solverPoses()
        {
            return (System.Collections.Generic.List<SolverPose>)this.m_SolverPoses;
        }
        public float get_weight()
        {
            return (float)this.m_Weight;
        }
        public void set_weight(float value)
        {
            this.m_Weight = UnityEngine.Mathf.Clamp01(value:  value);
        }
        public bool get_restoreDefaultPose()
        {
            return (bool)this.m_RestoreDefaultPose;
        }
        public void set_restoreDefaultPose(bool value)
        {
            this.m_RestoreDefaultPose = value;
        }
        public void Initialize(Anima2D.Bone2D _rootBone, int numChilds)
        {
            var val_5;
            UnityEngine.Object val_6;
            val_5 = numChilds;
            this.rootBone = _rootBone;
            val_6 = this.rootBone;
            this.m_SolverPoses.Clear();
            if(val_5 >= 1)
            {
                    do
            {
                if((UnityEngine.Object.op_Implicit(exists:  val_6)) != false)
            {
                    IkSolver2D.SolverPose val_3 = new IkSolver2D.SolverPose();
                val_3.bone = val_6;
                this.m_SolverPoses.Add(item:  val_3);
                val_6 = val_6.child;
            }
            
                val_5 = val_5 - 1;
            }
            while(val_5 != 0);
            
            }
            
            this.StoreDefaultPoses();
        }
        public void Update()
        {
            if(this.m_Weight <= 0f)
            {
                    return;
            }
            
            if(this.m_RestoreDefaultPose != false)
            {
                    this.RestoreDefaultPoses();
            }
            
            this.UpdateBones();
        }
        public void StoreDefaultPoses()
        {
            goto label_1;
            label_5:
            SolverPose val_1 = this.m_SolverPoses.Item[0];
            if(val_1 != null)
            {
                    val_1.StoreDefaultPose();
            }
            
            0 = 1;
            label_1:
            if(0 < this.m_SolverPoses.Count)
            {
                goto label_5;
            }
        
        }
        public void RestoreDefaultPoses()
        {
            goto label_1;
            label_5:
            SolverPose val_1 = this.m_SolverPoses.Item[0];
            if(val_1 != null)
            {
                    val_1.RestoreDefaultPose();
            }
            
            0 = 1;
            label_1:
            if(0 < this.m_SolverPoses.Count)
            {
                goto label_5;
            }
        
        }
        private void UpdateBones()
        {
            var val_11;
            float val_12;
            UnityEngine.Quaternion val_13;
            float val_14;
            val_11 = 0;
            val_12 = 1f;
            goto label_1;
            label_17:
            SolverPose val_1 = this.m_SolverPoses.Item[0];
            if((val_1 != null) && ((UnityEngine.Object.op_Implicit(exists:  val_1.bone)) != false))
            {
                    UnityEngine.Transform val_5 = val_1.bone.transform;
                if(this.m_Weight == val_12)
            {
                    val_13 = val_1.solverRotation;
                val_5.localRotation = new UnityEngine.Quaternion() {x = val_13, y = V9.16B, z = V10.16B, w = V11.16B};
            }
            else
            {
                    UnityEngine.Quaternion val_8 = val_1.bone.transform.localRotation;
                UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, b:  new UnityEngine.Quaternion() {x = val_1.solverRotation, y = V13.16B, z = val_12, w = V11.16B}, t:  this.m_Weight);
                val_13 = val_9.x;
                val_14 = val_9.z;
                val_5.localRotation = new UnityEngine.Quaternion() {x = val_13, y = val_9.y, z = val_14, w = val_9.w};
                val_12 = 1f;
            }
            
            }
            
            val_11 = 1;
            label_1:
            if(val_11 < this.m_SolverPoses.Count)
            {
                goto label_17;
            }
        
        }
        protected abstract void DoSolverUpdate(); // 0
        protected IkSolver2D()
        {
            this.m_SolverPoses = new System.Collections.Generic.List<SolverPose>();
            this.m_Weight = 1f;
            this.m_RestoreDefaultPose = true;
        }
    
    }

}
