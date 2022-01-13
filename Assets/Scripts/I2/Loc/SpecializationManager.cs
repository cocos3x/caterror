using UnityEngine;

namespace I2.Loc
{
    public class SpecializationManager : BaseSpecializationManager
    {
        // Fields
        public static I2.Loc.SpecializationManager Singleton;
        
        // Methods
        private SpecializationManager()
        {
            this.InitializeSpecializations();
        }
        public static string GetSpecializedText(string text, string specialization)
        {
            string val_15;
            var val_16;
            var val_17;
            var val_18;
            val_15 = specialization;
            int val_1 = text.IndexOf(value:  "[i2s_");
            if((val_1 & 2147483648) != 0)
            {
                    return (string)text;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_15)) != false)
            {
                    val_16 = null;
                val_16 = null;
                val_15 = I2.Loc.SpecializationManager.Singleton.GetCurrentSpecialization();
            }
            
            if((System.String.IsNullOrEmpty(value:  val_15)) == true)
            {
                    return text.Substring(startIndex:  0, length:  val_1);
            }
            
            label_14:
            if((System.String.op_Inequality(a:  val_15, b:  "Any")) == false)
            {
                    return text.Substring(startIndex:  0, length:  val_1);
            }
            
            string val_6 = "[i2s_" + val_15 + "]";
            int val_7 = text.IndexOf(value:  val_6);
            if((val_7 & 2147483648) == 0)
            {
                goto label_10;
            }
            
            val_17 = null;
            val_17 = null;
            string val_8 = I2.Loc.SpecializationManager.Singleton.GetFallbackSpecialization(specialization:  val_15);
            val_15 = val_8;
            if((System.String.IsNullOrEmpty(value:  val_8)) == false)
            {
                goto label_14;
            }
            
            return text.Substring(startIndex:  0, length:  val_1);
            label_10:
            int val_11 = val_6.Length + val_7;
            val_18 = text.IndexOf(value:  "[i2s_", startIndex:  val_11);
            if((val_18 & 2147483648) != 0)
            {
                    val_18 = text.Length;
            }
            
