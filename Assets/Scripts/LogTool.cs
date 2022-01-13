using UnityEngine;
public class LogTool : MonoBehaviour
{
    // Fields
    private static bool logFlg;
    private static string[] m_colorS;
    
    // Methods
    public static void Init(bool _logFlg)
    {
        var val_5 = null;
        LogTool.logFlg = _logFlg;
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Debug.unityLogger.logEnabled = (LogTool.logFlg == true) ? 1 : 0;
    }
    public static void DebugLog(string log, LogTool.Color color = 0, string path, string name)
    {
        string val_6;
        var val_7;
        var val_9;
        val_6 = path;
        val_7 = null;
        val_7 = null;
        if(LogTool.logFlg == false)
        {
                return;
        }
        
        if(val_6 != null)
        {
                char[] val_1 = new char[1];
            val_1[0] = '/';
            val_9 = val_6.Split(separator:  val_1);
        }
        else
        {
                val_9 = 0;
        }
        
        string[] val_3 = new string[6];
        val_3[0] = "[";
        if(val_9 != 0)
        {
                var val_4 = val_9 + 62264824;
            val_6 = mem[(val_9 + 62264824) + 32];
            val_6 = (val_9 + 62264824) + 32;
        }
        
        val_3[1] = val_6;
        val_3[2] = "_";
        val_3[3] = name;
        val_3[4] = "]:";
        val_3[5] = log;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  LogTool.m_colorS + 32, arg0:  +val_3));
    }
    public static void Error(string log, string path, string name)
    {
        string val_5;
        var val_6;
        var val_7;
        val_5 = path;
        val_6 = null;
        val_6 = null;
        if(LogTool.logFlg == false)
        {
                return;
        }
        
        if(val_5 != null)
        {
                char[] val_1 = new char[1];
            val_1[0] = '/';
            val_7 = val_5.Split(separator:  val_1);
        }
        else
        {
                val_7 = 0;
        }
        
        string[] val_3 = new string[6];
        if(val_3 == null)
        {
            goto label_8;
        }
        
        if(val_7 == 0)
        {
            goto label_9;
        }
        
        label_16:
        val_3[0] = "[";
        var val_4 = val_7 + 62264824;
        val_5 = mem[(val_7 + 62264824) + 32];
        val_5 = (val_7 + 62264824) + 32;
        if(val_5 != 0)
        {
            goto label_14;
        }
        
        goto label_21;
        label_8:
        if(val_7 != 0)
        {
            goto label_16;
        }
        
        label_9:
        val_3[0] = "Error!!! [";
        if(val_5 == null)
        {
            goto label_21;
        }
        
        label_14:
        label_21:
        val_3[1] = val_5;
        val_3[2] = "_";
        val_3[3] = name;
        val_3[4] = "]:";
        val_3[5] = log;
        UnityEngine.Debug.LogError(message:  +val_3);
    }
    public LogTool()
    {
    
    }
    private static LogTool()
    {
        LogTool.logFlg = false;
        string[] val_1 = new string[9];
        val_1[0] = "{0}";
        val_1[1] = "<color=#ff0000>{0}</color>";
        val_1[2] = "<color=#ffff00ff>{0}</color>";
        val_1[3] = "<color=#008000ff>{0}</color>";
        val_1[4] = "<color=#0000ffff>{0}</color>";
        val_1[5] = "<color=#add8e6ff>{0}</color>";
        val_1[6] = "<color=#800080ff>{0}</color>";
        val_1[7] = "<color=#c0c0c0ff>{0}</color>";
        val_1[8] = "{0}";
        LogTool.m_colorS = val_1;
    }

}
