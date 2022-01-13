using UnityEngine;
public static class BoolExtensions
{
    // Methods
    public static int ToInt(bool b)
    {
        return (int)b;
    }
    public static int ToIntPlusMinus(bool b)
    {
        return (int)((b & true) != 0) ? (-1) : 1;
    }

}
