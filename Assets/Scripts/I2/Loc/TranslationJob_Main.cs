using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_Main : TranslationJob
    {
        // Fields
        private I2.Loc.TranslationJob_WEB mWeb;
        private I2.Loc.TranslationJob_POST mPost;
        private I2.Loc.TranslationJob_GET mGet;
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        public string mErrorMessage;
        
        // Methods
        public TranslationJob_Main(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            this.mPost = new I2.Loc.TranslationJob_POST(requests:  requests, OnTranslationReady:  OnTranslationReady);
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            I2.Loc.TranslationJob_WEB val_3;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_4;
            System.Action<System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>, System.String> val_5;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_6;
            val_3 = this.mWeb;
            if(val_3 == null)
            {
                goto label_5;
            }
            
            if(val_3 == null)
            {
                    return (eJobState)this.mGet;
            }
            
            if(val_3 == 2)
            {
                goto label_3;
            }
            
            if(val_3 != 1)
            {
                goto label_5;
            }
            
            mem[1152921512246570464] = 1;
            goto label_5;
            label_3:
            this.mWeb.Dispose();
            this.mWeb = 0;
            val_5 = this._OnTranslationReady;
            I2.Loc.TranslationJob_POST val_1 = null;
            val_4 = this._requests;
            val_1 = new I2.Loc.TranslationJob_POST(requests:  val_4, OnTranslationReady:  val_5);
            this.mPost = val_1;
            label_5:
            val_3 = this.mPost;
            if(val_3 == null)
            {
                goto label_11;
            }
            
            if(val_3 == null)
            {
                    return (eJobState)this.mGet;
            }
            
            if(val_3 == 2)
            {
                goto label_9;
            }
            
            if(val_3 != 1)
            {
                goto label_11;
            }
            
            mem[1152921512246570464] = 1;
            goto label_11;
            label_9:
            this.mPost.Dispose();
            this.mPost = 0;
            val_5 = this._OnTranslationReady;
            I2.Loc.TranslationJob_GET val_2 = null;
            val_4 = this._requests;
            val_2 = new I2.Loc.TranslationJob_GET(requests:  val_4, OnTranslationReady:  val_5);
            this.mGet = val_2;
            label_11:
            val_3 = this.mGet;
            if(val_3 == null)
            {
                    return (eJobState)this.mGet;
            }
            
            if(val_3 == null)
            {
                    return (eJobState)this.mGet;
            }
            
            if(val_3 != 2)
            {
                    if(val_3 != 1)
            {
                    return (eJobState)this.mGet;
            }
            
                mem[1152921512246570464] = 1;
                return (eJobState)this.mGet;
            }
            
            this.mErrorMessage = this.mGet.mErrorMessage;
            if(this._OnTranslationReady != null)
            {
                    val_6 = this._requests;
                this._OnTranslationReady.Invoke(arg1:  val_6, arg2:  this.mGet.mErrorMessage);
            }
            
            this.mGet.Dispose();
            this.mGet = 0;
            return (eJobState)this.mGet;
        }
        public override void Dispose()
        {
            if(this.mPost != null)
            {
                    this.mPost.Dispose();
            }
            
            if(this.mGet != null)
            {
                    this.mGet.Dispose();
            }
            
            this.mPost = 0;
            this.mGet = 0;
        }
    
    }

}
