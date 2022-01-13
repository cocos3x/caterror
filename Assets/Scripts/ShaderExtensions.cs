using UnityEngine;
public static class ShaderExtensions
{
    // Methods
    public static UnityEngine.Material CreateHiddenMaterial(UnityEngine.Shader shader)
    {
        UnityEngine.Material val_1 = new UnityEngine.Material(shader:  shader);
        val_1.hideFlags = 61;
        return val_1;
    }

}
