using UnityEngine;
public class BackButtonManager : SingletonMonoBehaviour<BackButtonManager>
{
    // Fields
    private System.Collections.Generic.Stack<System.Action<bool>> backActionStack;
    private bool isEnable;
    private System.Action genericBackAction;
    
    // Methods
    public void SetEnable()
    {
        this.isEnable = true;
    }
    public void SetDisable()
    {
        this.isEnable = false;
    }
    private void Update()
    {
        if(this.isEnable == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
        {
                return;
        }
        
        if(this.backActionStack.Count >= 1)
        {
                this.PopAction(isPressedBackButton:  true);
            return;
        }
        
        this.genericBackAction.Invoke();
    }
    public void SetGenericAction(System.Action action)
    {
        this.genericBackAction = action;
    }
    public void SetAction(System.Action action)
    {
        .action = action;
        this.SetAction(action:  new System.Action<System.Boolean>(object:  new BackButtonManager.<>c__DisplayClass7_0(), method:  System.Void BackButtonManager.<>c__DisplayClass7_0::<SetAction>b__0(bool isPressedBackButton)));
    }
    public void SetAction(System.Action<bool> action)
    {
        this.backActionStack.Push(item:  action);
    }
    public void PopAction()
    {
        this.PopAction(isPressedBackButton:  false);
    }
    private void PopAction(bool isPressedBackButton)
    {
        this.backActionStack.Pop().Invoke(obj:  isPressedBackButton);
    }
    public void DestroyOneAction()
    {
        if(this.backActionStack.Count < 1)
        {
                return;
        }
        
        System.Action<System.Boolean> val_2 = this.backActionStack.Pop();
    }
    public void DestroyAllAction()
    {
        this.backActionStack.Clear();
    }
    public BackButtonManager()
    {
        var val_2;
        this.backActionStack = new System.Collections.Generic.Stack<System.Action<System.Boolean>>();
        this.isEnable = true;
        val_2 = null;
        val_2 = null;
        this.genericBackAction = ActionExtensions.EmptyAction;
    }

}
