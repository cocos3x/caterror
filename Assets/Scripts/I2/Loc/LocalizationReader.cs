using UnityEngine;

namespace I2.Loc
{
    public class LocalizationReader
    {
        // Methods
        public static System.Collections.Generic.Dictionary<string, string> ReadTextAsset(UnityEngine.TextAsset asset)
        {
            var val_18;
            System.Collections.Generic.IEqualityComparer<TKey> val_19;
            System.Collections.Generic.IEqualityComparer<TKey> val_20;
            string val_10 = 0;
            string val_11 = 0;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            if(asset != null)
            {
                    val_18 = asset.bytes;
            }
            else
            {
                    val_18 = 0.bytes;
            }
            
            if(asset.bytes == null)
            {
                goto label_3;
            }
            
            label_17:
            val_19 = System.StringComparer.Ordinal;
            System.Collections.Generic.Dictionary<System.String, System.String> val_9 = null;
            val_20 = val_19;
            val_9 = new System.Collections.Generic.Dictionary<System.String, System.String>(comparer:  val_20);
            goto label_12;
            label_15:
            if((I2.Loc.LocalizationReader.TextAsset_ReadLine(line:  val_9, key: out  val_10, value: out  val_11, category: out  0, comment: out  0, termType: out  0)) != false)
            {
                    val_19 = val_10;
                val_20 = 0;
                if((System.String.IsNullOrEmpty(value:  val_19)) != true)
            {
                    val_20 = 0;
                if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    val_20 = val_19;
                val_9.set_Item(key:  val_20, value:  val_11);
            }
            
            }
            
            }
            
            label_12:
            if((new System.IO.StringReader(s:  val_1.Replace(oldValue:  "\r\n", newValue:  "\n").Replace(oldValue:  "\r", newValue:  "\n"))) != null)
            {
                goto label_15;
            }
            
            return val_9;
            label_3:
            if(val_1 != null)
            {
                goto label_17;
            }
            
