using UnityEngine;

namespace Umeng
{
    public class JSONNumber : JSONNode
    {
        // Fields
        private double m_Data;
        
        // Properties
        public override Umeng.JSONNodeType Tag { get; }
        public override bool IsNumber { get; }
        public override string Value { get; set; }
        public override double AsDouble { get; set; }
        
        // Methods
        public override Umeng.JSONNodeType get_Tag()
        {
            return 4;
        }
        public override bool get_IsNumber()
        {
            return true;
        }
        public override string get_Value()
        {
            return this.m_Data.ToString();
        }
        public override void set_Value(string value)
        {
            if((System.Double.TryParse(s:  value, result: out  double val_1 = 1.28823193088738E-231)) == false)
            {
                    return;
            }
            
            this.m_Data = 0;
        }
        public override double get_AsDouble()
        {
            return (double)this.m_Data;
        }
        public override void set_AsDouble(double value)
        {
            this.m_Data = value;
        }
        public JSONNumber(double aData)
        {
            this = new System.Object();
            this.m_Data = aData;
        }
        public JSONNumber(string aData)
        {
            this = new System.Object();
            goto typeof(Umeng.JSONNumber).__il2cppRuntimeField_1B8;
        }
        public override string ToString()
        {
            return this.m_Data.ToString();
        }
        internal override string ToString(string aIndent, string aPrefix)
        {
            return this.m_Data.ToString();
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            if(aWriter == null)
            {
                
            }
        
        }
    
    }

}
