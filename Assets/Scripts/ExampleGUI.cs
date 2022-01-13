using UnityEngine;
public class ExampleGUI : MonoBehaviour
{
    // Fields
    private int numberOfButtons;
    private bool isEnabled;
    private bool showPopUp;
    private string txtSetEnabled;
    private string txtManualLaunch;
    private string txtSetOfflineMode;
    
    // Methods
    private void OnGUI()
    {
        var val_64;
        string val_66;
        string val_67;
        if(this.showPopUp != false)
        {
                int val_1 = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            var val_3 = (val_1 < 0) ? (val_1 + 1) : (val_1);
            val_3 = val_3 >> 1;
            var val_4 = (val_2 < 0) ? (val_2 + 1) : (val_2);
            val_3 = val_3 - 150;
            val_4 = val_4 >> 1;
            var val_5 = val_4 - 65;
            UnityEngine.Rect val_7 = UnityEngine.GUI.Window(id:  0, clientRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, func:  new GUI.WindowFunction(object:  this, method:  System.Void ExampleGUI::ShowGUI(int windowID)), text:  "Is SDK enabled?");
        }
        
        int val_8 = UnityEngine.Screen.height;
        int val_9 = UnityEngine.Screen.width;
        int val_64 = this.numberOfButtons;
        val_64 = UnityEngine.Screen.height / val_64;
        if(((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this.txtManualLaunch)) == false) || ((System.String.Equals(a:  this.txtManualLaunch, b:  "SDK Launched", comparisonType:  5)) == true))
        {
            goto label_7;
        }
        
        com.adjust.sdk.AdjustConfig val_13 = new com.adjust.sdk.AdjustConfig(appToken:  "2fm9gkqubvpc", environment:  0);
        val_13.setLogLevel(logLevel:  1);
        val_64 = null;
        val_64 = null;
        if((ExampleGUI.<>c.<>9__6_0) == null)
        {
            goto label_11;
        }
        
        label_52:
        val_13.setLogDelegate(logDelegate:  ExampleGUI.<>c.<>9__6_0);
        val_13.setEventSuccessDelegate(eventSuccessDelegate:  new System.Action<com.adjust.sdk.AdjustEventSuccess>(object:  this, method:  public System.Void ExampleGUI::EventSuccessCallback(com.adjust.sdk.AdjustEventSuccess eventSuccessData)), sceneName:  "Adjust");
        val_13.setEventFailureDelegate(eventFailureDelegate:  new System.Action<com.adjust.sdk.AdjustEventFailure>(object:  this, method:  public System.Void ExampleGUI::EventFailureCallback(com.adjust.sdk.AdjustEventFailure eventFailureData)), sceneName:  "Adjust");
        val_13.setSessionSuccessDelegate(sessionSuccessDelegate:  new System.Action<com.adjust.sdk.AdjustSessionSuccess>(object:  this, method:  public System.Void ExampleGUI::SessionSuccessCallback(com.adjust.sdk.AdjustSessionSuccess sessionSuccessData)), sceneName:  "Adjust");
        val_13.setSessionFailureDelegate(sessionFailureDelegate:  new System.Action<com.adjust.sdk.AdjustSessionFailure>(object:  this, method:  public System.Void ExampleGUI::SessionFailureCallback(com.adjust.sdk.AdjustSessionFailure sessionFailureData)), sceneName:  "Adjust");
        val_13.setDeferredDeeplinkDelegate(deferredDeeplinkDelegate:  new System.Action<System.String>(object:  this, method:  System.Void ExampleGUI::DeferredDeeplinkCallback(string deeplinkURL)), sceneName:  "Adjust");
        val_13.setAttributionChangedDelegate(attributionChangedDelegate:  new System.Action<com.adjust.sdk.AdjustAttribution>(object:  this, method:  public System.Void ExampleGUI::AttributionChangedCallback(com.adjust.sdk.AdjustAttribution attributionData)), sceneName:  "Adjust");
        com.adjust.sdk.Adjust.start(adjustConfig:  val_13);
        this.isEnabled = true;
        this.txtManualLaunch = "SDK Launched";
        label_7:
        int val_21 = UnityEngine.Screen.width;
        int val_65 = this.numberOfButtons;
        int val_23 = UnityEngine.Screen.height / this.numberOfButtons;
        val_65 = UnityEngine.Screen.height / val_65;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Simple Event")) != false)
        {
                com.adjust.sdk.Adjust.trackEvent(adjustEvent:  new com.adjust.sdk.AdjustEvent(eventToken:  "g3mfiw"));
        }
        
