using UnityEngine;
public static class AnalyticsManager
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, object> analysisParametersDic;
    
    // Methods
    public static void Initialize()
    {
        null = null;
        AnalyticsManager.analysisParametersDic.Clear();
        AnalyticsManager.analysisParametersDic.Add(key:  "version", value:  System.String.Format(format:  "Ver {0}", arg0:  UnityEngine.Application.version));
        AnalyticsManager.analysisParametersDic.Add(key:  "genuine", value:  UnityEngine.Application.genuine);
        AnalyticsManager.analysisParametersDic.Add(key:  "genuine_check_available", value:  UnityEngine.Application.genuineCheckAvailable);
        UnityEngine.Analytics.AnalyticsResult val_7 = UnityEngine.Analytics.AnalyticsEvent.Custom(eventName:  "Initialize", eventData:  AnalyticsManager.analysisParametersDic);
    }
    public static void StageBegin(GameData gameData, int stage)
    {
        int val_3;
        var val_4;
        val_3 = stage;
        if(val_3 > 60)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        AnalyticsManager.analysisParametersDic.Clear();
        AnalyticsManager.analysisParametersDic.Add(key:  "stage", value:  System.String.Format(format:  "Stage {0}", arg0:  val_3));
        val_3 = AnalyticsManager.analysisParametersDic;
        UnityEngine.Analytics.AnalyticsResult val_2 = UnityEngine.Analytics.AnalyticsEvent.Custom(eventName:  "StageBegin", eventData:  val_3);
    }
    private static AnalyticsManager()
    {
        AnalyticsManager.analysisParametersDic = new System.Collections.Generic.Dictionary<System.String, System.Object>();
    }

}
