using UnityEngine;

namespace I2.Loc
{
    public class Localize : MonoBehaviour
    {
        // Fields
        public string mTerm;
        public string mTermSecondary;
        public string FinalTerm;
        public string FinalSecondaryTerm;
        public I2.Loc.Localize.TermModification PrimaryTermModifier;
        public I2.Loc.Localize.TermModification SecondaryTermModifier;
        public string TermPrefix;
        public string TermSuffix;
        public bool LocalizeOnAwake;
        private string LastLocalizedLanguage;
        public bool IgnoreRTL;
        public int MaxCharactersInRTL;
        public bool IgnoreNumbersInRTL;
        public bool CorrectAlignmentForRTL;
        public bool AddSpacesToJoinedLanguages;
        public bool AllowLocalizedParameters;
        public System.Collections.Generic.List<UnityEngine.Object> TranslatedObjects;
        public System.Collections.Generic.Dictionary<string, UnityEngine.Object> mAssetDictionary;
        public UnityEngine.Events.UnityEvent LocalizeEvent;
        public static string MainTranslation;
        public static string SecondaryTranslation;
        public static string CallBackTerm;
        public static string CallBackSecondaryTerm;
        public static I2.Loc.Localize CurrentLocalizeComponent;
        public bool AlwaysForceLocalize;
        public I2.Loc.EventCallback LocalizeCallBack;
        public bool mGUI_ShowReferences;
        public bool mGUI_ShowTems;
        public bool mGUI_ShowCallback;
        public I2.Loc.ILocalizeTarget mLocalizeTarget;
        public string mLocalizeTargetName;
        
        // Properties
        public string Term { get; set; }
        public string SecondaryTerm { get; set; }
        
        // Methods
        public string get_Term()
        {
            return (string)this.mTerm;
        }
        public void set_Term(string value)
        {
            this.SetTerm(primary:  value);
        }
        public string get_SecondaryTerm()
        {
            return (string)this.mTermSecondary;
        }
        public void set_SecondaryTerm(string value)
        {
            this.SetTerm(primary:  0, secondary:  value);
        }
        private void Awake()
        {
            this.UpdateAssetDictionary();
            bool val_1 = this.FindTarget();
            if(this.LocalizeOnAwake == false)
            {
                    return;
            }
            
            this.OnLocalize(Force:  false);
        }
        private void OnEnable()
        {
            this.OnLocalize(Force:  false);
        }
        public bool HasCallback()
        {
            UnityEngine.Events.UnityEvent val_4;
            var val_5;
            val_4 = this;
            if(this.LocalizeCallBack.HasCallback() != false)
            {
                    val_5 = 1;
                return (bool)(val_4.GetPersistentEventCount() > 0) ? 1 : 0;
            }
            
            val_4 = this.LocalizeEvent;
            return (bool)(val_4.GetPersistentEventCount() > 0) ? 1 : 0;
        }
        public void OnLocalize(bool Force = False)
        {
            string val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            UnityEngine.GameObject val_67;
            var val_68;
            var val_69;
            string val_71;
            var val_72;
            char val_73;
            bool val_74;
            string val_76;
            var val_78;
            if(Force == false)
            {
                goto label_1;
            }
            
            label_23:
            if((System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.CurrentLanguage)) == true)
            {
                    return;
            }
            
