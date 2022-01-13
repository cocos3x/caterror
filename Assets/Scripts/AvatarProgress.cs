using UnityEngine;
public sealed class AvatarProgress : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text progressText;
    private GaugeX gauge;
    private UnityEngine.RectTransform iconPivot;
    private AnimationEventReceiver animationEventReceiver;
    
    // Methods
    public void Show(int prev, int stage, AvatarData avatarData, System.Action callback)
    {
        AvatarProgress.<>c__DisplayClass4_0 val_1 = new AvatarProgress.<>c__DisplayClass4_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        this.gameObject.SetActive(value:  true);
        UnityEngine.RectTransform val_4 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  avatarData.GetIconPrefab(), parent:  this.iconPivot);
        float val_6 = UnityEngine.Mathf.InverseLerp(a:  (float)prev, b:  (float)avatarData.value, value:  (float)stage - 1);
        .from = val_6;
        val_6 = val_6 * 100f;
        val_6 = val_6 + 0.001f;
        string val_8 = (int)val_6.ToString() + "%"("%");
        .to = UnityEngine.Mathf.InverseLerp(a:  (float)prev, b:  (float)avatarData.value, value:  (float)stage);
        this.animationEventReceiver.onEvent1.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AvatarProgress.<>c__DisplayClass4_0::<Show>b__0()));
    }
    public AvatarProgress()
    {
    
    }

}
