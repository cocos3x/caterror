using UnityEngine;
public static class NativeUtils
{
    // Fields
    public static readonly string vEffectOneShot;
    public static readonly string vEffectClick;
    public static readonly string vEffectDClick;
    public static readonly string vEffectHClick;
    public static readonly string vEffectTick;
    
    // Methods
    private static void _Vibration()
    {
        UnityEngine.Handheld.Vibrate();
    }
    private static void _VibrationAndroid(string effectType, long msec = 100)
    {
        var val_21;
        var val_22;
        UnityEngine.AndroidJavaClass val_23;
        var val_24;
        var val_25;
        object val_26;
        var val_27;
        var val_28;
        var val_30;
        var val_32;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        object[] val_3 = new object[1];
        val_3[0] = "vibrator";
        UnityEngine.AndroidJavaObject val_4 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_3);
        val_21 = null;
        if(NativeUtils.androidOSVersion() >= 26)
        {
            goto label_9;
        }
        
        val_22 = 0;
        goto label_45;
        label_9:
        val_23 = new UnityEngine.AndroidJavaClass();
        val_23 = new UnityEngine.AndroidJavaClass(className:  "android.os.VibrationEffect");
        val_24 = null;
        val_24 = null;
        if((System.String.op_Inequality(a:  effectType, b:  NativeUtils.vEffectOneShot)) == false)
        {
            goto label_13;
        }
        
        val_25 = null;
        if(NativeUtils.androidOSVersion() >= 29)
        {
            goto label_16;
        }
        
        label_13:
        object[] val_9 = new object[2];
        val_9[0] = msec;
        val_9[1] = new UnityEngine.AndroidJavaClass().GetStatic<System.Int32>(fieldName:  "DEFAULT_AMPLITUDE");
        val_26 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createOneShot", args:  val_9);
        goto label_26;
        label_16:
        object[] val_12 = new object[1];
        val_12[0] = new UnityEngine.AndroidJavaClass().GetStatic<System.Int32>(fieldName:  effectType);
        val_26 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createPredefined", args:  val_12);
        label_26:
        object[] val_15 = new object[1];
        val_15[0] = val_26;
        val_4.Call(methodName:  "vibrate", args:  val_15);
        val_27 = 0;
        val_28 = 0;
        if(val_23 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
        }
        
        if(val_27 != 1)
        {
                if(272 == 272)
        {
            goto label_116;
        }
        
        }
        
        label_45:
        object[] val_17 = new object[1];
        val_23 = val_17;
        val_23[0] = msec;
        val_4.Call(methodName:  "vibrate", args:  val_17);
        val_30 = 1;
        val_28 = 0;
        label_116:
        if(val_4 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_4.Dispose();
        }
        
        if(val_30 == 1)
        {
            goto label_56;
        }
        
        if(val_28 != 0)
        {
                if(272 != 272)
        {
            goto label_58;
        }
        
        }
        
        val_32 = val_28;
        if(val_2 != null)
        {
            goto label_62;
        }
        
        goto label_64;
        label_56:
        if(val_28 == 0)
        {
            goto label_61;
        }
        
        label_58:
        val_28 = 0;
        val_32 = 0;
        if(val_2 != null)
        {
            goto label_62;
        }
        
        goto label_64;
        label_61:
        val_32 = 0;
        val_30 = 0;
        if(val_2 == null)
        {
            goto label_64;
        }
        
        label_62:
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_2.Dispose();
        label_64:
        if(val_30 == 1)
        {
            goto label_69;
        }
        
        if(val_32 == 0)
        {
            goto label_72;
        }
        
        if(272 != 272)
        {
            goto label_71;
        }
        
        goto label_72;
        label_69:
        if(val_32 == 0)
        {
            goto label_73;
        }
        
        label_71:
        val_28 = 0;
        val_32 = 0;
        label_72:
        if(val_1 == null)
        {
            goto label_122;
        }
        
        label_121:
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_1.Dispose();
        label_122:
        if(val_30 != 1)
        {
                if(val_32 == 0)
        {
                return;
        }
        
            if(272 == 272)
        {
                return;
        }
        
            return;
        }
        
        if(val_32 != 0)
        {
                return;
        }
        
        return;
        label_73:
        if(val_1 != null)
        {
            goto label_121;
        }
        
