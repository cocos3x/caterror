using UnityEngine;
private sealed class LanguageSourceData.<Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public I2.Loc.LanguageSourceData <>4__this;
    public bool JustCheck;
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LanguageSourceData.<Import_Google_Coroutine>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_13;
        var val_15;
        UnityEngine.Networking.UnityWebRequest val_16;
        string val_17;
        int val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_34;
        }
        
        val_13 = this.JustCheck;
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_2 = this.<>4__this.Import_Google_CreateWWWcall(ForceUpdate:  false, justCheck:  (val_13 == true) ? 1 : 0);
        val_15 = this;
        this.<www>5__2 = val_2;
        if(val_2 != null)
        {
            goto label_6;
        }
        
        return (bool)val_18;
        label_1:
        val_15 = this;
        val_16 = this.<www>5__2;
        this.<>1__state = 0;
        if(val_16 == null)
        {
                val_16 = 0;
        }
        
        label_6:
        if(val_16.isDone == false)
        {
            goto label_7;
        }
        
        val_13 = this.<www>5__2;
        if((System.String.IsNullOrEmpty(value:  val_13.error)) == false)
        {
            goto label_9;
        }
        
        System.Byte[] val_7 = this.<www>5__2.downloadHandler.data;
        System.Text.Encoding val_8 = System.Text.Encoding.UTF8;
        val_13 = val_8;
        if((System.String.IsNullOrEmpty(value:  val_8)) == false)
        {
            goto label_14;
        }
        
        val_17 = 1;
        goto label_15;
        label_7:
        val_18 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_18;
        return (bool)val_18;
        label_14:
        val_17 = val_13;
        bool val_10 = System.String.op_Equality(a:  val_17, b:  "\"\"");
        label_15:
        if(this.JustCheck == false)
        {
            goto label_17;
        }
        
        if(val_10 == true)
        {
            goto label_34;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Spreadsheet is not up-to-date and Google Live Synchronization is enabled\nWhen playing in the device the Spreadsheet will be downloaded and translations may not behave as what you see in the editor.\nTo fix this, Import or Export replace to Google");
        val_18 = 0;
        this.<>4__this.GoogleLiveSyncIsUptoDate = false;
        return (bool)val_18;
        label_17:
        if(val_10 == false)
        {
            goto label_23;
        }
        
        label_9:
        if((this.<>4__this.Event_OnSourceUpdateFromGoogle) != null)
        {
                val_13 = this.<www>5__2;
            this.<>4__this.Event_OnSourceUpdateFromGoogle.Invoke(arg1:  this.<>4__this, arg2:  false, arg3:  val_13.error);
        }
        
        UnityEngine.Debug.Log(message:  "Language Source was up-to-date with Google Spreadsheet");
        label_34:
        val_18 = 0;
        return (bool)val_18;
        label_23:
        if((this.<>4__this) != null)
        {
                this.<>4__this.mDelayedGoogleData = val_13;
        }
        else
        {
                mem[160] = val_13;
        }
        
        if((this.<>4__this.GoogleUpdateSynchronization) == 1)
        {
            goto label_31;
        }
        
        if((this.<>4__this.GoogleUpdateSynchronization) != 2)
        {
            goto label_34;
        }
        
        this.<>4__this.ApplyDownloadedDataFromGoogle();
        goto label_34;
        label_31:
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this.<>4__this, method:  System.Void I2.Loc.LanguageSourceData::ApplyDownloadedDataOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)));
        goto label_34;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
