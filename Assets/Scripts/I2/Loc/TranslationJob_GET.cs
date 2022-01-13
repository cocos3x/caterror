using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_GET : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        private System.Collections.Generic.List<string> mQueries;
        public string mErrorMessage;
        
        // Methods
        public TranslationJob_GET(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            this.mQueries = I2.Loc.GoogleTranslation.ConvertTranslationRequest(requests:  requests, encodeGET:  true);
            goto typeof(I2.Loc.TranslationJob_GET).__il2cppRuntimeField_178;
        }
        private void ExecuteNextQuery()
        {
            if(this.mQueries.Count != 0)
            {
                    int val_3 = this.mQueries.Count - 1;
                this.mQueries.RemoveAt(index:  val_3);
                UnityEngine.Networking.UnityWebRequest val_7 = UnityEngine.Networking.UnityWebRequest.Get(uri:  System.String.Format(format:  "{0}?action=Translate&list={1}", arg0:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0), arg1:  this.mQueries.Item[val_3]));
                mem[1152921512245785576] = val_7;
                I2.Loc.I2Utils.SendWebRequest(www:  val_7);
                return;
            }
            
            mem[1152921512245785568] = 1;
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this != null)
            {
                    if(this.isDone != false)
            {
                    System.Byte[] val_3 = X20.downloadHandler.data;
                this.ProcessResult(bytes:  val_3, errorMsg:  X21.error);
                val_3.Dispose();
                mem[1152921512245975400] = 0;
            }
            else
            {
                    if(X20 != 0)
            {
                    return (eJobState)this;
            }
            
            }
            
            }
            
            this.ExecuteNextQuery();
            return (eJobState)this;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            string val_5 = errorMsg;
            if((System.String.IsNullOrEmpty(value:  val_5 = errorMsg)) == false)
            {
                goto label_6;
            }
            
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            if(bytes == null)
            {
                goto label_2;
            }
            
            label_9:
            string val_3 = I2.Loc.GoogleTranslation.ParseTranslationResult(html:  val_2, requests:  this._requests);
            val_5 = val_3;
            if((System.String.IsNullOrEmpty(value:  val_3)) != false)
            {
                    if(this._OnTranslationReady == null)
            {
                    return;
            }
            
                this._OnTranslationReady.Invoke(arg1:  this._requests, arg2:  0);
                return;
            }
            
            label_6:
            mem[1152921512246194912] = 2;
            this.mErrorMessage = val_5;
            return;
            label_2:
            if(val_2 != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
    
    }

}