        int val_27 = UnityEngine.Screen.width;
        int val_66 = this.numberOfButtons;
        int val_29 = UnityEngine.Screen.height << 1;
        val_29 = val_29 / this.numberOfButtons;
        val_66 = UnityEngine.Screen.height / val_66;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Revenue Event")) != false)
        {
                com.adjust.sdk.AdjustEvent val_31 = new com.adjust.sdk.AdjustEvent(eventToken:  "a4fd35");
            val_31.setRevenue(amount:  0.25, currency:  "EUR");
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_31);
        }
        
        int val_32 = UnityEngine.Screen.height;
        int val_33 = UnityEngine.Screen.width;
        int val_67 = this.numberOfButtons;
        int val_35 = val_32 + (val_32 << 1);
        val_35 = val_35 / this.numberOfButtons;
        val_67 = UnityEngine.Screen.height / val_67;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Callback Event")) != false)
        {
                com.adjust.sdk.AdjustEvent val_37 = new com.adjust.sdk.AdjustEvent(eventToken:  "34vgg9");
            if(val_37 != null)
        {
                val_37.addCallbackParameter(key:  "key", value:  "value");
        }
        else
        {
                val_37.addCallbackParameter(key:  "key", value:  "value");
        }
        
            val_37.addCallbackParameter(key:  "foo", value:  "bar");
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_37);
        }
        
        int val_39 = UnityEngine.Screen.width;
        int val_68 = this.numberOfButtons;
        int val_41 = UnityEngine.Screen.height << 2;
        val_41 = val_41 / this.numberOfButtons;
        val_68 = UnityEngine.Screen.height / val_68;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Partner Event")) != false)
        {
                com.adjust.sdk.AdjustEvent val_43 = new com.adjust.sdk.AdjustEvent(eventToken:  "w788qs");
            if(val_43 != null)
        {
                val_43.addPartnerParameter(key:  "key", value:  "value");
        }
        else
        {
                val_43.addPartnerParameter(key:  "key", value:  "value");
        }
        
            val_43.addPartnerParameter(key:  "foo", value:  "bar");
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_43);
        }
        
        int val_44 = UnityEngine.Screen.height;
        int val_45 = UnityEngine.Screen.width;
        int val_69 = this.numberOfButtons;
        int val_47 = val_44 + (val_44 << 2);
        val_47 = val_47 / this.numberOfButtons;
        val_69 = UnityEngine.Screen.height / val_69;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this.txtSetOfflineMode)) != false)
        {
                if((System.String.Equals(a:  this.txtSetOfflineMode, b:  "Turn Offline Mode ON", comparisonType:  5)) != false)
        {
                com.adjust.sdk.Adjust.setOfflineMode(enabled:  true);
            val_66 = "Turn Offline Mode OFF";
        }
        else
        {
                com.adjust.sdk.Adjust.setOfflineMode(enabled:  false);
            val_66 = "Turn Offline Mode ON";
        }
        
            this.txtSetOfflineMode = val_66;
        }
        
        int val_50 = UnityEngine.Screen.height;
        int val_51 = UnityEngine.Screen.width;
        int val_70 = this.numberOfButtons;
        int val_53 = val_50 + (val_50 << 1);
        val_53 = val_53 << 1;
        val_53 = val_53 / this.numberOfButtons;
        val_70 = UnityEngine.Screen.height / val_70;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this.txtSetEnabled)) != false)
        {
                if((System.String.Equals(a:  this.txtSetEnabled, b:  "Disable SDK", comparisonType:  5)) != false)
        {
                com.adjust.sdk.Adjust.setEnabled(enabled:  false);
            val_67 = "Enable SDK";
        }
        else
        {
                com.adjust.sdk.Adjust.setEnabled(enabled:  true);
            val_67 = "Disable SDK";
        }
        
            this.txtSetEnabled = val_67;
        }
        
        int val_56 = UnityEngine.Screen.height;
        int val_57 = UnityEngine.Screen.width;
        int val_71 = this.numberOfButtons;
        int val_59 = val_56 << 3;
        val_59 = val_59 - val_56;
        val_59 = val_59 / this.numberOfButtons;
        val_71 = UnityEngine.Screen.height / val_71;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Is SDK Enabled?")) == false)
        {
                return;
        }
        
        this.isEnabled = com.adjust.sdk.Adjust.isEnabled();
        this.showPopUp = true;
        return;
        label_11:
        ExampleGUI.<>c.<>9__6_0 = new System.Action<System.String>(object:  ExampleGUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ExampleGUI.<>c::<OnGUI>b__6_0(string msg));
        if(val_13 != null)
        {
            goto label_52;
        }
        
        goto label_52;
    }
    private void ShowGUI(int windowID)
    {
        string val_2;
        if(this.isEnabled != false)
        {
                val_2 = "Adjust SDK is ENABLED!";
        }
        else
        {
                val_2 = "Adjust SDK is DISABLED!";
        }
        
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_2);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "OK")) == false)
        {
                return;
        }
        
        this.showPopUp = false;
    }
    public void HandleGooglePlayId(string adId)
    {
        UnityEngine.Debug.Log(message:  "Google Play Ad ID = "("Google Play Ad ID = ") + adId);
    }
    public void AttributionChangedCallback(com.adjust.sdk.AdjustAttribution attributionData)
    {
        UnityEngine.Debug.Log(message:  "Attribution changed!");
        if(attributionData.trackerName != null)
        {
                UnityEngine.Debug.Log(message:  "Tracker name: "("Tracker name: ") + attributionData.trackerName);
        }
        
        if(attributionData.trackerToken != null)
        {
                UnityEngine.Debug.Log(message:  "Tracker token: "("Tracker token: ") + attributionData.trackerToken);
        }
        
        if(attributionData.network != null)
        {
                UnityEngine.Debug.Log(message:  "Network: "("Network: ") + attributionData.network);
        }
        
        if(attributionData.campaign != null)
        {
                UnityEngine.Debug.Log(message:  "Campaign: "("Campaign: ") + attributionData.campaign);
        }
        
        if(attributionData.adgroup != null)
        {
                UnityEngine.Debug.Log(message:  "Adgroup: "("Adgroup: ") + attributionData.adgroup);
        }
        
        if(attributionData.creative != null)
        {
                UnityEngine.Debug.Log(message:  "Creative: "("Creative: ") + attributionData.creative);
        }
        
        if(attributionData.clickLabel != null)
        {
                UnityEngine.Debug.Log(message:  "Click label: "("Click label: ") + attributionData.clickLabel);
        }
        
        if(attributionData.adid == null)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "ADID: "("ADID: ") + attributionData.adid);
    }
    public void EventSuccessCallback(com.adjust.sdk.AdjustEventSuccess eventSuccessData)
    {
        UnityEngine.Debug.Log(message:  "Event tracked successfully!");
        if(eventSuccessData.Message != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + eventSuccessData.Message);
        }
        
        if(eventSuccessData.Timestamp != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + eventSuccessData.Timestamp);
        }
        
        if(eventSuccessData.Adid != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + eventSuccessData.Adid);
        }
        
        if(eventSuccessData.EventToken != null)
        {
                UnityEngine.Debug.Log(message:  "EventToken: "("EventToken: ") + eventSuccessData.EventToken);
        }
        
        if(eventSuccessData.CallbackId != null)
        {
                UnityEngine.Debug.Log(message:  "CallbackId: "("CallbackId: ") + eventSuccessData.CallbackId);
        }
        
        if(eventSuccessData.JsonResponse == null)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + eventSuccessData.GetJsonResponse());
    }
    public void EventFailureCallback(com.adjust.sdk.AdjustEventFailure eventFailureData)
    {
        UnityEngine.Debug.Log(message:  "Event tracking failed!");
        if(eventFailureData.Message != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + eventFailureData.Message);
        }
        
        if(eventFailureData.Timestamp != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + eventFailureData.Timestamp);
        }
        
        if(eventFailureData.Adid != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + eventFailureData.Adid);
        }
        
        if(eventFailureData.EventToken != null)
        {
                UnityEngine.Debug.Log(message:  "EventToken: "("EventToken: ") + eventFailureData.EventToken);
        }
        
        if(eventFailureData.CallbackId != null)
        {
                UnityEngine.Debug.Log(message:  "CallbackId: "("CallbackId: ") + eventFailureData.CallbackId);
        }
        
        if(eventFailureData.JsonResponse != null)
        {
                UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + eventFailureData.GetJsonResponse());
        }
        
        UnityEngine.Debug.Log(message:  "WillRetry: "("WillRetry: ") + eventFailureData.WillRetry.ToString());
    }
    public void SessionSuccessCallback(com.adjust.sdk.AdjustSessionSuccess sessionSuccessData)
    {
        UnityEngine.Debug.Log(message:  "Session tracked successfully!");
        if(sessionSuccessData.Message != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + sessionSuccessData.Message);
        }
        
        if(sessionSuccessData.Timestamp != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + sessionSuccessData.Timestamp);
        }
        
        if(sessionSuccessData.Adid != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + sessionSuccessData.Adid);
        }
        
        if(sessionSuccessData.JsonResponse == null)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + sessionSuccessData.GetJsonResponse());
    }
    public void SessionFailureCallback(com.adjust.sdk.AdjustSessionFailure sessionFailureData)
    {
        UnityEngine.Debug.Log(message:  "Session tracking failed!");
        if(sessionFailureData.Message != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + sessionFailureData.Message);
        }
        
        if(sessionFailureData.Timestamp != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + sessionFailureData.Timestamp);
        }
        
        if(sessionFailureData.Adid != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + sessionFailureData.Adid);
        }
        
        if(sessionFailureData.JsonResponse != null)
        {
                UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + sessionFailureData.GetJsonResponse());
        }
        
        UnityEngine.Debug.Log(message:  "WillRetry: "("WillRetry: ") + sessionFailureData.WillRetry.ToString());
    }
    private void DeferredDeeplinkCallback(string deeplinkURL)
    {
        string val_2;
        object val_3;
        val_2 = deeplinkURL;
        UnityEngine.Debug.Log(message:  "Deferred deeplink reported!");
        if(val_2 != null)
        {
                val_2 = "Deeplink URL: "("Deeplink URL: ") + val_2;
            val_3 = val_2;
        }
        else
        {
                val_3 = "Deeplink URL is null!";
        }
        
        UnityEngine.Debug.Log(message:  val_3);
    }
    public ExampleGUI()
    {
        this.numberOfButtons = 8;
        this.txtSetEnabled = "Disable SDK";
        this.txtManualLaunch = "Manual Launch";
        this.txtSetOfflineMode = "Turn Offline Mode ON";
    }

}
