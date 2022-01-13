using UnityEngine;

namespace Joypac
{
    public class JoypacSingleMonoBehaviour<T> : MonoBehaviour
    {
        // Fields
        private static T instance;
        
        // Properties
        public static T Instance { get; }
        
        // Methods
        public static T get_Instance()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 294;
            val_2 = __RuntimeMethodHiddenParam + 24;
            if((val_1 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24];
                val_2 = __RuntimeMethodHiddenParam + 24;
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192;
            if((val_1 & 1) == 0)
            {
                    val_3 = val_3;
            }
        
        }
        public static T GetInstance()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if(0 != (__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184))
            {
                goto label_21;
            }
            
            val_10 = 1152921504624365568;
            UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24}));
            val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            if(val_3 == null)
            {
                goto label_17;
            }
            
            val_12 = val_3;
            if(val_12 != null)
            {
                goto label_18;
            }
            
            label_17:
            val_12 = 0;
            label_18:
            mem2[0] = val_12;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) != 0)
            {
                goto label_21;
            }
            
            UnityEngine.GameObject val_6 = new UnityEngine.GameObject();
            val_6.name = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24});
            val_10 = mem[__RuntimeMethodHiddenParam + 24];
            val_10 = __RuntimeMethodHiddenParam + 24;
            val_11 = val_6.AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24}));
            if(val_11 == null)
            {
                goto label_35;
            }
            
            val_13 = val_11;
            if(val_13 != null)
            {
                goto label_36;
            }
            
            label_35:
            val_13 = 0;
            label_36:
            mem2[0] = val_13;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_6);
            label_21:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294) & 1) != 0)
            {
                    return (object)__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
            }
            
            return (object)__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
        }
        public JoypacSingleMonoBehaviour<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
