using UnityEngine;
private sealed class Cat.<>c__DisplayClass50_0
{
    // Fields
    public Cat <>4__this;
    public CatActionTrigger catActionTrigger;
    public System.Action <>9__3;
    
    // Methods
    public Cat.<>c__DisplayClass50_0()
    {
    
    }
    internal void <SearchCat>b__0()
    {
        System.Action val_3;
        this.<>4__this.NotFound();
        val_3 = this.<>9__3;
        if(val_3 == null)
        {
                System.Action val_1 = null;
            val_3 = val_1;
            val_1 = new System.Action(object:  this, method:  System.Void Cat.<>c__DisplayClass50_0::<SearchCat>b__3());
            this.<>9__3 = val_3;
        }
        
        this.<>4__this.coroutine = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this.<>4__this, seconds:  1f, act:  val_1);
    }
    internal void <SearchCat>b__3()
    {
        this.<>4__this.Hide();
        System.Action val_1 = new System.Action(object:  this.<>4__this, method:  System.Void Cat::EndCatAction());
        this.<>4__this.coroutine = this.catActionTrigger;
    }
    internal void <SearchCat>b__1(UnityEngine.Coroutine coroutine)
    {
        this.<>4__this.coroutine = coroutine;
    }
    internal void <SearchCat>b__2()
    {
        this.<>4__this.cancelAction.Invoke();
    }

}
