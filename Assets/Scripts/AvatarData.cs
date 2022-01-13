using UnityEngine;
[Serializable]
public sealed class AvatarData : ChooseData
{
    // Fields
    private static readonly int AcquisitionConditionTextFormatId;
    public int id;
    public int nameId;
    public string prefabName;
    public int value;
    public bool silhouette;
    public int category;
    public int acquisitionCondition;
    
    // Properties
    public string Name { get; }
    public AvatarCategory Category { get; }
    public AcquisitionCondition AcquisitionCondition { get; }
    public string AcquisitionConditionText { get; }
    
    // Methods
    public string get_Name()
    {
        LanguageManager val_1 = SingletonMonoBehaviour<LanguageManager>.Instance;
        if(val_1 != null)
        {
                return val_1.getWord(id:  this.nameId);
        }
        
        return val_1.getWord(id:  this.nameId);
    }
    public UnityEngine.Animator GetPrefab()
    {
        return UnityEngine.Resources.Load<UnityEngine.Animator>(path:  "Avatars/"("Avatars/") + this.prefabName);
    }
    public Cat GetCatPrefab()
    {
        return UnityEngine.Resources.Load<Cat>(path:  "Cats/"("Cats/") + this.prefabName);
    }
    public UnityEngine.Transform GetCatHeadgearPrefab()
    {
        return UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "CatHeadgears/"("CatHeadgears/") + this.prefabName);
    }
    public UnityEngine.Transform GetCatFaceItemPrefab()
    {
        return UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "CatFaceItems/"("CatFaceItems/") + this.prefabName);
    }
    public UnityEngine.RectTransform GetIconPrefab()
    {
        string val_2;
        int val_2 = this.category;
        val_2 = val_2 - 2;
        if(val_2 <= 2)
        {
                val_2 = mem[35836656 + ((this.category - 2)) << 3];
            val_2 = 35836656 + ((this.category - 2)) << 3;
            return UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  val_2 + this.prefabName);
        }
        
        val_2 = "AvatarIcons/";
        return UnityEngine.Resources.Load<UnityEngine.RectTransform>(path:  val_2 + this.prefabName);
    }
    public AvatarCategory get_Category()
    {
        return (AvatarCategory)this.category;
    }
    public AcquisitionCondition get_AcquisitionCondition()
    {
        return (AcquisitionCondition)this.acquisitionCondition;
    }
    public string get_AcquisitionConditionText()
    {
        var val_5;
        string val_6;
        val_5 = null;
        val_5 = null;
        val_6 = SingletonMonoBehaviour<LanguageManager>.Instance.GetWordUI(id:  this.acquisitionCondition + AvatarData.AcquisitionConditionTextFormatId);
        if(this.acquisitionCondition == 1)
        {
                return (string)val_6;
        }
        
        if(this.acquisitionCondition == 4)
        {
                return (string)val_6;
        }
        
        val_6 = System.String.Format(format:  val_6, arg0:  this.value);
        return (string)val_6;
    }
    public string GetAcquisitionConditionProgressText(GameData gameData)
    {
        object val_2;
        var val_3;
        int val_4;
        var val_5;
        val_2 = gameData;
        if(this.acquisitionCondition == 3)
        {
            goto label_1;
        }
        
        if(this.acquisitionCondition != 2)
        {
            goto label_2;
        }
        
        val_3 = 1152921504620851200;
        val_4 = gameData.stage - 1;
        goto label_4;
        label_1:
        val_4 = gameData.dailyLoginCount;
        val_3 = 1152921504620851200;
        label_4:
        val_2 = val_4;
        string val_1 = System.String.Format(format:  "{0}/{1}", arg0:  val_4, arg1:  this.value);
        return (string)val_5;
        label_2:
        val_5 = "";
        return (string)val_5;
    }
    public float GetAcquisitionConditionProgress(GameData gameData)
    {
        if(this.acquisitionCondition != 3)
        {
                if(this.acquisitionCondition != 2)
        {
                return -1f;
        }
        
            int val_1 = gameData.stage;
            val_1 = val_1 - 1;
            float val_2 = (float)this.value;
            val_2 = (float)val_1 / val_2;
            return -1f;
        }
        
        float val_3 = (float)gameData.dailyLoginCount;
        val_3 = val_3 / (float)this.value;
        return -1f;
    }
    public bool CheckGetAvatar(GameData gameData)
    {
        var val_3;
        if(this.acquisitionCondition == 3)
        {
            goto label_0;
        }
        
        if(this.acquisitionCondition != 2)
        {
            goto label_1;
        }
        
        var val_1 = (this.value < gameData.stage) ? 1 : 0;
        return (bool)val_3;
        label_0:
        var val_2 = (this.value <= gameData.dailyLoginCount) ? 1 : 0;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
    }
    public AvatarData()
    {
        val_1 = new System.Object();
    }
    private static AvatarData()
    {
        AvatarData.AcquisitionConditionTextFormatId = 3000;
    }

}
