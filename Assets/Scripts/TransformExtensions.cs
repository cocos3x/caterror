using UnityEngine;
public static class TransformExtensions
{
    // Methods
    public static float ForwardToTargetPositionXZAngle(UnityEngine.Transform transform, UnityEngine.Transform target)
    {
        UnityEngine.Vector3 val_1 = target.position;
        return TransformExtensions.ForwardToTargetPositionXZAngle(transform:  transform, targetPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public static float ForwardToTargetPositionXZAngle(UnityEngine.Transform transform, UnityEngine.Vector3 targetPosition)
    {
        UnityEngine.Vector3 val_1 = transform.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.z);
        UnityEngine.Vector2 val_4 = val_3.x.normalized;
        float val_11 = val_4.x;
        UnityEngine.Vector3 val_5 = transform.forward;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.z);
        UnityEngine.Vector2 val_7 = val_6.x.normalized;
        val_7.x = val_11 * val_7.x;
        val_7.y = val_4.y * val_7.y;
        val_11 = val_7.x + val_7.y;
        float val_12 = (val_11 * val_7.y) - (val_4.y * val_7.x);
        val_12 = val_12 * 57.29578f;
        return (float)val_12;
    }
    public static void SetPositionX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.position;
        t.position = new UnityEngine.Vector3() {x = f, y = val_1.y, z = val_1.z};
    }
    public static void SetPositionY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.position;
        t.position = new UnityEngine.Vector3() {x = val_1.x, y = f, z = val_1.z};
    }
    public static void SetPositionZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.position;
        t.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = f};
    }
    public static void AddPositionX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.position;
        val_1.x = val_1.x + f;
        TransformExtensions.SetPositionX(t:  t, f:  val_1.x);
    }
    public static void AddPositionY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.position;
        TransformExtensions.SetPositionY(t:  t, f:  val_1.y + f);
    }
    public static void AddPositionZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.position;
        TransformExtensions.SetPositionZ(t:  t, f:  val_1.z + f);
    }
    public static void SetLocalPositionX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localPosition;
        t.localPosition = new UnityEngine.Vector3() {x = f, y = val_1.y, z = val_1.z};
    }
    public static void SetLocalPositionY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localPosition;
        t.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = f, z = val_1.z};
    }
    public static void SetLocalPositionZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localPosition;
        t.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = f};
    }
    public static void AddLocalPositionX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localPosition;
        val_1.x = val_1.x + f;
        TransformExtensions.SetLocalPositionX(t:  t, f:  val_1.x);
    }
    public static void AddLocalPositionY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localPosition;
        TransformExtensions.SetLocalPositionY(t:  t, f:  val_1.y + f);
    }
    public static void AddLocalPositionZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localPosition;
        TransformExtensions.SetLocalPositionZ(t:  t, f:  val_1.z + f);
    }
    public static void SetEulerAnglesX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.eulerAngles;
        t.eulerAngles = new UnityEngine.Vector3() {x = f, y = val_1.y, z = val_1.z};
    }
    public static void SetEulerAnglesY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.eulerAngles;
        t.eulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = f, z = val_1.z};
    }
    public static void SetEulerAnglesZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.eulerAngles;
        t.eulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = f};
    }
    public static void AddEulerAnglesX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.eulerAngles;
        val_1.x = val_1.x + f;
        TransformExtensions.SetEulerAnglesX(t:  t, f:  val_1.x);
    }
    public static void AddEulerAnglesY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.eulerAngles;
        TransformExtensions.SetEulerAnglesY(t:  t, f:  val_1.y + f);
    }
    public static void AddEulerAnglesZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.eulerAngles;
        TransformExtensions.SetEulerAnglesZ(t:  t, f:  val_1.z + f);
    }
    public static void SetLocalEulerAnglesX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localEulerAngles;
        t.localEulerAngles = new UnityEngine.Vector3() {x = f, y = val_1.y, z = val_1.z};
    }
    public static void SetLocalEulerAnglesY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localEulerAngles;
        t.localEulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = f, z = val_1.z};
    }
    public static void SetLocalEulerAnglesZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localEulerAngles;
        t.localEulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = f};
    }
    public static void AddLocalEulerAnglesX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localEulerAngles;
        val_1.x = val_1.x + f;
        TransformExtensions.SetLocalEulerAnglesX(t:  t, f:  val_1.x);
    }
    public static void AddLocalEulerAnglesY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localEulerAngles;
        TransformExtensions.SetLocalEulerAnglesY(t:  t, f:  val_1.y + f);
    }
    public static void AddLocalEulerAnglesZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localEulerAngles;
        TransformExtensions.SetLocalEulerAnglesZ(t:  t, f:  val_1.z + f);
    }
    public static void SetLocalScaleX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localScale;
        t.localScale = new UnityEngine.Vector3() {x = f, y = val_1.y, z = val_1.z};
    }
    public static void SetLocalScaleY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localScale;
        t.localScale = new UnityEngine.Vector3() {x = val_1.x, y = f, z = val_1.z};
    }
    public static void SetLocalScaleZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localScale;
        t.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = f};
    }
    public static void MulLocalScaleX(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localScale;
        UnityEngine.Vector3 val_2 = Vector3Extensions.MulX(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, f:  f);
        t.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public static void MulLocalScaleY(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localScale;
        UnityEngine.Vector3 val_2 = Vector3Extensions.MulY(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, f:  f);
        t.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public static void MulLocalScaleZ(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localScale;
        UnityEngine.Vector3 val_2 = Vector3Extensions.MulZ(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, f:  f);
        t.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public static void AddLocalScale(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = t.localScale;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        t.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public static void SetLocalScale(UnityEngine.Transform t, float f)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  f);
        t.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public static bool NearCheckX(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.position;
        UnityEngine.Vector3 val_2 = t2.position;
        val_2.x = val_1.x - val_2.x;
        val_2.x = val_2.x * val_2.x;
        return (bool)(val_2.x <= (max * max)) ? 1 : 0;
    }
    public static bool NearCheckY(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.position;
        UnityEngine.Vector3 val_2 = t2.position;
        float val_3 = val_1.y - val_2.y;
        val_3 = val_3 * val_3;
        return (bool)(val_3 <= (max * max)) ? 1 : 0;
    }
    public static bool NearCheckZ(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.position;
        UnityEngine.Vector3 val_2 = t2.position;
        float val_3 = val_1.z - val_2.z;
        val_3 = val_3 * val_3;
        return (bool)(val_3 <= (max * max)) ? 1 : 0;
    }
    public static bool NearCheck(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.position;
        UnityEngine.Vector3 val_2 = t2.position;
        return Vector3Extensions.NearCheck(v1:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v2:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, max:  max);
    }
    public static bool NearCheck(UnityEngine.Transform t, UnityEngine.Vector3 p, float max)
    {
        UnityEngine.Vector3 val_1 = t.position;
        return Vector3Extensions.NearCheck(v1:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v2:  new UnityEngine.Vector3() {x = p.x, y = p.y, z = p.z}, max:  max);
    }
    public static bool LocalNearCheckX(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.localPosition;
        UnityEngine.Vector3 val_2 = t2.localPosition;
        val_2.x = val_1.x - val_2.x;
        val_2.x = val_2.x * val_2.x;
        return (bool)(val_2.x <= (max * max)) ? 1 : 0;
    }
    public static bool LocalNearCheckY(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.localPosition;
        UnityEngine.Vector3 val_2 = t2.localPosition;
        float val_3 = val_1.y - val_2.y;
        val_3 = val_3 * val_3;
        return (bool)(val_3 <= (max * max)) ? 1 : 0;
    }
    public static bool LocalNearCheckZ(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.localPosition;
        UnityEngine.Vector3 val_2 = t2.localPosition;
        float val_3 = val_1.z - val_2.z;
        val_3 = val_3 * val_3;
        return (bool)(val_3 <= (max * max)) ? 1 : 0;
    }
    public static bool LocalNearCheck(UnityEngine.Transform t1, UnityEngine.Transform t2, float max)
    {
        UnityEngine.Vector3 val_1 = t1.localPosition;
        UnityEngine.Vector3 val_2 = t2.localPosition;
        return Vector3Extensions.NearCheck(v1:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v2:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, max:  max);
    }
    public static bool LocalNearCheck(UnityEngine.Transform t, UnityEngine.Vector3 p, float max)
    {
        UnityEngine.Vector3 val_1 = t.localPosition;
        return Vector3Extensions.NearCheck(v1:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, v2:  new UnityEngine.Vector3() {x = p.x, y = p.y, z = p.z}, max:  max);
    }
    public static void AddChild(UnityEngine.Transform t, UnityEngine.Transform child)
    {
        child.SetParent(p:  t);
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        child.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        child.localEulerAngles = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        child.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static void SetParentKeepState(UnityEngine.Transform t, UnityEngine.Transform parent)
    {
        TransformExtensions.AddChildKeepState(t:  parent, child:  t);
    }
    public static void AddChildKeepState(UnityEngine.Transform t, UnityEngine.Transform child)
    {
        UnityEngine.Vector3 val_1 = child.position;
        UnityEngine.Vector3 val_2 = child.eulerAngles;
        UnityEngine.Vector3 val_3 = child.localScale;
        if(child != null)
        {
                child.SetParent(p:  t);
        }
        else
        {
                0.SetParent(p:  t);
        }
        
        child.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        if(child != null)
        {
                child.eulerAngles = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        else
        {
                0.eulerAngles = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        
        child.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static bool FindParentsComponent<T>(UnityEngine.Transform t, System.Action<T> func)
    {
        var val_5;
        if(t.parent == 0)
        {
            goto label_4;
        }
        
        if(t.parent == null)
        {
            goto label_7;
        }
        
        val_5 = 1;
        return (bool)val_5;
        label_4:
        val_5 = 0;
        return (bool)val_5;
        label_7:
        UnityEngine.Transform val_4 = t.parent;
        goto __RuntimeMethodHiddenParam + 48 + 24;
    }
    public static bool FindParentByName(UnityEngine.Transform t, string name, System.Action<UnityEngine.Transform> func)
    {
        var val_5;
        label_6:
        UnityEngine.Transform val_1 = t.parent;
        if(val_1 == 0)
        {
            goto label_4;
        }
        
        if((System.String.op_Equality(a:  val_1.name, b:  name)) == false)
        {
            goto label_6;
        }
        
        func.Invoke(obj:  val_1);
        val_5 = 1;
        return (bool)val_5;
        label_4:
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool FindParentByContainsName(UnityEngine.Transform t, string name, System.Action<UnityEngine.Transform> func)
    {
        var val_5;
        label_7:
        UnityEngine.Transform val_1 = t.parent;
        if(val_1 == 0)
        {
            goto label_4;
        }
        
        if((val_1.name.Contains(value:  name)) == false)
        {
            goto label_7;
        }
        
        func.Invoke(obj:  val_1);
        val_5 = 1;
        return (bool)val_5;
        label_4:
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool FindComponent<T>(UnityEngine.Transform t, System.Action<T> func)
    {
        var val_2;
        if(t == null)
        {
            goto label_2;
        }
        
        if(t != 0)
        {
            goto label_5;
        }
        
        label_7:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        if(t == null)
        {
            goto label_7;
        }
        
        label_5:
        val_2 = 1;
        return (bool)val_2;
    }
    public static bool FindComponents<T>(UnityEngine.Transform t, System.Action<T> func)
    {
        var val_2;
        var val_3;
        val_2 = 0;
        val_3 = 0;
        goto label_2;
        label_12:
        if(UnityEngine.Transform.__il2cppRuntimeField_byval_arg != 0)
        {
                val_3 = 1;
        }
        
        val_2 = 1;
        label_2:
        if(val_2 < null)
        {
            goto label_12;
        }
        
        return (bool)val_3 & 1;
    }
    public static bool FindChildComponent<T>(UnityEngine.Transform t, System.Action<T> func)
    {
        var val_3;
        var val_3 = 0;
        label_3:
        if(val_3 >= t.childCount)
        {
            goto label_1;
        }
        
        val_3 = val_3 + 1;
        if(((t.GetChild(index:  0)) & 1) == 0)
        {
            goto label_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
    }
    public static bool FindAllChildComponent<T>(UnityEngine.Transform t, System.Action<T> func)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        val_5 = 0;
        goto label_0;
        label_3:
        val_5 = val_5 | (t.GetChild(index:  0));
        val_4 = 1;
        label_0:
        if(val_4 < t.childCount)
        {
            goto label_3;
        }
        
        return (bool)val_5 & 1;
    }
    public static bool FindChildrensComponent<T>(UnityEngine.Transform t, System.Action<T> func)
    {
        var val_5;
        var val_5 = 0;
        label_3:
        if(val_5 >= t.childCount)
        {
            goto label_1;
        }
        
        val_5 = val_5 + 1;
        if(((t.GetChild(index:  0)) & 1) == 0)
        {
            goto label_3;
        }
        
        goto label_4;
        label_1:
        var val_6 = 0;
        label_8:
        if(val_6 >= t.childCount)
        {
            goto label_6;
        }
        
        val_6 = val_6 + 1;
        if(((t.GetChild(index:  0)) & 1) == 0)
        {
            goto label_8;
        }
        
        label_4:
        val_5 = 1;
        return (bool)val_5;
        label_6:
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool FindAllChildrensComponent<T>(UnityEngine.Transform t, System.Action<T> func)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        val_5 = 0;
        goto label_0;
        label_3:
        UnityEngine.Transform val_1 = t.GetChild(index:  0);
        val_5 = val_5 | val_1;
        val_5 = val_5 | val_1;
        val_4 = 1;
        label_0:
        if(val_4 < t.childCount)
        {
            goto label_3;
        }
        
        return (bool)val_5 & 1;
    }
    public static bool FindChildByName(UnityEngine.Transform t, string name, System.Action<UnityEngine.Transform> func)
    {
        var val_5;
        var val_5 = 0;
        label_5:
        if(val_5 >= t.childCount)
        {
            goto label_2;
        }
        
        UnityEngine.Transform val_2 = t.GetChild(index:  0);
        val_5 = val_5 + 1;
        if((System.String.op_Equality(a:  val_2.name, b:  name)) == false)
        {
            goto label_5;
        }
        
        func.Invoke(obj:  val_2);
        val_5 = 1;
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool FindChildrensByName(UnityEngine.Transform t, string name, System.Action<UnityEngine.Transform> func)
    {
        var val_7;
        var val_7 = 0;
        label_5:
        if(val_7 >= t.childCount)
        {
            goto label_2;
        }
        
        UnityEngine.Transform val_2 = t.GetChild(index:  0);
        val_7 = val_7 + 1;
        if((System.String.op_Equality(a:  val_2.name, b:  name)) == false)
        {
            goto label_5;
        }
        
        func.Invoke(obj:  val_2);
        goto label_7;
        label_2:
        var val_8 = 0;
        label_12:
        if(val_8 >= t.childCount)
        {
            goto label_9;
        }
        
        val_8 = val_8 + 1;
        if(((t.GetChild(index:  0)) & 1) == 0)
        {
            goto label_12;
        }
        
        label_7:
        val_7 = 1;
        return (bool)val_7;
        label_9:
        val_7 = 0;
        return (bool)val_7;
    }
    public static void AllChildrens(UnityEngine.Transform t, System.Action<UnityEngine.Transform> func)
    {
        goto label_1;
        label_6:
        func.Invoke(obj:  t.GetChild(index:  0));
        0 = 1;
        label_1:
        if(0 < t.childCount)
        {
            goto label_6;
        }
    
    }
    public static void DestroyAllChildrens(UnityEngine.Transform t)
    {
        goto label_1;
        label_7:
        UnityEngine.Object.DestroyImmediate(obj:  t.GetChild(index:  0).gameObject);
        label_1:
        if(t.childCount > 0)
        {
            goto label_7;
        }
    
    }
    public static void SetLayer(UnityEngine.Transform t, string layerName)
    {
        TransformExtensions.SetLayer(t:  t, layer:  UnityEngine.LayerMask.NameToLayer(layerName:  layerName));
    }
    public static void SetLayer(UnityEngine.Transform t, int layer)
    {
        .layer = layer;
        t.gameObject.layer = (TransformExtensions.<>c__DisplayClass61_0)[1152921512027700896].layer;
        TransformExtensions.AllChildrens(t:  t, func:  new System.Action<UnityEngine.Transform>(object:  new TransformExtensions.<>c__DisplayClass61_0(), method:  System.Void TransformExtensions.<>c__DisplayClass61_0::<SetLayer>b__0(UnityEngine.Transform c)));
    }
    public static UnityEngine.Bounds TransformBounds(UnityEngine.Transform t, UnityEngine.Bounds bounds)
    {
        UnityEngine.Bounds val_0;
        UnityEngine.Vector3 val_1 = t.TransformPoint(position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        UnityEngine.Vector3 val_2 = t.TransformPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  2f);
        val_0.m_Extents.y = 0f;
        val_0.m_Extents.z = 0f;
        val_0.m_Center.x = 0f;
        val_0.m_Center.y = 0f;
        val_0.m_Center.z = 0f;
        val_0.m_Extents.x = 0f;
        return val_0;
    }
    public static UnityEngine.Bounds InverseTransformBounds(UnityEngine.Transform t, UnityEngine.Bounds bounds)
    {
        UnityEngine.Bounds val_0;
        UnityEngine.Vector3 val_1 = t.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        UnityEngine.Vector3 val_2 = t.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  2f);
        val_0.m_Extents.y = 0f;
        val_0.m_Extents.z = 0f;
        val_0.m_Center.x = 0f;
        val_0.m_Center.y = 0f;
        val_0.m_Center.z = 0f;
        val_0.m_Extents.x = 0f;
        return val_0;
    }
    public static string GetPath(UnityEngine.Transform t)
    {
        string val_7 = t.gameObject.name;
        if(t != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_9:
        val_7 = t.name + "/"("/") + val_7;
        label_6:
        if(t.parent != 0)
        {
            goto label_9;
        }
        
        return (string)val_7;
    }

}
