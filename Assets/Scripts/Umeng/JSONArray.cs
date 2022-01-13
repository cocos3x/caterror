using UnityEngine;

namespace Umeng
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<Umeng.JSONNode> m_List;
        
        // Properties
        public override Umeng.JSONNodeType Tag { get; }
        public override bool IsArray { get; }
        public override Umeng.JSONNode Item { get; set; }
        public override Umeng.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<Umeng.JSONNode> Children { get; }
        
        // Methods
        public override Umeng.JSONNodeType get_Tag()
        {
            return 1;
        }
        public override bool get_IsArray()
        {
            return true;
        }
        public override Umeng.JSONNode get_Item(int aIndex)
        {
            var val_4;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    val_4 = this.m_List.Item[aIndex];
                return (Umeng.JSONNode)val_4;
            }
            
            }
            
            Umeng.JSONLazyCreator val_3 = null;
            val_4 = val_3;
            val_3 = new Umeng.JSONLazyCreator(aNode:  this);
            return (Umeng.JSONNode)val_4;
        }
        public override void set_Item(int aIndex, Umeng.JSONNode value)
        {
            Umeng.JSONNode val_4 = value;
            if((Umeng.JSONNode.op_Equality(a:  val_4 = value, b:  0)) != false)
            {
                    Umeng.JSONNull val_2 = null;
                val_4 = val_2;
                val_2 = new Umeng.JSONNull();
            }
            
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    this.m_List.set_Item(index:  aIndex, value:  val_2);
                return;
            }
            
            }
            
            this.m_List.Add(item:  val_2);
        }
        public override Umeng.JSONNode get_Item(string aKey)
        {
            return (Umeng.JSONNode)new Umeng.JSONLazyCreator(aNode:  this);
        }
        public override void set_Item(string aKey, Umeng.JSONNode value)
        {
            Umeng.JSONNode val_3 = value;
            if((Umeng.JSONNode.op_Equality(a:  val_3 = value, b:  0)) != false)
            {
                    Umeng.JSONNull val_2 = null;
                val_3 = val_2;
                val_2 = new Umeng.JSONNull();
            }
            
            this.m_List.Add(item:  val_2);
        }
        public override int get_Count()
        {
            if(this.m_List != null)
            {
                    return this.m_List.Count;
            }
            
            return this.m_List.Count;
        }
        public override void Add(string aKey, Umeng.JSONNode aItem)
        {
            Umeng.JSONNode val_3 = aItem;
            if((Umeng.JSONNode.op_Equality(a:  val_3 = aItem, b:  0)) != false)
            {
                    Umeng.JSONNull val_2 = null;
                val_3 = val_2;
                val_2 = new Umeng.JSONNull();
            }
            
            this.m_List.Add(item:  val_2);
        }
        public override Umeng.JSONNode Remove(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    val_3 = this.m_List.Item[aIndex];
                this.m_List.RemoveAt(index:  aIndex);
                return (Umeng.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (Umeng.JSONNode)val_3;
        }
        public override Umeng.JSONNode Remove(Umeng.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
            return (Umeng.JSONNode)aNode;
        }
        public override System.Collections.Generic.IEnumerable<Umeng.JSONNode> get_Children()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<Umeng.JSONNode>)new JSONArray.<get_Children>d__17();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONArray.<GetEnumerator>d__18();
        }
        public override string ToString()
        {
            string val_7;
            string val_8;
            string val_9;
            val_7 = "[ ";
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_8:
            if(((-987787240) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.Id;
            val_8 = 0;
            if(Length >= 3)
            {
                goto label_4;
            }
            
            val_9 = val_7;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_8 = ", ";
            val_9 = val_7 + val_8;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            string val_5 = val_9 + val_2;
            goto label_8;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_7 + " ]";
        }
        internal override string ToString(string aIndent, string aPrefix)
        {
            var val_3;
            string val_11;
            string val_12;
            string val_13;
            val_11 = aIndent;
            val_12 = "[ ";
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_23:
            if(((-987617808) & 1) == 0)
            {
                goto label_2;
            }
            
            if(Length < 4)
            {
                    val_13 = val_12;
            }
            else
            {
                    val_13 = val_12 + ", ";
            }
            
            string[] val_7 = new string[5];
            val_7[0] = val_13;
            val_7[1] = "\n";
            val_7[2] = aPrefix;
            val_7[3] = val_11;
            string val_8 = aPrefix + val_11;
            val_7[4] = val_3.Id;
            string val_9 = +val_7;
            goto label_23;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_12 + "\n" + aPrefix + "]";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_4;
            int val_1 = this.m_List.Count;
            val_4 = 0;
            goto label_3;
            label_7:
            Umeng.JSONNode val_2 = this.m_List.Item[0];
            val_4 = 1;
            label_3:
            if(val_4 < this.m_List.Count)
            {
                goto label_7;
            }
        
        }
        public JSONArray()
        {
            this.m_List = new System.Collections.Generic.List<Umeng.JSONNode>();
            this = new System.Object();
        }
    
    }

}
