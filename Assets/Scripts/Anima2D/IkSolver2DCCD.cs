using UnityEngine;

namespace Anima2D
{
    [Serializable]
    public class IkSolver2DCCD : IkSolver2D
    {
        // Fields
        public int iterations;
        public float damping;
        
        // Methods
        protected override void DoSolverUpdate()
        {
            var val_43;
            var val_44;
            var val_45;
            int val_46;
            float val_47;
            float val_48;
            float val_49;
            if((UnityEngine.Object.op_Implicit(exists:  this.rootBone)) == false)
            {
                    return;
            }
            
            val_43 = 0;
            goto label_4;
            label_17:
            SolverPose val_3 = X21.Item[0];
            if(val_3 != null)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  val_3.bone)) != false)
            {
                    UnityEngine.Quaternion val_8 = val_3.bone.transform.localRotation;
                val_3.solverRotation = val_8;
                mem2[0] = val_8.y;
                mem2[0] = val_8.z;
                mem2[0] = val_8.w;
                val_44 = val_3.bone.transform;
                UnityEngine.Vector3 val_13 = val_44.position;
                UnityEngine.Vector3 val_14 = this.rootBone.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
                val_3.solverPosition = val_14;
                mem2[0] = val_14.y;
                mem2[0] = val_14.z;
            }
            
            }
            
            val_43 = 1;
            label_4:
            if(val_43 < val_3.Count)
            {
                goto label_17;
            }
            
            if(val_3 != null)
            {
                    val_45 = val_3.Count;
            }
            else
            {
                    val_45 = 0.Count;
            }
            
            val_46 = val_3.Item[val_45 - 1].bone;
            UnityEngine.Vector3 val_23 = val_46.endPosition;
            UnityEngine.Vector3 val_24 = this.rootBone.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            int val_43 = this.rootBone.transform;
            UnityEngine.Vector3 val_27 = val_43.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            val_48 = this.damping;
            float val_28 = UnityEngine.Mathf.Clamp01(value:  val_48);
            this.damping = val_28;
            float val_29 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.99f, t:  val_28);
            if(this.iterations < 1)
            {
                    return;
            }
            
            val_29 = 1f - val_29;
            do
            {
                val_43 = val_43.Count - 1;
                if((val_43 & 2147483648) == 0)
            {
                    do
            {
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_31.solverPosition, y = val_48, z = val_23.y});
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_31.solverPosition, y = val_48, z = val_23.y});
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.forward;
                UnityEngine.Vector3 val_36 = UnityEngine.Vector3.forward;
                float val_44 = val_29;
                val_44 = val_44 * (Anima2D.MathUtils.SignedAngle(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = 0f}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = 0f}, forward:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.z}));
                UnityEngine.Quaternion val_37 = UnityEngine.Quaternion.AngleAxis(angle:  val_44, axis:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
                val_47 = val_37.x;
                val_49 = val_37.y;
                UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_31.solverRotation, y = val_37.y, z = val_37.z, w = val_32.y}, rhs:  new UnityEngine.Quaternion() {x = val_47, y = val_49, z = val_37.z, w = val_37.w});
                val_31.solverRotation = val_38;
                mem2[0] = val_38.y;
                mem2[0] = val_38.z;
                mem2[0] = val_38.w;
                UnityEngine.Vector3 val_39 = this.RotatePositionFrom(position:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, pivot:  new UnityEngine.Vector3() {x = val_31.solverPosition, y = val_36.x, z = val_36.y}, rotation:  new UnityEngine.Quaternion() {x = val_47, y = val_37.z, w = val_27.z});
                val_46 = val_46.Item[val_43].Count - 1;
                if(val_46 > val_43)
            {
                    do
            {
                UnityEngine.Vector3 val_42 = val_45.Item[val_46].RotatePositionFrom(position:  new UnityEngine.Vector3() {x = val_41.solverPosition, y = val_39.y, z = val_39.z}, pivot:  new UnityEngine.Vector3() {x = val_31.solverPosition, y = val_36.x, z = val_36.y}, rotation:  new UnityEngine.Quaternion() {x = val_47, y = val_37.z, w = val_27.z});
                val_49 = val_42.x;
                val_47 = val_42.z;
                val_46 = val_46 - 1;
                val_41.solverPosition = val_42;
                mem2[0] = val_42.y;
                mem2[0] = val_47;
            }
            while(val_46 > val_43);
            
            }
            
                val_43 = val_43 - 1;
            }
            while((val_43 & 2147483648) == 0);
            
            }
            
                val_44 = 0 + 1;
            }
            while(val_44 < this.iterations);
        
        }
        private UnityEngine.Vector3 RotatePositionFrom(UnityEngine.Vector3 position, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation)
        {
            float val_1;
            float val_2;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = pivot.x, y = pivot.y, z = pivot.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = val_2, z = rotation.y, w = val_1}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pivot.x, y = pivot.y, z = pivot.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public IkSolver2DCCD()
        {
            this.iterations = 10;
            this.damping = 7.346868E-41f;
        }
    
    }

}
