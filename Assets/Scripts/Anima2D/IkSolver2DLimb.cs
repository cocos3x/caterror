using UnityEngine;

namespace Anima2D
{
    [Serializable]
    public class IkSolver2DLimb : IkSolver2D
    {
        // Fields
        public bool flip;
        
        // Methods
        protected override void DoSolverUpdate()
        {
            var val_54;
            UnityEngine.Object val_55;
            float val_56;
            float val_57;
            float val_58;
            float val_62;
            float val_63;
            val_54 = this;
            val_55 = this.rootBone;
            if((UnityEngine.Object.op_Implicit(exists:  val_55)) == false)
            {
                    return;
            }
            
            if(val_55.Count != 2)
            {
                    return;
            }
            
            SolverPose val_4 = val_55.Item[0];
            val_55 = val_55.Item[1];
            UnityEngine.Vector3 val_8 = this.rootBone.transform.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            float val_53 = val_4.bone.length;
            float val_52 = val_55.bone.length;
            float val_22 = val_53 * val_4.bone.length;
            val_52 = val_52 * val_55.bone.length;
            float val_24 = val_55.bone.length;
            val_56 = (val_9.x - val_22) - val_52;
            val_24 = (val_4.bone.length + val_4.bone.length) * val_24;
            val_53 = val_56 / val_24;
            val_57 = 0f;
            if(val_53 > 1f)
            {
                goto label_28;
            }
            
            float val_27 = val_9.x + val_22;
            val_27 = val_27 - val_52;
            val_56 = val_9.x * (val_4.bone.length + val_4.bone.length);
            val_22 = val_27 / val_56;
            if((val_22 < (-1f)) || (val_22 > 1f))
            {
                goto label_28;
            }
            
            val_58 = 0f;
            if(val_53 < (-1f))
            {
                goto label_32;
            }
            
            val_58 = val_22 * 57.29578f;
            val_57 = val_53 * 57.29578f;
            goto label_32;
            label_28:
            val_58 = 0f;
            label_32:
            float val_29 = (this.flip == true) ? -1f : 1f;
            UnityEngine.Vector3 val_32 = this.rootBone.transform.position;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22, y = val_9.x, z = val_53}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
            UnityEngine.Vector3 val_36 = this.rootBone.transform.forward;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, planeNormal:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            val_62 = val_37.x;
            val_63 = val_37.y;
            if((UnityEngine.Object.op_Implicit(exists:  this.rootBone.transform.parent)) != false)
            {
                    val_54 = this.rootBone.transform.parent;
                UnityEngine.Vector3 val_45 = val_54.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_62, y = val_63, z = val_37.z});
                val_62 = val_45.x;
                val_63 = val_45.y;
            }
            
            UnityEngine.Quaternion val_49 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  (val_63 * 57.29578f) - (val_58 * val_29));
            val_4.solverRotation = val_49;
            mem2[0] = val_49.y;
            mem2[0] = val_49.z;
            mem2[0] = val_49.w;
            UnityEngine.Quaternion val_51 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_57 * val_29);
            val_5.solverRotation = val_51;
            mem2[0] = val_51.y;
            mem2[0] = val_51.z;
            mem2[0] = val_51.w;
        }
        public IkSolver2DLimb()
        {
        
        }
    
    }

}
