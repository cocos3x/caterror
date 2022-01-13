using UnityEngine;

namespace Umeng
{
    internal class JSONLazyCreator : JSONNode
    {
        // Fields
        private Umeng.JSONNode m_Node;
        private string m_Key;
        
        // Properties
        public override Umeng.JSONNodeType Tag { get; }
        public override Umeng.JSONNode Item { get; set; }
        public override Umeng.JSONNode Item { get; set; }
        public override int AsInt { get; set; }
        public override float AsFloat { get; set; }
        public override double AsDouble { get; set; }
        public override bool AsBool { get; set; }
        public override Umeng.JSONArray AsArray { get; }
        public override Umeng.JSONObject AsObject { get; }
        
        // Methods
        public override Umeng.JSONNodeType get_Tag()
        {
            return 7;
        }
        public JSONLazyCreator(Umeng.JSONNode aNode)
        {
            this = new System.Object();
            this.m_Node = aNode;
            this.m_Key = 0;
        }
        public JSONLazyCreator(Umeng.JSONNode aNode, string aKey)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = val_1;
        }
        private void Set(Umeng.JSONNode aVal)
        {
            if(this.m_Key != null)
            {
                    if(this.m_Node != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            this.m_Node = 0;
        }
        public override Umeng.JSONNode get_Item(int aIndex)
        {
            return (Umeng.JSONNode)new Umeng.JSONLazyCreator(aNode:  this);
        }
        public override void set_Item(int aIndex, Umeng.JSONNode value)
        {
            Umeng.JSONArray val_1 = new Umeng.JSONArray();
            val_1.Add(aItem:  value);
            this.Set(aVal:  val_1);
        }
        public override Umeng.JSONNode get_Item(string aKey)
        {
            return (Umeng.JSONNode)new Umeng.JSONLazyCreator(aNode:  this, aKey:  aKey);
        }
        public override void set_Item(string aKey, Umeng.JSONNode value)
        {
            this.Set(aVal:  new Umeng.JSONObject());
        }
        public override void Add(Umeng.JSONNode aItem)
        {
            Umeng.JSONArray val_1 = new Umeng.JSONArray();
            val_1.Add(aItem:  aItem);
            this.Set(aVal:  val_1);
        }
        public override void Add(string aKey, Umeng.JSONNode aItem)
        {
            this.Set(aVal:  new Umeng.JSONObject());
        }
        public static bool op_Equality(Umeng.JSONLazyCreator a, object b)
        {
            a = ((b == 0) ? 1 : 0) | ((a == b) ? 1 : 0);
            return (bool)a;
        }
        public static bool op_Inequality(Umeng.JSONLazyCreator a, object b)
        {
            a = ((a != b) ? 1 : 0) & ((b != 0) ? 1 : 0);
            return (bool)a;
        }
        public override bool Equals(object obj)
        {
            this = ((obj == 0) ? 1 : 0) | ((this == obj) ? 1 : 0);
            return (bool)this;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override string ToString()
        {
            return "";
        }
        internal override string ToString(string aIndent, string aPrefix)
        {
            return "";
        }
        public override int get_AsInt()
        {
            this.Set(aVal:  new Umeng.JSONNumber(aData:  0));
            return 0;
        }
        public override void set_AsInt(int value)
        {
            this.Set(aVal:  new Umeng.JSONNumber(aData:  (double)value));
        }
        public override float get_AsFloat()
        {
            this.Set(aVal:  new Umeng.JSONNumber(aData:  0));
            return 0f;
        }
        public override void set_AsFloat(float value)
        {
            this.Set(aVal:  new Umeng.JSONNumber(aData:  (double)value));
        }
        public override double get_AsDouble()
        {
            this.Set(aVal:  new Umeng.JSONNumber(aData:  0));
            return 0;
        }
        public override void set_AsDouble(double value)
        {
            this.Set(aVal:  new Umeng.JSONNumber(aData:  value));
        }
        public override bool get_AsBool()
        {
            this.Set(aVal:  new Umeng.JSONBool(aData:  false));
            return false;
        }
        public override void set_AsBool(bool value)
        {
            Umeng.JSONBool val_1 = null;
            value = value;
            val_1 = new Umeng.JSONBool(aData:  value);
            this.Set(aVal:  val_1);
        }
        public override Umeng.JSONArray get_AsArray()
        {
            Umeng.JSONArray val_1 = new Umeng.JSONArray();
            this.Set(aVal:  val_1);
            return val_1;
        }
        public override Umeng.JSONObject get_AsObject()
        {
            Umeng.JSONObject val_1 = 12481;
            val_1 = new Umeng.JSONObject();
            this.Set(aVal:  val_1);
            return val_1;
        }
    
    }

}
