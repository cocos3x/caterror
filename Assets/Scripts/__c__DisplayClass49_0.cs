using UnityEngine;
private sealed class GameManager.<>c__DisplayClass49_0
{
    // Fields
    public GameData gameData;
    
    // Methods
    public GameManager.<>c__DisplayClass49_0()
    {
    
    }
    internal bool <Start>b__0(AvatarData data)
    {
        return (bool)(data.id == this.gameData.catId) ? 1 : 0;
    }

}
