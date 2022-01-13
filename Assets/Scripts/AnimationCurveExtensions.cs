using UnityEngine;
public static class AnimationCurveExtensions
{
    // Fields
    public static UnityEngine.AnimationCurve Smooth01;
    public static UnityEngine.AnimationCurve Smooth10;
    
    // Methods
    private static AnimationCurveExtensions()
    {
        AnimationCurveExtensions.Smooth01 = UnityEngine.AnimationCurve.EaseInOut(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  1f);
        AnimationCurveExtensions.Smooth10 = UnityEngine.AnimationCurve.EaseInOut(timeStart:  0f, valueStart:  1f, timeEnd:  1f, valueEnd:  0f);
    }
    public static float GetMax(UnityEngine.AnimationCurve ac)
    {
        var val_2;
        float val_3;
        UnityEngine.Keyframe[] val_1 = ac.keys;
        val_2 = 0;
        val_3 = 0f;
        goto label_1;
        label_5:
        if(val_3 < 0)
        {
                val_3 = ;
        }
        
        val_2 = 1;
        label_1:
        if(val_2 < val_1.Length)
        {
            goto label_5;
        }
        
        return (float)val_3;
    }
    public static float GetMin(UnityEngine.AnimationCurve ac)
    {
        float val_2;
        var val_3;
        UnityEngine.Keyframe[] val_1 = ac.keys;
        val_2 = 3.402823E+38f;
        val_3 = 0;
        goto label_1;
        label_5:
        if(val_2 > )
        {
                val_2 = ;
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < val_1.Length)
        {
            goto label_5;
        }
        
        return (float)val_2;
    }

}
