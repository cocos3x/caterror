using UnityEngine;
[Serializable]
public sealed class StageData
{
    // Fields
    public int id;
    public int stage;
    public string prefabName;
    
    // Methods
    public Stage GetPrefab()
    {
        Stage val_2 = UnityEngine.Resources.Load<Stage>(path:  "Stages/"("Stages/") + this.prefabName);
        if(val_2 == 0)
        {
                return UnityEngine.Resources.Load<Stage>(path:  "Stages/Stage_f0001");
        }
        
        return val_2;
    }
    public StageData()
    {
    
    }

}
