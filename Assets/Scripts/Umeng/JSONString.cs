using UnityEngine;

namespace Umeng
{
    public class JSONString : JSONNode
    {
        // Fields
        private string m_Data;
        
        // Properties
        public override Umeng.JSONNodeType Tag { get; }
        public override bool IsString { get; }
        public override string Value { get; set; }
        
        // Methods
        public override Umeng.JSONNodeType get_Tag()
        {
            return 3;
        }
        public override bool get_IsString()
        {
            return true;
        }
        public override string get_Value()
        {
            return (string)this.m_Data;
        }
        public override void set_Value(string value)
        {
            this.m_Data = value;
        }
        public JSONString(string aData)
        {
            this = new System.Object();
            this.m_Data = aData;
        }
        public override string ToString()
        {
            return "\"" + Umeng.JSONNode.Escape(aText:  this.m_Data)(Umeng.JSONNode.Escape(aText:  this.m_Data)) + "\"";
        }
        internal override string ToString(string aIndent, string aPrefix)
        {
            return "\"" + Umeng.JSONNode.Escape(aText:  this.m_Data)(Umeng.JSONNode.Escape(aText:  this.m_Data)) + "\"";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            if(aWriter == null)
            {
                
            }
        
        }
    
    }

}