            int val_14 = val_18 - val_11;
            return text.Substring(startIndex:  0, length:  val_1);
        }
        public static string SetSpecializedText(string text, string newText, string specialization)
        {
            string val_6 = "Any";
            string val_2 = ((System.String.IsNullOrEmpty(value:  specialization)) != true) ? (val_6) : specialization;
            if(text == null)
            {
                goto label_1;
            }
            
            if((text.Contains(value:  "[i2s_")) == true)
            {
                goto label_3;
            }
            
            val_6 = "Any";
            label_1:
            if((System.String.op_Equality(a:  val_2, b:  val_6)) != false)
            {
                    return (string)newText;
            }
            
            label_3:
            System.Collections.Generic.Dictionary<System.String, System.String> val_5 = I2.Loc.SpecializationManager.GetSpecializations(text:  text, buffer:  0);
            val_5.set_Item(key:  val_2, value:  newText);
            return I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_5);
        }
        public static string SetSpecializedText(System.Collections.Generic.Dictionary<string, string> specializations)
        {
            var val_6;
            System.Collections.Generic.Dictionary<System.String, System.String> val_14 = specializations;
            bool val_2 = val_14.TryGetValue(key:  "Any", value: out  0);
            Dictionary.Enumerator<TKey, TValue> val_3 = val_14.GetEnumerator();
            goto label_6;
            label_23:
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_7 = val_6.Current;
            if((System.String.op_Inequality(a:  val_7.Value.Id, b:  "Any")) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  val_7.Value)) != true)
            {
                    string[] val_11 = new string[5];
                val_14 = val_11;
                val_14[0] = System.String.alignConst;
                val_14[1] = "[i2s_";
                val_14[2] = val_7.Value.Id;
                val_14[3] = "]";
                val_14[4] = ;
            }
            
            }
            
            label_6:
            if(((-962778544) & 1) != 0)
            {
                goto label_23;
            }
            
            UniRx.Unit..cctor();
            return (string)+val_11;
        }
        public static System.Collections.Generic.Dictionary<string, string> GetSpecializations(string text, System.Collections.Generic.Dictionary<string, string> buffer)
        {
            int val_15;
            var val_16;
            string val_17;
            string val_18;
            var val_19;
            var val_20;
            val_16 = buffer;
            if(val_16 == null)
            {
                goto label_1;
            }
            
            val_16.Clear();
            if(text == null)
            {
                goto label_2;
            }
            
            label_12:
            val_15 = text.IndexOf(value:  "[i2s_");
            if((val_15 & 2147483648) != 0)
            {
                    val_15 = text.Length;
            }
            
            val_17 = text.Substring(startIndex:  0, length:  val_15);
            val_18 = "Any";
            val_19 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
            goto label_5;
            label_10:
            val_20 = "[i2s_";
            if("[i2s_" == null)
            {
                    val_20 = "[i2s_";
            }
            
            int val_5 = Length + val_15;
            int val_15 = val_5;
            val_15 = text.IndexOf(value:  ']', startIndex:  val_15);
            if((val_15 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)val_16;
            }
            
            val_15 = val_15 - val_5;
            int val_8 = val_15 + 1;
            val_15 = text.IndexOf(value:  "[i2s_", startIndex:  val_8);
            if((val_15 & 2147483648) != 0)
            {
                    val_15 = text.Length;
            }
            
            val_19 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
            val_18 = text.Substring(startIndex:  val_5, length:  val_15);
            val_17 = text.Substring(startIndex:  val_8, length:  val_15 - val_8);
            label_5:
            val_16.set_Item(key:  val_18, value:  val_17);
            if(val_15 < text.Length)
            {
                goto label_10;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_16;
            label_1:
            System.Collections.Generic.Dictionary<System.String, System.String> val_14 = null;
            val_16 = val_14;
            val_14 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(text != null)
            {
                goto label_12;
            }
            
            label_2:
            val_14.set_Item(key:  "Any", value:  "");
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_16;
        }
        public static void AppendSpecializations(string text, System.Collections.Generic.List<string> list)
        {
            int val_12;
            var val_13;
            var val_14;
            val_13 = list;
            if(text == null)
            {
                    return;
            }
            
            if(val_13 == null)
            {
                    System.Collections.Generic.List<System.String> val_1 = null;
                val_13 = val_1;
                val_1 = new System.Collections.Generic.List<System.String>();
                if(val_13 == null)
            {
                goto label_14;
            }
            
            }
            
            label_14:
            val_12 = "Any";
            if((val_1.Contains(item:  "Any")) != true)
            {
                    val_1.Add(item:  "Any");
            }
            
            if(text.Length < 1)
            {
                    return;
            }
            
            do
            {
                val_12 = text.IndexOf(value:  "[i2s_", startIndex:  0);
                if((val_12 >> 31) != 0)
            {
                    return;
            }
            
                val_14 = "[i2s_";
                if("[i2s_" == null)
            {
                    val_14 = "[i2s_";
            }
            
                val_12 = Length + val_12;
                int val_12 = val_12;
                int val_7 = text.IndexOf(value:  ']', startIndex:  val_12);
                if((val_7 >> 31) != 0)
            {
                    return;
            }
            
                val_12 = val_7 - val_12;
                string val_9 = text.Substring(startIndex:  val_12, length:  val_12);
                if((val_1.Contains(item:  val_9)) != true)
            {
                    val_1.Add(item:  val_9);
            }
            
            }
            while(val_12 < text.Length);
        
        }
        private static SpecializationManager()
        {
            I2.Loc.SpecializationManager val_1 = new I2.Loc.SpecializationManager();
            val_1.InitializeSpecializations();
            I2.Loc.SpecializationManager.Singleton = val_1;
        }
    
    }

}