            if((this.AlwaysForceLocalize != true) && (Force != true))
            {
                    if(this.HasCallback() != true)
            {
                    if((System.String.op_Equality(a:  this.LastLocalizedLanguage, b:  I2.Loc.LocalizationManager.CurrentLanguage)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            string val_9 = this.FinalTerm;
            this.LastLocalizedLanguage = I2.Loc.LocalizationManager.CurrentLanguage;
            val_62 = 1152921512272361824;
            if((System.String.IsNullOrEmpty(value:  val_9)) == true)
            {
                goto label_13;
            }
            
            string val_10 = this.FinalSecondaryTerm;
            if((System.String.IsNullOrEmpty(value:  val_10)) == false)
            {
                goto label_14;
            }
            
            label_13:
            this.GetFinalTerms(primaryTerm: out  val_9, secondaryTerm: out  val_10);
            label_14:
            if((I2.Loc.I2Utils.IsPlaying() == false) || (this.HasCallback() == false))
            {
                goto label_16;
            }
            
            val_63 = 1;
            goto label_17;
            label_1:
            if(this.enabled == false)
            {
                    return;
            }
            
            val_62 = this.gameObject;
            if(val_62 == 0)
            {
                    return;
            }
            
            val_62 = this.gameObject;
            if(val_62.activeInHierarchy == true)
            {
                goto label_23;
            }
            
            return;
            label_16:
            if((System.String.IsNullOrEmpty(value:  val_9)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  this.FinalSecondaryTerm)) == true)
            {
                    return;
            }
            
            }
            
            val_63 = 0;
            label_17:
            I2.Loc.Localize.CallBackTerm = this.FinalTerm;
            I2.Loc.Localize.CallBackSecondaryTerm = this.FinalSecondaryTerm;
            val_64 = 0;
            if((System.String.IsNullOrEmpty(value:  this.FinalTerm)) != true)
            {
                    val_64 = 0;
                if((System.String.op_Equality(a:  val_9, b:  "-")) != true)
            {
                    val_62 = val_9;
                val_65 = 0;
            }
            
            }
            
            I2.Loc.Localize.MainTranslation = I2.Loc.LocalizationManager.GetTranslation(Term:  val_62, FixForRTL:  false, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0);
            val_66 = 0;
            if((System.String.IsNullOrEmpty(value:  this.FinalSecondaryTerm)) != true)
            {
                    val_66 = 0;
                if((System.String.op_Equality(a:  this.FinalSecondaryTerm, b:  "-")) != true)
            {
                    val_62 = this.FinalSecondaryTerm;
                val_65 = 0;
            }
            
            }
            
            I2.Loc.Localize.SecondaryTranslation = I2.Loc.LocalizationManager.GetTranslation(Term:  val_62, FixForRTL:  false, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  0);
            if((val_63 & 1) == 0)
            {
                    if((System.String.IsNullOrEmpty(value:  val_9)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.SecondaryTranslation)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            I2.Loc.Localize.CurrentLocalizeComponent = this;
            this.LocalizeCallBack.Execute(Sender:  this);
            this.LocalizeEvent.Invoke();
            val_62 = this.gameObject;
            val_67 = val_62;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  I2.Loc.Localize.MainTranslation, root:  val_67, allowLocalizedParameters:  (this.AllowLocalizedParameters == true) ? 1 : 0);
            if(this.FindTarget() == false)
            {
                    return;
            }
            
            val_68 = null;
            val_68 = null;
            if(I2.Loc.LocalizationManager.IsRight2Left != false)
            {
                    bool val_61 = this.IgnoreRTL;
                val_61 = val_61 ^ 1;
                val_69 = val_61 & 255;
            }
            else
            {
                    val_69 = 0;
            }
            
            if(I2.Loc.Localize.MainTranslation == null)
            {
                goto label_74;
            }
            
            TermModification val_62 = this.PrimaryTermModifier;
            val_62 = val_62 - 1;
            if(val_62 > 3)
            {
                goto label_48;
            }
            
            var val_63 = 26982712 + ((this.PrimaryTermModifier - 1)) << 2;
            val_63 = val_63 + 26982712;
            goto (26982712 + ((this.PrimaryTermModifier - 1)) << 2 + 26982712);
            label_48:
            if((System.String.IsNullOrEmpty(value:  this.TermPrefix)) != true)
            {
                    I2.Loc.Localize.MainTranslation = (val_69 != 0) ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : (this.TermPrefix)((val_69 != 0) ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : (this.TermPrefix)) + (val_69 != 0) ? (this.TermPrefix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields((val_69 != 0) ? (this.TermPrefix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields);
            }
            
            val_71 = 0;
            if((System.String.IsNullOrEmpty(value:  this.TermSuffix)) != true)
            {
                    val_71 = mem[val_69 != 0x0 ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : 1152921512272361848];
                val_71 = (val_69 != 0) ? I2.Loc.Localize.__il2cppRuntimeField_static_fields : (this.TermSuffix);
                I2.Loc.Localize.MainTranslation = (val_69 != 0) ? (this.TermSuffix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields((val_69 != 0) ? (this.TermSuffix) : I2.Loc.Localize.__il2cppRuntimeField_static_fields) + val_71;
            }
            
            if(this.AddSpacesToJoinedLanguages == false)
            {
                goto label_62;
            }
            
            val_72 = null;
            val_72 = null;
            if(I2.Loc.LocalizationManager.HasJoinedWords == false)
            {
                goto label_62;
            }
            
            val_71 = 0;
            if((System.String.IsNullOrEmpty(value:  I2.Loc.Localize.MainTranslation)) == true)
            {
                goto label_62;
            }
            
            System.Text.StringBuilder val_44 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_46 = val_44.Append(value:  I2.Loc.Localize.MainTranslation.Chars[0]);
            val_73 = 0;
            val_74 = 1;
            goto label_66;
            label_70:
            System.Text.StringBuilder val_48 = val_44.Append(value:  ' ');
            val_73 = I2.Loc.Localize.MainTranslation.Chars[1];
            System.Text.StringBuilder val_50 = val_44.Append(value:  val_73);
            val_74 = 2;
            label_66:
            if(val_74 < I2.Loc.Localize.MainTranslation.Length)
            {
                goto label_70;
            }
            
            I2.Loc.Localize.MainTranslation = val_44;
            label_62:
            if((val_69 != 0) && ((this.mLocalizeTarget & 1) != 0))
            {
                    val_67 = 0;
                if((System.String.IsNullOrEmpty(value:  val_44)) != true)
            {
                    val_74 = this.IgnoreNumbersInRTL;
                val_67 = this.MaxCharactersInRTL;
                I2.Loc.Localize.MainTranslation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  val_44, maxCharacters:  val_67, ignoreNumbers:  (val_74 == true) ? 1 : 0);
            }
            
            }
            
            label_74:
            val_76 = I2.Loc.Localize.SecondaryTranslation;
            if(val_76 == null)
            {
                goto label_89;
            }
            
            TermModification val_64 = this.SecondaryTermModifier;
            val_64 = val_64 - 1;
            if(val_64 > 3)
            {
                goto label_78;
            }
            
            var val_65 = 26982728 + ((this.SecondaryTermModifier - 1)) << 2;
            val_65 = val_65 + 26982728;
            goto (26982728 + ((this.SecondaryTermModifier - 1)) << 2 + 26982728);
            label_78:
            if(val_69 != 0)
            {
                    val_76 = this.mLocalizeTarget;
                if((val_76 & 1) != 0)
            {
                    if((System.String.IsNullOrEmpty(value:  null)) != true)
            {
                    val_76 = ;
                I2.Loc.Localize.SecondaryTranslation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  val_76);
            }
            
            }
            
            }
            
            label_89:
            val_78 = null;
            val_78 = null;
            if(I2.Loc.LocalizationManager.HighlightLocalizedTargets != false)
            {
                    I2.Loc.Localize.MainTranslation = "LOC:"("LOC:") + val_9;
            }
            
            val_62 = I2.Loc.Localize.SecondaryTranslation;
            I2.Loc.Localize.CurrentLocalizeComponent = 0;
        }
        public bool FindTarget()
        {
            var val_6;
            var val_17;
            var val_18;
            var val_19;
            string val_20;
            string val_21;
            var val_22;
            var val_23;
            I2.Loc.ILocalizeTarget val_24;
            var val_25;
            System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor> val_26;
            var val_27;
            var val_28;
            var val_29;
            val_17 = this;
            if((this.mLocalizeTarget != 0) && ((this.mLocalizeTarget & 1) != 0))
            {
                    val_18 = 1;
                return (bool)val_18;
            }
            
            val_19 = 0;
            if(this.mLocalizeTarget != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.mLocalizeTarget);
                val_20 = 0;
                val_21 = this.mLocalizeTargetName;
                this.mLocalizeTarget = 0;
                this.mLocalizeTargetName = 0;
            }
            else
            {
                    val_21 = val_17;
                val_20 = this.mLocalizeTargetName;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_20)) == true)
            {
                goto label_13;
            }
            
            val_22 = null;
            val_22 = null;
            List.Enumerator<T> val_4 = I2.Loc.LocalizationManager.mLocalizeTargets.GetEnumerator();
            val_23 = 1152921512272639216;
            label_25:
            if(((-924119216) & 1) == 0)
            {
                goto label_17;
            }
            
            string val_7 = val_6.Id;
            if((System.String.op_Equality(a:  this.mLocalizeTargetName, b:  val_7)) == false)
            {
                goto label_25;
            }
            
            if((val_7 & 1) != 0)
            {
                    val_24 = val_7;
                this.mLocalizeTarget = val_24;
            }
            else
            {
                    val_24 = this.mLocalizeTarget;
            }
            
            val_19 = 0;
            if(val_24 == 0)
            {
                goto label_25;
            }
            
            val_25 = 1;
            val_26 = 300;
            goto label_26;
            label_17:
            val_25 = 0;
            val_26 = 195;
            label_26:
            UniRx.Unit..cctor();
            if(195 == 300)
            {
                    var val_10 = (val_25 != 0) ? 1 : 0;
                return (bool)val_18;
            }
            
            var val_11 = (val_25 != 0) ? 1 : 0;
            var val_12 = (195 == 195) ? -1 : 0;
            goto label_29;
            label_13:
            val_18 = 0;
            val_27 = 0;
            label_29:
            val_28 = null;
            val_28 = null;
            val_26 = I2.Loc.LocalizationManager.mLocalizeTargets;
            List.Enumerator<T> val_13 = val_26.GetEnumerator();
            val_23 = 1152921512272639216;
            label_47:
            if(((-924119216) & 1) == 0)
            {
                goto label_41;
            }
            
            string val_14 = val_6.Id;
            if((val_14 & 1) == 0)
            {
                goto label_47;
            }
            
            this.mLocalizeTarget = val_14;
            this.mLocalizeTargetName = val_14;
            val_26 = this.mLocalizeTarget;
            if(val_26 == 0)
            {
                goto label_47;
            }
            
            val_29 = 1;
            val_17 = 0;
            val_18 = 1;
            goto label_49;
            label_41:
            val_17 = 0;
            val_29 = 0 + 1;
            mem2[0] = 298;
            label_49:
            UniRx.Unit..cctor();
            if(val_29 == 1)
            {
                goto label_56;
            }
            
            if((1152921512272662304 + ((0 + 1)) << 2) == 300)
            {
                    return (bool)val_18;
            }
            
            val_18 = 0;
            if( == 0)
            {
                    return (bool)val_18;
            }
            
            if((1152921512272662304 + ((0 + 1)) << 2) != 298)
            {
                goto label_59;
            }
            
            return (bool)val_18;
            label_56:
            if( == 0)
            {
                goto label_61;
            }
            
            label_59:
            label_61:
            val_18 = 0;
            return (bool)val_18;
        }
        public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
        {
            string val_8;
            primaryTerm = System.String.alignConst;
            secondaryTerm = System.String.alignConst;
            if(this.FindTarget() == false)
            {
                    return;
            }
            
            if(this.mLocalizeTarget != 0)
            {
                    val_8 = this;
                primaryTerm = I2.Loc.I2Utils.GetValidTermName(text:  primaryTerm, allowCategory:  false);
            }
            else
            {
                    val_8 = this.mTerm;
            }
            
            if((System.String.IsNullOrEmpty(value:  mem[this.mTerm])) != true)
            {
                    primaryTerm = mem[this.mTerm];
            }
            
            if((System.String.IsNullOrEmpty(value:  this.mTermSecondary)) != true)
            {
                    secondaryTerm = this.mTermSecondary;
            }
            
            if(primaryTerm != null)
            {
                    primaryTerm = primaryTerm.Trim();
            }
            
            if(secondaryTerm == null)
            {
                    return;
            }
            
            secondaryTerm = secondaryTerm.Trim();
        }
        public string GetMainTargetsText()
        {
            if(this.mLocalizeTarget == 0)
            {
                    return (string)((System.String.IsNullOrEmpty(value:  0 = 0)) != true) ? this.mTerm : -923788952;
            }
            
            return (string)((System.String.IsNullOrEmpty(value:  0)) != true) ? this.mTerm : -923788952;
        }
        public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
        {
            primaryTerm = I2.Loc.I2Utils.GetValidTermName(text:  Main, allowCategory:  false);
            secondaryTerm = Secondary;
        }
        public void SetTerm(string primary)
        {
            if((System.String.IsNullOrEmpty(value:  primary)) != true)
            {
                    this.mTerm = primary;
                this.FinalTerm = primary;
            }
            
            this.OnLocalize(Force:  true);
        }
        public void SetTerm(string primary, string secondary)
        {
            if((System.String.IsNullOrEmpty(value:  primary)) != true)
            {
                    this.mTerm = primary;
                this.FinalTerm = primary;
            }
            
            this.mTermSecondary = secondary;
            this.FinalSecondaryTerm = secondary;
            this.OnLocalize(Force:  true);
        }
        internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation)
        {
            string val_6;
            UnityEngine.Object val_7;
            val_6 = 1152921512273570288;
            string val_1 = 0;
            string val_2 = 0;
            this.DeserializeTranslation(translation:  mainTranslation, value: out  val_1, secondary: out  val_2);
            val_7 = 0;
            if((System.String.IsNullOrEmpty(value:  val_2)) != true)
            {
                    val_7 = this;
                if(this != 0)
            {
                    mainTranslation = val_1;
                secondaryTranslation = val_2;
            }
            
            }
            
            if(this != 0)
            {
                    return (object)val_7;
            }
            
            val_6 = secondaryTranslation;
            val_7 = this;
            return (object)val_7;
        }
        public void UpdateAssetDictionary()
        {
            var val_12;
            var val_14;
            var val_15;
            System.Func<UnityEngine.Object, System.String> val_17;
            var val_18;
            System.Func<UnityEngine.Object, System.String> val_20;
            var val_21;
            System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String> val_23;
            System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_25;
            val_12 = null;
            val_12 = null;
            if((Localize.<>c.<>9__49_0) == null)
            {
                goto label_3;
            }
            
            label_28:
            int val_1 = this.TranslatedObjects.RemoveAll(match:  Localize.<>c.<>9__49_0);
            val_14 = 1152921512253564208;
            val_15 = null;
            val_15 = null;
            val_17 = Localize.<>c.<>9__49_1;
            if(val_17 == null)
            {
                    System.Func<UnityEngine.Object, System.String> val_3 = null;
                val_17 = val_3;
                val_3 = new System.Func<UnityEngine.Object, System.String>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  System.String Localize.<>c::<UpdateAssetDictionary>b__49_1(UnityEngine.Object o));
                Localize.<>c.<>9__49_1 = val_17;
            }
            
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<UnityEngine.Object, System.String>(source:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  this.TranslatedObjects), keySelector:  val_3);
            val_18 = null;
            val_18 = null;
            val_20 = Localize.<>c.<>9__49_2;
            if(val_20 == null)
            {
                    System.Func<UnityEngine.Object, System.String> val_6 = null;
                val_20 = val_6;
                val_6 = new System.Func<UnityEngine.Object, System.String>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  System.String Localize.<>c::<UpdateAssetDictionary>b__49_2(UnityEngine.Object o));
                Localize.<>c.<>9__49_2 = val_20;
            }
            
            val_21 = null;
            val_21 = null;
            val_23 = Localize.<>c.<>9__49_3;
            if(val_23 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String> val_8 = null;
                val_23 = val_8;
                val_8 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  System.String Localize.<>c::<UpdateAssetDictionary>b__49_3(System.Linq.IGrouping<string, UnityEngine.Object> g));
                val_21 = null;
                Localize.<>c.<>9__49_3 = val_23;
            }
            
            val_21 = null;
            val_25 = Localize.<>c.<>9__49_4;
            if(val_25 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_9 = null;
                val_25 = val_9;
                val_9 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Object Localize.<>c::<UpdateAssetDictionary>b__49_4(System.Linq.IGrouping<string, UnityEngine.Object> g));
                Localize.<>c.<>9__49_4 = val_25;
            }
            
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String, UnityEngine.Object>(source:  System.Linq.Enumerable.GroupBy<UnityEngine.Object, System.String>(source:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  this.TranslatedObjects), keySelector:  val_6), keySelector:  val_8, elementSelector:  val_9);
            return;
            label_3:
            Localize.<>c.<>9__49_0 = new System.Predicate<UnityEngine.Object>(object:  Localize.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Localize.<>c::<UpdateAssetDictionary>b__49_0(UnityEngine.Object x));
            if(this.TranslatedObjects != null)
            {
                goto label_28;
            }
            
            goto label_28;
        }
        internal T GetObject<T>(string Translation)
        {
            if((System.String.IsNullOrEmpty(value:  Translation)) != false)
            {
                    return 0;
            }
            
            if(this == null)
            {
                
            }
        
        }
        private T GetTranslatedObject<T>(string Translation)
        {
            if(this == null)
            {
                
            }
        
        }
        private void DeserializeTranslation(string translation, out string value, out string secondary)
        {
            if(((System.String.IsNullOrEmpty(value:  translation)) == true) || (translation.Length < 2))
            {
                goto label_7;
            }
            
            char val_4 = translation.Chars[0] & 65535;
            if(val_4 != '[')
            {
                goto label_7;
            }
            
            int val_5 = translation.IndexOf(value:  ']');
            int val_6 = val_5 - 1;
            if(val_4 < '[')
            {
                goto label_7;
            }
            
            if(translation == null)
            {
                goto label_8;
            }
            
            secondary = translation.Substring(startIndex:  1, length:  val_6);
            goto label_9;
            label_7:
            value = translation;
            label_10:
            secondary = System.String.alignConst;
            return;
            label_8:
            secondary = 0.Substring(startIndex:  1, length:  val_6);
            label_9:
            string val_10 = translation.Substring(startIndex:  val_5 + 1);
            goto label_10;
        }
        public T FindTranslatedObject<T>(string value)
        {
            var val_5;
            var val_6;
            var val_7;
            UnityEngine.Object val_20;
            var val_21;
            var val_22;
            var val_23;
            val_20 = 0;
            if((System.String.IsNullOrEmpty(value:  value)) == true)
            {
                    return (object)val_20;
            }
            
            if(this.mAssetDictionary != null)
            {
                    if(this.mAssetDictionary.Count == this.TranslatedObjects.Count)
            {
                goto label_4;
            }
            
            }
            
            this.UpdateAssetDictionary();
            label_4:
            Dictionary.Enumerator<TKey, TValue> val_4 = this.mAssetDictionary.GetEnumerator();
            label_11:
            if(((-922475568) & 1) == 0)
            {
                goto label_6;
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_8 = val_7.Current;
            if(((val_8.Value == 0) || ((value.EndsWith(value:  val_8.Value.Id, comparisonType:  5)) == false)) || ((System.String.Compare(strA:  value, strB:  val_8.Value.Id, comparisonType:  5)) != 0))
            {
                goto label_11;
            }
            
            if(val_8.Value == 0)
            {
                goto label_13;
            }
            
            val_20 = ;
            if(val_8.Value != 0)
            {
                goto label_14;
            }
            
            label_13:
            val_20 = 0;
            label_14:
            val_21 = 0;
            val_22 = 0;
            val_23 = 210;
            goto label_16;
            label_6:
            val_21 = 0;
            val_20 = 0;
            val_22 = 0;
            val_23 = 164;
            label_16:
            val_5 = val_6;
            val_6 = val_7;
            val_7 = null;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_7.Dispose();
            if( == 1)
            {
                goto label_32;
            }
            
            if(164 == 210)
            {
                    return (object)val_20;
            }
            
            if( == false)
            {
                goto label_37;
            }
            
            if(164 != 164)
            {
                goto label_35;
            }
            
            goto label_37;
            label_32:
            if( == false)
            {
                goto label_37;
            }
            
            label_35:
            label_37:
            val_21 = I2.Loc.LocalizationManager.FindAsset(value:  value);
            if(val_21 == null)
            {
                goto label_42;
            }
            
            val_20 = val_21;
            if(val_20 != null)
            {
                goto label_43;
            }
            
            label_42:
            val_20 = 0;
            label_43:
            if((UnityEngine.Object.op_Implicit(exists:  val_20)) == true)
            {
                    return (object)val_20;
            }
            
            val_20 = I2.Loc.ResourceManager.pInstance;
            return (object)val_20;
        }
        public bool HasTranslatedObject(UnityEngine.Object Obj)
        {
            if((this.TranslatedObjects.Contains(item:  Obj)) != false)
            {
                    return true;
            }
            
            I2.Loc.ResourceManager val_2 = I2.Loc.ResourceManager.pInstance;
            if(val_2 != null)
            {
                    return val_2.HasAsset(Obj:  Obj);
            }
            
            return val_2.HasAsset(Obj:  Obj);
        }
        public void AddTranslatedObject(UnityEngine.Object Obj)
        {
            if((this.TranslatedObjects.Contains(item:  Obj)) != false)
            {
                    return;
            }
            
            this.TranslatedObjects.Add(item:  Obj);
            this.UpdateAssetDictionary();
        }
        public void SetGlobalLanguage(string Language)
        {
            I2.Loc.LocalizationManager.CurrentLanguage = Language;
        }
        public Localize()
        {
            this.mTerm = System.String.alignConst;
            this.LocalizeOnAwake = true;
            this.IgnoreNumbersInRTL = true;
            this.CorrectAlignmentForRTL = true;
            this.AllowLocalizedParameters = true;
            this.mTermSecondary = System.String.alignConst;
            this.TranslatedObjects = new System.Collections.Generic.List<UnityEngine.Object>();
            this.mAssetDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer.Ordinal);
            this.LocalizeEvent = new UnityEngine.Events.UnityEvent();
            this.LocalizeCallBack = new I2.Loc.EventCallback();
            this.mGUI_ShowTems = true;
        }
    
    }

}
