using UnityEngine;
public class JPRewardAd : JoypacSingleMonoBehaviour<JPRewardAd>
{
    // Methods
    public void ShowRV(string position, UnityEngine.Events.UnityAction success, UnityEngine.Events.UnityAction not_success, bool showPop = False)
    {
        JPRewardAd.<>c__DisplayClass0_0 val_1 = new JPRewardAd.<>c__DisplayClass0_0();
        if(val_1 != null)
        {
                .success = success;
            .showPop = showPop;
        }
        else
        {
                mem[16] = success;
            mem[24] = showPop;
        }
        
        .not_success = not_success;
        JoypacAdManager.Instance.ShowVideo(_callback:  new System.Action<JoypacVideoStatus>(object:  val_1, method:  System.Void JPRewardAd.<>c__DisplayClass0_0::<ShowRV>b__0(JoypacVideoStatus obj)), _videoPlace:  new JoypacVideoPlace());
    }
    public JPRewardAd()
    {
    
    }

}
