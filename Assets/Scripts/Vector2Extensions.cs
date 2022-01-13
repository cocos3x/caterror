using UnityEngine;
public static class Vector2Extensions
{
    // Methods
    public static UnityEngine.Vector3 ToVector3XZ(UnityEngine.Vector2 v)
    {
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static float Dot(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
    {
        v1.x = v1.x * v2.x;
        v1.y = v1.y * v2.y;
        v1.x = v1.x + v1.y;
        return (float)v1.x;
    }
    public static float Cross(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
    {
        v1.x = v1.x * v2.y;
        v1.y = v1.y * v2.x;
        v1.x = v1.x - v1.y;
        return (float)v1.x;
    }
    public static UnityEngine.Vector2 RandomRotateDeg(UnityEngine.Vector2 v, float randomAngle)
    {
        float val_3 = 0.01745329f;
        val_3 = -(randomAngle * val_3);
        return Vector2Extensions.RotateRad(v:  new UnityEngine.Vector2() {x = v.x, y = v.y}, angle:  UnityEngine.Random.Range(min:  val_3, max:  randomAngle * val_3));
    }
    public static UnityEngine.Vector2 RotateDeg(UnityEngine.Vector2 v, float angle)
    {
        angle = angle * 0.01745329f;
        return Vector2Extensions.RotateRad(v:  new UnityEngine.Vector2() {x = v.x, y = v.y}, angle:  angle);
    }
    public static UnityEngine.Vector2 RandomRotateRad(UnityEngine.Vector2 v, float randomAngle)
    {
        return Vector2Extensions.RotateRad(v:  new UnityEngine.Vector2() {x = v.x, y = v.y}, angle:  UnityEngine.Random.Range(min:  -randomAngle, max:  randomAngle));
    }
    public static UnityEngine.Vector2 RotateRad(UnityEngine.Vector2 v, float angle)
    {
        angle = v.y * angle;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  (v.x * angle) - angle, y:  (v.x * angle) + (v.y * angle));
        return new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }
    public static float ForwardToTargetPositionAngle(UnityEngine.Vector2 position, UnityEngine.Vector2 forward, UnityEngine.Vector2 targetPosition)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = targetPosition.x, y = targetPosition.y}, b:  new UnityEngine.Vector2() {x = position.x, y = position.y});
        return Vector2Extensions.TargetAngle(vector:  new UnityEngine.Vector2() {x = forward.x, y = forward.y}, targetVector:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
    }
    public static float TargetAngle(UnityEngine.Vector2 vector, UnityEngine.Vector2 targetVector)
    {
        UnityEngine.Vector2 val_1 = targetVector.x.normalized;
        float val_6 = val_1.x;
        UnityEngine.Vector2 val_2 = vector.x.normalized;
        val_2.x = val_6 * val_2.x;
        val_2.y = val_1.y * val_2.y;
        val_6 = val_2.x + val_2.y;
        float val_7 = (val_6 * val_2.y) - (val_1.y * val_2.x);
        val_7 = val_7 * 57.29578f;
        return (float)val_7;
    }
    public static float MagnitudeNotSqrt(UnityEngine.Vector2 v)
    {
        v.x = v.x * v.x;
        v.y = v.y * v.y;
        v.x = v.x + v.y;
        return (float)v.x;
    }
    public static bool NearCheck(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2, float max)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = v1.x, y = v1.y}, b:  new UnityEngine.Vector2() {x = v2.x, y = v2.y});
        val_1.x = val_1.x * val_1.x;
        val_1.y = val_1.y * val_1.y;
        val_1.x = val_1.x + val_1.y;
        return (bool)(val_1.x <= (max * max)) ? 1 : 0;
    }
    public static UnityEngine.Vector2 SetX(UnityEngine.Vector2 v, float f)
    {
        return new UnityEngine.Vector2() {x = f, y = v.y};
    }
    public static UnityEngine.Vector2 SetY(UnityEngine.Vector2 v, float f)
    {
        return new UnityEngine.Vector2() {x = v.x, y = f};
    }
    public static UnityEngine.Vector2 AddX(UnityEngine.Vector2 v, float f)
    {
        v.x = v.x + f;
        return new UnityEngine.Vector2() {x = v.x, y = v.y};
    }
    public static UnityEngine.Vector2 AddY(UnityEngine.Vector2 v, float f)
    {
        v.y = v.y + f;
        return new UnityEngine.Vector2() {x = v.x, y = v.y};
    }
    public static UnityEngine.Vector2 Add(UnityEngine.Vector2 v, float f)
    {
        v.x = v.x + f;
        v.y = v.y + f;
        return new UnityEngine.Vector2() {x = v.x, y = v.y};
    }
    public static UnityEngine.Vector2 Mul(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
    {
        return UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = v1.x, y = v1.y}, b:  new UnityEngine.Vector2() {x = v2.x, y = v2.y});
    }
    public static UnityEngine.Vector2 Div(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
    {
        v1.x = v1.x / v2.x;
        v1.y = v1.y / v2.y;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  v1.x, y:  v1.y);
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }

}
