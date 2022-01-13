using UnityEngine;
public class NativeAd : MonoBehaviour
{
    // Fields
    protected static UnityEngine.RectTransform s_NativeAd;
    private static NativeAd s_instance;
    private UnityEngine.Camera uiCamera;
    private bool horizontal;
    private static bool firstFlg;
    private static float m_width;
    private static float m_height;
    private static float m_x;
    private static float m_y;
    
    // Properties
    public static NativeAd Instance { get; }
    
    // Methods
    public static NativeAd get_Instance()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(NativeAd.s_instance == 0)
        {
                UnityEngine.Debug.LogError(message:  "s_instance == null ");
        }
        
        val_3 = null;
        val_3 = null;
        return (NativeAd)NativeAd.s_instance;
    }
    private void Awake()
    {
        null = null;
        NativeAd.s_instance = this;
    }
    public void ShowNativeAd()
    {
        UnityEngine.Debug.Log(message:  "show native");
        JoypacAdManager.Instance.ShowNative(x:  this.GetX(), y:  this.GetY(), w:  this.GetWidth(), h:  this.GetHeight());
    }
    public float GetWidth()
    {
        var val_1;
        this.FirstGetWAndH();
        val_1 = null;
        val_1 = null;
        return (float)NativeAd.m_width;
    }
    public float GetHeight()
    {
        var val_1;
        this.FirstGetWAndH();
        val_1 = null;
        val_1 = null;
        return (float)NativeAd.m_height;
    }
    public float GetX()
    {
        var val_1;
        this.FirstGetWAndH();
        val_1 = null;
        val_1 = null;
        return (float)NativeAd.m_x;
    }
    public float GetY()
    {
        var val_1;
        this.FirstGetWAndH();
        val_1 = null;
        val_1 = null;
        return (float)NativeAd.m_y;
    }
    private void FirstGetWAndH()
    {
        var val_55;
        UnityEngine.Camera val_56;
        float val_57;
        float val_58;
        float val_59;
        var val_60;
        val_55 = null;
        val_55 = null;
        if(NativeAd.firstFlg == false)
        {
                return;
        }
        
        if(this.uiCamera == 0)
        {
                val_56 = UnityEngine.GameObject.Find(name:  "Main Camera").GetComponent<UnityEngine.Camera>();
            this.uiCamera = val_56;
        }
        else
        {
                val_56 = this.uiCamera;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        UnityEngine.Rect val_7 = this.GetComponent<UnityEngine.RectTransform>().rect;
        UnityEngine.Vector3 val_9 = this.transform.lossyScale;
        UnityEngine.Vector3 val_11 = this.transform.position;
        UnityEngine.Rect val_13 = this.GetComponent<UnityEngine.RectTransform>().rect;
        UnityEngine.Vector3 val_15 = this.transform.lossyScale;
        UnityEngine.Vector3 val_17 = this.transform.position;
        float val_54 = 0.5f;
        float val_18 = val_7.m_XMin * val_54;
        val_54 = val_13.m_YMin * val_54;
        val_18 = val_18 * val_9.x;
        val_54 = val_54 * val_15.y;
        val_18 = val_5.x - val_18;
        val_54 = val_11.y + val_54;
        UnityEngine.Vector3 val_19 = val_56.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_57 = val_19.x;
        float val_58 = val_19.y;
        UnityEngine.Vector3 val_21 = this.transform.position;
        UnityEngine.Rect val_23 = this.GetComponent<UnityEngine.RectTransform>().rect;
        UnityEngine.Vector3 val_25 = this.transform.lossyScale;
        UnityEngine.Vector3 val_27 = this.transform.position;
        UnityEngine.Rect val_29 = this.GetComponent<UnityEngine.RectTransform>().rect;
        UnityEngine.Vector3 val_31 = this.transform.lossyScale;
        UnityEngine.Vector3 val_33 = this.transform.position;
        float val_55 = 0.5f;
        float val_56 = val_55;
        val_55 = val_23.m_XMin * val_56;
        val_56 = val_29.m_YMin * val_56;
        val_55 = val_55 * val_25.x;
        val_56 = val_56 * val_31.y;
        val_55 = val_21.x + val_55;
        val_56 = val_27.y - val_56;
        UnityEngine.Vector3 val_34 = this.uiCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        float val_57 = val_34.x;
        object[] val_35 = new object[5];
        val_35[0] = "世界坐标 x=";
        UnityEngine.Vector3 val_37 = this.transform.position;
        val_35[1] = val_37.x;
        val_35[2] = " y=";
        UnityEngine.Vector3 val_39 = this.transform.position;
        val_35[3] = val_39.y;
        val_35[4] = " ";
        LogTool.DebugLog(log:  +val_35, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/NativeAd.cs", name:  "FirstGetWAndH");
        UnityEngine.Vector3 val_42 = this.transform.position;
        UnityEngine.Vector3 val_43 = this.uiCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z});
        float val_59 = val_43.y;
        object[] val_44 = new object[4];
        val_44[0] = "lefttop.x = ";
        val_44[1] = val_57;
        val_44[2] = " rightbottom.y = ";
        val_44[3] = val_34.y;
        LogTool.DebugLog(log:  +val_44, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/NativeAd.cs", name:  "FirstGetWAndH");
        object[] val_46 = new object[4];
        val_57 = val_57 - val_57;
        val_46[0] = " width = ";
        val_46[1] = val_57;
        val_58 = val_34.y - val_58;
        val_58 = System.Math.Abs(val_58);
        val_46[2] = " htight = ";
        val_46[3] = val_58;
        LogTool.DebugLog(log:  +val_46, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/NativeAd.cs", name:  "FirstGetWAndH");
        object[] val_49 = new object[4];
        val_49[0] = "Screen.height=";
        val_49[1] = UnityEngine.Screen.height;
        float val_60 = (float)UnityEngine.Screen.height;
        val_59 = (val_58 * 0.5f) + val_59;
        val_60 = val_60 - val_59;
        val_49[2] = "最终屏幕坐标 y =";
        val_49[3] = val_60;
        LogTool.DebugLog(log:  +val_49, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Ad/NativeAd.cs", name:  "FirstGetWAndH");
        if(this.horizontal == false)
        {
            goto label_89;
        }
        
        float val_61 = 1.2f;
        val_59 = ((val_58 > val_57) ? (val_57) : (val_58)) * val_61;
        if(val_57 <= val_59)
        {
            goto label_89;
        }
        
        val_61 = val_57 - val_59;
        val_61 = val_61 * 0.5f;
        val_57 = val_57 + val_61;
        goto label_90;
        label_89:
        val_59 = val_57;
        label_90:
        val_60 = null;
        val_60 = null;
        NativeAd.m_x = val_57;
        NativeAd.m_y = val_60;
        NativeAd.m_width = val_59;
        NativeAd.m_height = val_58;
        NativeAd.firstFlg = false;
    }
    public NativeAd()
    {
    
    }
    private static NativeAd()
    {
        NativeAd.firstFlg = true;
    }

}
