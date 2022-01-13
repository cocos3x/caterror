using UnityEngine;

namespace AvoEx
{
    public static class AesEncryptor
    {
        // Fields
        private const int keySize = 16;
        private const string keyString = "defaultKeyString";
        private const int IvLength = 16;
        private static readonly System.Text.UTF8Encoding encoder;
        private static readonly System.Security.Cryptography.AesManaged aes;
        
        // Methods
        private static AesEncryptor()
        {
            System.Text.UTF8Encoding val_1 = new System.Text.UTF8Encoding();
            AvoEx.AesEncryptor.encoder = val_1;
            TSource[] val_4 = System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Take<System.Byte>(source:  val_1, count:  16));
            AvoEx.AesEncryptor.aes = new System.Security.Cryptography.AesManaged();
            if(AvoEx.AesEncryptor.aes == null)
            {
                
            }
        
        }
        public static byte[] GenerateIV()
        {
            null = null;
            if(AvoEx.AesEncryptor.aes == null)
            {
                
            }
        
        }
        public static byte[] Encrypt(byte[] buffer)
        {
            var val_5;
            var val_7;
            val_5 = null;
            val_5 = null;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = null;
            val_7 = null;
            if(AvoEx.AesEncryptor.aes != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                AvoEx.AesEncryptor.aes.Dispose();
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Concat<System.Byte>(first:  AvoEx.AesEncryptor.aes, second:  AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length)));
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Concat<System.Byte>(first:  AvoEx.AesEncryptor.aes, second:  AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length)));
            }
            
            return (System.Byte[])System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Concat<System.Byte>(first:  AvoEx.AesEncryptor.aes, second:  AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length)));
        }
        public static byte[] Decrypt(byte[] buffer)
        {
            var val_6;
            TSource[] val_2 = System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Take<System.Byte>(source:  buffer, count:  16));
            val_6 = null;
            val_6 = null;
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(AvoEx.AesEncryptor.aes != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                AvoEx.AesEncryptor.aes.Dispose();
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  16, inputCount:  buffer.Length - 16);
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  16, inputCount:  buffer.Length - 16);
            }
            
            return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  16, inputCount:  buffer.Length - 16);
        }
        public static byte[] EncryptIV(byte[] buffer, byte[] IV)
        {
            null = null;
            if(AvoEx.AesEncryptor.aes != null)
            {
                    return AvoEx.AesEncryptor.EncryptKeyIV(buffer:  buffer, key:  AvoEx.AesEncryptor.aes, IV:  IV);
            }
            
            return AvoEx.AesEncryptor.EncryptKeyIV(buffer:  buffer, key:  AvoEx.AesEncryptor.aes, IV:  IV);
        }
        public static byte[] DecryptIV(byte[] buffer, byte[] IV)
        {
            null = null;
            if(AvoEx.AesEncryptor.aes != null)
            {
                    return AvoEx.AesEncryptor.DecryptKeyIV(buffer:  buffer, key:  AvoEx.AesEncryptor.aes, IV:  IV);
            }
            
            return AvoEx.AesEncryptor.DecryptKeyIV(buffer:  buffer, key:  AvoEx.AesEncryptor.aes, IV:  IV);
        }
        public static byte[] EncryptKeyIV(byte[] buffer, byte[] key, byte[] IV)
        {
            var val_3 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            if(AvoEx.AesEncryptor.aes != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                AvoEx.AesEncryptor.aes.Dispose();
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length);
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length);
            }
            
            return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length);
        }
        public static byte[] DecryptKeyIV(byte[] buffer, byte[] key, byte[] IV)
        {
            var val_3 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            if(AvoEx.AesEncryptor.aes != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                AvoEx.AesEncryptor.aes.Dispose();
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length);
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length);
            }
            
            return (System.Byte[])AvoEx.AesEncryptor.aes.TransformFinalBlock(inputBuffer:  buffer, inputOffset:  0, inputCount:  buffer.Length);
        }
        public static string Encrypt(string unencrypted)
        {
            null = null;
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  AvoEx.AesEncryptor.encoder.GetBytes(s:  unencrypted)));
        }
        public static string Decrypt(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptString(encrypted:  encrypted);
        }
        public static string DecryptString(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptString(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static string DecryptString(byte[] encrypted)
        {
            if((AvoEx.AesEncryptor.Decrypt(buffer:  encrypted)) == null)
            {
                goto label_3;
            }
            
            label_6:
            AvoEx.AesEncryptor.encoder = ???;
            goto typeof(System.Text.UTF8Encoding).__il2cppRuntimeField_358;
            label_3:
            if(AvoEx.AesEncryptor.encoder != 0)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        public static string EncryptIV(string unencrypted, byte[] vector)
        {
            null = null;
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.EncryptIV(buffer:  AvoEx.AesEncryptor.encoder.GetBytes(s:  unencrypted), IV:  vector));
        }
        public static string DecryptIV(string encrypted, byte[] vector)
        {
            if((AvoEx.AesEncryptor.DecryptIV(buffer:  System.Convert.FromBase64String(s:  encrypted), IV:  vector)) == null)
            {
                goto label_5;
            }
            
            label_8:
            AvoEx.AesEncryptor.encoder = ???;
            goto typeof(System.Text.UTF8Encoding).__il2cppRuntimeField_358;
            label_5:
            if(AvoEx.AesEncryptor.encoder != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        public static string Encrypt(bool unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static bool DecryptBool(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptBool(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static bool DecryptBool(byte[] encrypted)
        {
            return System.BitConverter.ToBoolean(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(char unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static char DecryptChar(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptChar(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static char DecryptChar(byte[] encrypted)
        {
            return System.BitConverter.ToChar(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(double unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static double DecryptDouble(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptDouble(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static double DecryptDouble(byte[] encrypted)
        {
            return System.BitConverter.ToDouble(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(float unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static float DecryptFloat(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptFloat(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static float DecryptFloat(byte[] encrypted)
        {
            return System.BitConverter.ToSingle(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(int unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static int DecryptInt(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptInt(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static int DecryptInt(byte[] encrypted)
        {
            return System.BitConverter.ToInt32(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(long unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static long DecryptLong(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptLong(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static long DecryptLong(byte[] encrypted)
        {
            return System.BitConverter.ToInt64(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(short unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static short DecryptShort(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptShort(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static short DecryptShort(byte[] encrypted)
        {
            return System.BitConverter.ToInt16(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(uint unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static uint DecryptUInt(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptUInt(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static uint DecryptUInt(byte[] encrypted)
        {
            return System.BitConverter.ToUInt32(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(ulong unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static ulong DecryptULong(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptULong(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static ulong DecryptULong(byte[] encrypted)
        {
            return System.BitConverter.ToUInt64(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
        public static string Encrypt(ushort unencrypted)
        {
            return System.Convert.ToBase64String(inArray:  AvoEx.AesEncryptor.Encrypt(buffer:  System.BitConverter.GetBytes(value:  unencrypted)));
        }
        public static ushort DecryptUShort(string encrypted)
        {
            return AvoEx.AesEncryptor.DecryptUShort(encrypted:  System.Convert.FromBase64String(s:  encrypted));
        }
        public static ushort DecryptUShort(byte[] encrypted)
        {
            return System.BitConverter.ToUInt16(value:  AvoEx.AesEncryptor.Decrypt(buffer:  encrypted), startIndex:  0);
        }
    
    }

}
