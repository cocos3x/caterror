using UnityEngine;
public static class Vector3Extensions
{
    // Fields
    public static readonly UnityEngine.Vector3 upright;
    public static readonly UnityEngine.Vector3 upleft;
    public static readonly UnityEngine.Vector3 downright;
    public static readonly UnityEngine.Vector3 downleft;
    
    // Methods
    public static UnityEngine.Vector2 ToVector2XZ(UnityEngine.Vector3 v)
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  v.x, y:  v.z);
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public static UnityEngine.Vector2 ToVector2(UnityEngine.Vector3 v)
    {
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z});
    }
    public static float ForwardToTargetPositionXZAngle(UnityEngine.Vector3 position, UnityEngine.Vector3 forward, UnityEngine.Vector3 targetPosition)
    {
        float val_1;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  forward.x, y:  forward.z);
        return (float)Vector3Extensions.ForwardToTargetPositionXZAngle(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, forward:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, targetPosition:  new UnityEngine.Vector3() {x = targetPosition.x, y = val_1, z = targetPosition.y});
    }
    public static float ForwardToTargetPositionXZAngle(UnityEngine.Vector3 position, UnityEngine.Vector2 forward, UnityEngine.Vector3 targetPosition)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, b:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.z);
        UnityEngine.Vector2 val_3 = val_2.x.normalized;
        float val_8 = val_3.x;
        UnityEngine.Vector2 val_4 = forward.x.normalized;
        val_4.x = val_8 * val_4.x;
        val_4.y = val_3.y * val_4.y;
        val_8 = val_4.x + val_4.y;
        float val_9 = (val_8 * val_4.y) - (val_3.y * val_4.x);
        val_9 = val_9 * 57.29578f;
        return (float)val_9;
    }
    public static float ForwardToVectorXZAngle(UnityEngine.Vector3 forward, UnityEngine.Vector3 vector)
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  forward.x, y:  forward.z);
        return (float)Vector3Extensions.ForwardToVectorXZAngle(forward:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, vector:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z});
    }
    public static float ForwardToVectorXZAngle(UnityEngine.Vector2 forward, UnityEngine.Vector3 vector)
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  vector.x, y:  vector.z);
        UnityEngine.Vector2 val_2 = val_1.x.normalized;
        float val_7 = val_2.x;
        UnityEngine.Vector2 val_3 = forward.x.normalized;
        val_3.x = val_7 * val_3.x;
        val_3.y = val_2.y * val_3.y;
        val_7 = val_3.x + val_3.y;
        float val_8 = (val_7 * val_3.y) - (val_2.y * val_3.x);
        val_8 = val_8 * 57.29578f;
        return (float)val_8;
    }
    public static UnityEngine.Vector3 Center(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = v2.x, y = v2.y, z = v2.z}, b:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    public static float MagnitudeNotSqrt(UnityEngine.Vector3 v)
    {
        v.x = v.x * v.x;
        v.y = v.y * v.y;
        v.x = v.x + v.y;
        v.x = (v.z * v.z) + v.x;
        return (float)v.x;
    }
    public static bool NearCheckX(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, float max)
    {
        v1.x = v1.x - v2.x;
        v1.x = v1.x * v1.x;
        return (bool)(v1.x <= (max * max)) ? 1 : 0;
    }
    public static bool NearCheckY(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, float max)
    {
        float val_1 = v1.y - v2.y;
        val_1 = val_1 * val_1;
        return (bool)(val_1 <= (max * max)) ? 1 : 0;
    }
    public static bool NearCheckZ(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, float max)
    {
        float val_1 = v1.z - v2.z;
        val_1 = val_1 * val_1;
        return (bool)(val_1 <= (max * max)) ? 1 : 0;
    }
    public static bool NearCheck(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, float max)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z}, b:  new UnityEngine.Vector3() {x = v2.x, y = v2.y, z = v2.z});
        val_1.x = val_1.x * val_1.x;
        val_1.y = val_1.y * val_1.y;
        val_1.z = val_1.z * val_1.z;
        val_1.x = val_1.x + val_1.y;
        val_1.x = val_1.z + val_1.x;
        return (bool)(val_1.x <= (max * max)) ? 1 : 0;
    }
    public static bool NearCheck(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, float min, float max)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z}, b:  new UnityEngine.Vector3() {x = v2.x, y = v2.y, z = v2.z});
        val_1.x = val_1.x * val_1.x;
        val_1.y = val_1.y * val_1.y;
        val_1.z = val_1.z * val_1.z;
        val_1.x = val_1.x + val_1.y;
        val_1.x = val_1.z + val_1.x;
        return (bool)((val_1.x >= (min * min)) ? 1 : 0) & ((val_1.x <= (max * max)) ? 1 : 0);
    }
    public static UnityEngine.Vector3 Mul(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
    {
        return UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = v1.x, y = v1.y, z = v1.z}, b:  new UnityEngine.Vector3() {x = v2.x, y = v2.y, z = v2.z});
    }
    public static UnityEngine.Vector3 Div(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
    {
        v1.x = v1.x / v2.x;
        v1.y = v1.y / v2.y;
        v1.z = v1.z / v2.z;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static UnityEngine.Vector3 Rotate(UnityEngine.Vector3 v, UnityEngine.Vector3 eulerAngles)
    {
        UnityEngine.Vector3 val_1 = Vector3Extensions.RotateZDeg(v:  new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z}, angle:  eulerAngles.z);
        UnityEngine.Vector3 val_2 = Vector3Extensions.RotateXDeg(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, angle:  eulerAngles.x);
        return Vector3Extensions.RotateYDeg(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, angle:  eulerAngles.y);
    }
    public static UnityEngine.Vector3 RotateXDeg(UnityEngine.Vector3 v, float angle)
    {
        angle = angle * 0.01745329f;
        return Vector3Extensions.RotateXRad(v:  new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z}, angle:  angle);
    }
    public static UnityEngine.Vector3 RotateXRad(UnityEngine.Vector3 v, float angle)
    {
        float val_2 = angle;
        v.y = v.y * angle;
        v.z = v.z * val_2;
        val_2 = v.y * val_2;
        angle = v.z * angle;
        v.y = v.y - v.z;
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = angle + val_2};
    }
    public static UnityEngine.Vector3 RotateYDeg(UnityEngine.Vector3 v, float angle)
    {
        angle = angle * 0.01745329f;
        return Vector3Extensions.RotateYRad(v:  new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z}, angle:  angle);
    }
    public static UnityEngine.Vector3 RotateYRad(UnityEngine.Vector3 v, float angle)
    {
        float val_3 = angle;
        float val_2 = v.x * val_3;
        val_3 = v.z * val_3;
        angle = v.x * angle;
        val_2 = (v.z * angle) - val_2;
        val_3 = angle + val_3;
        return new UnityEngine.Vector3() {x = val_3, y = v.y, z = val_2};
    }
    public static UnityEngine.Vector3 RotateZDeg(UnityEngine.Vector3 v, float angle)
    {
        angle = angle * 0.01745329f;
        return Vector3Extensions.RotateZRad(v:  new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z}, angle:  angle);
    }
    public static UnityEngine.Vector3 RotateZRad(UnityEngine.Vector3 v, float angle)
    {
        float val_5 = angle;
        angle = v.x * val_5;
        val_5 = (v.x * angle) - (v.y * val_5);
        return new UnityEngine.Vector3() {x = val_5, y = (v.y * angle) + angle, z = v.z};
    }
    public static UnityEngine.Vector3 FixIfNaN(UnityEngine.Vector3 v)
    {
        v.z = ((System.Single.IsNaN(f:  v.z)) != true) ? 0f : v.z;
        return new UnityEngine.Vector3() {x = ((System.Single.IsNaN(f:  v.x)) != true) ? 0f : v.x, y = ((System.Single.IsNaN(f:  v.y)) != true) ? 0f : v.y, z = v.z};
    }
    public static UnityEngine.Vector3 SetX(UnityEngine.Vector3 v, float f)
    {
        return new UnityEngine.Vector3() {x = f, y = v.y, z = v.z};
    }
    public static UnityEngine.Vector3 SetY(UnityEngine.Vector3 v, float f)
    {
        return new UnityEngine.Vector3() {x = v.x, y = f, z = v.z};
    }
    public static UnityEngine.Vector3 SetZ(UnityEngine.Vector3 v, float f)
    {
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = f};
    }
    public static UnityEngine.Vector3 AddX(UnityEngine.Vector3 v, float f)
    {
        v.x = v.x + f;
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
    }
    public static UnityEngine.Vector3 AddY(UnityEngine.Vector3 v, float f)
    {
        v.y = v.y + f;
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
    }
    public static UnityEngine.Vector3 AddZ(UnityEngine.Vector3 v, float f)
    {
        v.z = v.z + f;
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
    }
    public static UnityEngine.Vector3 MulX(UnityEngine.Vector3 v, float f)
    {
        v.x = v.x * f;
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
    }
    public static UnityEngine.Vector3 MulY(UnityEngine.Vector3 v, float f)
    {
        v.y = v.y * f;
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
    }
    public static UnityEngine.Vector3 MulZ(UnityEngine.Vector3 v, float f)
    {
        v.z = v.z * f;
        return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
    }
    public static UnityEngine.Vector3 Min(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
    {
        v1.x = v1.x * v1.x;
        v1.y = v1.y * v1.y;
        v1.x = v1.x + v1.y;
        float val_2 = v2.y * v2.y;
        val_2 = (v2.x * v2.x) + val_2;
        v1.x = (v1.z * v1.z) + v1.x;
        val_2 = (v2.z * v2.z) + val_2;
        return new UnityEngine.Vector3() {x = (v1.x < 0) ? v1.x : v2.x, y = (v1.x < 0) ? v1.y : v2.y, z = (v1.x < 0) ? v1.z : v2.z};
    }
    public static UnityEngine.Vector3 Max(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
    {
        v1.x = v1.x * v1.x;
        v1.y = v1.y * v1.y;
        v1.x = v1.x + v1.y;
        float val_2 = v2.y * v2.y;
        val_2 = (v2.x * v2.x) + val_2;
        v1.x = (v1.z * v1.z) + v1.x;
        val_2 = (v2.z * v2.z) + val_2;
        return new UnityEngine.Vector3() {x = (v1.x > val_2) ? v1.x : v2.x, y = (v1.x > val_2) ? v1.y : v2.y, z = (v1.x > val_2) ? v1.z : v2.z};
    }
    public static UnityEngine.Vector3 Round(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
    {
        var val_1;
        var val_5;
        float val_6;
        var val_8;
        float val_9;
        var val_11;
        float val_12;
        float val_11 = v2.z;
        float val_8 = v2.y;
        float val_5 = v2.x;
        val_5 = v1.x + val_5;
        if(val_5 >= 0f)
        {
            goto label_3;
        }
        
        if((double)val_5 != (-0.5))
        {
            goto label_4;
        }
        
        val_5 = val_1;
        val_6 = -1f;
        goto label_5;
        label_3:
        if((double)val_5 != 0.5)
        {
            goto label_6;
        }
        
        val_5 = val_1;
        val_6 = 1f;
        label_5:
        val_6 = (float)val_5 + val_6;
        var val_2 = (((long)val_5 & 1) != 0) ? ((float)val_5) : (val_6);
        goto label_8;
        label_4:
        float val_6 = -0.5f;
        val_6 = val_5 + val_6;
        goto label_8;
        label_6:
        float val_7 = 0.5f;
        val_7 = val_5 + val_7;
        label_8:
        val_8 = v1.y + val_8;
        if(val_8 >= 0f)
        {
            goto label_9;
        }
        
        if((double)val_8 != (-0.5))
        {
            goto label_10;
        }
        
        val_8 = val_1;
        val_9 = -1f;
        goto label_11;
        label_9:
        if((double)val_8 != 0.5)
        {
            goto label_12;
        }
        
        val_8 = val_1;
        val_9 = 1f;
        label_11:
        val_9 = (float)val_8 + val_9;
        var val_3 = (((long)val_8 & 1) != 0) ? ((float)val_8) : (val_9);
        goto label_14;
        label_10:
        float val_9 = -0.5f;
        val_9 = val_8 + val_9;
        goto label_14;
        label_12:
        float val_10 = 0.5f;
        val_10 = val_8 + val_10;
        label_14:
        val_11 = v1.z + val_11;
        if(val_11 >= 0f)
        {
            goto label_15;
        }
        
        if((double)val_11 != (-0.5))
        {
            goto label_16;
        }
        
        val_11 = val_1;
        val_12 = -1f;
        goto label_17;
        label_15:
        if((double)val_11 != 0.5)
        {
            goto label_18;
        }
        
        val_11 = val_1;
        val_12 = 1f;
        label_17:
        val_12 = (float)val_11 + val_12;
        var val_4 = (((long)val_11 & 1) != 0) ? ((float)val_11) : (val_12);
        return new UnityEngine.Vector3() {x = val_5, y = val_8, z = v1.z};
        label_16:
        float val_12 = -0.5f;
        val_12 = val_11 + val_12;
        return new UnityEngine.Vector3() {x = val_5, y = val_8, z = v1.z};
        label_18:
        float val_13 = 0.5f;
        val_13 = val_11 + val_13;
        return new UnityEngine.Vector3() {x = val_5, y = val_8, z = v1.z};
    }
    public static UnityEngine.Vector3 RandomInsideCone(UnityEngine.Vector3 v, UnityEngine.Transform t, float conicAngle)
    {
        UnityEngine.Vector3 val_1 = t.up;
        UnityEngine.Vector3 val_2 = t.forward;
        UnityEngine.Vector3 val_3 = Vector3Extensions.RandomInsideCone(v:  new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z}, up:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, forward:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.z, z = conicAngle}, conicAngle:  v.y);
        return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static UnityEngine.Vector3 RandomInsideCone(UnityEngine.Vector3 v, UnityEngine.Vector3 up, UnityEngine.Vector3 forward, float conicAngle)
    {
        float val_1;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Random.Range(min:  0f, max:  360f), axis:  new UnityEngine.Vector3() {x = forward.x, y = val_1, z = forward.y});
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Random.Range(min:  0f, max:  forward.z), axis:  new UnityEngine.Vector3() {x = up.x, y = up.y, z = up.z});
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z});
    }
    private static Vector3Extensions()
    {
        Vector3Extensions.upright = 0;
        Vector3Extensions.upright.__il2cppRuntimeField_8 = 0;
        Vector3Extensions.upleft = 0;
        Vector3Extensions.upright.__il2cppRuntimeField_14 = 0;
        Vector3Extensions.downright = 0;
        Vector3Extensions.upright.__il2cppRuntimeField_20 = 0;
        Vector3Extensions.downleft = 0;
        Vector3Extensions.upright.__il2cppRuntimeField_2C = 0;
    }

}
