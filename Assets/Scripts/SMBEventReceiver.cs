using UnityEngine;
public class SMBEventReceiver : StateMachineBehaviour
{
    // Fields
    public UnityEngine.Events.UnityEvent onStateEnter;
    public UnityEngine.Events.UnityEvent onStateExit;
    public UnityEngine.Events.UnityEvent onStateUpdate;
    public UnityEngine.Events.UnityEvent onStateMove;
    public UnityEngine.Events.UnityEvent onStateIK;
    
    // Methods
    public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.onStateEnter.Invoke();
    }
    public override void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.onStateExit.Invoke();
    }
    public override void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.onStateUpdate.Invoke();
    }
    public override void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.onStateMove.Invoke();
    }
    public override void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
    {
        this.onStateIK.Invoke();
    }
    public SMBEventReceiver()
    {
    
    }

}
