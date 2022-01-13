using UnityEngine;
[Serializable]
public class IkSolver2D.SolverPose
{
    // Fields
    private UnityEngine.Transform m_BoneTransform;
    private Anima2D.Bone2D m_CachedBone;
    public UnityEngine.Vector3 solverPosition;
    public UnityEngine.Quaternion solverRotation;
    public UnityEngine.Quaternion defaultLocalRotation;
    
    // Properties
    public Anima2D.Bone2D bone { get; set; }
    
    // Methods
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
        this.m_BoneTransform = 0;
        this.m_CachedBone = value;
        if((UnityEngine.Object.op_Implicit(exists:  value)) == false)
        {
                return;
        }
        
        this.m_BoneTransform = this.m_CachedBone.transform;
    }
    public void StoreDefaultPose()
    {
        UnityEngine.Quaternion val_3 = this.bone.transform.localRotation;
        this.defaultLocalRotation = val_3;
        mem[1152921512411476032] = val_3.y;
        mem[1152921512411476036] = val_3.z;
        mem[1152921512411476040] = val_3.w;
    }
    public void RestoreDefaultPose()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.bone)) == false)
        {
                return;
        }
        
        this.bone.transform.localRotation = new UnityEngine.Quaternion() {x = this.defaultLocalRotation, y = V9.16B, z = V10.16B, w = V11.16B};
    }
    public IkSolver2D.SolverPose()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.solverPosition = val_1;
        mem[1152921512411732772] = val_1.y;
        mem[1152921512411732776] = val_1.z;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.solverRotation = val_2;
        mem[1152921512411732784] = val_2.y;
        mem[1152921512411732788] = val_2.z;
        mem[1152921512411732792] = val_2.w;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        this.defaultLocalRotation = val_3;
        mem[1152921512411732800] = val_3.y;
        mem[1152921512411732804] = val_3.z;
        mem[1152921512411732808] = val_3.w;
    }

}
