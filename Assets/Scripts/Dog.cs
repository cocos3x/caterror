using UnityEngine;
public sealed class Dog : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator animator;
    
    // Methods
    public void Show(DogActionTrigger dogActionTrigger)
    {
        .<>4__this = this;
        this.Sleep(isSleep:  false);
        if(dogActionTrigger != null)
        {
                .sleepTime = dogActionTrigger.sleepTime;
        }
        else
        {
                .sleepTime = 0f;
        }
        
        UnityEngine.Coroutine val_3 = MonoBehaviourExtensions.CallWaitForSeconds(monoBehaviour:  this, seconds:  dogActionTrigger.waitTime, act:  new System.Action(object:  new Dog.<>c__DisplayClass1_0(), method:  System.Void Dog.<>c__DisplayClass1_0::<Show>b__0()));
    }
    public void Sleep(bool isSleep)
    {
        this.animator.SetBool(name:  "IsSleep", value:  isSleep);
    }
    public void Hide()
    {
        this.animator.SetTrigger(name:  "Hide");
    }
    public Dog()
    {
    
    }

}
