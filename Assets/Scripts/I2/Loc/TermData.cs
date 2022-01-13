using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class TermData
    {
        // Fields
        public string Term;
        public I2.Loc.eTermType TermType;
        public string Description;
        public string[] Languages;
        public byte[] Flags;
        private string[] Languages_Touch;
        
        // Methods
        public string GetTranslation(int idx, string specialization, bool editMode = False)
        {
            var val_3;
            string val_3 = this.Languages[(long)idx];
            if(val_3 != null)
            {
                    val_3 = I2.Loc.SpecializationManager.GetSpecializedText(text:  val_3, specialization:  specialization);
                if(editMode == true)
            {
                    return (string)val_3;
            }
            
                string val_2 = val_3.Replace(oldValue:  "[i2nt]", newValue:  "");
                if(val_2 != null)
            {
                    return val_2.Replace(oldValue:  "[/i2nt]", newValue:  "");
            }
            
                return val_2.Replace(oldValue:  "[/i2nt]", newValue:  "");
            }
            
            val_3 = 0;
            return (string)val_3;
        }
        public void SetTranslation(int idx, string translation, string specialization)
        {
            mem2[0] = I2.Loc.SpecializationManager.SetSpecializedText(text:  this.Languages[(long)idx], newText:  translation, specialization:  specialization);
        }
        public void RemoveSpecialization(string specialization)
        {
            goto label_0;
            label_2:
            this.RemoveSpecialization(idx:  0, specialization:  specialization);
            0 = 1;
            label_0:
            if(0 < this.Languages.Length)
            {
                goto label_2;
            }
        
        }
        public void RemoveSpecialization(int idx, string specialization)
        {
            string val_7 = this.Languages[(long)idx];
            if((System.String.op_Equality(a:  specialization, b:  "Any")) == true)
            {
                    return;
            }
            
            if((val_7.Contains(value:  "[i2s_" + specialization + "]")) == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_4 = I2.Loc.SpecializationManager.GetSpecializations(text:  val_7, buffer:  0);
            bool val_5 = val_4.Remove(key:  specialization);
            this = this.Languages;
            this[(long)idx] = I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_4);
        }
        public bool IsAutoTranslated(int idx, bool IsTouch)
        {
            return (bool)(uint)(this.Flags[(long)idx] >> 1) & 1;
        }
        public void Validate()
        {
            System.String[] val_7;
            var val_8;
            System.String[] val_2 = this.Languages;
            int val_1 = UnityEngine.Mathf.Max(a:  this.Languages.Length, b:  this.Flags.Length);
            if(val_1 != this.Languages.Length)
            {
                    System.Array.Resize<System.String>(array: ref  val_2, newSize:  val_1);
            }
            
            if(val_1 != this.Flags.Length)
            {
                    System.Array.Resize<System.Byte>(array: ref  this.Flags, newSize:  val_1);
            }
            
            val_7 = this.Languages_Touch;
            if(val_7 == null)
            {
                    return;
            }
            
            val_8 = 0;
            goto label_10;
            label_30:
            if((System.String.IsNullOrEmpty(value:  val_2[0])) == false)
            {
                goto label_16;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.Languages_Touch[0])) == true)
            {
                goto label_16;
            }
            
            string val_9 = this.Languages_Touch[0];
            if(this.Languages == null)
            {
                goto label_19;
            }
            
            if(val_9 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(val_9 == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            this.Languages[0] = val_9;
            this.Languages_Touch[0] = 0;
            label_16:
            val_7 = this.Languages_Touch;
            val_8 = 1;
            label_10:
            if(val_8 < (UnityEngine.Mathf.Min(a:  this.Languages_Touch.Length, b:  val_1)))
            {
                goto label_30;
            }
            
            this.Languages_Touch = 0;
        }
        public bool IsTerm(string name, bool allowCategoryMistmatch)
        {
            string val_2 = this.Term;
            if(allowCategoryMistmatch == false)
            {
                    return System.String.op_Equality(a:  name, b:  val_2 = I2.Loc.LanguageSourceData.GetKeyFromFullTerm(FullTerm:  val_2 = this.Term, OnlyMainCategory:  false));
            }
            
            return System.String.op_Equality(a:  name, b:  val_2);
        }
        public bool HasSpecializations()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            goto label_1;
            label_10:
            if((System.String.IsNullOrEmpty(value:  this.Languages[0])) == true)
            {
                goto label_4;
            }
            
            if((this.Languages[0].Contains(value:  "[i2s_")) == true)
            {
                goto label_8;
            }
            
            label_4:
            val_3 = 1;
            label_1:
            if(val_3 < this.Languages.Length)
            {
                goto label_10;
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_8:
            val_4 = 1;
            return (bool)val_4;
        }
        public System.Collections.Generic.List<string> GetAllSpecializations()
        {
            var val_2;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_2 = 0;
            goto label_1;
            label_7:
            I2.Loc.SpecializationManager.AppendSpecializations(text:  this.Languages[0], list:  val_1);
            val_2 = 1;
            label_1:
            if(val_2 < this.Languages.Length)
            {
                goto label_7;
            }
            
            return val_1;
        }
        public TermData()
        {
            this.Term = System.String.alignConst;
            this.Languages = new string[0];
            this.Flags = new byte[0];
        }
    
    }

}
