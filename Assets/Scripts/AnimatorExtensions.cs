using UnityEngine;
public static class AnimatorExtensions
{
    // Methods
    public static bool FindBehaviour<T>(UnityEngine.Animator t, System.Action<T> func)
    {
        var val_2;
        if(t != 0)
        {
                val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }

}
