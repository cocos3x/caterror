using UnityEngine;

namespace Umeng
{
    public abstract class JSONNode
    {
        // Fields
        internal static System.Text.StringBuilder m_EscapeBuilder;
        
        // Properties
        public virtual Umeng.JSONNode Item { get; set; }
        public virtual Umeng.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual bool IsNumber { get; }
        public virtual bool IsString { get; }
        public virtual bool IsBoolean { get; }
        public virtual bool IsNull { get; }
        public virtual bool IsArray { get; }
        public virtual bool IsObject { get; }
        public virtual System.Collections.Generic.IEnumerable<Umeng.JSONNode> Children { get; }
        public System.Collections.Generic.IEnumerable<Umeng.JSONNode> DeepChildren { get; }
        public abstract Umeng.JSONNodeType Tag { get; }
        public virtual double AsDouble { get; set; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual Umeng.JSONArray AsArray { get; }
        public virtual Umeng.JSONObject AsObject { get; }
        
        // Methods
        public virtual Umeng.JSONNode get_Item(int aIndex)
        {
            return 0;
        }
        public virtual void set_Item(int aIndex, Umeng.JSONNode value)
        {
        
        }
        public virtual Umeng.JSONNode get_Item(string aKey)
        {
            return 0;
        }
        public virtual void set_Item(string aKey, Umeng.JSONNode value)
        {
        
        }
        public virtual string get_Value()
        {
            return "";
        }
        public virtual void set_Value(string value)
        {
        
        }
        public virtual int get_Count()
        {
            return 0;
        }
        public virtual bool get_IsNumber()
        {
            return false;
        }
        public virtual bool get_IsString()
        {
            return false;
        }
        public virtual bool get_IsBoolean()
        {
            return false;
        }
        public virtual bool get_IsNull()
        {
            return false;
        }
        public virtual bool get_IsArray()
        {
            return false;
        }
        public virtual bool get_IsObject()
        {
            return false;
        }
        public virtual void Add(string aKey, Umeng.JSONNode aItem)
        {
        
        }
        public virtual void Add(Umeng.JSONNode aItem)
        {
            goto typeof(Umeng.JSONNode).__il2cppRuntimeField_238;
        }
        public virtual Umeng.JSONNode Remove(string aKey)
        {
            return 0;
        }
        public virtual Umeng.JSONNode Remove(int aIndex)
        {
            return 0;
        }
        public virtual Umeng.JSONNode Remove(Umeng.JSONNode aNode)
        {
            return (Umeng.JSONNode)aNode;
        }
        public virtual System.Collections.Generic.IEnumerable<Umeng.JSONNode> get_Children()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            return (System.Collections.Generic.IEnumerable<Umeng.JSONNode>)new JSONNode.<get_Children>d__29();
        }
        public System.Collections.Generic.IEnumerable<Umeng.JSONNode> get_DeepChildren()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<Umeng.JSONNode>)new JSONNode.<get_DeepChildren>d__31();
        }
        public override string ToString()
        {
            return "JSONNode";
        }
        public virtual string ToString(string aIndent)
        {
            goto typeof(Umeng.JSONNode).__il2cppRuntimeField_2A8;
        }
        internal abstract string ToString(string aIndent, string aPrefix); // 0
        public abstract Umeng.JSONNodeType get_Tag(); // 0
        public virtual double get_AsDouble()
        {
            return (double)((System.Double.TryParse(s:  this, result: out  double val_1 = 1.28823192579834E-231)) != true) ? 0 : 0;
        }
        public virtual void set_AsDouble(double value)
        {
            string val_1 = value.ToString();
        }
        public virtual int get_AsInt()
        {
            return (int)(int)D0;
        }
        public virtual void set_AsInt(int value)
        {
            goto typeof(Umeng.JSONNode).__il2cppRuntimeField_2D8;
        }
        public virtual float get_AsFloat()
        {
            return (float)(float)D0;
        }
        public virtual void set_AsFloat(float value)
        {
            goto typeof(Umeng.JSONNode).__il2cppRuntimeField_2D8;
        }
        public virtual bool get_AsBool()
        {
            var val_6;
            bool val_1 = false;
            if((System.Boolean.TryParse(value:  this, result: out  val_1)) != false)
            {
                    var val_3 = (val_1 != 0) ? 1 : 0;
            }
            else
            {
                    bool val_4 = System.String.IsNullOrEmpty(value:  this);
                val_6 = val_4 ^ 1;
            }
            
            val_4 = val_6;
            return (bool)val_4;
        }
        public virtual void set_AsBool(bool value)
        {
            var val_1 = (value != true) ? "true" : "false";
            if(this == null)
            {
                
            }
        
        }
        public virtual Umeng.JSONArray get_AsArray()
        {
            var val_2 = 0;
            return (Umeng.JSONArray);
        }
        public virtual Umeng.JSONObject get_AsObject()
        {
            var val_2 = 0;
            return (Umeng.JSONObject);
        }
        public static Umeng.JSONNode op_Implicit(string s)
        {
            return (Umeng.JSONNode)new Umeng.JSONString(aData:  s);
        }
        public static string op_Implicit(Umeng.JSONNode d)
        {
            if((Umeng.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0;
            }
            
            if(d == null)
            {
                
            }
        
        }
        public static Umeng.JSONNode op_Implicit(double n)
        {
            return (Umeng.JSONNode)new Umeng.JSONNumber(aData:  n);
        }
        public static double op_Implicit(Umeng.JSONNode d)
        {
            if((Umeng.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0;
            }
            
            if(d == null)
            {
                
            }
        
        }
        public static Umeng.JSONNode op_Implicit(float n)
        {
            return (Umeng.JSONNode)new Umeng.JSONNumber(aData:  (double)n);
        }
        public static float op_Implicit(Umeng.JSONNode d)
        {
            if((Umeng.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0f;
            }
            
            if(d == null)
            {
                
            }
        
        }
        public static Umeng.JSONNode op_Implicit(int n)
        {
            return (Umeng.JSONNode)new Umeng.JSONNumber(aData:  (double)n);
        }
        public static int op_Implicit(Umeng.JSONNode d)
        {
            if((Umeng.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0;
            }
            
            if(d == null)
            {
                
            }
        
        }
        public static Umeng.JSONNode op_Implicit(bool b)
        {
            return (Umeng.JSONNode)new Umeng.JSONBool(aData:  b);
        }
        public static bool op_Implicit(Umeng.JSONNode d)
        {
            if((Umeng.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return false;
            }
            
            if(d == null)
            {
                
            }
        
        }
        public static bool op_Equality(Umeng.JSONNode a, object b)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            if(a == b)
            {
                goto label_1;
            }
            
            if(a == null)
            {
                goto label_2;
            }
            
            val_6 = 0;
            goto label_4;
            label_1:
            val_7 = 1;
            return (bool)(val_9 != ) ? 1 : 0;
            label_2:
            val_8 = 1;
            if(b != null)
            {
                goto label_17;
            }
            
            goto label_13;
            label_4:
            val_8 = 1;
            if(a != null)
            {
                    val_8 = 0;
            }
            
            if(b == null)
            {
                goto label_13;
            }
            
            label_17:
            val_9 = 0;
            return (bool)(val_9 != ) ? 1 : 0;
            label_13:
            val_9 = 1;
            return (bool)(val_9 != ) ? 1 : 0;
        }
        public static bool op_Inequality(Umeng.JSONNode a, object b)
        {
            bool val_1 = Umeng.JSONNode.op_Equality(a:  a, b:  b);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override bool Equals(object obj)
        {
            return (bool)(this == obj) ? 1 : 0;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        internal static string Escape(string aText)
        {
            var val_15;
            System.Text.StringBuilder val_16;
            var val_17;
            var val_18;
            string val_20;
            var val_21;
            var val_22;
            var val_28;
            var val_29;
            val_15 = null;
            val_15 = null;
            Umeng.JSONNode.m_EscapeBuilder.Length = 0;
            if(aText != null)
            {
                    val_16 = aText.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
            int val_4 = aText.Length;
            var val_15 = 0;
            val_15 = val_15 + val_16;
            if(Umeng.JSONNode.m_EscapeBuilder.Capacity < val_15)
            {
                    val_17 = null;
                val_17 = null;
                if(aText != null)
            {
                    val_16 = aText.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
                int val_7 = aText.Length;
                Umeng.JSONNode.m_EscapeBuilder.Capacity = 0 + val_16;
            }
            
            val_18 = 0;
            goto label_13;
            label_50:
            val_16 = aText.Chars[0];
            char val_10 = val_16 & 65535;
            if((val_10 - 8) > '')
            {
                goto label_15;
            }
            
            var val_16 = 27001756 + (((val_9 & 65535) - 8)) << 2;
            val_16 = val_16 + 27001756;
            goto (27001756 + (((val_9 & 65535) - 8)) << 2 + 27001756);
            label_15:
            if(val_10 == '"')
            {
                goto label_20;
            }
            
            if(val_10 != '\')
            {
                goto label_21;
            }
            
            val_21 = null;
            val_21 = null;
            val_16 = Umeng.JSONNode.m_EscapeBuilder;
            val_20 = "\\\\";
            goto label_25;
            label_21:
            val_22 = null;
            val_22 = null;
            System.Text.StringBuilder val_12 = Umeng.JSONNode.m_EscapeBuilder.Append(value:  val_16);
            goto label_29;
            label_20:
            val_28 = null;
            val_28 = null;
            val_16 = Umeng.JSONNode.m_EscapeBuilder;
            val_20 = "\"";
            label_25:
            System.Text.StringBuilder val_13 = val_16.Append(value:  val_20);
            label_29:
            val_18 = 1;
            label_13:
            if(val_18 < aText.Length)
            {
                goto label_50;
            }
            
            val_29 = null;
            val_29 = null;
            Umeng.JSONNode.m_EscapeBuilder.Length = 0;
            return (string)Umeng.JSONNode.m_EscapeBuilder;
        }
        private static void ParseElement(Umeng.JSONNode ctx, string token, string tokenName, bool quoted)
        {
            if(quoted == false)
            {
                goto label_1;
            }
            
            label_16:
            Umeng.JSONNode val_1 = Umeng.JSONNode.op_Implicit(s:  token);
            return;
            label_1:
            string val_2 = token.ToLower();
            if((System.String.op_Equality(a:  val_2, b:  "false")) != true)
            {
                    if((System.String.op_Equality(a:  val_2, b:  "true")) == false)
            {
                goto label_7;
            }
            
            }
            
            Umeng.JSONNode val_7 = Umeng.JSONNode.op_Implicit(b:  System.String.op_Equality(a:  val_2, b:  "true"));
            return;
            label_7:
            if((System.String.op_Equality(a:  val_2, b:  "null")) != false)
            {
                    if(ctx != null)
            {
                    return;
            }
            
                return;
            }
            
            if((System.Double.TryParse(s:  token, result: out  double val_9 = 1.28823192665432E-231)) == false)
            {
                goto label_16;
            }
            
            Umeng.JSONNode val_11 = Umeng.JSONNode.op_Implicit(n:  0);
        }
        public static Umeng.JSONNode Parse(string aJSON)
        {
            var val_32;
            var val_33;
            Umeng.JSONNode val_34;
            string val_35;
            var val_36;
            string val_38;
            System.Collections.Generic.Stack<Umeng.JSONNode> val_1 = new System.Collections.Generic.Stack<Umeng.JSONNode>();
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            var val_32 = 0;
            val_32 = 0;
            val_33 = 0;
            val_34 = 0;
            goto label_75;
            label_92:
            char val_3 = aJSON.Chars[0];
            char val_4 = val_3 & 65535;
            if(val_4 > ',')
            {
                goto label_3;
            }
            
            if(val_4 > ' ')
            {
                goto label_4;
            }
            
            char val_5 = val_3 & 65535;
            if(val_5 > '')
            {
                goto label_5;
            }
            
            if(val_5 == '	')
            {
                goto label_6;
            }
            
            if(val_5 == '
            ')
            {
                goto label_87;
            }
            
            goto label_43;
            label_3:
            if(val_4 > ']')
            {
                goto label_9;
            }
            
            char val_6 = val_3 & 65535;
            if(val_6 > '[')
            {
                goto label_10;
            }
            
            if(val_6 == (':'))
            {
                goto label_11;
            }
            
            if(val_6 != '[')
            {
                goto label_43;
            }
            
            if((val_32 & 1) != 0)
            {
                goto label_44;
            }
            
            Umeng.JSONArray val_7 = null;
            val_35 = val_7;
            val_7 = new Umeng.JSONArray();
            if(val_1 != null)
            {
                goto label_29;
            }
            
            goto label_15;
            label_4:
            char val_8 = val_3 & 65535;
            if(val_8 == '"')
            {
                goto label_16;
            }
            
            if(val_8 != ',')
            {
                goto label_43;
            }
            
            if((val_32 & 1) != 0)
            {
                goto label_44;
            }
            
            if(val_2.Length >= 1)
            {
                    val_35 = val_2;
                Umeng.JSONNode.ParseElement(ctx:  val_34, token:  val_2, tokenName:  "", quoted:  false);
            }
            
            if(val_2 != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_9:
            char val_10 = val_3 & 65535;
            if(val_10 == '}')
            {
                goto label_26;
            }
            
            if(val_10 != '{')
            {
                goto label_43;
            }
            
            if((val_32 & 1) != 0)
            {
                goto label_44;
            }
            
            Umeng.JSONObject val_11 = null;
            val_35 = val_11;
            val_11 = new Umeng.JSONObject();
            if(val_1 != null)
            {
                goto label_29;
            }
            
            label_15:
            label_29:
            val_1.Push(item:  val_11);
            if((Umeng.JSONNode.op_Inequality(a:  val_34, b:  0)) != false)
            {
                    val_35 = val_1.Peek();
            }
            
            val_2.Length = 0;
            if(val_1 != null)
            {
                goto label_56;
            }
            
            goto label_37;
            label_5:
            if(val_5 == '')
            {
                goto label_87;
            }
            
            if(val_5 != ' ')
            {
                goto label_43;
            }
            
            label_6:
            if((val_32 & 1) != 0)
            {
                goto label_44;
            }
            
            goto label_57;
            label_10:
            if(val_6 == '\')
            {
                goto label_42;
            }
            
            if(val_6 != ']')
            {
                goto label_43;
            }
            
            label_26:
            if((val_32 & 1) != 0)
            {
                goto label_44;
            }
            
            if(val_1.Count == 0)
            {
                goto label_46;
            }
            
            Umeng.JSONNode val_15 = val_1.Pop();
            if(val_2.Length >= 1)
            {
                    val_35 = val_2;
                Umeng.JSONNode.ParseElement(ctx:  val_34, token:  val_2, tokenName:  "", quoted:  false);
            }
            
            val_2.Length = 0;
            if(val_1.Count < 1)
            {
                goto label_57;
            }
            
            if(val_1 != null)
            {
                goto label_56;
            }
            
            label_37:
            label_56:
            val_34 = val_1.Peek();
            goto label_57;
            label_43:
            val_35 = aJSON.Chars[0];
            System.Text.StringBuilder val_20 = val_2.Append(value:  val_35);
            goto label_87;
            label_16:
            val_32 = 1;
            val_32 = val_32 | val_32;
            goto label_87;
            label_11:
            if((val_32 & 1) == 0)
            {
                goto label_62;
            }
            
            label_44:
            val_35 = aJSON.Chars[0];
            System.Text.StringBuilder val_22 = val_2.Append(value:  val_35);
            val_32 = 1;
            goto label_87;
            label_42:
            if((val_32 & 1) == 0)
            {
                goto label_87;
            }
            
            char val_23 = aJSON.Chars[1];
            char val_24 = val_23 & 65535;
            if(val_24 > 'f')
            {
                goto label_68;
            }
            
            if(val_24 == 'b')
            {
                goto label_69;
            }
            
            if(val_24 != 'f')
            {
                goto label_77;
            }
            
            val_36 = 12;
            goto label_85;
            label_62:
            string val_25 = val_2.Trim();
            label_25:
            val_2.Length = 0;
            label_57:
            val_32 = 0;
            label_87:
            val_33 = 1;
            goto label_75;
            label_68:
            val_24 = val_24 - 110;
            if(val_24 > '')
            {
                goto label_77;
            }
            
            var val_33 = 27001724 + (((val_23 & 65535) - 110)) << 2;
            val_33 = val_33 + 27001724;
            goto (27001724 + (((val_23 & 65535) - 110)) << 2 + 27001724);
            label_77:
            val_36 = val_23;
            goto label_81;
            label_69:
            val_36 = 8;
            label_85:
            label_81:
            System.Text.StringBuilder val_26 = val_2.Append(value:  '	');
            goto label_87;
            label_75:
            if(val_33 < aJSON.Length)
            {
                goto label_92;
            }
            
            if((val_32 & 1) != 0)
            {
                goto label_93;
            }
            
            return val_34;
            label_46:
            val_38 = "JSON Parse: Too many closing brackets";
            goto label_94;
            label_93:
            val_38 = "JSON Parse: Quotation marks seems to be messed up.";
            label_94:
            null = new System.Exception(message:  val_38);
        }
        public virtual void Serialize(System.IO.BinaryWriter aWriter)
        {
        
        }
        public void SaveToStream(System.IO.Stream aData)
        {
            System.IO.BinaryWriter val_1 = new System.IO.BinaryWriter(output:  aData);
            goto typeof(Umeng.JSONNode).__il2cppRuntimeField_368;
        }
        public void SaveToCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public void SaveToCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public string SaveToCompressedBase64()
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public void SaveToFile(string aFileName)
        {
            System.IO.Stream val_12;
            System.IO.DirectoryInfo val_4 = System.IO.Directory.CreateDirectory(path:  new System.IO.FileInfo(fileName:  aFileName).Directory.FullName);
            val_12 = System.IO.File.OpenWrite(path:  aFileName);
            this.SaveToStream(aData:  val_12);
            if(val_12 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_12.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_12 = ???;
        }
        public string SaveToBase64()
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            this.SaveToStream(aData:  val_1);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            if(0 != 1)
            {
                    return (string)System.Convert.ToBase64String(inArray:  val_1);
            }
            
            if(0 == 0)
            {
                    return (string)System.Convert.ToBase64String(inArray:  val_1);
            }
            
            return (string)System.Convert.ToBase64String(inArray:  val_1);
        }
        public static Umeng.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            System.IO.BinaryReader val_1 = aReader & 255;
            if((val_1 - 1) <= 5)
            {
                    var val_12 = 27001780;
                val_12 = (27001780 + (((aReader & 255) - 1)) << 2) + val_12;
            }
            else
            {
                    System.Exception val_11 = new System.Exception(message:  "Error deserializing JSON. Unknown tag: "("Error deserializing JSON. Unknown tag: ") + val_1);
            }
        
        }
        public static Umeng.JSONNode LoadFromCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static Umeng.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static Umeng.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static Umeng.JSONNode LoadFromStream(System.IO.Stream aData)
        {
            System.IO.BinaryReader val_1 = new System.IO.BinaryReader(input:  aData);
            if(val_1 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (Umeng.JSONNode)Umeng.JSONNode.Deserialize(aReader:  val_1);
            }
            
            if(0 == 0)
            {
                    return (Umeng.JSONNode)Umeng.JSONNode.Deserialize(aReader:  val_1);
            }
            
            return (Umeng.JSONNode)Umeng.JSONNode.Deserialize(aReader:  val_1);
        }
        public static Umeng.JSONNode LoadFromFile(string aFileName)
        {
            System.IO.FileStream val_1 = System.IO.File.OpenRead(path:  aFileName);
            if(val_1 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (Umeng.JSONNode)Umeng.JSONNode.LoadFromStream(aData:  val_1);
            }
            
            if(0 == 0)
            {
                    return (Umeng.JSONNode)Umeng.JSONNode.LoadFromStream(aData:  val_1);
            }
            
            return (Umeng.JSONNode)Umeng.JSONNode.LoadFromStream(aData:  val_1);
        }
        public static Umeng.JSONNode LoadFromBase64(string aBase64)
        {
            return Umeng.JSONNode.LoadFromStream(aData:  new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  aBase64)));
        }
        protected JSONNode()
        {
        
        }
        private static JSONNode()
        {
            Umeng.JSONNode.m_EscapeBuilder = new System.Text.StringBuilder();
        }
    
    }

}
