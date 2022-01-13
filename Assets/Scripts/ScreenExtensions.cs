using UnityEngine;
public static class ScreenExtensions
{
    // Methods
    public static bool IsNarrowScreen()
    {
        float val_4;
        if((float)UnityEngine.Screen.height > (float)UnityEngine.Screen.width)
        {
                val_4 = (float)UnityEngine.Screen.height / (float)UnityEngine.Screen.width;
            return (bool)(val_4 > 1.788889f) ? 1 : 0;
        }
        
        val_4 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
        return (bool)(val_4 > 1.788889f) ? 1 : 0;
    }
    public static bool HasSafeArea()
    {
        var val_8;
        if((float)UnityEngine.Screen.height > (float)UnityEngine.Screen.width)
        {
                val_8 = UnityEngine.Screen.height;
            UnityEngine.Rect val_4 = UnityEngine.Screen.safeArea;
            return (bool)(val_8 != (int)val_6.m_XMin) ? 1 : 0;
        }
        
        val_8 = UnityEngine.Screen.width;
        UnityEngine.Rect val_6 = UnityEngine.Screen.safeArea;
        return (bool)(val_8 != (int)val_6.m_XMin) ? 1 : 0;
    }
    public static UnityEngine.Rect GetSafeArea()
    {
        return UnityEngine.Screen.safeArea;
    }
    public static int GetSafeAreaTop()
    {
        UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
        float val_3 = (float)UnityEngine.Screen.height;
        val_3 = val_3 - val_1.m_XMin;
        val_3 = val_3 - val_1.m_XMin;
        val_1.m_XMin = val_3 / val_1.m_XMin;
        val_1.m_XMin = val_1.m_XMin * 1136f;
        return (int)(int)val_1.m_XMin;
    }
    public static int GetSafeAreaBottom()
    {
        UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
        val_1.m_XMin = val_1.m_XMin / val_1.m_XMin;
        val_1.m_XMin = val_1.m_XMin * 1136f;
        return (int)(int)val_1.m_XMin;
    }
    public static bool IsiPhoneX()
    {
        if(NativeUtils.getWidth() == 1125)
        {
                if(NativeUtils.getHeight() == 2436)
        {
                return true;
        }
        
        }
        
        if(NativeUtils.getWidth() == 2436)
        {
                if(NativeUtils.getHeight() == 1125)
        {
                return true;
        }
        
        }
        
        if(NativeUtils.getWidth() == 828)
        {
                if(NativeUtils.getHeight() == 1792)
        {
                return true;
        }
        
        }
        
        if(NativeUtils.getWidth() == 1792)
        {
                if(NativeUtils.getHeight() == 828)
        {
                return true;
        }
        
        }
        
        if((NativeUtils.getWidth() == 1242) && (NativeUtils.getHeight() == 2688))
        {
                return true;
        }
        
        if(NativeUtils.getWidth() != 2688)
        {
                return true;
        }
        
        var val_13 = (NativeUtils.getHeight() == 1242) ? 1 : 0;
        return true;
    }
    public static void ChangeScreenRotateState(UnityEngine.MonoBehaviour behaviour, ScreenRotateState state)
    {
        var val_9;
        System.Action val_11;
        var val_12;
        if(state == 2)
        {
            goto label_1;
        }
        
        if(state == 1)
        {
            goto label_2;
        }
        
        if(state != 0)
        {
                return;
        }
        
        UnityEngine.Screen.autorotateToLandscapeLeft = true;
        UnityEngine.Screen.autorotateToLandscapeRight = true;
        UnityEngine.Screen.autorotateToPortrait = true;
        UnityEngine.Screen.autorotateToPortraitUpsideDown = true;
        return;
        label_1:
        UnityEngine.Screen.autorotateToLandscapeLeft = false;
        UnityEngine.Screen.autorotateToLandscapeRight = false;
        UnityEngine.Screen.autorotateToPortrait = true;
        UnityEngine.Screen.autorotateToPortraitUpsideDown = true;
        if(UnityEngine.Screen.orientation != 3)
        {
                if(UnityEngine.Screen.orientation != 4)
        {
                return;
        }
        
        }
        
        UnityEngine.Screen.orientation = 1;
        val_9 = null;
        val_9 = null;
        val_11 = ScreenExtensions.<>c.<>9__6_1;
        if(val_11 != null)
        {
            goto label_16;
        }
        
        System.Action val_3 = null;
        val_11 = val_3;
        val_3 = new System.Action(object:  ScreenExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ScreenExtensions.<>c::<ChangeScreenRotateState>b__6_1());
        ScreenExtensions.<>c.<>9__6_1 = val_11;
        goto label_16;
        label_2:
        UnityEngine.Screen.autorotateToLandscapeLeft = true;
        UnityEngine.Screen.autorotateToLandscapeRight = true;
        UnityEngine.Screen.autorotateToPortrait = false;
        UnityEngine.Screen.autorotateToPortraitUpsideDown = false;
        if(UnityEngine.Screen.orientation != 1)
        {
                if(UnityEngine.Screen.orientation != 2)
        {
                return;
        }
        
        }
        
        UnityEngine.Screen.orientation = 3;
        val_12 = null;
        val_12 = null;
        val_11 = ScreenExtensions.<>c.<>9__6_0;
        if(val_11 == null)
        {
                System.Action val_6 = null;
            val_11 = val_6;
            val_6 = new System.Action(object:  ScreenExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ScreenExtensions.<>c::<ChangeScreenRotateState>b__6_0());
            ScreenExtensions.<>c.<>9__6_0 = val_11;
        }
        
        label_16:
        UnityEngine.Coroutine val_7 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  behaviour, act:  val_6);
    }
    public static SimpleDeviceOrientation DeviceOrientationToSimpleDeviceOrientation(UnityEngine.DeviceOrientation deviceOrientation)
    {
        if((deviceOrientation - 1) < 2)
        {
                return 1;
        }
        
        if((deviceOrientation - 3) < 2)
        {
                return 2;
        }
        
        return (SimpleDeviceOrientation)(UnityEngine.Screen.width >= UnityEngine.Screen.height) ? (1 + 1) : 1;
    }

}
