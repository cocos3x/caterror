using UnityEngine;
public class ShareManager : SingletonMonoBehaviour<ShareManager>
{
    // Fields
    private System.Action<bool> callback;
    private string TexturePath;
    private UnityEngine.AndroidJavaObject worker;
    
    // Methods
    private void Awake()
    {
        if(this.CheckInstance() == true)
        {
                return;
        }
        
        this.TexturePath = UnityEngine.Application.persistentDataPath + "/SNSTexture.png"("/SNSTexture.png");
        this.worker = new UnityEngine.AndroidJavaObject(className:  "jp.usaya.lib.UsayaUnityPlayerActivity", args:  System.Array.Empty<System.Object>());
    }
    public void ShareTwitter(string message, UnityEngine.Texture2D texture, System.Action<bool> callback)
    {
        this.callback = callback;
        this.SaveTexture(texture:  texture, path:  this.TexturePath);
        this.PostTwitter(message:  message, imagePath:  this.TexturePath);
    }
    public void ShareTwitter(string message, string path, System.Action<bool> callback)
    {
        this.callback = callback;
        this.PostTwitter(message:  message, imagePath:  path);
    }
    public void ShareFacebook(string message, UnityEngine.Texture2D texture, System.Action<bool> callback)
    {
        callback.Invoke(obj:  false);
    }
    public void ShareFacebook(string message, string path, System.Action<bool> callback)
    {
        callback.Invoke(obj:  false);
    }
    private void SaveTexture(UnityEngine.Texture2D texture, string path)
    {
        System.IO.Stream val_12;
        System.IO.BinaryWriter val_13;
        var val_14;
        var val_15;
        System.IO.FileStream val_1 = null;
        val_12 = val_1;
        val_1 = new System.IO.FileStream(path:  path, mode:  2, access:  2);
        val_13 = new System.IO.BinaryWriter();
        val_13 = new System.IO.BinaryWriter(output:  val_1);
        System.Byte[] val_3 = UnityEngine.ImageConversion.EncodeToPNG(tex:  texture);
        val_14 = 0;
        val_15 = 0;
        var val_12 = 0;
        val_12 = val_12 + 1;
        new System.IO.BinaryWriter().Dispose();
        if(val_15 == 1)
        {
                if(val_14 != 0)
        {
                val_14 = 0;
        }
        
            val_15 = 0;
        }
        
        if(val_12 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_1.Dispose();
        }
        
        if(val_15 != 1)
        {
                return;
        }
        
        if(val_14 == 0)
        {
                return;
        }
        
        val_12 = ???;
        val_13 = ???;
    }
    private void PostTwitter(string message, string imagePath)
    {
        object[] val_3 = new object[4];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(true == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(true == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = true;
        val_3[1] = (message == null) ? "" : message;
        val_3[2] = "";
        val_3[3] = (imagePath == null) ? "" : imagePath;
        this.worker.Call(methodName:  "postTwitterOrFacebook", args:  val_3);
    }
    private void PostFacebook(string imagePath)
    {
        object[] val_2 = new object[4];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if( == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if( == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = null;
        val_2[1] = "";
        val_2[2] = "";
        val_2[3] = (imagePath == null) ? "" : imagePath;
        this.worker.Call(methodName:  "postTwitterOrFacebook", args:  val_2);
    }
    private void CreateChooser(string message, string imagePath)
    {
        object val_1 = (message == null) ? "" : message;
        object[] val_3 = new object[2];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        val_3[1] = (imagePath == null) ? "" : imagePath;
        this.worker.Call(methodName:  "createChooser", args:  val_3);
    }
    private void OnShareManagerResult(string result)
    {
        var val_2;
        if((System.String.op_Equality(a:  result, b:  "0")) != false)
        {
                val_2 = 1;
        }
        else
        {
                val_2 = 0;
        }
        
        this.callback.Invoke(obj:  false);
    }
    public ShareManager()
    {
        this.TexturePath = "";
    }

}
