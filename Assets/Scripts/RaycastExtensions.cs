using UnityEngine;
public static class RaycastExtensions
{
    // Methods
    public static UnityEngine.RaycastHit[] ConeCastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float coneAngle, float maxRadius, float maxDistance = ∞, int layerMask = -5)
    {
        float val_9;
        float val_10;
        val_9 = maxDistance;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(val_2.Length == 0)
        {
                return (UnityEngine.RaycastHit[])new UnityEngine.RaycastHit[0];
        }
        
        System.Collections.Generic.List<UnityEngine.RaycastHit> val_3 = new System.Collections.Generic.List<UnityEngine.RaycastHit>();
        if(val_2.Length >= 1)
        {
                do
        {
            val_10 = ((UnityEngine.Physics.SphereCastAll(origin:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  maxRadius, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, maxDistance:  val_9)) + (0 * 44)) + 32;
            val_9 = val_1.y;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_9, z = val_1.z}, b:  new UnityEngine.Vector3() {x = origin.x, y = origin.y, z = origin.z});
            if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, to:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) < 0)
        {
                val_3.Add(item:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, m_Normal = new UnityEngine.Vector3() {x = val_10, y = ((0 * 44) + val_2 + 32) + 16, z = ((0 * 44) + val_2 + 32) + 16}, m_FaceID = ((0 * 44) + val_2 + 32) + 16, m_Distance = ((0 * 44) + val_2 + 32) + 16, m_UV = new UnityEngine.Vector2() {x = ((0 * 44) + val_2 + 32) + 16, y = ((0 * 44) + val_2 + 32) + 16}, m_Collider = ((0 * 44) + val_2 + 32) + 16});
        }
        
        }
        while((0 + 1) < val_2.Length);
        
        }
        
        T[] val_8 = val_3.ToArray();
        return (UnityEngine.RaycastHit[])new UnityEngine.RaycastHit[0];
    }

}
