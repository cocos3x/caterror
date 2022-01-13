using UnityEngine;
public class CryptoPrefs
{
    // Fields
    private static string sKEY;
    private static string sIV;
    
    // Methods
    public static void SetInt(string key, int val)
    {
        UnityEngine.PlayerPrefs.SetString(key:  CryptoPrefs.GetHash(key:  key), value:  CryptoPrefs.Encrypt(rawString:  val.ToString()));
    }
    public static int GetInt(string key, int defaultValue = 0)
    {
        int val_3 = defaultValue;
        bool val_4 = System.Int32.TryParse(s:  CryptoPrefs.GetString(key:  key, defaultValue:  defaultValue.ToString()), result: out  val_3);
        return val_3;
    }
    public static void SetFloat(string key, float val)
    {
        UnityEngine.PlayerPrefs.SetString(key:  CryptoPrefs.GetHash(key:  key), value:  CryptoPrefs.Encrypt(rawString:  val.ToString()));
    }
    public static float GetFloat(string key, float defaultValue = 0)
    {
        bool val_4 = System.Single.TryParse(s:  CryptoPrefs.GetString(key:  key, defaultValue:  defaultValue.ToString()), result: out  float val_3 = -5.279746E-11f);
        return (float)defaultValue;
    }
    public static void SetString(string key, string val)
    {
        UnityEngine.PlayerPrefs.SetString(key:  CryptoPrefs.GetHash(key:  key), value:  CryptoPrefs.Encrypt(rawString:  val));
    }
    public static string GetString(string key, string defaultValue = "")
    {
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  CryptoPrefs.GetHash(key:  key), defaultValue:  defaultValue);
        if((defaultValue.Equals(value:  val_2)) == false)
        {
                return CryptoPrefs.Decrypt(encString:  val_2);
        }
        
        return (string)defaultValue;
    }
    public static bool HasKey(string key)
    {
        return UnityEngine.PlayerPrefs.HasKey(key:  CryptoPrefs.GetHash(key:  key));
    }
    public static void DeleteKey(string key)
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  CryptoPrefs.GetHash(key:  key));
    }
    public static void DeleteAll()
    {
        UnityEngine.PlayerPrefs.DeleteAll();
    }
    public static void Save()
    {
        UnityEngine.PlayerPrefs.Save();
    }
    private static string Decrypt(string encString)
    {
        var val_10;
        System.Security.Cryptography.RijndaelManaged val_1 = new System.Security.Cryptography.RijndaelManaged();
        if(val_1 != null)
        {
            
        }
        
        System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
        val_10 = null;
        val_10 = null;
        System.Byte[] val_3 = System.Convert.FromBase64String(s:  CryptoPrefs.sIV);
        if(new byte[0] == null)
        {
            goto label_11;
        }
        
        label_16:
        System.Text.Encoding val_8 = System.Text.Encoding.UTF8;
        if(val_8 != null)
        {
                return val_8.TrimEnd(trimChars:  new char[1]);
        }
        
        return val_8.TrimEnd(trimChars:  new char[1]);
        label_11:
        if((new System.Security.Cryptography.CryptoStream(stream:  new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  encString)), transform:  val_1, mode:  0)) != null)
        {
            goto label_16;
        }
        
        goto label_16;
    }
    private static string Encrypt(string rawString)
    {
        var val_7;
        var val_8;
        System.Security.Cryptography.RijndaelManaged val_1 = new System.Security.Cryptography.RijndaelManaged();
        if(val_1 != null)
        {
            
        }
        
        System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
        val_7 = null;
        val_7 = null;
        System.Byte[] val_3 = System.Convert.FromBase64String(s:  CryptoPrefs.sIV);
        System.IO.MemoryStream val_4 = new System.IO.MemoryStream();
        System.Security.Cryptography.CryptoStream val_5 = new System.Security.Cryptography.CryptoStream(stream:  val_4, transform:  val_1, mode:  1);
        if(System.Text.Encoding.UTF8 == null)
        {
            goto label_11;
        }
        
        if(val_5 == null)
        {
            goto label_12;
        }
        
        label_14:
        val_8 = 0;
        goto label_13;
        label_11:
        if(val_5 != null)
        {
            goto label_14;
        }
        
        label_12:
        val_8 = 1;
        label_13:
        val_5.FlushFinalBlock();
        if(val_4 != null)
        {
                return System.Convert.ToBase64String(inArray:  val_4);
        }
        
        return System.Convert.ToBase64String(inArray:  val_4);
    }
    private static string GetHash(string key)
    {
        System.Byte[] val_7;
        string val_8;
        var val_9;
        val_7 = System.Text.Encoding.UTF8;
        System.Text.StringBuilder val_4 = null;
        val_8 = 0;
        val_4 = new System.Text.StringBuilder();
        val_9 = 0;
        goto label_3;
        label_7:
        val_7 = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(buffer:  val_7)[0][32].ToString(format:  "x2");
        val_8 = val_7;
        System.Text.StringBuilder val_6 = val_4.Append(value:  val_8);
        val_9 = 1;
        label_3:
        if(val_9 < val_3.Length)
        {
            goto label_7;
        }
        
        if(val_4 == null)
        {
            
        }
    
    }
    public CryptoPrefs()
    {
    
    }
    private static CryptoPrefs()
    {
        CryptoPrefs.sKEY = "ZTdkvTNmaBE2NTM3nWM0NDFhNRdzNzU1";
        CryptoPrefs.sIV = "4rZtmENfa/PpeJ86qU3gyA==";
    }

}
