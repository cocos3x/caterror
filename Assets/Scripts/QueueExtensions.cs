using UnityEngine;
public static class QueueExtensions
{
    // Methods
    public static void EnqueueEnd<T>(System.Collections.Generic.Queue<T> queue, T obj)
    {
        System.Collections.Generic.Queue<T> val_1 = queue;
        if(val_1 < 1)
        {
                return;
        }
        
        do
        {
            val_1 = val_1 - 1;
        }
        while(val_1 != null);
    
    }

}
