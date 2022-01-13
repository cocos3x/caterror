using UnityEngine;
private sealed class GameManager.<>c__DisplayClass64_1
{
    // Fields
    public bool isAcquiredAvatar;
    public GameManager.<>c__DisplayClass64_0 CS$<>8__locals1;
    
    // Methods
    public GameManager.<>c__DisplayClass64_1()
    {
    
    }
    internal void <ResultReward>b__2(bool isAcquiredPresent)
    {
        bool val_1 = (this.isAcquiredAvatar == true) ? 1 : 0;
        val_1 = val_1 | isAcquiredPresent;
        isAcquiredPresent = val_1;
        this.CS$<>8__locals1.<>4__this.TransitionToMain(isAcquiredAvatar:  isAcquiredPresent);
    }

}
