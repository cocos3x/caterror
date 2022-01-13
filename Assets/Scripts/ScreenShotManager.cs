using UnityEngine;
public class ScreenShotManager : SingletonMonoBehaviour<ScreenShotManager>
{
    // Fields
    private UnityEngine.Texture2D defaultScreenShotTexture;
    public string shareImageFileName;
    
    // Properties
    public string ImagePath { get; }
    public bool ExistsScreenShot { get; }
    
    // Methods
    public string get_ImagePath()
    {
        return System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Application.persistentDataPath, arg1:  this.shareImageFileName);
    }
    public bool get_ExistsScreenShot()
    {
        return System.IO.File.Exists(path:  this.ImagePath);
    }
    private void Awake()
    {
        bool val_1 = this.CheckInstance();
    }
    public void CaptureScreenShot(System.Action justBeforeAction, System.Action justAfterAction, System.Action callback)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this._CaptureScreenShot(justBeforeAction:  justBeforeAction, justAfterAction:  justAfterAction, callback:  callback));
    }
    private System.Collections.IEnumerator _CaptureScreenShot(System.Action justBeforeAction, System.Action justAfterAction, System.Action callback)
    {
        ScreenShotManager.<_CaptureScreenShot>d__8 val_1 = new ScreenShotManager.<_CaptureScreenShot>d__8();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .justBeforeAction = justBeforeAction;
            .justAfterAction = justAfterAction;
        }
        else
        {
                mem[32] = this;
            mem[40] = justBeforeAction;
            mem[48] = justAfterAction;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }
    public UnityEngine.Texture2D GetTexture()
    {
        UnityEngine.Texture2D val_6 = new UnityEngine.Texture2D();
        val_6 = new UnityEngine.Texture2D(width:  0, height:  0);
        bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  System.IO.File.ReadAllBytes(path:  this.ImagePath));
        if((TextureExtensions.isBogus(tex:  new UnityEngine.Texture2D())) == false)
        {
                return val_6;
        }
        
        val_6 = this.defaultScreenShotTexture;
        return val_6;
    }
    public UnityEngine.Sprite GetSprite()
    {
        return Texture2DExtensions.ToSprite(tex:  this.GetTexture());
    }
    public void ShareTwitter(string message, System.Action<bool> callback)
    {
        val_1.callback = callback;
        SingletonMonoBehaviour<ShareManager>.Instance.PostTwitter(message:  message, imagePath:  this.ImagePath);
    }
    public void ShareFacebook(string message, System.Action<bool> callback)
    {
        ShareManager val_1 = SingletonMonoBehaviour<ShareManager>.Instance;
        string val_2 = this.ImagePath;
        0.ShareFacebook(message:  message, path:  callback, callback:  callback);
    }
    public ScreenShotManager()
    {
        this.shareImageFileName = "ScreenShot.png";
    }

}
