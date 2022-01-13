using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<com.adjust.sdk.JSONNode> m_List;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        
        // Methods
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            var val_4;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    val_4 = this.m_List.Item[aIndex];
                return (com.adjust.sdk.JSONNode)val_4;
            }
            
            }
            
            com.adjust.sdk.JSONLazyCreator val_3 = null;
            val_4 = val_3;
            val_3 = new com.adjust.sdk.JSONLazyCreator();
            .m_Node = this;
            .m_Key = 0;
            return (com.adjust.sdk.JSONNode)val_4;
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    this.m_List.set_Item(index:  aIndex, value:  value);
                return;
            }
            
            }
            
            this.m_List.Add(item:  value);
        }
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            .m_Node = this;
            .m_Key = 0;
            return (com.adjust.sdk.JSONNode)new com.adjust.sdk.JSONLazyCreator();
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            this.m_List.Add(item:  value);
        }
        public override int get_Count()
        {
            if(this.m_List != null)
            {
                    return this.m_List.Count;
            }
            
            return this.m_List.Count;
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            this.m_List.Add(item:  aItem);
        }
        public override com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    val_3 = this.m_List.Item[aIndex];
                this.m_List.RemoveAt(index:  aIndex);
                return (com.adjust.sdk.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (com.adjust.sdk.JSONNode)val_3;
        }
        public override com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
            return (com.adjust.sdk.JSONNode)aNode;
        }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>)new JSONArray.<get_Childs>d__13();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONArray.<GetEnumerator>d__14();
        }
        public override string ToString()
        {
            string val_7;
            string val_8;
            string val_9;
            val_7 = "[ ";
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_8:
            if(((-763434664) & 1) == 0)
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
        public override string ToString(string aPrefix)
        {
            System.Collections.Generic.List<com.adjust.sdk.JSONNode> val_9;
            string val_10;
            string val_11;
            val_9 = this.m_List;
            val_10 = "[ ";
            List.Enumerator<T> val_1 = val_9.GetEnumerator();
            label_6:
            if(((-763269448) & 1) == 0)
            {
                goto label_2;
            }
            
            if(Length >= 4)
            {
                    val_11 = val_10 + ", ";
            }
            
            string val_6 = aPrefix + "   ";
            string val_7 = val_11 + "\n" + aPrefix + "   "(val_11 + "\n" + aPrefix + "   ") + 0.Id;
            goto label_6;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_10 + "\n" + aPrefix + "]";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_4;
            int val_1 = this.m_List.Count;
            val_4 = 0;
            goto label_3;
            label_7:
            com.adjust.sdk.JSONNode val_2 = this.m_List.Item[0];
            val_4 = 1;
            label_3:
            if(val_4 < this.m_List.Count)
            {
                goto label_7;
            }
        
        }
        public JSONArray()
        {
            this.m_List = new System.Collections.Generic.List<com.adjust.sdk.JSONNode>();
            this = new System.Object();
        }
    
    }

}
