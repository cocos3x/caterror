using UnityEngine;
public class DeviceOrientationChecker : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.CanvasScaler[] canvasScalerArray;
    private float[] autoMatchArray;
    private UnityEngine.Camera[] cameraArray;
    private ChangeDeviceOrientationEvent onChangeDeviceOrientation;
    private ChangeDeviceOrientationEvent onChangeToDeviceOrientationPortrait;
    private ChangeDeviceOrientationEvent onChangeToDeviceOrientationLandscape;
    private UnityEngine.DeviceOrientation deviceOrientation;
    private int screenWidth;
    private int screenHeight;
    
    // Properties
    public ChangeDeviceOrientationEvent OnChangeDeviceOrientation { get; }
    public ChangeDeviceOrientationEvent OnChangeToDeviceOrientationPortrait { get; }
    public ChangeDeviceOrientationEvent OnChangeToDeviceOrientationLandscape { get; }
    public UnityEngine.DeviceOrientation DeviceOrientation { get; }
    
    // Methods
    public ChangeDeviceOrientationEvent get_OnChangeDeviceOrientation()
    {
        return (ChangeDeviceOrientationEvent)this.onChangeDeviceOrientation;
    }
    public ChangeDeviceOrientationEvent get_OnChangeToDeviceOrientationPortrait()
    {
        return (ChangeDeviceOrientationEvent)this.onChangeToDeviceOrientationPortrait;
    }
    public ChangeDeviceOrientationEvent get_OnChangeToDeviceOrientationLandscape()
    {
        return (ChangeDeviceOrientationEvent)this.onChangeToDeviceOrientationLandscape;
    }
    public UnityEngine.DeviceOrientation get_DeviceOrientation()
    {
        return (UnityEngine.DeviceOrientation)this.deviceOrientation;
    }
    private void Start()
    {
        var val_5;
        if((ScreenExtensions.IsNarrowScreen() == false) || (this.canvasScalerArray.Length == 0))
        {
            goto label_2;
        }
        
        val_5 = 0;
        goto label_3;
        label_15:
        UnityEngine.UI.CanvasScaler val_6 = this.canvasScalerArray[0];
        if(this.autoMatchArray[0] < 0)
        {
                if(val_6 != null)
        {
            goto label_10;
        }
        
        }
        else
        {
            
        }
        
        label_10:
        val_6.matchWidthOrHeight = this.autoMatchArray[0];
        val_5 = 1;
        label_3:
        if(val_5 < this.canvasScalerArray.Length)
        {
            goto label_15;
        }
        
        label_2:
        this.screenWidth = UnityEngine.Screen.width;
        int val_3 = UnityEngine.Screen.height;
        this.screenHeight = val_3;
        this.deviceOrientation = this.GetDeviceOrientation(width:  this.screenWidth, height:  val_3);
        this.InvokeChangeEvent();
    }
    private void Update()
    {
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        UnityEngine.DeviceOrientation val_3 = this.GetDeviceOrientation(width:  val_1, height:  val_2);
        if(((this.deviceOrientation != val_3) || (this.screenWidth != val_1)) || (this.screenHeight != val_2))
        {
            goto label_3;
        }
        
        UnityEngine.DeviceOrientation val_7 = this.GetDeviceOrientation(width:  NativeUtils.getWidth(), height:  NativeUtils.getHeight());
        if(val_3 != val_7)
        {
            goto label_6;
        }
        
        return;
        label_3:
        this.deviceOrientation = val_3;
        this.screenWidth = val_1;
        this.screenHeight = val_2;
        this.InvokeChangeEvent();
        return;
        label_6:
        val_7 = val_7 - 1;
        if(val_7 <= 1)
        {
                NativeUtils.forceOrientationPortrait();
            return;
        }
        
        NativeUtils.forceOrientationLandscape();
    }
    private void InvokeChangeEvent()
    {
        ChangeDeviceOrientationEvent val_12;
        var val_13;
        float val_14;
        float val_15;
        var val_16;
        val_12 = this;
        UnityEngine.DeviceOrientation val_12 = this.deviceOrientation;
        if((val_12 - 1) < 2)
        {
            goto label_1;
        }
        
        val_12 = val_12 - 3;
        if((val_12 > 1) || (ScreenExtensions.IsNarrowScreen() == false))
        {
            goto label_10;
        }
        
        float val_16 = 0f;
        float val_13 = 0f;
        float val_14 = 0f;
        float val_15 = 0f;
        val_13 = 812f - val_13;
        float val_3 = 375f - val_16;
        val_14 = 375f - val_14;
        val_3 = val_3 / 375f;
        val_15 = val_13 - val_15;
        val_14 = val_14 - val_16;
        val_13 = 1f - (val_13 / 812f);
        val_16 = 1f - val_3;
        val_15 = val_15 / 812f;
        float val_5 = val_14 / 375f;
        val_13 = 0;
        goto label_4;
        label_8:
        val_14 = 0f;
        val_15 = 0f;
        this.cameraArray[0].rect = new UnityEngine.Rect() {m_XMin = val_14, m_YMin = 0f, m_Width = val_15, m_Height = 0f};
        val_13 = 1;
        label_4:
        if(val_13 < this.cameraArray.Length)
        {
            goto label_8;
        }
        
        goto label_10;
        label_1:
        if(ScreenExtensions.IsNarrowScreen() == false)
        {
            goto label_10;
        }
        
        float val_21 = 0f;
        float val_18 = 0f;
        float val_19 = 0f;
        float val_20 = 0f;
        val_18 = 375f - val_18;
        float val_7 = 812f - val_21;
        val_19 = 812f - val_19;
        val_7 = val_7 / 812f;
        val_20 = val_18 - val_20;
        val_19 = val_19 - val_21;
        val_18 = 1f - (val_18 / 375f);
        val_21 = 1f - val_7;
        val_20 = val_20 / 375f;
        float val_9 = val_19 / 812f;
        val_16 = 0;
        goto label_11;
        label_15:
        val_14 = 0f;
        val_15 = 0f;
        this.cameraArray[0].rect = new UnityEngine.Rect() {m_XMin = val_14, m_YMin = 0f, m_Width = val_15, m_Height = 0f};
        val_16 = 1;
        label_11:
        if(val_16 < this.cameraArray.Length)
        {
            goto label_15;
        }
        
        label_10:
        this.onChangeDeviceOrientation.Invoke(arg0:  this.deviceOrientation);
        if((this.deviceOrientation - 1) < 2)
        {
            goto label_17;
        }
        
        if((this.deviceOrientation - 3) >= 2)
        {
                return;
        }
        
        val_12 = this.onChangeToDeviceOrientationLandscape;
        if(val_12 != null)
        {
            goto label_21;
        }
        
        goto label_20;
        label_17:
        val_12 = this.onChangeToDeviceOrientationPortrait;
        if(val_12 != null)
        {
            goto label_21;
        }
        
        label_20:
        label_21:
        val_12.Invoke(arg0:  this.deviceOrientation);
    }
    private UnityEngine.DeviceOrientation GetDeviceOrientation(int width, int height)
    {
        if(UnityEngine.Input.deviceOrientation > 6)
        {
                return (UnityEngine.DeviceOrientation)(width >= height) ? 3 : (0 + 1);
        }
        
        var val_3 = 28872416 + (val_1) << 2;
        val_3 = val_3 + 28872416;
        goto (28872416 + (val_1) << 2 + 28872416);
    }
    public DeviceOrientationChecker()
    {
        float[] val_1 = new float[2];
        val_1[0] = -1f;
        this.autoMatchArray = val_1;
    }

}
