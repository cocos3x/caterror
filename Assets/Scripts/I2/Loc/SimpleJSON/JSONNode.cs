using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    public class JSONNode
    {
        // Properties
        public virtual I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public virtual I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual I2.Loc.SimpleJSON.JSONArray AsArray { get; }
        public virtual I2.Loc.SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public virtual void Add(string aKey, I2.Loc.SimpleJSON.JSONNode aItem)
        {
        
        }
        public virtual I2.Loc.SimpleJSON.JSONNode get_Item(int aIndex)
        {
            return 0;
        }
        public virtual void set_Item(int aIndex, I2.Loc.SimpleJSON.JSONNode value)
        {
        
        }
        public virtual I2.Loc.SimpleJSON.JSONNode get_Item(string aKey)
        {
            return 0;
        }
        public virtual void set_Item(string aKey, I2.Loc.SimpleJSON.JSONNode value)
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
        public virtual void Add(I2.Loc.SimpleJSON.JSONNode aItem)
        {
            goto typeof(I2.Loc.SimpleJSON.JSONNode).__il2cppRuntimeField_168;
        }
        public virtual I2.Loc.SimpleJSON.JSONNode Remove(string aKey)
        {
            return 0;
        }
        public virtual I2.Loc.SimpleJSON.JSONNode Remove(int aIndex)
        {
            return 0;
        }
        public virtual I2.Loc.SimpleJSON.JSONNode Remove(I2.Loc.SimpleJSON.JSONNode aNode)
        {
            return (I2.Loc.SimpleJSON.JSONNode)aNode;
        }
        public virtual System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> get_Childs()
        {
            return (System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>)new JSONNode.<get_Childs>d__17(<>1__state:  -2);
        }
        public System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> get_DeepChilds()
        {
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>)new JSONNode.<get_DeepChilds>d__19(<>1__state:  -2);
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
            return (float)((System.Single.TryParse(s:  this, result: out  float val_1 = -5.749131E+07f)) != true) ? 0 : 0f;
        }
        public virtual void set_AsFloat(float value)
        {
            string val_1 = value.ToString();
        }
        public virtual double get_AsDouble()
        {
            return (double)((System.Double.TryParse(s:  this, result: out  double val_1 = 1.2882319632513E-231)) != true) ? 0 : 0;
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
        public virtual I2.Loc.SimpleJSON.JSONArray get_AsArray()
        {
            var val_2 = 0;
            return (I2.Loc.SimpleJSON.JSONArray);
        }
        public virtual I2.Loc.SimpleJSON.JSONClass get_AsObject()
        {
            var val_2 = 0;
            return (I2.Loc.SimpleJSON.JSONClass);
        }
        public static I2.Loc.SimpleJSON.JSONNode op_Implicit(string s)
        {
            .m_Data = s;
            return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONData();
        }
        public static string op_Implicit(I2.Loc.SimpleJSON.JSONNode d)
        {
            if((I2.Loc.SimpleJSON.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0;
            }
            
            if(d == null)
            {
                
            }
        
        }
        public static bool op_Equality(I2.Loc.SimpleJSON.JSONNode a, object b)
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
        public static bool op_Inequality(I2.Loc.SimpleJSON.JSONNode a, object b)
        {
            bool val_1 = I2.Loc.SimpleJSON.JSONNode.op_Equality(a:  a, b:  b);
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
            
            var val_6 = 26982848 + (((val_1 & 65535) - 8)) << 2;
            val_6 = val_6 + 26982848;
            goto (26982848 + (((val_1 & 65535) - 8)) << 2 + 26982848);
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
        public static I2.Loc.SimpleJSON.JSONNode Parse(string aJSON)
        {
            var val_40;
            var val_41;
            string val_42;
            var val_43;
            var val_44;
            var val_45;
            I2.Loc.SimpleJSON.JSONNode val_46;
            string val_47;
            var val_48;
            string val_50;
            System.Collections.Generic.Stack<I2.Loc.SimpleJSON.JSONNode> val_1 = new System.Collections.Generic.Stack<I2.Loc.SimpleJSON.JSONNode>();
            val_40 = 1152921504978145280;
            val_41 = 1152921512332126096;
            val_42 = "";
            val_43 = 1152921512332127120;
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
            
            I2.Loc.SimpleJSON.JSONArray val_6 = null;
            val_46 = val_6;
            val_6 = new I2.Loc.SimpleJSON.JSONArray();
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
            
            I2.Loc.SimpleJSON.JSONNode val_10 = I2.Loc.SimpleJSON.JSONNode.op_Implicit(s:  val_42);
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
            
            I2.Loc.SimpleJSON.JSONClass val_12 = null;
            val_46 = val_12;
            val_12 = new I2.Loc.SimpleJSON.JSONClass();
            if(val_1 != null)
            {
                goto label_29;
            }
            
            label_15:
            label_29:
            val_1.Push(item:  val_12);
            if(((I2.Loc.SimpleJSON.JSONNode.op_Equality(a:  0, b:  0)) == true) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_38;
            }
            
            I2.Loc.SimpleJSON.JSONNode val_16 = val_1.Peek();
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
            
            I2.Loc.SimpleJSON.JSONNode val_18 = val_1.Pop();
            if(((System.String.op_Inequality(a:  val_42, b:  "")) == false) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_56;
            }
            
            I2.Loc.SimpleJSON.JSONNode val_22 = I2.Loc.SimpleJSON.JSONNode.op_Implicit(s:  val_42);
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
            
            var val_40 = 26982816 + (((val_27 & 65535) - 110)) << 2;
            val_40 = val_40 + 26982816;
            goto (26982816 + (((val_27 & 65535) - 110)) << 2 + 26982816);
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
            val_43 = 1152921512332127120;
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
            
            return (I2.Loc.SimpleJSON.JSONNode)val_1.Peek();
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
            goto typeof(I2.Loc.SimpleJSON.JSONNode).__il2cppRuntimeField_2E8;
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
        public static I2.Loc.SimpleJSON.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            System.IO.BinaryReader val_1 = aReader & 255;
            if((val_1 - 1) <= 6)
            {
                    var val_13 = 26982872;
                val_13 = (26982872 + (((aReader & 255) - 1)) << 2) + val_13;
            }
            else
            {
                    System.Exception val_12 = new System.Exception(message:  "Error deserializing JSON. Unknown tag: "("Error deserializing JSON. Unknown tag: ") + val_1);
            }
        
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromStream(System.IO.Stream aData)
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
                    return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.Deserialize(aReader:  val_1);
            }
            
            if(0 == 0)
            {
                    return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.Deserialize(aReader:  val_1);
            }
            
            return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.Deserialize(aReader:  val_1);
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromFile(string aFileName)
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
                    return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.LoadFromStream(aData:  val_1);
            }
            
            if(0 == 0)
            {
                    return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.LoadFromStream(aData:  val_1);
            }
            
            return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.LoadFromStream(aData:  val_1);
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromBase64(string aBase64)
        {
            System.IO.MemoryStream val_2 = new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  aBase64));
            if(val_2 != null)
            {
                    return I2.Loc.SimpleJSON.JSONNode.LoadFromStream(aData:  val_2);
            }
            
            return I2.Loc.SimpleJSON.JSONNode.LoadFromStream(aData:  val_2);
        }
        public JSONNode()
        {
        
        }
    
    }

}
