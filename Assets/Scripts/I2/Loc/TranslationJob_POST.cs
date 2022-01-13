using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_POST : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        
        // Methods
        public TranslationJob_POST(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            UnityEngine.WWWForm val_3 = new UnityEngine.WWWForm();
            val_3.AddField(fieldName:  "action", value:  "Translate");
            val_3.AddField(fieldName:  "list", value:  I2.Loc.GoogleTranslation.ConvertTranslationRequest(requests:  requests, encodeGET:  false).Item[0]);
            UnityEngine.Networking.UnityWebRequest val_6 = UnityEngine.Networking.UnityWebRequest.Post(uri:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0), formData:  val_3);
            mem[1152921512246905160] = val_6;
            I2.Loc.I2Utils.SendWebRequest(www:  val_6);
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this == null)
            {
                    return (eJobState)val_3;
            }
            
            if(this.isDone == false)
            {
                    return (eJobState)val_3;
            }
            
            System.Byte[] val_3 = X20.downloadHandler.data;
            this.ProcessResult(bytes:  val_3, errorMsg:  X21.error);
            val_3.Dispose();
            mem[1152921512247090888] = 0;
            return (eJobState)val_3;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            string val_4;
            var val_5;
            val_4 = errorMsg;
            if((System.String.IsNullOrEmpty(value:  val_4)) == false)
            {
                goto label_1;
            }
            
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            if(bytes == null)
            {
                goto label_2;
            }
            
            label_9:
            val_4 = val_2;
            if(this._OnTranslationReady != null)
            {
                    this._OnTranslationReady.Invoke(arg1:  this._requests, arg2:  I2.Loc.GoogleTranslation.ParseTranslationResult(html:  val_4, requests:  this._requests));
            }
            
            val_5 = 1;
            goto label_7;
            label_1:
            val_5 = 2;
            label_7:
            mem[1152921512247309376] = val_5;
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
