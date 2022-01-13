using UnityEngine;
public class MoreGameButton : JPButton
{
    // Fields
    private UnityEngine.GameObject red;
    
    // Methods
    private void OnEnable()
    {
        this.gameObject.SetActive(value:  false);
        if(this.red == 0)
        {
                return;
        }
        
        this.red.SetActive(value:  Joypac.JoypacSingleMonoBehaviour<MoreGameManager>.Instance.BoolRedPodShow());
    }
    public override void OnClick()
    {
        Joypac.JoypacSingleMonoBehaviour<MoreGameManager>.Instance.OnClick(red:  this.red);
    }
    public MoreGameButton()
    {
    
    }

}
