using UnityEngine;
public class JoyPacCurrentcyAdSingle
{
    // Fields
    private readonly UnityEngine.AndroidJavaObject _currentcyAdSinglePlugin;
    
    // Methods
    public JoyPacCurrentcyAdSingle()
    {
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        this._currentcyAdSinglePlugin = new UnityEngine.AndroidJavaObject(className:  "com.joypac.unitybridge.UnityAdManager", args:  System.Array.Empty<System.Object>());
    }
    public void init(string joypacAppID, string userType, string joypacUnitName)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacAppID != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacAppID == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacAppID;
        val_1[1] = userType;
        val_1[2] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "init", args:  val_1);
    }
    public void initBanner(string joypacUnitName, int position)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        val_1[1] = position;
        this._currentcyAdSinglePlugin.Call(methodName:  "initBanner", args:  val_1);
    }
    public void initInterstitial(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "initInterstitial", args:  val_1);
    }
    public void initReward(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "initReward", args:  val_1);
    }
    public void initNative(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "initNative", args:  val_1);
    }
    public void loadBanner(int direction, string joypacUnitName, string postion)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(direction != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(direction == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = direction;
        val_1[1] = joypacUnitName;
        val_1[2] = postion;
        this._currentcyAdSinglePlugin.Call(methodName:  "loadBanner", args:  val_1);
    }
    public void loadInterstitial(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "loadInterstitial", args:  val_1);
    }
    public void loadReward(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "loadReward", args:  val_1);
    }
    public void loadNative(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "loadNative", args:  val_1);
    }
    public void showBanner(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "showBanner", args:  val_1);
    }
    public bool isReadyNative(string joypacUnitName)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return false;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = joypacUnitName;
        if(this._currentcyAdSinglePlugin != null)
        {
                return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReadyNative", args:  val_2);
        }
        
        return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReadyNative", args:  val_2);
    }
    public void showNative(string joypacUnitName, float left, float top, float width, float height)
    {
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        val_1[1] = left;
        val_1[2] = top;
        val_1[3] = width;
        val_1[4] = height;
        this._currentcyAdSinglePlugin.Call(methodName:  "showNative", args:  val_1);
    }
    public void hideNative()
    {
        this._currentcyAdSinglePlugin.Call(methodName:  "hideNative", args:  System.Array.Empty<System.Object>());
    }
    public void destroyNative()
    {
        this._currentcyAdSinglePlugin.Call(methodName:  "destroyNative", args:  System.Array.Empty<System.Object>());
    }
    public void hideBanner()
    {
        this._currentcyAdSinglePlugin.Call(methodName:  "hideBanner", args:  System.Array.Empty<System.Object>());
    }
    public void destroyBanner()
    {
        this._currentcyAdSinglePlugin.Call(methodName:  "destroyBanner", args:  System.Array.Empty<System.Object>());
    }
    public bool isReadyInterstitial(string joypacUnitName)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return false;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = joypacUnitName;
        if(this._currentcyAdSinglePlugin != null)
        {
                return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReadyInterstitial", args:  val_2);
        }
        
        return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReadyInterstitial", args:  val_2);
    }
    public bool isReadyBanner(string joypacUnitName)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return false;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = joypacUnitName;
        if(this._currentcyAdSinglePlugin != null)
        {
                return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReadyBanner", args:  val_2);
        }
        
        return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReadyBanner", args:  val_2);
    }
    public void showInterstitial(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "showInterstitial", args:  val_1);
    }
    public void closeInterstitial()
    {
        this._currentcyAdSinglePlugin.Call(methodName:  "closeInterstitial", args:  System.Array.Empty<System.Object>());
    }
    public void destroyInterstitial()
    {
        this._currentcyAdSinglePlugin.Call(methodName:  "destroyInterstitial", args:  System.Array.Empty<System.Object>());
    }
    public void showReward(string joypacUnitName, string eventPosition)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        val_1[1] = eventPosition;
        this._currentcyAdSinglePlugin.Call(methodName:  "showReward", args:  val_1);
    }
    public bool isReady(string joypacUnitName)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return false;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = joypacUnitName;
        if(this._currentcyAdSinglePlugin != null)
        {
                return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReady", args:  val_2);
        }
        
        return this._currentcyAdSinglePlugin.Call<System.Boolean>(methodName:  "isReady", args:  val_2);
    }
    public void destroyReward()
    {
        this._currentcyAdSinglePlugin.Call(methodName:  "destroyReward", args:  System.Array.Empty<System.Object>());
    }
    public void setBannerListener(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "setBannerListener", args:  val_1);
    }
    public void setInterstitialListener(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "setInterstitialListener", args:  val_1);
    }
    public void setRewardListener(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "setRewardListener", args:  val_1);
    }
    public void setNativeListener(string joypacUnitName)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(joypacUnitName != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(joypacUnitName == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = joypacUnitName;
        this._currentcyAdSinglePlugin.Call(methodName:  "setNativeListener", args:  val_1);
    }
    public void joypacEventLog(string eventSort, string eventType, string eventPosition, string eventExtra)
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(eventSort != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(eventSort == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = eventSort;
        val_1[1] = eventType;
        val_1[2] = eventPosition;
        val_1[3] = eventExtra;
        this._currentcyAdSinglePlugin.Call(methodName:  "joypacEventLog", args:  val_1);
    }
    public void ReceiveGameGroupId(string cGroupId)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(cGroupId != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(cGroupId == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = cGroupId;
        this._currentcyAdSinglePlugin.Call(methodName:  "ReceiveGameGroupId", args:  val_1);
    }
    public string GetDeviceID()
    {
        if(this._currentcyAdSinglePlugin != null)
        {
                return this._currentcyAdSinglePlugin.Call<System.String>(methodName:  "GetDeviceID", args:  System.Array.Empty<System.Object>());
        }
        
        return this._currentcyAdSinglePlugin.Call<System.String>(methodName:  "GetDeviceID", args:  System.Array.Empty<System.Object>());
    }
    public void ReceiveAdJustData(string adJustJson)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(adJustJson != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(adJustJson == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = adJustJson;
        this._currentcyAdSinglePlugin.Call(methodName:  "ReceiveAdJustData", args:  val_1);
    }

}
