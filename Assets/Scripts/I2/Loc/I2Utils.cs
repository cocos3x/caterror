using UnityEngine;

namespace I2.Loc
{
    public static class I2Utils
    {
        // Fields
        public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
        public const string NumberChars = "0123456789";
        public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&\',^=<>~`";
        
        // Methods
        public static string ReverseText(string source)
        {
            int val_1 = source.Length;
            char[] val_2 = new char[0];
            if(val_1 < 1)
            {
                    return 0.CreateString(val:  val_2);
            }
            
            var val_5 = 0;
            int val_3 = val_1 - 1;
            do
            {
                val_5 = val_5 + 1;
                val_3 = val_3 - 1;
                val_2[((long)(int)((val_1 - 1))) << 1] = source.Chars[0];
            }
            while(val_1 != val_5);
            
            return 0.CreateString(val:  val_2);
        }
        public static string RemoveNonASCII(string text, bool allowCategory = False)
        {
            var val_10;
            var val_11;
            char val_12;
            var val_13;
            var val_14;
            var val_15;
            if((System.String.IsNullOrEmpty(value:  text)) != false)
            {
                    return (string)text;
            }
            
            int val_2 = text.Length;
            char[] val_3 = new char[0];
            val_10 = 0;
            val_11 = 0;
            goto label_5;
            label_26:
            val_12 = text.Trim().ToCharArray()[0];
            if(allowCategory == false)
            {
                goto label_8;
            }
            
            text.Trim().ToCharArray()[0] = val_12 - 34;
            if(text.Trim().ToCharArray()[0] > (':'))
            {
                goto label_8;
            }
            
            text.Trim().ToCharArray()[0] = 1 << text.Trim().ToCharArray()[0];
            text.Trim().ToCharArray()[0] = text.Trim().ToCharArray()[0] & 288230376151719937;
            if(text.Trim().ToCharArray()[0] != 0)
            {
                goto label_14;
            }
            
            label_8:
            if((System.Char.IsLetterOrDigit(c:  val_12)) != true)
            {
                    val_13 = ".-_$#@*()[]{}+:?!&\',^=<>~`";
                if((".-_$#@*()[]{}+:?!&\',^=<>~`") == null)
            {
                    val_13 = ".-_$#@*()[]{}+:?!&\',^=<>~`";
            }
            
                if(((IndexOf(value:  val_12)) & 2147483648) != 0)
            {
                    val_12 = 32;
            }
            
            }
            
            label_14:
            if((System.Char.IsWhiteSpace(c:  ' ')) == false)
            {
                goto label_17;
            }
            
            var val_9 = (val_11 < 1) ? 1 : 0;
            val_9 = 0 | val_9;
            if((val_9 & 1) == 0)
            {
                goto label_18;
            }
            
            goto label_19;
            label_17:
            val_14 = 1;
            val_15 = 0;
            if(val_11 < val_3.Length)
            {
                goto label_22;
            }
            
            goto label_22;
            label_18:
            val_14 = 1;
            val_15 = 0;
            val_12 = 32;
            label_22:
            val_11 = val_14;
            val_3[0] = val_12;
            label_19:
            val_10 = 1;
            label_5:
            if(val_10 < val_5.Length)
            {
                goto label_26;
            }
            
            return 0.CreateString(val:  val_3, startIndex:  0, length:  1);
        }
        public static string GetValidTermName(string text, bool allowCategory = False)
        {
            if(text == null)
            {
                    return (string)text;
            }
            
            allowCategory = allowCategory;
            return I2.Loc.I2Utils.RemoveNonASCII(text:  I2.Loc.I2Utils.RemoveTags(text:  text), allowCategory:  allowCategory);
        }
        public static string SplitLine(string line, int maxCharacters)
        {
            var val_9;
            var val_10;
            var val_11;
            char val_12;
            var val_13;
            System.Func<System.Char, System.Boolean> val_15;
            if(maxCharacters < 1)
            {
                    return (string)line;
            }
            
            if(line.Length < maxCharacters)
            {
                    return (string)line;
            }
            
            System.Char[] val_2 = line.ToCharArray();
            val_9 = 0;
            val_10 = 0;
            val_11 = 1;
            goto label_23;
            label_29:
            if((val_11 & 1) == 0)
            {
                goto label_6;
            }
            
            val_12 = val_2[0];
            if(((val_12 == '
            ') ? 0 : 1) < maxCharacters)
            {
                goto label_12;
            }
            
            if(val_10 >= val_2.Length)
            {
                    val_12 = mem[val_2[0x0] + 32];
                val_12 = val_2[0x0] + 32;
            }
            
            if((System.Char.IsWhiteSpace(c:  val_12)) == false)
            {
                goto label_12;
            }
            
            val_11 = 0;
            mem2[0] = 10;
            goto label_27;
            label_6:
            if((System.Char.IsWhiteSpace(c:  val_2[0])) == false)
            {
                goto label_18;
            }
            
            if((val_2[0x0] + 32) != 10)
            {
                goto label_20;
            }
            
            if((0 & 1) == 0)
            {
                goto label_21;
            }
            
            goto label_27;
            label_18:
            val_9 = 0;
            label_12:
            val_11 = 1;
            label_27:
            val_10 = 1;
            goto label_23;
            label_20:
            mem2[0] = 0;
            goto label_27;
            label_21:
            mem2[0] = 0;
            goto label_27;
            label_23:
            if(val_10 < val_2.Length)
            {
                goto label_29;
            }
            
            val_13 = null;
            val_13 = null;
            val_15 = I2Utils.<>c.<>9__6_0;
            if(val_15 != null)
            {
                    return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_2, predicate:  System.Func<System.Char, System.Boolean> val_6 = null)));
            }
            
            val_15 = val_6;
            val_6 = new System.Func<System.Char, System.Boolean>(object:  I2Utils.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean I2Utils.<>c::<SplitLine>b__6_0(char c));
            I2Utils.<>c.<>9__6_0 = val_15;
            return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_2, predicate:  val_6)));
        }
        public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
        {
            int val_15 = iStart;
            goto label_0;
            label_20:
            val_15 = val_15 + 1;
            tagEnd = val_15;
            if(val_15 >= W22)
            {
                    return false;
            }
            
            var val_15 = 0;
            label_6:
            char val_1 = line.Chars[val_15];
            char val_2 = val_1 & 65535;
            char val_3 = val_2 - 62;
            if(val_3 > ('?'))
            {
                goto label_3;
            }
            
            val_3 = 1 << val_3;
            val_3 = val_3 & (-9223372034707292159);
            if(val_3 != 0)
            {
                goto label_5;
            }
            
            label_3:
            if(val_2 == ')')
            {
                goto label_5;
            }
            
            val_15 = tagEnd + 1;
            val_15 = val_15 | (((val_1 & 65535) > 'ÿ') ? 1 : 0);
            tagEnd = val_15;
            if(val_15 < W22)
            {
                goto label_6;
            }
            
            return false;
            label_5:
            if((val_15 & 1) == 0)
            {
                    return false;
            }
            
            int val_16 = tagEnd;
            val_15 = val_16 + 1;
            label_0:
            tagStart = 0;
            tagEnd = 0;
            int val_6 = line.Length;
            tagStart = val_15;
            if(val_15 >= val_6)
            {
                goto label_10;
            }
            
            label_19:
            val_16 = line.Chars[val_15] & 65535;
            if((((val_16 == '[') || ((line.Chars[tagStart] & 65535) == '(')) || ((line.Chars[tagStart] & 65535) == '{')) || ((line.Chars[tagStart] & 65535) == ('<')))
            {
                goto label_18;
            }
            
            int val_14 = tagStart + 1;
            tagStart = val_14;
            if(val_14 < val_6)
            {
                goto label_19;
            }
            
            label_18:
            val_15 = tagStart;
            label_10:
            if(val_15 != val_6)
            {
                goto label_20;
            }
            
            return false;
        }
        public static string RemoveTags(string text)
        {
            return System.Text.RegularExpressions.Regex.Replace(input:  text, pattern:  "\\{\\[(.*?)]}|\\[(.*?)]|\\<(.*?)>", replacement:  "");
        }
        public static bool RemoveResourcesPath(ref string sPath)
        {
            int val_16;
            int val_17;
            string val_18;
            int val_19;
            var val_20;
            var val_21;
            string val_22;
            val_16 = sPath.IndexOf(value:  "\\Resources\\");
            int[] val_5 = new int[4];
            val_17 = val_5.Length;
            if(val_17 == 0)
            {
                    val_17 = val_5.Length;
            }
            
            val_5[0] = val_16;
            if(val_17 <= 1)
            {
                    val_17 = val_5.Length;
            }
            
            val_5[0] = sPath.IndexOf(value:  "\\Resources/");
            if(val_17 <= 2)
            {
                    val_17 = val_5.Length;
            }
            
            val_5[1] = sPath.IndexOf(value:  "/Resources\\");
            val_5[1] = sPath.IndexOf(value:  "/Resources/");
            int val_6 = UnityEngine.Mathf.Max(values:  val_5);
            val_18 = sPath;
            if((val_6 & 2147483648) == 0)
            {
                    val_19 = val_6 + 11;
                val_20 = 1;
            }
            else
            {
                    val_21 = null;
                val_21 = null;
                int val_7 = val_18.LastIndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators);
                val_18 = sPath;
                if(val_7 < 1)
            {
                goto label_26;
            }
            
                val_20 = 0;
                val_19 = val_7 + 1;
            }
            
            val_22 = val_18.Substring(startIndex:  val_19);
            sPath = val_22;
            label_26:
            string val_9 = System.IO.Path.GetExtension(path:  val_22);
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                    return (bool)val_20;
            }
            
            val_22 = sPath;
            val_16 = val_22.Length;
            sPath = val_22.Substring(startIndex:  0, length:  val_16 - val_9.Length);
            return (bool)val_20;
        }
        public static bool IsPlaying()
        {
            return UnityEngine.Application.isPlaying;
        }
        public static string GetPath(UnityEngine.Transform tr)
        {
            if(tr != 0)
            {
                    return tr.parent + "/"("/") + tr.name;
            }
            
            if(tr != null)
            {
                    return tr.name;
            }
            
            return tr.name;
        }
        public static UnityEngine.Transform FindObject(string objectPath)
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_1.m_Handle = val_1.m_Handle & 4294967295;
            return I2.Loc.I2Utils.FindObject(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_1.m_Handle}, objectPath:  objectPath);
        }
        public static UnityEngine.Transform FindObject(UnityEngine.SceneManagement.Scene scene, string objectPath)
        {
            var val_12;
            var val_13;
            UnityEngine.Transform val_14;
            val_12;
            val_13 = 0;
            label_9:
            if(val_13 >= (???))
            {
                goto label_2;
            }
            
            val_14 = ???.transform;
            if((System.String.op_Equality(a:  val_14.name, b:  objectPath)) == true)
            {
                    return (UnityEngine.Transform)val_14;
            }
            
            val_13 = val_13 + 1;
            if((objectPath.StartsWith(value:  val_14.name + "/"("/"))) == false)
            {
                goto label_9;
            }
            
            val_12 = val_14.name.Length;
            val_14 = I2.Loc.I2Utils.FindObject(root:  val_14, objectPath:  objectPath.Substring(startIndex:  val_12 + 1));
            return (UnityEngine.Transform)val_14;
            label_2:
            val_14 = 0;
            return (UnityEngine.Transform)val_14;
        }
        public static UnityEngine.Transform FindObject(UnityEngine.Transform root, string objectPath)
        {
            var val_12;
            label_12:
            var val_12 = 0;
            label_8:
            if(val_12 >= root.childCount)
            {
                goto label_2;
            }
            
            val_12 = root.GetChild(index:  0);
            if((System.String.op_Equality(a:  val_12.name, b:  objectPath)) == true)
            {
                    return (UnityEngine.Transform)val_12;
            }
            
            val_12 = val_12 + 1;
            if((objectPath.StartsWith(value:  val_12.name + "/"("/"))) == false)
            {
                goto label_8;
            }
            
            string val_11 = objectPath.Substring(startIndex:  val_12.name.Length + 1);
            goto label_12;
            label_2:
            val_12 = 0;
            return (UnityEngine.Transform)val_12;
        }
        public static H FindInParents<H>(UnityEngine.Transform tr)
        {
            UnityEngine.Object val_5;
            UnityEngine.Object val_6;
            val_5 = tr;
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                    return (object)val_6;
            }
            
            val_6 = val_5;
            goto label_5;
            label_13:
            val_6 = val_5;
            val_5 = val_5.parent;
            label_5:
            if((UnityEngine.Object.op_Implicit(exists:  val_6)) == true)
            {
                    return (object)val_6;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == true)
            {
                goto label_13;
            }
            
            return (object)val_6;
        }
        public static string GetCaptureMatch(System.Text.RegularExpressions.Match match)
        {
            var val_5;
            int val_6;
            val_5 = match;
            val_6 = 0;
            int val_5 = val_5.Count;
            do
            {
                val_5 = val_5 - 1;
                if((val_5 & 2147483648) != 0)
            {
                    return val_5.ToString();
            }
            
            }
            while(val_5.Item[val_5].Success == false);
            
            val_6 = val_5;
            val_5 = val_5.Item[val_6];
            if(val_5 != null)
            {
                    return val_5.ToString();
            }
            
            return val_5.ToString();
        }
        public static void SendWebRequest(UnityEngine.Networking.UnityWebRequest www)
        {
            UnityEngine.Networking.UnityWebRequestAsyncOperation val_1 = www.SendWebRequest();
        }
    
    }

}
