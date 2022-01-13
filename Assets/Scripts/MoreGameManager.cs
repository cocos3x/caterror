using UnityEngine;
public class MoreGameManager : JoypacSingleMonoBehaviour<MoreGameManager>
{
    // Fields
    public static bool showFlg;
    private bool initFlg;
    
    // Methods
    public void InitRedpot()
    {
        var val_7;
        object val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        int val_1 = JoypacUtils.OnlineParametersInt(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.GET_MOREGAMES, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_80});
        int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  "GMS_FLAG", defaultValue:  0);
        LogTool.DebugLog(log:  "localflg " + val_2, color:  val_2, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Buttons/MoreGames/RedPotManager.cs", name:  "InitRedpot");
        object[] val_4 = new object[4];
        if(val_1 > val_2)
        {
                val_4[0] = "Show Red  GMG_Flg  ";
            val_4[1] = val_1;
            val_8 = "localflg  ";
            val_4[2] = val_8;
            val_4[3] = val_2;
            LogTool.DebugLog(log:  +val_4, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Buttons/MoreGames/RedPotManager.cs", name:  "InitRedpot");
            val_9 = 1152921504942149632;
            val_10 = null;
            val_10 = null;
            MoreGameManager.showFlg = true;
            return;
        }
        
        val_4[0] = "Close Red  GMG_Flg  ";
        val_4[1] = val_1;
        val_8 = "localflg  ";
        val_4[2] = val_8;
        val_4[3] = val_2;
        LogTool.DebugLog(log:  +val_4, color:  0, path:  "/Users/grace/Documents/git/nigeneko_android/nigeneko/Assets/Joypac/Scripts/Buttons/MoreGames/RedPotManager.cs", name:  "InitRedpot");
        val_9 = 1152921504942149632;
        val_11 = null;
        val_11 = null;
        MoreGameManager.showFlg = false;
    }
    public void RedClick()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        if(MoreGameManager.showFlg != false)
        {
                JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Behavior", type:  "getmoreskin_click", position:  "red", onlyFirst:  false, extra:  "");
            val_4 = null;
            val_4 = null;
            MoreGameManager.showFlg = false;
        }
        else
        {
                JoypacAnalyticsManager.DesignEvent(_logType:  32, sort:  "Behavior", type:  "getmoreskin_click", position:  "initiative", onlyFirst:  false, extra:  "");
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "GMS_FLAG", value:  JoypacUtils.OnlineParametersInt(_param:  new JoypacOnlineParam() {Key = StaticOnlineParams.GET_MOREGAMES, DefaultValue = StaticOnlineParams.hasInterLimitFlag.__il2cppRuntimeField_80}));
    }
    public bool BoolRedPodShow()
    {
        var val_1;
        if(this.initFlg != true)
        {
                this.InitRedpot();
            this.initFlg = true;
        }
        
        val_1 = null;
        val_1 = null;
        return (bool)MoreGameManager.showFlg;
    }
    public void OnClick(UnityEngine.GameObject red)
    {
        UnityEngine.Application.OpenURL(url:  "");
        RedClick();
        if(red == 0)
        {
                return;
        }
        
        red.SetActive(value:  this.BoolRedPodShow());
    }
    public MoreGameManager()
    {
    
    }
    private static MoreGameManager()
    {
    
    }

}