        goto label_122;
    }
    private static int androidOSVersion()
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "android.os.Build$VERSION");
        if(val_1 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return (int)val_1.GetStatic<System.Int32>(fieldName:  "SDK_INT");
        }
        
        if(0 == 0)
        {
                return (int)val_1.GetStatic<System.Int32>(fieldName:  "SDK_INT");
        }
        
        return (int)val_1.GetStatic<System.Int32>(fieldName:  "SDK_INT");
    }
    public static int getHeight()
    {
        var val_7;
        var val_8;
        var val_10;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_7 = 0;
        val_8 = 0;
        if(val_2 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_2.Dispose();
        }
        
        if(val_7 == 1)
        {
            goto label_8;
        }
        
        val_10 = val_8;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_8 != 0)
        {
                val_8 = 0;
        }
        
        val_10 = 0;
        val_7 = 0;
        if(val_1 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_1.Dispose();
        label_12:
        if(val_7 != 1)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getHeightPixels", args:  System.Array.Empty<System.Object>());
        }
        
        if(val_10 == 0)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getHeightPixels", args:  System.Array.Empty<System.Object>());
        }
        
        return (int)(int)val_2.Call<System.Single>(methodName:  "getHeightPixels", args:  System.Array.Empty<System.Object>());
    }
    public static int getWidth()
    {
        var val_7;
        var val_8;
        var val_10;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_7 = 0;
        val_8 = 0;
        if(val_2 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_2.Dispose();
        }
        
        if(val_7 == 1)
        {
            goto label_8;
        }
        
        val_10 = val_8;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_8 != 0)
        {
                val_8 = 0;
        }
        
        val_10 = 0;
        val_7 = 0;
        if(val_1 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_1.Dispose();
        label_12:
        if(val_7 != 1)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getWidthPixels", args:  System.Array.Empty<System.Object>());
        }
        
        if(val_10 == 0)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getWidthPixels", args:  System.Array.Empty<System.Object>());
        }
        
        return (int)(int)val_2.Call<System.Single>(methodName:  "getWidthPixels", args:  System.Array.Empty<System.Object>());
    }
    public static int getPointHeight()
    {
        var val_7;
        var val_8;
        var val_10;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_7 = 0;
        val_8 = 0;
        if(val_2 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_2.Dispose();
        }
        
        if(val_7 == 1)
        {
            goto label_8;
        }
        
        val_10 = val_8;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_8 != 0)
        {
                val_8 = 0;
        }
        
        val_10 = 0;
        val_7 = 0;
        if(val_1 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_1.Dispose();
        label_12:
        if(val_7 != 1)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getPointHeight", args:  System.Array.Empty<System.Object>());
        }
        
        if(val_10 == 0)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getPointHeight", args:  System.Array.Empty<System.Object>());
        }
        
        return (int)(int)val_2.Call<System.Single>(methodName:  "getPointHeight", args:  System.Array.Empty<System.Object>());
    }
    public static int getPointWidth()
    {
        var val_7;
        var val_8;
        var val_10;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_7 = 0;
        val_8 = 0;
        if(val_2 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_2.Dispose();
        }
        
        if(val_7 == 1)
        {
            goto label_8;
        }
        
        val_10 = val_8;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_8 != 0)
        {
                val_8 = 0;
        }
        
        val_10 = 0;
        val_7 = 0;
        if(val_1 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_1.Dispose();
        label_12:
        if(val_7 != 1)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getPointWidth", args:  System.Array.Empty<System.Object>());
        }
        
        if(val_10 == 0)
        {
                return (int)(int)val_2.Call<System.Single>(methodName:  "getPointWidth", args:  System.Array.Empty<System.Object>());
        }
        
        return (int)(int)val_2.Call<System.Single>(methodName:  "getPointWidth", args:  System.Array.Empty<System.Object>());
    }
    public static void forceOrientationLandscape()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_16;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_12 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_2.Call(methodName:  "forceOrientationLandscape", args:  System.Array.Empty<System.Object>());
        val_13 = 0;
        val_14 = 0;
        if(val_2 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_2.Dispose();
        }
        
        if(val_13 == 1)
        {
            goto label_8;
        }
        
        val_16 = val_14;
        if(val_12 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_14 != 0)
        {
                val_14 = 0;
        }
        
        val_16 = 0;
        val_13 = 0;
        if(val_12 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_1.Dispose();
        label_12:
        if(val_13 != 1)
        {
                return;
        }
        
        if(val_16 == 0)
        {
                return;
        }
        
        val_12 = ???;
        val_16 = ???;
    }
    public static void forceOrientationPortrait()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_16;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_12 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_2.Call(methodName:  "forceOrientationPortrait", args:  System.Array.Empty<System.Object>());
        val_13 = 0;
        val_14 = 0;
        if(val_2 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_2.Dispose();
        }
        
        if(val_13 == 1)
        {
            goto label_8;
        }
        
        val_16 = val_14;
        if(val_12 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_14 != 0)
        {
                val_14 = 0;
        }
        
        val_16 = 0;
        val_13 = 0;
        if(val_12 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_1.Dispose();
        label_12:
        if(val_13 != 1)
        {
                return;
        }
        
        if(val_16 == 0)
        {
                return;
        }
        
        val_12 = ???;
        val_16 = ???;
    }
    public static bool enableReviewWindow()
    {
        return false;
    }
    public static void reviewWindow(string appid)
    {
    
    }
    public static long systemClockTime()
    {
        var val_7;
        var val_8;
        var val_10;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        long val_4 = val_2.Call<System.Int64>(methodName:  "elapsedRealtime", args:  System.Array.Empty<System.Object>());
        val_7 = 0;
        val_8 = 0;
        if(val_2 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_2.Dispose();
        }
        
        if(val_7 == 1)
        {
            goto label_8;
        }
        
        val_10 = val_8;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_8 != 0)
        {
                val_8 = 0;
        }
        
        val_10 = 0;
        val_7 = 0;
        if(val_1 == null)
        {
            goto label_12;
        }
        
        label_9:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_1.Dispose();
        label_12:
        if(val_7 != 1)
        {
                return 18446744073709551;
        }
        
        if(val_10 == 0)
        {
                return 18446744073709551;
        }
        
        return 18446744073709551;
    }
    public static int getAndroidApiLevel()
    {
        int val_2 = new UnityEngine.AndroidJavaClass(className:  "android.os.Build$VERSION").GetStatic<System.Int32>(fieldName:  "SDK_INT");
        UnityEngine.Debug.Log(message:  val_2);
        return val_2;
    }
    public static void InitNotification()
    {
    
    }
    public static void RegisterNotification()
    {
    
    }
    public static void ScheduleNotification(int triggerInSeconds, string title, string message, int id)
    {
    
    }
    public static void CancelAllNotifications()
    {
    
    }
    public static void PlayVibration(VibrationType vibrationType)
    {
        if((vibrationType - 1) > 5)
        {
                return;
        }
        
        var val_2 = 28871988 + ((vibrationType - 1)) << 2;
        val_2 = val_2 + 28871988;
        goto (28871988 + ((vibrationType - 1)) << 2 + 28871988);
    }
    public static void PlayVibrationOnce()
    {
        null = null;
        NativeUtils._VibrationAndroid(effectType:  NativeUtils.vEffectClick, msec:  20);
    }
    public static void PlayVibrationOnceStrong()
    {
        null = null;
        NativeUtils._VibrationAndroid(effectType:  NativeUtils.vEffectHClick, msec:  50);
    }
    public static void PlayVibrationOnceWeak()
    {
        null = null;
        NativeUtils._VibrationAndroid(effectType:  NativeUtils.vEffectTick, msec:  10);
    }
    public static void PlayVibrationDoubleStrong()
    {
        null = null;
        NativeUtils._VibrationAndroid(effectType:  NativeUtils.vEffectDClick, msec:  80);
    }
    public static void PlayVibrationDoubleWeak()
    {
        null = null;
        NativeUtils._VibrationAndroid(effectType:  NativeUtils.vEffectOneShot, msec:  100);
    }
    public static void PlayVibrationTriple()
    {
        null = null;
        NativeUtils._VibrationAndroid(effectType:  NativeUtils.vEffectOneShot, msec:  200);
    }
    public static void ShowAlert(string title, string message)
    {
    
    }
    private static NativeUtils()
    {
        NativeUtils.vEffectOneShot = "EFFECT_DEFAULT_AMPLITUDE";
        NativeUtils.vEffectClick = "EFFECT_CLICK";
        NativeUtils.vEffectDClick = "EFFECT_DOUBLE_CLICK";
        NativeUtils.vEffectHClick = "EFFECT_HEAVY_CLICK";
        NativeUtils.vEffectTick = "EFFECT_TICK";
    }

}
