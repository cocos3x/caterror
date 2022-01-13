using UnityEngine;
public sealed class ContinueDialogManager : DialogManagerParent
{
    // Fields
    private static readonly string YesCallbackTag;
    private static readonly string NoCallbackTag;
    private UnityEngine.UI.Image gauge;
    private UnityEngine.UI.Button noButton;
    private bool isYes;
    private UnityEngine.Coroutine gaugeCoroutine;
    
    // Methods
    private void Awake()
    {
        null = null;
        this.gaugeCoroutine = MonoBehaviourExtensions.CallLerpRealtime(monoBehaviour:  this, duration:  Const.ContinuableTime, act:  new System.Action<System.Single>(object:  this, method:  System.Void ContinueDialogManager::<Awake>b__6_0(float t)), callback:  new System.Action(object:  this, method:  public System.Void ContinueDialogManager::OnNo()));
        SingletonMonoBehaviour<BackButtonManager>.Instance.SetAction(action:  new System.Action(object:  this, method:  System.Void ContinueDialogManager::<Awake>b__6_1()));
    }
    public void OnYes()
    {
        if(true != 0)
        {
                return;
        }
        
        this.isYes = true;
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction(isPressedBackButton:  false);
    }
    public void OnNo()
    {
        if(true != 0)
        {
                return;
        }
        
        SingletonMonoBehaviour<BackButtonManager>.Instance.PopAction(isPressedBackButton:  false);
    }
    protected override void Hide()
    {
        this.Hide();
        this.OnHided();
    }
    public void OnHided()
    {
        UnityEngine.Coroutine val_2 = MonoBehaviourExtensions.CallWaitForOneFrame(monoBehaviour:  this, act:  new System.Action(object:  this, method:  System.Void ContinueDialogManager::<OnHided>b__10_0()));
    }
    public static void ShowDialog(System.Action yesCallback, System.Action noCallback)
    {
        ContinueDialogManager.<>c__DisplayClass11_0 val_1 = new ContinueDialogManager.<>c__DisplayClass11_0();
        if(val_1 != null)
        {
                .yesCallback = yesCallback;
        }
        else
        {
                mem[16] = yesCallback;
        }
        
        .noCallback = noCallback;
        DialogManager.ShowDialog(showAction:  new System.Action(object:  val_1, method:  System.Void ContinueDialogManager.<>c__DisplayClass11_0::<ShowDialog>b__0()), category:  0);
    }
    public ContinueDialogManager()
    {
    
    }
    private static ContinueDialogManager()
    {
        ContinueDialogManager.YesCallbackTag = "ContinueDialogYesCallback";
        ContinueDialogManager.NoCallbackTag = "ContinueDialogNoCallback";
    }
    private void <Awake>b__6_0(float t)
    {
        float val_4 = 1f;
        val_4 = val_4 - t;
        this.gauge.fillAmount = val_4;
        if(t < 0.4f)
        {
                return;
        }
        
        if(this.noButton.gameObject.activeInHierarchy != false)
        {
                return;
        }
        
        this.noButton.gameObject.SetActive(value:  true);
    }
    private void <Awake>b__6_1()
    {
        MonoBehaviourExtensions.SafeStopCoroutine(monoBehaviour:  this, c:  this.gaugeCoroutine);
        goto typeof(ContinueDialogManager).__il2cppRuntimeField_168;
    }
    private void <OnHided>b__10_0()
    {
        var val_3;
        var val_4;
        string val_5;
        var val_6;
        DialogManager.HideDialog();
        val_3 = null;
        if(this.isYes != false)
        {
                val_4 = null;
        }
        else
        {
                val_6 = null;
            val_5 = 1152921504946360328;
        }
        
        LocalCacheManager.Load<System.Action>(tag:  val_5).Invoke();
        SingletonMonoBehaviour<TransitionManager>.Instance.UnloadScene(scene:  9);
    }

}
