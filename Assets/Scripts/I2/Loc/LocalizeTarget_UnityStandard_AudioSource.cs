using UnityEngine;

namespace I2.Loc
{
    public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<UnityEngine.AudioSource>
    {
        // Methods
        private static LocalizeTarget_UnityStandard_AudioSource()
        {
            I2.Loc.LocalizeTarget_UnityStandard_AudioSource.AutoRegister();
        }
        private static void AutoRegister()
        {
            I2.Loc.LocalizeTargetDesc_Type<UnityEngine.AudioSource, I2.Loc.LocalizeTarget_UnityStandard_AudioSource> val_1 = new I2.Loc.LocalizeTargetDesc_Type<UnityEngine.AudioSource, I2.Loc.LocalizeTarget_UnityStandard_AudioSource>();
            if(val_1 != null)
            {
                    mem[1152921512296387216] = "AudioSource";
            }
            else
            {
                    mem[16] = "AudioSource";
            }
            
            mem[1152921512296387224] = 100;
            I2.Loc.LocalizationManager.RegisterTarget(desc:  val_1);
        }
        public override I2.Loc.eTermType GetPrimaryTermType(I2.Loc.Localize cmp)
        {
            return 3;
        }
        public override I2.Loc.eTermType GetSecondaryTermType(I2.Loc.Localize cmp)
        {
            return 0;
        }
        public override bool CanUseSecondaryTerm()
        {
            return false;
        }
        public override bool AllowMainTermToBeRTL()
        {
            return false;
        }
        public override bool AllowSecondTermToBeRTL()
        {
            return false;
        }
        public override void GetFinalTerms(I2.Loc.Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
        {
            var val_5;
            int val_6;
            val_5 = this;
            if((UnityEngine.Object.op_Implicit(exists:  clip)) != false)
            {
                    val_5 = this.clip;
                string val_4 = val_5.name;
            }
            else
            {
                    val_6 = System.String.alignConst;
            }
            
            primaryTerm = val_6;
            secondaryTerm = 0;
        }
        public override void DoLocalize(I2.Loc.Localize cmp, string mainTranslation, string secondaryTranslation)
        {
            var val_10;
            var val_11;
            val_10 = cmp;
            if(isPlaying != true)
            {
                    if(loop == false)
            {
                goto label_4;
            }
            
            }
            
            val_11 = UnityEngine.Application.isPlaying;
            goto label_5;
            label_4:
            val_11 = 0;
            label_5:
            UnityEngine.AudioClip val_5 = val_10.FindTranslatedObject<UnityEngine.AudioClip>(value:  mainTranslation);
            if(clip != val_5)
            {
                    val_10.clip = val_5;
            }
            
            if(val_11 == 0)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_5.clip)) == false)
            {
                    return;
            }
            
            this.Play();
        }
        public LocalizeTarget_UnityStandard_AudioSource()
        {
        
        }
    
    }

}
