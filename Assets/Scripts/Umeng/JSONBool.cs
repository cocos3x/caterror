using UnityEngine;

namespace Umeng
{
    public class JSONBool : JSONNode
    {
        // Fields
        private bool m_Data;
        
        // Properties
        public override Umeng.JSONNodeType Tag { get; }
        public override bool IsBoolean { get; }
        public override string Value { get; set; }
        public override bool AsBool { get; set; }
        
        // Methods
        public override Umeng.JSONNodeType get_Tag()
        {
            return 6;
        }
        public override bool get_IsBoolean()
        {
            return true;
        }
        public override string get_Value()
        {
            return this.m_Data.ToString();
        }
        public override void set_Value(string value)
        {
            if((System.Boolean.TryParse(value:  value, result: out  false)) == false)
            {
                    return;
            }
            
            this.m_Data = false;
        }
        public override bool get_AsBool()
        {
            return (bool)this.m_Data;
        }
        public override void set_AsBool(bool value)
        {
            this.m_Data = value;
        }
        public JSONBool(bool aData)
        {
            this = new System.Object();
            this.m_Data = aData;
        }
        public JSONBool(string aData)
        {
            this = new System.Object();
            goto typeof(Umeng.JSONBool).__il2cppRuntimeField_1B8;
        }
        public override string ToString()
        {
            return (string)(this.m_Data == false) ? "false" : "true";
        }
        internal override string ToString(string aIndent, string aPrefix)
        {
            return (string)(this.m_Data == false) ? "false" : "true";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_1 = (this.m_Data == true) ? 1 : 0;
            goto typeof(System.IO.BinaryWriter).__il2cppRuntimeField_1A8;
        }
    
    }

}
