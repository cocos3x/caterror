using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONClass : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, com.adjust.sdk.JSONNode> m_Dict;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        
        // Methods
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    if(this.m_Dict != null)
            {
                    return this.m_Dict.Item[aKey];
            }
            
                return this.m_Dict.Item[aKey];
            }
            
            .m_Node = this;
            .m_Key = aKey;
            return (com.adjust.sdk.JSONNode)new com.adjust.sdk.JSONLazyCreator();
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            bool val_1 = this.m_Dict.ContainsKey(key:  aKey);
            if(this.m_Dict == null)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                goto label_3;
            }
            
            label_4:
            this.m_Dict.set_Item(key:  aKey, value:  value);
            return;
            label_2:
            if(val_1 == true)
            {
                goto label_4;
            }
            
            label_3:
            this.m_Dict.Add(key:  aKey, value:  value);
        }
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_3;
                return (com.adjust.sdk.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (com.adjust.sdk.JSONNode)val_3;
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            int val_4 = aIndex;
            if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= val_4)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, index:  val_4 = aIndex);
            val_4 = this.m_Dict;
            val_4.set_Item(key:  val_2.Value.Id, value:  value);
        }
        public override int get_Count()
        {
            if(this.m_Dict != null)
            {
                    return this.m_Dict.Count;
            }
            
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            string val_4;
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_5;
            val_4 = aKey;
            val_5 = this.m_Dict;
            if((System.String.IsNullOrEmpty(value:  val_4)) == false)
            {
                goto label_1;
            }
            
            System.Guid val_2 = System.Guid.NewGuid();
            val_4 = ;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_1:
            bool val_3 = val_5.ContainsKey(key:  val_4);
            val_5 = this.m_Dict;
            if(val_5 == null)
            {
                goto label_7;
            }
            
            if(val_3 == false)
            {
                goto label_8;
            }
            
            label_10:
            val_5.set_Item(key:  val_4, value:  aItem);
            return;
            label_7:
            if(val_3 == true)
            {
                goto label_10;
            }
            
            label_8:
            val_5.Add(key:  val_4, value:  aItem);
        }
        public override com.adjust.sdk.JSONNode Remove(string aKey)
        {
            var val_4;
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    val_4 = this.m_Dict.Item[aKey];
                bool val_3 = this.m_Dict.Remove(key:  aKey);
                return (com.adjust.sdk.JSONNode)val_4;
            }
            
            val_4 = 0;
            return (com.adjust.sdk.JSONNode)val_4;
        }
        public override com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_5;
            var val_6;
            val_5 = this;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_5 = this.m_Dict;
                bool val_4 = val_5.Remove(key:  val_2.Value.Id);
                val_6;
                return (com.adjust.sdk.JSONNode)val_6;
            }
            
            }
            
            val_6 = 0;
            return (com.adjust.sdk.JSONNode)val_6;
        }
        public override com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            .aNode = aNode;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>, System.Boolean>(object:  new JSONClass.<>c__DisplayClass12_0(), method:  System.Boolean JSONClass.<>c__DisplayClass12_0::<Remove>b__0(System.Collections.Generic.KeyValuePair<string, com.adjust.sdk.JSONNode> k));
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, predicate:  null));
            bool val_6 = this.m_Dict.Remove(key:  val_4.Value.Id);
            return (com.adjust.sdk.JSONNode)(JSONClass.<>c__DisplayClass12_0)[1152921512437067664].aNode;
        }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>)new JSONClass.<get_Childs>d__14();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONClass.<GetEnumerator>d__15();
        }
        public override string ToString()
        {
            var val_4;
            string val_13;
            string val_14;
            string val_15;
            val_13 = "{";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_23:
            val_14 = val_13;
            if(((-759344176) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_5 = val_4.Current;
            if(Length < 3)
            {
                    val_15 = val_13;
            }
            else
            {
                    val_15 = val_13 + ", ";
            }
            
            string[] val_8 = new string[5];
            val_8[0] = val_15;
            val_8[1] = "\"";
            val_8[2] = com.adjust.sdk.JSONNode.Escape(aText:  val_5.Value.Id);
            val_8[3] = "\":";
            val_8[4] = ;
            string val_11 = +val_8;
            goto label_23;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_13 + "}";
        }
        public override string ToString(string aPrefix)
        {
            var val_4;
            string val_15;
            string val_16;
            string val_17;
            string val_18;
            string val_20;
            val_15 = aPrefix;
            val_16 = "{ ";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            val_17 = "\n";
            label_22:
            if(((-759162448) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_5 = val_4.Current;
            if(Length >= 4)
            {
                    val_18 = val_16 + ", ";
            }
            
            string[] val_9 = new string[5];
            val_9[0] = val_18 + "\n" + val_15 + "   ";
            val_9[1] = "\"";
            val_9[2] = com.adjust.sdk.JSONNode.Escape(aText:  val_5.Value.Id);
            val_9[3] = "\" : ";
            string val_12 = val_15 + "   ";
            val_9[4] = ;
            string val_13 = +val_9;
            goto label_22;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_20 + val_17 + val_15 + "}";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.m_Dict.Keys.GetEnumerator();
            label_8:
            if(((-758975608) & 1) == 0)
            {
                goto label_5;
            }
            
            if(this.m_Dict.Item[0.Id] != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_5:
            UniRx.Unit..cctor();
        }
        public JSONClass()
        {
            this.m_Dict = new System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode>();
            this = new System.Object();
        }
    
    }

}
