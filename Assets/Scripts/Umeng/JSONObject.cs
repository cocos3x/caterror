using UnityEngine;

namespace Umeng
{
    public class JSONObject : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, Umeng.JSONNode> m_Dict;
        
        // Properties
        public override Umeng.JSONNodeType Tag { get; }
        public override bool IsObject { get; }
        public override Umeng.JSONNode Item { get; set; }
        public override Umeng.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<Umeng.JSONNode> Children { get; }
        
        // Methods
        public override Umeng.JSONNodeType get_Tag()
        {
            return 2;
        }
        public override bool get_IsObject()
        {
            return true;
        }
        public override Umeng.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) == false)
            {
                    return (Umeng.JSONNode)new Umeng.JSONLazyCreator(aNode:  this, aKey:  aKey);
            }
            
            if(this.m_Dict != null)
            {
                    return this.m_Dict.Item[aKey];
            }
            
            return this.m_Dict.Item[aKey];
        }
        public override void set_Item(string aKey, Umeng.JSONNode value)
        {
            Umeng.JSONNode val_4 = value;
            if((Umeng.JSONNode.op_Equality(a:  val_4 = value, b:  0)) != false)
            {
                    Umeng.JSONNull val_2 = null;
                val_4 = val_2;
                val_2 = new Umeng.JSONNull();
            }
            
            bool val_3 = this.m_Dict.ContainsKey(key:  aKey);
            if(this.m_Dict == null)
            {
                goto label_5;
            }
            
            if(val_3 == false)
            {
                goto label_6;
            }
            
            label_7:
            this.m_Dict.set_Item(key:  aKey, value:  val_2);
            return;
            label_5:
            if(val_3 == true)
            {
                goto label_7;
            }
            
            label_6:
            this.m_Dict.Add(key:  aKey, value:  val_2);
        }
        public override Umeng.JSONNode get_Item(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_3;
                return (Umeng.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (Umeng.JSONNode)val_3;
        }
        public override void set_Item(int aIndex, Umeng.JSONNode value)
        {
            Umeng.JSONNode val_6;
            int val_7;
            val_6 = value;
            val_7 = aIndex;
            if((Umeng.JSONNode.op_Equality(a:  val_6, b:  0)) != false)
            {
                    Umeng.JSONNull val_2 = null;
                val_6 = val_2;
                val_2 = new Umeng.JSONNull();
            }
            
            if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= val_7)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode> val_4 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode>>(source:  this.m_Dict, index:  val_7);
            val_7 = this.m_Dict;
            val_7.set_Item(key:  val_4.Value.Id, value:  val_2);
        }
        public override int get_Count()
        {
            if(this.m_Dict != null)
            {
                    return this.m_Dict.Count;
            }
            
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, Umeng.JSONNode aItem)
        {
            Umeng.JSONNode val_6;
            string val_7;
            System.Collections.Generic.Dictionary<System.String, Umeng.JSONNode> val_8;
            var val_9;
            val_6 = aItem;
            val_7 = aKey;
            val_8 = this;
            if((Umeng.JSONNode.op_Equality(a:  val_6, b:  0)) != false)
            {
                    Umeng.JSONNull val_2 = null;
                val_6 = val_2;
                val_2 = new Umeng.JSONNull();
            }
            
            if((System.String.IsNullOrEmpty(value:  val_7)) == false)
            {
                goto label_4;
            }
            
            System.Guid val_4 = System.Guid.NewGuid();
            val_7 = ;
            val_9 = 1152921512211876032;
            goto label_8;
            label_4:
            bool val_5 = this.m_Dict.ContainsKey(key:  val_7);
            val_8 = this.m_Dict;
            if(val_8 == null)
            {
                goto label_10;
            }
            
            if(val_5 == false)
            {
                goto label_11;
            }
            
            label_13:
            val_8.set_Item(key:  val_7, value:  val_2);
            return;
            label_10:
            if(val_5 == true)
            {
                goto label_13;
            }
            
            label_11:
            val_9 = 1152921512211876032;
            label_8:
            val_8.Add(key:  val_7, value:  val_2);
        }
        public override Umeng.JSONNode Remove(string aKey)
        {
            var val_4;
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    val_4 = this.m_Dict.Item[aKey];
                bool val_3 = this.m_Dict.Remove(key:  aKey);
                return (Umeng.JSONNode)val_4;
            }
            
            val_4 = 0;
            return (Umeng.JSONNode)val_4;
        }
        public override Umeng.JSONNode Remove(int aIndex)
        {
            System.Collections.Generic.Dictionary<System.String, Umeng.JSONNode> val_5;
            var val_6;
            val_5 = this;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_5 = this.m_Dict;
                bool val_4 = val_5.Remove(key:  val_2.Value.Id);
                val_6;
                return (Umeng.JSONNode)val_6;
            }
            
            }
            
            val_6 = 0;
            return (Umeng.JSONNode)val_6;
        }
        public override Umeng.JSONNode Remove(Umeng.JSONNode aNode)
        {
            .aNode = aNode;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode>, System.Boolean>(object:  new JSONObject.<>c__DisplayClass16_0(), method:  System.Boolean JSONObject.<>c__DisplayClass16_0::<Remove>b__0(System.Collections.Generic.KeyValuePair<string, Umeng.JSONNode> k));
            System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, Umeng.JSONNode>>(source:  this.m_Dict, predicate:  null));
            bool val_6 = this.m_Dict.Remove(key:  val_4.Value.Id);
            return (Umeng.JSONNode)(JSONObject.<>c__DisplayClass16_0)[1152921512212969984].aNode;
        }
        public override System.Collections.Generic.IEnumerable<Umeng.JSONNode> get_Children()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<Umeng.JSONNode>)new JSONObject.<get_Children>d__18();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONObject.<GetEnumerator>d__19();
        }
        public override string ToString()
        {
            var val_4;
            string val_13;
            string val_14;
            string val_15;
            val_13 = "{";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_25:
            val_14 = val_13;
            if(((-983441696) & 1) == 0)
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
            val_8[2] = Umeng.JSONNode.Escape(aText:  val_5.Value.Id);
            val_8[3] = "\":";
            val_8[4] = ;
            string val_11 = +val_8;
            goto label_25;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_13 + "}";
        }
        internal override string ToString(string aIndent, string aPrefix)
        {
            var val_4;
            string val_15;
            string val_16;
            string val_17;
            val_15 = aIndent;
            val_16 = "{ ";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_30:
            if(((-983255696) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_5 = val_4.Current;
            if(Length >= 4)
            {
                    val_17 = val_16 + ", ";
            }
            
            string[] val_8 = new string[7];
            val_8[0] = val_17;
            val_8[1] = "\n";
            val_8[2] = aPrefix;
            val_8[3] = val_15;
            val_8[4] = "\"";
            val_8[5] = Umeng.JSONNode.Escape(aText:  val_5.Value.Id);
            val_8[6] = "\" : ";
            string val_12 = aPrefix + val_15;
            string val_13 = +val_8(+val_8) + val_5.Value;
            goto label_30;
            label_2:
            UniRx.Unit..cctor();
            return (string)val_16 + "\n" + aPrefix + "}";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.m_Dict.Keys.GetEnumerator();
            label_8:
            if(((-983064744) & 1) == 0)
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
        public JSONObject()
        {
            this.m_Dict = new System.Collections.Generic.Dictionary<System.String, Umeng.JSONNode>();
            this = new System.Object();
        }
    
    }

}
