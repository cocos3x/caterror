using UnityEngine;
[Serializable]
public sealed class BackgroundData
{
    // Fields
    public int id;
    public string prefabName;
    public float firstMiddleObjectPosition;
    public float middleObjectIntervalMin;
    public float middleObjectIntervalMax;
    public string backColor;
    public string spriteColor1;
    public string spriteColor2;
    public string spriteColor3;
    
    // Methods
    public Background GetPrefab()
    {
        return UnityEngine.Resources.Load<Background>(path:  "Backgrounds/"("Backgrounds/") + this.prefabName);
    }
    public UnityEngine.Sprite GetSprite()
    {
        return UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "BackgroundIcons/"("BackgroundIcons/") + this.prefabName);
    }
    public UnityEngine.Transform GetStartObjectPrefab()
    {
        return UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "StartObjects/"("StartObjects/") + this.prefabName);
    }
    public UnityEngine.Transform GetGoalObjectPrefab()
    {
        return UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "GoalObjects/"("GoalObjects/") + this.prefabName);
    }
    public UnityEngine.Transform[] GetMiddleObjectPrefabArray()
    {
        return UnityEngine.Resources.LoadAll<UnityEngine.Transform>(path:  "MiddleObjects/"("MiddleObjects/") + this.prefabName);
    }
    public UnityEngine.Color GetBackColor()
    {
        return this.StringToColor(str:  this.backColor);
    }
    public UnityEngine.Color GetSpriteColor1()
    {
        return this.StringToColor(str:  this.spriteColor1);
    }
    public UnityEngine.Color GetSpriteColor2()
    {
        return this.StringToColor(str:  this.spriteColor2);
    }
    public UnityEngine.Color GetSpriteColor3()
    {
        return this.StringToColor(str:  this.spriteColor3);
    }
    private UnityEngine.Color StringToColor(string str)
    {
        if((UnityEngine.ColorUtility.TryParseHtmlString(htmlString:  str, color: out  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) != false)
        {
                return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    public BackgroundData()
    {
        this.firstMiddleObjectPosition = 7f;
        this.middleObjectIntervalMin = 6f;
        this.middleObjectIntervalMax = 10f;
    }

}
