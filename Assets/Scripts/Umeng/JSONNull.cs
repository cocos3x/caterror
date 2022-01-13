using UnityEngine;

namespace Umeng
{
    public class JSONNull : JSONNode
    {
        // Properties
        public override Umeng.JSONNodeType Tag { get; }
        public override bool IsNull { get; }
        public override string Value { get; set; }
        public override bool AsBool { get; set; }
        
        // Methods
        public override Umeng.JSONNodeType get_Tag()
        {
            return 5;
        }
        public override bool get_IsNull()
        {
            return true;
        }
        public override string get_Value()
        {
            return "null";
        }
        public override void set_Value(string value)
        {
        
        }
        public override bool get_AsBool()
        {
            return false;
        }
        public override void set_AsBool(bool value)
        {
        
        }
        public override string ToString()
        {
            return "null";
        }
        internal override string ToString(string aIndent, string aPrefix)
        {
            return "null";
        }
        public override bool Equals(object obj)
        {
            var val_2;
            if(this != obj)
            {
                    val_2 = 0;
                return (bool);
            }
            
            val_2 = 1;
            return (bool);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            if(aWriter == null)
            {
                
            }
        
        }
        public JSONNull()
        {
            this = new System.Object();
        }
    
    }

}
