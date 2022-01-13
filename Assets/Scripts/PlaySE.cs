using UnityEngine;
public class PlaySE : MonoBehaviour
{
    // Fields
    private SEInfo[] seInfoArray;
    private bool isDestroyed;
    
    // Methods
    private void OnEnable()
    {
        goto label_1;
        label_6:
        .<>4__this = this;
        SEInfo val_5 = this.seInfoArray[0];
        .info = val_5;
        UnityEngine.Coroutine val_4 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  val_5.Delay, act:  new System.Action(object:  new PlaySE.<>c__DisplayClass2_0(), method:  System.Void PlaySE.<>c__DisplayClass2_0::<OnEnable>b__0()));
        0 = 1;
        label_1:
        if(0 < this.seInfoArray.Length)
        {
            goto label_6;
        }
    
    }
    private void OnDestroy()
    {
        this.isDestroyed = true;
    }
    public PlaySE()
    {
    
    }

}
