using UnityEngine;
public class JoyPacCurrentcySingle
{
    // Fields
    private readonly UnityEngine.AndroidJavaObject _currentcySinglePlugin;
    
    // Methods
    public JoyPacCurrentcySingle()
    {
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        this._currentcySinglePlugin = new UnityEngine.AndroidJavaObject(className:  "com.joypac.coresdk.core.LoginManager", args:  System.Array.Empty<System.Object>());
        this.getInstance();
    }
    public void getInstance()
    {
        UnityEngine.AndroidJavaObject val_2 = this._currentcySinglePlugin.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
    }
    public void init(string appSecret)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(appSecret != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(appSecret == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = appSecret;
        this._currentcySinglePlugin.Call(methodName:  "init", args:  val_1);
    }
    public void register()
    {
        this._currentcySinglePlugin.Call(methodName:  "register", args:  System.Array.Empty<System.Object>());
    }
    public void login()
    {
        this._currentcySinglePlugin.Call(methodName:  "login", args:  System.Array.Empty<System.Object>());
    }
    public void notifyZone(string serverId, string serverName, string roleId, string roleName)
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(serverId != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(serverId == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = serverId;
        val_1[1] = serverName;
        val_1[2] = roleId;
        val_1[3] = roleName;
        this._currentcySinglePlugin.Call(methodName:  "notifyZone", args:  val_1);
    }
    public void createRole(string role, string roleId)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(role != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(role == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = role;
        val_1[1] = roleId;
        this._currentcySinglePlugin.Call(methodName:  "createRole", args:  val_1);
    }
    public void setAccountListener()
    {
        this._currentcySinglePlugin.Call(methodName:  "setAccountListener", args:  System.Array.Empty<System.Object>());
    }
    public void getUserInfo()
    {
        this._currentcySinglePlugin.Call(methodName:  "getUserInfo", args:  System.Array.Empty<System.Object>());
    }
    public void isLogin()
    {
        this._currentcySinglePlugin.Call(methodName:  "isLogin", args:  System.Array.Empty<System.Object>());
    }
    public void logout()
    {
        this._currentcySinglePlugin.Call(methodName:  "logout", args:  System.Array.Empty<System.Object>());
    }
    public void isRealNameAuth()
    {
        this._currentcySinglePlugin.Call(methodName:  "isRealNameAuth", args:  System.Array.Empty<System.Object>());
    }
    public void exit()
    {
        this._currentcySinglePlugin.Call(methodName:  "exit", args:  System.Array.Empty<System.Object>());
    }
    public void destroy()
    {
        this._currentcySinglePlugin.Call(methodName:  "destroy", args:  System.Array.Empty<System.Object>());
    }

}
