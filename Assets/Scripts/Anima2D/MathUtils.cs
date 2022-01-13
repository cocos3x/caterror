using UnityEngine;

namespace Anima2D
{
    public static class MathUtils
    {
        // Methods
        public static float SignedAngle(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 forward)
        {
            float val_1;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, rhs:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z});
            float val_5 = UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = forward.x, y = val_1, z = forward.y}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}));
            val_5 = (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, to:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z})) * val_5;
            return (float)val_5;
        }
        public static float Fmod(float value, float mod)
        {
            float val_1 = value;
            val_1 = val_1 + mod;
            float val_2 = System.Math.Abs(val_1);
        }
        public static float SegmentDistance(UnityEngine.Vector3 point, UnityEngine.Vector3 a, UnityEngine.Vector3 b)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = b.x, y = val_1, z = b.y}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            float val_6 = UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, rhs:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            if(val_6 <= 0f)
            {
                    return (float)val_9.x;
            }
            
            if(val_6 < val_3.x.sqrMagnitude)
            {
                    float val_8 = Anima2D.MathUtils.LineDistance(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = b.x, y = b.y});
                return (float)val_9.x;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = b.x, y = val_1, z = b.y});
            return (float)val_9.x;
        }
        public static float SegmentSqrtDistance(UnityEngine.Vector3 point, UnityEngine.Vector3 a, UnityEngine.Vector3 b)
        {
            float val_1;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = b.x, y = val_1, z = b.y}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            float val_6 = UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, rhs:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            if(val_6 <= 0f)
            {
                goto label_5;
            }
            
            if(val_6 >= val_3.x.sqrMagnitude)
            {
                goto label_6;
            }
            
            float val_8 = Anima2D.MathUtils.SqrtLineDistance(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = b.x, y = b.y});
            return (float)val_10.x;
            label_5:
            float val_9 = val_5.x.sqrMagnitude;
            return (float)val_10.x;
            label_6:
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = b.x, y = val_1, z = b.y});
            return (float)val_10.x;
        }
        public static float LineDistance(UnityEngine.Vector3 point, UnityEngine.Vector3 a, UnityEngine.Vector3 b)
        {
            float val_2 = Anima2D.MathUtils.SqrtLineDistance(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = ???});
            if(val_2 <= _TYPE_MAX_)
            {
                    return val_2;
            }
        
        }
        public static float SqrtLineDistance(UnityEngine.Vector3 point, UnityEngine.Vector3 a, UnityEngine.Vector3 b)
        {
            float val_1;
            float val_2 = val_1 - a.y;
            float val_3 = b.x - a.x;
            a.y = point.x * val_2;
            float val_5 = a.y * b.x;
            a.y = a.y - (point.y * val_3);
            a.x = a.x * val_1;
            val_5 = val_5 + a.y;
            val_2 = val_2 * val_2;
            val_3 = val_3 * val_3;
            val_5 = val_5 - a.x;
            val_5 = val_5 * val_5;
            val_2 = val_2 + val_3;
            val_2 = val_5 / val_2;
            return (float)val_2;
        }
        public static void WorldFromMatrix4x4(UnityEngine.Transform transform, UnityEngine.Matrix4x4 matrix)
        {
            UnityEngine.Vector3 val_1 = Anima2D.MathUtils.GetScale(m:  new UnityEngine.Matrix4x4() {m00 = matrix.m00, m01 = matrix.m01, m02 = matrix.m02, m03 = matrix.m03});
            transform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Quaternion val_2 = Anima2D.MathUtils.GetRotation(matrix:  new UnityEngine.Matrix4x4() {m00 = matrix.m00, m01 = matrix.m01, m02 = matrix.m02, m03 = matrix.m03});
            transform.rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static void LocalFromMatrix4x4(UnityEngine.Transform transform, UnityEngine.Matrix4x4 matrix)
        {
            UnityEngine.Vector3 val_1 = Anima2D.MathUtils.GetScale(m:  new UnityEngine.Matrix4x4() {m00 = matrix.m00, m01 = matrix.m01, m02 = matrix.m02, m03 = matrix.m03});
            transform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Quaternion val_2 = Anima2D.MathUtils.GetRotation(matrix:  new UnityEngine.Matrix4x4() {m00 = matrix.m00, m01 = matrix.m01, m02 = matrix.m02, m03 = matrix.m03});
            transform.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static UnityEngine.Quaternion GetRotation(UnityEngine.Matrix4x4 matrix)
        {
            float val_6;
            float val_6 = 1f;
            val_6 = matrix.m00 + val_6;
            val_6 = val_6 + matrix.m11;
            if(val_6 >= _TYPE_MAX_)
            {
                    val_6 = val_6 + matrix.m22;
            }
            
            float val_7 = matrix.m12;
            float val_3 = matrix.m02 - matrix.m20;
            float val_4 = (val_6 * 0.5f) * 4f;
            val_7 = matrix.m21 - val_7;
            float val_5 = matrix.m10 - matrix.m01;
            val_3 = val_3 / val_4;
            val_5 = val_5 / val_4;
            val_7 = val_7 / val_4;
            return new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        public static UnityEngine.Vector3 GetPosition(UnityEngine.Matrix4x4 matrix)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static UnityEngine.Vector3 GetScale(UnityEngine.Matrix4x4 m)
        {
            var val_6;
            var val_7;
            float val_1 = m.m00 * m.m00;
            val_1 = val_1 + (m.m01 * m.m01);
            val_1 = val_1 + (m.m02 * m.m02);
            if(m.m02 >= _TYPE_MAX_)
            {
                    val_6 = val_1;
            }
            
            float val_6 = m.m10;
            float val_7 = m.m11;
            val_6 = val_6 * val_6;
            val_7 = val_7 * val_7;
            val_6 = val_6 + val_7;
            val_6 = val_6 + (m.m12 * m.m12);
            if(m.m01 >= _TYPE_MAX_)
            {
                    val_7 = val_6;
            }
            
            float val_8 = m.m20;
            float val_9 = m.m21;
            val_8 = val_8 * val_8;
            val_9 = val_9 * val_9;
            val_8 = val_8 + val_9;
            val_8 = val_8 + (m.m22 * m.m22);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static UnityEngine.Rect ClampRect(UnityEngine.Rect rect, UnityEngine.Rect frame)
        {
            float val_1 = rect.m_XMin.System.IConvertible.ToSingle(provider:  0);
            float val_2 = val_1 + (-1f);
            float val_3 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  val_2);
            val_2 = val_3 + (-1f);
            float val_4 = UnityEngine.Mathf.Clamp(value:  val_3, min:  0f, max:  val_2);
            float val_5 = UnityEngine.Mathf.Clamp(value:  val_4, min:  1f, max:  val_4);
            float val_6 = UnityEngine.Mathf.Clamp(value:  val_5, min:  1f, max:  val_5);
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        public static UnityEngine.Vector2 ClampPositionInRect(UnityEngine.Vector2 position, UnityEngine.Rect frame)
        {
            float val_1 = frame.m_XMin.System.IConvertible.ToSingle(provider:  0);
            float val_2 = UnityEngine.Mathf.Clamp(value:  position.x, min:  val_1, max:  val_1);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2, y:  UnityEngine.Mathf.Clamp(value:  position.y, min:  val_2, max:  val_2));
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public static UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect)
        {
            if((rect.m_XMin.System.IConvertible.ToSingle(provider:  0)) > (rect.m_XMin.System.IConvertible.ToSingle(provider:  0)))
            {
                
            }
            
            if((rect.m_XMin.System.IConvertible.ToSingle(provider:  0)) <= (rect.m_XMin.System.IConvertible.ToSingle(provider:  0)))
            {
                    return new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height};
            }
            
            return new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height};
        }
        public static float RoundToMultipleOf(float value, float roundingValue)
        {
            var val_1;
            float val_2;
            var val_3;
            float val_4;
            val_2 = value;
            if(roundingValue == 0f)
            {
                    return (float)val_2;
            }
            
            val_2 = val_2 / roundingValue;
            if(val_2 >= 0f)
            {
                goto label_4;
            }
            
            if((double)val_2 != (-0.5))
            {
                goto label_5;
            }
            
            val_3 = val_1;
            val_4 = -1f;
            goto label_6;
            label_4:
            if((double)val_2 != 0.5)
            {
                goto label_7;
            }
            
            val_3 = val_1;
            val_4 = 1f;
            label_6:
            float val_2 = (float)val_3;
            val_4 = val_2 + val_4;
            val_2 = (((long)val_3 & 1) != 0) ? (val_2) : (val_4);
            goto label_9;
            label_5:
            float val_3 = -0.5f;
            val_3 = val_2 + val_3;
            goto label_9;
            label_7:
            float val_4 = 0.5f;
            val_4 = val_2 + val_4;
            label_9:
            val_2 = val_4 * roundingValue;
            return (float)val_2;
        }
        public static float GetClosestPowerOfTen(float positiveNumber)
        {
            if(positiveNumber <= 0f)
            {
                    return 1f;
            }
            
            int val_1 = UnityEngine.Mathf.RoundToInt(f:  positiveNumber);
            return 1f;
        }
        public static float RoundBasedOnMinimumDifference(float valueToRound, float minDifference)
        {
            if(minDifference != 0f)
            {
                    return (float)(float)System.Math.Round(value:  (double)valueToRound, digits:  Anima2D.MathUtils.GetNumberOfDecimalsForMinimumDifference(minDifference:  minDifference), mode:  1);
            }
            
            return Anima2D.MathUtils.DiscardLeastSignificantDecimal(v:  valueToRound);
        }
        public static float DiscardLeastSignificantDecimal(float v)
        {
            float val_3 = System.Math.Abs(v);
            val_3 = 5f - val_3;
            return (float)(float)System.Math.Round(value:  (double)v, digits:  UnityEngine.Mathf.Clamp(value:  (int)val_3, min:  0, max:  15), mode:  1);
        }
        public static int GetNumberOfDecimalsForMinimumDifference(float minDifference)
        {
            return UnityEngine.Mathf.Clamp(value:  -(UnityEngine.Mathf.FloorToInt(f:  minDifference)), min:  0, max:  15);
        }
        public static UnityEngine.Vector3 Unskin(UnityEngine.Vector3 skinedPosition, UnityEngine.Matrix4x4 localToWorld, UnityEngine.BoneWeight boneWeight, UnityEngine.Matrix4x4[] bindposes, UnityEngine.Transform[] bones)
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_51;
            UnityEngine.Matrix4x4 val_2 = bones[(long)boneWeight.m_Weight0.glyphIndex].localToWorldMatrix;
            UnityEngine.Matrix4x4 val_8 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_7, m10 = val_7, m20 = val_7, m30 = val_7, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_5, m12 = val_5, m22 = val_5, m32 = val_5, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4}, rhs:  new UnityEngine.Matrix4x4() {m00 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m10 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m20 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m30 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m01 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m11 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m21 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m31 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m02 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m12 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m22 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m32 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m03 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m13 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m23 = bindposes[(long)boneWeight.m_Weight0.glyphIndex], m33 = bindposes[(long)boneWeight.m_Weight0.glyphIndex]});
            UnityEngine.Matrix4x4 val_14 = bones[(long)boneWeight.m_Weight0.NewIndex].localToWorldMatrix;
            UnityEngine.Matrix4x4 val_20 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_18, m10 = val_18, m20 = val_18, m30 = val_18, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_16, m12 = val_16, m22 = val_16, m32 = val_16, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17}, rhs:  new UnityEngine.Matrix4x4() {m00 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m10 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m20 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m30 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m01 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m11 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m21 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m31 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m02 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m12 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m22 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m32 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m03 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m13 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m23 = bindposes[(long)boneWeight.m_Weight0.NewIndex], m33 = bindposes[(long)boneWeight.m_Weight0.NewIndex]});
            UnityEngine.Matrix4x4 val_26 = bones[(long)boneWeight.m_Weight0.LogType].localToWorldMatrix;
            UnityEngine.Matrix4x4 val_32 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_30, m10 = val_30, m20 = val_30, m30 = val_30, m01 = val_31, m11 = val_31, m21 = val_31, m31 = val_31, m02 = val_28, m12 = val_28, m22 = val_28, m32 = val_28, m03 = val_29, m13 = val_29, m23 = val_29, m33 = val_29}, rhs:  new UnityEngine.Matrix4x4() {m00 = bindposes[(long)boneWeight.m_Weight0.LogType], m10 = bindposes[(long)boneWeight.m_Weight0.LogType], m20 = bindposes[(long)boneWeight.m_Weight0.LogType], m30 = bindposes[(long)boneWeight.m_Weight0.LogType], m01 = bindposes[(long)boneWeight.m_Weight0.LogType], m11 = bindposes[(long)boneWeight.m_Weight0.LogType], m21 = bindposes[(long)boneWeight.m_Weight0.LogType], m31 = bindposes[(long)boneWeight.m_Weight0.LogType], m02 = bindposes[(long)boneWeight.m_Weight0.LogType], m12 = bindposes[(long)boneWeight.m_Weight0.LogType], m22 = bindposes[(long)boneWeight.m_Weight0.LogType], m32 = bindposes[(long)boneWeight.m_Weight0.LogType], m03 = bindposes[(long)boneWeight.m_Weight0.LogType], m13 = bindposes[(long)boneWeight.m_Weight0.LogType], m23 = bindposes[(long)boneWeight.m_Weight0.LogType], m33 = bindposes[(long)boneWeight.m_Weight0.LogType]});
            UnityEngine.Matrix4x4 val_38 = bones[(long)boneWeight.m_Weight0.Length].localToWorldMatrix;
            UnityEngine.Matrix4x4 val_44 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_42, m10 = val_42, m20 = val_42, m30 = val_42, m01 = val_43, m11 = val_43, m21 = val_43, m31 = val_43, m02 = val_40, m12 = val_40, m22 = val_40, m32 = val_40, m03 = val_41, m13 = val_41, m23 = val_41, m33 = val_41}, rhs:  new UnityEngine.Matrix4x4() {m00 = bindposes[(long)boneWeight.m_Weight0.Length], m10 = bindposes[(long)boneWeight.m_Weight0.Length], m20 = bindposes[(long)boneWeight.m_Weight0.Length], m30 = bindposes[(long)boneWeight.m_Weight0.Length], m01 = bindposes[(long)boneWeight.m_Weight0.Length], m11 = bindposes[(long)boneWeight.m_Weight0.Length], m21 = bindposes[(long)boneWeight.m_Weight0.Length], m31 = bindposes[(long)boneWeight.m_Weight0.Length], m02 = bindposes[(long)boneWeight.m_Weight0.Length], m12 = bindposes[(long)boneWeight.m_Weight0.Length], m22 = bindposes[(long)boneWeight.m_Weight0.Length], m32 = bindposes[(long)boneWeight.m_Weight0.Length], m03 = bindposes[(long)boneWeight.m_Weight0.Length], m13 = bindposes[(long)boneWeight.m_Weight0.Length], m23 = bindposes[(long)boneWeight.m_Weight0.Length], m33 = bindposes[(long)boneWeight.m_Weight0.Length]});
            UnityEngine.Matrix4x4 val_49 = UnityEngine.Matrix4x4.identity;
            var val_76 = 0;
            do
            {
                float val_54 = boneWeight.m_Weight0.System.IConvertible.ToSingle(provider:  0);
                val_54 = val_51 * val_54;
                val_54 = val_54 * val_54;
                val_54 = val_54 * val_54;
                val_54 = val_54 * val_54;
                float val_55 = val_54 + val_54;
                val_55 = val_55 + val_54;
                val_54 = val_55 + val_54;
                val_76 = val_76 + 1;
            }
            while(val_76 != 16);
            
            return new UnityEngine.Vector3() {x = skinedPosition.x, y = skinedPosition.y, z = skinedPosition.z};
        }
    
    }

}
