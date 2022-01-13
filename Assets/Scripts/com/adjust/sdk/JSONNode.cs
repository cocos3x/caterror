using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONNode
    {
        // Properties
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual com.adjust.sdk.JSONArray AsArray { get; }
        public virtual com.adjust.sdk.JSONClass AsObject { get; }
        
        // Methods
        public virtual void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            return 0;
        }
        public virtual void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            return 0;
        }
        public virtual void set_Item(string aKey, com.adjust.sdk.JSONNode value)
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
        public virtual void Add(com.adjust.sdk.JSONNode aItem)
        {
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_168;
        }
        public virtual com.adjust.sdk.JSONNode Remove(string aKey)
        {
            return 0;
        }
        public virtual com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            return 0;
        }
        public virtual com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            return (com.adjust.sdk.JSONNode)aNode;
        }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            return (System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>)new JSONNode.<get_Childs>d__17();
        }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_DeepChilds()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>)new JSONNode.<get_DeepChilds>d__19();
        }
        public override string ToString()
        {
            return "JSONNode";
        }
        public virtual string ToString(string aPrefix)
        {
            return "JSONNode";
        }
        public virtual int get_AsInt()
        {
            int val_1 = 0;
            return (int)((System.Int32.TryParse(s:  this, result: out  val_1)) != true) ? (val_1) : 0;
        }
        public virtual void set_AsInt(int value)
        {
            string val_1 = value.ToString();
        }
        public virtual float get_AsFloat()
        {
            return (float)((System.Single.TryParse(s:  this, result: out  float val_1 = -1.550235E+11f)) != true) ? 0 : 0f;
        }
        public virtual void set_AsFloat(float value)
        {
            string val_1 = value.ToString();
        }
        public virtual double get_AsDouble()
        {
            return (double)((System.Double.TryParse(s:  this, result: out  double val_1 = 1.28823199064073E-231)) != true) ? 0 : 0;
        }
        public virtual void set_AsDouble(double value)
        {
            string val_1 = value.ToString();
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
        public virtual com.adjust.sdk.JSONArray get_AsArray()
        {
            var val_2 = 0;
            return (com.adjust.sdk.JSONArray);
        }
        public virtual com.adjust.sdk.JSONClass get_AsObject()
        {
            var val_2 = 0;
            return (com.adjust.sdk.JSONClass);
        }
        public static com.adjust.sdk.JSONNode op_Implicit(string s)
        {
            .m_Data = s;
            return (com.adjust.sdk.JSONNode)new com.adjust.sdk.JSONData();
        }
        public static string op_Implicit(com.adjust.sdk.JSONNode d)
        {
            if((com.adjust.sdk.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0;
            }
            
            if(d == null)
            {
                
            }
        
        }
        public static bool op_Equality(com.adjust.sdk.JSONNode a, object b)
        {
            if(b != null)
            {
                    return (bool)(a == b) ? 1 : 0;
            }
            
            if(a == null)
            {
                    return (bool)(a == b) ? 1 : 0;
            }
            
            return (bool)(a == b) ? 1 : 0;
        }
        public static bool op_Inequality(com.adjust.sdk.JSONNode a, object b)
        {
            bool val_1 = com.adjust.sdk.JSONNode.op_Equality(a:  a, b:  b);
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
            string val_6;
            var val_7;
            string val_8;
            val_6 = "";
            val_7 = 0;
            goto label_1;
            label_14:
            char val_2 = aText.Chars[0] & 65535;
            if((val_2 - 8) > '')
            {
                goto label_3;
            }
            
            var val_6 = 27037956 + (((val_1 & 65535) - 8)) << 2;
            val_6 = val_6 + 27037956;
            goto (27037956 + (((val_1 & 65535) - 8)) << 2 + 27037956);
            label_3:
            if(val_2 == '"')
            {
                goto label_5;
            }
            
            if(val_2 != '\')
            {
                goto label_6;
            }
            
            val_8 = "\\\\";
            goto label_12;
            label_6:
            val_8;
            goto label_12;
            label_5:
            val_8 = "\\\"";
            label_12:
            val_6 = val_6 + val_8;
            val_7 = 1;
            label_1:
            if(val_7 < aText.Length)
            {
                goto label_14;
            }
            
            return (string)val_6;
        }
        public static com.adjust.sdk.JSONNode Parse(string aJSON)
        {
            var val_40;
            var val_41;
            string val_42;
            var val_43;
            var val_44;
            var val_45;
            com.adjust.sdk.JSONNode val_46;
            string val_47;
            var val_48;
            string val_50;
            System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
            val_40 = 1152921504981606400;
            val_41 = 1152921512427878448;
            val_42 = "";
            val_43 = 1152921512427879472;
            val_44 = 0;
            val_45 = 0;
            goto label_1;
            label_87:
            char val_2 = aJSON.Chars[0];
            char val_3 = val_2 & 65535;
            if(val_3 > ',')
            {
                goto label_3;
            }
            
            if(val_3 > ' ')
            {
                goto label_4;
            }
            
            char val_4 = val_2 & 65535;
            if(val_4 > '')
            {
                goto label_5;
            }
            
            if(val_4 == '	')
            {
                goto label_6;
            }
            
            if(val_4 == '
            ')
            {
                goto label_83;
            }
            
            goto label_44;
            label_3:
            if(val_3 > ']')
            {
                goto label_9;
            }
            
            char val_5 = val_2 & 65535;
            if(val_5 > '[')
            {
                goto label_10;
            }
            
            if(val_5 == (':'))
            {
                goto label_11;
            }
            
            if(val_5 != '[')
            {
                goto label_44;
            }
            
            if((val_44 & 1) != 0)
            {
                goto label_45;
            }
            
            com.adjust.sdk.JSONArray val_6 = null;
            val_46 = val_6;
            val_6 = new com.adjust.sdk.JSONArray();
            if(val_1 != null)
            {
                goto label_29;
            }
            
            goto label_15;
            label_4:
            char val_7 = val_2 & 65535;
            if(val_7 == '"')
            {
                goto label_16;
            }
            
            if(val_7 != ',')
            {
                goto label_44;
            }
            
            if((val_44 & 1) != 0)
            {
                goto label_45;
            }
            
            if(((System.String.op_Inequality(a:  val_42, b:  "")) == false) || ((System.String.op_Inequality(a:  val_42, b:  "")) == false))
            {
                goto label_25;
            }
            
            com.adjust.sdk.JSONNode val_10 = com.adjust.sdk.JSONNode.op_Implicit(s:  val_42);
            if(0 != 0)
            {
                goto label_25;
            }
            
            goto label_25;
            label_9:
            char val_11 = val_2 & 65535;
            if(val_11 == '}')
            {
                goto label_26;
            }
            
            if(val_11 != '{')
            {
                goto label_44;
            }
            
            if((val_44 & 1) != 0)
            {
                goto label_45;
            }
            
            com.adjust.sdk.JSONClass val_12 = null;
            val_46 = val_12;
            val_12 = new com.adjust.sdk.JSONClass();
            if(val_1 != null)
            {
                goto label_29;
            }
            
            label_15:
            label_29:
            val_1.Push(item:  val_12);
            if(((com.adjust.sdk.JSONNode.op_Equality(a:  0, b:  0)) == true) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_38;
            }
            
            com.adjust.sdk.JSONNode val_16 = val_1.Peek();
            if(0 != 0)
            {
                goto label_38;
            }
            
            goto label_38;
            label_5:
            if(val_4 == '')
            {
                goto label_83;
            }
            
            if(val_4 != ' ')
            {
                goto label_44;
            }
            
            label_6:
            if((val_44 & 1) != 0)
            {
                goto label_45;
            }
            
            val_44 = 0;
            goto label_83;
            label_10:
            if(val_5 == '\')
            {
                goto label_43;
            }
            
            if(val_5 != ']')
            {
                goto label_44;
            }
            
            label_26:
            if((val_44 & 1) != 0)
            {
                goto label_45;
            }
            
            if(val_1.Count == 0)
            {
                goto label_47;
            }
            
            com.adjust.sdk.JSONNode val_18 = val_1.Pop();
            if(((System.String.op_Inequality(a:  val_42, b:  "")) == false) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_56;
            }
            
            com.adjust.sdk.JSONNode val_22 = com.adjust.sdk.JSONNode.op_Implicit(s:  val_42);
            if(0 != 0)
            {
                goto label_56;
            }
            
            goto label_56;
            label_44:
            string val_24 = val_42 + aJSON.Chars[0];
            goto label_83;
            label_16:
            val_44 = 1;
            goto label_83;
            label_11:
            if((val_44 & 1) == 0)
            {
                goto label_60;
            }
            
            label_45:
            string val_26 = val_42 + aJSON.Chars[0];
            val_44 = 1;
            goto label_83;
            label_43:
            if((val_44 & 1) == 0)
            {
                goto label_63;
            }
            
            char val_28 = aJSON.Chars[1] & 65535;
            if(val_28 > 'f')
            {
                goto label_65;
            }
            
            if(val_28 == 'b')
            {
                goto label_66;
            }
            
            if(val_28 != 'f')
            {
                goto label_71;
            }
            
            val_47 = "\f";
            goto label_82;
            label_60:
            val_44 = 0;
            val_42 = val_42;
            goto label_83;
            label_63:
            val_44 = 0;
            goto label_70;
            label_65:
            val_28 = val_28 - 110;
            if(val_28 > '')
            {
                goto label_71;
            }
            
            var val_40 = 27037924 + (((val_27 & 65535) - 110)) << 2;
            val_40 = val_40 + 27037924;
            goto (27037924 + (((val_27 & 65535) - 110)) << 2 + 27037924);
            label_71:
            val_48;
            goto label_73;
            label_66:
            val_47 = "\b";
            goto label_82;
            label_38:
            val_42 = "";
            if(val_1 != null)
            {
                goto label_81;
            }
            
            goto label_81;
            label_56:
            val_42 = "";
            if((val_1.Count < 1) || (val_1 == null))
            {
                goto label_81;
            }
            
            goto label_81;
            label_82:
            label_73:
            string val_33 = val_42 + ;
            val_44 = 1;
            label_70:
            val_40 = val_41;
            val_41 = "";
            val_43 = 1152921512427879472;
            goto label_83;
            label_25:
            val_42 = "";
            label_81:
            val_44 = 0;
            label_83:
            val_45 = val_45 + 1;
            label_1:
            if(val_45 < aJSON.Length)
            {
                goto label_87;
            }
            
            if((val_44 & 1) != 0)
            {
                goto label_88;
            }
            
            return (com.adjust.sdk.JSONNode)val_1.Peek();
            label_47:
            val_50 = "JSON Parse: Too many closing brackets";
            goto label_89;
            label_88:
            val_50 = "JSON Parse: Quotation marks seems to be messed up.";
            label_89:
            null = new System.Exception(message:  val_50);
        }
        public virtual void Serialize(System.IO.BinaryWriter aWriter)
        {
        
        }
        public void SaveToStream(System.IO.Stream aData)
        {
            System.IO.BinaryWriter val_1 = new System.IO.BinaryWriter(output:  aData);
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_2E8;
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
        public static com.adjust.sdk.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            System.IO.BinaryReader val_1 = aReader & 255;
            if((val_1 - 1) <= 6)
            {
                    var val_13 = 27037980;
                val_13 = (27037980 + (((aReader & 255) - 1)) << 2) + val_13;
            }
            else
            {
                    System.Exception val_12 = new System.Exception(message:  "Error deserializing JSON. Unknown tag: "("Error deserializing JSON. Unknown tag: ") + val_1);
            }
        
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static com.adjust.sdk.JSONNode LoadFromStream(System.IO.Stream aData)
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
                    return (com.adjust.sdk.JSONNode)com.adjust.sdk.JSONNode.Deserialize(aReader:  val_1);
            }
            
            if(0 == 0)
            {
                    return (com.adjust.sdk.JSONNode)com.adjust.sdk.JSONNode.Deserialize(aReader:  val_1);
            }
            
            return (com.adjust.sdk.JSONNode)com.adjust.sdk.JSONNode.Deserialize(aReader:  val_1);
        }
        public static com.adjust.sdk.JSONNode LoadFromBase64(string aBase64)
        {
            System.IO.MemoryStream val_2 = new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  aBase64));
            if(val_2 != null)
            {
                    return com.adjust.sdk.JSONNode.LoadFromStream(aData:  val_2);
            }
            
            return com.adjust.sdk.JSONNode.LoadFromStream(aData:  val_2);
        }
        public JSONNode()
        {
        
        }
    
    }

}
