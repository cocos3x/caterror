using UnityEngine;
private sealed class GameManager.<>c__DisplayClass70_0
{
    // Fields
    public System.Action hideAction;
    public GameManager <>4__this;
    
    // Methods
    public GameManager.<>c__DisplayClass70_0()
    {
    
    }
    internal void <OnOpenLoginBonusList>b__2(bool isAcquiredAvatar)
    {
        this.<>4__this.canvas.gameObject.SetActive(value:  true);
        if(this.hideAction == null)
        {
                return;
        }
        
        this.hideAction.Invoke();
    }

}
