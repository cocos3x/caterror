using UnityEngine;
private sealed class GameManager.<>c__DisplayClass67_0
{
    // Fields
    public GameData gameData;
    
    // Methods
    public GameManager.<>c__DisplayClass67_0()
    {
    
    }
    internal bool <ChangeAvatar>b__0(AvatarData data)
    {
        return (bool)(data.id == this.gameData.catHeadgearId) ? 1 : 0;
    }
    internal bool <ChangeAvatar>b__1(AvatarData data)
    {
        return (bool)(data.id == this.gameData.catFaceItemId) ? 1 : 0;
    }

}
