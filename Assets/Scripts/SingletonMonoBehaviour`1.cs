using UnityEngine;
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour
{
    // Fields
    private static T instance;
    
    // Properties
    public static T Instance { get; }
    public static bool ExistsInstance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_4;
        var val_5;
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_4 = __RuntimeMethodHiddenParam + 24 + 294;
        val_5 = __RuntimeMethodHiddenParam + 24;
        if((val_4 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24];
            val_5 = __RuntimeMethodHiddenParam + 24;
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_4 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) == 0)
        {
                UnityEngine.Debug.LogError(message:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24})) + " is nothing.");
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294) & 1) != 0)
        {
                return (AdManager)__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
        }
        
        return (AdManager)__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
    }
    public virtual void OnDestroy()
    {
        var val_2 = __RuntimeMethodHiddenParam;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) != this)
        {
                return;
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        mem2[0] = 0;
    }
    protected bool CheckInstance()
    {
        var val_2;
        if(this != (__RuntimeMethodHiddenParam + 24 + 192 + 32))
        {
                UnityEngine.Object.Destroy(obj:  this);
            val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    private static void FindInstance()
    {
        var val_5;
        var val_6;
        val_5 = __RuntimeMethodHiddenParam;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) != 0)
        {
                return;
        }
        
        UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24}));
        val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16];
        val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        if(val_3 == null)
        {
            goto label_15;
        }
        
        val_6 = val_3;
        if(val_6 != null)
        {
            goto label_16;
        }
        
        label_15:
        val_6 = 0;
        label_16:
        mem2[0] = val_6;
    }
    public static bool get_ExistsInstance()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        val_2 = __RuntimeMethodHiddenParam + 24;
        if((val_1 & 1) != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184, y:  0);
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24];
        val_2 = __RuntimeMethodHiddenParam + 24;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184, y:  0);
    }
    protected SingletonMonoBehaviour<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }

}
