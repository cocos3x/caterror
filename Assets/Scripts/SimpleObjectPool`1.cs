using UnityEngine;
public class SimpleObjectPool<T> : ObjectPool<T>
{
    // Fields
    private readonly T prefab;
    private readonly UnityEngine.Transform parentTransform;
    
    // Methods
    public SimpleObjectPool<T>(T prefab, UnityEngine.Transform parentTransform)
    {
        mem[1152921512121016224] = prefab;
        mem[1152921512121016232] = parentTransform;
    }
    protected override T CreateInstance()
    {
        goto __RuntimeMethodHiddenParam + 24 + 192 + 16;
    }

}
