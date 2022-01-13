using UnityEngine;

namespace I2.Loc
{
    public abstract class I2BasePersistentStorage
    {
        // Methods
        public virtual void SetSetting_String(string key, string value)
        {
            object val_8;
            int val_9;
            val_8 = key;
            val_9 = value.Length;
            if(val_9 > 8000)
            {
                    float val_8 = 8000f;
                val_8 = (float)val_9 / val_8;
                int val_2 = UnityEngine.Mathf.CeilToInt(f:  val_8);
                if(val_2 >= 1)
            {
                    var val_10 = 0;
                object val_9 = 0;
                do
            {
                UnityEngine.PlayerPrefs.SetString(key:  System.String.Format(format:  "[I2split]{0}{1}", arg0:  val_9, arg1:  val_8), value:  value.Substring(startIndex:  0, length:  UnityEngine.Mathf.Min(a:  64, b:  val_9)));
                val_9 = val_9 + 1;
                val_9 = val_9 + 7999;
                val_10 = val_10 + 8000;
            }
            while(val_9 < val_2);
            
            }
            
                UnityEngine.PlayerPrefs.SetString(key:  val_8, value:  "[$I2#@div$]" + val_2);
                return;
            }
            
            UnityEngine.PlayerPrefs.SetString(key:  val_8, value:  value);
        }
        public virtual string GetSetting_String(string key, string defaultValue)
        {
            string val_11;
            var val_12;
            val_11 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  defaultValue);
            if((System.String.IsNullOrEmpty(value:  val_11)) == true)
            {
                    return (string)val_11;
            }
            
            if((val_11.StartsWith(value:  "[I2split]")) == false)
            {
                    return (string)val_11;
            }
            
            val_12 = "[I2split]";
            if("[I2split]" == null)
            {
                    val_12 = "[I2split]";
            }
            
            int val_6 = System.Int32.Parse(s:  val_11.Substring(startIndex:  Length));
            val_11 = "";
            if(val_6 < 1)
            {
                    return (string)val_11;
            }
            
            object val_11 = 0;
            do
            {
                string val_8 = UnityEngine.PlayerPrefs.GetString(key:  System.String.Format(format:  "[I2split]{0}{1}", arg0:  val_11, arg1:  key), defaultValue:  "");
                string val_9 = val_11 + val_8;
                val_11 = val_9;
                val_11 = val_11 + 1;
            }
            while(val_11 < val_6);
            
            return (string)val_11;
        }
        public virtual void DeleteSetting(string key)
        {
            int val_8;
            var val_9;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_1)) != true)
            {
                    val_8 = "[I2split]";
                if((val_1.StartsWith(value:  "[I2split]")) != false)
            {
                    val_9 = "[I2split]";
                if("[I2split]" == null)
            {
                    val_9 = "[I2split]";
            }
            
                val_8 = Length;
                int val_6 = System.Int32.Parse(s:  val_1.Substring(startIndex:  val_8));
                if(val_6 >= 1)
            {
                    do
            {
                UnityEngine.PlayerPrefs.DeleteKey(key:  System.String.Format(format:  "[I2split]{0}{1}", arg0:  0, arg1:  key));
                val_8 = 0 + 1;
            }
            while(val_8 < val_6);
            
            }
            
            }
            
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  key);
        }
        public virtual void ForceSaveSettings()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        public virtual bool HasSetting(string key)
        {
            return UnityEngine.PlayerPrefs.HasKey(key:  key);
        }
        public virtual bool CanAccessFiles()
        {
            return true;
        }
        private string UpdateFilename(I2.Loc.PersistentStorage.eFileType fileType, string fileName)
        {
            if(fileType != 3)
            {
                    if(fileType == 2)
            {
                    return UnityEngine.Application.temporaryCachePath + "/"("/") + fileName;
            }
            
                if(fileType != 1)
            {
                    return (string)fileName;
            }
            
                string val_1 = UnityEngine.Application.persistentDataPath;
                return UnityEngine.Application.temporaryCachePath + "/"("/") + fileName;
            }
            
            string val_2 = UnityEngine.Application.streamingAssetsPath;
            return UnityEngine.Application.temporaryCachePath + "/"("/") + fileName;
        }
        public virtual bool SaveFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = True)
        {
            string val_5;
            eFileType val_6;
            var val_7;
            val_5 = data;
            val_6 = fileType;
            if((this & 1) != 0)
            {
                    val_6 = this.UpdateFilename(fileType:  val_6, fileName:  fileName);
                System.IO.File.WriteAllText(path:  val_6, contents:  val_5, encoding:  System.Text.Encoding.UTF8);
                val_7 = 1;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public virtual string LoadFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            string val_6;
            eFileType val_7;
            var val_8;
            val_6 = fileName;
            val_7 = fileType;
            if((this & 1) != 0)
            {
                    val_7 = this.UpdateFilename(fileType:  val_7, fileName:  val_6);
                string val_3 = System.IO.File.ReadAllText(path:  val_7, encoding:  System.Text.Encoding.UTF8);
                return (string)val_8;
            }
            
            val_8 = 0;
            return (string)val_8;
        }
        public virtual bool DeleteFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            string val_4;
            eFileType val_5;
            object val_6;
            val_4 = fileName;
            val_5 = fileType;
            if((this & 1) != 0)
            {
                    val_5 = this.UpdateFilename(fileType:  val_5, fileName:  val_4);
                System.IO.File.Delete(path:  val_5);
                val_6 = 1;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public virtual bool HasFile(I2.Loc.PersistentStorage.eFileType fileType, string fileName, bool logExceptions = True)
        {
            string val_5;
            eFileType val_6;
            string val_7;
            val_5 = fileName;
            val_6 = fileType;
            if((this & 1) != 0)
            {
                    val_6 = this.UpdateFilename(fileType:  val_6, fileName:  val_5);
                val_7 = val_6;
                bool val_2 = System.IO.File.Exists(path:  val_7);
            }
            else
            {
                    val_7 = 0;
            }
            
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
        protected I2BasePersistentStorage()
        {
        
        }
    
    }

}