            goto label_17;
        }
        public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
        {
            string val_24;
            var val_25;
            int val_26;
            var val_27;
            val_24 = 1152921512269673232;
            val_25 = line;
            key = System.String.alignConst;
            category = System.String.alignConst;
            comment = System.String.alignConst;
            termType = System.String.alignConst;
            value = System.String.alignConst;
            string val_24 = "//";
            int val_1 = val_25.LastIndexOf(value:  val_24);
            if((val_1 & 2147483648) == 0)
            {
                    val_24 = val_1 + 2;
                string val_3 = val_25.Substring(startIndex:  val_24).Trim();
                comment = val_3;
                comment = I2.Loc.LocalizationReader.DecodeString(str:  val_3);
                val_25 = val_25.Substring(startIndex:  0, length:  val_1);
            }
            
            val_26 = val_25.IndexOf(value:  "=");
            if((val_26 & 2147483648) == 0)
            {
                    key = val_25.Substring(startIndex:  0, length:  val_26).Trim();
                string val_11 = val_25.Substring(startIndex:  val_26 + 1).Trim();
                value = val_11;
                val_26 = "\n";
                string val_13 = val_11.Replace(oldValue:  "\r\n", newValue:  "\n").Replace(oldValue:  "\n", newValue:  "\\n");
                value = val_13;
                value = I2.Loc.LocalizationReader.DecodeString(str:  val_13);
                val_24 = key;
                if(val_24.Length >= 3)
            {
                    val_24 = key;
                if((val_24.Chars[0] & 65535) == '[')
            {
                    val_24 = key.IndexOf(value:  ']');
                if((val_24 & 2147483648) == 0)
            {
                    termType = key.Substring(startIndex:  1, length:  val_24 - 1);
                key = key.Substring(startIndex:  val_24 + 1);
            }
            
            }
            
            }
            
                I2.Loc.LocalizationReader.ValidateFullTerm(Term: ref  string val_23 = key);
                val_27 = 1;
                return (bool)val_27;
            }
            
            val_27 = 0;
            return (bool)val_27;
        }
        public static string ReadCSVfile(string Path, System.Text.Encoding encoding)
        {
            System.IO.StreamReader val_1 = new System.IO.StreamReader(path:  Path, encoding:  encoding);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            string val_3 = val_1.Replace(oldValue:  "\r\n", newValue:  "\n");
            if(val_3 != null)
            {
                    return val_3.Replace(oldValue:  "\r", newValue:  "\n");
            }
            
            return val_3.Replace(oldValue:  "\r", newValue:  "\n");
        }
        public static System.Collections.Generic.List<string[]> ReadCSV(string Text, char Separator = '\x2c')
        {
            var val_5;
            int val_2 = 0;
            System.Collections.Generic.List<System.String[]> val_1 = new System.Collections.Generic.List<System.String[]>();
            val_5 = 0;
            goto label_1;
            label_5:
            System.String[] val_3 = I2.Loc.LocalizationReader.ParseCSVline(Line:  Text, iStart: ref  val_2, Separator:  Separator);
            if(val_3 == null)
            {
                    return val_1;
            }
            
            val_1.Add(item:  val_3);
            val_5 = val_2;
            label_1:
            if(0 < Text.Length)
            {
                goto label_5;
            }
            
            return val_1;
        }
        private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
        {
            int val_17;
            int val_18;
            string val_12 = Line;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            int val_2 = Line.Length;
            val_17 = iStart;
            int val_13 = val_17;
            if(val_17 >= val_2)
            {
                goto label_19;
            }
            
            label_18:
            char val_3 = Line.Chars[val_17];
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            if((val_3 & 65535) != '"')
            {
                goto label_5;
            }
            
            int val_15 = iStart;
            int val_5 = val_15 + 1;
            if(val_5 >= val_2)
            {
                goto label_17;
            }
            
            val_15 = Line.Chars[val_5] & 65535;
            if(val_15 != '"')
            {
                goto label_17;
            }
            
            val_18 = iStart;
            int val_7 = val_18 + 2;
            if(val_7 >= val_2)
            {
                goto label_11;
            }
            
            val_18 = iStart;
            if((Line.Chars[val_7] & 65535) != '"')
            {
                goto label_11;
            }
            
            val_18 = val_18 + 2;
            iStart = val_18;
            goto label_17;
            label_4:
            val_17 = val_3 & 65535;
            if((val_17 == '
            ') || (val_17 == Separator))
            {
                goto label_14;
            }
            
            var val_11 = ((val_3 & 65535) == '"') ? 1 : 0;
            goto label_17;
            label_14:
            I2.Loc.LocalizationReader.AddCSVtoken(list: ref  val_1, Line: ref  val_12, iEnd:  iStart, iWordStart: ref  val_13);
            if(val_17 == '
            ')
            {
                goto label_16;
            }
            
            goto label_17;
            label_11:
            val_18 = val_18 + 1;
            iStart = val_18;
            label_5:
            label_17:
            val_17 = iStart + 1;
            iStart = val_17;
            if(val_17 < val_2)
            {
                goto label_18;
            }
            
            goto label_19;
            label_16:
            val_17 = iStart + 1;
            iStart = val_17;
            label_19:
            if(val_17 <= val_13)
            {
                    return (System.String[])val_1.ToArray();
            }
            
            I2.Loc.LocalizationReader.AddCSVtoken(list: ref  val_1, Line: ref  val_12, iEnd:  val_17, iWordStart: ref  val_13);
            return (System.String[])val_1.ToArray();
        }
        private static void AddCSVtoken(ref System.Collections.Generic.List<string> list, ref string Line, int iEnd, ref int iWordStart)
        {
            var val_16;
            string val_17;
            val_16 = iEnd;
            iEnd = val_16 - iWordStart;
            iWordStart = val_16 + 1;
            val_17 = Line.Substring(startIndex:  iWordStart, length:  iEnd).Replace(oldValue:  "\"\"", newValue:  "\"");
            if((val_17.Length >= 2) && ((val_17.Chars[0] & 65535) == '"'))
            {
                    if(val_17 != null)
            {
                    val_16 = val_17.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
                if(((val_17.Chars[val_16 - 1]) & 65535) == '"')
            {
                    if(val_17 != null)
            {
                    val_16 = val_17.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
                val_17 = val_17.Substring(startIndex:  1, length:  val_16 - 2);
            }
            
            }
            
            list.Add(item:  val_17);
        }
        public static System.Collections.Generic.List<string[]> ReadI2CSV(string Text)
        {
            var val_6;
            string[] val_1 = new string[1];
            val_1[0] = "[*]";
            string[] val_2 = new string[1];
            val_2[0] = "[ln]";
            System.Collections.Generic.List<System.String[]> val_3 = new System.Collections.Generic.List<System.String[]>();
            val_6 = 0;
            goto label_10;
            label_15:
            val_3.Add(item:  Text.Split(separator:  val_2, options:  0)[0].Split(separator:  val_1, options:  0));
            val_6 = 1;
            label_10:
            if(val_6 < val_4.Length)
            {
                goto label_15;
            }
            
            return val_3;
        }
        public static void ValidateFullTerm(ref string Term)
        {
            string val_5;
            string val_1 = Term.Replace(oldChar:  '\', newChar:  '/');
            Term = val_1;
            int val_2 = val_1.IndexOf(value:  '/');
            if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
            val_5 = Term;
            goto label_3;
            label_6:
            val_5 = Term.Remove(startIndex:  val_5, count:  1);
            Term = val_5;
            label_3:
            if((val_5.LastIndexOf(value:  '/')) != val_2)
            {
                goto label_6;
            }
        
        }
        public static string EncodeString(string str)
        {
            if((System.String.IsNullOrEmpty(value:  str)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            string val_3 = str.Replace(oldValue:  "\r\n", newValue:  "<\\n>").Replace(oldValue:  "\r", newValue:  "<\\n>");
            if(val_3 != null)
            {
                    return val_3.Replace(oldValue:  "\n", newValue:  "<\\n>");
            }
            
            return val_3.Replace(oldValue:  "\n", newValue:  "<\\n>");
        }
        public static string DecodeString(string str)
        {
            if((System.String.IsNullOrEmpty(value:  str)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            if(str != null)
            {
                    return str.Replace(oldValue:  "<\\n>", newValue:  "\r\n");
            }
            
            return str.Replace(oldValue:  "<\\n>", newValue:  "\r\n");
        }
        public LocalizationReader()
        {
        
        }
    
    }

}
