using UnityEngine;
public struct JoypacVideoPlace
{
    // Fields
    public string ClickPlace;
    public string ShowPlace;
    public string RewardPlace;
    
    // Methods
    public JoypacVideoPlace(string clickPlace, string showPlace, string rewardPlace)
    {
        this.RewardPlace = clickPlace;
        mem[1152921511817213240] = showPlace;
        mem[1152921511817213248] = rewardPlace;
    }

}
