using UnityEngine;
public static class ArrayExtensions
{
    // Methods
    public static T RandomChoose<T>(T[] array)
    {
        int val_1 = UnityEngine.Random.Range(min:  0, max:  array.Length);
        return (int)array[((long)(int)(val_1)) << 2];
    }
    public static T RandomChoose<T>(T[] array, System.Random rand)
    {
        if(array == null)
        {
            goto label_0;
        }
        
        label_5:
        return (object)array[(long)rand];
        label_0:
        if(rand != null)
        {
            goto label_5;
        }
        
        goto label_5;
    }

}
